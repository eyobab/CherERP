using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;


namespace Belayab
{
    public partial class frmItemRequisitions : Form
    {
        private DataGridView dv;
        private clsData objData = clsData.Instance;
        private clsUtility objUtility = new clsUtility();
        private clsNumbers objNumber = new clsNumbers();

        string fltr = "",strSQL;

        bool addingNew=false, rowmodified =false;
        int order;

        public frmItemRequisitions()
        {
            InitializeComponent();
        }

        public frmItemRequisitions(string strRN)
        {
            InitializeComponent();
            fltr = strRN;
        }
        private void itemRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveMain();
        }


        private void frmItemRequisitions_Load(object sender, EventArgs e)
        {
            try
            {

                strSQL = "Select StoreID, StoreName from Stores";
                objUtility.fillComboValues(storeIDComboBox, strSQL);
                objUtility.fillComboValues(fromStoreComboBox, strSQL);


                strSQL = "Select State From States Order By State";
                objUtility.fillComboValues(statusComboBox, strSQL);

                
                dv = ItemRequistionDetailsView;

                setAdapterConnectionString();

                //this.m_WorkOrderNumbersTableAdapter.fill(this.belayAbVMaintain.m_WorkOrderNumbers,false, clsVariables.sStore);

                this.m_WorkOrderNumbersTableAdapter.Fill(this.belayAbVMaintain.m_WorkOrderNumbers, clsVariables.sStore);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.
                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.DepartmentLst' table. You can move, or remove it, as needed.
                this.departmentLstTableAdapter.Fill(this.belayAbItemRequistions.DepartmentLst);
                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.ItemRequisition' table. You can move, or remove it, as needed.
                
                if (fltr=="")
                      this.itemRequisitionTableAdapter.FillByStore(this.belayAbItemRequistions.ItemRequisition,clsVariables.sStore);
                else
                     this.itemRequisitionTableAdapter.FillByReferenceNumber(this.belayAbItemRequistions.ItemRequisition,fltr);
             
                // TODO: This line of code loads data into the 'belayAbItemRequistions.ItemRequisitionDetails' table. You can move, or remove it, as needed.
                this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);
               
     
                
                setAllUnits();
                GetAllInStock();
                
                storeIDComboBox.Enabled = false;
              //  approvedByComboBox.Enabled = false;

                objUtility.enableControl(statusComboBox);




            }
            catch (Exception ex) { MessageBox.Show(ex.Message,"Error_", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void toolstrDetailsSave_Click(object sender, EventArgs e)
        {
            try
            {
                dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
                this.itemRequistionDetailsbSouce.EndEdit();
                logUpdator();
                this.itemRequistionDetailsbSouce.EndEdit();
                this.itemRequisitionDetailsTableAdapter.Update(this.belayAbItemRequistions.ItemRequisitionDetails);
                              
                detailNaveAddNew.Enabled = true;
                setAllUnits();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Belayab ");
                detailNaveAddNew.Enabled = true;
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
                comm.Dispose();
                comm = null;


            }
            catch (Exception ex) { }//MessageBox.Show( ex.Message); }
        }



        private void ItemRequistionDetailsView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dv = ItemRequistionDetailsView;
            if (dv.Columns[e.ColumnIndex].Name == "ItemID")
            {

                SetUnit(e.RowIndex);
                GetInstock (e.RowIndex);

            }


        }

        private void GetAllInStock()
        {
          for (int i = 0 ; i< dv.Rows.Count ; i++)
              GetInstock(i);

        }

        private void GetInstock(int Rx)
        {
            try
            {
                objData.GetInstock(dv, Rx,"GetNetItemsInStock_AfterDate", clsVariables.sStore);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
                

        private void setAdapterConnectionString()
        {

            employeesLstTableAdapter.Connection = clsData.connBel;
            departmentLstTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            itemRequisitionDetailsTableAdapter.Connection = clsData.connBel;
            itemRequisitionTableAdapter.Connection = clsData.connBel;
            m_WorkOrderNumbersTableAdapter.Connection = clsData.connBel;

        }

        private void ItemRequistionDetailsView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float val;
            DataGridView dv = ItemRequistionDetailsView;

            dv.Rows[e.RowIndex].ErrorText = "";
            if (dv.Columns[e.ColumnIndex].Name == "RequestedQty")
            {
                if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                {
                    dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                    e.Cancel = true;
                }
            }
        }


        private void setAllUnits()
        {
            try
            {
                for (int k = 0; k < ItemRequistionDetailsView.Rows.Count; k++)
                {
                    //this line set the units of all rows

                    SetUnit(k);
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void itemRequisitionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            setAllUnits();
            GetAllInStock();
        }

        private void saveDetails()
        {
            try
            {
                this.itemRequistionDetailsbSouce.EndEdit();

                markRowModified(belayAbItemRequistions.ItemRequisition.Rows[itemRequisitionBindingSource.Position].RowState);

                this.itemRequisitionDetailsTableAdapter.Update(this.belayAbItemRequistions.ItemRequisitionDetails);

                detailNaveDelete.Text = "- Delete";
                detailNaveAddNew.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Belayab Msg"); };
        }

        private void markRowModified(DataRowState rowState)
        {

            switch (rowState)
            {
                case DataRowState.Added:
                case DataRowState.Modified:
                    rowmodified = true;
                    break;
            }

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

        private void saveMain()
        {
            try
            {

                this.Validate();
                this.itemRequisitionBindingSource.EndEdit();

          //      markRowModified(belayAbItemRequistions.ItemRequisitionDetails.Rows[itemRequistionDetailsbSouce.Position].RowState);
                
                logUpdator();

                this.itemRequisitionBindingSource.EndEdit();

                this.itemRequisitionTableAdapter.Update(this.belayAbItemRequistions.ItemRequisition);

                itemRequistionDetailsBNav.Enabled = true;

                MainNavAddnew.Enabled = clsVariables.allow;         

                setAllUnits();



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

           

        }

        private void logUpdator()
        {
            bool rowmodified = false;

            
            if (this.belayAbItemRequistions.ItemRequisition.Rows[itemRequisitionBindingSource.Position].RowState== DataRowState.Added 
                || this.belayAbItemRequistions.ItemRequisition.Rows[itemRequisitionBindingSource.Position].RowState== DataRowState.Modified 
                ||this.belayAbItemRequistions.ItemRequisitionDetails.Rows[itemRequistionDetailsbSouce.Position].RowState == DataRowState.Added
                ||this.belayAbItemRequistions.ItemRequisitionDetails.Rows[itemRequistionDetailsbSouce.Position].RowState == DataRowState.Modified)
           
                    rowmodified = true;
             
          

            if (rowmodified)

                if (createdByTextBox.Text == "")
                {
                    createdByTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                }
                else
                {
                    updatedbyTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
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
            itemRequistionDetailsBNav.Enabled = false;

        }

        private void toolStrpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    itemRequistionDetailsbSouce.RemoveCurrent();
                    saveDetails();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void DeleteWrap_Click(object sender, EventArgs e)
        {
            try
            {
            if(DeleteWrap.Text == "Delete")
            {
               if (MessageBox.Show("All Requistion records will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    itemRequisitionBindingSource.RemoveCurrent();
                      this.itemRequisitionBindingSource.EndEdit();
                      this.itemRequisitionTableAdapter.Update(this.belayAbItemRequistions.ItemRequisition);

                    }
                }
            
            else
            {

                itemRequisitionBindingSource.RemoveCurrent();
                this.itemRequisitionBindingSource.EndEdit();
                this.itemRequisitionTableAdapter.Update(this.belayAbItemRequistions.ItemRequisition);

                    DeleteWrap.Text = "Delete";
   
                
                itemRequistionDetailsBNav.Enabled = false;
                MainNavFirst.Enabled = false;
                MainNavPrevious.Enabled = false;
                MainNavPosition.Enabled = false;


            }


        }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public void tooStrDetailAddnew_Click(object sender, EventArgs e)
        {
            itemRequisitionBindingSource.AddNew();

            if (DeleteWrap.Text == "Delete")
            {
                DeleteWrap.Text = "Cancel";
            }

            //if it has been opened from maintenance form then assign the work order number.
            if (fltr != "") workOrderNoComboBox.Text = fltr.Trim();

            itemRequistionDetailsBNav.Enabled = false;
            MainNavFirst.Enabled = false;
            MainNavPrevious.Enabled = false;
            MainNavPosition.Enabled = false;
            MainNavAddnew.Enabled = false;
            requistionDateDateTimePicker.Text = "";
            requisitionTypeComboBox.SelectedIndex = 0;
            requistionDateDateTimePicker.Value = DateTime.Now;

            storeIDComboBox.SelectedValue = clsVariables.sStore;


            if (clsVariables.sUserIsEmployee) requestedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;

        }

       
        private void toolStrDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!addingNew)
                {
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        itemRequistionDetailsbSouce.RemoveCurrent();
                        saveDetails();

                    }
                }

                else
                {
                    itemRequistionDetailsbSouce.RemoveCurrent();
                    saveDetails();
                    addingNew = false;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ItemRequistionDetailsView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
            //  MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        

        private void itemRequisitionBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //  saveBoth();

            requisitionTypeComboBox.SelectedIndex = 0;

        }

        private void toolStrDetailAddNew_Click(object sender, EventArgs e)
        {

            dv = ItemRequistionDetailsView;
                        
            itemRequistionDetailsbSouce.AddNew();

            detailNaveAddNew.Enabled = false;

            addingNew = true;
            
            dv.CurrentCell = dv[1, dv.CurrentCell.RowIndex];

            if (detailNaveDelete.Text == "- Delete") detailNaveDelete.Text = "Cancel";

        }

        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (requisitionTypeComboBox.Text.Trim() == "ST")
                {
                    if (workOrderNoComboBox.SelectedIndex < 0 || workOrderNoComboBox.Text == "")
                        throw new Exception("Reference Number can not be empty!");
                }
                else
                {
                    if (fromStoreComboBox.SelectedIndex < 0 || fromStoreComboBox.Text == "")
                        throw new Exception("From Store Value can not be empty!");
                }

            if (chkAuto.Checked && requisitionNumberTextBox.Text == "")
                requisitionNumberTextBox.Text = objNumber.getNextAutoNumber("Req");
          
            saveMain();

            }
            catch (Exception exx) { MessageBox.Show(exx.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ItemRequistionDetailsView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (belayAbItemRequistions.ItemRequisitionDetails.GetChanges() != null) saveDetails();
        }

        private void ItemRequistionDetailsView_Leave(object sender, EventArgs e)
        {
            dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }

        private void ItemRequistionDetailsView_Sorted(object sender, EventArgs e)
        {
            GetAllInStock();
            setAllUnits();
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
                requisitionNumberTextBox.ReadOnly = true;
            else
                requisitionNumberTextBox.ReadOnly = false;
        }

        private void ItemRequistionDetailsView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //First Get all descriptions for the sort order
            if (dv.Columns[e.ColumnIndex].Name == "PartNumber")
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
                strSQL = "Select Description from Items Where PartNumber = '" + dv.Rows[Rx].Cells["PartNumber"].Value.ToString().Trim() + "'";
                dv.Rows[Rx].Cells["HD"].Value = objData.getStringValue(strSQL);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void setAllDescriptions()
        {
            try
            {
                int k;

                if (dv == null) dv = ItemRequistionDetailsView;


                for (k = 0; k < dv.Rows.Count; k++)
                    setDesc(k);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void mnuRefreshItems_Click(object sender, EventArgs e)
        {
           
         refreshItems();
        }

        private void mnuShowAll_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList("Requisition",this);
            Program.mainFrm.OpenOverFrm(f);
        }

        private void ItemRequistionDetailsView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
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
                dv.Rows[dv.CurrentCell.RowIndex].Cells["PartNumber"].Value = pNum;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void MainNavPrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();
            rptRequisitionA5  rpt = new rptRequisitionA5();
           

            string strSQL = "Select * from rpt_Requisition Where RequistionNumber ='" +
                requisitionNumberTextBox.Text + "'";

            frmv.SetReport(rpt, strSQL, "rpt_Requisition");
          
            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void btnGotoPurchaseRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseRq frp = new frmPurchaseRq();
            Program.mainFrm.OpenFrm(frp);

        }

        private void requisitionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fromStoreComboBox.Visible = (requisitionTypeComboBox.SelectedItem.ToString() == "TR");
            fromStoreLabel.Visible = (requisitionTypeComboBox.SelectedItem.ToString() == "TR");
            
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  objUtility.setApprover(statusComboBox, approvedByComboBox);
        }

        private void itemBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCurrentBalance fcb = new frmItemCurrentBalance();
            Program.mainFrm.OpenFrm(fcb);
            fcb.fillByItem(dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString());
        }

        private void ItemRequistionDetailsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmItemRequisitions_Activated(object sender, EventArgs e)
        {
            if (clsData.trNo != "")
            {
                int res = itemRequisitionBindingSource.Find("RequisitionNumber", clsData.trNo);
                if (res > -1) itemRequisitionBindingSource.Position = res;
                clsData.trNo = "";
            }

            refreshItems();

            storeIDComboBox.Enabled = false;
        }

        private void frmItemRequisitions_Shown(object sender, EventArgs e)
        {
            storeIDComboBox.Enabled = false;
        }

       
        
    }
}