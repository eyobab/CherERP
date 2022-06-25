using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_maintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_maintenanceBindingSource.EndEdit();
            this.m_maintenanceTableAdapter.Update(this.belayAbVMaintain.m_maintenance);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCost_WorkDetails' table. You can move, or remove it, as needed.
            this.m_LaborCost_WorkDetailsTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost_WorkDetails);
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCost' table. You can move, or remove it, as needed.
            this.m_LaborCostTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost);
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_maintenance' table. You can move, or remove it, as needed.
            this.m_maintenanceTableAdapter.Fill(this.belayAbVMaintain.m_maintenance);

        }
    }
}
