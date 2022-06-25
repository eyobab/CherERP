using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Tools
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            LocationComboBox.SelectedIndex = 0;

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            clsVariables.sServer = LocationComboBox.Text.Trim();
            clsVariables.sStore = clsData.Location(clsVariables.sServer);
            clsData.CreateAdminConnection();
            MessageBox.Show("Connection Ok!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
