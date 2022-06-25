using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Belayab
{
    public partial class frmSetting : Form
    {


        public clsUnitMeasurment objUnitMeaseurment = new clsUnitMeasurment();
        public clsPriceSetting objPriceSetting = new clsPriceSetting();
        BindingSource bs = new BindingSource();
        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();

        private   DataGridView dv;

        int order;

        public int selectedId = 0;
        public bool bolForNew = false;
        public bool addingNew = false;
        private string strSQL = "";

        private SqlCommand comm = new SqlCommand();

        public frmSetting()
        {
            InitializeComponent();
            fillListView();
        }



        private void fillListView()
        {
            DataTable dtData;
            dtData =objUnitMeaseurment.getAllUnitMeasurment();
            try
            {
                dtData = objUnitMeaseurment.getAllUnitMeasurment();
                
                objUtility.FillListViewData(lvUnitMeasurment, dtData,2);

            }

            catch (Exception ex) { }


        }

        private void populateUnitMeasurmentValues()
        {
            try
            {

                clearValues();
                txtMeasurementId.Text = lvUnitMeasurment.SelectedItems[0].SubItems[1].Text;
                txtUnitMeasured.Text = lvUnitMeasurment.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception ex) {  }

        }

        private void populatePriceSetting()
        {
            try
            {

              
              
            }
            catch (Exception ex) { }

        }

        private void clearValues()
        {
            foreach (Control Cont in tabSetting.SelectedTab.Controls)
                if (Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
                    Cont.Text = "";

        }

        

        private void getControlFocus()
        {
            if (tabSetting.SelectedTab.Text == "Unit Measurment")
                txtMeasurementId.Focus();
            else
               settiningDateDateTimePicker.Focus();
        }
        private void collectValues()
        {
            if (tabSetting.SelectedTab.Text == "Unit Measurment")
            {
                objUnitMeaseurment.pMeasurementId = this.txtMeasurementId.Text;
                objUnitMeaseurment.pDescription = this.txtUnitMeasured.Text;
            }
           
        }


        private void setAdapterConnectionString()
        {

            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            itemPriceSettingsTableAdapter.Connection = clsData.connBel;
            itemPriceSettingsDetailsTableAdapter.Connection = clsData.connBel;
            this.itemPriceTypesTableAdapter.Connection = clsData.connBel;


        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

            try
            {
                setAdapterConnectionString();


                // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemPriceSettings' table. You can move, or remove it, as needed.
                this.itemPriceSettingsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemPriceSettings);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemPriceSettingsDetails' table. You can move, or remove it, as needed.
                this.itemPriceSettingsDetailsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemPriceSettingsDetails);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemPriceTypes' table. You can move, or remove it, as needed.
                this.itemPriceTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemPriceTypes);

                setDs();


                tabSetting.Height = this.Height;
                tabSetting.Width = this.Width;
                //txtEmpName.Text = objData.getStringValue();

                chkFilterByReceiveNo.CheckState = CheckState.Unchecked;

                //    filterPanel.Enabled = false;

                dv = DetailGrid;

                comm.Connection = clsData.connBel;

               // setAllDescriptions();
            }
            catch (Exception ee)
            { MessageBox.Show(ee.StackTrace, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

   
        private void lvUnitMeasurment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUnitMeasurment.SelectedItems.Count > 0)
            {
                try
                {

                    populateUnitMeasurmentValues();

                    //    bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                }
                catch (Exception ee)
                { }


            }
        }
        public Boolean deletedListview()
        {
            Boolean reValue = false;
            if (tabSetting.SelectedTab.Text == "Unit Measurment")
            {
                if (lvUnitMeasurment.SelectedItems.Count > 0)
                    reValue = true;
            }
           
            return reValue;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            clearValues();
            bolForNew = true;
            btnAddNew.Enabled = false;
            getControlFocus();

            if (btnSave.Enabled == false) btnSave.Enabled = true;
            if (btnDelete.Enabled == false) btnDelete.Enabled = true;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

                       }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletedListview())
                {
                    if (MessageBox.Show("Are you sure to delete?", "Stosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        collectValues();

                        if (tabSetting.SelectedTab.Text == "Unit Measurment")
                        {
                            objUnitMeaseurment.deleteUnitMeasurment();
                            lvUnitMeasurment.SelectedItems[0].Remove();
                            if (lvUnitMeasurment.Items.Count > 0) lvUnitMeasurment.Items[0].Selected = true;

                        }
                         
                    }
                }
            }
            catch (Exception ee)
            {
               }
        }

        
 
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            if (isvalid)//(isDataValid())
            {
                collectValues();


                switch (tabSetting.SelectedTab.Text)
                {
                    case "Unit Measurment":
                        if (!bolForNew)
                        {
                            objUnitMeaseurment.beginTransact();
                            try
                            {
                                objUnitMeaseurment.UpdateUnitMeasurment();
                                fillListView();
                                objUnitMeaseurment.commitTransact();

                            }
                            catch (Exception Exp)
                            {
                                objUnitMeaseurment.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from MeasurmentTypes where MeasurementId = '" + objUnitMeaseurment.pMeasurementId + "'"))
                            {
                                objUnitMeaseurment.beginTransact();
                                try
                                {
                                    objUnitMeaseurment.addUnitMeasurment();
                                    objUnitMeaseurment.commitTransact();

                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objUnitMeaseurment.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                        break;
                    case "Price Setting":

                        if (!bolForNew)
                        {
                            objPriceSetting.beginTransact();
                            
                            try
                            {
                                objPriceSetting.UpdatePriceSetting();

                                //Refresh lst view
                                fillListView();
                                objPriceSetting.commitTransact();


                            }
                            catch (Exception Exp)
                            {
                                objPriceSetting.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {		//Add New 
                            if (true)
                            {
                                objPriceSetting.beginTransact();
                                try
                                {
                                    objPriceSetting.addPriceSetting();
                                    objPriceSetting.commitTransact();

                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objPriceSetting.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        break;
                }
            }
        }

        private void mbtnSave_Click(object sender, EventArgs e)
        {
            saveMain();
        }


        void saveMain()
        {
            try
            {
                itemPriceSettingsBindingSource.EndEdit();
                itemPriceSettingsTableAdapter.Update(belayAbSSDataSetItemsCategories.ItemPriceSettings);

                detailNav.Enabled = true;
                mainNavAddnew.Enabled = true;
                addingNew = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        void saveDetails()
        {
            try
            {
                DetailGrid.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
                itemPriceSettingsDetailsBindingSource.EndEdit();
                itemPriceSettingsDetailsTableAdapter.Update(belayAbSSDataSetItemsCategories.ItemPriceSettingsDetails);
                detailNavAddnew.Enabled = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mainNavDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainNavDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete ? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        itemPriceSettingsBindingSource.RemoveCurrent();
                        saveMain();
                        
                    }
                }
                else
                {
                    itemPriceSettingsBindingSource.RemoveCurrent();
                    saveMain();

                    mainNavDelete.Text = "Delete";
                }


                detailNav.Enabled = true;
                mainNavMoveFirst.Enabled = true;
                mainNavMoveprev.Enabled = true;
                mainNavAddnew.Enabled = true;


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        private void detailNavSave_Click(object sender, EventArgs e)
        {
            saveDetails();
        }

        private void detailNavDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!addingNew)
                {
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        itemPriceSettingsDetailsBindingSource.RemoveCurrent();
                        saveDetails();
                        detailNavAddnew.Enabled = true;

                    }
                }

                else
                {
                    itemPriceSettingsDetailsBindingSource.RemoveCurrent();
                    saveDetails();
                    addingNew = false;
                    detailNavAddnew.Enabled = true;

                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void detailNavAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                bs.Filter = "";
                itemPriceSettingsDetailsBindingSource.AddNew();
                addingNew = true;
                detailNavAddnew.Enabled = false;
            }
            catch (Exception exx) { }

        }


        private void mainNavAddnew_Click(object sender, EventArgs e)
        {
            try
            {
                itemPriceSettingsBindingSource.AddNew();

                bolForNew = true;
                btnAddNew.Enabled = false;
                getControlFocus();
                //          filterPanel.Enabled = true;
                chkFilterByReceiveNo.Enabled = true;

                if (mainNavDelete.Text == "Delete")
                    btnDelete.Text = "Cancel";

                settiningDateDateTimePicker.Text = "";
                settiningDateDateTimePicker.Value = DateTime.Now;

                detailNav.Enabled = !bolForNew;
                mainNavMoveFirst.Enabled = !bolForNew;
                mainNavMoveprev.Enabled = !bolForNew;
                mainNavAddnew.Enabled = !bolForNew;

               txtEmpName.Text = clsVariables.curUserName.Trim();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Stosa"); }


        }

      
        public void setNewPars(string pNo)
        {

            mainNavAddnew_Click(null, null); 

            saveMain();
            detailNavAddnew_Click(null, null);
          
            if (pNo != "")
            {
                bs.Filter = "ItemID = '" + pNo + "'";
                DetailGrid.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value = pNo;
            }

        }

        private void mainNavSave_Click(object sender, EventArgs e)
        {
            saveMain();
        }

        private void chkFilterByReceiveNo_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState == CheckState.Checked)
            {
                receivedNumberComboBox.Enabled = true;
               // receivedNumberTextBox.Enabled = false;
                strSQL = "Select ReceivedNumber, ReceivedNumber + ',  '+ Convert(VarChar,ReceivedDate) As ReceivedDesc from ItemsReceived";
                objUtility.fillComboValues(receivedNumberComboBox, strSQL);
                            

            }

            else
            {
                receivedNumberComboBox.Enabled = false;
                receivedNumberTextBox.Enabled = true;
                
                setDs();

                           
            }

 
            
        }

        private void setDs()
        {
            
            DataSet ds = new DataSet();
            SqlDataAdapter da;
           

       //     if (receivedNumberComboBox.SelectedValue == null) return;

            if (chkFilterByReceiveNo.CheckState == CheckState.Checked)
            {
                strSQL = "SELECT Items.ItemID, Items.PartNumber,  Items.ItemId   + ',  ' + Description AS Description FROM Items INNER JOIN "
                          + " ItemsReceivedDetails ON Items.ItemId = ItemsReceivedDetails.ItemId INNER JOIN "
                           + " ItemsReceived ON dbo.ItemsReceivedDetails.ReceivedNumber = dbo.ItemsReceived.ReceivedNumber"
                           + " Where ItemsReceivedDetails.ReceivedNumber ='" + receivedNumberComboBox.SelectedValue.ToString().Trim() + "' "
                            + " ORDER BY dbo.Items.Description + ',    ' + dbo.Items.ItemId ";
                if(addingNew) receivedNumberTextBox.Text = receivedNumberComboBox.SelectedValue.ToString();
            }

            else
            {
                strSQL = "SELECT Items.ItemID,Items.PartNumber, Items.ItemID + ',  ' + Description  AS Description FROM Items"; 
               
                
                //strSQL = "SELECT Items.ItemID,Items.PartNumber, Description + ',  ' + Items.PartNumber AS Description FROM Items INNER JOIN "
                //         + " ItemsReceivedDetails ON Items.PartNumber = ItemsReceivedDetails.PartNumber INNER JOIN "
                //          + " ItemsReceived ON dbo.ItemsReceivedDetails.ReceivedNumber = dbo.ItemsReceived.ReceivedNumber";
                

            }
            
           

            da = new SqlDataAdapter(strSQL, clsData.connBel);
            da.Fill(ds, "PartNumDescription");
           
            bs.DataSource = ds;
            bs.DataMember = "PartNumDescription" ;

            ItemID.DataSource = null;
            ItemID.Items.Clear();

            ItemID.DataSource = bs;

            ItemID.DisplayMember = "Description";
            ItemID.ValueMember = "ItemId";

            da.Dispose();
            da = null;
           


        }

        private void itemPriceSettingsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //filterPanel.Enabled = false;
            
            chkFilterByReceiveNo.CheckState = CheckState.Unchecked;

        //    if (belayAbSSDataSetItemsCategories.ItemPriceSettings.GetChanges() != null)
        //        saveBoth();

        }

        private void itemPriceSettingsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (belayAbSSDataSetItemsCategories.ItemPriceSettingsDetails.GetChanges() != null)
                saveDetails();
        }


        private void saveBoth()
        {
            saveDetails();
            saveMain();
        }

        private void receivedNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setDs();
        }

        private void itemPriceSettingsDetailsBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }

        private void frmSetting_Activated(object sender, EventArgs e)
        {
          //  filterPanel.Enabled = false;
        }

        private void DetailGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.GetType() == typeof(ArgumentException))// = "ArguementExeption")
                { 
                //chkFilterByReceiveNo.CheckState = CheckState.Unchecked;
                // chkFilterByReceiveNo_CheckedChanged(chkFilterByReceiveNo, new EventArgs());
               // setDs();
                }
        }

        private void itemPriceSettingsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            receivedNumberComboBox.SelectedValue = receivedNumberTextBox.Text;
            chkFilterByReceiveNo.CheckState = CheckState.Unchecked;   
         
        }

       

        private void receivedNumberTextBox_TextChanged(object sender, EventArgs e)
        {

            //chkFilterByReceiveNo.CheckState = CheckState.Unchecked;
            //receivedNumberComboBox.Enabled = false;
           
        }

        private void DetailGrid_Leave(object sender, EventArgs e)
        {
            DetailGrid.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }

        private void DetailGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dv == null) dv = DetailGrid;

          if (dv.Columns[e.ColumnIndex].Name == "ItemID")
                {

                    setDesc(e.RowIndex);

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

                if (dv == null) dv = DetailGrid;
                
                
                for (k = 0; k < dv.Rows.Count; k++)
                    setDesc(k);


              

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void DetailGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //First Get all descriptions for the sort order
            if(dv.Columns[e.ColumnIndex].Name == "ItemID")
            {
               // setAllDescriptions();

                objUtility.sortGrid(dv, order, "HD");
                order = order % 2 + 1;
            }

        }

        private void DetailGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void mainNavPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnImportPrices_Click(object sender, EventArgs e)
        {
            frmDataImport fdi = new frmDataImport();
            fdi.itemPriceIDTextBox.Text = this.itemPriceIDTextBox.Text;
            fdi.tabType.SelectedIndex = 1;
            fdi.fset = this;
            Program.mainFrm.OpenFrm(fdi);
        }

        public void RefreshPriceList()
        {

            this.itemPriceSettingsDetailsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemPriceSettingsDetails);

        }
    }
}