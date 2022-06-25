using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
   
    public partial class frmGoodReceivedNoteHome : Form
    {
        public string vType = "Import";

        public frmGoodReceivedNoteHome()
        {
            InitializeComponent();
        }

        private void itemsReceivedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsReceivedBindingSource.EndEdit();
            this.itemsReceivedTableAdapter.Update(this.belayAbReceived.ItemsReceived);

        }

        private void frmGoodReceivedNoteHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbReceived.ItemsReceived' table. You can move, or remove it, as needed.
            this.itemsReceivedTableAdapter.Connection = clsData.connBel;
            //this.itemsReceivedTableAdapter.FillByStore(this.belayAbReceived.ItemsReceived, clsVariables.sStore);
            if (this.vType =="All")
                this.itemsReceivedTableAdapter.FillByStore(this.belayAbReceived.ItemsReceived, clsVariables.sStore);
            else
                this.itemsReceivedTableAdapter.FillByStoreVoucher(this.belayAbReceived.ItemsReceived, clsVariables.sStore, this.vType);


            
        }

        private void itemsReceivedDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string iFltr = itemsReceivedDataGridView.Rows[itemsReceivedDataGridView.CurrentCell.RowIndex].Cells["ReceivedNumber"].Value.ToString().Trim();
            frmGoodReceivedNote fgr = new frmGoodReceivedNote(iFltr);
            Program.mainFrm.OpenFrm(fgr);
        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNote fgr = new frmGoodReceivedNote();
            Program.mainFrm.OpenFrm(fgr);
            fgr.vType = this.vType;
            fgr.bindingNavigatorAddNewItem_Click(null, null);
            
            ////fgr.cboVouchureType.Text = this.vType;
            ////fgr.cboVouchureType.Enabled = false;
        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            //this.itemsReceivedTableAdapter.FillByStore(this.belayAbReceived.ItemsReceived, clsVariables.sStore);
            this.itemsReceivedTableAdapter.FillByStoreVoucher(this.belayAbReceived.ItemsReceived, clsVariables.sStore, this.vType);


        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            clsData.Instance.filterData(itemsReceivedBindingSource, "ReceivedNumber", txtFind.Text);
        }

    }
}
