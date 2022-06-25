using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace Belayab
{
    public partial class frmLoginScreen : Form
    {
        //CLASS VARIABLES
        private XmlDocument doc;
        private XmlElement root;
        private XmlElement currentElement;

        private clsData objData;
               
        public frmLoginScreen(){InitializeComponent();}


        private void LoginScreen_Activated(object sender, EventArgs e) { txtUserName.Focus(); }

        private void bttnCancel_Click(object sender, EventArgs e) { 
            Application.Exit();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            try
            {
             

                clsVariables.sServer = txtServerHost.Text;
                clsVariables.sDatabase = "SysBab";
                clsVariables.sDBUserID = "Sa"; //txtUserName.Text.Trim();
                clsVariables.sDBPassword = "goodwork";// txtPassword.Text.Trim(); ;
                clsVariables.curUserName = txtUserName.Text;

       
                Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                MainForm.strUserName = txtUserName.Text;


                Cursor.Current = System.Windows.Forms.Cursors.Default;
                clsSecurity objSecurity = new clsSecurity();

                if (objSecurity.IsUsrNamPsWdValid(txtUserName.Text, txtPassword.Text))
                {
                    Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
                    MainForm.strUserName = txtUserName.Text;
                    clsVariables.userRole = clsData.Instance.getUserRole(txtUserName.Text.Trim());
                    clsVariables.sUsername = txtUserName.Text.Trim();
                    
                   
                    clsVariables.curUserName = txtUserName.Text.ToUpper();
                    clsVariables.sUserIsEmployee = objSecurity.IsEmployee(txtUserName.Text.Trim());
                    clsVariables.sUserEmployeeId = objSecurity.GetUserEmployeeId(txtUserName.Text.Trim());

                    if (clsVariables.sUserIsEmployee)
                    {
                        objData = clsData.Instance;
                        clsVariables.sEmployeeDepartment = objSecurity.EmployeeDept(clsVariables.sUserEmployeeId);
                        clsVariables.sUserEmployeeName = objData.getFieldValue("Select EmployeeName from Employees Where EmployeeId='" + clsVariables.sUserEmployeeId + "'");

                    }
                    else
                        clsVariables.sEmployeeDepartment = "ADMIN";


                    UpdateUserLocation();

                    this.Visible = false;
                    //MainForm fm = new MainForm();
                    Program.mainFrm = new MainForm();
                    Program.mainFrm.Show();
                                     
                    
                    clsSecurity.setMainPermissions();

                  


                    //frmGoodReceivedNote fm = new frmGoodReceivedNote();
                    //   fm.Show();

                }
                else
                {
                    MainForm.strUserName = "";
                    MessageBox.Show("Your User name or Password is incorrect, Try again", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error );

                }

 
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                }
            
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            try
            {
                doc = new XmlDocument();
                doc.Load("DB.XML");

                //Get root element
                root = doc.DocumentElement;

                //Get the record at the current index
                currentElement = (XmlElement)root.ChildNodes[0];

                //User the serverhost information
                txtServerHost.Text = currentElement.Attributes["Name"].Value;
                clsVariables.sStore = currentElement.Attributes["Loc"].Value;

               
             
                //if (DateTime.Today.ToShortDateString().CompareTo("5/14/2012")>=0)
                //        {
                //            currentElement.Attributes["Name"].Value = "12";

                //            doc.Save("DB.XML");
                //        }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not Initialize the Data Sources!", "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

         }

        private void UpdateUserLocation()
        {

            string strSQL = "";

            if (objData == null) objData = new Belayab.clsData(); 

            if (clsVariables.curUserName.ToUpper() != "ADMIN")
            {
                //strSQL = "Select EmployeeId from Users Where UserName='" + clsVariables.curUserName.ToUpper() + "'";
                //clsVariables.sUserEmployeeId = objData.getFieldValue(strSQL);
                if(clsVariables.sUserEmployeeId!="")
                {
                    strSQL = "Select StoreID from Employees Where EmployeeID='" + clsVariables.sUserEmployeeId + "'";
                    clsVariables.sStore = objData.getFieldValue(strSQL);
                }
            }

           
        }
    }
}