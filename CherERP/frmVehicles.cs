using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmVehicles : Form
    {
        clsUtility objUtility = new clsUtility();
        clsData objData = clsData.Instance;
        frmVehicleMaintenanceProcess frm = null;
        int order =1;

        public frmVehicles(frmVehicleMaintenanceProcess f)
        {
            InitializeComponent();
            frm = f;
        }
        public frmVehicles()
        {
            InitializeComponent();
        }

       

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            
          
       try
            {

                setAdapterConnectionString();

                this.m_VehiclesTableAdapter.Fill(this.belayAbVMaintain.m_Vehicles);
                this.m_VehicleTypeTableAdapter.Fill(this.belayAbVMaintain.m_VehicleType);
                this.customersTableAdapter.Fill(this.belayAbInvoices.Customers);
                this.m_ItemTypesTableAdapter.Fill(this.belayAbVMaintain.m_ItemTypes);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_ItemTypes' table. You can move, or remove it, as needed.
                this.m_ItemTypesTableAdapter.Fill(this.belayAbVMaintain.m_ItemTypes);
                //         this.customerListTableAdapter.Fill(belayAbInvoices.CustomerList );
            }
            catch (Exception ex) { }//MessageBox.Show(ex.Message); }

            try
            {
                if (frm != null && frm.plateNumberComboBox.Text != "")
                {
                    int res = m_VehiclesBindingSource.Find("Plate Number", frm.plateNumberComboBox.SelectedValue.ToString());
                    if (res > -1) m_VehiclesBindingSource.Position = res;
                    m_VehiclesDataGridView.Rows[res].Selected = true;

                }
            }
            catch (Exception exx) { }
            
        }

     
        private void setAdapterConnectionString()
        {
            m_VehiclesTableAdapter.Connection = Belayab.clsData.connBel;
            m_VehicleTypeTableAdapter.Connection = Belayab.clsData.connBel;
            customersTableAdapter.Connection = Belayab.clsData.connBel;
            m_ItemTypesTableAdapter.Connection = Belayab.clsData.connBel;
            m_ItemTypesTableAdapter.Connection = Belayab.clsData.connBel;

        }

        private void frmVehicles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm != null)
                frm.updateVehicleList();
        }

        private void m_VehiclesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            saveVehicles();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
               if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_VehiclesBindingSource.RemoveCurrent();
                    saveVehicles();

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void saveVehicles()
        {
            this.Validate();
            this.m_VehiclesBindingSource.EndEdit();
            this.m_VehiclesTableAdapter.Update(this.belayAbVMaintain.m_Vehicles);
        }

        private void m_VehiclesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                //MessageBox.Show(e.Exception.Message.ToString());
                //e.Cancel = true;
            }


        }


     
        private void m_VehiclesDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);

        }

        private void mnuRefreshItems_Click(object sender, EventArgs e)
        {
            refreshItems();
        }

        private void refreshItems()
        {
           
            this.m_VehicleTypeTableAdapter.Fill(this.belayAbVMaintain.m_VehicleType);
            this.customersTableAdapter.Fill(this.belayAbInvoices.Customers);
            this.m_ItemTypesTableAdapter.Fill(this.belayAbVMaintain.m_ItemTypes);
        }

        private void frmVehicles_Activated(object sender, EventArgs e)
        {
            refreshItems();
        }

       


      

        private void m_VehiclesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //First Get all descriptions for the sort order
            if (m_VehiclesDataGridView.Columns[e.ColumnIndex].Name == "Owner")
            {
                setAllDescriptions();

                objUtility.sortGrid(m_VehiclesDataGridView, order, "HD");
                order = order % 2 + 1;
            }
        }

        private void setAllDescriptions()
        {
            try
            {
                int k;

                string strSQL;


                for (k = 0; k < m_VehiclesDataGridView.Rows.Count; k++)
                {
                    strSQL = "Select CustomerName from Customers Where CustomerId = '" + m_VehiclesDataGridView.Rows[k].Cells["Owner"].Value.ToString().Trim() + "'";
                    m_VehiclesDataGridView.Rows[k].Cells["HD"].Value = objData.getStringValue(strSQL);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtFindVehicle_TextChanged(object sender, EventArgs e)
        {
            objData.filterData(m_VehiclesBindingSource, "Plate Number", txtFindVehicle.Text);
        }

        private void mnuEditEditCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomersSuppliers fc = new frmCustomersSuppliers();
                Program.mainFrm.OpenFrm(fc);
                fc.tabSupplier_Customer.SelectedIndex = 1;

                string curCustomer = m_VehiclesDataGridView.Rows[m_VehiclesDataGridView.CurrentCell.RowIndex].Cells["Owner"].EditedFormattedValue.ToString();

                fc.txtFind.Text = curCustomer;
            }
            catch (Exception ex) { }
        }

        private void mnuEditNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers fc = new frmCustomersSuppliers();
            Program.mainFrm.OpenFrm(fc);
            fc.tabSupplier_Customer.SelectedIndex = 1;
            fc.btnAddNew_Click(null, null);

        }

        private void mnuEditVehicles_Click(object sender, EventArgs e)
        {
            frmVehicleModels fv = new frmVehicleModels();
            Program.mainFrm.OpenFrm(fv);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMItemTypes frItm = new frmMItemTypes();
            Program.mainFrm.OpenFrm(frItm);

        }

        private void frmVehicles_Resize(object sender, EventArgs e)
        {
            m_VehiclesDataGridView.Left = 0;
            m_VehiclesDataGridView.Width = this.Width;

        }

        

    }
}