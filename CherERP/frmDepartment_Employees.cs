using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using Belayab.Reports;

namespace Belayab
{
    public partial class frmDepartment_Employees : Form
    {
        
        public clsDepartment objDept = new clsDepartment();
        public clsEmployee objEmp = new clsEmployee();
        public DataSet dsPhoto = new DataSet();
        private clsImage objImage = new clsImage();


        public string photopath = Application.StartupPath + "\\Photo.jpg";



        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();


        public int selectedId = 0;
        public bool bolForNew = false;
        public bool bolReadOnly = false;
        private string strSQL = "";

        public frmDepartment_Employees()
        {
            InitializeComponent();
            
        }



        private void fillListView()
        {
            DataTable dtData;

            try
            {
                dtData = objDept.getAllDepartments();
                objUtility.FillListViewData(lvDepartment, dtData, 3);

           
                //dtData = objEmp.getAllEmployees();

                dtData = dsEmployees.Tables["Employees"];
                objUtility.FillListViewData(lvEmployee, dtData, 6);
          }

            catch (Exception ex) { }


        }

        private void populateDepartmentValues()
        {
            try
            {

                clearValues();
                txtDepartmentId.Text = lvDepartment.SelectedItems[0].SubItems[1].Text;
                txDepartmentName.Text = lvDepartment.SelectedItems[0].SubItems[2].Text;
                txtHead.Text = lvDepartment.SelectedItems[0].SubItems[3].Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void populateEmployeeValues()
        {
            try
            {

                //DisplayPhoto(photopath);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Stosa"); }

        }

        private void clearValues()
        {
            foreach (Control Cont in tabEmployee.SelectedTab.Controls)
                if (Cont.GetType().Name.Equals("TextBox") || Cont.GetType().Name.Equals("ComboBox"))
                    Cont.Text = "";

        }



        private void lvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmployee.SelectedItems.Count > 0)
            {
                try
                {

                    //selectedId = Int32.Parse(lvBranch.SelectedItems.[0].Text);

                  employeesBindingSource.Position = lvEmployee.SelectedItems[0].Index;
       //           MessageBox.Show(dsEmployees1.Tables["Employees"].Rows[lvEmployee.SelectedItems[0].Index]["StoreId"].ToString());

                    populateEmployeeValues();

                    //    bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;


                }
                catch (Exception ee)
                { MessageBox.Show(ee.Message); }


            }
        }

        private void lvDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDepartment.SelectedItems.Count > 0)
            {
                try
                {

                    //selectedId = Int32.Parse(lvBranch.SelectedItems.[0].Text);
                    populateDepartmentValues();

                    //    bolForNew = false;
                    if (btnAddNew.Enabled == false) btnAddNew.Enabled = true;
                    if (btnSave.Enabled == false) btnSave.Enabled = true;
                    if (btnDelete.Enabled == false) btnDelete.Enabled = true;
                }
                catch (Exception ee)
                { }


            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            clearValues();
            bolForNew = true;
            btnAddNew.Enabled = false;
            getControlFocus();

            if (btnSave.Enabled == false) btnSave.Enabled = true;
            if (btnDelete.Enabled == false) btnDelete.Enabled = true;

            if (tabEmployee.SelectedTab.Text == "Employee")
            {
                this.BindingContext[dsEmployees, "Employees"].AddNew();
                imgPhoto.Image = null;

            }
        }
        private void getControlFocus()
        {
            if (tabEmployee.SelectedTab.Text == "Department")
                txtDepartmentId.Focus();
            else
                txtEmployeeId.Focus();
        }
        private void collectValues()
        {
            if (tabEmployee.SelectedTab.Text == "Department")
            {
                objDept.DepartmentId = this.txtDepartmentId.Text;
                objDept.DepartmentName = this.txDepartmentName.Text;
                objDept.Head = this.txtHead.Text;



            }
            else
            {
                objEmp.EmployeeId = txtEmployeeId.Text;
                objEmp.EmployeeName = txtEmployeeName.Text;
                objEmp.DepartmentId = cboEmpDepartmentId.SelectedValue.ToString();
                objEmp.Woreda = txtWorda.Text;
                objEmp.Kebele = txtKebele.Text;
                objEmp.storeID = storeIDComboBox.Text;

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isvalid = true;
            if (isvalid)//(isDataValid())
            {
                collectValues();


                switch (tabEmployee.SelectedTab.Text)
                {
                    case "Department":
                        if (!bolForNew)
                        {
                      //      objDept.beginTransact();
                            try
                            {
                                objDept.UpdateDepartment();
                        //        objDept.commitTransact();

                                fillListView();

                            }
                            catch (Exception Exp)
                            {
                         //       objDept.rollbackTransact();
                                MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        else
                        {		//Add New 
                            if (!objData.exists("SELECT * from Departments where DepartmentId = '" + objDept.DepartmentId + "'"))
                            {
                                objDept.beginTransact();
                                try
                                {
                                    objDept.addDepartment();
                                    objDept.commitTransact();

                                    bolForNew = false;
                                    btnAddNew.Enabled = true;
                                    fillListView();

                                }

                                catch (Exception Exp)
                                {
                                    objDept.rollbackTransact();
                                    MessageBox.Show(Exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                MessageBox.Show("Successfully Saved", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                                MessageBox.Show("This Record already exists", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                        break;




                    case "Employee":
                        //bsPhoto.Position = lvEmployee.SelectedItems[0].Index;

                        UpadateAll();

                       // dsEmployees1.Clear();
                       // daSql.Fill(dsEmployees1, "Employees");
                       
                       // DisplayPhoto(photopath);

                       // //Refresh lst view
                       //fillListView();
                        break;

                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvDepartment.SelectedItems.Count > 0 || lvEmployee.SelectedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure to delete?", "Stosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        collectValues();

                        if (tabEmployee.SelectedTab.Text == "Department")
                        {
                            objDept.deleteDepartemnt();
                            lvDepartment.SelectedItems[0].Remove();
                            if (lvDepartment.Items.Count > 0) lvDepartment.Items[0].Selected = true;

                        }
                        if (tabEmployee.SelectedTab.Text == "Employee")
                        {
                           
                            objEmp.deleteEmployee();

                           
                             daSql.Update(dsEmployees);
                            
                              dsEmployees.Clear();
                              daSql.Fill(dsEmployees, "Employees");
                            
                              DisplayPhoto(photopath);

                            lvEmployee.SelectedItems[0].Remove();
                            if (lvEmployee.Items.Count > 0) lvEmployee.Items[0].Selected = true;


                        }

                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepartment_Employees_Load(object sender, EventArgs e)
        {
            

            try
            {
                employeesTableAdapter.Connection = clsData.connBel;
                departmentLstTableAdapter.Connection = clsData.connBel;
                i_StoreListTableAdapter.Connection = clsData.connBel;
  
                // TODO: This line of code loads data into the 'dsEmployees1.I_StoreList' table. You can move, or remove it, as needed.
                this.i_StoreListTableAdapter.Fill(this.dsEmployees.I_StoreList);
                // TODO: This line of code loads data into the 'dsEmployees.Employees' table. You can move, or remove it, as needed.
                this.employeesTableAdapter.Fill(this.dsEmployees.Employees);
                // TODO: This line of code loads data into the 'belayAbItemRequistions.DepartmentLst' table. You can move, or remove it, as needed.
                this.departmentLstTableAdapter.Fill(this.belayAbItemRequistions.DepartmentLst);
             

                tabEmployee.Width = this.Width;
                tabEmployee.Height = this.Height;

                fillListView();

                if (clsVariables.curUserName.ToUpper() != "ADMIN") storeIDComboBox.Enabled = false;



            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "LOAD"); }

        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {

            try
            {
                openDlg.FileName = "";

                openDlg.ShowDialog();


                photopath = openDlg.FileName;

                if (photopath == "") return;
                // 'Then add  the photo to the dataset
                
                //***************
                //SavePhoto(photopath, dsEmployees1, "Photo");

                objImage.SavePhotoToDB(ref photopath, dsEmployees.Tables[0], "Photo",
                    this.BindingContext[dsEmployees, "Employees"].Position);

                //'And display the new photo

                //***********************
                DisplayPhoto(photopath);

  
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Photo Saveing Displaying"); }



        }


        public void DisplayPhoto(string path)
        {

              objImage.getImageToFile(dsEmployees.Tables[0], "Photo", ref path,
                    this.BindingContext[dsEmployees, "Employees"].Position);
            

            if (path != "")
                imgPhoto.Load(path);
            else
                imgPhoto.Image = imgPhoto.InitialImage;

        }

       
       

        private void bsPhoto_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            //  MessageBox.Show(e.Exception.Message, "Binding");
        }

        private void UpadateAll()
        {
            try
            {
                this.Validate();
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(dsEmployees.Employees);

                if (!dsEmployees.HasChanges())
                    MessageBox.Show("Successfully Saved", "Save...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error occured in updating Photo(s)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEmployeePrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from EmployeeList where EmployeeId = '" +
                txtEmployeeId.Text + "'";

            frmv.SetReport(new rptEmployeeList(), strSQL, "EmployeeList");

            Program.mainFrm.OpenOverFrm(frmv);


        }

        private void btnPrintAllEmployee_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from EmployeeList";

            frmv.SetReport(new rptEmployeeList(), strSQL, "EmployeeList");

            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void imgPhoto_Click(object sender, EventArgs e)
        {

        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}