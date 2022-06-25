using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;

namespace Belayab
{
    public partial class frmInvoicesCredit : Form
    {
        clsData objData = clsData.Instance;
        DataGridView dv;
        clsUtility objUtility = new clsUtility();
        clsNumbers objNumber = new clsNumbers();
    
        bool addingNew,qtyEdited;

        private int  oldQty;

        private decimal sum = 0, vatSum = 0, fval = 0, vat, totvat;

        public string fltr = "", strSQL;

        int order;

        decimal cusLoan = 0, cusAdvance = 0;
       
        public frmInvoicesCredit()
        {
            InitializeComponent();
            
        }

        public frmInvoicesCredit(string strInvNo)
        {
            InitializeComponent();
            fltr = strInvNo;
            
        }
        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.invoices_CreditTableAdapter.Update(this.belayAbInvoices.Invoices_Credit);

        }

        private void frmInvoices_Load(object sender, EventArgs e)
        {
            
            try
            {
                setAdapterConnectionString();


                string strSQL;
                strSQL = "Select EmployeeID, EmployeeName From Employees Order by EmployeeName";
                objUtility.fillComboValues(salesPersonIdComboBox, strSQL);
                objUtility.fillComboValues(cashierComboBox, strSQL);
                objUtility.fillComboValues(checkedByComboBox, strSQL);


                // TODO: This line of code loads data into the 'belayAbInvoices.CustomerList' table. You can move, or remove it, as needed.
                this.customerListTableAdapter.Fill(this.belayAbInvoices.CustomerList);
                // TODO: This line of code loads data into the 'belayAbInvoices.paymentTypes' table. You can move, or remove it, as needed.
                this.paymentTypesTableAdapter.Fill(this.belayAbInvoices.paymentTypes);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.
                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                
                // TODO: This line of code loads data into the 'belayAbInvoices.Invoices_Credit' table. You can move, or remove it, as needed.
                this.invoices_CreditTableAdapter.Fill(this.belayAbInvoices.Invoices_Credit);

               // TODO: This line of code loads data into the 'belayAbInvoices.InvoiceDetails_Credit' table. You can move, or remove it, as needed.
                this.invoiceDetails_CreditTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails_Credit);

                dv = invoiceDetailsDataGridView;

                //invoicesBindingSource.Filter = fltr;

               

                calculateEveryTotal();
                setAdvanceAndLoan();

                objData.resetChanges(dv);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        private void toolstrDetailSave_Click(object sender, EventArgs e)
        {
            try
            {

                saveDetails();
                calculateEveryTotal();
                saveMain();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
            detailNavAddnew.Enabled = true;
        }

        }


        private void SetUnit(int Rx)
        {
            try
            {
                SqlCommand comm = new SqlCommand();               
                comm.Connection = clsData.connBel;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "GetUnit '" + dv.Rows[Rx].Cells["ItemID"].Value.ToString().Trim() + "'";
                dv.Rows[Rx].Cells["Units"].Value = comm.ExecuteScalar().ToString();
                comm = null;

                GetInstock(Rx);

            }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        
       

        private void calculateTotal(int row)
        {
            double price = 0, tot = 0;
            int qty = 0;

            try
            {
                dv = invoiceDetailsDataGridView;

                if (row < dv.Rows.Count )
                {
                    if (int.TryParse(dv.Rows[row].Cells["Qty"].Value.ToString(), out qty) &&
                         double.TryParse(dv.Rows[row].Cells["UnitPrice"].Value.ToString(), out price))
                    
                        tot = price * qty;

                    dv.Rows[row].Cells["TotalPrice"].Value = tot;
                }

            }

      catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void calculateEveryTotal()
        {
            try
            {
                int k;
                
                for (k = 0; k < dv.Rows.Count; k++)
                  calculateTotal(k);
               
                
                for (k = 0; k < dv.Rows.Count; k++)
                    SetUnit(k);

                
                calculateGrandTotal();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void calculateGrandTotal()
        {

            sum = vatSum = fval = 0;

            dv = this.invoiceDetailsDataGridView;

          try
            {
             for (int k = 0; k < dv.Rows.Count; k++)
                {
                    if (decimal.TryParse(dv.Rows[k].Cells["TotalPrice"].Value.ToString(), out fval))
                    {
                        sum += fval;
                        if (objData.getFieldValue("IsItemTaxed '" + dv.Rows[k].Cells["ItemID"].Value.ToString() + "'") == "True")
                            vatSum += fval;
                    }
                }



                vat = clsVariables.VATAmt * vatSum;
                totvat = vat + sum;
               
                txtTotal.Text = string.Format("{0: Br #,##0.00}", sum);
                txtVAT.Text = string.Format("{0: Br #,##0.00}", vat);
                txtTotWithVAT.Text = string.Format("{0: Br #,##0.00}", totvat);
              
                 totCreditAmtTextBox.Text = totvat.ToString();
               

            }

       catch (Exception ex) { MessageBox.Show(ex.Message); }

           
        }

     

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }

      

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }

       

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }

        private void invoiceDetailsDataGridView_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                dv = this.invoiceDetailsDataGridView;

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].Name == "Qty" || dv.Columns[e.ColumnIndex].Name == "UnitPrice")
                {
                    calculateTotal(e.RowIndex);
                    calculateGrandTotal();

                //    if (!qtyEdited) oldQty = objData.inStock(dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString().Trim(),"GetNetItemsInstock");

                    dv.Rows[e.RowIndex].Cells["InStock"].Value = oldQty - int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());
                }
                else if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {

                    SetUnit(e.RowIndex);
                    GetInstock(e.RowIndex);

                    dv.Rows[e.RowIndex].Cells["UnitPrice"].Value =
                    objData.getUnitPrice(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());

                    dv.Rows[e.RowIndex].Cells["InStock"].Value = objData.inStock(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), "GetNetItemsInStock", clsVariables.sStore)
                       - int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                }

                dv.Rows[e.RowIndex].ErrorText = "";
            }

            catch (Exception ex) 
            {
               if (e.RowIndex >= 0) dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }
        }

        private void invoiceDetailsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float val;
            DataGridView dv = invoiceDetailsDataGridView;
            try
            {

                dv.Rows[e.RowIndex].ErrorText = "";
                if (dv.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice") 
                {
                    if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                        e.Cancel = true;
                    }


                }

                if (dv.Columns[e.ColumnIndex].DataPropertyName == "Qty")
                {
                   // GetInstock(e.RowIndex);

                    if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                        e.Cancel = true;
                    }
                    else
                        if (dv.Rows[e.RowIndex].Cells["InStock"].Value != null && oldQty <
                            int.Parse(e.FormattedValue.ToString()) && qtyEdited)
                        {
                            dv.Rows[e.RowIndex].Cells["Qty"].ErrorText = "No sufficient Quantity available in stock for this item!";
                           
                        }
                        else
                        {
                            dv.Rows[e.RowIndex].Cells["Qty"].ErrorText = "";
                            qtyEdited = false;
                
                        }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }


        private void setAdapterConnectionString()
        {

            customerListTableAdapter.Connection = clsData.connBel;
            paymentTypesTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            invoiceDetails_CreditTableAdapter.Connection = clsData.connBel;
            invoices_CreditTableAdapter.Connection = clsData.connBel;

        }

       private void GetInstock(int Rx)
       {
           try
           {

               dv = invoiceDetailsDataGridView;
               objData.GetInstock(dv, Rx, "GetNetItemsInstock", clsVariables.sStore);

           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
                

       }

        private void tooStripAddnew_Click(object sender, EventArgs e)
        {
            invoicesBindingSource.AddNew();

            if (DeleteWrap.Text == "Delete")
            {
                DeleteWrap.Text = "Cancel";
             }
             detailNavigtor.Enabled = false;
             MainNavFirst.Enabled = false;
             MainNavPrevious.Enabled = false;
             MainNavPosition.Enabled = false;
             MainNavAddnew.Enabled = false;
             txtAdvance.Text = "";
             txtBalance.Text = "";
             txtCredits.Text = "";
             txtLoan.Text = "";
             txtPayments.Text = "";
             invoiceDateDateTimePicker.Text = "";
             invoiceDateDateTimePicker.Value = DateTime.Now;
             payTypeIdComboBox.SelectedValue = "Credit";
             payTypeIdComboBox.Text = "Credit";
             customerIdComboBox.Focus();

        }

        private void DeleteWrap_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteWrap.Text == "Delete")
                {
                    if (MessageBox.Show("All Items in this invoice will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        invoicesBindingSource.RemoveCurrent();
                        saveMain();
                    }
                }
                else
                {

                    invoicesBindingSource.RemoveCurrent();
                    saveMain();

                    DeleteWrap.Text = "Delete";
                    detailNavigtor.Enabled = true;
                    MainNavFirst.Enabled = true;
                    MainNavPrevious.Enabled = true;
                    MainNavPosition.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void saveDetails()
        {
            try
            {
                if (dv == null) dv = invoiceDetailsDataGridView;

                dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);

                this.invoiceDetailsBindingSource.EndEdit();
                this.invoiceDetails_CreditTableAdapter.Update(this.belayAbInvoices.InvoiceDetails_Credit);

                this.invoiceDetails_CreditTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails_Credit);

                detailNavAddnew.Enabled = clsVariables.allow;

                detailNavDelete.Text = "- Delete";

                 calculateEveryTotal();
                 
                 setAdvanceAndLoan();

                 objData.resetChanges(dv);
               

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message,"Stosa");
               detailNavAddnew.Enabled = true;

            }

        }

        private void saveMain()
        {
            try
            {

                this.Validate();
                this.invoicesBindingSource.EndEdit();
                this.invoices_CreditTableAdapter.Update(this.belayAbInvoices.Invoices_Credit);

                detailNavigtor.Enabled = true;
                MainNavAddnew.Enabled = true;
                DeleteWrap.Text = "Delete";
                MainNavAddnew.Enabled = clsVariables.allow;         
                calculateEveryTotal();

                setAdvanceAndLoan();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); 
            }



        }

        private void saveBoth()
        {
            saveDetails();
            saveMain();
        }



        private void itemsReceivedBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            saveBoth();
        }

        private void itemsReceivedDetailsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            saveDetails();
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

            saveDetails();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            detailNavigtor.Enabled = false;

        }

              
        private void invoicesBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            saveBoth();
            
        }

        

        private void invoiceDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (chkAuto.Checked && invoiceNoTextBox.Text == "")
                invoiceNoTextBox.Text = objNumber.getNextAutoNumber("Credit");


            saveMain();
            detailNavigtor.Enabled = true;
        }

        private void toolStrDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                  if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        invoiceDetailsBindingSource.RemoveCurrent();
                        saveDetails();
                  //      this.invoices_CreditTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails_Credit);

                    }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void invoiceDetailsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message,"Data Error"); 
        }


        private void paymentRecievedLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrPrintInvoice_Click(object sender, EventArgs e)
        {
         
            rptVATInvoiceCredit  rpt = new rptVATInvoiceCredit();

            rpt.DataDefinition.FormulaFields["invTot"].Text = sum.ToString();
            rpt.DataDefinition.FormulaFields["vatAmt"].Text = vat.ToString();


            frmReportsViewer frmv = new frmReportsViewer();
            string strSQL = "Select * from VATInvoiceViewCredit Where InvoiceNo ='" +
                invoiceNoTextBox.Text + "'";
            frmv.SetReport(rpt, strSQL, "VATInvoiceView");

            Program.mainFrm.OpenOverFrm(frmv);
        }

     
        private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calculateEveryTotal();
            setAdvanceAndLoan();

        }

        private void invoicesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (belayAbInvoices.Invoices_Credit.GetChanges()!=null)
                if (belayAbInvoices.Invoices_Credit.GetChanges().Rows.Count > 0) saveMain();

        }

        private void invoiceDetailsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
 //           if (belayAbInvoices.InvoiceDetails_Credit.GetChanges() != null) saveDetails();
        }


        private void setAdvanceAndLoan()
        {
            if (customerIdComboBox.SelectedValue !=null)
            {
                decimal cred=0, payd=0;

                cusAdvance = objData.GetCustomerPayments("GetAdvancePayments", customerIdComboBox.SelectedValue.ToString());
                cusLoan = objData.GetCustomerPayments("GetLoanpayments",customerIdComboBox.SelectedValue.ToString());

                objData.GetCustomerCredPayments(customerIdComboBox.SelectedValue.ToString(),
                   out cred, out payd);


                txtAdvance.Text = string.Format("{0: #,##0.00}", cusAdvance);
                txtLoan.Text = string.Format("{0: #,##0.00}", cusLoan);
                txtCredits.Text = string.Format("{0: #,##0.00}", cred);
                txtPayments.Text = string.Format("{0: #,##0.00}", payd);

                decimal balance = cred - (payd +cusAdvance + cusLoan) ;

                txtBalance.Text = string.Format("{0:Br   #,##0.00}", balance);

        }
        }

       

        private void detailNavAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                dv = invoiceDetailsDataGridView;
                addingNew = true;
                invoiceDetailsBindingSource.AddNew();
                detailNavAddnew.Enabled = false;
                
                int i =0;

                while (dv.Columns[i].Name != "ItemID")
                    i++;

                dv.CurrentCell = dv[i , dv.CurrentCell.RowIndex];
       
                if (detailNavDelete.Text == "- Delete") detailNavDelete.Text = "Cancel";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Unkown"); }
        }

        private void invoiceDetailsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {

                oldQty = objData.inStock(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), "GetNetItemsInStock", clsVariables.sStore);

                if (dv.Columns[e.ColumnIndex].DataPropertyName == "Qty")
                {

                    //   label10.Text = dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString();

                    if (dv.Rows[e.RowIndex].Cells["Qty"].Value != null && bool.Parse(dv.Rows[e.RowIndex].Cells["Edited"].Value.ToString()) == false)
                        oldQty = oldQty + int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());
                    else
                        oldQty = int.Parse(dv.Rows[e.RowIndex].Cells["InStock"].Value.ToString()) + int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                    dv.Rows[e.RowIndex].Cells["Edited"].Value = true;
                }
            }
            catch (Exception ex) { 
                 }

        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers f = new frmCustomersSuppliers(this);
            Program.mainFrm.OpenFrm(f);
            f.txtFind.Text = customerIdComboBox.Text;
            f.tabSupplier_Customer.SelectedIndex = 1;
        }

        public void updateCustomerList()
        {
           string curCustomer = customerIdComboBox.Text;

            belayAbInvoices.CustomerList.Clear();
            customerListTableAdapter.Fill(belayAbInvoices.CustomerList);
            customerIdComboBox.Refresh();

            customerIdComboBox.Text = curCustomer;

        }

        private void invoiceDetailsDataGridView_Sorted(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }


        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
                invoiceNoTextBox.ReadOnly = true;
            else
                invoiceNoTextBox.ReadOnly = false;

        }

        private void mnuRefreshItems_Click(object sender, EventArgs e)
        {
refreshItems();
        }

        private void invoiceDetailsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //First Get all descriptions for the sort order
            if (dv.Columns[e.ColumnIndex].Name == "ItemID")
            {
                setAllDescriptions();

                objUtility.sortGrid(dv, order, "HD");
                order = order % 2 + 1;
            }
        }
      
        private void setDesc(int Rx)
        {
            try
            {
                strSQL = "Select Description from Items Where ItemID = '" + dv.Rows[Rx].Cells["ItemID"].Value.ToString().Trim() + "'";
                dv.Rows[Rx].Cells["HD"].Value = objData.getStringValue(strSQL);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void setAllDescriptions()
        {
            try
            {
                int k;

                if (dv == null) dv = invoiceDetailsDataGridView;


                for (k = 0; k < dv.Rows.Count; k++)
                    setDesc(k);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void invoiceDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            objUtility.makeCellEditable(e);

        }

        private void mnuEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                clsData.pNum = dv.CurrentCell.Value.ToString().Trim();
                 Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }
            catch (Exception ex)
            {
                Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }
        }

        private void allItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList("Credit Invoice",this);
            Program.mainFrm.OpenOverFrm(f);
        }

        private void mnuSetPrices_Click(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting();
            Program.mainFrm.OpenFrm(f);

        }
       
          private void refreshItems()
        {
            this.belayAbSSDataSet.PartNumDescription.Clear();
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
        }


        public void selectItem(string pNum)
        {
            try
            {
                refreshItems();
                dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value = pNum;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmInvoicesCredit_Activated(object sender, EventArgs e)
        {
            if (clsData.trNo != "")
            {
                int res = invoicesBindingSource.Find("InvoiceNo", clsData.trNo);
                if (res > -1) invoicesBindingSource.Position = res;
                clsData.trNo = "";
            }

            refreshItems();
                    
        }

        private void frmInvoicesCredit_Shown(object sender, EventArgs e)
        {
            payTypeIdComboBox.Enabled = false;
        }

     

    }
}

