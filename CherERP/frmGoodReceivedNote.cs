using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;



namespace Belayab
{
    public partial class frmGoodReceivedNote : Form
    {
       public string vType = "Import";


        DataSet ds = new DataSet();
        SqlDataAdapter  da ;
        DataGridView dv;
        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();
        clsReceiving objReceiving = new clsReceiving();
        clsNumbers objNumber = new clsNumbers();
       
        int order = 1;

        bool rowmodified = false;
        bool saveOk = false;


        static string fltr = "";

        string strSQL = "";
        bool addingNew = false;
        bool addingAll = false;
        
  //      SqlCommand comm = new SqlCommand();               
       


        public frmGoodReceivedNote()
        {
            InitializeComponent();
        }

        public frmGoodReceivedNote(string strGRN)
        {
            fltr = strGRN;
            InitializeComponent();
            
        }

   
        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                if (chkAuto.Checked && receivedNumberTextBox.Text == "")
                    receivedNumberTextBox.Text = objNumber.getNextAutoNumber("GRN");
                
                saveMain();
                MainNavAddnew.Enabled = true;

                saveOk = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void validateSave()
        {
          
            if (StatusTextBox.Text == "Closed" && !saveOk)
            {
                throw new Exception("Status closed! Record not modifiable. Please activate ther record first!");
            }

            if (cboVouchureType.SelectedItem == null || cboVouchureType.Text =="")
            {
                throw new Exception("Please Select a Valid Voucher Type");
            }
        }

        private void frmGoodReceivedNote_Load(object sender, EventArgs e)
        {
                              
           try
            {
                dv = DetailGridView;

                setAdapterConnectionString();

                string strSQL;

                strSQL = "Select Distinct DeliveredBy from ItemsReceived";
                objUtility.fillComboValues(deliveredByComboBox, strSQL);


                strSQL = "Select Distinct EmployeeId,EmployeeName From Employees Order By employeeName";
                //   objUtility.fillComboValues(requestedByComboBox, strSQL);
                objUtility.fillComboValues(approvedByComboBox, strSQL);
                objUtility.fillComboValues(preparedByComboBox, strSQL);
           

                strSQL = "Select StoreId, StoreName  from Stores";
                objUtility.fillComboValues(storeIDComboBox, strSQL);

                strSQL = "Select Distinct SupplierId, SupplierName From Suppliers Order By SupplierName";
                objUtility.fillComboValues(supplierIdComboBox, strSQL);
        

                 // TODO: This line of code loads data into the 'belayAbSSDataSet1.Delivered_ByList' table. You can move, or remove it, as needed.
                this.delivered_ByListTableAdapter.Fill(this.belayAbSSDataSet1.Delivered_ByList);
                // TODO: This line of code loads data into the 'belayAbSSDataSet1.SupplierList' table. You can move, or remove it, as needed.
                this.supplierListTableAdapter.Fill(this.belayAbSSDataSet1.SupplierList);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.EmployeesLst' table. You can move, or remove it, as needed.
                this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
           
                // TODO: This line of code loads data into the 'belayAbSSDataSet1.MeasurmentUnits' table. You can move, or remove it, as needed.
                this.measurmentUnitsTableAdapter.Fill(this.belayAbSSDataSet1.MeasurmentUnits);

                this.itemsReceivedTableAdapter.ClearBeforeFill = true;
                this.itemsReceivedDetailsTableAdapter.ClearBeforeFill = true;


                // TODO: This line of code loads data into the 'belayAbReceived.ItemsReceived' table. You can move, or remove it, as needed.
                if (fltr!="")
                    this.itemsReceivedTableAdapter.FillByReceivedNo(this.belayAbReceived.ItemsReceived, fltr);
                else
                {
                    //  this.itemsReceivedTableAdapter.FillByStore(this.belayAbReceived.ItemsReceived, clsVariables.sStore);
                    this.itemsReceivedTableAdapter.FillByStoreVoucher(this.belayAbReceived.ItemsReceived, clsVariables.sStore, cboVouchureType.Text.Trim());
                }

                // TODO: This line of code loads data into the 'belayAbSSDataSet1.ItemsReceivedDetails' table. You can move, or remove it, as needed.

                this.itemsReceivedDetailsTableAdapter.Fill(this.belayAbReceived.ItemsReceivedDetails);


                setPermissions();

                if (cboVouchureType.Text == "" || cboVouchureType.Text == null)
                    cboVouchureType.Enabled = true;
                else
                    cboVouchureType.Enabled = false;
                
                calculateEveryTotal();

                



            }
           catch (Exception ex) { MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

       
        private void setContrlDataSource()
        {
           try
           {

           
            if (ds.Tables.Contains("PartNumDescription"))
                {
                    ItemID.DataSource = ds.Tables[0];
                    ItemID.DisplayMember = "Description";
                    ItemID.ValueMember = "ItemID";
                    return;
                }

            strSQL = "Select * From PartNumDescription order by Description";

            da = new SqlDataAdapter(strSQL, clsData.connBel);

            da.Fill(ds, "PartNumDescription");

            ItemID.DataSource = null;

            ItemID.Items.Clear();

            ItemID.DataSource = ds.Tables[0];
            ItemID.DisplayMember = "Description";
            ItemID.ValueMember = "ItemID";

           }
           catch (Exception ex) { MessageBox.Show(ex.Message); }

            
        }

        
        private void setAdapterConnectionString()
        {

         //   partNumDescriptionTableAdapter.Connection = clsData.connBel;
            itemsReceivedDetailsTableAdapter.Connection = clsData.connBel;
            itemsReceivedTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;
            delivered_ByListTableAdapter.Connection = clsData.connBel;
            supplierListTableAdapter.Connection = clsData.connBel;
            measurmentUnitsTableAdapter.Connection = clsData.connBel;

        }

        private void toolStrSaveDetails_Click(object sender, EventArgs e)
        {
            try
            {


                saveDetails();
                updateRequests();
                //   calculateEveryTotal();
               

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

      
 
  
        //private void SetUnit(int Rx)
        //{
        //    try
        //    {
        //        string strPn = dv.Rows[Rx].Cells["PartNumber"].Value.ToString().Trim();
        //        comm.CommandText = "GetUnit '" + strPn + "'";
        //        dv.Rows[Rx].Cells["Units"].Value = comm.ExecuteScalar().ToString();
        //        comm.CommandText = "Select Description from Items Where PartNumber = '" + strPn + "'";
        //        dv.Rows[Rx].Cells["HD"].Value = comm.ExecuteScalar().ToString();

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message); }
        //}

        private void calculateTotal(int row)
        {
      //      float price = 0, tot = 0;
      //      int qty = 0;

      //      try
      //      {
      //          dv = DetailGridView;

      //          if (row < dv.Rows.Count )
      //          {
      //              if (int.TryParse(dv.Rows[row].Cells["Quantity"].Value.ToString(), out qty) &&
      //                   float.TryParse(dv.Rows[row].Cells["UnitCost"].Value.ToString(), out price))
      //                              tot = price * qty;

      //              dv.Rows[row].Cells["TotalCost"].Value = tot;
      //          }

      //      }

      //catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void calculateEveryTotal()
        {
            try
            {
                int k;

                if (dv == null) dv = DetailGridView;

                //     for ( k= 0; k < dv.Rows.Count; k++)
               
                //          calculateTotal(k);
                
                
                //for (k = 0; k < dv.Rows.Count; k++)
                //    SetUnit(k);

                calculateGrandTotal();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void calculateGrandTotal()
        {
            float sum = 0, fval=0;

          if (dv == null)  dv = this.DetailGridView;

          try
            {
             for (int k = 0; k < dv.Rows.Count; k++)
                {
                    if( float.TryParse(dv.Rows[k].Cells["TotalCost"].Value.ToString(),out fval))
                            sum += fval;
                }
            
              txtTotal.Text = string.Format("{0: Br #,##0.00}", sum);
            }

       catch (Exception ex) { MessageBox.Show(ex.Message+ "1" ); }

           
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


        
       
        private void itemsReceivedDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dv = this.DetailGridView;

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].Name == "UnitCost" ||
                    (dv.Columns[e.ColumnIndex].Name == "Quantity"))
                {
                    calculateTotal(e.RowIndex);
                    calculateGrandTotal();
                }
                else if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {

           //         SetUnit(e.RowIndex); 

                }

                dv.Rows[e.RowIndex].ErrorText = "";
            }

            catch (Exception ex)
            {
                if (e.RowIndex >= 0) dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }

        }

        private void itemsReceivedDetailsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float val;
            //DataGridView dv = invoiceDetailsDataGridView;

            dv.Rows[e.RowIndex].ErrorText = "";
            if ((dv.Columns[e.ColumnIndex].DataPropertyName == "UnitCost") ||
                   (dv.Columns[e.ColumnIndex].DataPropertyName == "Quantity"))
            {
                if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                {
                    dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                    e.Cancel = true;
                }
            }
        }

      

        private void saveDetails()
        {
            try
            {

                validateSave();
                calculateEveryTotal();

                dv.EndEdit();
                dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
                this.itemsReceivedDetailsBindingSource.EndEdit();

                if (itemsReceivedDetailsBindingSource.Position >= 0)
                {    
                   
                    switch (this.belayAbReceived.ItemsReceivedDetails.Rows[itemsReceivedDetailsBindingSource.Position].RowState)
                    {
                        case DataRowState.Added:
                        case DataRowState.Modified:
                            rowmodified = true;
                            break;
                    }

                    markRowModified();

                }

                
                this.itemsReceivedDetailsBindingSource.EndEdit();
                this.itemsReceivedDetailsTableAdapter.Update(this.belayAbReceived.ItemsReceivedDetails);

                DetailNavAddnew.Enabled = clsVariables.allow;
                
                DetailNavDelete.Text = "- Delete";
                DetailNavAddnew.Enabled = true;

                rowmodified = false;



            }
            catch (SqlException exS)
            {
                if (exS.Message.Contains("DENIED")) 
                    itemsReceivedBindingSource.CancelEdit();
                    DetailNavAddnew.Enabled = clsVariables.allow;

            }

            catch (Exception ex)
            {
               // if (!addingNew) MessageBox.Show(ex.Message + "2");

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
    
        }

        private void updateRequests()
        {
            string issueNo, WoN;
            decimal woQty=0, retQty=0;
            //    issueNo = objData.getFieldValue("Select IssueNo From ItemsIssued Where IssueNo ='" + referenceNumberComboBox.Text.Trim() + "'");
            issueNo = referenceNumberComboBox.Text.Trim();
            if (issueNo!="" || issueNo !=null)
               WoN = objData.getFieldValue("Select WorkOrderNumber from WorkOrder_Requested_Issued Where IssueNo ='" + issueNo + "'");
            else
                throw new Exception("Requisition or issue number is not valid!");

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
                           // string UnitP = dv.Rows[k].Cells["UnitPrice"].Value.ToString();
                            string itemCat = objData.getFieldValue("Select CategoryID from Items Where ItemID='" + newPart + "'");
                            string tableName;

                            retQty = Convert.ToDecimal(quantity);

                            if (itemCat == "FL")
                                tableName = "m_Fuel_Lubricatnts";
                            else
                                tableName = "m_Replaced";


                            if (objData.exists("Select * from " + tableName + " Where mNumber ='" + WoN + "'" + " And ItemID ='" + newPart + "'"))
                            {
                                woQty = objData.getFieldAmt("Select Quantity From " + tableName + " Where ItemID='" + newPart + "' AND mNumber ='" + WoN + "'");
                                if (woQty > retQty)
                                    { retQty = woQty - retQty;
                                        objData.updateRecord(tableName, "mNumber,  ItemID, Quantity, [SIV No] ", "'" + WoN + "'" + ",'" + newPart + "'," + retQty.ToString() + ",'" + issueNo + "'",
                                            " mNumber ='" + WoN + "'" + " And ItemID ='" + newPart + "'", true);
                                    }
                                else if (woQty == retQty)
                                {
                                    objData.deleteRecord(tableName, " mNumber ='" + WoN + "'" + " And ItemID ='" + newPart + "'");
                                }


                            }
                            //   objData.addNewRecord(tableName, "mNumber,  ItemID, Quantity, UnitPrice, [SIV No]", "'" + WoN + "'" + ",'" + newPart + "'," + quantity + "," + UnitP + ",'" + issueNo + "'", true);
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

           // rowmodified = false;

        }

        private void saveMain()
        {

            calculateEveryTotal();


            this.Validate();
            this.itemsReceivedBindingSource.EndEdit();
            if (itemsReceivedBindingSource.Position >= 0)
            {
                switch (this.belayAbReceived.ItemsReceived.Rows[itemsReceivedBindingSource.Position].RowState)
                {
                    case DataRowState.Added:
                    case DataRowState.Modified:
                        rowmodified = true;
                        break;
                }

                markRowModified();

            }

            //button1_Click(null, null);

            this.itemsReceivedBindingSource.EndEdit();
            this.itemsReceivedTableAdapter.Update(this.belayAbReceived.ItemsReceived);
            
            itemsReceivedDetailsBNav.Enabled = true;
           

            setPermissions();

            rowmodified = false;

        }

        private void saveBoth()
        {
            saveDetails();
            saveMain();
        }

            

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
             saveBoth();
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

            saveDetails();
            
        }

        public void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            itemsReceivedBindingSource.AddNew();
            
            if (MainNavDelete.Text == "Delete")
            {
                MainNavDelete.Text = "Cancel";
                
            }

            itemsReceivedDetailsBNav.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            MainNavAddnew.Enabled = false;
            MainNavPosition.Enabled = false;
            receivedDateDateTimePicker.Text="";
            receivedDateDateTimePicker.Value = DateTime.Now;
            storeIDComboBox.SelectedValue = clsVariables.sStore;
            receivingTypeComboBox.Text = "REC";
            this.cboVouchureType.Text = this.vType;
            this.cboVouchureType.Enabled = false;

            if (clsVariables.sUserIsEmployee) ReceivedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;

            StatusTextBox.Text = "Active";
        }

        public void callNew()
        {
            bindingNavigatorAddNewItem_Click(null, null);
            MainNavDelete.Text = "Cancel";
        }
        private void DeleteWrap_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                if (MessageBox.Show("This receiving record with details will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    itemsReceivedBindingSource.RemoveCurrent();
                    saveMain();
                }

                return;

                if (MainNavDelete.Text == "Delete")
                {
                    if (MessageBox.Show("All receiving records will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        itemsReceivedBindingSource.RemoveCurrent();
                        saveMain();
                    }
                }
                else
                {
                    itemsReceivedBindingSource.RemoveCurrent();
                    saveMain();
                    
                    MainNavDelete.Text = "Delete";
                }

    
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                MainNavPosition.Enabled = true;
                MainNavAddnew.Enabled = true;

           }
            catch (Exception ex) { MessageBox.Show(ex.Message ); }
        }

        private void toolStrpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                if (!addingNew)
                {
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        itemsReceivedDetailsBindingSource.RemoveCurrent();
                        saveDetails();
                        DetailNavAddnew.Enabled = true;

                       
                    }
                }
                
                else
                
                {
                    itemsReceivedDetailsBindingSource.RemoveCurrent();
                    saveDetails();
                    addingNew = false;
                    DetailNavAddnew.Enabled = true;

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        

        private void itemsReceivedDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }

        private void itemsReceivedBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        private void toolStrAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                dv = DetailGridView;
                addingNew = true;
                itemsReceivedDetailsBindingSource.AddNew();
                DetailNavAddnew.Enabled = false;
                
                if (DetailNavDelete.Text == "- Delete") DetailNavDelete.Text = "Cancel";
             
                
          //      dv.CurrentCell = dv[1, dv.CurrentCell.RowIndex];

               

            }
            catch (Exception ex) { }
        }

        private void toolStrGRNPrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer  frmv = new frmReportsViewer();

            string strSQL = "Select * from GoodsReceivedView where ReceivedNumber = '" +
                receivedNumberTextBox.Text + "'";

            frmv.SetReport(new rptGRNA5(), strSQL, "GoodsReceivedView");

            Program.mainFrm.OpenOverFrm(frmv);

        }

       
        private void itemsReceivedDetailsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
               if (belayAbReceived.ItemsReceivedDetails.GetChanges() !=null)  saveDetails();
        }

       

        private void supplierIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemsReceivedDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            addingNew = false;
            DetailNavAddnew.Enabled = true;
        }

        public void setPermissions()
        {
            if (clsVariables.userRole == "Admin") return;
            
            if (clsVariables.userRole.Contains("Store") || clsVariables.userRole.Contains("Finance"))
            {
                dv.Enabled = true;
                Permitfrm(true);
               // PermitUC(false);
                dv.Columns["UnitCost"].ReadOnly = false;
            }
         
            else
            {
                Permitfrm(false);
                dv.Columns["UnitCost"].ReadOnly = true;
                //  PermitUC(true);
            }


        }

        private void Permitfrm(bool val)
        {
            clsData.objSecurity.setCommonPermissionsMain(MainNavAddnew, MainNavSave, MainNavDelete, MainNavePrint, val);
            clsData.objSecurity.setCommonPermissionsDetail(DetailNavAddnew, DetailNavSave, DetailNavDelete, null, val); 
         }

        private void PermitUC(bool val)
        {
            dv.Columns["UnitCost"].ReadOnly = true;
            for (int i = 0; i < dv.Columns.Count-1; i++)
                if (dv.Columns[i].Name != "UnitCost") dv.Columns[i].ReadOnly = val;
                 


        }

      

        private void DetailGridView_Leave(object sender, EventArgs e)
        {
            dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }

        private void btnEditSuppliers_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers f = new frmCustomersSuppliers(this);
            Program.mainFrm.OpenFrm(f);
            f.tabSupplier_Customer.SelectedIndex = 0;
            
        }

        public void updateSupplierList()
        {

            //string  strSQL = "Select Distinct SupplierId, SupplierName From Suppliers";
            //objUtility.fillComboValues(supplierIdComboBox, strSQL);
            //supplierIdComboBox.Refresh();

        }

        private void DetailGridView_Sorted(object sender, EventArgs e)
        {
            calculateEveryTotal();
        }

    
        private void DetailGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReceivedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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


                for (k = 0; k < dv.Rows.Count-1; k++)
                    setDesc(k);




            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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


        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
                receivedNumberTextBox.ReadOnly = true;
            else
                receivedNumberTextBox.ReadOnly = false;
        }

        private void mnuRefreshItems_Click(object sender, EventArgs e)
        {
           refreshItems();
        }

        private void mnuAllItems_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList("Receiving",this);
            Program.mainFrm.OpenOverFrm(f);
        }

        private void DetailGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void DetailGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

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

        private void frmGoodReceivedNote_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
                if (e.KeyValue  == (int)Keys.S )
                    saveBoth();
        }
    
        private void refreshItems()
        {
             ds.Clear();
             da.Fill(ds, "PartNumDescription");
             da.Dispose();
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

        private void frmGoodReceivedNote_Activated(object sender, EventArgs e)
        {
            try
            {
                if (clsData.trNo != "")
                {
                    int res = itemsReceivedBindingSource.Find("ReceivedNumber", clsData.trNo);
                    if (res > -1) itemsReceivedBindingSource.Position = res;
                    clsData.trNo = "";

                    //The Status button value
               }

                //           refreshItems(); Item list will be refreshed!!


                if (StatusTextBox.Text == "Closed") btnCloseActivate.Text = "Activate";


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmGoodReceivedNote_Shown(object sender, EventArgs e)
        {
            storeIDComboBox.Enabled = false;

        }

        private void receivingTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblLCNo.Visible = (receivingTypeComboBox.Text.Trim().ToUpper() == "PUR");
            lCNumberTextBox.Visible = (receivingTypeComboBox.Text.Trim().ToUpper() =="PUR");

            string refNo = referenceNumberComboBox.Text;

            referenceNumberComboBox.DataSource = null;
            referenceNumberComboBox.Items.Clear();


            switch (receivingTypeComboBox.Text.Trim())
            {
                case "PUR":
                    {
                        strSQL = "GetNonReceivedPurchaseRequisitions @Store =N'" + clsVariables.sStore + "'";
                        referenceNumberComboBox.DisplayMember = "PerchaseReqNo";
                        //    referenceNumberComboBox.ValueMember = "RequisitionNumber";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                    }
                    break;

                case "RETI":
                    {
                        strSQL = "GetNonReturnedIssues '" + clsVariables.sStore + "'";
                        referenceNumberComboBox.DisplayMember = "IssueNo";
                        //      referenceNumberComboBox.ValueMember = "InvoiceNo";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                    }
                    break;

                case "RETT":
                    {
                        strSQL = "GetNonReturnedTransfers 'Credit'";
                        referenceNumberComboBox.DisplayMember = "InvoiceNo";
                        //      referenceNumberComboBox.ValueMember = "InvoiceNo";
                        objUtility.fillComboValues(referenceNumberComboBox, strSQL);
                    }
                    break;
                default:
              //      referenceNumberComboBox.Text = receivingTypeComboBox.Text;
                    setContrlDataSource();
                    break;
            }


            if (refNo != "") referenceNumberComboBox.Text = refNo;



        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            DataTable dtParts = new DataTable();

            try
            {
                addingAll = true;
                dtParts = (DataTable)ItemID.DataSource;
                int qty;

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
                            itemsReceivedDetailsBindingSource.EndEdit();
                            this.Validate();
                            itemsReceivedDetailsBindingSource.AddNew();
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

        private void referenceNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
          //  SqlDataAdapter da;


            

            switch (receivingTypeComboBox.Text.Trim())
            {
                case "PUR":
                    {
                        strSQL = "GetItemsInPurchaseRequisition '" + referenceNumberComboBox.Text.Trim() + "'";

                        objUtility.fillComboValues(ItemID, strSQL);

                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";

                        // Get the suppliername
                        int supID;
                      

                        strSQL = "Select Supplier from PurchaseRequisition Where PerchaseReqNo ='" + referenceNumberComboBox.Text.Trim() + "'";
                        supID = (int)objData.getFieldAmt(strSQL);
                        supplierIdComboBox.SelectedValue = supID;

                    }
                    break;

                case "RETR":
                    {
                        strSQL = "GetItemsInIssue '" + referenceNumberComboBox.Text.Trim() + "'";

                        objUtility.fillComboValues(ItemID, strSQL);

                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";


                    }
                    break;
                case "RETT":
                    {

                        strSQL = "GetItemsInRequisition '" + referenceNumberComboBox.Text.Trim() + "'";

                        objUtility.fillComboValues(ItemID, strSQL);
                        ItemID.DisplayMember = "Description";
                        ItemID.ValueMember = "ItemID";

                    }
                    break;

                default:
                    // referenceNumberComboBox.Text = issueTypeIdComboBox.Text; ;
                    setContrlDataSource();
                    break;
            }



        }

        private void DetailGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dv = this.DetailGridView;

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].Name == "Qty")
                {
                    calculateTotal(e.RowIndex);
                    calculateGrandTotal();

             //       dv.Rows[e.RowIndex].Cells["InStock"].Value = oldQty - double.Parse(dv.CurrentCell.Value.ToString());

                }
                else if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {
                    double reqAmt =0;

                        reqAmt = objData.GetValueInOrder(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(),
                          referenceNumberComboBox.Text, receivingTypeComboBox.Text.Trim());

                        dv.Rows[e.RowIndex].Cells["Qty"].Value = reqAmt;
                }

                dv.Rows[e.RowIndex].ErrorText = "";

            }

            catch (Exception ex)
            {
                if (e.RowIndex >= 0) dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }

        }

        private void DetailGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            setContrlDataSource();
        }

        private void btnCloseActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCloseActivate.Text == "Activate")
                {
                    if (clsVariables.curUserName == "ADMIN" || clsVariables.curUserName == "TAYE" ||
                          clsVariables.curUserName == "YARED" || clsVariables.curUserName == "BELAYAB" ||
                          clsVariables.curUserName == "TENSAE")
                    {
                        StatusTextBox.Text = "Active";
                        btnCloseActivate.Text = "Close";
                        this.belayAbReceived.EndInit();
                    }

                    else
                    {
                        throw new Exception("You Can't do this with your current account!");

                    }
                }
                else
                {

                    StatusTextBox.Text = "Closed";
                    btnCloseActivate.Text = "Activate";
                    belayAbReceived.EndInit();
                }
                saveOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsReceivedDetails_RowChanged(DataGridViewCellEventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            rowmodified= true;
        }

       

       
    }
}       
        
    
