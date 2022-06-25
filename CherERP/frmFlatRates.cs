using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmFlatRates : Form
    {
        clsData objData = new clsData();

        public frmFlatRates()
        {
            InitializeComponent();
        }

        private void m_FlatRateTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
         SaveData();

        }

        private void frmFlatRates_Load(object sender, EventArgs e)
        {
           

            setAdapterConnectionString();

            this.m_FlatRateValuesTableAdapter.Fill(this.stosaFlatRates.m_FlatRateValues);
            this.m_VehicleSizesTableAdapter.Fill(this.stosaFlatRates.m_VehicleSizes);
            this.m_FlatRateSubCategoriesTableAdapter.Fill(this.stosaFlatRates.m_FlatRateSubCategories);
            this.m_FlatRateCategoriesTableAdapter.Fill(this.stosaFlatRates.m_FlatRateCategories);
            this.m_FlatRateTypesTableAdapter.Fill(this.stosaFlatRates.m_FlatRateTypes);

            txtHourlyLaborRate.Text = clsVariables.mLaborRate.ToString();

        }
 

     private void setAdapterConnectionString()
        {

            this.tableAdapterManager.Connection = clsData.connBel;
              this.m_FlatRateValuesTableAdapter.Connection = clsData.connBel;
              this.m_FlatRateSubCategoriesTableAdapter.Connection = clsData.connBel;
              this.m_FlatRateCategoriesTableAdapter.Connection = clsData.connBel;
              this.m_FlatRateTypesTableAdapter.Connection = clsData.connBel;
              this.m_VehicleSizesTableAdapter.Connection = clsData.connBel;
       

        }

     private void frmFlatRates_Resize(object sender, EventArgs e)
     {
           // if (this.Height < 80 && this.Width < 100) return;
         int ht = this.Height - m_FlatRateTypesDataGridView.Height - 2 * m_FlatRateTypesBindingNavigator.Height - 2* m_FlatRatesSubCatsbindingNavigator.Height;
         m_FlatRateSubCategoriesDataGridView.Height = ht -  m_FlatRatesSubCatsbindingNavigator.Height; 
        
     }


     private DialogResult DeleteConfirm(int pos)
     {
         DialogResult ret = DialogResult.No; ;
         if (pos >= 0)
               ret = MessageBox.Show("Are you sure to delete the record?", "Confirm Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         
         
         return ret;
         
     }

     private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
     {
         if (DeleteConfirm(m_FlatRateTypesBindingSource.Position) == DialogResult.Yes)
         {

             this.m_FlatRateTypesBindingSource.RemoveCurrent();
             SaveData();
         }
     }
     

     private void SaveData()
     {
            this.Validate();
            this.m_FlatRateTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stosaFlatRates);
         
       
     }

     private void toolStripButton2_Click(object sender, EventArgs e)
     {
         if (DeleteConfirm(m_FlatRateCategoriesBindingSource.Position) == DialogResult.Yes)
         {

             this.m_FlatRateCategoriesBindingSource.RemoveCurrent();
             SaveData();
         }
     }

     private void toolStripButton16_Click(object sender, EventArgs e)
     {
         if (DeleteConfirm(m_FlatRateSubCategoriesBindingSource.Position) == DialogResult.Yes)
         {

             this.m_FlatRateSubCategoriesBindingSource.RemoveCurrent();
             SaveData();
         }
     }

     private void toolStripButton9_Click(object sender, EventArgs e)
     {
         if (DeleteConfirm(m_FlatRateValuesBindingSource.Position) == DialogResult.Yes)
         {

             this.m_FlatRateValuesBindingSource.RemoveCurrent();
             SaveData();
         }
     }

     private void tabPage2_Click(object sender, EventArgs e)
     {

     }

     private void btnLaborRateUpdate_Click(object sender, EventArgs e)
     {
        
             String strWhere = "VKey='LaborRate'";
             //     if (!objData.exists("Select * from m_Consumables Where mNumber ='" + WoN + "'" + " And PartNumber ='OH001'")) 
             //objData.deleteRecord("m_KeyValuePairs", strWhere);

             try
             {

                 if (!objData.exists("Select * from m_KeyValuePairs Where " + strWhere)) // mNumber ='" + WoN + "'" + " And PartNumber ='OH001'"))
                     objData.addNewRecord("m_KeyValuePairs", "VKey,  Value", "'LaborRate', '" + txtHourlyLaborRate.Text.Trim() + "'", true);
                 else
                     objData.updateRecord("m_KeyValuePairs", "VKey, Value", " 'LaborRate', '" + txtHourlyLaborRate.Text.Trim() + "'", strWhere, true);

                 clsVariables.mLaborRate = Decimal.Parse(txtHourlyLaborRate.Text.Trim());

                 lblRateSaved.Text = "Ok";
             }
             catch (Exception ex) { }
         
      
     }

     private void txtHourlyLaborRate_TextChanged(object sender, EventArgs e)
     {
         lblRateSaved.Text = "";
     }

        private void m_FlatRateValuesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ingnore
        }
    }
}
