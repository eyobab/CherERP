using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmCategories : Form
    {
        clsUtility objUtility = new clsUtility();

        public frmCategories()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveCategories();

        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
          


            string strSQL;
            strSQL = "Select CategoryId, CategoryName From Categories Order by CategoryName";
            objUtility.fillComboValues(parentCategoryIdComboBox, strSQL);
            parentCategoryIdComboBox.DisplayMember = "CategoryName";
            parentCategoryIdComboBox.ValueMember = "CategoryId";

            
            setAdapterConnectionString();
            
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Categories);
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.Items);



        }

        private void saveCategories()
        {
            try
            {
                this.Validate();
                this.categoriesBindingSource.EndEdit();
                this.categoriesTableAdapter.Update(this.belayAbSSDataSetItemsCategories.Categories);
                //btnDelete.Text = "Delete";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void setAdapterConnectionString()
         {
            categoriesTableAdapter.Connection = clsData.connBel;
            itemsTableAdapter.Connection = clsData.connBel;
        
          }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    categoriesBindingSource.RemoveCurrent();
                    saveCategories();
                    

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmCategories_SizeChanged(object sender, EventArgs e)
        {
            tabControl1.Top = parentCategoryIdComboBox.Top + parentCategoryIdComboBox.Height +5 ;
            tabControl1.Left = 0;
            tabControl1.Width = this.Width;
            tabControl1.Height = this.Height - tabControl1.Top;
        }

    }
}
