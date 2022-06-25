using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab.Reports
{
    public partial class frmMechanicReport : Form
        {

        public frmMechanicReport()
        {
            InitializeComponent();
        }

        private void frmMechanicReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbVMaintain.m_MechanicList' table. You can move, or remove it, as needed.
            this.m_MechanicListTableAdapter.Connection = clsData.connBel;
            this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);

        }

    }
}
