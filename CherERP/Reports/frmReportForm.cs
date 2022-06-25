using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;

namespace Belayab.Reports
{
    public partial class frmReportForm : Form
    {
        int repType, grpType, durType;
        string strSQL = "", tblName = "";
        string strCriteria ="0";

        clsUtility objUtility = new clsUtility();

        frmReportsViewer frmv = new frmReportsViewer();

        Object repObject;
        
        public frmReportForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int idx = tabPeriodicReport.SelectedIndex;

            frmv = new frmReportsViewer();
            if (idx == 1) //Received sold issued
            {
                if (optReceived.Checked)
                {
                    strSQL = "Select * from rev_ReceivedHistory Where ReceivedDate Between '" +
                       dtFrom.Value.ToShortDateString() + " 0:00:00' And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

                    frmv.SetReport(new rptReceivedListing(), strSQL, "rpt_Received_List");
                }

                else if (optSales.Checked)
                {

                    strSQL = "Select * from rpt_invoice_Items_List Where InvoiceDate Between '" +
                        dtFrom.Value.ToShortDateString() + " 00:00:00 And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

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

                    tblName = "rpt_invoice_Items_List";
                    finish_InvoiceListing();

                    //    frmv.SetReport(rpt, strSQL, "rpt_Invoice_List");
                }
                else if (optIssued.Checked)
                {
                    strSQL = "Select * from rpt_Issued_Items_Periodic Where IssueDate Between '" +
                    dtFrom.Value.ToShortDateString() + " 00:00:00 And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

                    frmv.SetReport(new rptIssuedListing(), strSQL, "rpt_Issued_List");

                }
               else if (optTransfered.Checked)
                {
                    strSQL = "Select * from rev_TransferHistory Where ItemTransferDate Between '" +
                    dtFrom.Value.ToShortDateString() + " 00:00:00 And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

                    frmv.SetReport(new rptPeriodicTransfer_Monthly(), strSQL, "rev_TransferHistory");
                }

            } 
            else
            {
                switch (repType)
                {
                    case 1:
                        //switch (grpType)
                        //{
                        //    case 1: //Item

                        strSQL = "Select * from rpt_invoice_Items_List where InvoiceDate Between '" +
                            dtFrom.Value.ToShortDateString() + " 00:00:00' And '" + dtTo.Value.ToShortDateString() + " 23:59:59'"; 
                        
                            tblName = "rpt_invoice_Items_List";
                                finishSQL_SoldItem();

                               // break;

                            //case 2: //Category
                            //    strSQL = "Select * from rpt_ItemsSold Where InvoiceDate Between '" +
                            //          dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "'";
                            //    tblName = "rpt_ItemsSold";
                            //    finishSQL_SoldCat();
                            //    break;
                        //}
                       break;
                    case 2:
                        
                            strSQL = "Select * from rpt_Issued_Items_Periodic Where IssueDate Between '" +
                         dtFrom.Value.ToShortDateString() + " 00:00:00' And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

                        tblName = "rpt_Issued_Items_Periodic";
                        finish_IssuedItem();



                        break;
                    case 3:
                        //switch (grpType)
                        //{
                        //    case 1: //Item

                                strSQL = "Select * from rev_ReceivedHistory Where ReceivedDate Between '" +
                                 dtFrom.Value.ToShortDateString() + " 00:00:00 And '" + dtTo.Value.ToShortDateString() + " 23:59:59'";

                               tblName = "rev_ReceivedHistory";

                                finishSQL_ReceivedItem();

                                //break;

                        //    case 2: //Category
                        //        strSQL = "Select * from rev_ReceivedHistory Where ReceivedDate Between '" +
                        //         dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "'";
                        //        tblName = "rev_ReceivedHistory";
                        //        finishSQL_ReceivedItemCat();
                        //        break;
                        //}
                        break;

                    case 4:
                        //switch (grpType)
                        //{
                        //    case 1: //Item

                        strSQL = "Select * from rev_TransferHistory Where ItemTransferDate Between '" +
                            dtFrom.Value.ToShortDateString() + " 0:00:00' And '" + dtTo.Value.ToShortDateString() + " 23:59:59' and StoreID ='" + clsVariables.sStore + "'";
                        tblName = "rev_TransferHistory";

                        finishSQL_TranItem();

                        //break;

                        //    case 2: //Category
                        //        strSQL = "Select * from rev_ReceivedHistory Where ReceivedDate Between '" +
                        //         dtFrom.Value.ToShortDateString() + "' And '" + dtTo.Value.ToShortDateString() + "'";
                        //        tblName = "rev_ReceivedHistory";
                        //        finishSQL_ReceivedItemCat();
                        //        break;
                        //}

                        break;
                }

            }

            Program.mainFrm.OpenFrm(frmv);
             this.Hide();
        }

        private void optReceived_CheckedChanged(object sender, EventArgs e)
        {
            repType = 3; //Received
        }

        private void frmReportForm_Load(object sender, EventArgs e)
        {
                repType = 1;
                grpType = 1;
                durType = 1;
                radioButton3.Checked = true;
                dtFrom.Value = DateTime.Today;

               // MessageBox.Show("01/" + "01/" + string.Format("{0:yyyy}", DateTime.Today).ToString());
               //  
               //  dtFrom.Value = Convert.ToDateTime("01/" + "01/" + string.Format("{0:yyyy}",DateTime.Today).ToString() );
               //
                string sql = "Select VehicleType from m_VehicleType Order by VehicleType";
                objUtility.AddComboValues(cboVehicleTypes , sql);
                cboVehicleTypes.DisplayMember = "VehicleType";

                cboVehicleTypes.Text = "All";
                cboItemServiceType.Text = "All";

                sql = "Select CustomerTypeName from CustomerTypes";
                objUtility.AddComboValues(cboCusType, sql,"CustomerTypeName");
                cboCusType.DisplayMember = "CustomerTypeName";

                sql = "Select CustomerName from Customers Order By CustomerName";
                objUtility.AddComboValues(cboCustomer, sql, "CustomerName");
                cboCustomer.DisplayMember = "CustomerName";

                cboCustomer.Text = "All";
                cboCusType.Text = "All";

        }

        private void optSales_CheckedChanged(object sender, EventArgs e)
        {
            if (!optSales.Checked) return;
            repType = 1; //Sold
        }

        private void optIssued_CheckedChanged(object sender, EventArgs e)
        {
            if (!optIssued.Checked) return;
            repType = 2; //Issued
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton9.Checked) return;
            grpType = 1; //Item
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton8.Checked) return;
            grpType = 2; // Category
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton3.Checked) return;
            durType = 1; //Daily
            dtFrom.Value = DateTime.Today;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton4.Checked) return;
            durType = 2; //Weekly
     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;
            durType = 3; //Monthly
            string mmm = string.Format("{0:MM}", DateTime.Today).ToString();
            string dd =    mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString();
            dtFrom.Value = Convert.ToDateTime(mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString());

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked) return;
            durType = 4; //Quarterly
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton6.Checked) return;
            durType = 5; //Yearly
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton5.Checked) return;
            durType = 6; //Semi-anually
        }

        private void finishSQL_SoldItem()
        {
            filterVehicleType();

            switch (durType)
            {

                case 1:
                   // frmv.SetReport(new rptPeriodicSalesQ_Details_Daily(), strSQL, tblName);
                    frmv.SetReport(new rpt_invoice_Items_Listing(), strSQL, tblName);
                    break;
                case 2:
                  //  frmv.SetReport(new rptPeriodicSalesQ_Details_Weekly(), strSQL, tblName);
                    frmv.SetReport(new rpt_invoice_Items_ListingM(), strSQL, tblName);
                    break;
                case 3:
                    //frmv.SetReport(new rptPeriodicSalesQ_Details_Monthly(), strSQL, tblName);
                    frmv.SetReport(new rpt_invoice_Items_ListingM(), strSQL, tblName);
                    break;
                case 4:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Quarterly(), strSQL, tblName);
                    break;
                case 5:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Yearly(), strSQL, tblName);
                    break;
                case 6:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Semi_Anually(), strSQL, tblName);
                    break;
            }
        }

        private void finish_IssuedItem()
        {
            filterVehicleType();

            switch (durType)
            {

                case 1:
                    // frmv.SetReport(new rptPeriodicSalesQ_Details_Daily(), strSQL, tblName);
                    frmv.SetReport(new rptIssuedListing_Daily(), strSQL, tblName);
                    break;
                case 2:
                    //  frmv.SetReport(new rptPeriodicSalesQ_Details_Weekly(), strSQL, tblName);
                    frmv.SetReport(new rptIssuedListing(), strSQL, tblName);
                    break;
                case 3:
                    frmv.SetReport(new rptIssuedListingM(), strSQL, tblName);
                    break;
                case 4:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Quarterly(), strSQL, tblName);
                    break;
                case 5:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Yearly(), strSQL, tblName);
                    break;
                case 6:
                    frmv.SetReport(new rptPeriodicSalesQ_Details_Semi_Anually(), strSQL, tblName);
                    break;
            }
        }

        private void finish_InvoiceListing()
        {
            //filterVehicleType();

            CrystalDecisions.CrystalReports.Engine.ReportClass rpt =null;

            switch (durType)
            {
                case 1: //day
                  //  rpt = new rptInvoiceListing_Daily();
                    rpt = new rpt_invoice_Items_Listing();
                    frmv.SetReport(rpt , strSQL, tblName);
                    break;
                case 2://wk
                    rpt = new rpt_invoice_Items_ListingM();
                    frmv.SetReport(rpt, strSQL, tblName);
                    break;
                case 3://month
                    rpt = new rptInvoiceListing();
                    frmv.SetReport(rpt, strSQL, tblName);
                 
                    break;
                case 4://qurter
                    rpt = new rptInvoiceListing_Quarterly();
                    frmv.SetReport(rpt, strSQL, tblName);
                    break;
                case 5://yr
                    rpt = new rptInvoiceListing_Yearly();
                    frmv.SetReport(rpt, strSQL, tblName);
                    break;
                case 6://semi-anual
                    rpt = new rptInvoiceListing_Semi_Anually();
                    frmv.SetReport(rpt, strSQL, tblName);
                    break;
            }

            rpt.DataDefinition.FormulaFields["filtered"].Text = strCriteria;

        }
            private void finishSQL_SoldCat()
          {
              filterVehicleType();

            switch(durType )
            {
                case 2:
                 frmv.SetReport(new rptPeriodicSalesQ_Details_Weekly(), strSQL, tblName );
                  break;
                case 3:
                 frmv.SetReport(new rptPeriodicSalesQ_Details_Monthly (), strSQL, tblName );
                    break;
                case 4:
                  frmv.SetReport(new rptPeriodicSalesQ_Details_Quarterly(), strSQL, tblName );
                   break;
                case 5:
                  frmv.SetReport(new rptPeriodicSalesQ_Details_ByCat_Yearly(), strSQL, tblName );
                 break;
            }

                
    }

        private void finishSQL_ReceivedItem()
        {
            
            filterVehicleType();

            switch (durType)
            {
                case 1:
                    frmv.SetReport(new rptPeriodicReceived_Daily(), strSQL, tblName);
                    break;
                case 2:
                    frmv.SetReport(new rptPeriodicReceived_Weekly(), strSQL, tblName);
                    break;
                case 3:
                    frmv.SetReport(new rptPeriodicReceived_Monthly(), strSQL, tblName);
                    break;
                case 4:
                 //   frmv.SetReport(new rptPeriodicReceived_Quarterly(), strSQL, tblName);
                    break;
                case 5:
                    frmv.SetReport(new rptPeriodicReceived_Yearly(), strSQL, tblName);
                    break;
                case 6:
               //     frmv.SetReport(new rptPeriodicReceived_Semi_Anually(), strSQL, tblName);
                    break;

            }

           
        }

        private void finishSQL_TranItem()
        {

            filterVehicleType();

            switch (durType)
            {
                case 1:
                      frmv.SetReport(new rptPeriodicTransfer_Daily(), strSQL, tblName);
                    break;
                case 2:
                    //frmv.SetReport(new rptPeriodicReceived_Weekly(), strSQL, tblName);
                    break;
                case 3:
                    frmv.SetReport(new rptPeriodicTransfer_Monthly(), strSQL, tblName);
                    break;
                case 4:
                    //   frmv.SetReport(new rptPeriodicReceived_Quarterly(), strSQL, tblName);
                    break;
                case 5:
                   // frmv.SetReport(new rptPeriodicReceived_Yearly(), strSQL, tblName);
                    break;
                case 6:
                    //  frmv.SetReport(new rptPeriodicReceived_Semi_Anually(), strSQL, tblName);
                    break;

            }


        }

        private void finishSQL_ReceivedItemCat()
        {
            filterVehicleType();
            frmv.SetReport(new rptPeriodicReceived_Cat_Monthly(), strSQL, tblName);

        }

        private void optTransfered_CheckedChanged(object sender, EventArgs e)
        {
            if (!optTransfered.Checked) return;
            repType = 4; //Issued
        }

        private void filterVehicleType()
        {
            if (cboVehicleTypes.Text !="All")
                strSQL += " and VehicleType = '" + cboVehicleTypes.Text + "'";

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

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
        
        
        
    }
}