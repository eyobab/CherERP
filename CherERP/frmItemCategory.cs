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
    public partial class frmItemCategory : Form
    {

        DataGridViewComboBoxCell dvcCell = new DataGridViewComboBoxCell();

        DataGridView dv;
        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();
        bool addingNew = false;
        DataGridViewCell curCell;

        string fltrV = "";
        string fltrC = "", fltrP="";
        
        string strSQL,srvTypeTag;

        clsImage objImage = new clsImage();
        string imagePath = Application.StartupPath + "\\ItemImage.jpg";
        string noPhotoPath = Application.StartupPath + "\\NoPhoto.jpg";
        
        
        BindingSource bsItem = new BindingSource();

        BindingSource bs = new BindingSource();

        public frmItemCategory()
        {
            InitializeComponent();

            updateTruckTypeCboBox();
           
        }

      public frmItemCategory(string strVType, string strCatId)
        {
            fltrV = strVType;
            fltrC = strCatId;
            
            InitializeComponent();

            updateTruckTypeCboBox();
        }

        public frmItemCategory(string strVType, string strCatId,string strPn)
        {
            fltrV = strVType;
            fltrC = strCatId;
            fltrP = strPn;

            InitializeComponent();

            updateTruckTypeCboBox();
        }


        private void setAdapterConnectionString()
        {
            categoryListTableAdapter.Connection = clsData.connBel;
        //  truckTypesTableAdapter.Connection = clsData.connBel;
            itemsTableAdapter.Connection = clsData.connBel;
            categoriesTableAdapter.Connection = clsData.connBel;
            measurmentTypesTableAdapter.Connection = clsData.connBel;
            locationViewTableAdapter.Connection = clsData.connBel;
          }

        private void saveCategories()
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.categoriesTableAdapter.Update(this.belayAbSSDataSetItemsCategories.Categories);

            
            ItembindingNavigatorItem.Enabled = true;         
        }
        private void saveItems()
        {
            try
            {
            
                    this.itemsBindingSource.EndEdit();
                    this.itemsTableAdapter.Update(this.belayAbSSDataSetItemsCategories.Items);

                    MainNavAddnew.Enabled = clsVariables.allow;
                    DeleteItem.Text = "Delete";
                    AddItem.Enabled = true;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
                AddItem.Enabled = true;

            }

        }
        private void checkData()
        {
            
            if (txtCategoryId.Text == "")
            {
             
               MessageBox.Show(" Please enter the category  ", " Belayab ");

                if (truckTypeIdTextBox.Text == "")
                   truckTypeIdTextBox.Text = truckTypeComboBox.SelectedValue.ToString();

               txtCategoryId.Focus();
            }
        }

     
        private void frmItemCategory_Load(object sender, EventArgs e)
        {
            try
            {

                dv = itemsDataGridView;
               
                setAdapterConnectionString(); 

                //this.truckTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.TruckTypes);
                this.itemsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Items);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.CategoryList' table. You can move, or remove it, as needed.
                this.categoryListTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.CategoryList);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.Categories' table. You can move, or remove it, as needed.
                this.categoriesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Categories);
                this.measurmentTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.MeasurmentTypes);
                // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.LocationView' table. You can move, or remove it, as needed.
                this.locationViewTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.LocationView);

                //   stock(); 

                if (fltrV != "")
                {
                    truckTypeComboBox.SelectedValue = fltrV;
                    truckTypeComboBox.Text = objData.getStringValue(
                        "Select VehicleType from m_VehicleType where VehicleType = '" + fltrV.Trim() + "'").ToString(); ;
                }

                truckTypeComboBox_SelectedIndexChanged(new object(), new EventArgs());

                if (fltrC != "")
                {
                    int ret =categoriesBindingSource.Find("CategoryId", fltrC);
                    if (ret > -1) categoriesBindingSource.Position = ret;

                }

                if (fltrP != "")
                {
                    
                    bsItem.DataSource = itemsDataGridView.DataSource;
                    bsItem.DataMember = itemsDataGridView.DataMember;

                    
                    int ret = bsItem.Find("PartNumber", fltrP);
                    if (ret > -1) itemsBindingSource.Position = ret;


                }

                lstCats.DataSource = categoriesBindingSource;
                lstCats.DisplayMember = "CategoryName";
                lstCats.ValueMember = "CategoryName";

                txtCategoryId.Focus();
                      
              }
            catch (Exception ex) {}// MessageBox.Show(ex.Message); }

        }

        private void saveBoth()
        {
            saveItems();
            saveCategories();
           
        }

     
     
        private void enableCategoryBindings()
        {
               categorybindingNavigatorMoveFirstItem.Enabled = true;
                categorybindingNavigatorMoveNextItem.Enabled = true;
                categorybindingNavigatorMoveLastItem.Enabled = true;
                categorybindingNavigatorMovePreviousItem.Enabled = true;
                categoriesbindingNavigatorPositionItem.Enabled = true;
                MainNavAddnew.Enabled = true;
                MainNavPrint.Enabled = true;

        }
        private void disableCategoryBindings()
        {
                categorybindingNavigatorMoveFirstItem.Enabled = false;
                categorybindingNavigatorMoveNextItem.Enabled = false;
                categorybindingNavigatorMovePreviousItem.Enabled = false;
                categorybindingNavigatorMovePreviousItem.Enabled = false;
                categoriesbindingNavigatorPositionItem.Enabled = false;
                MainNavAddnew.Enabled = false;
                MainNavPrint.Enabled = false;
               
        }
        private void disableItemsBindings()
        {
            ItembindingNavigatorMoveFirstItem.Enabled = false;
            ItembindingNavigatorMoveNextItem.Enabled = false;
            ItembindingNavigatorMovePreviousItem.Enabled = false;
            ItembindingNavigatorMovePreviousItem.Enabled = false;
            ItembindingNavigatorPositionItem.Enabled = false;
           AddItem.Enabled = false;
           

        }
        private void enableItemsBindings()
        {
            ItembindingNavigatorMoveFirstItem.Enabled = true;
            ItembindingNavigatorMoveNextItem.Enabled = true;
            ItembindingNavigatorMovePreviousItem.Enabled = true;
            ItembindingNavigatorMovePreviousItem.Enabled = true;
            ItembindingNavigatorPositionItem.Enabled = true;
            AddItem.Enabled = true;
           

        }

        

        private void itemsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

      

        private void itemsBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void itemsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float val;
            
            dv.Rows[e.RowIndex].ErrorText = "";
            if ((dv.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice"))
            {
                if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                {
                    dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                    e.Cancel = true;
                }
            }
        }

  
        private void AddItem_Click(object sender, EventArgs e)
        {
            
            dv = itemsDataGridView;
            itemsBindingSource.AddNew();
            disableItemsBindings();
            addingNew = true;
            dv.CurrentCell = dv[0, dv.CurrentCell.RowIndex];

            if (DeleteItem.Text == "Delete")
                DeleteItem.Text = "Cancel";
        

        }

        private void saveItemss_Click(object sender, EventArgs e)
        {
            try
            {
                dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);

                if (dv.Rows[dv.CurrentCell.RowIndex].Cells["PartNumber"].Value.ToString() != "")
                {
                    saveItems();
                    enableItemsBindings();
                    enableCategoryBindings();
                 //   MessageBox.Show("Sucessfully Saved", " Belayab");
                }
                else
                {
                    MessageBox.Show("An item must have PartNumber :", " Belayab");
                    dv.CurrentCell = dv[0, dv.CurrentCell.RowIndex];
                }
               


            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        itemsBindingSource.RemoveCurrent();
                        saveItems();

                    }
               


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

       

        }
        //june 05 2007
        private void categoriesbindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            

            if (MainNavDelete.Text == "Delete")
            {

                categoriesBindingSource.AddNew();
                
                MainNavDelete.Text = "Cancel";

                disableCategoryBindings();

                ItembindingNavigatorItem.Enabled = false;

                serviceTypeTextBox.Text = srvTypeTag;
                
            }
            
            truckTypeIdTextBox.Text = truckTypeComboBox.SelectedValue.ToString();

        }

        private void categoriesBindingNavigtorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainNavDelete.Text == "Delete")
                {
                    if (MessageBox.Show("All Items in this Category will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        categoriesBindingSource.RemoveCurrent();
                        saveCategories();
                    }
                }
                else
                {
                    categoriesBindingSource.RemoveCurrent();
                    saveCategories();

                    MainNavDelete.Text = "Delete";
                }


                enableCategoryBindings();
                ItembindingNavigatorItem.Enabled = true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        
        }

        private void categoriesbindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                checkData();
                saveCategories();
                MainNavDelete.Text = "Delete";
                enableCategoryBindings();
             //   enableItemsBindings();
                ItembindingNavigatorItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Belayab ");
            }

        }

        private void itemsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void btnPrintCurrentCategory_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_ItemList where [Category Id] = '" +
                txtCategoryId.Text + "'";

            frmv.SetReport(new rptItemList(), strSQL, "rpt_ItemList");

            Program.mainFrm.OpenOverFrm(frmv);

        }

       

        public void DisplayImage()
        {
            try
            {
                if (!addingNew)
                {

                    clsImage.imagePath = this.imagePath;

                   objImage.DisplayPhoto(belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "ItemID",
                        itemsDataGridView.Rows[itemsDataGridView.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString(), imgItem, clsImage.imagePath);

                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name != "NullReferenceException") 
                   MessageBox.Show(ex.Message   , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {

            try
            {
                openDlg.FileName = "";

                openDlg.ShowDialog();


                imagePath = openDlg.FileName;

                if (imagePath == "")
                {
                    clsImage.imagePath = "";
                    return;
                }

                clsImage.imagePath = this.imagePath;
                // 'Then add  the photo to the dataset

                //***************
                //SavePhoto(photopath, dsEmployees1, "Photo");

               
                if (itemsDataGridView.Rows.Count > 0)
                {
                          objImage.SavePhoto(belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "PartNumber",
                            itemsDataGridView.Rows[itemsDataGridView.CurrentCell.RowIndex].Cells["PartNumber"].Value.ToString(), ref clsImage.newImagePath);

                   
                }
                //'And display the new photo

                //***********************
                DisplayImage();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Image Saveing Displaying"); }
        }

        
        private int  getRowPos()
        {
            try
            {
                string filtr = itemsDataGridView.Rows[itemsDataGridView.CurrentCell.RowIndex].Cells["PartNumber"].Value.ToString();
              
                BindingSource bs = new BindingSource();
                bs.DataSource = itemsDataGridView.DataSource;
                bs.DataMember = itemsDataGridView.DataMember;
                
                int ret = bsItem.Find("PartNumber",filtr.Trim());
                  
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; }

        }
        private void itemsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                clsData.pNum = dv.Rows[curCell.RowIndex].Cells["PartNumber"].Value.ToString();
                Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }
            catch (Exception ex)
            {
                Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }       
        }

        

        private void itemsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                curCell = dv[e.ColumnIndex, e.RowIndex];

                DisplayImage();
            }

            catch (Exception ex)
            {
                
                //MessageBox.Show(ex.Message, "Stosa");
            }       
        }

        private void truckTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                if (truckTypeComboBox.SelectedValue != null && truckTypeComboBox.SelectedValue.ToString() != "" && truckTypeComboBox.Text.Trim() != "All")
                {
                    categoriesBindingSource.Filter = "VehicleType = '" + truckTypeComboBox.SelectedValue.ToString().Trim() + "'";
                    MainNavAddnew.Enabled = true;
                    truckTypeIdTextBox.Text = truckTypeComboBox.SelectedValue.ToString();
                    
                }
                else
                {
                    categoriesBindingSource.Filter = "";
                    MainNavAddnew.Enabled = false;
                }

                stock();
                optAll.Checked = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Stosa"); }

        }

        private void btnNewTruck_Click(object sender, EventArgs e)
        {
             frmVehicleModels frvm = new frmVehicleModels(this);
            // frvm.frm = this;
             Program.mainFrm.OpenFrm(frvm);

        }

        public void updateTruckTypeCboBox()
        {
           
            strSQL = "Select vehicleType, vDescription From vehicle_List";
            objUtility.AddComboValues(truckTypeComboBox, strSQL);
       

            truckTypeComboBox.DisplayMember = "vehicleType";
            truckTypeComboBox.ValueMember = "vehicleType";


            setAdapterConnectionString(); 
            this.belayAbSSDataSetItemsCategories.Items.Clear();
            this.belayAbSSDataSetItemsCategories.Categories.Clear();
            this.itemsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Items);
            this.categoriesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Categories);
        }

        private void getAllInstock()
        {
            for (int i = 0; i < dv.Rows.Count; i++)
            {
                 //  getInstock(i);
               
            }
        }


        private void getInstock(int Rx)
        {
            try
            {

                 objData.GetInstock(dv, Rx, "GetNetItemsInStock", clsVariables.sStore);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void categoriesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            stock();
        }

       private void stock()
        {
            dv = itemsDataGridView;
         //   getAllInstock();
        }

        private void ItemDetail_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            frmItemsList f = new frmItemsList();
            Program.mainFrm.OpenOverFrm(f);
        }

        private void itemsDataGridView_Leave(object sender, EventArgs e)
        {
            dv.CommitEdit(DataGridViewDataErrorContexts.LeaveControl);
        }

        private void lnkShowAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmItemsList f = new frmItemsList();
            Program.mainFrm.OpenOverFrm(f);
        }

        private void filterCategories(string serviceType)
        {
            try
            {
               
                string filter1 = "", filter2 = "", filterv = "";
                if (truckTypeComboBox.SelectedValue != null && truckTypeComboBox.SelectedValue.ToString() != "" && truckTypeComboBox.Text.Trim() != "All")
                    filter1 = " VehicleType = '" + truckTypeComboBox.SelectedValue.ToString().Trim() + "'";

                if (serviceType != "A")
                    filter2 = " ServiceType ='" + serviceType + "'";
                else
                    filter2 = "";

                if (filter1 == "" && filter2 == "") filterv = "";
                else if (filter1 != "" && filter2 != "") filterv = filter2 + " and " + filter1;
                else if (filter1 == "") filterv = filter2;
                else filterv = filter1;
        
                categoriesBindingSource.Filter = filterv;

                srvTypeTag = serviceType;
            }
            catch (Exception ex)
            {
              
            }
        }
        private void optParts_CheckedChanged(object sender, EventArgs e)
        {
            filterCategories(optParts.Tag.ToString());
        }

        private void optVehicles_CheckedChanged(object sender, EventArgs e)
        {
            filterCategories(optVehicles.Tag.ToString());

        }

       

        private void optMaintenance_CheckedChanged(object sender, EventArgs e)
        {
            filterCategories(optMaintenance.Tag.ToString());
        }

        private void optOthers_CheckedChanged(object sender, EventArgs e)
        {
            filterCategories(optOthers.Tag.ToString());
        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            filterCategories(optAll.Tag.ToString());
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditCategories_Click(object sender, EventArgs e)
        {
           // Boolean Val = itemsDataGridView.Columns["Category"].Visible;


            if (btnEditCategories.Text == "Edit Categories")
            {
                itemsDataGridView.Columns["Category"].Visible = true;
                btnEditCategories.Text = "Hide Categories";
            }
            else
            {
                itemsDataGridView.Columns["Category"].Visible = false;
                btnEditCategories.Text = "Edit Categories";
            }
        }

        private void btnPrintAllItems_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_ItemList ";//where CategoryId = '" +
            // txtCategoryId.Text + "'";

            frmv.SetReport(new rptItemList(), strSQL, "rpt_ItemList");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void btnPrintCurrentVModel_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_ItemList where [Vehicle Type] = '" +
               truckTypeComboBox.SelectedValue.ToString()  + "'";

            frmv.SetReport(new rptItemList(), strSQL, "rpt_ItemList");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void itemsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void imgItem_DoubleClick(object sender, EventArgs e)
        {
            DisplayImage();
        }

        private void lnkEditItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            itemsDataGridView_DoubleClick (sender, new EventArgs());
        }

       

       
       
       

      
       

    }
}