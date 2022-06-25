using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmOtherServices : Form
    {
        public frmOtherServices()
        {
            InitializeComponent();
        }

        private void m_ServicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_ServicesBindingSource.EndEdit();
            this.m_ServicesTableAdapter.Update(this.belayAbSSDataSetItemsCategories.m_Services);

        }

        private void frmOtherServices_Load(object sender, EventArgs e)
        {
            m_ServicesTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbSSDataSetItemsCategories.m_Services' table. You can move, or remove it, as needed.
            this.m_ServicesTableAdapter.Fill(this.belayAbSSDataSetItemsCategories.m_Services);

        }
    }
}