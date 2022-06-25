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
    public partial class frmTransfer : Form
    {
        clsUtility objUtility = new clsUtility();
        DataGridView dv = null;
        Boolean addingNew = false;
        clsData objData = clsData.Instance;
        string filtr = "";
        clsSecurity objSecurity = new clsSecurity();
        bool saveOk = false;
        bool rowmodified = false;

        public string storeAction = "Receive";


        public frmTransfer()
        {
            InitializeComponent();
        }
        public frmTransfer(string fltrr)
        {
            InitializeComponent();
            filtr = fltrr;
        }
        private void storeTransferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
            saveBoth();
        }



        private void frmTransfer_Load(object sender, EventArgs e)
        {
          try
          {
  
            string strSQL;
            strSQL = "Select EmployeeID, EmployeeName From Employees Order by EmployeeName";
            objUtility.fillComboValues(issuedByComboBox, strSQL);
            objUtility.fillComboValues(receivedByComboBox, strSQL);
            objUtility.fillComboValues(approvedByComboBox, strSQL);
            strSQL = "Select State,stateFor from States Where StateFor ='All' or StateFor='Transfer'";
            objUtility.fillComboValues(statusComboBox, strSQL);

            strSQL = "Select StoreId, StoreName from Stores";
            objUtility.fillComboValues(fromStoreComboBox, strSQL);
            objUtility.fillComboValues(toStoreComboBox, strSQL);

            setAdapterConnectionString();

            this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbReceived.StoreTransferDetails' table. You can move, or remove it, as needed.

            if (filtr =="")
             this.storeTransferTableAdapter.FillByStore(this.belayAbReceived.StoreTransfer, clsVariables.sStore);
            else
                this.storeTransferTableAdapter.FillByTransferNo(this.belayAbReceived.StoreTransfer, clsVariables.sStore, filtr);
           // TODO: This line of code loads data into the 'belayAbReceived.StoreTransfer' table. You can move, or remove it, as needed.
            this.storeTransferDetailsTableAdapter.Fill(this.belayAbReceived.StoreTransferDetails);
            // TODO: This line of code loads data into the 'belayAbSSDataSet.AllStates' table. You can move, or remove it, as needed.
            this.allStatesTableAdapter.Fill(this.belayAbSSDataSet.AllStates);
                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.


                GetAllInStock();

                statusComboBox.Enabled = false;

          }
          catch (Exception ex) { }
        }

        public void FillbyReferenceStore(string refNo)
        {
            this.storeTransferTableAdapter.FillByRefernceStore(this.belayAbReceived.StoreTransfer, refNo, clsVariables.sStore);

        }

        private void btnNavSaveDetails_Click(object sender, EventArgs e)
        {
            saveDetails();
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
                        storeTransferBindingSource.RemoveCurrent();
                        saveMain();
                    }
                }
                else
                {

                    storeTransferBindingSource.RemoveCurrent();
                    saveMain();

                    DeleteWrap.Text = "Delete";
                    DetailNavigator.Enabled = true;
                    MainNavFirst.Enabled = true;
                    MainNavPrevious.Enabled = true;
                    MainNavPosition.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
        private void saveMain()
        {
            try
            {
                validateSave();

                this.Validate();
                this.storeTransferBindingSource.EndEdit();
                this.storeTransferTableAdapter.Update(this.belayAbReceived.StoreTransfer);

                DetailNavigator.Enabled = true;
                MainNavAddnew.Enabled = true;
                DeleteWrap.Text = "Delete";
                MainNavAddnew.Enabled = clsVariables.allow;
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void saveBoth()
        {
            markRowModified();
            saveDetails();
            saveMain();
        }

        private void saveDetails()
        {
            try
            {
                validateSave();

                if (dv == null) dv = storeTransferDetailsDataGridView;

                dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);

                markRowModified();

                this.storeTransferDetalsBindingSource.EndEdit();
                this.storeTransferDetailsTableAdapter.Update(this.belayAbReceived.StoreTransferDetails);

                detailNavAddnew.Enabled = clsVariables.allow;

                detailNavDelete.Text = "- Delete";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                detailNavAddnew.Enabled = true;
                addingNew = false;

            }

        }
        public void MainNavAddnew_Click(object sender, EventArgs e)
        {
            DetailNavigator.Enabled = false;
            storeTransferBindingSource.AddNew();

            if (DeleteWrap.Text == "Delete")
            {
                DeleteWrap.Text = "Cancel";
            }

            fromStoreComboBox.SelectedIndex = 0;
            toStoreComboBox.SelectedIndex = 1;

            DetailNavigator.Enabled = false;
            MainNavFirst.Enabled = false;
            MainNavPrevious.Enabled = false;
            MainNavPosition.Enabled = false;
            MainNavAddnew.Enabled = false;
            itemTransferDateDateTimePicker.Value = DateTime.Now;
            itemTransferNoTextBox.Focus();


        }

        private void detailNavDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
               

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                  storeTransferDetalsBindingSource.RemoveCurrent();
                    saveDetails();

                    //   this.invoiceDetailsTableAdapter.Fill(this.belayAbInvoices.InvoiceDetails);

                }

            }
            catch (Exception ex)
            {
                addingNew = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void detailNavAddnew_Click(object sender, EventArgs e)
        {
            try{

                storeTransferDetalsBindingSource.AddNew();
                detailNavAddnew.Enabled = false;

            }
            catch (Exception ex)
            {
                addingNew = false;
                MessageBox.Show(ex.Message);
            }
       }


        private void setAdapterConnectionString()
        {

            storeTransferTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            storeTransferDetailsTableAdapter.Connection = clsData.connBel;
            allStatesTableAdapter.Connection = clsData.connBel;
              
          

        }

        private void detailNavSave_Click(object sender, EventArgs e)
        {
            saveDetails();
        }

        
        private void GetInstock(int Rx)
        {
            try
            {
                string pNum = dv.Rows[Rx].Cells["ItemID"].Value.ToString();
                dv.Rows[Rx].Cells["InStock"].Value = objData.ReturnInstock("GetNetItemsInStock_AfterDate", pNum, fromStoreComboBox.SelectedValue.ToString().Trim());

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void storeTransferBindingSource_PositionChanged(object sender, EventArgs e)
        {
            GetAllInStock();
        }
        private void GetAllInStock()
        {
            try
            {
                int k;

                for (k = 0; k < dv.Rows.Count; k++)
                    GetInstock(k);


            }
            catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            }

        }

        private void storeTransferDetalsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void storeTransferDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dv = this.storeTransferDetailsDataGridView;

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {


                    //   SetUnit(e.RowIndex);

                    GetInstock(e.RowIndex);

                    double reqAmt = objData.GetValueInOrder(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(),
                         referenceNumberComboBox.Text.Trim(), "Requisition");

                    dv.Rows[e.RowIndex].Cells["TransferedQty"].Value = reqAmt;
                  
                    // dv.Rows[e.RowIndex].Cells["Qty"].Value = reqAmt;

                    //dv.Rows[e.RowIndex].Cells["UnitPrice"].Value =
                    // objData.getUnitPrice(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString());


                    ////balance
                    //dv.Rows[e.RowIndex].Cells["InStock"].Value = objData.ReturnInstock("GetNetItemsInStock", dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), clsVariables.sStore)
                    //    - double.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());

                }
                dv.Rows[e.RowIndex].ErrorText = "";
            }

            catch (Exception ex)
            {
                //if (e.RowIndex >= 0 && dv.Columns[e.ColumnIndex].Name != "ItemID") dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }
        }

        private void storeTransferDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void toolStrPrintInvoice_Click(object sender, EventArgs e)
        {
            saveBoth();
            
            frmReportsViewer frmv = new frmReportsViewer();
            rptStoreTransferA5 rpt = new rptStoreTransferA5();

            string strSQL = "Select * from rpt_Storetransfer Where StoreTransferNo='" +
            itemTransferNoTextBox.Text + "'";

            frmv.SetReport(rpt, strSQL, "rpt_Storetransfer");


            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void fromStoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curval = "";
            if (referenceNumberComboBox.SelectedIndex > -1 || referenceNumberComboBox.Text != null || referenceNumberComboBox.Text != "")
                curval = referenceNumberComboBox.Text.Trim();
            try
            {
                string strSQL = "GetNonTransferedRequisitions @ToStore =N'" + toStoreComboBox.SelectedValue.ToString().Trim() + "', @FromStore='" +
                      fromStoreComboBox.SelectedValue.ToString().Trim() + "'";

                referenceNumberComboBox.DisplayMember = "RequisitionNumber";
                //    referenceNumberComboBox.ValueMember = "RequisitionNumber";
                objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                DataTable dt = (DataTable) referenceNumberComboBox.DataSource;
                dt.Rows.Add(curval);
                referenceNumberComboBox.Refresh();
                referenceNumberComboBox_SelectedIndexChanged(null, null);


            }
            catch (Exception exx) { }
        }

        private void referenceNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            if (referenceNumberComboBox.Text.Trim() != null || referenceNumberComboBox.Text.Trim() != "")
            {
                string strSQL = "GetItemsInRequisition '" + referenceNumberComboBox.Text.Trim() + "'";
                objUtility.fillComboValues(ItemID, strSQL);
                ItemID.DisplayMember = "Description";
                ItemID.ValueMember = "ItemID";
                DataTable tb = (DataTable)ItemID.DataSource;
                if(tb.Rows.Count==0) ItemID.DataSource = this.belayAbSSDataSet.PartNumDescription;
            }

        }

        private void toolStripButtonAddAll_Click(object sender, EventArgs e)
        {
            // addingAll = true;
            DataTable dtParts = (DataTable)ItemID.DataSource;
            //   int qty;

            if (dtParts.Rows.Count > 0)
            {
                //MessageBox.Show(dtParts.Rows.Count.ToString());
                foreach (DataRow dr in dtParts.Rows)
                {
                    int k = 0;
                    string newPart = dr["ItemID"].ToString();

                    while (k < dv.Rows.Count && dv.Rows[k].Cells["ItemID"].Value.ToString() != newPart)
                        k++;

                    //this line set the units of all rows
                    if (k >= dv.Rows.Count)
                    {
                        storeTransferDetalsBindingSource.EndEdit();
                        this.Validate();
                        storeTransferDetalsBindingSource.AddNew();
                        dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value = dr["ItemID"].ToString();

                    }
                }
            }
        }

        private void toStoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromStoreComboBox_SelectedIndexChanged(null, null);
        }

        private void storeTransferDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //Get the employee who received the transfer!!!

            saveDetails();
            
            if (MessageBox.Show("Recieved Confirmation will be set in your name. Continue ? ", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                if (clsVariables.sUserIsEmployee) receivedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;
                statusComboBox.Text = "Received";
                itemReceivedDateDateTimePicker.Value = DateTime.Now;
                saveMain();
                }
                
        }

        private void btnSendItems_Click(object sender, EventArgs e)
        {
            saveDetails();

            if (MessageBox.Show("Send Infirmation will be set in your name. Continue ? ", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsVariables.sUserIsEmployee) issuedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;
                statusComboBox.Text = "Sent";
                saveMain();
            }
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
                        storeTransferBindingSource.EndEdit();
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
                    storeTransferBindingSource.EndEdit();
                }
                saveOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void markRowModified()
        {

            storeTransferDetalsBindingSource.EndEdit();
            storeTransferBindingSource.EndEdit();

            //if (belayAbReceived.StoreTransfer.GetChanges() != null || belayAbReceived.StoreTransferDetails.GetChanges() != null)
                rowmodified = true;

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

        private void StatusTextbox_TextChanged(object sender, EventArgs e)
        {
            if (StatusTextbox.Text == "Active")
                btnCloseActivate.Text = "Close";
            else
                btnCloseActivate.Text = "Close";
        }

        private void referenceNumberComboBox_TextUpdate(object sender, EventArgs e)
        {
            if (referenceNumberComboBox.Text == null || referenceNumberComboBox.Text == "")
                ItemID.DataSource = this.belayAbSSDataSet.PartNumDescription;
            else
                referenceNumberComboBox_SelectedIndexChanged(null, null);

        }

     
    }
}
