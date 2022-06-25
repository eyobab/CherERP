using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmLaborTypes : Form
    {
        public frmLaborTypes()
        {
            InitializeComponent();
        }

        private void m_LaborCostTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_LaborCostTypeBindingSource.EndEdit();
            this.m_LaborCostTypeTableAdapter.Update(this.belayAbVMaintain.m_LaborCostType);

        }

        private void frmLaborTypes_Load(object sender, EventArgs e)
        {
            this.m_LaborCostTypeTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCostType' table. You can move, or remove it, as needed.
            this.m_LaborCostTypeTableAdapter.Fill(this.belayAbVMaintain.m_LaborCostType);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_LaborCostTypeBindingSource.RemoveCurrent();
                    m_LaborCostTypeBindingNavigatorSaveItem_Click(null, null);
                 }

            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message);
            }
        }
    }
}
