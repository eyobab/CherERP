using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class FrmItemTypes : Form
    {
        public FrmItemTypes()
        {
            InitializeComponent();
        }

        private void itemTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            SaveItemTypes();
        }

        private void SaveItemTypes()
        {
            this.Validate();
            this.itemTypesBindingSource.EndEdit();
            this.itemTypesTableAdapter.Update(this.belayAbSSDataSetItemsCategories.ItemTypes);
        }

        private void FrmItemTypes_Load(object sender, EventArgs e)
        {
            this.itemTypesTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.ItemTypes' table. You can move, or remove it, as needed.
            this.itemTypesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.ItemTypes);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    itemTypesBindingSource.RemoveCurrent();
                    SaveItemTypes();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
