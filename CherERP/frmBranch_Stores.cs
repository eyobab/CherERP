using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmBranch_Stores : Form
    {
        public string oldBrId = "";
        public string oldStId = "";
        public string oldShId = "";
        public string oldColId = "";
        public string oldRowId = ""; 

        public clsBranch objBranch = new clsBranch();
        public clsStore objStore = new clsStore ();
        public clsShelf objShelf = new clsShelf();
        public clsColumn objColumn = new clsColumn();
        public clsRow objRow = new clsRow();

        clsUtility objUtility = new clsUtility();
        clsData objData = clsData.Instance;
        public int selectedId = 0;
        public bool bolForNew = false;
        public bool bolReadOnly = false;
        private string strSQL = "";

        public frmBranch_Stores()
        {
            InitializeComponent();
            fillListView();
            

            //Store
            //strSQL = "Select Distinct BranchId, BranchName From Branches Order by BranchName";
            //objUtility.fillComboValues(cboBranchId, strSQL);
            //cboBranchId.DisplayMember = "BranchName";
            //cboBranchId.ValueMember = "BranchId";
            //Shelf
            strSQL = "Select Distinct StoreId,StoreName From Stores Order By StoreName";
            objUtility.fillComboValues(comboStoreId, strSQL);

            //Column
            strSQL = "Select Distinct ShelfId, ShelfName From Shelfs Order By ShelfName";
            objUtility.fillComboValues(cboShelfId, strSQL);
            //Row
            strSQL = "Select Distinct ColumnId,Description From Columns Order By Description";
            objUtility.fillComboValues(cboColumnId, strSQL);

            

        }
        private void frmBranch_Stores_Load(object sender, EventArgs e)
        {
            branchesTableAdapter.Connection = clsData.connBel;
            // TODO: This line of code loads data into the 'belayAbBranchStore.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.belayAbBranchStore.Branches);
            tbBranchStore.Width = this.Width;
            tbBranchStore.Height = this.Height;

            Program.brsFrm = this;
            
        }
        //fillListview
        private void fillListView()
        {

            DataTable dtData;
            dtData = objBranch.getAllBranches();
            try
            {
                dtData = objBranch.getAllBranches();
                objUtility.FillListViewData(lvBranch, dtData, 4);


                dtData = objStore.getAllStores();
                objUtility.FillListViewData(lvStore, dtData, 4);

                dtData = objShelf.getAllShelves();
                objUtility.FillListViewData(lvShelf, dtData, 4);


                dtData = objColumn.getAllColumns();
                objUtility.FillListViewData(lvColumn, dtData, 3);

                dtData = objRow.getAllRows();
                objUtility.FillListViewData(lvRow, dtData, 3);



            }

            catch (Exception ex) { 
                //MessageBox.Show(ex.Message); 
            }
        }        
          
        private void populateBranchValues()
        {
            try
            {

               // clearValues();
                txtBranchId.Text = lvBranch.SelectedItems[0].SubItems[1].Text;
                txtBranchName.Text = lvBranch.SelectedItems[0].SubItems[2].Text;
                txtLocation.Text = lvBranch.SelectedItems[0].SubItems[3].Text;
                txtRemark.Text = lvBranch.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception ex) { 
                //MessageBox.Show(ex.Message);
            }

        }

        private void populateStoreValues()
        {
            try
            {

                txtStoreId.Text = lvStore.SelectedItems[0].SubItems[1].Text;
                cboBranchId.SelectedValue = lvStore.SelectedItems[0].SubItems[3].Text.Trim();
                cboBranchId.Text = lvStore.SelectedItems[0].SubItems[3].Text.Trim();
                txtStoreName.Text = lvStore.SelectedItems[0].SubItems[2].Text;
                txtStoreRemark.Text = lvStore.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
            }

        }

        private void populateShelfValues()
        {
            try
            {

                // clearValues();
                txtShelfId.Text = lvShelf.SelectedItems[0].SubItems[1].Text;
                txtShelfName.Text = lvShelf.SelectedItems[0].SubItems[2].Text;
                comboStoreId.SelectedValue = lvShelf.SelectedItems[0].SubItems[3].Text;
                txtShelfRemark.Text = lvShelf.SelectedItems[0].SubItems[4].Text;
            }
            catch (Exception ex) {// MessageBox.Show(ex.Message); 
            }

        }


        private void populateColumnValues()
        {
            try
            {

                // clearValues();
                txtColumnId.Text = lvColumn.SelectedItems[0].SubItems[1].Text;
                txtColumnDescription.Text = lvColumn.SelectedItems[0].SubItems[2].Text;
                cboShelfId.SelectedValue = lvColumn.SelectedItems[0].SubItems[3].Text;
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private void populateRowValues()
        {
            try
            {

                // clearValues();
                txtRowId.Text = lvRow.SelectedItems[0].SubItems[1].Text;
                txtRowDescription.Text = lvRow.SelectedItems[0].SubItems[2].Text;
                cboColumnId.SelectedValue = lvRow.SelectedItems[0].SubItems[3].Text;
            }
            catch (Exception ex) { //MessageBox.Show(ex.Message); 
            }

        }
        private void lvBranch_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lvBranch.SelectedItems.Count > 0)
            {
                try
                {

                       populateBranchValues();

                       oldBrId = "";
                     
                     bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                    fillComboOnChange();
                }
                catch (Exception ee)
                { MessageBox.Show(ee.Message); }

            }
        }
        
        private void lvStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStore.SelectedItems.Count > 0)
            {
                try
                {

                      populateStoreValues();

                      oldStId = "";

                      bolForNew = false;
                      if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                    fillComboOnChange();
                }
                catch (Exception ee)
                { //MessageBox.Show(ee.Message);
                }


            }
        }

        private void lvShelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvShelf.SelectedItems.Count > 0)
            {
                try
                {

                      populateShelfValues();

                      oldShId = "";

                       bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                    fillComboOnChange();
                }
                catch (Exception ee)
                { MessageBox.Show(ee.Message); }


            }
        }

        private void lvColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvColumn.SelectedItems.Count > 0)
            {
                try
                {

                     populateColumnValues();

                     oldColId = "";

                       bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                    fillComboOnChange();            
                    }
                catch (Exception ee)
                {  }


            }
        }

        private void lvRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRow.SelectedItems.Count > 0)
            {
                try
                {

                     populateRowValues();
                     fillComboOnChange();
                    
                     oldRowId = "";

                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                }
                catch (Exception ee)
                { }


            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddNew_Click(object sender, System.EventArgs e)
        {
            clearValues();
            getControlFocus();
            bolForNew = true;
            btnAddNew.Enabled = false;
            btnDelete.Text = "Cancel";
            fillComboOnChange();

            if (btnSave.Enabled == false) btnSave.Enabled = true;
            if (btnDelete.Enabled == false) btnDelete.Enabled = true;
        }
        private void clearValues()
        {
            foreach (Control Cont in tbBranchStore.SelectedTab.Controls)
                if (Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
                    Cont.Text = "";
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            bool isvalid = true;
            if (isvalid)//(isDataValid())
            {
                collectValues();
              
                if (checkControlValue()) 
              switch (tbBranchStore.SelectedTab.Text)
                {
                    case "  Branch  ":
                        if (!bolForNew)
                        {
                            objBranch.beginTransact();
                            try
                            {
                                objBranch.UpdateBranch();

                                objBranch.commitTransact();

                                //Refresh lst view
                                fillListView();

                                oldBrId = "";
                                


                            }
                            catch (Exception Exp)
                            {
                                objBranch.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Branches where BranchId = '" + objBranch.pBranchId + "'"))
                            {
                                objBranch.beginTransact();
                                try
                                {
                                    objBranch.addBranch();
                                    objBranch.commitTransact();
                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objBranch.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        break;

                    case "  Store   ":
                        if (!bolForNew)
                        {
                            objStore.beginTransact();
                            try
                            {
                                objStore.UpdateStore();

                                objStore.commitTransact();

                                //Refresh lst view
                                fillListView();

                                oldStId = "";

                            }
                            catch (Exception Exp)
                            {
                                objStore.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Stores where StoreId = '" + objStore.pStoreId + "'"))
                            {
                                objStore.beginTransact();
                                try
                                {
                                    objStore.addStore();
                                    objStore.commitTransact();
                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objStore.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    
                        break;

                    case "  Shelf   ":
                        if (!bolForNew)
                        {
                            objShelf.beginTransact();
                            try
                            {
                                objShelf.UpdateShelf();
                                 objShelf.commitTransact();

                                //Refresh lst view
                                fillListView();

                                oldShId = "";

                            }
                            catch (Exception Exp)
                            {
                                objShelf.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Shelfs where ShelfId = '" + objShelf.pshelfId + "'"))
                            {
                                objShelf.beginTransact();
                                try
                                {
                                    objShelf.addShelf();
                                    objShelf.commitTransact();
                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objShelf.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    
                        break;

                    case "  Column  ":
                        if (!bolForNew)
                        {
                            objColumn.beginTransact();
                            try
                            {
                                objColumn.UpdateColumn();
                                
                                objColumn.commitTransact();

                                //Refresh lst view
                                fillListView();

                                oldColId = "";

                            }
                            catch (Exception Exp)
                            {
                                objColumn.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Columns where ColumnId = '" + objColumn.pcolumnID + "'"))
                            {
                                objColumn.beginTransact();
                                try
                                {
                                    objColumn.addColumn();
                                    objColumn.commitTransact();
                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objColumn.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    
                        break;

                    case "  Row      ":
                            if (!bolForNew)
                            {
                                objRow.beginTransact();
                                try
                                {
                                    objRow.UpdateRow();

                                    objRow.commitTransact();

                                    //Refresh lst view
                                    fillListView();

                                    oldRowId = "";

                                }
                                catch (Exception Exp)
                                {
                                    objRow.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {		//Add New 
                                if (!objData.exists("SELECT * from Rows where RowId = '" + objRow.pRowID + "'"))
                                {
                                    objRow.beginTransact();
                                    try
                                    {
                                        objRow.addRow();
                                        objRow.commitTransact();
                                        bolForNew = false;
                                        btnAddNew.Enabled = true;
                                        fillListView();

                                    }

                                    catch (Exception Exp)
                                    {
                                        objRow.rollbackTransact();
                                        MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                    MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                    
                        break;
    

                }

            }

            fillComboOnChange();
            btnDelete.Text = "Delete";

        }
        private void collectValues()
        {

            //Branch
            if (tbBranchStore.SelectedTab.Text == "  Branch  ")
            {
                objBranch.pBranchId = this.txtBranchId.Text;
         //       if (oldBrId != "") objBranch.pBranchId = oldBrId;
                objBranch.pBranchName = this.txtBranchName.Text;
                objBranch.pLocation = this.txtLocation.Text;
                objBranch.pRemark = this.txtRemark.Text;


            }
            //Store
            else if (tbBranchStore.SelectedTab.Text == "  Store   ")
            {
                objStore.pStoreName = txtStoreName.Text;
        //        if (oldStId != "") objStore.pStoreId = oldStId;
                objStore.pStoreId = txtStoreId.Text;
                objStore.pRemark = txtStoreRemark.Text;
                objStore.pBranchId = (string)cboBranchId.SelectedValue;
                              

            }
            //Shelf
            else if (tbBranchStore.SelectedTab.Text == "  Shelf   ")
            {
                objShelf.pshelfId = txtShelfId.Text;
          //      if (oldShId != "") objShelf.pshelfId = oldShId;
                objShelf.pshelfName = txtShelfName.Text;
                objShelf.pRemark = txtShelfRemark.Text;
                objShelf.pstoreId = (string)comboStoreId.SelectedValue;




            }//Column
            else if (tbBranchStore.SelectedTab.Text == "  Column  ")
            {
                objColumn.pcolumnID = txtColumnId.Text;
       //         if (oldColId != "") objColumn.pcolumnID = oldColId;
                objColumn.pDescription = txtColumnDescription.Text;
                objColumn.pshelfId = (string)cboShelfId.SelectedValue;



            }
            //Row
            else
            {
                objRow.pRowID = txtRowId.Text;
      //          if (oldRowId != "") objRow.pRowID = oldRowId;
                objRow.pDescription = txtRowDescription.Text;
                objRow.pcolumnId = (string)cboColumnId.SelectedValue;



            }


        }
        public void disableButtons()
        {
            bolReadOnly = true;
            btnAddNew.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
      
        public bool isDataValid(Control ctrlName)
        {

            foreach (Control Cont in ctrlName.Controls)
            {
                if (Cont.Tag != null)
                {
                    if (Cont.Tag.ToString().StartsWith("REQ-") && Cont.Text.Trim().Equals(""))
                    {
                        MessageBox.Show(Cont.Tag.ToString().Substring(4), "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cont.Focus();
                        return false;
                    }
                }

                else
                {
                    ListBox lstBx = (System.Windows.Forms.ListBox)Cont;
                    if (Cont.Tag.ToString().StartsWith("REQ-") && lstBx.Items.Count == 0)
                    {
                        MessageBox.Show(Cont.Tag.ToString().Substring(4), "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cont.Focus();
                        return false;
                    }
                }
            }

            return true;
        }
        private void getControlFocus()
        {
            if (tbBranchStore.SelectedTab.Text == "  Branch  ")
                txtBranchId.Focus();
            else if (tbBranchStore.SelectedTab.Text == "  Store   ")
                txtStoreId.Focus();
            if (tbBranchStore.SelectedTab.Text == "  Shelf   ")
                txtShelfId.Focus();
            else if (tbBranchStore.SelectedTab.Text == "  Column  ")
                txtColumnId.Focus();
         
            else
                txtRowId.Focus();
        }
        private bool checkControlValue()
        {
            bool ret = false;

            if (tbBranchStore.SelectedTab.Text == "  Branch  " && txtBranchId.Text == "")
                MessageBox.Show("Branch must have Branch Id", " Belayab ");
            else if (tbBranchStore.SelectedTab.Text == "  Store   " && txtStoreId.Text == "")
                MessageBox.Show("Store must have store Id", " Belayab ");
            if (tbBranchStore.SelectedTab.Text == "  Shelf   " && txtShelfId.Text == "")
                MessageBox.Show("Shelf must have Shelf Id", " Belayab ");
            else if (tbBranchStore.SelectedTab.Text == "  Column  " && txtColumnId.Text == "")
                MessageBox.Show("Column must have Column Id", " Belayab ");

            else if (tbBranchStore.SelectedTab.Text == "  Row      " && txtRowId.Text == "")
                MessageBox.Show("Row must have Row Id", " Belayab ");
            else
                ret = true;

            getControlFocus();
            
            return ret;

        }

        public Boolean deletedListview()
        {
            Boolean reValue = false;
            
            if (tbBranchStore.SelectedTab.Text == "  Branch  ")
            {
                if (lvBranch.SelectedItems.Count > 0)
                    reValue = true;
            }
            else if (tbBranchStore.SelectedTab.Text == "  Store   ")
            {
                if (lvStore.SelectedItems.Count > 0)
                    reValue = true;
            } 
            else if (tbBranchStore.SelectedTab.Text == "  Shelf   ")
            {
                if (lvShelf.SelectedItems.Count > 0)
                    reValue = true;
            }
            else if (tbBranchStore.SelectedTab.Text == "  Column  ")
            {
                if (lvColumn.SelectedItems.Count > 0)
                    reValue = true;
            }
            else
            {
                if (lvRow.SelectedItems.Count > 0)
                    reValue = true;
            }
            return reValue;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (deletedListview() && btnDelete.Text== "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete?", "Stosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        collectValues();
                        if (tbBranchStore.SelectedTab.Text == "  Branch  ")
                        {
                            objBranch.deleteBranch();
                            lvBranch.SelectedItems[0].Remove();
                            if (lvBranch.Items.Count > 0) lvBranch.Items[0].Selected = true;
                            populateBranchValues();
                            clearValues();
                        }
                        if (tbBranchStore.SelectedTab.Text == "  Store   ")
                        {
                            objStore.deleteStore();
                            lvStore.SelectedItems[0].Remove();
                            if (lvStore.Items.Count > 0) lvStore.Items[0].Selected = true;
                            populateStoreValues();
                            clearValues();
                        }
                        if (tbBranchStore.SelectedTab.Text == "  Shelf   ")
                        {
                            objShelf.deleteShelf();
                            lvShelf.SelectedItems[0].Remove();
                            if (lvShelf.Items.Count > 0) lvShelf.Items[0].Selected = true;
                            populateShelfValues();
                            clearValues();

                        }

                        if (tbBranchStore.SelectedTab.Text == "  Column  ")
                        {
                            objColumn.deleteColumn();
                            lvColumn.SelectedItems[0].Remove();
                            if (lvColumn.Items.Count > 0) lvColumn.Items[0].Selected = true;
                            populateColumnValues();
                            clearValues();
                        }
                        if (tbBranchStore.SelectedTab.Text == "  Row      ")
                        {
                            objRow.deleteRow();
                            lvRow.SelectedItems[0].Remove();
                            if (lvRow.Items.Count > 0) lvRow.Items[0].Selected = true;

                            populateRowValues();
                            clearValues();
                        }

                    }
                }
                fillListView();
                btnDelete.Text = "Delete";

            }
            catch (Exception ee)
            {
            }
        }

       
   
      
        private void fillComboOnChange()
        {
            try
            {
     
                //Store
                strSQL = "Select Distinct BranchId, BranchName From Branches Order by BranchName";
                objUtility.fillComboValues(cboBranchId, strSQL);
                cboBranchId.DisplayMember = "BranchName";
                cboBranchId.ValueMember = "BranchId";
                //Shelf
                strSQL = "Select Distinct StoreId,StoreName From Stores Order By StoreName";
                objUtility.fillComboValues(comboStoreId, strSQL);

                //Column
                strSQL = "Select Distinct ShelfId, ShelfName From Shelfs Order By ShelfName";
                objUtility.fillComboValues(cboShelfId, strSQL);
                //Row
                strSQL = "Select Distinct ColumnId,Description From Columns Order By Description";
                objUtility.fillComboValues(cboColumnId, strSQL);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void tbBranchStore_TabIndexChanged(object sender, EventArgs e)
        {

            fillComboOnChange();
        }

       
        private void txtBranchId_Enter(object sender, EventArgs e)
        {
            if (oldBrId == "") oldBrId = txtBranchId.Text;

        }

        private void txtStoreId_Enter(object sender, EventArgs e)
        {
            if (oldStId  == "") oldStId = txtStoreId.Text;
        }

        private void txtShelfId_TextChanged(object sender, EventArgs e)
        {
            if (oldShId == "") oldBrId = txtShelfId.Text;
        }

        private void txtColumnId_Enter(object sender, EventArgs e)
        {
            if (oldColId  == "") oldColId = txtColumnId.Text;
        }

        private void txtRowId_Enter(object sender, EventArgs e)
        {
            if (oldRowId == "") oldRowId = txtRowId.Text;
        }

        private void frmBranch_Stores_Resize(object sender, EventArgs e)
        {

            tbBranchStore.Height = this.Height -  grp2.Height;

            lvBranch.Height = tbBranchStore.Height - grp2.Height-5;
            lvShelf.Height = lvBranch.Height;
            lvStore.Height = lvBranch.Height;
            lvColumn.Height = lvBranch.Height;
            lvRow.Height = lvBranch.Height;
            
            grp1.Height = this.Height- grp2.Height;


            //tbpBranch.Height = lvBranch.Height; 
            //tbpStore.Height = tbpShelf.Height = tbpColumn.Height =
            //    tbpRow.Height = lvBranch.Height ;
        }

        

            

    }
}

       

       
    
