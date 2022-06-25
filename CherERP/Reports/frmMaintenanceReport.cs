using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab;
using CrystalDecisions.Reporting;

namespace Belayab.Reports
{
    public partial class frmMaintenanceReport : Form

    {
        public Form fm;
        string strCriteria = "0";
        int grpOption = 0, grpLaborDetailsOption = 2;

        string strDeliveryStatus = ""; //" Or isOut <> 1 ";
        string strInOrOutDate = "[Date Out]";
        string laborworktype = "All";

        clsUtility objUtility = new clsUtility();

        public frmMaintenanceReport()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (this.tbMaintenanceReports.SelectedIndex)
            {
                case 0: showMaintenanceReport(); break;
                case 1: showMechanicReport(); break;
                case 2: showLaborReport(); break;
                case 3: showItemsIssuedMReport(); break;
            }
         
        }


        private void showMaintenanceReport()
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from Maintainance_Totals Where " + strInOrOutDate + " Between '" +
            dtFrom.Value.ToShortDateString() + " 00:00:00' And '" + dtTo.Value.ToShortDateString() + " 23:59:59' " + strDeliveryStatus;// or m_ReceivedDate is null";


            if (cboCustomer.Text != "All")
            {
                strSQL += " and CustomerName = '" + cboCustomer.Text + "'";
                strCriteria = "1";
            }
            else if (cboCusType.Text != "All")
            {
                strSQL += " and CustomerTypeName = '" + cboCusType.Text + "'";
                strCriteria = "2";
            }

            if (cboServiceType.Text != "All") strSQL += " and m_TypeName = '" + cboServiceType.Text + "'";

            if (cboVehicleType.Text != "All") strSQL += " and VehicleType = '" + cboVehicleType.Text + "'";
          
       //     if (cboLaborWorkType.Text != "All") strSQL += " and lCostType = '" + cboLaborWorkType.Text + "'";
            if (clsVariables.sStore !="All")
                strSQL += " and StoreID ='" + clsVariables.sStore + "'";

            string str = dtTo.Value.ToShortDateString();

            //Declarations for reports
            rptMaintenanceListingMWDetailsOnly rptMLDO = null;
            rptMaintenanceListingMWDetailsOnly_K rptMLDOK = null;
            rptMaintenanceListingMWDetails_K rptMLDK = null;
            rptMaintenanceListingMWDetails rptMLD = null;



            switch (grpOption)
            {
             
                case 0:
                    if (grpLaborDetailsOption == 0)
                    {

                        if (clsVariables.sStore == "KBS1")
                        {
                            rptMLDOK = new rptMaintenanceListingMWDetailsOnly_K();
                            frmv.SetReport(rptMLDOK, strSQL, "Maintainance_Totals");
                            rptMLDOK.DataDefinition.FormulaFields["filtered"].Text = strCriteria;

                        }
                        else
                        {
                            rptMLDO = new rptMaintenanceListingMWDetailsOnly();
                            frmv.SetReport(rptMLDO, strSQL, "Maintainance_Totals");
                            rptMLDO.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                        }
                    }

                    else if (grpLaborDetailsOption == 1)
                    {
                        rptMaintenanceListingMW rptML = new rptMaintenanceListingMW();
                        frmv.SetReport(rptML, strSQL, "Maintainance_Totals");
                        rptML.DataDefinition.FormulaFields["filtered"].Text = strCriteria; 
                    }
                    else
                    {
                        if (clsVariables.sStore == "KBS1")
                        {
                            rptMLDK = new rptMaintenanceListingMWDetails_K();
                            frmv.SetReport(rptMLDK, strSQL, "Maintainance_Totals");
                            rptMLDK.DataDefinition.FormulaFields["filtered"].Text = strCriteria;

                        }
                        else
                        {
                            rptMLD = new rptMaintenanceListingMWDetails();
                            frmv.SetReport(rptMLD, strSQL, "Maintainance_Totals");
                            rptMLD.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                        }
                    }

                    break;

                case 1:
                    rptMaintenanceListing_Cus_Type rptMLCT = new rptMaintenanceListing_Cus_Type();
                    frmv.SetReport(rptMLCT, strSQL, "Maintainance_Totals");
                    rptMLCT.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;
                case 2:
                    rptMaintenanceListingMW_ByVehicleType  rptMLVT = new rptMaintenanceListingMW_ByVehicleType();
                    frmv.SetReport(rptMLVT, strSQL, "Maintainance_Totals");
                    rptMLVT.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;
                case 3:
                    rptMaintenanceListing_Ser_Type rptMLST = new rptMaintenanceListing_Ser_Type();
                    frmv.SetReport(rptMLST, strSQL, "Maintainance_Totals");
                    rptMLST.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;

            }

            //rptObj.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
            Program.mainFrm.OpenFrm(frmv);
           // this.Hide();
        }

        private void showLaborReport()
        {

            frmReportsViewer frmv = new frmReportsViewer();


            string strSQL = "Select * from rpt_Mechanic_Labour Where [Date out] Between '" +
     dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "' " + strDeliveryStatus +  " And [Labor Type]= '" + laborworktype + "'";
            

            if (cboCustomer.Text != "All")
            {
                strSQL += " and CustomerName = '" + cboCustomer.Text + "'";
                strCriteria = "1";
            }

            //else if (cboCusType.Text != "All")
            //{
            //    strSQL += " and CustomerTypeName = '" + cboCusType.Text + "'";
            //    strCriteria = "2";
            //}

            //if (cboServiceType.Text != "All") strSQL += " and m_TypeName = '" + cboServiceType.Text + "'";

            //if (cboVehicleType.Text != "All") strSQL += " and VehicleType = '" + cboVehicleType.Text + "'";


            string str = dtTo.Value.ToShortDateString();


           rpt_Workshop_Labor_Report rptML = new rpt_Workshop_Labor_Report();
           frmv.SetReport(rptML, strSQL, "rpt_Mechanic_Labour");
            
            //rptObj.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
            Program.mainFrm.OpenFrm(frmv);
            //this.Hide();        

        }
       
        private void showMechanicReport()
        {
            frmReportsViewer frmv = new frmReportsViewer();

            if (lstMechanicList.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select at least one mechanic!", "Selection Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

           // create the criteria for the In part

            string inQuery =" and FullName In ('";

            if (lstMechanicList.GetSelected(0)) inQuery += lstMechanicList.GetItemText(lstMechanicList.Items[0]);

            for (int i = 1; i < lstMechanicList.Items.Count-1; i++)
                if (lstMechanicList.GetSelected(i)) inQuery += "','" + lstMechanicList.GetItemText(lstMechanicList.Items[i]);

            if (lstMechanicList.GetSelected(lstMechanicList.Items.Count - 1))
                inQuery += "','" + lstMechanicList.GetItemText(lstMechanicList.Items[lstMechanicList.Items.Count - 1]);
                   
                   inQuery += "')";

                   string strSQL = "Select * from m_Mechanic_Performance Where SesionStart Between '" +
            dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "' " + strDeliveryStatus
             + inQuery; // or m_ReceivedDate is null"; rpt_Mechanic_Labor


            if (cboCustomer.Text != "All")
            {
                strSQL += " and CustomerName = '" + cboCustomer.Text + "'";
                strCriteria = "1";
            }
            //else if (cboCusType.Text != "All")
            //{
            //    strSQL += " and CustomerTypeName = '" + cboCusType.Text + "'";
            //    strCriteria = "2";
            //}

            //if (cboServiceType.Text != "All") strSQL += " and m_TypeName = '" + cboServiceType.Text + "'";

            //if (cboVehicleType.Text != "All") strSQL += " and VehicleType = '" + cboVehicleType.Text + "'";


            string str = dtTo.Value.ToShortDateString();

            switch (grpOption)
            {
                case 0:
                    if (chkDetails.Checked)
                    {
                        rptMechanicPerformance rptML = new rptMechanicPerformance();
                        frmv.SetReport(rptML, strSQL, "m_Mechanic_Performance");
                    }
                    else
                    {
                        rptMechanicPerformance rptMLS = new rptMechanicPerformance();
                        frmv.SetReport(rptMLS, strSQL, "m_Mechanic_Performance");
                    }
                    
             //       rptML.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;

                case 1:
                    rptMaintenanceListing_Cus_Type rptMLCT = new rptMaintenanceListing_Cus_Type();
                    frmv.SetReport(rptMLCT, strSQL, "Maintainance_Totals");
                    rptMLCT.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;
                case 2:
                    rptMaintenanceListing_Veh_Type rptMLVT = new rptMaintenanceListing_Veh_Type();
                    frmv.SetReport(rptMLVT, strSQL, "Maintainance_Totals");
                    rptMLVT.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;
                case 3:
                    rptMaintenanceListing_Ser_Type rptMLST = new rptMaintenanceListing_Ser_Type();
                    frmv.SetReport(rptMLST, strSQL, "Maintainance_Totals");
                    rptMLST.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
                    break;

            }



            //rptObj.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
            Program.mainFrm.OpenFrm(frmv);
            //this.Hide();
        }


    /// <summary>
    ///  Just By me
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>


        private void showItemsIssuedMReport()
        {
            frmReportsViewer frmv = new frmReportsViewer();

          


            // create the criteria for the In part


            string strSQL = "Select * from rpt_ItemsIssuedM Where [Date Out] Between '" +
     dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "' ";
  
     /*  
     
     + strDeliveryStatus
      + inQuery; // or m_ReceivedDate is null"; rpt_Mechanic_Labor


            if (cboCustomer.Text != "All")
            {
                strSQL += " and CustomerName = '" + cboCustomer.Text + "'";
                strCriteria = "1";
            }
            //else if (cboCusType.Text != "All")
            //{
            //    strSQL += " and CustomerTypeName = '" + cboCusType.Text + "'";
            //    strCriteria = "2";
            //}

            //if (cboServiceType.Text != "All") strSQL += " and m_TypeName = '" + cboServiceType.Text + "'";

            //if (cboVehicleType.Text != "All") strSQL += " and VehicleType = '" + cboVehicleType.Text + "'";

*/
                      rptItemsIssuedListingM rptItmI = new rptItemsIssuedListingM();
                        frmv.SetReport(rptItmI, strSQL, "rpt_ItemsIssuedM");
          



            //rptObj.DataDefinition.FormulaFields["filtered"].Text = strCriteria;
            Program.mainFrm.OpenFrm(frmv);
            //this.Hide();
        }
        
        
        private void frmMaintenanceReport_Load(object sender, EventArgs e)
        {

            setAdapterConnectionString();
            
            
            // TODO: This line of code loads data into the 'belayAbVMaintain.rpt_Mechanic_Labour' table. You can move, or remove it, as needed.
       
            //WATCH FOR MECHANIC
            ////////////     this.rpt_Mechanic_LabourTableAdapter.Fill(this.belayAbVMaintain.rpt_Mechanic_Labour);
            
                       
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_MechanicList' table. You can move, or remove it, as needed.
            this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);
            dtFrom.Value = Convert.ToDateTime("01/" + "01/" + string.Format("{0:yyyy}", DateTime.Now).ToString());

           string sql = "Select CustomerTypeName from CustomerTypes";
            objUtility.AddComboValues(cboCusType, sql, "CustomerTypeName");
            cboCusType.DisplayMember = "CustomerTypeName";

            sql = "Select CustomerName from Customers Order By CustomerName";
            objUtility.AddComboValues(cboCustomer, sql, "CustomerName");
            cboCustomer.DisplayMember = "CustomerName";

            sql = "Select Vehicletype from m_VehicleType Order By VehicleType";
            objUtility.AddComboValues(cboVehicleType, sql, "VehicleType");
            cboVehicleType.DisplayMember = "VehicleType";

            sql = "Select m_TypeName from m_MaintenanceType Order By m_TypeName";
            objUtility.AddComboValues(cboServiceType, sql, "m_TypeName");
            cboServiceType.DisplayMember = "m_TypeName";

            sql = "Select lCostType from m_LaborCostType Order By lCostType";
            objUtility.AddComboValues(cboLaborWorkType, sql, "lCostType");
            cboLaborWorkType.DisplayMember = "lCostType";




            cboCustomer.Text = "All";
            cboCusType.Text = "All";
            cboVehicleType.Text = "All";
            cboServiceType.Text = "All";
            cboLaborWorkType.Text = "All";

        }

        private void setAdapterConnectionString()
        {
            this.rpt_Mechanic_LabourTableAdapter.Connection = clsData.connBel;
            this.m_MechanicListTableAdapter.Connection = clsData.connBel;
        

        }

        private void cboCusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL = "SELECT dbo.Customers.CustomerName, dbo.CustomerTypes.CustomerTypeId  FROM  dbo.Customers INNER JOIN dbo.CustomerTypes ON dbo.Customers.CustomerTypeId = dbo.CustomerTypes.CustomerTypeId ";

            if (cboCusType.Text != "All") strSQL += "  Where CustomerTypeName = '" + cboCusType.Text + "'";

            strSQL += " Order by CustomerName";

            objUtility.AddComboValues(cboCustomer, strSQL, "CustomerName");
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.Text = "All";
        }

        private void optNone_Click(object sender, EventArgs e)
        {
            grpOption = 0; //none
        }

        private void optCusType_Click(object sender, EventArgs e)
        {
            grpOption = 1;//cus type
        }

        private void optVType_Click(object sender, EventArgs e)
        {
            grpOption = 2;// vehicle type
        }

        private void optSType_CheckedChanged(object sender, EventArgs e)
        {
            grpOption = 3;// Service Type
        }

       
        private void rdDelivered_Click(object sender, EventArgs e)
        {
           //  strDeliveryStatus = " And isOut =1";
        }

        private void rdnonDelivered_Click(object sender, EventArgs e)
        {
             strDeliveryStatus = " And isOut =0";
             strInOrOutDate = "m_ReceivedDate";
        }

        private void rdBothDeliverdandNonDelivered_CheckedChanged(object sender, EventArgs e)
        {
             strDeliveryStatus = "";
        }

        
        private void lnkAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectItems(true);
        }

        private void lnkNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectItems(false);
        }

        private void selectItems(bool tf)
        {
            if (lstMechanicList.Items.Count > 0)
                for (int i = 0; i < lstMechanicList.Items.Count - 1; i++)
                    lstMechanicList.SetSelected(i, tf);

        }

        private void tbMaintenanceReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbMaintenanceReports.SelectedIndex == 0)
            {
                chkDetails.Visible = false;
                chkLaborDetails.Visible = true;
            }
            else
            {   chkDetails.Visible = true;
            chkLaborDetails.Visible = false;
            }
            
        }

        private void optVType_CheckedChanged(object sender, EventArgs e)
        {
            grpOption = 2;
        }

        private void optNone_CheckedChanged(object sender, EventArgs e)
        {
            grpOption = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strSQL = "Select * from m_Replaced_Parts_List_Per_WO Where m_Date Between '" + dtFrom.Value.ToShortDateString() + 
                "' And '" + dtTo.Value.ToShortDateString() + "' ";
            frmReportsViewer frmv = new frmReportsViewer();

            rptMaintainance_Replaced_Parts_List rptRPL = new rptMaintainance_Replaced_Parts_List();
            frmv.SetReport(rptRPL, strSQL, "m_Replaced_Parts_List_Per_WO");

            Program.mainFrm.OpenFrm(frmv);
        }

        private void opLaborDetails_CheckedChanged(object sender, EventArgs e)
        {
            grpLaborDetailsOption = 0;
        }

        private void optLaborNoDetails_CheckedChanged(object sender, EventArgs e)
        {
            grpLaborDetailsOption = 1;

        }

        private void optLaborBoth_CheckedChanged(object sender, EventArgs e)
        {
            grpLaborDetailsOption = 2;
        }

        private void cboLaborWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
             laborworktype = cboLaborWorkType.Text;

        }
        
    }
}