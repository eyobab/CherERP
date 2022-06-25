using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
  {
    public partial class frmItem_Quantities : Form
    {
        clsData objData = new clsData();
        clsUtility objUtility = new clsUtility();

        public frmItem_Quantities()
        {
            InitializeComponent();
        }

        private void Item_Quantities_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).TextChanged += c_ControlChanged;
                }
                else
                {
                    c.TextChanged += new EventHandler(c_ControlChanged);
                }
            }


            string strSQL = "Select Distinct StoreId,StoreName From Stores Order by StoreName";
            objUtility.fillComboValues(StoreComboBox, strSQL);

            StoreComboBox.DisplayMember = "StoreName";
            StoreComboBox.ValueMember = "StoreId";

           this.StoreComboBox.SelectedValue = clsVariables.sStore;

           StoreComboBox.Enabled = false; 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                qtyDateDateTimePicker.Value = DateTime.Now;

                if (quantityTextBox.Text != null && quantityTextBox.Text != "")
                {
                     string strSQL;

                    if (objData.exists("Select * from ItemCurrentBalance  Where ItemID ='" + ItemIdTextBox.Text.Trim() + "' And BranchID='" + 
                         StoreComboBox.SelectedValue.ToString().Trim() + "'")) 
                       
                            strSQL = "Update ItemCurrentBalance Set FirstQty=" + quantityTextBox.Text +
                                ", FirstQtyDate ='" + qtyDateDateTimePicker.Value.ToString() + "'  Where ItemId ='" + ItemIdTextBox.Text.Trim() + "' " +
                                " And BranchID='" + StoreComboBox.SelectedValue.ToString().Trim() + "'";
                    else
                        strSQL = "Insert Into ItemCurrentBalance(ItemID, BranchID, FirstQtyDate,  FirstQty ) Values ('" + ItemIdTextBox.Text + "', '" +
                            StoreComboBox.SelectedValue.ToString() + "', '"  + qtyDateDateTimePicker.Value.ToString() + "', " + quantityTextBox.Text + ")";


                    objData.executeCommand(strSQL);
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void c_ControlChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

       private void StoreComboBox_SelectedIndexChanged(object sender, EventArgs e)
       {
           StoreTextBox.Text = StoreComboBox.Text;
       }
    }
}
