using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmItemEdit : Form
    {
        public string pNum;
        clsSecurity objSecurity = new clsSecurity();
        clsUtility objUtility = new clsUtility();
        clsImage objImage = new clsImage();
        clsData objData = clsData.Instance;

        string imagePath = Application.StartupPath + "\\ItemImage.jpg";
        string noPhotoPath = Application.StartupPath + "\\NoPhoto.jpg";

        
        public frmItemEdit()
        {
            InitializeComponent();
        }

        private void itemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsBindingSource.EndEdit();
            this.itemsTableAdapter.Update(this.belayAbSSDataSetItemsCategories.Items);
            
        }

        private void frmItemEdit_Load(object sender, EventArgs e)
        {
             setAdapterConnectionString();

            //string strSQL = "Select [ItemPuchaseTypeID], [ItemPurchaseTypeDescription] from [ItemPurchaseTypes] ";
            //objUtility.fillComboValues(itemPurchaseTypeComboBox, strSQL);

            //itemPurchaseTypeComboBox.DisplayMember ="ItemPurchaseTypeDescription";
            //itemPurchaseTypeComboBox.ValueMember = "ItemPuchaseTypeID";

            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemPurchaseTypes' table. You can move, or remove it, as needed.
            this.itemPurchaseTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemPurchaseTypes);


            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.MeasurmentTypes' table. You can move, or remove it, as needed.
            this.measurmentTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.MeasurmentTypes);

            this.categoryListTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.CategoryList);

            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.m_VehicleType' table. You can move, or remove it, as needed.
            this.m_VehicleTypeTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.m_VehicleType);

            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemTypes' table. You can move, or remove it, as needed.
            this.itemTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemTypes);

            this.itemsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Items);

            // The rest take to activated event



            partNumberTextBox.Focus();

         //   fillReceivedNos();


            //Trap Change event on each editing control
            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    foreach (Control ctl in c.Controls)
                    {
                        setControlChangeEventHandler(ctl);
                    }

                }

                else
                    setControlChangeEventHandler(c);

            }

            if (clsVariables.userRole.Contains("Store") || clsVariables.sEmployeeDepartment.Contains("Store"))
                lnkSetBeginning.Visible = true;
            else
                lnkSetBeginning.Visible = false;
        }


        public void setControlChangeEventHandler( Control c)
        {

            //Set the change tracker on the form

            if (c is CheckBox)
            {
                ((CheckBox)c).CheckedChanged += c_ControlChanged;
            }
            else if (c is ComboBox)
            {
                c.TextChanged += new EventHandler(c_ControlChanged);
                ((ComboBox)c).SelectedIndexChanged += new EventHandler(c_ControlChanged);
            }
            else if (c is TextBox)
            {
                c.TextChanged += new EventHandler(c_ControlChanged);
            }
            else if (c is PictureBox)
            {
                ((PictureBox)c).LoadCompleted += c_ControlChanged;
            }

      
        }


        private void setAdapterConnectionString()
        {
            m_VehicleTypeTableAdapter.Connection = clsData.connBel;
            itemsTableAdapter.Connection = clsData.connBel;
            locationViewTableAdapter.Connection = clsData.connBel;
            measurmentTypesTableAdapter.Connection = clsData.connBel;
            categoryListTableAdapter.Connection = clsData.connBel;
            itemTypesTableAdapter.Connection = clsData.connBel;
            itemPurchaseTypesTableAdapter.Connection = clsData.connBel;

        }
        

        private void itemsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
             saveItems();
          
            //  saveImage(); //Disabled due to the VPN

        }

        private void categoryIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFind.Text != "")
                    itemsBindingSource.Filter = "Description Like '%" + txtFind.Text + "%' Or PartNumber Like '%" + txtFind.Text + "%'  Or ItemID Like '%" + txtFind.Text + "%'";
                else
                    itemsBindingSource.Filter = "";

                txtFind.Focus();
            }
            catch (Exception ex) {

            }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    itemsBindingSource.RemoveCurrent();
                    saveItems();
                    itemsBindingNavigatorSaveItem.Enabled = true;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void saveItems()
        {
            try
            {
                this.itemsBindingSource.EndEdit();
                this.Validate();
                this.itemsTableAdapter.Update(this.belayAbSSDataSetItemsCategories.Items );
                btnDelete.Text = "Delete";
                bindingNavigatorAddNewItem.Enabled = true;
                itemsBindingNavigatorSaveItem.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDelete.Text = "Cancel";
                bindingNavigatorAddNewItem.Enabled = false;
                itemsBindingNavigatorSaveItem.Enabled = true;
            }
        }


        private void saveImage()
        {
            try
            {

                objImage.SavePhoto(this.belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "ItemID", itemIDTextBox.Text.Trim(), ref clsImage.newImagePath);

                objImage.DisplayPhoto(belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "ItemID",
                itemIDTextBox.Text.Trim(), picImage, clsImage.imagePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
             
             try
             {
              
               itemsBindingSource.AddNew();
               partNumberTextBox.Focus();
               btnDelete.Text = "Cancel";
               txtFind.Text = "";
               measurementIdComboBox.SelectedValue = 1;
               categoryIdComboBox.SelectedValue = "_TBA_";
               bindingNavigatorAddNewItem.Enabled = false;

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            
        }

           

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {

                if (cboReceivedNo.Text == "" || itemIDTextBox.Text == "" || txtQty.Text == "" )
                {
                    MessageBox.Show("Please Specify atleast Received Number and Quantity");
                    return;
                }
             
                if (txtUnitCost.Text == "") txtUnitCost.Text  = "0";

                string strSQL = " Insert Into ItemsReceivedDetails Values('" + cboReceivedNo.Text .Trim()+ "','" + itemIDTextBox.Text.Trim() + "'," +
                    txtQty.Text + "," + txtUnitCost.Text + ", '')";

                

                clsData.cmdShared.Connection = clsData.connBel;
                clsData.cmdShared.CommandText = strSQL;
                clsData.cmdShared.ExecuteNonQuery();
                lblDone.Text = "Done!";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearDone()
        {
         lblDone.Text = "";
        }
        private void cboReceivedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearDone();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            clearDone();
        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {
            clearDone();
        }

        private void mnuEditImage_Click(object sender, EventArgs e)
        {

            try
            {
                openDlg.FileName = "";

                openDlg.ShowDialog();

                if (openDlg.FileName != "")
                {
                    imagePath = openDlg.FileName;
                    picImage.Load(imagePath);

                    clsImage.newImagePath = imagePath;

                  

                }
                  

                
                }
         
            catch (Exception ex) { MessageBox.Show(ex.Message, "Image Saving Displaying"); }
        }

        private void frmItemEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblDone.Text = "";
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList();
            Program.mainFrm.OpenFrm(f);
        }

        private void btnBrowseItems_Click(object sender, EventArgs e)
        {
            //frmItemCategory f = new frmItemCategory();
            frmCategories f = new frmCategories();
            Program.mainFrm.OpenFrm(f);

        }

        private void btnSItemDetails_Click(object sender, EventArgs e)
        {
            FrmViewItemDetails_Tx f = new FrmViewItemDetails_Tx(itemIDTextBox.Text);
            f.showstoreAll = false;
            Program.mainFrm.OpenFrm(f);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            txtFind.Focus();
            txtFind.SelectAll();
        }

        private void frmItemEdit_Activated(object sender, EventArgs e)
        {
            try
            {
             //refresh the parts list      
                if (clsData.pNum != "")
                {
                    int ret = itemsBindingSource.Find("ItemID", clsData.pNum);
                    if (ret > -1) itemsBindingSource.Position = ret;
                    clsData.pNum = "";
                }

                //refresh main data of the form
                fillData();
                //refersh the GR numbers list
               // fillReceivedNos();

                if (txtInStock.Text == "" || txtInStock.Text == "0.00" || txtInStock.Text == "0")
                    show_Instock_and_Price();


            }
            catch (Exception exx) { }
        }

        public void fillData()
        {

            this.locationViewTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.LocationView);
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.CategoryList' table. You can move, or remove it, as needed.
            this.categoryListTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.CategoryList);
            // TODO: This line of code loads data into the 'belayAbSSDataSet.MeasurmentUnits' table. You can move, or remove it, as needed.
            this.measurmentTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.MeasurmentTypes);
        }

        private void btnEditCats_Click(object sender, EventArgs e)
        {
            frmCategories fm = new frmCategories();
            Program.mainFrm.OpenFrm(fm);
            clsCommon.fItm = this;
        }

       


        private void show_Instock_and_Price()
        {
            try
            {
                string pNum = itemIDTextBox.Text;
                string strSQL = "Select FirstQty from ItemCurrentBalance Where ItemID ='" + pNum + "' And BranchID ='" + 
                      clsVariables.sStore + "'";
                
          //       pNum = grdItemList.Rows[grdItemList.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString().Trim();

                decimal val = objData.getUnitPrice(pNum);

                txtUnitPrice.Text = string.Format("{0: #,##0.00}", val);
                txtInStock.Text = string.Format("{0: 0.00}", objData.ReturnInstock("GetNetItemsInStock_AfterDate", pNum, clsVariables.sStore));

                //txtYearBegining.Text = string.Format("{0: 0.00}", objData.ReturnInstock("GetNetItemsInStock_ByDate", pNum, clsVariables.sStore));

                txtYearBegining.Text = objData.getFieldAmt(strSQL).ToString();


                if (unitPriceTextBox.Text != "")
                    unitPriceTextBox.Text = string.Format("{0: #,##0.00}", decimal.Parse(unitPriceTextBox.Text));
            }
            catch (Exception ex) { }
        }
        private void mnuDeleteImage_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure to delete the Image permanently?? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               // clsImage.imagePath = noPhotoPath;
                picImage.Load(noPhotoPath);
                
            }
           
        }

        private void itemsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            //clsImage.imagePath = this.imagePath;

            objImage.DisplayPhoto(belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "ItemID",
                 itemIDTextBox.Text.Trim(), picImage, clsImage.imagePath);
        }

        private void cmdNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGoodReceivedNote fm = new frmGoodReceivedNote();
            Program.mainFrm.OpenFrm(fm);
            fm.callNew();
        }

        private void fillReceivedNos()
        {
            //string strSQLf = "Select Distinct ReceivedNumber from ItemsReceived";
            //objUtility.fillComboValues(cboReceivedNo, strSQLf);
            //cboReceivedNo.DisplayMember = "ReceivedNumber";
            
        }

        private void lnkSetPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (objSecurity.userHasSuperPermission() || clsVariables.sEmployeeDepartment.Contains("Store"))  // removed --  
                {
                    frmItem_Quantities fitq = new frmItem_Quantities();
                    Program.mainFrm.OpenFrm(fitq);

                    fitq.ItemIdTextBox.Text = this.itemIDTextBox.Text;
                    fitq.quantityTextBox.Text = this.txtYearBegining.Text;
                }

                else
                {
                    throw new Exception("You Can't do this with your current account!");

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        
           
        }

        private void lnkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nfrmCostPriceHistory fm = new nfrmCostPriceHistory();
            Program.mainFrm.OpenFrm(fm);
            fm.partNumberComboBox.SelectedValue = itemIDTextBox.Text;
        }

        private void btnEdiItemTypes_Click(object sender, EventArgs e)
        {
            FrmItemTypes f = new FrmItemTypes();
            Program.mainFrm.OpenFrm(f);
        }

        private void btnEditVehiceTypes_Click(object sender, EventArgs e)
        {
            frmItemVehicleTypes f = new frmItemVehicleTypes();
            Program.mainFrm.OpenFrm(f);
        }

        private void grdItemList_Click(object sender, EventArgs e)
        {
            //clsImage.imagePath = this.imagePath;

            //AND THIS IS DUE TO THE VPN SLOW CONNECION
            //objImage.DisplayPhoto(belayAbSSDataSetItemsCategories.Items, "Items", "Picture", "ItemID",
            //     itemIDTextBox.Text.Trim(), picImage, clsImage.imagePath);
            

            show_Instock_and_Price();

        }

        private void c_ControlChanged(object sender, EventArgs e)
        {
            itemsBindingNavigatorSaveItem.Enabled = true;
        }

       

        private void lnkItemBalances_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmItemCurrentBalance  fcb = new frmItemCurrentBalance();
            Program.mainFrm.OpenFrm(fcb);
            fcb.fillByItem(itemIDTextBox.Text.Trim());
          
        }

        private void grdItemList_SelectionChanged(object sender, EventArgs e)
        {
            grdItemList_Click(null, null);
        }

      
    }
}