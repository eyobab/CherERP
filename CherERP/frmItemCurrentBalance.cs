using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GridPrintPreviewLib;
using Excel = Microsoft.Office.Interop.Excel;

namespace Belayab
{
    public partial class frmItemCurrentBalance : Form
    {
        clsUtility objUtility = new clsUtility();
        public frmItemCurrentBalance()
        {
            InitializeComponent();
        }

        private void itemCurrentBalanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemCurrentBalanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stosaReports);

        }

        private void frmItemCurrentBalance_Load(object sender, EventArgs e)
        {
           
      
            // TODO: This line of code loads data into the 'stosaReports.ItemCurrentBalance' table. You can move, or remove it, as needed.
            this.tableAdapterManager.Connection = clsData.connBel;
            itemCurrentBalanceTableAdapter.Connection = clsData.connBel;

            // this.itemCurrentBalanceTableAdapter.Fill(this.stosaReports.ItemCurrentBalance);

        }

        public void fillByItem(string itemID)
        {

            this.itemCurrentBalanceTableAdapter.FillByItem(this.stosaReports.ItemCurrentBalance,itemID);


        }

        public void fillByStore()
        {

            this.itemCurrentBalanceTableAdapter.FillByStore(this.stosaReports.ItemCurrentBalance, clsVariables.sStore);

      
        }

       
     
        private void toolStripButtonShowAll_Click(object sender, EventArgs e)
        {
            this.itemCurrentBalanceTableAdapter.Fill(this.stosaReports.ItemCurrentBalance);
        }

        private void toolStripButtonCurLoc_Click(object sender, EventArgs e)
        {
            fillByStore();
        }

        private void toolStripTextBoxFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTextBoxFind.Text != "")
                    itemCurrentBalanceBindingSource.Filter = "Description Like '%" + toolStripTextBoxFind.Text + "%' Or ItemID Like '%" + toolStripTextBoxFind.Text + "%'"; 
                else
                    itemCurrentBalanceBindingSource.Filter = "";

                toolStripTextBoxFind.Focus();
            }
            catch (Exception ex) {

            }
        }

        public void fillAll()
        {
            this.itemCurrentBalanceTableAdapter.FillByStocked(this.stosaReports.ItemCurrentBalance, clsVariables.sStore);

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {

            GridPrintDocument doc = new GridPrintDocument(this.itemCurrentBalanceDataGridView, this.itemCurrentBalanceDataGridView.Font, true);
            doc.DocumentName = "Item Balances";
            doc.DrawCellBox = true;
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();
            doc.Dispose();
            doc = null;
            /*
            GridPrintDocument doc = new GridPrintDocument(this.itemCurrentBalanceDataGridView, this.itemCurrentBalanceDataGridView.Font, true);
            doc.DocumentName = "Stock Balances ";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "Print Preview Dialog";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            float scale = doc.CalcScaleForFit();
            doc.ScaleFactor = scale;

            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Location = new Point(29, 29);
            printPreviewDialog.Name = "PrintPreviewDialog1";
            printPreviewDialog.UseAntiAlias = true;
            printPreviewDialog.Document = doc;
            printPreviewDialog.ShowDialog();

            doc.Dispose();
            doc = null;
            */
        }

private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String strFileName = "Export_Item_Balance" + cboShow.Text + "_From_" + DateTime.Parse(dtFromToolStripTextBox.Text).ToString("ddMMMyyyy") +
            //                  "_To_" + dateTimeTo.Value.ToString("ddMMMyyyy");

            String strFileName = "Export_Item_Balance_" + DateTime.Today.ToString("ddMMMyyyy");
            objUtility.ExportToExcel(itemCurrentBalanceDataGridView, strFileName);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = "Balance Export.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                rng.NumberFormat = "@";

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                this.itemCurrentBalanceDataGridView.ClearSelection();

                // Open the newly saved excel file
                if (System.IO.File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            this.itemCurrentBalanceDataGridView.SelectAll();
            DataObject dataObj = this.itemCurrentBalanceDataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnOpenExtended_Click(object sender, EventArgs e)
        {

            frmItemsList f = new frmItemsList();
            Program.mainFrm.OpenFrm(f);

        /*

            DataGridView dv = itemCurrentBalanceDataGridView;
            frmItemsList fil = new frmItemsList();
            fcb.fillByItem(dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString()); 

    */
        }

       
    }
}





