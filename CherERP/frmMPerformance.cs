using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Belayab
{
    public partial class frmMPerformance : Form
    {
        clsUtility objUtility = new clsUtility();
        string fltr = "", newFltr = "";

        public frmMPerformance()
        {
            InitializeComponent();
        }

       
        private void frmMPerformance_Load(object sender, EventArgs e)
        {
            dtFromToolStripTextBox.Text = string.Format("{0: MM/dd/yyyy}", DateTime.Now.AddDays(-30));
            dtToToolStripTextBox.Text = string.Format("{0: MM/dd/yyyy}", DateTime.Now);

            this.getMaintenancePerfomanceTableAdapter.Connection = clsData.connBel;
            this.getMaintenancePerfomanceListTableAdapter.Connection = clsData.connBel;
          
            cboShow.SelectedIndex = 0;

            //List of employees combobox
            string strSQL = "Select Distinct EmployeeId,EmployeeName From Employees Order by EmployeeName";
            //   objUtility.fillComboValues(requestedByComboBox, strSQL);
            objUtility.AddComboValues(approvedByComboBox, strSQL,"EmployeeName");
           //Testing 
            approvedByComboBox.DisplayMember = "EmployeeName";

            approvedByComboBox.SelectedIndex = approvedByComboBox.Items.Count - 1;

           

        }



        private void fillToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.getMaintenancePerfomanceTableAdapter.Fill(this.belayAbVMaintain.GetMaintenancePerfomance, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtFromToolStripTextBox.Text + " 00:00:00", typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtToToolStripTextBox.Text + " 23:59:59", typeof(System.DateTime))))), clsVariables.sStore);

                this.getMaintenancePerfomanceListTableAdapter.Fill(this.belayAbVMaintain.GetMaintenancePerfomanceList, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtFromToolStripTextBox.Text + " 00:00:00", typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtToToolStripTextBox.Text + " 23:59:59", typeof(System.DateTime))))), clsVariables.sStore);

                cboShow_SelectedIndexChanged(null, null);

                //DataGridViewCellStyle style = new DataGridViewCellStyle();
                //style.BackColor = Color.Blue;
                //getMaintenancePerfomanceDataGridView.Rows[0].DefaultCellStyle = style;

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            dtFromToolStripTextBox.Text = dateTimeFrom.Value.ToShortDateString();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            dtToToolStripTextBox.Text = dateTimeTo.Value.ToShortDateString();
        }

        private void frmMPerformance_Resize(object sender, EventArgs e)
        {
            getMaintenancePerfomanceListDataGridView.Width = this.Width;
            getMaintenancePerfomanceListDataGridView.Height = this.Height - getMaintenancePerfomanceListDataGridView.Top-100;
        }

        private void cboShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPerformanceList();

        }

        private void getMaintenancePerfomanceListDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Program.showWorkOrder(getMaintenancePerfomanceListDataGridView.Rows[getMaintenancePerfomanceListDataGridView.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);
        }

        private void approvedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterPerformanceList();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String strFileName = "Export_" + cboShow.Text + "_From_" + DateTime.Parse(dtFromToolStripTextBox.Text).ToString("ddMMMyyyy") +
                     "_To_" + dateTimeTo.Value.ToString("ddMMMyyyy");

            objUtility.ExportToExcel(getMaintenancePerfomanceDataGridView, strFileName);
        }

        private void filterPerformanceList()
           {
            switch (cboShow.SelectedIndex)
            {
                case 1:
                    fltr = "[Date In] >= '" + dtFromToolStripTextBox.Text + " 00:00:00 ' And [Date In] <= '" + dtToToolStripTextBox.Text + " 23:59:59'";
                    break;
                case 2:
                     fltr = "[Date Out] >= '" + dtFromToolStripTextBox.Text + " 00:00:00' And [Date Out] <= '" + dtToToolStripTextBox.Text + " 23:59:59'";
                    break;
                case 3:
                    fltr = "[Date in] >= '" + dtFromToolStripTextBox.Text + " 00:00:00' And  [Date Out] <= '" + dtToToolStripTextBox.Text + " 23:59:59'";
                    break;
                default:
                    fltr = "";
                    break;
            }

            if (fltr != "")
            {
                if (approvedByComboBox.Text != "All")
                    newFltr = " And ApprovedBy='" + approvedByComboBox.Text + "'";
            }
            else
                if (approvedByComboBox.Text != "All")
                    newFltr = " ApprovedBy='" + approvedByComboBox.Text + "'";


            getMaintenancePerfomanceListBindingSource.Filter = fltr + newFltr;

            lblCount.Text = "Count: " + getMaintenancePerfomanceListDataGridView.Rows.Count.ToString();

            fltr = "";
            newFltr = "";


        }
              
    }  
}
