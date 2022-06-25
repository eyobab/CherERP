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
    public partial class frmPurchaseRqHome : Form
    {
        public frmPurchaseRqHome()
        {
            InitializeComponent();
        }

        private void purchaseRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseRequisitionBindingSource.EndEdit();
            this.purchaseRequisitionTableAdapter.Update(this.belayAbSSDataSet.PurchaseRequisition);

        }

        private void frmPurchaseRqHome_Load(object sender, EventArgs e)
        {

            this.purchaseRequisitionTableAdapter.Connection = clsData.connBel;

            // TODO: This line of code loads data into the 'belayAbSSDataSet.PurchaseRequisition' table. You can move, or remove it, as needed.
            this.purchaseRequisitionTableAdapter.FillByStore(this.belayAbSSDataSet.PurchaseRequisition, clsVariables.sStore);

        }

        private void purchaseRequisitionDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string iFltr = purchaseRequisitionDataGridView.Rows[purchaseRequisitionDataGridView.CurrentCell.RowIndex].Cells["PurchaseReqNo"].Value.ToString().Trim();
            frmPurchaseRq fgr = new frmPurchaseRq(iFltr);
            Program.mainFrm.OpenFrm(fgr);

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

            //clsData.Instance.filterData(itemsIssuedBindingSource, "IssueNo", txtFind.Text);
            try
            {
                if (txtFind.Text != "")
                    purchaseRequisitionBindingSource.Filter = "PerchaseReqNo Like '%" + txtFind.Text + "%' Or Refrerence Like '%" + txtFind.Text + "%'";
                else
                    purchaseRequisitionBindingSource.Filter = "";

                txtFind.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
           // clsData.Instance.filterData(purchaseRequisitionBindingSource, "PerchaseReqNo", txtFind.Text);
        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {
            frmPurchaseRq fpr = new frmPurchaseRq();
            Program.mainFrm.OpenFrm(fpr);

            fpr.bindingNavigatorAddNewItem1_Click(null, null);

            

        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            this.purchaseRequisitionTableAdapter.FillByStore(this.belayAbSSDataSet.PurchaseRequisition, clsVariables.sStore);
        }

        public void FillPerchaseRequisitionData()
        {   // appState -> 0=Approved  1=All


            if (clsVariables.sEmployeeDepartment.ToUpper() == "ADMIN" || clsVariables.userRole.ToUpper() == "APPROVER")
                purchaseRequisitionBindingSource.Filter = "Status Not in ('Approved', 'Closed') or Status is null"; //, 'Issued') or State is null";
            else
                purchaseRequisitionBindingSource.Filter = "Status in ('New','Approved')";
            //this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);

        }
    }
}
