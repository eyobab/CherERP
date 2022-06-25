using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmCustomerTypes : Form
    {
        public frmCustomerTypes()
        {
            InitializeComponent();
        }

        private void customerTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveCusTypes();
        }

        private void frmCustomerTypes_Load(object sender, EventArgs e)
        {

            setAdapterConnectionString();

            this.customerTypesTableAdapter.Fill(this.belayAbVMaintain.CustomerTypes);
            this.customersTableAdapter.Fill(this.belayAbVMaintain.Customers);


        }


        private void setAdapterConnectionString()
        {

            customersTableAdapter.Connection = clsData.connBel;
            customerTypesTableAdapter.Connection = clsData.connBel;

        }

        private bool confirmDelete()
        {
            if (MessageBox.Show(" Are you sure to delete this record? ", "Confirm Delete",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return true;
            else
                return false;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (confirmDelete())
            {
                customerTypesBindingSource.RemoveCurrent();
                saveCusTypes();
            }

        }


        private void saveCusTypes()
        {
            this.Validate();
            this.customerTypesBindingSource.EndEdit();
            this.customerTypesTableAdapter.Update(this.belayAbVMaintain.CustomerTypes);

        }

        private void saveCustomers()
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.belayAbVMaintain.Customers);
        }

        private void bNavSaveCus_Click(object sender, EventArgs e)
        {

            saveCustomers();

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            if (confirmDelete())
            {
                customersBindingSource.RemoveCurrent();
                saveCustomers();
            }
        }

        private void frmCustomerTypes_Resize(object sender, EventArgs e)
        {
            customersDataGridView.Width = this.Width - customersDataGridView.Left;
        }


        private void frmCustomerTypes_Deactivate(object sender, EventArgs e)
        {
            if (Program.scFrm != null) Program.scFrm.refreshData();
        }


    }
}