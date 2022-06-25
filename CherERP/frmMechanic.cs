using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab;

namespace Belayab
{
    public partial class frmMechanic : Form
    {
        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();

        public frmVehicleMaintenanceProcess frm =null;

        public frmMechanic(frmVehicleMaintenanceProcess f)
        {
            InitializeComponent();
            frm = f;
        }

        public frmMechanic()
        {
            InitializeComponent();
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            setAdapterConnectionString();
            // TODO: This line of code loads data into the 'BelayAbVMaintain.m_Mechanic' table. You can move, or remove it, as needed.
            this.m_MechanicTableAdapter.Fill(this.BelayAbVMaintain.m_Mechanic);

            this.Height = 235;
         
        }

        private void m_MechanicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveMechs();
           
        }

        private void setAdapterConnectionString()
        {
            m_MechanicTableAdapter.Connection = Belayab.clsData.connBel;
        }

        private void frmMechanic_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm != null)
                frm.updateMechList();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_MechanicBindingSource.RemoveCurrent();
                    saveMechs();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void saveMechs()
        {
            this.Validate();
            this.m_MechanicBindingSource.EndEdit();
            this.m_MechanicTableAdapter.Update(this.BelayAbVMaintain.m_Mechanic);

        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            if (this.Height <= 235)
            {
                this.Height = 550;
                btnListAll.BackColor = Color.BlueViolet;
                grdMechList.Visible = true;
            }
            else
            {
                this.Height = 235;
                btnListAll.BackColor = this.BackColor;
                grdMechList.Visible = false;
            } 

        }
    }
}