using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmVMaintainanceType : Form
    {
        public frmVMaintainanceType()
        {
            InitializeComponent();
        }

        private void m_MaintenanceTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveMaintenanceTypes();
        }

        private void saveMaintenanceTypes()
        {
            this.Validate();
            this.m_MaintenanceTypeBindingSource.EndEdit();
            this.m_MaintenanceTypeTableAdapter.Update(this.belayAbVMaintain.m_MaintenanceType);

        }

        private void frmVMaintainanceType_Load(object sender, EventArgs e)
        {
            this.m_MaintenanceTypeTableAdapter.Connection = clsData.connBel;

            // TODO: This line of code loads data into the 'belayAbVMaintain.m_MaintenanceType' table. You can move, or remove it, as needed.
            this.m_MaintenanceTypeTableAdapter.Fill(this.belayAbVMaintain.m_MaintenanceType);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_MaintenanceTypeBindingSource.RemoveCurrent();
                    saveMaintenanceTypes();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       
    }
}
