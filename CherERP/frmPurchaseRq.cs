using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;

namespace Belayab
{
    public partial class frmPurchaseRq : Form
    {
        clsUtility objUtility = new clsUtility();
        clsData objData = new clsData();
        DataGridView dv;
        bool addingAll;


        string fltr = "";
        public frmPurchaseRq()
        {
            InitializeComponent();
        }

        public frmPurchaseRq(string strPRN)
        {
            fltr = strPRN;
            InitializeComponent();

        }

        private void purchaseRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.purchaseRequisitionDetailsBindingSource.EndEdit();
                this.purchaseRequisitionDetailsTableAdapter.Update(this.belayAbSSDataSet.PurchaseRequisitionDetails);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void frmPurchaseRq_Load(object sender, EventArgs e)
        {
            string strSQL = "Select StoreId, StoreName  from Stores";
            objUtility.fillComboValues(storeIDComboBox, strSQL);

            strSQL = "Select EmployeeId, EmployeeName From EmployeeList Order By EmployeeName";
            objUtility.fillComboValues(approvedByComboBox, strSQL);

            strSQL = "Select State From States Order By State";
            objUtility.fillComboValues(statusComboBox, strSQL);

            strSQL = "Select Distinct SupplierId, SupplierName From Suppliers Order By SupplierName";
            objUtility.fillComboValues(supplierComboBox, strSQL);




            //strSQL = "   Select RequisitionNumber from ItemRequisition Where RequisitionNumber not in (Select Reference from PurchaseRequisition) and StoreID = '" 
            //    + clsVariables.sStore + "' " + " Order by RequisitionNumber Desc";


    
            //objUtility.fillComboValues(refrerenceComboBox, strSQL);
            //refrerenceComboBox.DisplayMember = "RequisitionNumber";

                     setAdapterConnectionString();

            this.supplierListTableAdapter.Fill(this.belayAbSSDataSet.SupplierList);
            this.m_RequisitionNumbersTableAdapter.Fill(this.belayAbSSDataSet.m_RequisitionNumbers);
            this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);

            if (fltr != "")
                this.purchaseRequisitionTableAdapter.FillByPrNo(this.belayAbSSDataSet.PurchaseRequisition, fltr);
            else
                this.purchaseRequisitionTableAdapter.FillByStore(this.belayAbSSDataSet.PurchaseRequisition, clsVariables.sStore);
            this.purchaseRequisitionDetailsTableAdapter.Fill(this.belayAbSSDataSet.PurchaseRequisitionDetails);
           

            this.storeIDComboBox.Enabled = false;

           //Set the change tracker on the form

            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckedChanged += c_ControlChanged;
                }
                else if (c is ComboBox)
                {
                    c.TextChanged += new EventHandler(c_ControlChanged);
                }
                else if (c is TextBox)
                {
                    c.TextChanged += new EventHandler(c_ControlChanged);
                }
                else if (c is PictureBox)
                {
                    ((DataGridView)c).CellValueChanged += c_ControlChanged;
                }

            }
           
            FillRequsitionReferences();
            refrerenceComboBox_SelectedValueChanged(null, null);
            GetAllStock();

        }


        public void FillRequsitionReferences()
        {
            string strSQL;
            string refNo = refrerenceComboBox.Text;

            refrerenceComboBox.DataSource = null;

           // strSQL = "GetNonIssuedRequisitions @Store =N'" + clsVariables.sStore + "'";
           strSQL = "GetNonOrderedRequisitions @Store =N'" + clsVariables.sStore + "'";
            refrerenceComboBox.DisplayMember = "RequisitionNumber";
            //    referenceNumberComboBox.ValueMember = "RequisitionNumber";
            objUtility.fillComboValues(refrerenceComboBox, strSQL);

            
            if (refNo != "") refrerenceComboBox.Text = refNo;


        }
        private void setAdapterConnectionString()
        {

            partNumDescriptionTableAdapter.Connection = clsData.connBel;
            purchaseRequisitionDetailsTableAdapter.Connection = clsData.connBel;
            purchaseRequisitionTableAdapter.Connection = clsData.connBel;
            supplierListTableAdapter.Connection = clsData.connBel;
            m_RequisitionNumbersTableAdapter.Connection = clsData.connBel;
            employeesLstTableAdapter.Connection = clsData.connBel;

        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseRequisitionBindingSource.EndEdit();
            this.purchaseRequisitionTableAdapter.Update(this.belayAbSSDataSet.PurchaseRequisition);
            bindingNavigatorAddNewItem.Enabled = true;

            //log updators
            logUpdator();
            GetAllStock();

            saveToolStripButton.Enabled = true;
        }

        private void purchaseRequisitionDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        public void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {

            purchaseRequisitionBindingSource.AddNew();

            //if (MainNavDelete.Text == "Delete")
            //{
            //    MainNavDelete.Text = "Cancel";

            //}

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorAddNewItem1.Enabled = false;
          
            orderDateDateTimePicker.Value = DateTime.Now;
            storeIDComboBox.SelectedValue = clsVariables.sStore;

            if (clsVariables.sUserIsEmployee) requestedByComboBox.SelectedValue = clsVariables.sUserEmployeeId;

            this.storeIDComboBox.Enabled = false;

            if (bindingNavigatorDeleteItem1.Text == "Delete")
            {
                bindingNavigatorDeleteItem1.Text = "Cancel";
            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.purchaseRequisitionDetailsBindingSource.RemoveCurrent();
                    purchaseRequisitionBindingNavigatorSaveItem_Click(null, null);

                    if (bindingNavigatorDeleteItem.Text == "Cancel")
                    {
                        bindingNavigatorDeleteItem.Text = "Delete";
                    }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.purchaseRequisitionBindingSource.RemoveCurrent();
                    saveToolStripButton_Click(null, null);

                    if (bindingNavigatorDeleteItem1.Text == "Cancel")
                    {
                        bindingNavigatorDeleteItem1.Text = "Delete";
                    }


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void refrerenceComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string strSQL;

            string strSql = "Select Reference from ItemRequisition Where RequisitionNumber = '" + refrerenceComboBox.Text.Trim() + "'";
            WorkOrderNumberTextBox.Text = objData.getFieldValue(strSql);

            DataSet ds = new DataSet();
          

                    strSQL = "GetItemsInRequisition '" + refrerenceComboBox.Text.Trim() + "'";

                    objUtility.fillComboValues(ItemID, strSQL);
                    ItemID.DisplayMember = "Description";
                    ItemID.ValueMember = "ItemID";
                   

        }



        private void GetAllInStock()
        {
            for (int i = 0; i < dv.Rows.Count; i++)
                GetInstock(i);

        }

        private void GetInstock(int Rx)
        {
            try
            {
                objData.GetInstock(dv, Rx, "GetNetItemsInStock_AfterDate", clsVariables.sStore);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SetUnit(int Rx)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.Connection = clsData.connBel;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "GetUnit '" + dv.Rows[Rx].Cells["ItemID"].Value.ToString().Trim() + "'";

                dv.Rows[Rx].Cells["Units"].Value = comm.ExecuteScalar().ToString();
                comm.Dispose();
                comm = null;


            }
            catch (Exception ex) { }//MessageBox.Show( ex.Message); }
        }

        private void purchaseRequisitionDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dv = purchaseRequisitionDetailsDataGridView;
            if (dv.Columns[e.ColumnIndex].Name == "ItemID")
            {

                SetUnit(e.RowIndex);
                GetInstock(e.RowIndex);

                double reqAmt = objData.GetValueInOrder(dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(),
                    this.refrerenceComboBox.Text, "POR");

               // dv.Rows[e.RowIndex].Cells["RequestedQty"].Value = reqAmt;
                dv.Rows[e.RowIndex].Cells["Qty"].Value = reqAmt;

           

                //balance
                //dv.Rows[e.RowIndex].Cells["InStock"].Value = objData.ReturnInstock("GetNetItemsInStock_AfterDate", dv.Rows[e.RowIndex].Cells["ItemID"].Value.ToString(), clsVariables.sStore)
                //    - double.Parse(dv.Rows[e.RowIndex].Cells["Qty"].Value.ToString());


            }
        }

        private void itemBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCurrentBalance fcb = new frmItemCurrentBalance();
            Program.mainFrm.OpenFrm(fcb);
            fcb.fillByItem(purchaseRequisitionDetailsDataGridView.Rows[purchaseRequisitionDetailsDataGridView.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString());
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();
            string strSQL = "Select * from rpt_PurchaseRequisition Where PerchaseReqNo ='" +
                perchaseReqNoTextBox.Text.Trim() + "'";
            frmv.SetReport(new rptPurchaseRequisitionA5(), strSQL, "rpt_PurchaseRequisition");
            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void GetAllStock()
        {
            try
            {
                int k;


                for (k = 0; k < dv.Rows.Count; k++)
                {
                    SetUnit(k);
                    GetInstock(k);
                }
                    
         }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void purchaseRequisitionDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ;
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            DataTable dtParts = new DataTable();
            decimal remainingQty;
            //string strSQL;


            try
            {
                addingAll = true;
                dtParts = (DataTable)ItemID.DataSource;

                if (dtParts.Rows.Count > 0)
                {
                    //MessageBox.Show(dtParts.Rows.Count.ToString());
                    foreach (DataRow dr in dtParts.Rows)
                    {
                        int k = 0;

                        string newPart = dr["ItemID"].ToString();
                        //  strSQL = "fIssuedforRequisition '" + this.issueNoTextBox.Text.Trim() + "' , '" + newPart + "', 'ALL'";
                        remainingQty = objData.GetValueInOrder(newPart, refrerenceComboBox.Text.Trim(), "POR");


                        while (k < dv.Rows.Count && dv.Rows[k].Cells["ItemID"].Value.ToString() != newPart && remainingQty > 0)
                            k++;

                        //this line sets the units of all rows
                        if (k >= dv.Rows.Count && remainingQty > 0)
                        {
                            purchaseRequisitionDetailsBindingSource.EndEdit();
                            this.Validate();

                            purchaseRequisitionDetailsBindingSource.AddNew();
                            dv.Rows[dv.CurrentCell.RowIndex].Cells["ItemID"].Value = dr["ItemID"].ToString();

                        }
                    }

                  //  calculateEveryTotal();

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                addingAll = false;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            if (bindingNavigatorDeleteItem.Text == "Delete")
            {
                bindingNavigatorDeleteItem.Text = "Cancel";
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            purchaseRequisitionDetailsBindingSource.MoveFirst();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            objUtility.setApprover(statusComboBox, approvedByComboBox);
        }


        private void logUpdator()
        {
            try
            {
               
                if (createdByTextBox.Text == "")
                {
                    createdByTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                }
                else
                {
                    updatedbyTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                }
            }
            catch (Exception exx) { }
        }

        private void c_ControlChanged(object sender, EventArgs e)
        {
            logUpdator();
        }

    }
}
