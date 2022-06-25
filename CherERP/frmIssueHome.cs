using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmIssueHome : Form
    {
        public string vType = "Import";

        clsUtility objUtility = new clsUtility();
        public frmIssueHome()
        {
            InitializeComponent();
        }

        private void itemsIssuedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsIssuedBindingSource.EndEdit();
            this.itemsIssuedTableAdapter.Update(this.belayAbSSDataSet.ItemsIssued);

        }

        

        private void frmIssueHome_Load(object sender, EventArgs e)
        {
            this.itemsIssuedTableAdapter.Connection = clsData.connBel;
            if (this.vType == "All")
                this.itemsIssuedTableAdapter.FillByStore(this.belayAbSSDataSet.ItemsIssued, clsVariables.sStore);
            else
                this.itemsIssuedTableAdapter.FillByStoreVoucher(this.belayAbSSDataSet.ItemsIssued, clsVariables.sStore, this.vType);

            string strSQL = "Select EmployeeID, EmployeeName From Employees Order by EmployeeName";

            //PreparedBy.DisplayMember = "EmployeeName";
            //PreparedBy.ValueMember = "EmployeeID";

          //  MessageBox.Show(this.belayAbSSDataSet.ItemsIssued.Rows.Count.ToString());

           objUtility.fillComboValues(PreparedBy, strSQL);
                       
        }

        public void FillIssueData()
        {   // appState -> 0=Approved  1=All


            if (clsVariables.sEmployeeDepartment.ToUpper() == "ADMIN" || clsVariables.userRole.ToUpper() == "APPROVER" || clsVariables.userRole.ToUpper() == "STORE HEAD")
                itemsIssuedBindingSource.Filter = "State Not in ('Closed') or State is null"; //, 'Issued') or State is null" State Not in ('Approved', 'Closed') or State is null;
            else
                itemsIssuedBindingSource.Filter = "State in ('New','Approved')";
            //this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);

        }


        private void itemsIssuedDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string iFltr = itemsIssuedDataGridView.Rows[itemsIssuedDataGridView.CurrentCell.RowIndex].Cells["IssueNo"].Value.ToString().Trim();
            frmIssue  fis = new frmIssue(iFltr);
            Program.mainFrm.OpenFrm(fis);
            
        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {
            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            //  fis.MainNavAddnew_Click(null, null);
            fis.vType = this.vType;
            fis.itemsIssuedBindingSource.AddNew();
            fis.StartNewIsssue();

        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            this.itemsIssuedTableAdapter.FillByStoreVoucher(this.belayAbSSDataSet.ItemsIssued, clsVariables.sStore, this.vType);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            //clsData.Instance.filterData(itemsIssuedBindingSource, "IssueNo", txtFind.Text);
            try
            {
                if (txtFind.Text != "")
                    itemsIssuedBindingSource.Filter = "IssueNo Like '%" + txtFind.Text + "%' Or ReferenceNumber Like '%" + txtFind.Text + "%'"; 
                else
                    itemsIssuedBindingSource.Filter = "";

                txtFind.Focus();
            }
            catch (Exception ex) { }

        }
    }
}
