using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;
using CrystalDecisions.CrystalReports.Engine;
using System.Threading;

namespace Belayab

{
    public partial class frmCreditPayments : Form
    {
        clsData objData = clsData.Instance;
        DataGridView dvIn, dvPayment;
        int ticks=0;
        bool addingNew;

        string[] creditP;
        string creditPayers;
 
        public frmCreditPayments()
        {
            InitializeComponent();
        }

       

        private void frmCreditPayments_Load(object sender, EventArgs e)
        {
   
            try
            {

                setAdapterConnectionString();


                creditP = objData.getColumnRecords("Select CustomerID From Invoice_Credit_Payers");

                if (creditP.Length > 0) creditPayers += "'" + creditP[0] + "'";

                if (creditP.Length > 1)
                    for (int i = 1; i < creditP.Length; i++)
                        creditPayers += ",'" + creditP[i] + "'";



                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbInvoices.CreditPayments' table. You can move, or remove it, as needed.
                this.creditPaymentsTableAdapter.Fill(this.belayAbInvoices.CreditPayments);
                // TODO: This line of code loads data into the 'belayAbInvoices.Invoices_Credit' table. You can move, or remove it, as needed.
                this.invoices_CreditTableAdapter.Fill(this.belayAbInvoices.Invoices_Credit);

                this.customersTableAdapter.Fill(this.belayAbInvoices.Customers);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.


                dvIn = invoicesDataGridView;
                dvPayment = creditPaymentsDataGridView;
              
                calculateAllCredits();

            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message); 
            }



        }
        private void setAdapterConnectionString()
        {

            creditPaymentsTableAdapter.Connection = clsData.connBel;
            invoices_CreditTableAdapter.Connection = clsData.connBel;
            customersTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
           


        }

        private void chkShowallInvoices_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkShowallInvoices.Checked)
            {
                invoices_CreditBindingSource.Filter = null;
                invoiceLabel.Text = "Customer's Invoice History";
            }
            else
            {
                invoices_CreditBindingSource.Filter = "PayTypeId = 'Credit'";
                invoiceLabel.Text = "Customer's Credit Invoice History";
            }
           
            
            calculateAllCredits();

        }

       

    
        private void calculateCredits(int row)
        {
          try
            {
               
                if (row < dvIn.Rows.Count)
                {

                    objData.GetCreditsAndPayments(dvIn, row);
                }

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        public void calculateAllCredits()
        {
            try
            {

                dvIn = invoicesDataGridView;
               
                int k;


                for (k = 0; k < dvIn.Rows.Count; k++)

                    calculateCredits(k);

                  calculateNetBalance();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void calculateNetBalance()
        {
            decimal sum = 0, fval = 0;

            if (dvIn == null) dvIn = invoicesDataGridView;
            try
            {
                for (int k = 0; k < dvIn.Rows.Count; k++)
                {

                    decimal.TryParse(dvIn.Rows[k].Cells["Balance"].Value.ToString(), out fval);
                    if (fval != null)
                        sum += fval;

                }

                txtNetBalance.Text = string.Format("{0: Br #,##0.00}", sum);
            }

            catch (Exception ex) { }


        }

        private decimal getInvoiceTotal()
        {
            decimal sum = 0, fval = 0;

            if (dvIn == null) dvIn = invoicesDataGridView;
            try
            {
                for (int k = 0; k < dvIn.Rows.Count; k++)
                {

                    decimal.TryParse(dvIn.Rows[k].Cells["Credits"].Value.ToString(), out fval);
                    if (fval != null)
                        sum += fval;

                }


            }

            catch (Exception ex) { }
            return sum;


        }

        private decimal getPaymentTotal()
        {
            decimal sum = 0, fval = 0;

            if (dvPayment == null) dvPayment = creditPaymentsDataGridView;
            try
            {
                for (int k = 0; k < dvPayment.Rows.Count; k++)
                {


                    decimal.TryParse(dvPayment.Rows[k].Cells["PayedAmount"].Value.ToString(), out fval);
                    if (fval != null)
                        sum += fval;

                }


            }

            catch (Exception ex) { }
            return sum;


        }

           
       
        private void paymentNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (getPaymentTotal() > getInvoiceTotal())
            {

                MessageBox.Show("Payed value is larger than Required\n for the invoice", "Stosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
               // dvPayment.CurrentCell.ErrorText = "This value is larger than Required\nfor the invoice";

                blinkCredits();

                txtNetBalance.Select();

            }
            else
              saveDetails();

        }

        private void CustomerNavigatorFindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomerNavigatorFindTextBox.Text !="") 
                customersBindingSource.Filter ="CustomerName Like '%" + CustomerNavigatorFindTextBox.Text+ "%'";
            else
            customersBindingSource.Filter = "";

        CustomerNavigatorFindTextBox.Focus();

        calculateAllCredits();

        }

      
        private void PaymentsNavigatorPrintItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveDetails();

                rptPaymentorLoan rpt = new rptPaymentorLoan();


                rpt.DataDefinition.FormulaFields["invTotal"].Text =
                    dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Credits"].Value.ToString().Trim();

                rpt.DataDefinition.FormulaFields[1].Text =
                     dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Payed"].Value.ToString();

                rpt.DataDefinition.FormulaFields[2].Text =
                    dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Balance"].Value.ToString();

                //Load the repot then
                frmReportsViewer frmv = new frmReportsViewer();
                string strSQL = "Select * from CreditPaymentView Where CashRecieptNo ='" +
                    creditPaymentsDataGridView.Rows[creditPaymentsDataGridView.CurrentCell.RowIndex].Cells["CashRecieptNo"].Value.ToString()
                    + "'";
                frmv.SetReport(rpt, strSQL, "CreditPaymentView");
                Program.mainFrm.OpenOverFrm(frmv);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void creditPaymentsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            decimal val;
            dvPayment = creditPaymentsDataGridView; 
         try
            {

                dvPayment.Rows[e.RowIndex].ErrorText = "";
                if (dvPayment.Columns[e.ColumnIndex].DataPropertyName == "PayedAmount")
                {

                    if (!decimal.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        
                        e.Cancel = true;
                        dvPayment.CurrentCell.ErrorText = "Value must be a non-negative number";
                    }

                    //else
                    //{
                    //    val = decimal.Parse(e.FormattedValue.ToString());
                    //   // decimal balance = decimal.Parse(dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Balance"].Value.ToString());
                    //    string bal = txtNetBalance.Text.Substring(3);
                    //    decimal balance = decimal.Parse(bal);
                    //    decimal pmt, invt;

                    //    pmt = getPaymentTotal();
                    //    invt = getInvoiceTotal();

                    //    //if (getPaymentTotal() > getInvoiceTotal())
                    //    //{

                    //    //    MessageBox.Show("This value is larger than Required\n for the invoice", "Stosa");
                    //    //    e.Cancel = true;
                    //    //    dvPayment.CurrentCell.ErrorText = "This value is larger than Required\nfor the invoice";

                    //    //    //dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Balance"].Selected = false;  
                    //    //    //  txtNetBalance.Select();

                    //    //    blinkCredits();

                    //    //    txtNetBalance.Select();

                    //    //}
                    //    else
                    //    {
                            txtNetBalance.ForeColor = Color.Black;
                            dvPayment.CurrentCell.ErrorText = "";
                        //}
                    //}
                }

             }
         
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }

        private void blinkCredits()
        {
            timer1.Interval = 500;
            timer1.Start();

            timer1_Tick(new object(), new EventArgs());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks < 10)
            {

                txtNetBalance.ForeColor = Color.Red;

                if (txtNetBalance.SelectedText.Length > 0)
                    txtNetBalance.SelectionLength = 0;
                else
                    txtNetBalance.SelectAll();

                //dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Balance"].Selected =
                //    !dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["Balance"].Selected;
                 ticks++;

            }
            else
            {
                timer1.Stop();
                ticks = 0;
                txtNetBalance.SelectionLength = 0;
            }
       }
               
        private void customersBindingSource_PositionChanged(object sender, EventArgs e)
        {

            dvPayment = creditPaymentsDataGridView;
            calculateAllCredits();

           paymentNav.Enabled = (dvIn.Rows.Count > 0);
        }

        private void paymentNavDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!addingNew)
                {
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        creditPaymentsBindingSource.RemoveCurrent();
                        saveDetails();
                    }
                }
                else
                {
                    creditPaymentsBindingSource.RemoveCurrent();
                    saveDetails();
                    addingNew = false;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void saveDetails()
        {
            creditPaymentsDataGridView.EndEdit();
            creditPaymentsBindingSource.EndEdit();
            creditPaymentsTableAdapter.Update(belayAbInvoices.CreditPayments);

            calculateAllCredits();
            calculateNetBalance();

            paymentNavAddnew.Enabled = clsVariables.allow;
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            addingNew = true;
            paymentNavAddnew.Enabled = false;
        }

        //private void calculateNetBalance()
        //{

        //    try
        //    {

        //        decimal totBal = 0;

        //        for (int k = 0; k <= dvIn.Rows.Count; k++)
        //            totBal = totBal + decimal.Parse(dvIn.Rows[k].Cells["Balance"].Value.ToString());

        //        txtNetBalance.Text = string.Format("{0:Br #,##0.00}", totBal);
        //    }
        //    catch (Exception ex) { }

        //}

        private void invoicesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            clsData.trNo = dvIn.Rows[dvIn.CurrentCell.RowIndex].Cells["InvoiceNo"].Value.ToString();
            frmInvoicesCredit f = new frmInvoicesCredit("");
            Program.mainFrm.OpenOverFrm(f);
           // f.Filter();
         
            

        }

        private void chkCreditPayersOnly_CheckStateChanged(object sender, EventArgs e)
        {

            
            if (chkCreditPayersOnly.Checked)
            {
               this.customersBindingSource.Filter = "CustomerId in (" + creditPayers + ")";
            }
            else
            {
                this.customersBindingSource.Filter = "";
            }


            calculateAllCredits();
        }

        

       

     


    }
}