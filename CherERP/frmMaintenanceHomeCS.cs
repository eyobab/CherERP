using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmMaintenanceHomeCS : Form
    {
        DataGridView dv;
        clsData objdata = clsData.Instance;
        DataTable dtMaint;

        public frmMaintenanceHomeCS()
        {
            InitializeComponent();
        }

        private void frmMaintenanceHome_Load(object sender, EventArgs e)
        {
          
            try
            {

                dv = grdRecentWos; 
                setAdapterConnectionString();
                
             
                // TODO: This line of code loads data into the 'belayAbVMaintain.MaintenanceList' table. You can move, or remove it, as needed.
               this.maintenanceListTableAdapter.FillLatestByStore(this.belayAbVMaintain.MaintenanceList,clsVariables.sStore);
               // TODO: This line of code loads data into the 'belayAbVMaintain.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.FillByMaintenanceRecord(this.belayAbVMaintain.Customers);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Vehicles' table. You can move, or remove it, as needed.
                this.m_VehiclesTableAdapter.Fill(this.belayAbVMaintain.m_Vehicles);

            //    this.m_maintenanceTableAdapter.FillByStore(this.belayAbVMaintain.m_maintenance, clsVariables.sStore);
              

                dtMaint = this.belayAbVMaintain.m_maintenance;

                calculateEveryDuration();
            
                //     setAllVehicleTypes();


               
            }
            catch (Exception ex) { }

        }

        private void fillRequisitions(String won)
        {
          // TODO: This line of code loads data into the 'belayAbItemRequistions.ItemRequisition' table. You can move, or remove it, as needed.
            this.itemRequisitionTableAdapter.FillByReferenceNumber(this.belayAbItemRequistions.ItemRequisition,won);
           // TODO: This line of code loads data into the 'belayAbItemRequistions.ItemRequisitionDetails' table. You can move, or remove it, as needed.
            this.itemRequisitionDetailsTableAdapter.Fill(this.belayAbItemRequistions.ItemRequisitionDetails);
             // TODO: This line of code loads data into the 'belayAbSSDataSet.PartNumDescription' table. You can move, or remove it, as needed.
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);

            // Clear the Issues grid if no requisitions!
           fillIssues("___NULL____");

           
       }

        private void fillIssues(string reqNo)
        {
            // TODO: This line of code loads data into the 'belayAbSSDataSet.ItemsIssued' table. You can move, or remove it, as needed.
            this.itemsIssuedTableAdapter.FillByRequsitionNumber(this.belayAbSSDataSet.ItemsIssued,reqNo);
            // TODO: This line of code loads data into the 'belayAbSSDataSet.ItemsIssuedDetails' table. You can move, or remove it, as needed.
            this.itemsIssuedDetailsTableAdapter.Fill(this.belayAbSSDataSet.ItemsIssuedDetails);
        }

        private void setAdapterConnectionString()
        {
            customersTableAdapter.Connection = clsData.connBel;
            m_VehiclesTableAdapter.Connection= clsData.connBel;
            m_maintenanceTableAdapter.Connection = clsData.connBel;
            customersTableAdapter.Connection = clsData.connBel;
            itemsIssuedDetailsTableAdapter.Connection = clsData.connBel;
            itemsIssuedTableAdapter.Connection = clsData.connBel;
            itemRequisitionDetailsTableAdapter.Connection = clsData.connBel;
            itemRequisitionTableAdapter.Connection = clsData.connBel;
            maintenanceListTableAdapter.Connection = clsData.connBel;

        }

        private void lstOwners_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.m_maintenanceTableAdapter.FillByPlateNo(this.belayAbVMaintain.m_maintenance,"");
            listVehicles(false);

            if (grdVehicleList.Rows.Count > 0)
            {
                grdVehicleList.Rows[0].Selected = true;
                listWorkWorders(false);
            }
        }

        private void grdVehicleList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void listVehicles(bool all)
        {
            try
            {
                if (all)
                {
                    this.m_VehiclesTableAdapter.Fill(this.belayAbVMaintain.m_Vehicles);
                }
                else
                {

                    this.m_VehiclesTableAdapter.FillBy(this.belayAbVMaintain.m_Vehicles, (int)lstOwners.SelectedValue);
                }
            }
            catch (Exception ex) { }
        }

        private void listWorkWorders(bool all)
        {
            try
            {
                if (clsData.connBel.State == ConnectionState.Open) clsData.connBel.Close();
                clsData.connBel.Open();

                if (all)
                {
                    this.m_maintenanceTableAdapter.FillByStore(this.belayAbVMaintain.m_maintenance, clsVariables.sStore);
                }
                else
                {
                    if ( grdVehicleList.CurrentCell != null)
                      this.m_maintenanceTableAdapter.FillByPlateNoStoreID(this.belayAbVMaintain.m_maintenance, grdVehicleList.Rows[grdVehicleList.CurrentCell.RowIndex].Cells["PlateNumberV"].Value.ToString().Trim(), clsVariables.sStore);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void grdRecentWos_DoubleClick(object sender, EventArgs e)
        {
            if (clsVariables.sEmployeeDepartment.ToUpper().Trim() == "STORE") return;
            
            Program.showWorkOrder(grdRecentWos.Rows[grdRecentWos.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);

        }

        private void grdHistory_DoubleClick(object sender, EventArgs e)
        {
            if (clsVariables.sEmployeeDepartment.ToUpper().Trim() == "STORE") return;
            Program.showWorkOrder(grdHistory.Rows[grdHistory.CurrentCell.RowIndex].Cells["WorkOrderNumber1"].Value.ToString(),false);

        }

        private void btnAllWorkOrders_Click(object sender, EventArgs e)
        {
            if (btnAllWorkOrders.Text == "Show All")
            {
                this.maintenanceListTableAdapter.FillByStore(this.belayAbVMaintain.MaintenanceList,clsVariables.sStore);
                btnAllWorkOrders.Text = "Show Recent";
                
            }
            else
            {
                this.maintenanceListTableAdapter.FillLatestByStore(this.belayAbVMaintain.MaintenanceList,clsVariables.sStore);
                btnAllWorkOrders.Text = "Show All";
            }

            calculateEveryDuration();
//           // setAllVehicleTypes();
        }

        private void calculateDuration(int row)
        {
           double diff = 0;
           DateTime dtOut, dtIn;
           TimeSpan tms;

            try
            {
                           

                if (row < dv.Rows.Count)
                {
                    if (DateTime.TryParse(dv.Rows[row].Cells["DateIn1"].Value.ToString(), out dtIn))

                        if (DateTime.TryParse(dv.Rows[row].Cells["DateOut1"].Value.ToString(), out dtOut))
                        {

                            //diff = Convert.ToDouble(dtOut) - Convert.ToDouble(dtIn);
                            tms = dtOut.Subtract(dtIn);
                            diff = tms.Days;

                            dv.Rows[row].Cells["Duration1"].Value = diff;// Convert.ToInt32(diff);
                        }
                        else
                        {
                            dtOut = DateTime.Now;
                            tms = dtOut.Subtract(dtIn);
                            diff = tms.Days;

                            dv.Rows[row].Cells["Duration1"].Value = diff;// Convert.ToInt32(diff);
                        }
                }

            }

            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }


        }

        private void setAllVehicleTypes()
        {
             try
            {
                int k;

                for (k = 0; k < dtMaint.Rows.Count; k++)
                    setVehicleType(k);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        


        }

        private void calculateEveryDuration()
        {
            try
            {
                int k;

                for (k = 0; k < dv.Rows.Count; k++)
                    calculateDuration(k);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnAllVehicles_Click(object sender, EventArgs e)
        {
            listVehicles(true);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmVehicleMaintenanceProcess fv = new frmVehicleMaintenanceProcess();
            Program.mainFrm.OpenFrm(fv);
            
            fv.bindingNavigatorAddNewItem_Click(new object(), new EventArgs());
            fv.storeIDComboBox.Enabled = false;

        }

        private void grdVehicleList_SelectionChanged(object sender, EventArgs e)
        {
            listWorkWorders(false);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string strfilterField;
            if (rdPN.Checked) strfilterField = "PlateNumber";
            else if (rdWON.Checked) strfilterField = "WorkOrderNumber";
            else strfilterField = "CustomerName";
            objdata.filterData(maintenanceListBindingSource, strfilterField, txtFind.Text);
            
            calculateEveryDuration();
           // setAllVehicleTypes();

        }

        private void rdWON_CheckedChanged(object sender, EventArgs e)
        {
            txtFind_TextChanged(null, null);
        }

        private void rdPN_CheckedChanged(object sender, EventArgs e)
        {
            txtFind_TextChanged(null, null);
        }

      

        private void itemRequisitionBindingSource_PositionChanged(object sender, EventArgs e)
        {
          
        }


        private void grdRecentWos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String workOrderNo;

            try
            {
                workOrderNo = grdRecentWos.Rows[grdRecentWos.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString();
                fillRequisitions(workOrderNo);
            }
            catch (Exception ex)
            {
                //          MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

      

        private void setVehicleType(int rIdx)
        {
            string plNo = dtMaint.Rows[rIdx]["PlateNumber"].ToString();
            
      //      string StrSQL = " SELECT  Distinct VehicleType FROM m_Vehicles Where [Plate Number] ='" + grdRecentWos.Rows[rIdx].Cells["PlateNumber"].Value.ToString() + "'";
      //        grdRecentWos.Rows[rIdx].Cells["VehicleType"].Value = objdata.getFieldValue(StrSQL);

            string StrSQL = " SELECT  Distinct VehicleType FROM m_Vehicles Where [Plate Number] ='" + plNo + "'";
            dtMaint.Rows[rIdx]["VehicleType"] = objdata.getFieldValue(StrSQL);
            
        }

        private void workOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.showWorkOrder(grdRecentWos.Rows[grdRecentWos.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);

        }

        private void laborWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.showLaborDetails(grdRecentWos.Rows[grdRecentWos.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);

        }

        private void frmMaintenanceHomeCS_Resize(object sender, EventArgs e)
        {
            grdRecentWos.Width = this.Width - 50;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmMaintenanceHome_Load(null, null);
        }


       
    }
}