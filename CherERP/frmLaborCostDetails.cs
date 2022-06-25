using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmLaborCostDetails : Form
    {
        DateTime dt;
        string _WON = "", _MechId = "";
        clsData objData = new clsData();
        bool SessionSaved = true;

        public frmLaborCostDetails()
        {
            InitializeComponent();
        }

        public frmLaborCostDetails(string Won, string MechID)
        {
            InitializeComponent();
            _MechId = MechID;
            _WON = Won;
        }

        private void m_LaborCostDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_LaborCostDetailsBindingSource.EndEdit();
            this.m_LaborCostDetailsTableAdapter.Update(this.belayAbVMaintain.m_LaborCostDetails);

        }

        private void m_LaborCostDetailsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.m_LaborCostDetailsBindingSource.EndEdit();
            this.m_LaborCostDetailsTableAdapter.Update(this.belayAbVMaintain.m_LaborCostDetails);

        }

        private void frmLaborCostDetails_Load(object sender, EventArgs e)
        {

            try
            {
                timer1.Start();

                setAdapterConnectionString();


                this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);


                if (_MechId != "")
                {
                    this.m_Labor_MainInfoTableAdapter.FillByMechId(this.belayAbVMaintain.m_Labor_MainInfo, _MechId);
                    if (_WON != "")
                        this.m_Labor_MainInfoTableAdapter.FillByWON_Mech(this.belayAbVMaintain.m_Labor_MainInfo, _WON, _MechId);
                }
                else
                {
                    this.m_Labor_MainInfoTableAdapter.Fill(this.belayAbVMaintain.m_Labor_MainInfo);

                }

                FillLaborCostDetails(txtLbCostID.Text);
                CalculateTotalHours();
            }
            catch (Exception ex) { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblCurrentTime.Text = dt.ToString(); //string.Format("{0: MMM dd, yyyy hh:mm:ss tt}", dt);


        }

        private void setAdapterConnectionString()
        {

            this.m_LaborCostDetailsTableAdapter.Connection = clsData.connBel;
            this.m_LaborCostTableAdapter.Connection = clsData.connBel;
            this.m_Labor_MainInfoTableAdapter.Connection = clsData.connBel;
            this.m_MechanicListTableAdapter.Connection = clsData.connBel;
        }

        private void btnSessionStart_Click(object sender, EventArgs e)
        {

          DialogResult ret = MessageBox.Show("New Session Will Start!, Are you sure?", "Session Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                m_LaborCostDetailsBindingSource.AddNew();
                SessionSaved = false;

                sesionStartDateTimePicker.Value = dt;
                statusTextBox.Text = "ON";
                MessageBox.Show("Session Started!", "Session Start", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSessionEnd.Enabled = true;
                btnSessionSuspend.Enabled = true;
                btnSessionStart.Enabled = false;
            }


         

        }

        private void btnSessionEnd_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Current Session Will End!, Are you sure?", "Session Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                sessionEndDateTimePicker.Value = dt;
                statusTextBox.Text = "OFF";
                MessageBox.Show("Session Ended!", "Session End", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            InsertSession();
            SessionSaved = true;

            btnSessionEnd.Enabled = false;
            btnSessionSuspend.Enabled = false;
            btnSessionStart.Enabled = true;

        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            btnSessionEnd_Click(null, null);

            btnSessionEnd.Enabled = false;
            btnSessionSuspend.Enabled = false;
            btnSessionStart.Enabled = false;


        }

        private void frmLaborCostDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SessionSaved)
            {
                DialogResult ret = MessageBox.Show("Current Session Will End and will not be saved!, Are you sure?", "Session Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ret == DialogResult.No)
                    e.Cancel = true;
                else
                {
                    sessionEndDateTimePicker.Value = dt;
                    MessageBox.Show("Session Ended!", "Task Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void InsertSession()
        {
            int nxtSessNo = 1;

            string StrSQL = "Select Max(SessionNo) from m_LaborCostDetails Where LbCostId = '" + txtLbCostID.Text + "'";
            if (objData.exists("Select * from m_LaborCostDetails Where LbCostId = '" + txtLbCostID.Text + "'"))
            {
                nxtSessNo = int.Parse(objData.getFieldValue(StrSQL).ToString()) + 1;
            }

            lbCostIdTextBox.Text = txtLbCostID.Text;
            sessionNoTextBox.Text = nxtSessNo.ToString();

            GetHours();

            this.Validate();
            m_LaborCostDetailsBindingSource.EndEdit();
            m_LaborCostDetailsTableAdapter.Update(this.belayAbVMaintain.m_LaborCostDetails);

            CalculateTotalHours();

            //StrSQL = "Insert Into LaborCostDetails (SessionNo,Mechanic, SessionStart, SesssionEnd) " +
            //    " Values (" + nxtSessNo.ToString() + ", '" + sesionStartDateTimePicker.Value.ToString() + "','" +
            //    sessionEndDateTimePicker.Value.ToString() + "'";


        }

        private void GetHours()
        {
            DateTime dt1, dt2;
            dt1 = sesionStartDateTimePicker.Value;
            dt2 = sessionEndDateTimePicker.Value;
            TimeSpan diff = dt2.Subtract(dt1);
            double Mins = diff.TotalMinutes;
            double Hours = Mins / 60;
            durationTextBox.Text = string.Format("{0:#,##0.00}", Hours);

        }

        private void txtLbCostID_TextChanged(object sender, EventArgs e)
        {
            FillLaborCostDetails(txtLbCostID.Text);
            CalculateTotalHours();

        }

        private void FillLaborCostDetails(string LbCostId)
        {
            if (LbCostId != "")
                this.m_LaborCostDetailsTableAdapter.FillByLbCostId(this.belayAbVMaintain.m_LaborCostDetails, int.Parse(LbCostId));
            else
                this.m_LaborCostDetailsTableAdapter.Fill(this.belayAbVMaintain.m_LaborCostDetails);
        }

        private void CalculateTotalHours()
        {

            double fval, sum = 0;

            DataGridView dv = this.m_LaborCostDetailsDataGridView;

            try
            {
                for (int k = 0; k < dv.Rows.Count; k++)
                    if (double.TryParse(dv.Rows[k].Cells["Duration"].Value.ToString(), out fval))
                        sum += fval;

                txtCurrentHours.Text = string.Format("{0: #,##0.00}", sum);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void m_LaborCostDetailsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            EnableButtons(e);
        }

        private void EnableButtons(DataGridViewCellEventArgs ee)
        {
            int RIdx = ee.RowIndex;// m_LaborCostDetailsDataGridView.CurrentCell.RowIndex;

            if (m_LaborCostDetailsDataGridView.Rows[RIdx].Cells["SessionStatus"].Value.ToString() == "ON")

                btnSessionEnd.Enabled = true;
            else
                btnSessionEnd.Enabled = false;
        }

        private void btnSessionSuspend_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Current Session Will be Suspended will stay active!, Are you sure?", "Session Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                sessionEndDateTimePicker.Value = dt;
                statusTextBox.Text = "ON";
                MessageBox.Show("Session Ended!", "Session End", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            InsertSession();
            SessionSaved = true;

            btnSessionSuspend.Enabled = false;
            btnSessionEnd.Enabled = true;
            btnSessionStart.Enabled = true;

        }

        private void m_LaborCostDetailsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }

       

      
}
