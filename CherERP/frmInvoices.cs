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
    public partial class frmInvoices : Form
    {
        
        clsData objData = clsData.Instance;
        DataGridView dv;
        clsUtility objUtility = new clsUtility();
        clsSecurity objSecurity = new clsSecurity();
        clsNumbers objNumber = new clsNumbers();

        bool addingNew = false, qtyEdited, rowmodified=false;
        bool saveOk = false;


        private int  oldQty;
        private Object wordamt ="";
        private decimal sum = 0, vatSum = 0, fval = 0, vat, totvat;

        private static string fltr = "";
            string  strSQL="";

        int order;

        decimal cusLoan = 0, cusAdvance = 0;

        public frmInvoices()
        {
            InitializeComponent();

        }

        public frmInvoices(string strInvNo)
        {
            InitializeComponent();
            fltr = strInvNo;

        }
        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.invoicesTableAdapter.Update(this.belayAbInvoices.Invoices);

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
                strSQL = "Select State,stateFor from States";
                objUtility.fillComboValues(curStateComboBox, strSQL);
               
                 // TODO: This line of code loads data into the 'belayAbBranchStore.Stores' table. You can move, or remove it, as needed.
                this.storesTableAdapter.Fill(this.belayAbBranchStore.Stores);
     
                // TODO: This line of code loads data into the 'belayAbSSDataSet.AllStates' table. You can move, or remove it, as needed.
                this.allStatesTableAdapter.Fill(this.belayAbSSDataSet.AllStates);
                // TODO: This line of code loads data into the 'belayAbInvoices.CustomerList' table. You can move, or remove it, as needed.
                this.customerListTableAdapter.Fill(this.belayAbInvoices.CustomerList);
                // TODO: This line of code loads data into the 'belayAbInvoices.paymentTypes' table. You can move, or remove it, as needed.
                this.paymentTypesTableAdapter.Fill(this.belayAbInvoices.paymentTypes);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.
                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbInvoices.Invoices' table. You can move, or remove it, as needed.
                
                 if (fltr=="")
                    this.invoicesTableAdapter.Fill(this.belayAbInvoices.Invoices,clsVariables.sStore);
                 else
                     this.invoicesTableAdapter.FillByInvNo(this.belayAbInvoices.Invoices,fltr);
         
                // TODO: This line of code loads data into the 'belayAbInvoices.InvoiceDetails' table. You can move, or remove it, as needed.
                this.invoiceDetailsTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails);
           

                this.allStatesTableAdapter.Fill(this.belayAbSSDataSet.AllStates);

                dv = invoiceDetailsDataGridView;

                //invoicesBindingSource.Filter = fltr;

                calculateEveryTotal();
                setAdvanceAndLoan();

                objData.resetChanges(dv);

                //this.Text = "Cash Sales Order";

                storeIDComboBox.Enabled = false;


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void toolstrDetailSave_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                saveDetails();
                saveMain();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            decimal price = 0, tot = 0;
            int qty = 0;
            try
            {
                dv = invoiceDetailsDataGridView;

                if (row < dv.Rows.Count)
                {
                    if (int.TryParse(dv.Rows[row].Cells["Qty"].Value.ToString(), out qty) &&
                         decimal.TryParse(dv.Rows[row].Cells["UnitPrice"].Value.ToString(), out price))
                        tot = price * qty;

                    dv.Rows[row].Cells["TotalPrice"].Value = tot;
                    sum += tot;
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
                //        string isTaxted = objData.getFieldValue("IsItemTaxed '" + dv.Rows[k].Cells["ItemID"].Value.ToString() + "'");
                        if (objData.getFieldValue("IsItemTaxed '" + dv.Rows[k].Cells["ItemID"].Value.ToString() + "'") == "True")
                            vatSum += fval;
                    }
                }



                vat = clsVariables.VATAmt * vatSum;
                totvat = vat + sum;

                totCreditAmtTextBox.Text = totvat.ToString();
                totCreditAmtTextBox1.Text = totvat.ToString();

                txtTotal.Text = string.Format("{0: Br #,##0.00}", sum);
                txtVAT.Text = string.Format("{0: Br #,##0.00}", vat);
                txtTotWithVAT.Text = string.Format("{0: Br #,##0.00}", totvat);

                string sTotVat = string.Format("{0: ##0.00}", totvat);
                string[] numInText = sTotVat.Split('.');


                string fullText, birrs, cents;
                birrs = objUtility.NumberToText(numInText[0].Trim());
                if (int.Parse(numInText[1].Trim().ToString()) == 0)
                {
                    fullText = birrs + " only.";

                }

                else
                {
                    cents = numInText[1].Trim() + "/" + "100";
                    //              cents = objUtility.NumberToText(numInText[1].Trim());

                    fullText = birrs + "and " + cents + " only.";
                }
                string upr = fullText[0].ToString().ToUpper();
                fullText = upr + fullText.Substring(1, fullText.Length - 2);

                txtInText.Text = fullText;
                wordamt = fullText;
                
                 
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


                if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {

                    SetUnit(e.RowIndex);
                    GetInstock(e.RowIndex);

                    dv.Rows[e.RowIndex].Cells["UnitPrice"].Value =
                    objData.getUnitPriceSelling(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), "SL1");

                    if (invoice_refTextBox.Text != "")
                        dv.Rows[e.RowIndex].Cells["InStock"].Value = objData.ReturnInstock("GetNetItemsInStock_AfterDate", dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), storeIDComboBox.SelectedValue.ToString().Trim())
                            - int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                  

                }

                if (dv.Columns[e.ColumnIndex].Name == "Qty" || dv.Columns[e.ColumnIndex].Name == "UnitPrice")
                {
                    
                    if (!qtyEdited) oldQty = objData.inStock(dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString().Trim(), "GetNetItemsInstock_AfterDate", clsVariables.sStore);
                    if (invoice_refTextBox.Text != "")
                        dv.Rows[e.RowIndex].Cells["InStock"].Value = oldQty - int.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                }



                dv.Rows[e.RowIndex].ErrorText = "";
            }

            catch (Exception ex)
            {
                if (e.RowIndex >= 0 && dv.Columns[e.ColumnIndex].Name != "ItemID") dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }



        }

        private void invoiceDetailsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           ValidateEntry(e);
        }

        private void ValidateEntry(DataGridViewCellValidatingEventArgs e)
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
                else
                    e.Cancel = false;

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
                        int.Parse(e.FormattedValue.ToString()))
                    {
                        //dv.Rows[e.RowIndex].Cells["Qty"].ErrorText = "No sufficient Quantity available in stock for this item!";
                        dv.Rows[e.RowIndex].ErrorText = "No sufficient Quantity available in stock for this item!";
                        e.Cancel = true;
                    }
                    else
                    {
                        dv.Rows[e.RowIndex].ErrorText = "";
                        e.Cancel = false;
                    }
                    e.Cancel = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); };

        }

        private void setAdapterConnectionString()
        {

            customerListTableAdapter.Connection = clsData.connBel;
            paymentTypesTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            invoiceDetailsTableAdapter.Connection = clsData.connBel;
            invoicesTableAdapter.Connection = clsData.connBel;
            allStatesTableAdapter.Connection = clsData.connBel;
            this.storesTableAdapter.Connection = clsData.connBel;

        }

        private void GetInstock(int Rx)
        {
            try
            {

                dv = invoiceDetailsDataGridView;
                objData.GetInstock(dv, Rx, "GetNetItemsInStock_AfterDate", clsVariables.sStore);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        public void tooStripAddnew_Click(object sender, EventArgs e)
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
            payTypeIdComboBox.SelectedValue = "Cash";
            payTypeIdComboBox.Text = "Cash";
            storeIDComboBox.SelectedValue = clsVariables.sStore;
            customerIdComboBox.Focus();

            if (clsVariables.sUserIsEmployee) salesPersonIdComboBox.SelectedValue = clsVariables.sUserEmployeeId;

            StatusTextbox.Text = "Active";

        }

        private void DeleteWrap_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

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
                this.invoiceDetailsTableAdapter.Update(this.belayAbInvoices.InvoiceDetails);

                detailNavAddnew.Enabled = clsVariables.allow;

                detailNavDelete.Text = "- Delete";

                sum = 0;
                calculateEveryTotal();
               
                
                objData.resetChanges(dv);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stosa");
                detailNavAddnew.Enabled = true;
                addingNew = false;

            }

        }

        private void saveMain()
        {
            try
            {

      //          validateSave();

                this.Validate();
                this.invoicesBindingSource.EndEdit();

                 rowmodified = false;

                calculateGrandTotal();

                if (invoicesBindingSource.Position >= 0)
                {
                    switch (this.belayAbInvoices.Invoices.Rows[invoicesBindingSource.Position].RowState)
                    {
                        case DataRowState.Added:
                        case DataRowState.Modified:
                            rowmodified = true;
                            break;
                    }


                    markRowModified();

                }


        //        this.Validate();
                 this.invoicesBindingSource.EndEdit();

                this.invoicesTableAdapter.Update(this.belayAbInvoices.Invoices);

              
                detailNavigtor.Enabled = true;
                MainNavAddnew.Enabled = true;
                DeleteWrap.Text = "Delete";
                MainNavAddnew.Enabled = clsVariables.allow;
                calculateEveryTotal();

             //   setAdvanceAndLoan();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void markRowModified()
        {
            if (rowmodified)

                if (createdByTextBox.Text == "")
                {
                    createdByTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    //          lblCreatedBy.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                }
                else
                {
                    //lblUpdatedBy.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    updatedbyTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                }

            rowmodified = false;

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
            if (e.Exception.Message != "") ;
        }

        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                if (invoice_refTextBox.Text != "")
                    if (objData.exists("Select invoice_ref from Invoices Where Invoice_ref ='" + invoice_refTextBox.Text.Trim() + "'"))
                        if (!objData.exists("Select invoice_ref from Invoices Where Invoice_ref ='" + invoice_refTextBox.Text.Trim() + "' and InvoiceNo='" + invoiceNoTextBox.Text.Trim() + "'"))
                            throw new Exception("Invoice Reference Number Already Exists!");

                if (chkAuto.Checked && invoiceNoTextBox.Text == "")
                    invoiceNoTextBox.Text = objNumber.getNextAutoNumber("Cash");

                if (invoice_refTextBox.Text != "") saveDetails();

                saveMain();

                detailNavigtor.Enabled = true;
            }
            catch (Exception exx) { MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        

        private void toolStrDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {

                    validateSave();
               
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        invoiceDetailsBindingSource.RemoveCurrent();
                        saveDetails();

                     //   this.invoiceDetailsTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails);

                    }
              
            }
            catch (Exception ex) {
                addingNew  = false;
                MessageBox.Show(ex.Message);
            }


        }

        private void invoiceDetailsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Data Error");
        }


        private void paymentRecievedLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStrPrintInvoice_Click(object sender, EventArgs e)
        {
            saveBoth();

            frmReportsViewer frmv = new frmReportsViewer();
            rptVATInvoice rpt = new rptVATInvoice();
            rptVATProroma rptV = new rptVATProroma();

            rpt.DataDefinition.FormulaFields["invTot"].Text = sum.ToString();
            rpt.DataDefinition.FormulaFields["vatAmt"].Text = vat.ToString();

            rptV.DataDefinition.FormulaFields["invTot"].Text = sum.ToString();
            rptV.DataDefinition.FormulaFields["vatAmt"].Text = vat.ToString();

            string strSQL = "Select * from VATInvoiceView Where InvoiceNo ='" +
                invoiceNoTextBox.Text + "'";

            if (payTypeIdComboBox.Text=="Cash")
              frmv.SetReport(rpt, strSQL, "VATInvoiceView");
            else
                frmv.SetReport(rptV, strSQL, "VATInvoiceView");

            Program.mainFrm.OpenOverFrm(frmv);
        }


        private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            calculateEveryTotal();
            setAdvanceAndLoan();

        }

        private void invoicesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (belayAbInvoices.Invoices.GetChanges() != null)
                if (belayAbInvoices.Invoices.GetChanges().Rows.Count > 0) saveMain();

        }

        private void invoiceDetailsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
         //      if (belayAbInvoices.InvoiceDetails.GetChanges() != null) saveDetails();
        }


        private void setAdvanceAndLoan()
        {
            if (customerIdComboBox.SelectedValue != null)
            {
                decimal cred = 0, payd = 0;

                cusAdvance = objData.GetCustomerPayments("GetAdvancePayments", customerIdComboBox.SelectedValue.ToString());
                cusLoan = objData.GetCustomerPayments("GetLoanpayments", customerIdComboBox.SelectedValue.ToString());

                objData.GetCustomerCredPayments(customerIdComboBox.SelectedValue.ToString(),
                   out cred, out payd);


                txtAdvance.Text = string.Format("{0: #,##0.00}", cusAdvance);
                txtLoan.Text = string.Format("{0: #,##0.00}", cusLoan);
                txtCredits.Text = string.Format("{0: #,##0.00}", cred);
                txtPayments.Text = string.Format("{0: #,##0.00}", payd);

                decimal balance = cred - (payd + cusAdvance + cusLoan);

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
                dv.CurrentCell = dv[1, dv.CurrentCell.RowIndex];

                if (detailNavDelete.Text == "- Delete") detailNavDelete.Text = "Cancel";

            }
            catch (Exception ex) {  }//MessageBox.Show(ex.Message, "Unkown");
        }

        private void invoiceDetailsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {

                oldQty = objData.inStock(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), "GetNetItemsInStock_AfterDate", clsVariables.sStore);

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
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
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

        private void invoiceDetailsDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
                invoiceNoTextBox.ReadOnly = true;
            else
                invoiceNoTextBox.ReadOnly = false;



            //{int res = (int)MessageBox.Show("Do you want to modify auto number options", "Auto number...",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            //    if (res == (int)DialogResult.Yes)
            //        MessageBox.Show("Yes Chosen!!");

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

        private void mnuAllItems_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList("Cash Invoice",this);
            Program.mainFrm.OpenOverFrm(f);
        }

        private void mnuSetPrices_Click(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting();
            Program.mainFrm.OpenFrm(f);

        }

        private void cboFilterStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string filter = invoicesBindingSource.Filter, newFilter =
            //    "CurState = '" + cboFilterStates.Text + "'";


            //if (cboFilterStates.Text.Trim() != "All")
            //    invoicesBindingSource.Filter = newFilter;
            //else
            //    invoicesBindingSource.Filter = "";

            //calculateEveryTotal();

        }

        private void btnCloseActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCloseActivate.Text == "Activate")
                {
                    if (objSecurity.userHasSuperPermission())
                    {
                        StatusTextbox.Text = "Active";
                        btnCloseActivate.Text = "Close";
                        invoiceDetailsBindingSource.EndEdit();
                    }

                    else
                    {
                        throw new Exception("You Can't do this with your current account!");
                    }
                }
                else
                {

                    StatusTextbox.Text = "Closed";
                    btnCloseActivate.Text = "Activate";
                    invoiceDetailsBindingSource.EndEdit();
                }
                saveOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateSave()
        {

            //    if (belayAbVMaintain.m_maintenance.GetChanges() != null)
            //   {
            if (StatusTextbox.Text == "Closed" && !saveOk)
            {
                throw new Exception("Status closed! Record not modifiable. Please activate ther record first!");
            }

        }

        private void btnCloseActivate1_Click(object sender, EventArgs e)
        {

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
                
            }
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

        private void frmInvoices_Activated(object sender, EventArgs e)
        {
            if (clsData.trNo != "")
            {
                int res = invoicesBindingSource.Find("InvoiceNo", clsData.trNo);
                if (res > -1) invoicesBindingSource.Position = res;
                clsData.trNo = "";
            }

            refreshItems();

            if (StatusTextbox.Text == "Closed") btnCloseActivate.Text = "Activate";

       }

        private void frmInvoices_Shown(object sender, EventArgs e)
        {
          //  payTypeIdComboBox.Enabled = false;
            this.storeIDComboBox.Enabled = false;
           // this.Text = "Cash Invoices";
        }

       
       
    }


}


