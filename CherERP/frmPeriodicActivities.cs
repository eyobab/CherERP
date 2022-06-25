using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmPeriodicActivities : Form
    {

        string strSQL = "";
        string strWhere = "";
        clsData objData = new clsData();
        decimal amount;

        const string woCount = "Work Orders:";
        const string issueCount = "Issues:";
        const string reqCount = "Requisitions:";
        const string rcCount = "Receivied:";
        const string invCount = "Sales:";
        const string trFCount = "Transfers From:";
        const string trToCount = "Transfers To:";


        public frmPeriodicActivities()
        {
            InitializeComponent();
        }

        private void frmPeriodicActivities_Load(object sender, EventArgs e)
        {
            refreshGridData();
        }

        private void refreshGridData()
        {

            grdSammary.Rows.Clear();

            strSQL = "Select Count(WorkOrderNumber) As WoCount From m_maintenance";
            getWhereCriteria("m_ReceivedDate");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(woCount, amount);


            strSQL = "Select Count(ReceivedNumber) As WoCount From ItemsReceived";
            getWhereCriteria("ReceivedDate");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(rcCount, amount);

            strSQL = "Select Count(RequisitionNumber) As WoCount From  ItemRequisition";
            getWhereCriteria("RequistionDate");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(reqCount, amount);

            strSQL = "Select Count(IssueNo) As WoCount From ItemsIssued";
            getWhereCriteria("IssueDate");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(issueCount, amount);

            strSQL = "Select Count(InvoiceNo) As WoCount From Invoices";
            getWhereCriteria("InvoiceDate");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(invCount, amount);

            strSQL = "Select Count(StoreTransferNo) As WoCount From StoreTransfer";
            getWhereCriteriaTransfer("ItemTransferDate", " FromStore" );
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(trFCount, amount);

            strSQL = "Select Count(StoreTransferNo) As WoCount From StoreTransfer";
            getWhereCriteriaTransfer("ItemTransferDate", " ToStore");
            amount = objData.getFieldAmt(strSQL);
            addtoGrid(trToCount, amount);

        }
        private void getWhereCriteria(string colName)
        {
            
            strWhere = " Where StoreID='" + clsVariables.sStore + "' ";

            DateTime dt = DateTime.Today;

            string mmm = string.Format("{0:MM}", DateTime.Today).ToString();
            string dd = mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString();
            DateTime fistDayofMonth = Convert.ToDateTime(mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString());


            switch (cboOptions.Text)
            {
                case "Today":
                    strWhere += " And " + colName + " Between '" + DateTime.Today.ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
               case "This Week":
                    strWhere += " And " + colName + " Between '" + dt.AddDays(getDaysFromMonday(dt)).ToShortDateString()  + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "Past Two Weeks":
                    strWhere += " And " + colName + " Between '" + dt.AddDays(getDaysFromMonday(dt)-7).ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "This Month":
                    strWhere += " And " + colName + " Between '" + fistDayofMonth.ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "Other...":
                    strWhere += " And " + colName + " Between '" + dtFrom.Value.ToShortDateString() + " 0:00'  and '" + dtTo.Value.ToShortDateString() + " 23:59'";
                    break;
                default:
                    strWhere = "";
                    break;
            }

            strSQL = strSQL + strWhere;

        }


        private void getWhereCriteriaTransfer(string colName, string fromTo)
        {


            strWhere = " Where " + fromTo + "='"  + clsVariables.sStore + "' ";

            DateTime dt = DateTime.Today;

            string mmm = string.Format("{0:MM}", DateTime.Today).ToString();
            string dd = mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString();
            DateTime fistDayofMonth = Convert.ToDateTime(mmm + "/01/" + string.Format("{0:yyyy}", DateTime.Today).ToString());


            switch (cboOptions.Text)
            {
                case "Today":
                    dtFrom.Value = DateTime.Today;
                    dtTo.Value = DateTime.Today;
                    strWhere += " And " + colName + " Between '" + DateTime.Today.ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                   break;
               case "This Week":
                    dtFrom.Value = dt.AddDays(getDaysFromMonday(dt));
                    dtTo.Value = DateTime.Today;
                    strWhere += " And " + colName + " Between '" + dt.AddDays(getDaysFromMonday(dt)).ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "Past Two Weeks":
                    dtFrom.Value = dt.AddDays(getDaysFromMonday(dt) - 7);
                    dtTo.Value = DateTime.Today;
                    strWhere += " And " + colName + " Between '" + dt.AddDays(getDaysFromMonday(dt) - 7).ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "This Month":
                    dtFrom.Value = fistDayofMonth;
                    dtTo.Value = DateTime.Today;
                    strWhere += " And " + colName + " Between '" + fistDayofMonth.ToShortDateString() + " 0:00'  and '" + DateTime.Today.ToShortDateString() + " 23:59'";
                    break;
                case "Other...":
                    strWhere += " And " + colName + " Between '" + dtFrom.Value.ToShortDateString() + " 0:00'  and '" + dtTo.Value.ToShortDateString() + " 23:59'"; 
                    break;
                default:
                    strWhere = "";
                    break;
            }

            strSQL = strSQL + strWhere;

        }

        private int getDaysFromMonday(DateTime dt)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday: return 0;
                case DayOfWeek.Tuesday: return -1; 
                case DayOfWeek.Wednesday: return -2; 
                case DayOfWeek.Thursday: return -3; 
                case DayOfWeek.Friday: return -4; 
                case DayOfWeek.Saturday: return -5; 
                case DayOfWeek.Sunday: return -6;
                default: return -7;    
            }
        }

        private void addtoGrid(String title, decimal amt)
        {
            grdSammary.Rows.Add();

            grdSammary.Rows[grdSammary.Rows.Count-1].Cells["summaryItem"].Value = title;
            grdSammary.Rows[grdSammary.Rows.Count-1].Cells["summaryValue"].Value = amt;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            refreshGridData();
        }
      
      }
}
