using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Belayab.Reports;

namespace Belayab
{
    public partial class frmVehicleMaintenanceProcess : Form
    {
        public bool startUp = true;
        private bool saveOk = false;
        private decimal sum, curSum;
        private decimal repTotalNoVAT, repTotal, fuelLTotal, outSideTotal, LaborCTotalNoVAT, laborCTotal, coverHTotal;
        DataGridView dgv, dv;
        string pColName, upColName, curState = "";

        clsUtility objUtility = new clsUtility();
        clsData objData = clsData.Instance;
        clsSecurity objSecurity = new clsSecurity();
        string VehicleType;
        int VehicleSizeId;

        bool dataChanged = false;

        public frmVehicleMaintenanceProcess()
        {
            InitializeComponent();
        }

        private void m_maitanancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            startUp = false;
            SaveDetails();

            // calculateGrandTotal();

            saveManitenanceInfo();
            saveOk = false;
            
            // activateStatus();

        }

        private void refreshDetails()
        {
            try
            {
                this.m_LaborCostTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Fuel_Lubricatnts' table. You can move, or remove it, as needed.
                this.m_Fuel_LubricatntsTableAdapter.Fill(this.belayAbVMaintain.m_Fuel_Lubricatnts);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Replaced' table. You can move, or remove it, as needed.
                this.m_ReplacedTableAdapter.Fill(this.belayAbVMaintain.m_Replaced);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_PartsToRepair' table. You can move, or remove it, as needed.
                this.m_PartsToRepairTableAdapter.Fill(this.belayAbVMaintain.m_PartsToRepair);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_OutSideWork' table. You can move, or remove it, as needed.
                this.m_OutSideWorkTableAdapter.Fill(this.belayAbVMaintain.m_OutSideWork);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_OutSideWork' table. You can move, or remove it, as needed.

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void showHideButtons(bool val)
        {
            bindingNavigatorAddNewItem.Visible = val;
            m_maitanancesBindingNavigatorSaveItem.Visible = val;
            mDetailsAddnew.Visible = val;
            M_DetailSave.Visible = val;
            bindingNavigatorDeleteItem.Visible = val;
            bindingNavigatorDeleteItem1.Visible = val;
            M_DetailSave.Visible = val;
            btnRequest.Visible = val;

        }


        private void frmVehicleMaintenance_Load(object sender, EventArgs e)
        {
            
            try
            {

                //List of employees combobox
                string strSQL = "Select Distinct EmployeeId,EmployeeName From Employees Order by EmployeeName";
                //   objUtility.fillComboValues(requestedByComboBox, strSQL);
                objUtility.fillComboValues(approvedByComboBox, strSQL);
                objUtility.fillComboValues(m_ReceivedByComboBox, strSQL);


                fItemID.DisplayMember = "Description";
                fItemID.ValueMember = "ItemID";

                setAdapterConnectionString();
                refreshItems();

     
                // TODO: This line of code loads data into the 'belayAbInvoices.CustomerList' table. You can move, or remove it, as needed.
                this.customerListTableAdapter.Fill(this.belayAbInvoices.CustomerList);
                // TODO: This line of code loads data into the 'belayAbBranchStore.Stores' table. You can move, or remove it, as needed.
                this.storesTableAdapter.Fill(this.belayAbBranchStore.Stores);
                this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCostType' table. You can move, or remove it, as needed.
                this.m_LaborCostTypeTableAdapter.Fill(this.belayAbVMaintain.m_LaborCostType);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_MantananceType' table. You can move, or remove it, as needed.
                this.m_MantananceTypeTableAdapter.Fill(this.belayAbVMaintain.m_MaintenanceType);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_MechanicList' table. You can move, or remove it, as needed.
                this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_VehicleList' table. You can move, or remove it, as needed.
                this.m_VehicleListTableAdapter.Fill(this.belayAbVMaintain.m_VehicleList);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_LaborCost' table. You can move, or remove it, as needed.
                this.m_LaborCostTableAdapter.Fill(this.belayAbVMaintain.m_LaborCost);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Fuel_Lubricatnts' table. You can move, or remove it, as needed.
                this.m_Fuel_LubricatntsTableAdapter.Fill(this.belayAbVMaintain.m_Fuel_Lubricatnts);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_Replaced' table. You can move, or remove it, as needed.
                this.m_ReplacedTableAdapter.Fill(this.belayAbVMaintain.m_Replaced);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_PartsToRepair' table. You can move, or remove it, as needed.
                this.m_PartsToRepairTableAdapter.Fill(this.belayAbVMaintain.m_PartsToRepair);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_maitanances' table. You can move, or remove it, as needed.

          //      this.m_maitanancesTableAdapter.FillByStore(this.belayAbVMaintain.m_maintenance, clsVariables.sStore);

                //if (clsData.trNo != "")
                //    this.m_maitanancesBindingSource.Filter = "workOrderNumber = ' " + clsData.trNo.Trim( + "'";
                this.m_OutSideWorkTableAdapter.Fill(this.belayAbVMaintain.m_OutSideWork);
                // TODO: This line of code loads data into the 'belayAbVMaintain.m_OutSideWork' table. You can move, or remove it, as needed.
                this.m_ConsumablesTableAdapter.Fill(this.belayAbVMaintain.m_Consumables);
               

                if (clsData.trNo != "")
                    this.m_maitanancesTableAdapter.FillByWoNo(this.belayAbVMaintain.m_maintenance, clsData.trNo);
                else
                    this.m_maitanancesTableAdapter.FillByStore(this.belayAbVMaintain.m_maintenance, clsVariables.sStore);

              

                tbVhMaintenanceDetails.SelectedIndex = 0;

                tbVhMaintenanceDetails_SelectedIndexChanged(new object(), new EventArgs());



                tbVhMaintenanceDetails.SelectedIndex = 0;
                tbVhMaintenanceDetails_SelectedIndexChanged(new object(), new EventArgs());

                //hideWONumber();
                //Enable Print Controls
                //Adminitrative previlages

                if (clsVariables.userRole == "Management")
                    showHideButtons(false);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void hideWONumber()
        {
            try
            {
                m_PartsToRepairDataGridView.Columns["mNumber"].Visible = false;
                m_ReplacedDataGridView.Columns["mNumberR"].Visible = false;
                m_Fuel_LubricatntsDataGridView.Columns["mNumberF"].Visible = false;
                m_LaborCostDataGridView.Columns["mNumberL"].Visible = false;
            }
            catch (Exception e) { }
        }


        private void setAdapterConnectionString()
        {
            m_MantananceTypeTableAdapter.Connection = Belayab.clsData.connBel;
            m_VehicleListTableAdapter.Connection = Belayab.clsData.connBel;
            m_MechanicListTableAdapter.Connection = Belayab.clsData.connBel;
            //employeesLstTableAdapter.Connection = Belayab.clsData.connBel;
            m_LaborCostTableAdapter.Connection = Belayab.clsData.connBel;
            m_Fuel_LubricatntsTableAdapter.Connection = Belayab.clsData.connBel;
            m_LaborCostTypeTableAdapter.Connection = Belayab.clsData.connBel;
            m_ReplacedTableAdapter.Connection = Belayab.clsData.connBel;
            m_PartsToRepairTableAdapter.Connection = Belayab.clsData.connBel;
            m_maitanancesTableAdapter.Connection = Belayab.clsData.connBel;
            partNumDescriptionTableAdapter.Connection = Belayab.clsData.connBel;
            m_OutSideWorkTableAdapter.Connection = Belayab.clsData.connBel;
            m_ConsumablesTableAdapter.Connection = Belayab.clsData.connBel;
            customerListTableAdapter.Connection = Belayab.clsData.connBel;
            storesTableAdapter.Connection = Belayab.clsData.connBel;

        }

        private void btnEditAdd_Click(object sender, EventArgs e)
        {
            frmVehicles f = new frmVehicles(this);
            Belayab.Program.mainFrm.OpenFrm(f);

        }

        private void btnAddEditMech_Click(object sender, EventArgs e)
        {

            frmMechanic ff = new frmMechanic(this);
            Belayab.Program.mainFrm.OpenFrm(ff);


        }

        private void tbVhMaintenanceDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tbVhMaintenanceDetails.SelectedIndex)
            {
                case 0:
                    M_Details_bindingNavigator.BindingSource = m_PartsToRepairBindingSource;
                    txtSubTotal.Visible = false;
                    M_Details_bindingNavigator.Visible = true;
                    break;

                case 1:
                    M_Details_bindingNavigator.BindingSource = m_ReplacedBindingSource;
                    txtSubTotal.Visible = true;
                    M_Details_bindingNavigator.Visible = true;
                    break;
                case 2:
                    M_Details_bindingNavigator.BindingSource = m_Fuel_LubricatntsBindingSource;
                    txtSubTotal.Visible = true;
                    M_Details_bindingNavigator.Visible = true;
                    break;

                case 3:
                    M_Details_bindingNavigator.BindingSource = m_ConsumablesBindingSource;
                    txtSubTotal.Visible = true;
                    M_Details_bindingNavigator.Visible = true;
                    break;

                case 4:
                    M_Details_bindingNavigator.BindingSource = m_LaborCostBindingSource;
                    txtSubTotal.Visible = true;
                    M_Details_bindingNavigator.Visible = true;
                    break;
                case 5:
                    M_Details_bindingNavigator.BindingSource = m_OutSideWorkBindingSource;
                    txtSubTotal.Visible = true;
                    M_Details_bindingNavigator.Visible = true;
                    break;
                case 6:

                    M_Details_bindingNavigator.Visible = false;
                    txtSubTotal.Visible = false;
                    break;
            }

            // SaveDetails();
             calculateSupTotals();
          //  calculateGrandTotal();
            lblCost.Visible = txtSubTotal.Visible;


        }

        private void M_DetailSave_Click(object sender, EventArgs e)
        {
            SaveDetails();
            calculateGrandTotal();
        }

        private void SaveDetails()
        {

            this.Validate();


            try
            {

               validateSave();

                switch (tbVhMaintenanceDetails.SelectedIndex)
                {
                    case 0:

                        m_PartsToRepairBindingSource.EndEdit();
                        m_PartsToRepairTableAdapter.Update(belayAbVMaintain.m_PartsToRepair);

                        break;

                    case 1:
                        m_ReplacedBindingSource.EndEdit();
                        m_ReplacedTableAdapter.Update(belayAbVMaintain.m_Replaced);
                        calculateTotal(m_ReplacedDataGridView, "RTotal");
                        break;
                    case 2:
                        m_Fuel_LubricatntsBindingSource.EndEdit();
                        m_Fuel_LubricatntsTableAdapter.Update(belayAbVMaintain.m_Fuel_Lubricatnts);
                        calculateTotal(m_Fuel_LubricatntsDataGridView, "FTotal");
                        break;

                    case 3:
                        m_ConsumablesBindingSource.EndEdit();
                        m_ConsumablesTableAdapter.Update(belayAbVMaintain.m_Consumables);
                        calculateTotal(m_ConsumablesDataGridView, "TotalPrice");
                        break;

                    case 4:
                        m_LaborCostBindingSource.EndEdit();
                        m_LaborCostTableAdapter.Update(belayAbVMaintain.m_LaborCost);
                        calculateTotal(m_LaborCostDataGridView, "LbTot");
                        break;

                    case 5:
                        m_OutSideWorkBindingSource.EndEdit();
                        m_OutSideWorkTableAdapter.Update(belayAbVMaintain.m_OutSideWork);
                        calculateTotal(m_OutSideWorkDataGridView, "Amount");
                        break;

                }

                txtSubTotal.Text = string.Format("{0:#,##0.00}", curSum);
                mDetailsAddnew.Enabled = true;

              //  saveOk = false;
   //             activateStatus();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void calculateSupTotals()
        {

            switch (tbVhMaintenanceDetails.SelectedIndex)
            {
                case 0:

                   break;

                case 1:
                    calculateTotal(m_ReplacedDataGridView, "RTotal");
                    break;
                case 2:
                    calculateTotal(m_Fuel_LubricatntsDataGridView, "FTotal");
                    break;

                case 3:
                    calculateTotal(m_ConsumablesDataGridView, "TotalPrice");
                    break;

                case 4:
                    calculateTotal(m_LaborCostDataGridView, "LbTot");
                    break;

                case 5:
                    calculateTotal(m_OutSideWorkDataGridView, "Amount");
                    break;

            }

            txtSubTotal.Text = string.Format("{0:#,##0.00}", curSum);

        }
        private void SaveBoth()
        {
            if (startUp) return;

            SaveDetails();
            saveManitenanceInfo();
        }
        public void updateVehicleList()
        {
            string curPlateNo = plateNumberComboBox.Text;
            belayAbVMaintain.m_VehicleList.Clear();
            this.m_VehicleListTableAdapter.Fill(this.belayAbVMaintain.m_VehicleList);
            plateNumberComboBox.Text = curPlateNo;
        }
        public void updateMechList()
        {
            string curMech = mechanicIDComboBox.Text;
            belayAbVMaintain.m_MechanicList.Clear();
            this.m_MechanicListTableAdapter.Fill(this.belayAbVMaintain.m_MechanicList);
            mechanicIDComboBox.Text = curMech;

        }

        private void m_LaborCostDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave();

                if (bindingNavigatorDeleteItem.Text == "Cancel")
                {
                    bindingNavigatorDeleteItem.Text = "Delete";
                }

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    m_maitanancesBindingSource.RemoveCurrent();
                    this.m_maitanancesBindingSource.EndEdit();
                    this.m_maitanancesTableAdapter.Update(this.belayAbVMaintain.m_maintenance);


                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void saveManitenanceInfo()
        {
            try
            {
               

                validateSave();

                if (workOrderNumberTextBox.Text == "") throw new Exception("Please Specify a Work Order Number");
                if (m_ReceivedDateDateTimePicker.Value == null) throw new Exception("Please Select the 'Date In'");
                //        if (mechanicIDComboBox.Text == "") throw new Exception("Please Select a mechanic");
                if (CustomerIdCombobox.Text == "") throw new Exception("Please Select a customer");

                calculateGrandTotal();


                this.Validate();
                this.m_maitanancesBindingSource.EndEdit();

                bool rowmodified = false;

                switch (this.belayAbVMaintain.m_maintenance.Rows[m_maitanancesBindingSource.Position].RowState)
                {
                    case DataRowState.Added:
                    case DataRowState.Modified:
                        rowmodified = true;
                        break;
                }

                /*
                 *          this.m_SerialNoTextBox.Text = objData.getNextValue("SELECT NEXT VALUE FOR mSerials as SNxt");
                        this.belayAbVMaintain.m_maintenance.m_SerialNoColumn.DefaultValue = this.m_SerialNoTextBox.Text.Trim();
                        rowmodified = true;
                        break;
               */

                int idx = tbVhMaintenanceDetails.SelectedIndex;
                ////Activate the summary tab
                 tbVhMaintenanceDetails.SelectedIndex = tbVhMaintenanceDetails.TabCount - 1;
               
                           
                if (rowmodified)
                    

                    if (createdByTextBox.Text == "")
                    {
                        createdByTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                        //          lblCreatedBy.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    }
                    else
                    {
                        //lblUpdatedBy.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                        updatedbyTextBox.Text = clsVariables.curUserName + ": " + DateTime.Now.ToString();
                    }


                this.m_maitanancesBindingSource.EndEdit();
                this.m_maitanancesTableAdapter.Update(this.belayAbVMaintain.m_maintenance);
                
                //Deactivate the summary tab
                tbVhMaintenanceDetails.SelectedIndex = idx;

                if (M_Details_bindingNavigator != null) M_Details_bindingNavigator.Enabled = true;

            //    refreshDetails();

                startUp = false;

                saveOk = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void validateSave()
        {

        //    if (belayAbVMaintain.m_maintenance.GetChanges() != null)
         //   {
                if (m_MaintenanceStatusTextBox.Text == "Closed" && !saveOk)
                {
                    throw new Exception("Status closed! Record not modifiable. Please activate ther record first!");
                }

          //  }
            
        }

        public void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {

                m_maitanancesBindingSource.AddNew();
                M_Details_bindingNavigator.Enabled = false;
                m_ReceivedDateDateTimePicker.Value = DateTime.Now;

                if (bindingNavigatorDeleteItem.Text == "Delete")
                {
                    bindingNavigatorDeleteItem.Text = "Cancel";
                }
                startUp = false;

                chkOverHead.Checked = true;

                storeIDComboBox.SelectedValue = clsVariables.sStore;
                
            }
            catch (Exception ee)
            {
                // MessageBox.Show(  ee.ToString());

            }
        }


        public void calcRTotal()
        {
            dgv = m_ReplacedDataGridView;
            calculateTotal(dgv, "RTotal");

            repTotalNoVAT = curSum;
            repTotal = curSum + curSum * clsVariables.VATAmt;
            //Save/show the Replaced total first
            rTotalTextBox.Text = string.Format("{0:#,##0.00}", repTotal);


            //ohAmtTextBox.Text = string.Format("{0:#,##0.00}", oh+oh*clsVariables.VATAmt);

            // sum = sum + oh;


        }

        private void UdateOverhead()
        {
            try
            {

                decimal oh = 0;

                if (startUp) return;
                string strSQL = "";
                //Ignore Overhead for belayab type customers
                if (CustomerIdCombobox.SelectedValue != null)
                    strSQL = "Select CustomerTypeId from Customers Where CustomerId ='"
                       + CustomerIdCombobox.SelectedValue.ToString() + "'";

                string cusTypeId = objData.getFieldValue(strSQL);
                if (cusTypeId.ToUpper() == "BEL")
                {
                    InsertUpdateOverhead(-1);
                    return;
                }

                if (deiveryDateDateTimePicker.Value >= DateTime.Parse("10/01/2013"))
                {

                    if (repTotalNoVAT > 0)
                    {
                        if (chkOverHead.Checked)
                            oh = CalculateOverHead(repTotalNoVAT);
                        else
                        {
                            InsertUpdateOverhead(-1);
                            return;
                        }
                    }

                }
                else
                {
                    InsertUpdateOverhead(-1);
                    return;
                }


                if (repTotalNoVAT > 0 && oh > 0 && deiveryDateDateTimePicker.Value >= DateTime.Parse("10/01/2013"))
                {
                    InsertUpdateOverhead(oh);

                }
                else
                {
                    if (!chkOverHead.Checked)
                    {
                        InsertUpdateOverhead(-1);
                        return;
                    }

                    if (laborCTotal > 0 && deiveryDateDateTimePicker.Value >= DateTime.Parse("10/01/2013"))
                    {
                        oh = 0.1M * LaborCTotalNoVAT;
                        InsertUpdateOverhead(oh);
                    }
                    else
                    {
                        InsertUpdateOverhead(-1);
                        return;
                    }
                }

            }
            catch (Exception ex) { }

        }

        public void calcFTotal()
        {
            dgv = m_Fuel_LubricatntsDataGridView;
            calculateTotal(dgv, "FTotal");
            fuelLTotal = curSum + curSum * clsVariables.VATAmt; 
            fTotalTextBox.Text = string.Format("{0:#,##0.00}", fuelLTotal);


        }
        public void calcCoTotal()
        {
            dgv = m_ConsumablesDataGridView;
            calculateTotal(dgv, "TotalPrice");
            coverHTotal = curSum + curSum * clsVariables.VATAmt;
            CoTotalTextbox.Text = string.Format("{0:#,##0.00}", coverHTotal);
        }


        public void calcLTotal()
        {
            dgv = m_LaborCostDataGridView;
            calculateTotal(dgv, "LbTot");
            LaborCTotalNoVAT = curSum;
            laborCTotal = curSum + curSum * clsVariables.VATAmt;
            lTotalTextBox.Text = string.Format("{0:#,##0.00}", laborCTotal);
        }




        public void calcOWTotal()
        {
            dgv = m_OutSideWorkDataGridView;
            calculateTotal(dgv, "Amount");
            outSideTotal = curSum + curSum * clsVariables.VATAmt;
            owTotalTextBox.Text = string.Format("{0:#,##0.00}", outSideTotal);
        }

        private void InsertUpdateOverhead(decimal oH)
        {
            String WoN = workOrderNumberTextBox.Text;

            try
            {

                if (oH < 0)
                {
                    String strWhere = "mNumber ='" + WoN + "'" + " And ItemID ='OH001'";
                    //     if (!objData.exists("Select * from m_Consumables Where mNumber ='" + WoN + "'" + " And ItemID ='OH001'")) 
                    objData.deleteRecord("m_Consumables", strWhere);
                    this.m_ConsumablesTableAdapter.Fill(this.belayAbVMaintain.m_Consumables);
                    return;
                }

                if (!objData.exists("Select * from m_Consumables Where mNumber ='" + WoN + "'" + " And ItemID ='OH001'"))
                    objData.addNewRecord("m_Consumables", "mNumber,  ItemID , repDescription , Quantity, UnitPrice", "'" + WoN + "', 'OH001', 'Overhead Cost', 1, " + oH, true);
                else
                    objData.updateRecord("m_Consumables", "mNumber,  ItemID , repDescription , Quantity, UnitPrice", "'" + WoN + "', 'OH001', 'Overhead Cost', 1," + oH,
                       " mNumber ='" + WoN + "'" + " And ItemID ='OH001'", true);

                this.m_ConsumablesTableAdapter.Fill(this.belayAbVMaintain.m_Consumables);

            }
            catch (Exception ex) { }

        }

        private void calculateGrandTotal()
        {
            try
            {
                //  if (startUp) return;
                sum = 0;
                calcFTotal();
                calcOWTotal();
                calcLTotal();
                calcRTotal();

                UdateOverhead();

                saveConsumables();


                calcCoTotal();



                // to check and include overhead follows


                //textBox.Text = string.Format("{0:#,##0.00}", curSum);

                txtTotalPrice.Text = string.Format("{0:#,##0.00}", sum); // with no VAT
                // Continue to vat calculation
                decimal fVat, totWithVat;
              //  fVat = decimal.Parse(fTotalTextBox.Text) * clsVariables.VATAmt;
                totWithVat = sum + sum * clsVariables.VATAmt;
              //  totWithVat -= fVat;

                maintenace_TotalTextBox.Text = string.Format("{0:#,##0.00}", totWithVat);

                //   m_maitanancesBindingSource.EndEdit();
                //   saveManitenanceInfo();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void saveConsumables()
        {
            m_ConsumablesBindingSource.EndEdit();
            m_ConsumablesTableAdapter.Update(belayAbVMaintain.m_Consumables);

        }

        private void calculateTotal(DataGridView dv, string colName)
        {
            try
            {

                int k;
                decimal fval;
                curSum = 0;

                if (dv.Rows.Count > 0)
                    for (k = 0; k < dv.Rows.Count; k++)
                        if (dv.Rows[k].Cells[colName].Value != null)
                            if (decimal.TryParse(dv.Rows[k].Cells[colName].Value.ToString(), out fval))
                            {
                                sum += fval;
                                curSum += fval;
                            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private decimal CalculateOverHead_old(decimal ohd)
        {
            decimal ohh = 0;

            if (ohd < 1001M)
                ohh = 0.2M * ohd;
            else if (ohd < 10001M)
                ohh = clsVariables.OHAmt * ohd;
            else if (ohd < 25001M)
                ohh = 0.1M * ohd;
            else if (ohd < 50001M)
                ohh = 0.08M * ohd;
            else if (ohd < 100001M)
                ohh = 0.05M * ohd;
            else
                ohh = 0.03M * ohd;

            return ohh;

        }

        private decimal CalculateOverHead(decimal ohd)
        {
            decimal ohh = 0;
         
            if (ohd < 50001M)
                ohh = 0.1M * ohd;
            else if (ohd < 100001M)
                ohh = 0.07M * ohd;
            else if (ohd < 200001M)
                ohh = 0.05M * ohd;
           else
                ohh = 0.03M * ohd;

            return ohh;

        }



        //////        if (curSum <= 1000.99M)
        //////    ohh = 0.2M * curSum;
        //////else if (curSum <= 10000.99M)
        //////    ohh = clsVariables.OHAmt * (curSum-1000M) + 200M;
        //////else if (curSum <= 25000.99M)
        //////    ohh = 0.1M * (curSum - 10000M) + 1500M;
        //////else if (curSum <= 50000.99M)
        //////    ohh = 0.08M * (curSum - 25000M) + 3000M;
        //////else if (curSum <= 100000.99M)
        //////    ohh = 0.05M * (curSum - 5000.99M) + 5000M;
        //////else
        //////    ohh = 0.03M * (curSum - 100000M) + 7500M;

        private void m_maitanancesBindingSource_PositionChanged(object sender, EventArgs e)
        {
           try{
               // activateStatus();
            calculateGrandTotal();
           }
        catch (Exception ex ) {}
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            M_Details_bindingNavigator.BindingSource.AddNew();
            mDetailsAddnew.Enabled = false;


            if (tbVhMaintenanceDetails.SelectedIndex == 4)
                m_LaborCostDataGridView.Rows[m_LaborCostDataGridView.CurrentCell.RowIndex].Cells["hourlyRateDataGridViewTextBoxColumn"].Value = clsVariables.mLaborRate;

        }

        //private void activateStatus()
        //{
        //    curState = m_MaintenanceStatusTextBox.Text;
        //    //calculateGrandTotal();
        //    if (m_MaintenanceStatusTextBox.Text == "Closed")
        //    {
        //        if (clsVariables.curUserName == "ADMIN" || clsVariables.curUserName == "DANIEL" ||
        //            clsVariables.curUserName == "YARED" || clsVariables.curUserName == "BELAYAB")
        //        {
        //            m_MaintenanceStatusTextBox.Enabled = true;
        //        }
        //        else
        //        {
        //            m_MaintenanceStatusTextBox.Enabled = false;
        //        }

        //    }
        //    else
        //    {
        //        m_MaintenanceStatusTextBox.Enabled = true;
        //    }

        //}

        private void mechanicIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataChanged = true;

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            try
            {
                validateSave(); 

                if (MessageBox.Show("Are you sure to delete this Record? ", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    M_Details_bindingNavigator.BindingSource.RemoveCurrent();
                    SaveBoth();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

       



        private void btnPrintPreview_Click(object sender, EventArgs e)
        {

            saveManitenanceInfo();

            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_Maintenance Where [Work Order Number] = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strRep = "Select * from rpt_Replaced Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strLabor = "Select * from m_LaborCost Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strpartsToRep = "Select * from m_PartsToRepair Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strfuelL = "Select * From rpt_FuelLubricants Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strOutside = "Select * From m_OutsideWork Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";
            string strCo = "Select * From m_Consumables Where mNumber = '" + workOrderNumberTextBox.Text.Trim() + "'";

            frmv.SetReport(new rptWoPortrait(), strSQL, "rpt_Maintenance", strRep, strLabor, strpartsToRep, strfuelL, strOutside, strCo);

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void m_Fuel_LubricatntsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void m_LaborCostDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            frmItemRequisitions fr = new frmItemRequisitions(workOrderNumberTextBox.Text);
            Program.mainFrm.OpenFrm(fr);
            fr.lstRequsitions.Visible = true;
        }

        private void m_ReplacedDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }

        private void m_Fuel_LubricatntsDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            objUtility.makeCellEditable(e);
        }


        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            frmInvoices finv = new frmInvoices();
            Program.mainFrm.OpenFrm(finv);

        }

        private void m_Fuel_LubricatntsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null) {

            }
        }

        private void m_LaborCostDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null) {

            }
        }

        private void m_ReplacedDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null) {

            }
        }

        
        private void mnuRefreshItems_Click(object sender, EventArgs e)
        {
            refreshItems();
        }

        private void refreshItems()
        {
            
            this.belayAbSSDataSet.PartNumDescription.Clear();
            this.partNumDescriptionTableAdapter.Fill(this.belayAbSSDataSet.PartNumDescription);

            string strSQL = "Select * From PartNumDescription";
            objUtility.fillComboValues(fItemID, strSQL);

            this.m_MantananceTypeTableAdapter.Fill(this.belayAbVMaintain.m_MaintenanceType);


        }

        private void mnuAllItems_Click(object sender, EventArgs e)
        {
            frmItemsList f = new frmItemsList(tbVhMaintenanceDetails.TabPages[tbVhMaintenanceDetails.SelectedIndex].Text, this);
            Program.mainFrm.OpenOverFrm(f);
        }

        private void mnuEditItem_Click(object sender, EventArgs e)
        {

            try
            {
                switch (tbVhMaintenanceDetails.SelectedIndex)
                {
                    case 1:
                        clsData.pNum = m_ReplacedDataGridView.Rows[m_ReplacedDataGridView.CurrentCell.RowIndex].Cells["RItemID"].Value.ToString().Trim();
                        Program.mainFrm.OpenOverFrm(new frmItemEdit());

                        break;
                    case 2:
                        clsData.pNum = m_Fuel_LubricatntsDataGridView.Rows[m_Fuel_LubricatntsDataGridView.CurrentCell.RowIndex].Cells["FItemID"].Value.ToString().Trim();
                        Program.mainFrm.OpenOverFrm(new frmItemEdit());
                        break;
                }

            }
            catch (Exception ex)
            {
                Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }
        }

        public void selectItem(string pNum)
        {
            try
            {
                refreshItems();

                switch (tbVhMaintenanceDetails.SelectedIndex)
                {
                    case 1:
                        m_ReplacedDataGridView.Rows[m_ReplacedDataGridView.CurrentCell.RowIndex].Cells["RItemID"].Value = pNum;
                        break;
                    case 2:
                        m_Fuel_LubricatntsDataGridView.Rows[m_Fuel_LubricatntsDataGridView.CurrentCell.RowIndex].Cells["FItemID"].Value = pNum;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
      //private void frmVehicleMaintenance_Activated(object sender, EventArgs e)
        //{

        //    if (clsData.trNo != "")
        //    {
        //        int res = m_maitanancesBindingSource.Find("WorkOrderNumber", clsData.trNo);
        //        if (res > -1) m_maitanancesBindingSource.Position = res;
        //        clsData.trNo = "";
        //    }

        //    refreshItems();

        //    //enable controls
        //    if (!this.workOrderNumberTextBox.Enabled)
        //    {
        //        if (clsVariables.userRole == "Finance")
        //        {
        //            panel1.Enabled = true;
        //            tbVhMaintenanceDetails.SelectedIndex = tbVhMaintenanceDetails.TabCount - 1;
        //            btnPrintPreview.Enabled = true;
        //            btnQuote.Enabled = true;
        //        }

        //    }

        //    calculateGrandTotal();
        //    //    activateStatus();
        //}

        private void m_maitanancesBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message.ToString());

        }

        private void m_ReplacedDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }


        private void setPrices(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getCurrentGridItems();
                if (e.ColumnIndex >= 0)
                    if (dv.Columns[e.ColumnIndex].Name == pColName)
                    {


                        dv.Rows[e.RowIndex].ErrorText = "";

                        dv.Rows[e.RowIndex].Cells[upColName].Value =
                        objData.getUnitPrice(dv.Rows[e.RowIndex].Cells[pColName].Value.ToString());


                        //                     calculateGrandTotal();


                    }



            }

            catch (Exception ex)
            {

                //   MessageBox.Show(ex.Message,"Error...",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //if (e.RowIndex >= 0 && dv.Columns[e.ColumnIndex].Name != "ItemID") dv.Rows[e.RowIndex].ErrorText = ex.Message;
            }
        }

        private void cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            float val;
            try
            {
                getCurrentGridItems();

                dv.Rows[e.RowIndex].ErrorText = "";

                if (dv.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice")
                {
                    if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                        e.Cancel = true;
                    }

                }

                if (dv.Columns[e.ColumnIndex].DataPropertyName == "Quantity")
                {
                    // GetInstock(e.RowIndex);

                    if (!float.TryParse(e.FormattedValue.ToString(), out val) || val < 0)
                    {
                        dv.Rows[e.RowIndex].ErrorText = "Value must be a non-negative number";
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void getCurrentGridItems()
        {
            if (tbVhMaintenanceDetails.SelectedTab == null) return;

            if (tbVhMaintenanceDetails.SelectedIndex == 1)
            {
                dv = this.m_ReplacedDataGridView;
                pColName = "RItemID";
                upColName = "RUnitPrice";
            }

            else
            {
                dv = this.m_Fuel_LubricatntsDataGridView;
                pColName = "FItemID";
                upColName = "FUnitPrice";
            }

        }

        private void m_Fuel_LubricatntsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plateNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string strSQL;
                if (plateNumberComboBox.Text != "")
                {
                    strSQL = "SELECT   Distinct   CustomerName FROM   m_maintenance INNER JOIN m_Vehicles ON m_maintenance.PlateNumber = m_Vehicles.[Plate Number] INNER JOIN Customers ON m_Vehicles.Owner = Customers.CustomerId Where m_maintenance.PlateNumber = '" + plateNumberComboBox.SelectedValue.ToString().Trim() + "'";
                    lblCustomer.Text = objData.getStringValue(strSQL);

                    //Set the vehicle type and size
                    strSQL = "Select VehicleType from m_Vehicles Where [Plate Number] ='" + plateNumberComboBox.SelectedValue.ToString().Trim() + "'";
                    VehicleType = objData.getStringValue(strSQL);

                    strSQL = "Select VehicleSizeId from m_VehicleType Where VehicleType ='" + VehicleType + "'";
                    VehicleSizeId = int.Parse(objData.getFieldValue(strSQL));

                    //    MessageBox.Show (" VT: " +VehicleType + "VS: " + VehicleSizeId.ToString());

                    // display valid  flat rates 
                    FetchFlatRates(VehicleSizeId, "");

                    // update the flat rates for the new vehicle
                    UpdateFlatRates();

                }
                else
                    lblCustomer.Text = "";
            }
            catch (Exception ex)
            {
                //    lblCustomer.Text = "";
                //    MessageBox.Show(ex.Message);
            }
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {

           // SaveBoth();

            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_Maintenance Where [Work Order Number] = '" + workOrderNumberTextBox.Text.Trim() + "'";

            if (clsVariables.sStore == "SBS1")
            {

                if(DialogResult.No == MessageBox.Show("Hide Bank Account References?", "Hide Bank Account...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                      frmv.SetReport(new rptWoQuatation(), strSQL, "rpt_Maintenance");
                else
                    frmv.SetReport(new rptWoQuatation_No_Account(), strSQL, "rpt_Maintenance");
            }
            else if (clsVariables.sStore == "MBS1")
                frmv.SetReport(new rptWoQuatationM(), strSQL, "rpt_Maintenance");
            else if (clsVariables.sStore == "ADBS1")
                frmv.SetReport(new rptWoQuatationAD(), strSQL, "rpt_Maintenance");
            else if (clsVariables.sStore == "KBS1")
                frmv.SetReport(new rptWoQuatationK(), strSQL, "rpt_Maintenance");
            else if (clsVariables.sStore == "RCBS1" || clsVariables.sStore == "SBS1")
            {
                if (DialogResult.No == MessageBox.Show("Hide Bank Account References?", "Hide Bank Account...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    frmv.SetReport(new rptWoQuatationRC(), strSQL, "rpt_Maintenance");
                else
                    frmv.SetReport(new rptWoQuatation_No_Account(), strSQL, "rpt_Maintenance");
            }
         //   frmv.SetReport(new rptWoQuatationRC(), strSQL, "rpt_Maintenance");

            Program.mainFrm.OpenOverFrm(frmv);

        }

        //private void frmVehicleMaintenance_Shown(object sender, EventArgs e)
        //{
        //    if (!this.workOrderNumberTextBox.Enabled)
        //    {
        //        if (clsVariables.userRole == "Finance")
        //        {
        //            panel1.Enabled = true;
        //            tbVhMaintenanceDetails.SelectedIndex = tbVhMaintenanceDetails.TabCount - 1;
        //            btnPrintPreview.Enabled = true;
        //            btnQuote.Enabled = true;
        //        }

        //    }

        //    storeIDComboBox.Enabled = false;
        //}

       
        private void frmVehicleMaintenance_Validated(object sender, EventArgs e)
        {
            dataChanged = true;
        }

        private void m_ConsumablesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (m_ConsumablesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "OH001") e.Cancel = true;
        }

        private void FetchFlatRates(int VSize, string FRSubCat)
        {
            //row or location Combo
            //  string strSQL = "SELECT Distinct lCostType from m_LaborCostType";
            /*  string strSQL = "SELECT Distinct  m_FlatRateSubCategories.FlatRateSubCatDesc " +
                              " FROM  m_FlatRateValues INNER JOIN m_FlatRateSubCategories ON m_FlatRateValues.FlatRateSubCatID = m_FlatRateSubCategories.FlatRateSubCatId " +
                              "Where m_FlatRateValues.VehicleSizeId =" + VSize +
                              " UNION SELECT lCostType AS FlatRateSubCatDesc FROM m_LaborCostType";
            
               */

                string strSQL = "SELECT     FlatRateTypeDescription as lCostType  FROM  m_FlatRateTypes" +
                             " UNION SELECT lCostType AS FlatRateSubCatDesc FROM m_LaborCostType";




            objUtility.fillComboValues(LaborType, strSQL);


            LaborType.DisplayMember = "lCostType";
            LaborType.ValueMember = "lCostType";



            //         LaborType.DisplayMember = "FlatRateSubCatDesc";
            //          LaborType.ValueMember = "FlatRateSubCatDesc";

        }


        private void m_LaborCostDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex >= 0)
                    if (m_LaborCostDataGridView.Columns[e.ColumnIndex].Name == LaborType.Name)
                    {
                        setFlatRate(e.RowIndex);
                    }

            }
            catch (Exception ex)
            {


            }
        }

        private void editLaborCostTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void editLaborCostTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLaborTypes flt = new frmLaborTypes();
            Program.mainFrm.OpenFrm(flt);
        }

        private void setFlatRate(int rIdx)
        {

            if (objData.exists("Select * from m_FlatRateSubCategories where FlatRateSubCatDesc ='" + m_LaborCostDataGridView.Rows[rIdx].Cells["LaborType"].Value.ToString() + "'")) ;
            {
                string StrSQL = "SELECT FlatRateHours  FROM m_FlatRateValues Inner join m_FlatRateSubCategories on " +
                                  "m_FlatRateValues.FlatRateSubCatId = m_FlatRateSubCategories.FlatRateSubCatId " +
                               " Where m_FlatRateValues.VehicleSizeId =" + VehicleSizeId +
                              " And FlatRateSubCatDesc ='" + m_LaborCostDataGridView.Rows[rIdx].Cells["LaborType"].Value.ToString() + "'";

                m_LaborCostDataGridView.Rows[rIdx].Cells["LHours"].Value = decimal.Parse(objData.getFieldValue(StrSQL));
            }
        }

        private void UpdateFlatRates()
        {
            try
            {

                int k;

                if (m_LaborCostDataGridView.Rows.Count > 0)
                    for (k = 0; k < m_LaborCostDataGridView.Rows.Count; k++)
                        setFlatRate(k);

            }
            catch (Exception ex)
            {
                //         MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void m_LaborCostDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (m_LaborCostDataGridView.Rows.Count <= 0) return;
            int rIdx = m_LaborCostDataGridView.CurrentCell.RowIndex;
            int lbCId = int.Parse(m_LaborCostDataGridView.Rows[rIdx].Cells["lbCostId"].Value.ToString());
            string lbrType = m_LaborCostDataGridView.Rows[rIdx].Cells["LaborType"].Value.ToString();

            //string won = workOrderNumberTextBox.Text;

            frmVLaborCostDetails flvcd = new frmVLaborCostDetails(lbCId, VehicleSizeId, workOrderNumberTextBox.Text, lbrType);
            Program.mainFrm.OpenFrm(flvcd);


            //int rIdx = m_LaborCostDataGridView.CurrentCell.RowIndex;
            //string mech = m_LaborCostDataGridView.Rows[rIdx].Cells["Mechanic"].Value.ToString();
            //string won = workOrderNumberTextBox.Text;

            //frmLaborCostDetails flcd = new frmLaborCostDetails(won,mech);
            //Program.mainFrm.OpenFrm(flcd);
        }

        private void btnEditCustomers_Click(object sender, EventArgs e)
        {

            frmCustomersSuppliers f = new frmCustomersSuppliers(this);
            Program.mainFrm.OpenFrm(f);
            f.txtFind.Text = CustomerIdCombobox.Text;
            f.tabSupplier_Customer.SelectedIndex = 1;
        }

        private void m_LaborCostDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void laborDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.showLaborDetails(workOrderNumberTextBox.Text.Trim(), false);

        }

     

        private void btnCloseActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCloseActivate.Text == "Activate")
                {
                    if (objSecurity.userHasSuperPermission())
                    {
                        m_MaintenanceStatusTextBox.Text = "Active";
                        btnCloseActivate.Text = "Close";
                        belayAbVMaintain.EndInit();
                    }

                    else
                    {
                        throw new Exception("You Can't do this with your current account!");

                    }
                }
                else
                {

                    m_MaintenanceStatusTextBox.Text = "Closed";
                    btnCloseActivate.Text = "Activate";
                    belayAbVMaintain.EndInit();
                }
                saveOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void m_MaintenanceStatusTextBox_TextChanged(object sender, EventArgs e)
        {
            if (m_MaintenanceStatusTextBox.Text == "Closed")
                btnCloseActivate.Text = "Activate";
            else
                btnCloseActivate.Text = "Close";
        }

        private void chkOut_Click(object sender, EventArgs e)
        {
            if (chkOut.Checked)
            {
                //Check for outside work 
                if (m_OutSideWorkDataGridView.Rows.Count == 0)
                    if (MessageBox.Show("No Outside work recorded for this workworder. Are you sure to continue??", "Outside work alert",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        chkOut.Checked = false;
                        return;
                    }


                //out is checked. Does the user want also to close the work order then??
                if (MessageBox.Show("Do you want to close the work worder now?", "Outside work alert",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    btnCloseActivate_Click(null, null);

            }
        }

        private void btnEditMaintenaceTypes_Click(object sender, EventArgs e)
        {
            frmVMaintainanceType f = new frmVMaintainanceType();
            Program.mainFrm.OpenFrm(f);
          
        }
   }
         
  }

