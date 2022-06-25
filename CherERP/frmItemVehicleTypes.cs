using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmItemVehicleTypes : Form
    {
        public frmItemVehicleTypes()
        {
            InitializeComponent();
        }

        private void m_VehicleTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveVehicleTypes();

        }

        private void SaveVehicleTypes()
        {
            this.Validate();
            this.m_VehicleTypeBindingSource.EndEdit();
            this.m_VehicleTypeTableAdapter.Update(this.belayAbSSDataSetItemsCategories.m_VehicleType);
        }

        private void frmItemVehicleTypes_Load(object sender, EventArgs e)
        {
            
             this.m_VehicleTypeTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.m_VehicleType' table. You can move, or remove it, as needed.
            this.m_VehicleTypeTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.m_VehicleType);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_VehicleTypeBindingSource.RemoveCurrent();
                    SaveVehicleTypes();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       
        }
    }
