using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;
namespace Belayab
{
    public partial class frmAdvanceLoan : Form
    {
        DataGridView dvAdv, dvLn;

        public frmAdvanceLoan()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.belayAbInvoices.Customers);

        }

        private void frmAdvanceLoan_Load(object sender, EventArgs e)
        {
            try
            {
                setAdapterConnectionString();
                // TODO: This line of code loads data into the 'belayAbInvoices.InvoiceAdvancePrepayments' table. You can move, or remove it, as needed.
                this.invoiceAdvancePrepaymentsTableAdapter.Fill(this.belayAbInvoices.InvoiceAdvancePrepayments);
                // TODO: This line of code loads data into the 'belayAbInvoices.CustomerLoans' table. You can move, or remove it, as needed.
                this.customerLoansTableAdapter.Fill(this.belayAbInvoices.CustomerLoans);
                // TODO: This line of code loads data into the 'belayAbInvoices.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.Fill(this.belayAbInvoices.Customers);

                dvAdv = invoiceAdvancePrepaymentsDataGridView;
                dvLn = customerLoansDataGridView;


                CalendarColumn col = new CalendarColumn();
                dvAdv.Columns["PaymentDate"].CellTemplate = col.CellTemplate;
                dvLn.Columns["LPaymentDate"].CellTemplate = col.CellTemplate;

            }  catch (Exception ex) { MessageBox.Show(ex.Message); }       

        }

        private void setAdapterConnectionString()
        {

            invoiceAdvancePrepaymentsTableAdapter.Connection = clsData.connBel;
            customerLoansTableAdapter.Connection = clsData.connBel;
            customersTableAdapter.Connection = clsData.connBel;


        }

        private void CustomerNavigatorFindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomerNavigatorFindTextBox.Text != "")
                customersBindingSource.Filter = "CustomerName Like '" + CustomerNavigatorFindTextBox.Text + "%'";
            else
                customersBindingSource.Filter = "";
        }

        private void AdvanceNavSave_Click(object sender, EventArgs e)
        {
            
               saveAdvance();

        }

        private void LoanNavSave_Click(object sender, EventArgs e)
        {
            saveLoan();
        }

        private void advanceNavPrint_Click(object sender, EventArgs e)
        {
            //Load the repot then

            frmReportsViewer frmv = new frmReportsViewer();
            rptAdvance rpt = new rptAdvance();
            string strSQL = "Select * from CustomerAdvancePaymentView Where ReceiptNumber ='" +
                invoiceAdvancePrepaymentsDataGridView.Rows[invoiceAdvancePrepaymentsDataGridView.CurrentCell.RowIndex].Cells["RecieptNo"].Value.ToString()
                + "'";
            frmv.SetReport(rpt, strSQL, "CustomerAdvancePaymentView");
            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void LoanNavPrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();
            rptAdvance rpt = new rptAdvance();
            string strSQL = "Select * from CustomerLoanView Where ReceiptNumber ='" +
                customerLoansDataGridView.Rows[customerLoansDataGridView.CurrentCell.RowIndex].Cells["ReceiptNumber"].Value.ToString()
                + "'";
            frmv.SetReport(rpt, strSQL, "CustomerAdvancePaymentView");
            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void AdvanceNavAdd_Click(object sender, EventArgs e)
        {
            invoiceAdvancePrepaymentsBindingSource.AddNew();

        }

        private void LoanNavAdd_Click(object sender, EventArgs e)
        {
            customerLoansBindingSource.AddNew();

        }

        private void AdvanceNavDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("The record will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        invoiceAdvancePrepaymentsBindingSource.RemoveCurrent();
                        saveAdvance();
                    }
            
              


               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void saveAdvance()
        {

            dvAdv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
            this.invoiceAdvancePrepaymentsBindingSource.EndEdit();
            invoiceAdvancePrepaymentsTableAdapter.Update(belayAbInvoices.InvoiceAdvancePrepayments);


        }

        private void LoanNavDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("The record will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    customerLoansBindingSource.RemoveCurrent();
                    saveLoan();
                }


            }
            catch (Exception ex) { }
        }

        private void saveLoan()
        {
            dvLn.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
            this.Validate();
            this.customerLoansBindingSource.EndEdit();
            this.customerLoansTableAdapter.Update(this.belayAbInvoices.CustomerLoans);


        }

        private void invoiceAdvancePrepaymentsDataGridView_Leave(object sender, EventArgs e)
        {
            dvAdv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }

        private void customerLoansDataGridView_Leave(object sender, EventArgs e)
        {
            dvLn.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }


       
    }
}