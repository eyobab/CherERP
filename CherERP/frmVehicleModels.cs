using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmVehicleModels : Form
    {
        frmItemCategory fItmCat =null ;
        clsUtility objUtility = new clsUtility();

        public frmVehicleModels()
        {
            InitializeComponent();
        }

        public frmVehicleModels( frmItemCategory frm)
        {
            InitializeComponent();
            fItmCat = frm;
        }
    
        private void frmVehicleModels_Load(object sender, EventArgs e)
        {
            m_VehicleSizesTableAdapter.Connection = clsData.connBel;
            m_VehicleTypeTableAdapter.Connection = clsData.connBel;
  
        
             this.m_VehicleTypeTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.m_VehicleType);
             this.m_VehicleSizesTableAdapter.Fill(this.stosaFlatRates.m_VehicleSizes);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveVehicleTypes();

        }

        private void frmVehicleModels_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fItmCat != null) fItmCat.updateTruckTypeCboBox();
        }

        private void m_VehicleTypeDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (Confirm())
            {
                m_VehicleTypeBindingSource1.RemoveCurrent();
                SaveVehicleTypes();
            }
        }

       
        


        private bool Confirm()
        {

            if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void bindingNavigatorDeleteItem2_Click(object sender, EventArgs e)
        {
            if (Confirm())
            {
                //categoriesBindingSource.RemoveCurrent();
                //SaveCats();
            }
        }

        private void bNavSaveCats_Click(object sender, EventArgs e)
        {
           
        }

     


        private void SaveVehicleTypes()
        {
            this.Validate();
            this.m_VehicleTypeBindingSource1.EndEdit();
            this.m_VehicleTypeTableAdapter.Update(this.belayAbSSDataSetItemsCategories.m_VehicleType);
      //      bNavCatAddNew.Enabled = true;

        }


      

        private void SaveAll()
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bNavVTypeAddnew.Enabled = false;
 //           bNavCatAddNew.Enabled = false;
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
     //       bNavCatAddNew.Enabled  = false;
        }

        private void frmVehicleModels_Activated(object sender, EventArgs e)
        {

        }

        private void categoriesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void categoriesDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void categoriesDataGridView_DoubleClick(object sender, EventArgs e)
        {
 try
            {
 //              
 //                string cat = categoriesDataGridView.Rows[categoriesDataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
   //              clsCommon.fItm.fillData();
 //                clsCommon.fItm.categoryIdComboBox.SelectedValue = cat;
               // clsCommon.fItm.Activate();
 //                clsCommon.fItm.Show();
            }

            catch (Exception ex) {
                
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }
    
    }} 