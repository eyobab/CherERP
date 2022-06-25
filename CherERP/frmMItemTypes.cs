using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmMItemTypes : Form
    {
        public frmMItemTypes()
        {
            InitializeComponent();
        }

        private void m_ItemTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_ItemTypesBindingSource.EndEdit();
            this.m_ItemTypesTableAdapter.Update(this.belayAbVMaintain.m_ItemTypes);

        }

        private void frmMItemTypes_Load(object sender, EventArgs e)
        {
            this.m_ItemTypesTableAdapter.Connection = clsData.connBel;

            // TODO: This line of code loads data into the 'belayAbVMaintain.m_ItemTypes' table. You can move, or remove it, as needed.
            this.m_ItemTypesTableAdapter.Fill(this.belayAbVMaintain.m_ItemTypes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_ItemTypesBindingSource.RemoveCurrent();

                    m_ItemTypesBindingNavigatorSaveItem_Click(null, null);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
