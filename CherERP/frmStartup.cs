using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmStartup : Form
    {
        int i = 0;

        public frmStartup()
        {
            InitializeComponent();
        }

        public frmStartup( int k)
        {
            InitializeComponent();
            i = k;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.loginFrm = new frmLoginScreen();
            Program.loginFrm.Show();
            this.Visible = false;
            timer1.Stop();
        }

        private void frmStartup_Load(object sender, EventArgs e)
        {
            if (i == 0) timer1.Start();
            else
            {
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void frmStartup_Click(object sender, EventArgs e)
        {
           if (i == 1) this.Close();
        }

        private void frmStartup_KeyDown(object sender, KeyEventArgs e)
        {
            if (i == 1) if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}