using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmNumberSettings : Form
    {

        DataSet dsCa = new DataSet();
        DataSet dsCr = new DataSet();
        //SqlDataAdapter daCa, daCr;

        clsData  objData = clsData.Instance;

        clsNumbers  objNumbers = new clsNumbers();

        public frmNumberSettings()
        {
            InitializeComponent();
        }

        private void frmNumberSettings_Load(object sender, EventArgs e)
        {
            try
            {


                objNumbers.getNumberRange("Cash");

                txtCaStart.Text = objNumbers.firstNo.ToString();
                txtCaEnd.Text = objNumbers.lastNo.ToString();
               // txtCaCurrent.Text = objData.getStringValue("Select Top 1 (InvoiceNo) From Invoices Order by InvoiceDate DESC").ToString();
                txtCaCurrent.Text = objData.getStringValue("Select Max(InvoiceNo) From Invoices ").ToString();
                txtCaLength.Text = objNumbers.length.ToString();
 
                
                objNumbers.getNumberRange("Credit");

                txtCrStart.Text = objNumbers.firstNo.ToString();
                txtCrEnd.Text = objNumbers.lastNo.ToString();
                txtCrCurrent.Text = objData.getStringValue("Select Max(InvoiceNo) From Invoices_Credit").ToString();
                txtCrLength.Text = objNumbers.length.ToString();


                objNumbers.getNumberRange("GRN");

                txtGrStart.Text = objNumbers.firstNo.ToString();
                txtGrEnd.Text = objNumbers.lastNo.ToString();
                txtGrCurrent.Text = objData.getStringValue("Select Max(ReceivedNumber) From ItemsReceived").ToString();
                txtGrLength.Text = objNumbers.length.ToString();
                
                
                objNumbers.getNumberRange("SIV");

                txtSiStart.Text = objNumbers.firstNo.ToString();
                txtSiEnd.Text = objNumbers.lastNo.ToString();
                txtSiCurrent.Text = objData.getStringValue("Select Max(IssueNo) From ItemsIssued").ToString();
                txtSiLength.Text = objNumbers.length.ToString();

                

                objNumbers.getNumberRange("Req");

                txtRqStart.Text = objNumbers.firstNo.ToString();
                txtRqEnd.Text = objNumbers.lastNo.ToString();
                txtRqCurrent.Text = objData.getStringValue("Select Max(RequisitionNumber) From ItemRequisition").ToString();
                txtRqLength.Text = objNumbers.length.ToString();

                //daCa= new SqlDataAdapter("Select numType, FirstNo, LastNo, Length from InvoiceNumberRanges where numtype = 'Cash' ",clsData.connBel);
                //daCa.Fill(dsCa,"Numbers");

                //daCr = new SqlDataAdapter("Select numtype, FirstNo, LastNo, Length from InvoiceNumberRanges where numtype = 'Credit' ",clsData.connBel);
                //daCr.Fill(dsCr,"Numbers");




            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            
            if(tabNoSetting.SelectedTab.Name =="CashI")
            {
                if (int.Parse(txtCaStart.Text) >= int.Parse(txtCaEnd.Text))
                    MessageBox.Show("Starting Number must be less than ending Number");
                
                else if (int.Parse(txtCaLength.Text) < txtCaStart.Text.Length)
                        MessageBox.Show("Length can not be less than " + txtCaStart.Text.Length.ToString());

                else if (objData.getStringValue("Select InvoiceNo From Invoices Where InvoiceNo In ('" + objNumbers.formatNumber(txtCaStart.Text,"Cash") + "', '" + objNumbers.formatNumber(txtCaEnd.Text,"Cash") + "')")
                    != "")
                         MessageBox.Show("Please Specify a new range of values \n Either of the numbers have been aleady used in cash invoices!");
                
                else 
                    {
                      saveChanges(int.Parse(txtCaStart.Text),"Cash");
                    }
            }

            else if (tabNoSetting.SelectedTab.Name == "CreditI")
            {
                if (int.Parse(txtCrStart.Text) >= int.Parse(txtCrEnd.Text))
                    MessageBox.Show("Starting Number must be less than ending Number");

                else if( int.Parse(txtCrLength.Text )< txtCrStart.Text.Length)
                        MessageBox.Show("Length can not be less than " + txtCrStart.Text.Length.ToString());

                    else if (objData.getStringValue("Select InvoiceNo From Invoices_Credit Where InvoiceNo In ('" + objNumbers.formatNumber(txtCrStart.Text, "Credit") + "', '" + objNumbers.formatNumber(txtCrEnd.Text,"Credit") + "')")
                    != "")
                         MessageBox.Show("Please Specify a new range of values \n Either of the numbers have been aleady used in existing credit Invices!");

                else 
                    {
                        saveChanges(int.Parse(txtCrStart.Text),"Credit");
                    }

             }

             else if (tabNoSetting.SelectedTab.Name == "GRN")
             {
                 if (int.Parse(txtGrStart.Text) >= int.Parse(txtGrEnd.Text))
                     MessageBox.Show("Starting Number must be less than ending Number");
                else if (int.Parse(txtGrLength.Text) < txtGrStart.Text.Length)
                     MessageBox.Show("Length can not be less than " + txtGrStart.Text.Length.ToString());
                else if (objData.getStringValue("Select ReceivedNumber From ItemsReceived Where ReceivedNumber In ('" + objNumbers.formatNumber(txtGrStart.Text,"GRN") + "', '" + objNumbers.formatNumber(txtGrEnd.Text,"GRN") + "')")
                     != "")
                     MessageBox.Show("Please Specify a new range of values \n Either of the numbers have been aleady used in existing GRN numbers!");
 
                 else
                 {
                     saveChanges(int.Parse(txtGrStart.Text),"GRN");
                 }

             }

             else if (tabNoSetting.SelectedTab.Name == "SIV")
             {
                 if (int.Parse(txtSiStart.Text) >= int.Parse(txtSiEnd.Text))
                     MessageBox.Show("Starting Number must be less than ending Number");
                 else if (int.Parse(txtSiLength.Text) < txtSiStart.Text.Length)
                     MessageBox.Show("Length can not be less than " + txtSiStart.Text.Length.ToString());
                 else if (objData.getStringValue("Select IssueNo From ItemsIssued Where IssueNo In ('" + objNumbers.formatNumber(txtSiStart.Text,"SIV") + "', '" + objNumbers.formatNumber(txtSiEnd.Text,"SIV")+ "')")
                     != "")
                     MessageBox.Show("Please Specify a new range of values \n Either of the numbers have been aleady used in existing SIV numbers!");

                 else
                 {
                     saveChanges(int.Parse(txtSiStart.Text),"SIV");
                 }

             }
             else if (tabNoSetting.SelectedTab.Name == "Req")
             {
                 if (int.Parse(txtRqStart.Text) >= int.Parse(txtRqEnd.Text))
                     MessageBox.Show("Starting Number must be less than ending Number");
                 else if (int.Parse(txtRqLength.Text) < txtRqStart.Text.Length)
                     MessageBox.Show("Length can not be less than " + txtRqStart.Text.Length.ToString());
                 else if (objData.getStringValue("Select RequisitionNumber From ItemRequisition Where RequisitionNumber In ('" + objNumbers.formatNumber(txtRqStart.Text,"Req") + "', '" + objNumbers.formatNumber(txtCrEnd.Text,"Req") + "')")
                     != "")
                     MessageBox.Show("Please Specify a new range of values \n Either of the numbers have been aleady used in existing Requistion numbes!");

                 else
                 {
                     saveChanges(int.Parse(txtRqStart.Text), "Req");
                     
                 }
             }

            }

            private void saveChanges(int start,string tpy)
            {
                try
                {
                    collectValues(tpy);
                    objNumbers.UpdateNumbers();
                    objData.setStartingID(start, tpy);
                    MessageBox.Show("Successfully Saved!", "Stosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Stosa"); }
            }
            
        

        private void collectValues(string numType)
        {
            switch(numType)
            {
                case "Cash": 
                    objNumbers.NumType = "Cash";
                    objNumbers.firstNo = int.Parse(txtCaStart.Text);
                    objNumbers.lastNo= int.Parse(txtCaEnd.Text);
                    objNumbers.length = byte.Parse(txtCaLength.Text);
                    break;
                case "Credit":
                    objNumbers.NumType = "Credit";
                    objNumbers.firstNo = int.Parse(txtCrStart.Text);
                    objNumbers.lastNo= int.Parse(txtCrEnd.Text);
                    objNumbers.length = byte.Parse(txtCrLength.Text);
                    break;
                case "GRN":
                    objNumbers.NumType = "GRN";
                    objNumbers.firstNo = int.Parse(txtGrStart.Text);
                    objNumbers.lastNo = int.Parse(txtGrEnd.Text);
                    objNumbers.length = byte.Parse(txtGrLength.Text);
                    break;
                case "SIV":
                    objNumbers.NumType = "SIV";
                    objNumbers.firstNo = int.Parse(txtSiStart.Text);
                    objNumbers.lastNo = int.Parse(txtSiEnd.Text);
                    objNumbers.length = byte.Parse(txtSiLength.Text);
                    break;
                case "Req":
                    objNumbers.NumType = "Req";
                    objNumbers.firstNo = int.Parse(txtRqStart.Text);
                    objNumbers.lastNo = int.Parse(txtRqEnd.Text);
                    objNumbers.length = byte.Parse(txtRqLength.Text);
                    break;
               // case default:

            }

        }

        private void CashI_Click(object sender, EventArgs e)
        {

        }
    }
}