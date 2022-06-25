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
    public partial class nfrmCostPriceHistory : Form
    {

        string strSQLItem, strSQLCost, strSQLPrice;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        BindingSource bsCost = new BindingSource();
        BindingSource bsPrice = new BindingSource();
        
        public nfrmCostPriceHistory()
        {
            InitializeComponent();
        }

       

        private void nfrmCostPriceHistory_Load(object sender, EventArgs e)
        {
            try
            {
                strSQLItem = "SELECT * from PartNumDescription";
                da = new SqlDataAdapter(strSQLItem, clsData.connBel);
                da.Fill(ds, "PartNumDescription");

                partNumberComboBox.DataSource = ds.Tables["PartNumDescription"];

                da.SelectCommand.CommandText = "SELECT  ItemID,  UnitPrce, ItempriceSettings.SettiningDate FROM dbo.ItemPriceSettingsDetails inner join dbo.ItemPriceSettings on ItemPriceSettings.ItemPriceID = ItemPriceSettingsDetails.ItemPriceID";
                da.Fill(ds, "PriceHistory");

                da.SelectCommand.CommandText = "SELECT ItemsReceivedDetails.ItemID, ItemsReceivedDetails.UnitCost, ItemsReceived.ReceivedDate FROM ItemsReceivedDetails INNER JOIN  ItemsReceived ON ItemsReceivedDetails.ReceivedNumber = ItemsReceived.ReceivedNumber";
                da.Fill(ds, "CostHistory");

                bsPrice.DataSource = ds;
                bsPrice.DataMember = "PriceHistory";

                bsCost.DataSource = ds;
                bsCost.DataMember = "CostHistory";

                grdPrice.DataSource = bsPrice;
                grdPrice.Columns["ItemID"].Visible = false;
                grdPrice.Columns["UnitPrce"].HeaderText = "Unit Price";
                grdPrice.Columns["SettiningDate"].HeaderText = "Date";

                grdCost.DataSource = bsCost;
                grdCost.Columns["ItemID"].Visible = false;
                grdCost.Columns["UnitCost"].HeaderText = "Unit Cost";
                grdCost.Columns["ReceivedDate"].HeaderText = "Date";

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Format = "#,##0.00";
                style.Alignment = DataGridViewContentAlignment.BottomRight;
                grdCost.Columns["UnitCost"].DefaultCellStyle = style;
                grdPrice.Columns["UnitPrce"].DefaultCellStyle = style;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Error", MessageBoxButtons.OK);
            }     
               

        }

        private void partNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bsCost.Filter = "ItemID = '" + Convert.ToString(partNumberComboBox.SelectedValue) + "'";
            bsPrice.Filter = "ItemID = '" + Convert.ToString(partNumberComboBox.SelectedValue) + "'";
        }

        private void lnkSetPrice_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSetting fm = new frmSetting();
            Program.mainFrm.OpenFrm(fm);
        }
    }
}