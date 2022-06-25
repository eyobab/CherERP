using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmInvoicesHome : Form
    {

        clsUtility objUtility = new clsUtility();
        clsData objData = new clsData();
        public frmInvoicesHome()
        {
            InitializeComponent();
        }


        private void frmInvoicesHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbInvoices.Invoices' table. You can move, or remove it, as needed.
            string strSQL = "Select EmployeeID, EmployeeName From Employees Order by EmployeeName";
            objUtility.fillComboValues(SalesPersonId, strSQL);
            SalesPersonId.DisplayMember = "EmployeeName";
            SalesPersonId.ValueMember = "EmployeeID";

            this.invoicesTableAdapter.Connection = clsData.connBel;
            this.invoicesTableAdapter.Fill(this.belayAbInvoices.Invoices, clsVariables.sStore);

        }

        private void invoicesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string iFltr = invoicesDataGridView.Rows[invoicesDataGridView.CurrentCell.RowIndex].Cells["InvoiceNo"].Value.ToString().Trim();
            frmInvoices finv = new frmInvoices(iFltr);
            Program.mainFrm.OpenFrm(finv);

        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {
            frmInvoices finv = new frmInvoices();
            Program.mainFrm.OpenFrm(finv);
            finv.tooStripAddnew_Click(null, null);

        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            this.invoicesTableAdapter.Fill(this.belayAbInvoices.Invoices, clsVariables.sStore);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string strfilterField = "InvoiceNo";
            objData.filterData(invoicesBindingSource, strfilterField, txtFind.Text);

          if (invoicesDataGridView.Rows.Count == 0)
            {
                strfilterField = "Invoice_ref";
                objData.filterData(invoicesBindingSource, strfilterField, txtFind.Text);
            }

        }
    }
}
