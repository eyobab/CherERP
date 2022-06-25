using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmVLaborCostDetails : Form
    {
        int lbCostID,VSize;
        public bool startUp = true;
        string strWoFilter = "";
        string WorkNo, Ltype;
        clsUtility objUtility = new clsUtility();

        clsData objData = new clsData();

        DataGridView dgvLbCost, dgvLbWork, dgvLbDetails;

        //for duration computaions

        double fval, sumS = 0, sumA = 0, sumP =0;
        double fvalSe, sumSe; // for sessions



        public frmVLaborCostDetails()
        {
            InitializeComponent();
        }

        public frmVLaborCostDetails(int lbC_ID)
        {
            InitializeComponent();
            lbCostID = lbC_ID;

        }

        public frmVLaborCostDetails(int lbC_ID, int Vs)
        {
            InitializeComponent();
            lbCostID = lbC_ID;
            VSize = Vs;

        }
        public frmVLaborCostDetails(int lbC_ID, int Vs, string wono, string lbType)
        {
            InitializeComponent();
            lbCostID = lbC_ID;
            VSize = Vs;
            Ltype = lbType;
            WorkNo = wono;

        }


        private void frmVLaborCostDetails_Load(object sender, EventArgs e)
        {
           
            setAdapterConnectionString();
            
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_MechanicList' table. You can move, or remove it, as needed.
            this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);
           // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCostDetails' table. You can move, or remove it, as needed.
            this.m_LaborCostDetailsTableAdapter.Fill(this.belayAbVMaintain.m_LaborCostDetails);
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCost_WorkDetails' table. You can move, or remove it, as needed.
            this.m_LaborCost_WorkDetailsTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost_WorkDetails);
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCost' table. You can move, or remove it, as needed.
            this.m_LaborCostTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost);
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_maintenance' table. You can move, or remove it, as needed.
            this.m_maintenanceTableAdapter.FillLatest(this.belayAbVMaintain.m_maintenance);
     
            this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);

                       

   //         refreshItems();
            
            ////////if (lbCostID > 0)
            ////////{
            ////////    this.m_LaborCost_WorkDetailsTableAdapter.FillBy(this.belayAbVMaintain.m_LaborCost_WorkDetails, lbCostID);
            ////////    //          txtLbCost.Text = lbCostID.ToString();
            ////////}
            ////////else
            ////////    this.m_LaborCost_WorkDetailsTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost_WorkDetails);
    
       

            //////string strSQL = "SELECT Distinct  m_FlatRateSubCategories.FlatRateSubCatDesc " +
            //////                " FROM  m_FlatRateValues INNER JOIN m_FlatRateSubCategories ON m_FlatRateValues.FlatRateSubCatID = m_FlatRateSubCategories.FlatRateSubCatId " +
            //////                "Where m_FlatRateValues.VehicleSizeId =" + VSize.ToString() +
            //////  " UNION SELECT lCostType AS FlatRateSubCatDesc FROM m_LaborCostType";

            //populate the labor cost type list (top data grid)

            string strSQL = "SELECT     FlatRateTypeDescription as lCostType  FROM  m_FlatRateTypes" +
                             " UNION SELECT lCostType AS FlatRateSubCatDesc FROM m_LaborCostType";




            objUtility.fillComboValues(LaborType, strSQL);


            LaborType.DisplayMember = "lCostType";
            LaborType.ValueMember = "lCostType";


            strSQL = "SELECT Distinct  m_FlatRateSubCategories.FlatRateSubCatDesc " +
                         " FROM  m_FlatRateValues INNER JOIN m_FlatRateSubCategories ON " +
                         "m_FlatRateValues.FlatRateSubCatID = m_FlatRateSubCategories.FlatRateSubCatId ";// +
                //      "Where m_FlatRateValues.VehicleSizeId =" + VSize.ToString();



            objUtility.fillComboValues(LaborWorkType, strSQL);

            LaborWorkType.DisplayMember = "FlatRateSubCatDesc";
            //////////////////LaborWorkType.ValueMember = "LaborWorkId";

            CalculateTotalHours();


            //txtWONo.Text = WorkNo;
            //txtLaborType.Text = Ltype;

            dgvLbCost = m_LaborCostDataGridView;
            dgvLbWork = m_LaborCost_WorkDetailsDataGridView;
            dgvLbDetails = m_LaborCostDetailsDataGridView;

            

        }
            

       private void setAdapterConnectionString()
        {
                 
            this.m_LaborCostDetailsTableAdapter.Connection = Belayab.clsData.connBel;
            this.m_LaborCostTableAdapter.Connection = Belayab.clsData.connBel;
            this.m_maintenanceTableAdapter.Connection = Belayab.clsData.connBel;
            this.m_maintenanceTableAdapter.Connection = Belayab.clsData.connBel;
            this.m_MechanicListTableAdapter.Connection = clsData.connBel;
            this.m_LaborCost_WorkDetailsTableAdapter.Connection = clsData.connBel;
 
        }


       void updateFlatrateList()
       {

           string flatRateType =" ", strSQL;

           if (dgvLbCost != null && dgvLbCost.CurrentCell != null)
           {
               flatRateType = dgvLbCost.Rows[dgvLbCost.CurrentCell.RowIndex].Cells["LaborType"].Value.ToString();
           }

           if (flatRateType != "Component")
               strSQL = "SELECT     m_FlatRateSubCategories.FlatRateSubCatDesc FROM m_FlatRateTypes INNER JOIN " +
                          "m_FlatRateCategories ON m_FlatRateTypes.FlatRateTypeId = m_FlatRateCategories.FlatRateTypeId INNER JOIN " +
                          "m_FlatRateSubCategories ON m_FlatRateCategories.FlatRateCatId = m_FlatRateSubCategories.FlatRateCatId INNER JOIN " +
                          "m_FlatRateValues ON m_FlatRateSubCategories.FlatRateSubCatId = m_FlatRateValues.FlatRateSubCatID " +
                          "Where m_FlatRateValues.VehicleSizeId =" + VSize.ToString() + " and m_FlatRateTypes.FlatRateTypeDescription ='" +
                          flatRateType + "'";
           else
               strSQL = "SELECT     m_FlatRateSubCategories.FlatRateSubCatDesc FROM m_FlatRateTypes INNER JOIN " +
                                   "m_FlatRateCategories ON m_FlatRateTypes.FlatRateTypeId = m_FlatRateCategories.FlatRateTypeId INNER JOIN " +
                                   "m_FlatRateSubCategories ON m_FlatRateCategories.FlatRateCatId = m_FlatRateSubCategories.FlatRateCatId INNER JOIN " +
                                   "m_FlatRateValues ON m_FlatRateSubCategories.FlatRateSubCatId = m_FlatRateValues.FlatRateSubCatID " +
                                   "Where m_FlatRateValues.VehicleSizeId =" + VSize.ToString();
        
           //       " UNION SELECT lCostType AS FlatRateSubCatDesc FROM m_LaborCostType";


           objUtility.fillComboValues(LaborWorkType, strSQL);
       }

        private void m_LaborCost_WorkDetailsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex >= 0)
                    if (m_LaborCost_WorkDetailsDataGridView.Columns[e.ColumnIndex].Name == LaborWorkType.Name)
                    {
                        setFlatRate(e.RowIndex);
                    }

            }
            catch (Exception ex)
            {


            }
        }



        private void setFlatRate(int rIdx)
        {

            if (objData.exists("Select * from m_FlatRateSubCategories where FlatRateSubCatDesc ='" + m_LaborCost_WorkDetailsDataGridView.Rows[rIdx].Cells["LaborWorkType"].Value.ToString() + "'")) ;
            {
                string StrSQL = "SELECT FlatRateHours  FROM m_FlatRateValues Inner join m_FlatRateSubCategories on " +
                                  "m_FlatRateValues.FlatRateSubCatId = m_FlatRateSubCategories.FlatRateSubCatId " +
                               " Where m_FlatRateValues.VehicleSizeId =" + VSize +
                              " And FlatRateSubCatDesc ='" + m_LaborCost_WorkDetailsDataGridView.Rows[rIdx].Cells["LaborWorkType"].Value.ToString() + "'";

                dgvLbWork.Rows[rIdx].Cells["WorkHours"].Value = decimal.Parse(objData.getFieldValue(StrSQL));
            }
        }

        private void UpdateFlatRates()
        {
            try
            {

                int k;

                if (m_LaborCost_WorkDetailsDataGridView.Rows.Count > 0)
                    for (k = 0; k < m_LaborCost_WorkDetailsDataGridView.Rows.Count; k++)
                        setFlatRate(k);

            }
            catch (Exception ex)
            {
                //         MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void m_LaborCost_WorkDetailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalculateTotalHours()
        {

            fval = 0; sumP = 0; sumS = 0; sumA = 0;


            try
            {
                if (dgvLbWork!=null)
                  if (dgvLbWork.Rows.Count != 0) 
                    for (int k = 0; k < dgvLbWork.Rows.Count; k++)
                    {
                        if (double.TryParse(dgvLbWork.Rows[k].Cells["WorkHours"].Value.ToString(), out fval))
                            sumS += fval;

                        if (double.TryParse(dgvLbWork.Rows[k].Cells["ActualHours"].Value.ToString(), out fval))
                            sumA += fval;
      
                    }
               


                txtTotalHours.Text = string.Format("{0: #,##0.0}", Math.Round(sumS));
                txtTotalActualHours.Text = string.Format("{0: #,##0.0}", Math.Round(sumA));

               

            }
            catch (Exception ex)
            {
              MessageBox.Show(" Errors on hours calculation -- " + ex.Message);
            }

        }

        private void CalculateTotalDuration()
        {

            fvalSe = 0; sumSe = 0;

            try
            {
                if (dgvLbDetails.Rows.Count != 0) 
                for (int k = 0; k < dgvLbDetails.Rows.Count; k++)
                {
                    if (double.TryParse(dgvLbDetails.Rows[k].Cells["Duration"].Value.ToString(), out fval))
                        sumSe += fval;
                }

                txtTotalDuration.Text = string.Format("{0: #,##0.0}", Math.Round(sumSe,0));
        
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateTotalDuration()
        {
            CalculateTotalDuration();
            if (dgvLbWork !=null && dgvLbWork.CurrentCell !=null)
              dgvLbWork.Rows[dgvLbWork.CurrentCell.RowIndex].Cells["ActualHours"].Value = sumSe.ToString();
        }

        private void updateFinalLaborHours()
        {
            CalculateTotalHours();
           
            sumP = sumA;
            if (sumS > sumA) sumP = sumS;
            
            dgvLbCost.Rows[dgvLbCost.CurrentCell.RowIndex].Cells["LaborHours"].Value = sumP.ToString();
            dgvLbCost.Rows[dgvLbCost.CurrentCell.RowIndex].Cells["StandardHours"].Value = sumS.ToString();
            dgvLbCost.Rows[dgvLbCost.CurrentCell.RowIndex].Cells["ActualHours_"].Value = sumA.ToString();

        }

        private void m_LaborCost_WorkDetailsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int rIdx = m_LaborCost_WorkDetailsDataGridView.CurrentCell.RowIndex;
            string mech = m_LaborCost_WorkDetailsDataGridView.Rows[rIdx].Cells["Mechanic"].Value.ToString();

            frmLaborCostDetails flcd = new frmLaborCostDetails("", mech);
            Program.mainFrm.OpenFrm(flcd);
        }

       

        private void btnSessionSave_Click(object sender, EventArgs e)
        {
            m_LaborCostDetailsBindingSource.EndEdit();
            m_LaborCostDetailsTableAdapter.Update(belayAbVMaintain.m_LaborCostDetails);

            btnSaveLaborWorks_Click(null, null);

        }

        private void m_LaborCost_WorkDetailsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void btnSaveLaborCosts_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_LaborCostBindingSource.EndEdit();
            this.m_LaborCostTableAdapter.Update(this.belayAbVMaintain.m_LaborCost);
            
            
            //then refresh the work details data!!
            this.belayAbVMaintain.m_LaborCost.AcceptChanges();
            updateFlatrateList();
          
        }

        private void btnSaveLaborWorks_Click(object sender, EventArgs e)
        {
            
            UpdateTotalDuration();
            
            CalculateTotalHours();

            updateFinalLaborHours();
           
            
           // this.Validate();
            
            this.m_LaborCost_WorkDetailsBindingSource.EndEdit();
            this.m_LaborCost_WorkDetailsTableAdapter.Update(this.belayAbVMaintain.m_LaborCost_WorkDetails);
          
            btnSaveLaborCosts_Click(null, null);
            
        }

        private void UpdateSessionHours(int rIdx)
        {

            DateTime dtS = Convert.ToDateTime( dgvLbDetails.Rows[rIdx].Cells["SessionStart"].Value);
            DateTime dtE = Convert.ToDateTime(dgvLbDetails.Rows[rIdx].Cells["SessionEnd"].Value);

            double Duration = GetHours(dtS, dtE);

            dgvLbDetails.Rows[rIdx].Cells["Duration"].Value = Duration;

            CalculateTotalDuration();

          

        }

        private double GetHours(DateTime dt1, DateTime dt2)
        {
            
           
            TimeSpan diff = dt2.Subtract(dt1);

            double Mins = diff.TotalMinutes;
            double Hours = Math.Round(Mins / 60,0);

            return Hours;

    //        durationTextBox.Text = string.Format("{0:#,##0.00}", Hours);

        }

        private void m_LaborCostDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //////if (dgvLbDetails.Columns[e.ColumnIndex].Name == "SessionStart")
            //////    if (MessageBox.Show("Confirm", "Begins or Changes the Session start value with current date and time value. Are you sure?", 
            //////        MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            //////        dgvLbDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DateTime.Now;


            //////if (dgvLbDetails.Columns[e.ColumnIndex].Name == "SessionEnd")
             

            
        }

        //private void m_LaborCostDetailsDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //       if (dgvLbDetails !=null)
        //        if (dgvLbDetails.CurrentCell != null)
        //        {
        //            UpdateSessionHours(dgvLbDetails.CurrentCell.RowIndex);
        //            UpdateTotalDuration();
        //        }

        //    }
        //    catch (Exception ex) { }
        //}

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rIdx = dgvLbDetails.CurrentCell.RowIndex; 
            if (MessageBox.Show( "Begins or Changes the Session start value with current date and time value. Are you sure?","Confirm",
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                 dgvLbDetails.Rows[rIdx].Cells["SessionStart"].Value = DateTime.Now.ToString();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rIdx;
            if (dgvLbDetails.CurrentCell != null)
            {
                rIdx = dgvLbDetails.CurrentCell.RowIndex;

                if (MessageBox.Show("Ends or Changes the Session End value with current date and time value. Are you sure?", "Confirm",
                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (DateTime.Now > Convert.ToDateTime(dgvLbDetails.Rows[rIdx].Cells["SessionStart"].Value))
                        dgvLbDetails.Rows[rIdx].Cells["SessionEnd"].Value = DateTime.Now.ToString();
                    else
                        MessageBox.Show("Session Ending Time can not be before Session Starting time", "Session Setting Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    return;
                  


                if ( dgvLbDetails.Rows[dgvLbDetails.CurrentCell.RowIndex].Cells["SessionNo"].Value.ToString()  == "" )
                {
                    int nxtSessNo =  getNextSessionNo();
                    dgvLbDetails.Rows[dgvLbDetails.CurrentCell.RowIndex].Cells["SessionNo"].Value = nxtSessNo;

                }

                UpdateSessionHours(rIdx);
            }

        }


       int getNextSessionNo()
       {
           int nxtNo=0;
           if (dgvLbDetails.Rows.Count > 0)
           {
             //  nxtNo= Convert.ToInt32(dgvLbDetails.Rows[0].Cells["SessionNo"].Value.ToString());
               for (int k=0; k<dgvLbDetails.Rows.Count-1; k++)
               {
                   int no = Convert.ToInt32(dgvLbDetails.Rows[k].Cells["SessionNo"].Value.ToString());
                   if(nxtNo < no) nxtNo = no;
               }
           }

           return nxtNo+1;

       }

        private void updateDurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSessionHours(dgvLbDetails.CurrentCell.RowIndex);
            UpdateTotalDuration();
        }

        private void m_maintenanceDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Program.showWorkOrder(m_maintenanceDataGridView.Rows[m_maintenanceDataGridView.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bnLaborCost.BindingSource.RemoveCurrent();
                    btnSaveLaborCosts_Click(null, null);
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

                    bnLbWorkDetails.BindingSource.RemoveCurrent();
                    btnSaveLaborWorks_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            btnSaveLaborWorks_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    bnLbWorkSessions.BindingSource.RemoveCurrent();
                    btnSessionSave_Click(null, null);
                    
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAddNewSession_Click(object sender, EventArgs e)
        {
            m_LaborCostDetailsBindingSource.AddNew();
        }

        private void m_LaborCostDetailsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvLbDetails != null)
                    if (dgvLbDetails.CurrentCell != null)
                    {
                      
                         UpdateSessionHours(dgvLbDetails.CurrentCell.RowIndex);
                         UpdateTotalDuration();
                    }

            }
            catch (Exception ex) { }
        }

        private void m_maintenanceDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string strSQL = " SELECT  dbo.m_VehicleSizes.VehicleSizeId "
                           + " FROM dbo.m_Vehicles INNER JOIN  dbo.m_VehicleType ON dbo.m_Vehicles.VehicleType = dbo.m_VehicleType.Vehicletype INNER JOIN "
                            + " dbo.m_VehicleSizes ON dbo.m_VehicleType.VehicleSizeId = dbo.m_VehicleSizes.VehicleSizeId where dbo.m_Vehicles.[Plate Number]='" +
                            m_maintenanceDataGridView.Rows[m_maintenanceDataGridView.CurrentCell.RowIndex].Cells["PlateNumber"].Value.ToString() + "'";

                VSize = Convert.ToInt32(objData.getFieldValue(strSQL));
                
                updateFlatrateList();
           
            
            }
            catch (Exception ex) { }
           
        }


        private void m_LaborCost_WorkDetailsDataGridView_Enter(object sender, EventArgs e)
        {
           dgvLbCost = m_LaborCostDataGridView;
           // if (dgvLbCost.Columns[dgvLbCost.CurrentCell.ColumnIndex].Name == "LaborType")
               updateFlatrateList();
        }

        private void m_LaborCostDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void refreshFlateRateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateFlatrateList();
        }

        private void m_LaborCostDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updateFlatrateList();
        }

        private void refreshWorkOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m_maintenanceTableAdapter.FillLatest(this.belayAbVMaintain.m_maintenance);

        }

        private void frmVLaborCostDetails_Activated(object sender, EventArgs e)
        {
            if (clsData.trNo != "")
            {
                int res = m_maintenanceBindingSource.Find("WorkOrderNumber", clsData.trNo);
                if (res > -1) m_maintenanceBindingSource.Position = res;
                clsData.trNo = "";
            }

            this.WindowState = FormWindowState.Maximized;
        }

        private void hideOthersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showHideWorkOrderList();
        }

        public void showHideWorkOrderList()
        {
           if (m_maintenanceDataGridView.Rows.Count > 0) 
            strWoFilter = m_maintenanceDataGridView.Rows[m_maintenanceDataGridView.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString();

            if (hideOthersToolStripMenuItem.Text == "Hide Others")
            {
                m_maintenanceBindingSource.Filter = "WorkOrderNumber ='" + strWoFilter + "'";
                hideOthersToolStripMenuItem.Text = "Show Others";
            }

            else
            {
                m_maintenanceBindingSource.Filter = "";
                txtFind.Text = "";
                hideOthersToolStripMenuItem.Text = "Hide Others";
            }

            int res = m_maintenanceBindingSource.Find("WorkOrderNumber", strWoFilter);
            if (res > -1) m_maintenanceBindingSource.Position = res;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m_maintenanceBindingSource.Filter = "WorkOrderNumber like '" + txtFind.Text.Trim() + "%'";
            hideOthersToolStripMenuItem.Text = "Show Others";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string strfilterField;
          //  if (rdPN.Checked) strfilterField = "PlateNumber";
            strfilterField = "WorkOrderNumber";
           
            objData.filterData(m_maintenanceBindingSource, strfilterField, txtFind.Text);
            
            if (txtFind.Text !="") hideOthersToolStripMenuItem.Text = "Show Others";
            else hideOthersToolStripMenuItem.Text = "Hide Others";
           
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contextMenuStrip3.Hide();

            if (txtFind.Text != "") hideOthersToolStripMenuItem.Text = "Show Others";
            else hideOthersToolStripMenuItem.Text = "Hide Others";

        }

        private void m_LaborCost_WorkDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void m_LaborCostDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void m_LaborCostDetailsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void m_LaborCostDetailsDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            int rIdx = e.RowIndex;

            if (Convert.ToDateTime(dgvLbDetails.Rows[rIdx].Cells["SessionEnd"].Value) < Convert.ToDateTime(dgvLbDetails.Rows[rIdx].Cells["SessionStart"].Value))
             {    MessageBox.Show("Session Ending Time can not be before Session Starting time", "Session Setting Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
              }

    }
     
            
    }
}
