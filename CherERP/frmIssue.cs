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
    public partial class frmIssue : Form
    {
        public string vType = "Import";

        clsData objData = clsData.Instance;
        DataGridView dv = new DataGridView();
        clsUtility objUtility = new clsUtility();
        clsNumbers objNumber = new clsNumbers();

        static string fltr = "";

        DataSet itemDs = new DataSet();

        int order;

        private double oldQty, newQty;

        string strSQL;

        bool addingNew, qtyEdited, addingAll;

        public frmIssue()
        {
            InitializeComponent();

        }

        public frmIssue(string strIssuNo)
        {
            InitializeComponent();
            fltr = strIssuNo;

        }

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsIssuedBindingSource.EndEdit();
            this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);

        }

        private void frmIssue_Load(object sender, EventArgs e)
        {
            try
            {
                setAdapterConnectionString();

                string strSQL;

                //row or location Combo
                strSQL = "Select Distinct EmployeeId,EmployeeName From Employees Order By employeeName";
                //   objUtility.fillComboValues(requestedByComboBox, strSQL);
                objUtility.fillComboValues(approvedByComboBox, strSQL);
                objUtility.fillComboValues(preparedByComboBox, strSQL);
                objUtility.fillComboValues(requestedByComboBox, strSQL);

                strSQL = "Select StoreID, StoreName From Stores Order by StoreName";
                objUtility.fillComboValuesWithAll(storeIDComboBox, strSQL);

                strSQL = "Select State From States Order By State";
                objUtility.fillComboValues(stateComboBox, strSQL);

                // TODO: This line of code loads data into the 'belayAbInvoices.Issuetypes' table. You can move, or remove it, as needed.
                this.issuetypesTableAdapter.Fill(this.belayAbInvoices.Issuetypes);

                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbInvoices.Invoices' table. You can move, or remove it, as needed.

                // TROUBLING NEW ENTRIES

                if (fltr == "")
                    this.itemsIssuedTableAdapter.FillByStoreVoucher(this.belayAbSSDataSet.ItemsIssued, clsVariables.sStore, this.vType);
                else
                    this.itemsIssuedTableAdapter.FillByIssueNo(this.belayAbSSDataSet.ItemsIssued, clsVariables.sStore, fltr);
                // TODO: This line of code loads data into the 'belayAbInvoices.InvoiceDetails' table. You can move, or remove it, as needed.
                this.itemsIssuedDetailsTableAdapter.Fill(this.belayAbSSDataSet.ItemsIssuedDetails);

                dv = DetailGridView;

                calculateEveryTotal();


                referenceNumberComboBox_SelectedIndexChanged(new object(), new EventArgs());

                //        setPermissions();

                //      objData.resetChanges(dv);

                storeIDComboBox.Enabled = false;
                issueTypeIdComboBox.Enabled = false;

                //Set the change tracker on the form

                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).CheckedChanged += c_ControlChanged;
                    }
                    else if (c is ComboBox)
                    {
                        c.TextChanged += new EventHandler(c_ControlChanged);
                    }
                    else if (c is TextBox)
                    {
                        c.TextChanged += new EventHandler(c_ControlChanged);
                    }
                    else if (c is PictureBox)
                    {
                        ((DataGridView)c).CellValueChanged += c_ControlChanged;
                    }

                }


                //approvedByComboBox.Enabled = false;

                // Enable the Status Box

                objUtility.enableIssueControl(stateComboBox);
                objUtility.enableIssueControl(approvedByComboBox);

                approvalStatusComboBox_SelectedIndexChanged(null, null);

                if (cboVouchureType.Text == "" || cboVouchureType.Text == null)
                    cboVouchureType.Enabled = true;
                else
                    cboVouchureType.Enabled = false;


            }
            catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            }


            
        }



        private void toolstrDetailSave_Click(object sender, EventArgs e)
        {
            try
            {

                this.itemsIssuedDetailsBindingSource.EndEdit();

                logUpdator();

                this.itemsIssuedDetailsTableAdapter.Update(this.belayAbSSDataSet.ItemsIssuedDetails);

                //Refresh
                belayAbSSDataSet.ItemsIssuedDetails.Clear();
                this.itemsIssuedDetailsTableAdapter.Fill(this.belayAbSSDataSet.ItemsIssuedDetails);

                calculateEveryTotal();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void SetUnit(int Rx)
        {
            try
            {

                objData.setItemUnit(dv, Rx);
                objData.GetInstock(dv, Rx, "GetNetItemsInStock_AfterDate", clsVariables.sStore);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void calculateTotal(int row)
        {
            float price = 0, tot = 0;
            float qty = 0;

            try
            {
                dv = DetailGridView;

                if (row < dv.Rows.Count)
                {
                    if (float.TryParse(dv.Rows[row].Cells["Qty"].Value.ToString(), out qty) &&
                         float.TryParse(dv.Rows[row].Cells["UnitPrice"].Value.ToString(), out price))
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
                {
                    calculateTotal(k);
                    //this line set the units of all rows

                }

                for (k = 0; k < dv.Rows.Count; k++)
                    SetUnit(k);

                calculateGrandTotal();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void calculateGrandTotal()
        {
            float sum = 0, fval = 0;

            dv = this.DetailGridView;

            try
            {
                for (int k = 0; k < dv.Rows.Count; k++)
                {
                    if (float.TryParse(dv.Rows[k].Cells["TotalPrice"].Value.ToString(), out fval))
                        sum += fval;
                }

                txtTotal.Text = string.Format("{0: Br #,##0.00}", sum);
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
                dv = this.DetailGridView;

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].Name == "Qty")
                {
                    calculateTotal(e.RowIndex);
                    calculateGrandTotal();

                    dv.Rows[e.RowIndex].Cells["InStock"].Value = oldQty - double.Parse(dv.CurrentCell.Value.ToString());

                }
                else if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {

                    SetUnit(e.RowIndex);
                   // GetInstock(e.RowIndex);

                    double reqAmt = objData.GetValueInOrder(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(),
                        referenceNumberComboBox.Text, issueTypeIdComboBox.Text.Trim());

                    dv.Rows[e.RowIndex].Cells["RequestedQty"].Value = reqAmt;
                    dv.Rows[e.RowIndex].Cells["Qty"].Value = reqAmt;

                    dv.Rows[e.RowIndex].Cells["UnitPrice"].Value =
                     objData.getUnitPrice(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());

                  
                    //balance
                    dv.Rows[e.RowIndex].Cells["InStock"].Value = objData.ReturnInstock("GetNetItemsInStock_AfterDate", dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), clsVariables.sStore)
                        - double.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());


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
            DataGridView dv = DetailGridView;
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

                if (dv.Columns[e.ColumnIndex].DataPropertyName == "IssuedQty")
                {
                    if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                        e.Cancel = true;
                    }
                    else if (int.Parse(dv.Rows[e.RowIndex].Cells["RequestedQty"].Value.ToString()) <
                                   int.Parse(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("Issued value can't be greater than Requested value!", "Stosa");
                        e.Cancel = true;
                    }
                    // else if (dv.Rows[e.RowIndex].Cells["InStock"].Value != null && oldQty <
                    //         int.Parse(e.FormattedValue.ToString()))
                    //     {
                    //         dv.Rows[e.RowIndex].Cells["Qty"].ErrorText = "No sufficient Quantity available in stock for this item!";
                    //         MessageBox.Show("No sufficient Quantity available in stock for this item!", "Stosa");
                    //         e.Cancel = true;
                    //     }
                    else
                    {
                        dv.Rows[e.RowIndex].Cells["Qty"].ErrorText = "";
                        qtyEdited = false;
                    }



                }
            }
            catch (Exception ex) { };

        }


        private void setAdapterConnectionString()
        {


            itemsIssuedDetailsTableAdapter.Connection = clsData.connBel;
            itemsIssuedTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            issuetypesTableAdapter.Connection = clsData.connBel;


        }

        private void GetInstock(int Rx)
        {
            try
            {
                
                dv = DetailGridView;
                objData.GetInstock(dv, Rx, "GetNetItemsInStock_AfterDate", clsVariables.sStore);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void itemsIssuedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsIssuedBindingSource.EndEdit();
            this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);

        }

        private void itemsIssuedBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsIssuedBindingSource.EndEdit();
            this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);

        }


        private void itemsIssuedBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsIssuedBindingSource.EndEdit();
            this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);
            DetailGridView.Enabled = true;
        }


        private void toolStrSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {
                
                saveDetails();

                if (approvalStatusComboBox.Text.Trim().ToUpper() == "DELIVERED")
                 updateRequests();

                //  calculateEveryTotal();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Stosa"); }

        }

        private void itemsIssuedBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //calculateEveryTotal();
            //if (belayAbSSDataSet.ItemsIssued.GetChanges() != null) saveMain();
        }

        private void saveDetails()
        {
            try
            {
                this.Validate();
              
                this.itemsIssuedDetailsBindingSource.EndEdit();
                logUpdator();
                this.itemsIssuedDetailsTableAdapter.Update(this.belayAbSSDataSet.ItemsIssuedDetails);

                DetailNavDelete.Text = "- Delete";

                DetailNavAddNew.Enabled = clsVariables.allow;

                objData.resetChanges(dv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DetailNavAddNew.Enabled = clsVariables.allow;
            }

        }

        private void saveMain()
        {
            try
            {

                this.Validate();
                this.itemsIssuedBindingSource.EndEdit();

                //log updators
                logUpdator();

                this.itemsIssuedBindingSource.EndEdit();
                this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);


                detailNavigtor.Enabled = true;

                MainNavAddnew.Enabled = clsVariables.allow;

                MainNavDelete.Text = "Delete";
                calculateEveryTotal();

              


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



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


        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

            saveDetails();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            detailNavigtor.Enabled = false;

        }

        private void toolStrpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!addingNew)
                {
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        itemsIssuedDetailsBindingSource.RemoveCurrent();
                        saveDetails();
                    }
                }
                else
                {
                    itemsIssuedDetailsBindingSource.RemoveCurrent();
                    saveDetails();
                    addingNew = false;
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void DeleteWrap_Click(object sender, EventArgs e)
        {


            try
            {

                if (itemsIssuedBindingSource.Position < 0 || itemsIssuedBindingSource.Current == null)
                {
                    itemsIssuedBindingSource.CancelEdit();
                    MainNavAddnew.Enabled = true;
                    return;

                }

                if (MainNavDelete.Text == "Delete")
                {
                    if (MessageBox.Show("All Requistion records will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        itemsIssuedBindingSource.RemoveCurrent();
                        saveMain();
                    }
                }
                else
                {

                    itemsIssuedBindingSource.RemoveCurrent();
                    saveMain();

                    MainNavDelete.Text = "Delete";
                    detailNavigtor.Enabled = true;
                    MainNavFirst.Enabled = true;
                    MainNavPrevious.Enabled = true;
                    MainNavPosition.Enabled = true;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }



        private void itemsIssuedDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //e.Cancel = true;

        }



        private void toolStripDetailAddNnew_Click(object sender, EventArgs e)
        {
            try
            {
                dv = DetailGridView;

                itemsIssuedDetailsBindingSource.AddNew();
                DetailNavAddNew.Enabled = false;

                addingNew = true;

                if (dv[1, dv.CurrentCell.RowIndex].Visible)
                    dv.CurrentCell = dv[1, dv.CurrentCell.RowIndex];

                if (DetailNavDelete.Text == "- Delete") DetailNavDelete.Text = "Cancel";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (chkAuto.Checked && issueNoTextBox.Text == "")
                    issueNoTextBox.Text = objNumber.getNextAutoNumber("SIV");

                if (issueNoTextBox.Text == null || issueNoTextBox.Text == "")
                    throw new Exception("Store Issue Number can not be Empty");

                if (cboVouchureType.SelectedItem == null || cboVouchureType.Text == "")
                {
                    throw new Exception("Please Select a Valid Voucher Type");
                }

                saveMain();

              if(stateComboBox.Text.Trim().ToUpper() == "DELIVERED")
                    updateRequests();

            }
            catch (Exception exx) { MessageBox.Show(exx.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }



        private void logUpdator()
        {
            try
            {
               // bool rowmodified = true;


                //if (this.belayAbItemRequistions.ItemRequisition.Rows[itemsIssuedBindingSource.Position].RowState == DataRowState.Added
                //    || this.belayAbItemRequistions.ItemRequisition.Rows[itemsIssuedBindingSource.Position].RowState == DataRowState.Modified
                //    || this.belayAbItemRequistions.ItemRequisitionDetails.Rows[itemsIssuedDetailsBindingSource.Position].RowState == DataRowState.Added
                //    || this.belayAbItemRequistions.ItemRequisitionDetails.Rows[itemsIssuedDetailsBindingSource.Position].RowState == DataRowState.Modified)

                // rowmodified = true;



                //if (rowmodified)

                if (createdByTextBox.Text == "")
                    {
                        createdByTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    }
                    else
                    {
                        updatedbyTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    }
            }
            catch (Exception exx) { }
        }
        private void updateRequests()
        {
            string WoN;

            WoN = objData.getFieldValue("Select WorkOrderNumber from WorkOrder_Requested_Issued Where IssueNo ='" + issueNoTextBox.Text + "'");

            if (WoN != "")
            {
                dv = this.DetailGridView;

                if (dv.Rows.Count > 0)
                {
                    //MessageBox.Show(dtParts.Rows.Count.ToString());
                    try
                    {
                        if (!objData.exists("Select * from m_maintenance Where WorkOrderNumber ='" + WoN + "'" + " And m_MaintenanceStatus ='Active'"))
                            {

                            MessageBox.Show("Can not update Work Order Requisitions because it is Closed! Please Activate it first and Save the Issue again", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                            }


                        for (int k = 0; k < dv.Rows.Count; k++)
                        {
                            string newPart = dv.Rows[k].Cells["ItemID"].Value.ToString();
                            string quantity = dv.Rows[k].Cells["Qty"].Value.ToString();
                            string UnitP = dv.Rows[k].Cells["UnitPrice"].Value.ToString();
                            string itemCat = objData.getFieldValue("Select CategoryID from Items Where ItemID='" + newPart + "'");
                            string tableName;

                            if (itemCat == "FL")
                                tableName = "m_Fuel_Lubricatnts";
                            else
                                tableName = "m_Replaced";

                            if (!objData.exists("Select * from " + tableName + " Where mNumber ='" + WoN + "'" + " And ItemID ='" + newPart + "'"))
                                objData.addNewRecord(tableName, "mNumber,  ItemID, Quantity, UnitPrice, [SIV No]", "'" + WoN + "'" + ",'" + newPart + "'," + quantity + "," + UnitP + ",'" + objUtility.VoucherSymbol(cboVouchureType.Text) +  issueNoTextBox.Text + "'", true);
                         //   else
                         //       objData.updateRecord(tableName, "mNumber,  ItemID, Quantity, UnitPrice, [SIV No]", "'" + WoN + "'" + ",'" + newPart + "'," + quantity + "," + UnitP + ",'" + issueNoTextBox.Text + "'",
                        //            " mNumber ='" + WoN + "'" + " And ItemID ='" + newPart + "'", true);

                            lblWorkorders.Text = "Work Orders Updated!";

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //      calculateEveryTotal();
                }


            }
        }



        private void toolStrPrintIssue_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();
            string strSQL = "Select * from ItemIssuedView Where IssueNo ='" +
                issueNoTextBox.Text + "'";
            frmv.SetReport(new rptStoreIssueVoucherA5(), strSQL, "ItemIssuedView");
            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void issueTypeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string refNo = referenceNumberComboBox.Text;

            referenceNumberComboBox.DataSource = null;


            switch (issueTypeIdComboBox.Text.Trim())
            {
                case "Requisition":
                    {
                        strSQL = "GetNonIssuedRequisitions @Store =N'" + clsVariables.sStore + "'";
                        referenceNumberComboBox.DisplayMember = "RequisitionNumber";
                        //    referenceNumberComboBox.ValueMember = "RequisitionNumber";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);


                    }
                    break;

                case "Cash Sales":
                    {
                        strSQL = "GetNonIssuedInvoices 'Cash'";
                        referenceNumberComboBox.DisplayMember = "InvoiceNo";
                        //      referenceNumberComboBox.ValueMember = "InvoiceNo";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                    }
                    break;

                case "Credit Sales":
                    {
                        strSQL = "GetNonIssuedInvoices 'Credit'";
                        referenceNumberComboBox.DisplayMember = "InvoiceNo";
                        //      referenceNumberComboBox.ValueMember = "InvoiceNo";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                    }
                    break;
                default:
                    referenceNumberComboBox.Text = issueTypeIdComboBox.Text;
                    ;
                    break;
            }


            if (refNo != "") referenceNumberComboBox.Text = refNo;

        }

        private void referenceNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;


            switch (issueTypeIdComboBox.Text.Trim())
            {
                case "Cash Sales":
                    {

                        strSQL = "GetItemsInSales '" + referenceNumberComboBox.Text.Trim() + "', 'Cash'";

                        objUtility.fillComboValues(ItemID, strSQL);

             

                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";


                    }
                    break;

                case "Credit Sales":
                    {
                        strSQL = "GetItemsInSales '" + referenceNumberComboBox.Text.Trim() + "', 'Credit'";

                        objUtility.fillComboValues(ItemID, strSQL);

                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";


                    }
                    break;
                case "Requisition":
                    {

                        strSQL = "GetItemsInRequisition '" + referenceNumberComboBox.Text.Trim() + "'";

                        objUtility.fillComboValues(ItemID, strSQL);
                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";

                        //Get Requision data
                        strSQL = "Select RequestedBy from ItemRequisition Where RequisitionNumber ='" + referenceNumberComboBox.Text.Trim() + "'";
                        string requestedBy = objData.getFieldValue(strSQL);
                        requestedByComboBox.Text = requestedBy;


                    }
                    break;

                default:
                    // referenceNumberComboBox.Text = issueTypeIdComboBox.Text; ;
                    break;
            }
        }

        private void itemsIssuedDetailsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (belayAbSSDataSet.ItemsIssuedDetails.GetChanges() != null && !addingAll) saveDetails();
        }

        private void setPermissions()
        {
            string uRole = objData.getUserRole(clsVariables.sDBUserID);

            clsData.objSecurity.setCommonPermissionsMain(MainNavAddnew, MainNavSave, MainNavDelete, null, false);
            clsData.objSecurity.setCommonPermissionsDetail(DetailNavAddNew, DetailNavSave, DetailNavDelete, DetailGridView, false);
        }

        private void itemsIssuedBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DetailGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {


                oldQty = objData.ReturnInstock("GetNetItemsInStock_AfterDate", dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(),  clsVariables.sStore);

                if (dv.Columns[e.ColumnIndex].Name == "Qty")
                {

                    //   label10.Text = dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString();

                    if (dv.Rows[e.RowIndex].Cells["Qty"].Value != null && dv.Rows[e.RowIndex].Cells["Edited"].Value!=null && bool.Parse(dv.Rows[e.RowIndex].Cells["Edited"].Value.ToString()) == false)
                        oldQty = oldQty + float.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());
                    else
                        oldQty = float.Parse(dv.Rows[e.RowIndex].Cells["InStock"].Value.ToString()) + float.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                    dv.Rows[e.RowIndex].Cells["Edited"].Value = true;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DetailGridView_Sorted(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }



        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
                issueNoTextBox.ReadOnly = true;
            else
                issueNoTextBox.ReadOnly = false;


        }

        private void DetailGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

                if (dv == null) dv = DetailGridView;


                for (k = 0; k < dv.Rows.Count; k++)
                    setDesc(k);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            DataTable dtParts = new DataTable();
            decimal  remainingQty;
            //string strSQL;


            try 
            {
                addingAll = true;
                dtParts = (DataTable)ItemID.DataSource;

                if (dtParts.Rows.Count > 0)
                {
                    //MessageBox.Show(dtParts.Rows.Count.ToString());
                    foreach (DataRow dr in dtParts.Rows)
                    {
                        int k = 0;
                       
                        string newPart = dr["ItemID"].ToString();
                      //  strSQL = "fIssuedforRequisition '" + this.issueNoTextBox.Text.Trim() + "' , '" + newPart + "', 'ALL'";
                        remainingQty = objData.GetValueInOrder(newPart,referenceNumberComboBox.Text, issueTypeIdComboBox.Text.Trim());


                        while (k < dv.Rows.Count && dv.Rows[k].Cells["ItemID"].Value.ToString() != newPart && remainingQty > 0)
                            k++;

                        //this line sets the units of all rows
                        if (k >= dv.Rows.Count && remainingQty > 0)
                        {
                            itemsIssuedBindingSource.EndEdit();
                            this.Validate();

                            itemsIssuedDetailsBindingSource.AddNew();
                            dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value = dr["ItemID"].ToString();

                        }
                    }

                    calculateEveryTotal();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                addingAll = false;
            }
        }

        private void btnUpdateRequests_Click(object sender, EventArgs e)
        {
            if (stateComboBox.Text.Trim().ToUpper() == "APPROVED")
                updateRequests();
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // objUtility.setApprover(stateComboBox, approvedByComboBox);
        }

       

        public void MainNavAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemsIssuedBindingSource.AddNew();
            }
            catch (Exception ex) { }
                     

            if (MainNavDelete.Text == "Delete")
            {
                MainNavDelete.Text = "Cancel";
            }


            detailNavigtor.Enabled = false;
            MainNavFirst.Enabled = false;
            MainNavPrevious.Enabled = false;
            MainNavPosition.Enabled = false;
            MainNavAddnew.Enabled = false;
            issueDateDateTimePicker.Text = "";
            issueDateDateTimePicker.Value = DateTime.Now;
            preparedByComboBox.SelectedIndex = -1;
            approvedByComboBox.SelectedIndex = -1;

            storeIDComboBox.SelectedValue = clsVariables.sStore;
            issueTypeIdComboBox.SelectedValue = "REQ";
            approvalStatusComboBox.Text = "New";
            this.cboVouchureType.Text = this.vType;
            this.cboVouchureType.Enabled = false;

            MainNavAddnew.Enabled = false;

            if (clsVariables.sUserIsEmployee) preparedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;
        }

        private void approvalStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool value = (approvalStatusComboBox.Text.Trim() == "Approved") && stateComboBox.Text != "Delivered";
            objUtility.setApprover(stateComboBox, approvedByComboBox);
            btnDelivery.Visible = value;
            btnDelivery.Enabled = value;
            stateComboBox.Visible = (approvalStatusComboBox.Text.Trim() == "Approved");
            btnDelivery.Visible = (approvalStatusComboBox.Text.Trim() == "Approved" && stateComboBox.Text != "Delivered");
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            stateComboBox.Text = "Delivered";
            btnDelivery.Enabled = false;
            stateComboBox.Enabled = false;
            saveMain();
        }

 

        public void StartNewIsssue()
        {

            if (MainNavDelete.Text == "Delete")
            {
                MainNavDelete.Text = "Cancel";
            }

            detailNavigtor.Enabled = false;
            MainNavFirst.Enabled = false;
            MainNavPrevious.Enabled = false;
            MainNavPosition.Enabled = false;
            MainNavAddnew.Enabled = false;
            issueDateDateTimePicker.Text = "";
            issueDateDateTimePicker.Value = DateTime.Now;
            preparedByComboBox.SelectedIndex = -1;
            approvedByComboBox.SelectedIndex = -1;

            storeIDComboBox.SelectedValue = clsVariables.sStore;
            issueTypeIdComboBox.SelectedValue = "REQ";

            this.cboVouchureType.Text = this.vType;
            this.cboVouchureType.Enabled = false;

            MainNavAddnew.Enabled = false;

            if (clsVariables.sUserIsEmployee) preparedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;

        }

        private void c_ControlChanged(object sender, EventArgs e)
        {
            logUpdator();
        }

        private void enableControls()
        {
            if (clsVariables.userRole.ToUpper() != "STORE HEAD")
            {
                stateComboBox.Enabled = true;
                approvedByComboBox.Enabled = false;
                //lstToolStripMenuItem.Visible = false;
            }
            else if (clsVariables.userRole.ToUpper() != "STORE CLERK")
            {
               // stateComboBox.Visible = true;
                stateComboBox.Enabled = false;
                approvedByComboBox.Enabled = true;
            }
            else
            {
                stateComboBox.Enabled = false;
                approvedByComboBox.Enabled = false;

                //lstToolStripMenuItem.Visible = false;
                //lstToolStripMenuItem.Visible = false;
            }
        }

    }


}


