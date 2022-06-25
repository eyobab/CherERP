using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmTransferHome : Form
    {
        public string storeAction = "Receive";

        public frmTransferHome()
        {
            InitializeComponent();
        }

        private void storeTransferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.storeTransferBindingSource.EndEdit();
            this.storeTransferTableAdapter.Update(this.belayAbReceived.StoreTransfer);

        }

        private void frmTransferHome_Load(object sender, EventArgs e)
        {
            this.storeTransferTableAdapter.Connection = clsData.connBel;
       
        }

        public void FillByStore(string StoreID)
        {
            this.storeTransferTableAdapter.FillByStore(this.belayAbReceived.StoreTransfer, StoreID);

        }

        public void FillbyReferenceStore(string refNo) {
           this.storeTransferTableAdapter.FillByRefernceStore(this.belayAbReceived.StoreTransfer, refNo, clsVariables.sStore);

        }

        public void FillByFromStore(string StoreID)
        {
            this.storeTransferTableAdapter.FillByFromStore(this.belayAbReceived.StoreTransfer, StoreID);

        }


        public void FillByToStore(string StoreID)
        {
           this.storeTransferTableAdapter.FillByToStore(this.belayAbReceived.StoreTransfer, StoreID);

        }


        private void storeTransferDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string iFltr = storeTransferDataGridView.Rows[storeTransferDataGridView.CurrentCell.RowIndex].Cells["StoreTransferNo"].Value.ToString().Trim();
            frmTransfer ftran = new frmTransfer(iFltr);
            Program.mainFrm.OpenFrm(ftran);
            ftran.storeAction = this.storeAction;
            ftran.btnReceive.Visible = Convert.ToBoolean(this.storeAction == "Receive");
            ftran.btnSendItems.Visible = Convert.ToBoolean(this.storeAction == "Send");


        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {
            frmTransfer ftran = new frmTransfer();
            Program.mainFrm.OpenFrm(ftran);
            ftran.MainNavAddnew_Click(null, null);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            clsData.Instance.filterData(storeTransferBindingSource, "StoreTransferNo", txtFind.Text);
 
        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            this.storeTransferTableAdapter.FillByStore(this.belayAbReceived.StoreTransfer, clsVariables.sStore);
        }

     
    }
}
