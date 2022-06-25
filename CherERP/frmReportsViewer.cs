 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Belayab.Reports;


namespace Belayab
{
    public partial class frmReportsViewer : Form
    {
        public Control  report;
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();

        ReportClass curRptObject = null;

        rptItem rpt = new rptItem();
        public frmReportsViewer()
        {
            InitializeComponent();
        }


        public void SetReport( ReportClass rptObj, string strSQL, string tblName)
        {
            //ptObj.SetDataSource(null);

            if (clsData.connBel.State != ConnectionState.Open ) clsData.connBel.Open() ;
            da = new SqlDataAdapter(strSQL, clsData.connBel);
            da.Fill(ds,tblName);

            rptObj.SetDataSource(ds);

       //     MessageBox.Show("Rows: " + ds.Tables[0].Rows.Count.ToString());

            
            if (tblName == "Maintainance_Totals")
            {
                
                curRptObject = rptObj;
                splitContainer1.SplitterDistance = 50;
            }

            ReportViewer1.ReportSource = rptObj;


        }

        public void SetReport(ReportClass rptObj, string strSQL, string tblName, string subRep, string subLab, string subP, string subFL, string subOW)
        {
            //ptObj.SetDataSource(null);

            da = new SqlDataAdapter(strSQL, clsData.connBel);
            da.Fill(ds, tblName);

            rptObj.SetDataSource(ds);


            DataSet dsRep = new DataSet();

            da.SelectCommand.CommandText = subRep;
            da.Fill(dsRep, "rpt_Replaced");
            rptObj.Subreports["rptReplaced"].SetDataSource(dsRep);
           

            DataSet dsLab = new DataSet();
            da.SelectCommand.CommandText = subLab;
            da.Fill(dsLab, "m_LaborCost");
            rptObj.Subreports["rptLaborCost"].SetDataSource(dsLab);


            DataSet dsFL = new DataSet();
            da.SelectCommand.CommandText = subFL;
            da.Fill(dsFL, "rpt_FuelLubricants");
          rptObj.Subreports["rptFuelLubricants"].SetDataSource(dsFL);
            //rptObj.Subreports[2].SetDataSource(dsFL);


            //DataSet dsP = new DataSet();
            //da.SelectCommand.CommandText = subP;
            //da.Fill(dsP, "m_PartsToRepair");
            //  rptObj.Subreports["rptPartsTobeRepaired"].SetDataSource(dsP);
            ////rptObj.Subreports[3].SetDataSource(dsP);


          DataSet dsOW = new DataSet();
          da.SelectCommand.CommandText = subOW;
          da.Fill(dsOW, "m_OutSideWork");
          ;
          rptObj.Subreports["rptOutsideWork.rpt"].SetDataSource(dsOW);
          //rptObj.Subreports[3].SetDataSource(dsP);


            //MessageBox.Show(dsP.Tables[0].Rows.Count.ToString());
            //MessageBox.Show(rptObj.Subreports["rptPartsTobeRepaired"].Name);
         
            ReportViewer1.ReportSource = rptObj;


        }

        public void SetReport(ReportClass rptObj, string strSQL, string tblName, string subRep, string subLab, string subP, string subFL, string subOW, string subCO)
        {
            //ptObj.SetDataSource(null);

            da = new SqlDataAdapter(strSQL, clsData.connBel);
            da.Fill(ds, tblName);

            rptObj.SetDataSource(ds);

            //for (int i = 0; i < rptObj.Subreports.Count; i++)
            //    MessageBox.Show(rptObj.Subreports[i].Name);

            DataSet dsRep = new DataSet();

            da.SelectCommand.CommandText = subRep;
            da.Fill(dsRep, "rpt_Replaced");
            rptObj.Subreports["rptReplaced.rpt"].SetDataSource(dsRep);

            
            DataSet dsLab = new DataSet();
            da.SelectCommand.CommandText = subLab;
            da.Fill(dsLab, "m_LaborCost");
            rptObj.Subreports["rptLaborCost"].SetDataSource(dsLab);


            DataSet dsFL = new DataSet();
            da.SelectCommand.CommandText = subFL;
            da.Fill(dsFL, "rpt_FuelLubricants");
            rptObj.Subreports["rptFuelLubricants.rpt"].SetDataSource(dsFL);
            //rptObj.Subreports[2].SetDataSource(dsFL);


            //DataSet dsP = new DataSet();
            //da.SelectCommand.CommandText = subP;
            //da.Fill(dsP, "m_PartsToRepair");
            //  rptObj.Subreports["rptPartsTobeRepaired"].SetDataSource(dsP);
            ////rptObj.Subreports[3].SetDataSource(dsP);


            DataSet dsOW = new DataSet();
            da.SelectCommand.CommandText = subOW;
            da.Fill(dsOW, "m_OutSideWork");
            rptObj.Subreports["rptOutsideWork.rpt"].SetDataSource(dsOW);

           
            DataSet dsCO = new DataSet();
            da.SelectCommand.CommandText = subCO;
            da.Fill(dsCO, "m_Consumables");
            rptObj.Subreports["rptConsumables.rpt"].SetDataSource(dsCO);

            //rptObj.Subreports[3].SetDataSource(dsP);


            //MessageBox.Show(dsP.Tables[0].Rows.Count.ToString());
            //MessageBox.Show(rptObj.Subreports["rptPartsTobeRepaired"].Name);

            ReportViewer1.ReportSource = rptObj;


        }



        public void SetReport(ReportClass rptObj,DataSet dSet)
        {
           

            rptObj.SetDataSource(dSet);

            ReportViewer1.ReportSource = rptObj;
            

        }

        private void frmReportsViewer_Load(object sender, EventArgs e)
        {
            //setAdapterConnectionString();


            //// TODO: This line of code loads data into the 'belayAbVMaintain.rpt_Mechanic_Labour' table. You can move, or remove it, as needed.
            //this.rpt_Mechanic_LabourTableAdapter.Fill(this.belayAbVMaintain.rpt_Mechanic_Labour);
            //// TODO: This line of code loads data into the 'belayAbVMaintain.m_MechanicList' table. You can move, or remove it, as needed.
            //this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);
            //dtFrom.Value = Convert.ToDateTime("01/" + "01/" + string.Format("{0:yyyy}", DateTime.Today).ToString());

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

            cboCustomer.Text = "All";
            cboCusType.Text = "All";
            cboVehicleType.Text = "All";
            cboServiceType.Text = "All";
        }

        private void applyFilterSelection()
        {
            if (curRptObject != null)
            {
                //createFormula();
           //     curRptObject.RecordSelectionFormula = "{Maintainance_Totals.CustomerName} = '" + cboCustomer.Text + "'";
                curRptObject.RecordSelectionFormula = createFormula();
                curRptObject.DataDefinition.FormulaFields["filterValue"].Text = createFormula();

                ReportViewer1.ReportSource = null;
                
                ReportViewer1.ReportSource  = curRptObject;
            }

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            applyFilterSelection(); ;
        }



        private string createFormula()
        {
            string formula = "";

            if (cboCusType.Text != "All")
                formula = "{Maintainance_Totals.CustomerTypeName} ='" + cboCusType.Text + "'";
            else
                formula =  "";

            if (cboCustomer.Text != "All")
                if (formula != "") formula += " And {Maintainance_Totals.CustomerName} ='" + cboCustomer.Text + "'";
                else formula =  "{Maintainance_Totals.CustomerName} ='" + cboCustomer.Text + "'";
            else
                if (formula != "") formula += " And {Maintainance_Totals.CustomerName} <>''";
                else formula += "";
   
            if (cboVehicleType.Text !="All")
                if (formula != "") formula += " And {Maintainance_Totals.VehicleType} ='" + cboVehicleType.Text + "'";
                else formula = "{Maintainance_Totals.VehicleType} ='" + cboVehicleType.Text + "'";
            else
                if (formula != "") formula += " And {Maintainance_Totals.VehicleType} <>''";
                else formula = "";

            if (cboServiceType.Text != "All")
                if (formula != "") formula += " And {Maintainance_Totals.m_TypeName} ='" + cboServiceType.Text + "'";
                else formula += "{Maintainance_Totals.m_TypeName} ='" + cboServiceType.Text + "'";
            //else
            //    if (formula != "") formula += " And {Maintainance_Totals.m_TypeName} <>''";
            //    else formula = "";



            return formula;
        }

    }

   
}