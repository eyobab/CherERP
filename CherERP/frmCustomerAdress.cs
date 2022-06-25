using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmCustomerAdress : Form
    {
        int fltr;

        public frmCustomerAdress()
        {
            InitializeComponent();
        }

        public frmCustomerAdress(int ftr)
        {
            InitializeComponent();
            if (fltr >=0) fltr = ftr;

        }
        private void customerAddressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerAddressBindingSource.EndEdit();
            this.customerAddressTableAdapter.Update(this.belayAbVMaintain.CustomerAddress);

        }

        private void frmCustomerAdress_Load(object sender, EventArgs e)
        {
            this.customerAddressTableAdapter.Connection = clsData.connBel;

            if (fltr >=0)
                this.customerAddressTableAdapter.FillByCusId(this.belayAbVMaintain.CustomerAddress, fltr);
            // TODO: This line of code loads data into the 'belayAbVMaintain.CustomerAddress' table. You can move, or remove it, as needed.
            else
                this.customerAddressTableAdapter.Fill(this.belayAbVMaintain.CustomerAddress);

        }

           private void customerAddressDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            customerAddressDataGridView.Rows[e.RowIndex].Cells["CustomerID"].Value = fltr;
        }

       
    }
}
