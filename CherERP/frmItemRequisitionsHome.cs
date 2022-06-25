using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmItemRequisitionsHome : Form
    {

        public string requsitionType = "ST";
        clsData objData = new clsData();
        public bool workingLocal = true;
        public int displayFor = 0;


        public frmItemRequisitionsHome()
        {
            InitializeComponent();
        }

        private void itemRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemRequisitionBindingSource.EndEdit();
            this.itemRequisitionTableAdapter.Update(this.belayAbItemRequistions.ItemRequisition);

        }

        public void fillNonIssuedLocalRequisitions()
        {
            
            workingLocal = true;
            ReqTypeComboBox.Visible = false;

            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);

            this.itemRequisitionTableAdapter.FillByNonIssuedLocalRequitions(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);

            this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);

        }
        private void frmRequisitionsHome_Load(object sender, EventArgs e)
        {
            setAdapterConnectionString();

            // TODO: This line of code loads data into the 'belayAbItemRequistions.DepartmentLst' table. You can move, or remove it, as needed.
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
            this.departmentLstTableAdapter.Fill(this.belayAbItemRequistions.DepartmentLst);

        }


        private void itemRequisitionDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string curStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["StoreID"].Value.ToString();
            if (curStore != clsVariables.sStore)
            {
                MessageBox.Show("Can't Open Record, Maintained in a different branch", "Wrong Branch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clsData.trNo = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["RequisitionNumber"].Value.ToString();
            frmItemRequisitions fReq = new frmItemRequisitions("");
            Program.mainFrm.OpenOverFrm(fReq);
            fReq.groupBox1.Left = fReq.lstRequsitions.Left;
        }

        private void setAdapterConnectionString()
        {

            departmentLstTableAdapter.Connection = clsData.connBel;
            itemRequisitionDetailsTableAdapter.Connection = clsData.connBel;
            itemRequisitionTableAdapter.Connection = clsData.connBel;
            partNumDescriptionTableAdapter.Connection = clsData.connBel;
         
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            clsData.Instance.filterData(itemRequisitionBindingSource, "RequisitionNumber", txtFind.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmItemRequisitions f = new frmItemRequisitions();
            Program.mainFrm.OpenOverFrm(f);
            f.tooStrDetailAddnew_Click(null, null);
            if (requsitionType == "TR") f.requisitionTypeComboBox.Text = "TR";
        }

        private void toolStripRefresh_Click(object sender, EventArgs e)
        {
            //frmRequisitionsHome_Load(null, null);
            if (!workingLocal)
                ReqTypeComboBox_SelectedIndexChanged(null, null);
            else
                FillLocalRequistions(displayFor);

        }

        private void frmRequisitionsHome_Resize(object sender, EventArgs e)
        {
            itemRequisitionDataGridView.Height = this.Height - itemRequisitionBindingNavigator.Height - 50;
        }

        private void ReqTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

             FillTransferRequisions();          
             
        }

       public void FillLocalRequistions(int forWhat)
        {   // forWhat -> 0=Approval  1=ToIssue
            workingLocal = true;

            ReqTypeComboBox.Visible = false;

            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);

            //if (ReqTypeComboBox.SelectedItem.ToString() == "All")
            //    this.itemRequisitionTableAdapter.FillByStore(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);
            //else
           
            this.itemRequisitionTableAdapter.FillByStoreReqType(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore, "ST");

            //if (clsVariables.userRole.ToUpper() == "ADMIN" || clsVariables.userRole.ToUpper() == "APPROVER")
            //    if (forWhat == 0) //Approval
            //        itemRequisitionBindingSource.Filter = "Status Not in ('Approved', 'Closed') or Status is null";
            //    else if (forWhat == 1) //Approval
            //        itemRequisitionBindingSource.Filter = "Status  in ('Approved', 'New') or Status is null";

            this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);
     
        }

        public void FillTransferRequisions()
        {

            //if (ReqTypeComboBox.SelectedItem.ToString() == "All")
            //    this.itemRequisitionTableAdapter.FillByStore(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);
            //else
            //    this.itemRequisitionTableAdapter.FillByStoreReqType(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore, ReqTypeComboBox.SelectedItem.ToString());

            // TODO: This line of code loads data into the 'belayAbItemRequistions.DepartmentLst' table. You can move, or remove it, as needed.
           //   this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
            //  this.departmentLstTableAdapter.Fill(this.belayAbItemRequistions.DepartmentLst);


          //  this.belayAbItemRequistions.Clear();

           
            switch (ReqTypeComboBox.Text.Trim())
            {
                case "ST_R":
                    this.itemRequisitionTableAdapter.FillByStoreReqType(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore, "ST");
                    break;
                case "TR_R_Rec":
                    this.itemRequisitionTableAdapter.FillByTrReqReceived(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);
                    if (this.belayAbItemRequistions.ItemRequisition.Rows.Count > 0) btnSendItems.Visible = true;
            //        btnReceiveItems.Visible = false
                    break;

                case "TR_R_Sent":
                    this.itemRequisitionTableAdapter.FillByTrReqSent(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);
                    btnSendItems.Visible = false;
              //      btnReceiveItems.
                    break;
                case "All":
                    this.itemRequisitionTableAdapter.FillByStoreReqType(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore,"TR");
                    btnSendItems.Visible = false;
                    break;
                default:
                    //           this.itemRequisitionTableAdapter.FillByTransferRequestStore(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore);
                    this.itemRequisitionTableAdapter.FillByStoreReqType(this.belayAbItemRequistions.ItemRequisition, clsVariables.sStore, "ST");
                    btnSendItems.Visible = false;
                    break;

            }

            if (clsVariables.userRole.ToUpper() == "ADMIN" || clsVariables.userRole.ToUpper() == "APPROVER")
                itemRequisitionBindingSource.Filter = "Status Not in ('Approved', 'Closed') or Status is null";
            
            // The details should will be filled whenever. 

            this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (itemRequisitionDataGridView.Rows.Count < 0) return;
            string refNo = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["RequisitionNumber"].Value.ToString();
            string strFromStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["FromStore"].Value.ToString();
            string strToStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["StoreID"].Value.ToString();

            frmTransfer ftr = new frmTransfer();
            Program.mainFrm.OpenFrm(ftr);
            ftr.MainNavAddnew_Click(null, null);

             ftr.fromStoreComboBox.SelectedValue = strFromStore;
             ftr.toStoreComboBox.SelectedValue = strToStore;
             ftr.storeAction = "Send";
             ftr.btnSendItems.Visible = true;

            //   ftr.referenceNumberComboBox.SelectedValue = refNo;





        }


        private void itemRequisitionDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

      
        private void btnReceiveItems_Click(object sender, EventArgs e)
        {
            try
            {

                string iFltr = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["RequisitionNumber"].Value.ToString();
                string strSQL; //= "Select  ReferenceNumber  From  StoreTransfer Where ReferenceNumber = '" + iFltr + "'";

                strSQL= "Select StoreTransferNo  From StoreTransfer Where ReferenceNumber = '" + iFltr + "'";


                clsData.trNo = objData.getFieldValue(strSQL);

                if (clsData.trNo == "")
                {
                    MessageBox.Show("Item(s) Not Yet Ready. Try later.", "Try Later", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                frmTransfer ftran = new frmTransfer();

                Program.mainFrm.OpenFrm(ftran);
                 ftran.storeAction = "Receive";
                ftran.btnReceive.Visible = true;
            }
            catch (Exception ex) { }         
        }

        private void itemRequisitionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (workingLocal) return;

                string SrcStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["FromStore"].Value.ToString();
                if (SrcStore == clsVariables.sStore)
                {
                    btnSendItems.Visible = true;
                    btnReceiveItems.Visible = false;
                }
                else
                {
                    btnSendItems.Visible = false;
                    btnReceiveItems.Visible = true;
                }

            }
            catch (Exception ex) { }
        }

        private void btnIssueLocal_Click(object sender, EventArgs e)
        {
            if (itemRequisitionDataGridView.Rows.Count < 0) return;
            string refNo = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["RequisitionNumber"].Value.ToString();
      //      string strFromStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["FromStore"].Value.ToString();
            string strToStore = itemRequisitionDataGridView.Rows[itemRequisitionDataGridView.CurrentCell.RowIndex].Cells["StoreID"].Value.ToString();

            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            fis.MainNavAddnew_Click(null, null);
            fis.StartNewIsssue();
            fis.referenceNumberComboBox.Text = refNo;
        }
    }
}
