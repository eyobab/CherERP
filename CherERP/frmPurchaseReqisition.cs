using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmPurchaseReqisition : Form
    {
        clsUtility objUtility = new clsUtility();

        public frmPurchaseReqisition()
        {
            InitializeComponent();
        }

        private void purchaseRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveMain();
        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
           
            setAdapterConnectionString(); 
            
            this.m_RequisitionNumbersTableAdapter.Fill(this.belayAbSSDataSet.m_RequisitionNumbers);
            this.supplierListTableAdapter.Fill(this.belayAbSSDataSet.SupplierList);
            this.employeesLstTableAdapter.Fill(this.belayAbItemRequistions.EmployeesLst);
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
            this.purchaseRequisitionDetailsTableAdapter.Fill(this.belayAbSSDataSet.PurchaseRequisitionDetails);
            this.purchaseRequisitionTableAdapter.Fill(this.belayAbSSDataSet.PurchaseRequisition);

            string strSQL = "Select EmployeeId, EmployeeName From EmployeeList Order By EmployeeName";
            objUtility.fillComboValues(approvedByComboBox, strSQL);


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

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            SaveDetails();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bNavAddnew.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("All Requistion records will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        purchaseRequisitionBindingSource.RemoveCurrent();
                        saveMain();
                        bNavAddnew.Enabled = true;

                    }
               
                
            }
             
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

            public void  saveMain()
            {

                try
                {
                    this.Validate();
                    this.purchaseRequisitionBindingSource.EndEdit();
                    this.purchaseRequisitionTableAdapter.Update(this.belayAbSSDataSet.PurchaseRequisition);
                    bNavAddnew.Enabled = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

        private void SaveDetails()
        {
            try
            {

                this.Validate();
                this.purchaseRequisitionDetailsBindingSource.EndEdit();
                this.purchaseRequisitionDetailsTableAdapter.Update(this.belayAbSSDataSet.PurchaseRequisitionDetails);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("All Requistion records will be Deleted! \n Are you sure to delete ? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    purchaseRequisitionDetailsBindingSource.RemoveCurrent();

                    SaveDetails();
                    bNavAddnew.Enabled = true;

                }

            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void purchaseRequisitionDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null) { }
        }

        private void purchaseRequisitionDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveMain();
        }
    }
}