using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;

namespace Belayab
{
    public partial class frmCustomersSuppliers : Form
    {
        public clsSupplier objSup = new clsSupplier();
        public clsCustomer objCus = new clsCustomer();
        ListViewItem itm;
        DataTable dtData;  // a data table used to fill the listviews


        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();


        public int selectedId = 0;
        public bool bolForNew = false;
        public bool bolReadOnly = false;
        private string newCustomer = "";
        private string fltr = "";

        frmInvoices frminv = null;
        frmInvoicesCredit frminvC = null;
        frmGoodReceivedNote frmgrn = null;
        frmVehicleMaintenanceProcess frmVM = null;
        


        public frmCustomersSuppliers(frmInvoices f)
        {
            InitializeComponent();
            frminv = f;
            fillListView();

            txtFind_TextChanged(new object(), new EventArgs());

        }
        public frmCustomersSuppliers(frmInvoicesCredit ff)
        {
            InitializeComponent();
            frminvC = ff;
            fillListView();

            txtFind_TextChanged(new object(), new EventArgs());

        }

        public frmCustomersSuppliers(frmGoodReceivedNote f)
        {
            InitializeComponent();
            frmgrn = f;
            fillListView();
        }

        public frmCustomersSuppliers(frmVehicleMaintenanceProcess f)
        {
            InitializeComponent();
            frmVM = f;
            fillListView();
        }

        public frmCustomersSuppliers()
        {
            InitializeComponent();

            fillListView();

        }

        public frmCustomersSuppliers(string strCId)
        {
            InitializeComponent();

        }


        private void fillListView()
        {
           
            dtData = objSup.getAllSuppliers();
            try
            {
                dtData = objSup.getAllSuppliers();


                objUtility.FillListViewData(lvSupplier, dtData, 5);

// repeated inside RefreshData
                dtData = objCus.getAllCustomers();
                objUtility.FillListViewData(lvCustomer, dtData, 12);

            }

            catch (Exception ex) { }


        }




        private void populateSupplierValues()
        {
            try
            {

                clearValues();
                txtSupplierId.Text = lvSupplier.SelectedItems[0].SubItems[1].Text;
                txtSupplierName.Text = lvSupplier.SelectedItems[0].SubItems[2].Text;
                txtTelephone.Text = lvSupplier.SelectedItems[0].SubItems[3].Text;
                txtPOBox.Text = lvSupplier.SelectedItems[0].SubItems[4].Text;
                txtEmailAddress.Text = lvSupplier.SelectedItems[0].SubItems[5].Text;

            }
            catch (Exception ex) { }

        }

        private void populateCustomerValues()
        {
            try
            {
                // clearValues();
                txtCustomerId.Text = lvCustomer.SelectedItems[0].SubItems[1].Text;
                txtCustomerName.Text = lvCustomer.SelectedItems[0].SubItems[2].Text;
                txtWordaId.Text = lvCustomer.SelectedItems[0].SubItems[3].Text;
                txtKebele.Text = lvCustomer.SelectedItems[0].SubItems[4].Text;
                txtCustomerPhone.Text = lvCustomer.SelectedItems[0].SubItems[5].Text;
                txtCity.Text = lvCustomer.SelectedItems[0].SubItems[6].Text;
                txtCountry.Text = lvCustomer.SelectedItems[0].SubItems[7].Text;
                txtVatRegNumber.Text = lvCustomer.SelectedItems[0].SubItems[8].Text;
                dateTimeVatRegdate.Text = lvCustomer.SelectedItems[0].SubItems[9].Text;
                txtTINNumber.Text = lvCustomer.SelectedItems[0].SubItems[10].Text;
                cboCustomerType.SelectedValue = lvCustomer.SelectedItems[0].SubItems[11].Text;
                txtContactTel.Text = lvCustomer.SelectedItems[0].SubItems[12].Text;
            }
            catch (Exception ex) { }

        }



        private void clearValues()
        {
            foreach (Control Cont in tabSupplier_Customer.SelectedTab.Controls)
                if (Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
                    Cont.Text = "";
            lblSaved.Text = "";
        }


        private void frmCustomersSuppliers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'belayAbInvoices.CustomerTypes' table. You can move, or remove it, as needed.
            customerTypesTableAdapter.Connection = clsData.connBel;

            this.customerTypesTableAdapter.Fill(this.belayAbInvoices.CustomerTypes);

            tabSupplier_Customer.Width = this.Width;
            tabSupplier_Customer.Height = this.Height;

            Program.scFrm = this;

        }


        public void btnAddNew_Click(object sender, EventArgs e)
        {
            clearValues();
            bolForNew = true;
            getControlFocus();
            btnAddNew.Enabled = false;

            if (btnSave.Enabled == false) btnSave.Enabled = true;
            if (btnDelete.Enabled == false) btnDelete.Enabled = true;

            if (tabSupplier_Customer.SelectedTab.Text == "Supplier")
                txtSupplierName.Focus();
            else
                txtCustomerName.Focus();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void collectValues()
        {
            if (tabSupplier_Customer.SelectedTab.Text == "Supplier")
            {
                objSup.SupplierId = this.txtSupplierId.Text;
                objSup.SupplierName = this.txtSupplierName.Text;
                objSup.TelePhone = this.txtTelephone.Text;
                objSup.PoBox = this.txtPOBox.Text;
                objSup.EmailAddress = this.txtEmailAddress.Text;

            }
            else
            {
                objCus.pCustomerId = txtCustomerId.Text;
                objCus.pCustomerName = txtCustomerName.Text;
                objCus.pWoreda = txtWordaId.Text;
                objCus.pKebele = txtKebele.Text;
                objCus.pHouseNo = txtCustomerPhone.Text;
                objCus.pCity = txtCity.Text;
                objCus.pCountry = txtCountry.Text;
                objCus.pVATRegNumber = txtVatRegNumber.Text;
                objCus.pVATRegDate = dateTimeVatRegdate.Text;
                objCus.pTINNumber = txtTINNumber.Text;
                objCus.pCustomerTypeId = cboCustomerType.SelectedValue.ToString();
                objCus.pContactTelephone = txtContactTel.Text;
               
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            if (isvalid)//(isDataValid())
            {
                collectValues();

                //string strCriteria=txtName.Text+txtFName.Text+txtGFName.Text;

                switch (tabSupplier_Customer.SelectedTab.Text)
                {
                    case "Supplier":
                        if (!bolForNew)
                        {
                            objSup.beginTransact();
                            try
                            {
                                objSup.UpdateSupplier();

                                //Refresh lst view
                                fillListView();
                                objSup.commitTransact();


                            }
                            catch (Exception Exp)
                            {
                                objSup.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            lblSaved.Text = "Saved";
                       //     MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Suppliers where SupplierId = '" + objSup.SupplierId + "'"))
                            {
                                objSup.beginTransact();
                                try
                                {
                                    objSup.addSupplier();
                                    objSup.commitTransact();

                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objSup.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                          //      MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                lblSaved.Text = "Saved";

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                        break;
                    case "Customer":

                        if (!bolForNew)
                        {
                            objCus.beginTransact();
                            try
                            {
                                objCus.UpdateCustomer();

                                //Refresh lst view
                                fillListView();
                                objCus.commitTransact();


                            }
                            catch (Exception Exp)
                            {
                                objCus.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                      //      MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblSaved.Text = "Saved";
                            txtFind.Text = objCus.pCustomerName;

                        }

                        else
                        {
                            //Add New 
                            if (txtCustomerName.Text != "")
                                if (!objData.exists("SELECT * from Customers where CustomerName = '" + objCus.pCustomerId + "'"))
                                {
                                    objCus.beginTransact();
                                    try
                                    {
                                        objCus.addCustomer();
                                        objCus.commitTransact();

                                        bolForNew = false;
                                        btnAddNew.Enabled = true;
                                        fillListView();

                                    }

                                    catch (Exception Exp)
                                    {
                                        objCus.rollbackTransact();
                                        MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                           //         MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    lblSaved.Text = "Saved";
                                    txtFind.Text = objCus.pCustomerName;
                                    
                                   

                                }
                                else
                                    MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Please specify a Customer Name", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        break;
                }
            }




        }
        private void getControlFocus()
        {
            if (tabSupplier_Customer.SelectedTab.Text == "Supplier")
                txtSupplierId.Focus();

            else
                txtCustomerId.Focus();
        }
        public Boolean deletedListview()
        {
            Boolean reValue = false;
            if (tabSupplier_Customer.SelectedTab.Text == "Supplier")
            {
                if (lvSupplier.SelectedItems.Count > 0)
                    reValue = true;
            }
            else
            {
                if (lvCustomer.SelectedItems.Count > 0)
                    reValue = true;
            }
            return reValue;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletedListview())
                {
                    if (MessageBox.Show("Are you sure to delete?", "Stosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        collectValues();

                        if (tabSupplier_Customer.SelectedTab.Text == "Supplier")
                        {
                            objSup.deleteSupplier();
                            lvSupplier.SelectedItems[0].Remove();
                            if (lvSupplier.Items.Count > 0) lvSupplier.Items[0].Selected = true;

                        }
                        if (tabSupplier_Customer.SelectedTab.Text == "Customer")
                        {
                            objCus.deleteCustomer();
                            lvCustomer.SelectedItems[0].Remove();
                            if (lvCustomer.Items.Count > 0) lvCustomer.Items[0].Selected = true;


                        }

                    }
                }
            }
            catch (Exception ee)
            {

            }
        }

        private void lvSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                try
                {

                    //selectedId = Int32.Parse(lvBranch.SelectedItems.[0].Text);
                    populateSupplierValues();

                    //    bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                }
                catch (Exception ee)
                { }


            }
        }

        private void lvCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCustomer.SelectedItems.Count > 0)
            {
                try
                {

                    //selectedId = Int32.Parse(lvBranch.SelectedItems.[0].Text);
                    populateCustomerValues();

                    //    bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                }
                catch (Exception ee)
                { }

                lblSaved.Text = "";

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from Customers where CustomerId = '" +
                txtCustomerId.Text + "'";

            frmv.SetReport(new rptCustomerList(), strSQL, "Customers");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void btnAllCustomer_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from Customers ";

            frmv.SetReport(new rptCustomerList(), strSQL, "Customers");

            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void frmCustomersSuppliers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frmgrn != null) frmgrn.updateSupplierList();
            if (frminv != null) frminv.updateCustomerList();
            if (frminvC != null) frminvC.updateCustomerList();
            Program.scFrm = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCustomersSuppliers_Resize(object sender, EventArgs e)
        {
            tabSupplier_Customer.Height = this.Height - 2 * grp1.Height;
            lvCustomer.Height = tabSupplier_Customer.Height - grp1.Height - 2;
            lvSupplier.Height = lvCustomer.Height;
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

            findCustomer(txtFind.Text);

        }

        public void findCustomer(string cusName)
        {
            if (cusName != "")
            {
                if (itm != null) itm.BackColor = lvCustomer.BackColor;

                itm = null;
                itm = lvCustomer.FindItemWithText(txtFind.Text, true, 0, true);
                if (itm != null)
                {
                    itm.Selected = true;
                    lvCustomer.TopItem = itm;
                    itm.BackColor  = Color.GreenYellow;
                    itm.Selected = false;
                }
               

            }
        }

        private void btnEditCustomerType_Click(object sender, EventArgs e)
        {
            frmCustomerTypes fct = new frmCustomerTypes();
            Program.mainFrm.OpenFrm(fct);
        }

        public void refreshData()
        {
            this.customerTypesTableAdapter.Fill(this.belayAbInvoices.CustomerTypes);

            dtData = objCus.getAllCustomers();
            objUtility.FillListViewData(lvCustomer, dtData, 12);


        }

        private void btnAdressDetails_Click(object sender, EventArgs e)
        {
            int cusID = Int16.Parse(txtCustomerId.Text);

            frmCustomerAdress fad = new frmCustomerAdress(cusID);
            Program.mainFrm.OpenFrm(fad);
        }


       
    }

       

}