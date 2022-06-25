using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmMaintainanceS : Form
    {
        public frmMaintainanceS()
        {
            InitializeComponent();
        }

        private void s_MaintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.s_MaintenanceBindingSource.EndEdit();
            this.s_MaintenanceTableAdapter.Update(this.belayAbSSDataSetItemsCategories.s_Maintenance);

        }

        private void frmMaintainanceS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.s_Maintenance' table. You can move, or remove it, as needed.
            this.s_MaintenanceTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.s_Maintenance);

        }

        private void s_MaintenanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}