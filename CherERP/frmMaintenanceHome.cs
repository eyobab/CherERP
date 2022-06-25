using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmMaintenanceHome : Form
    {
        DataGridView dv;
        clsData objdata = clsData.Instance;

        public frmMaintenanceHome()
        {
            InitializeComponent();
        }

        private void frmMaintenanceHome_Load(object sender, EventArgs e)
        {
        
            try
            {

                dv = grdRecentWos; 
                setAdapterConnectionString();
                // TODO: This line of code loads data into the 'belayAbVMaintain.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.FillByMaintenanceRecord(this.belayAbVMaintain.Customers);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Vehicles' table. You can move, or remove it, as needed.
                this.m_VehiclesTableAdapter.Fill(this.belayAbVMaintain.m_Vehicles);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_maintenance' table. You can move, or remove it, as needed.
                this.m_maintenanceTableAdapter.FillLatest(this.belayAbVMaintain.m_maintenance);                
           
                  
                calculateEveryDuration();

               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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

        }

      

        private void grdVehicleList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void showWorkOrder(string workOrdNo)
        {
            clsData.trNo = workOrdNo;
            frmVehicleMaintenanceProcess fMnt = new frmVehicleMaintenanceProcess();
            Program.mainFrm.OpenOverFrm(fMnt);
         
        }

        private void grdRecentWos_DoubleClick(object sender, EventArgs e)
        {
            showWorkOrder(grdRecentWos.Rows[grdRecentWos.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString());
        }

   

        private void btnAllWorkOrders_Click(object sender, EventArgs e)
        {
            if (btnAllWorkOrders.Text == "Show All")
            {
                this.m_maintenanceTableAdapter.Fill(this.belayAbVMaintain.m_maintenance);
                btnAllWorkOrders.Text = "Show Recent";
            }
            else
            {
                this.m_maintenanceTableAdapter.FillLatest(this.belayAbVMaintain.m_maintenance);
                btnAllWorkOrders.Text = "Show All";
            }

            calculateEveryDuration();
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
                    if (DateTime.TryParse(dv.Rows[row].Cells["DateIn"].Value.ToString(), out dtIn))

                        if (DateTime.TryParse(dv.Rows[row].Cells["DateOut"].Value.ToString(), out dtOut))
                        {

                            //diff = Convert.ToDouble(dtOut) - Convert.ToDouble(dtIn);
                            tms = dtOut.Subtract(dtIn);
                            diff = tms.Days;

                            dv.Rows[row].Cells["Duration"].Value = diff;// Convert.ToInt32(diff);
                        }
                        else
                        {
                            dtOut = DateTime.Now;
                            tms = dtOut.Subtract(dtIn);
                            diff = tms.Days;

                            dv.Rows[row].Cells["Duration"].Value = diff;// Convert.ToInt32(diff);
                        }
                }

            }

            catch (Exception ex) { 
                //MessageBox.Show(ex.Message);
            }


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

     

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmVehicleMaintenanceProcess fv = new frmVehicleMaintenanceProcess();
            Program.mainFrm.OpenFrm(fv);
            fv.bindingNavigatorAddNewItem_Click(new object(), new EventArgs());
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            string strfilterField;
            if (rdPN.Checked) strfilterField = "PlateNumber";
            else
                strfilterField = "WorkOrderNumber";
            objdata.filterData(mmaintenanceBindingSource, strfilterField, txtFind.Text);
            
            calculateEveryDuration();

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

        private void grdRequistions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String reqNo;


            reqNo = grdRequistions.Rows[grdRequistions.CurrentCell.RowIndex].Cells["RequistionNumber"].Value.ToString();
         //   MessageBox.Show(reqNo);
            fillIssues(reqNo);
            //}
            //catch (Exception ex)
            //{
            //    //MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            //}
        }

    
       
    }
}