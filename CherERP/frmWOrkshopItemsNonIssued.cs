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
    public partial class frmWOrkshopItemsNonIssued : Form
    {
        public frmWOrkshopItemsNonIssued()
        {
            InitializeComponent();
        }

        private void frmWOrkshopItemsNonIssued_Load(object sender, EventArgs e)
        {
            this.rpt_WorkOrderItems_Non_IssuedTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.rpt_WorkOrderItems_Non_Issued' table. You can move, or remove it, as needed.
            this.rpt_WorkOrderItems_Non_IssuedTableAdapter.FillByStore(this.belayAbSSDataSetItemsCategories.rpt_WorkOrderItems_Non_Issued, clsVariables.sStore);

        }

        private void rpt_WorkOrderItems_Non_IssuedDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (clsVariables.sEmployeeDepartment.ToUpper().Trim() == "STORE") return;

            Program.showWorkOrder(grdNonIssuedWOItemsList.Rows[grdNonIssuedWOItemsList.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);

        }
    }
}
