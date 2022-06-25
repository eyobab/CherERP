using System;
using System.Data;
using System.Windows.Forms;
using System.Security;

namespace Belayab
{
	/// <summary>
	/// Summary description for clsJudgePresident.
	/// </summary>
	public class clsSecurity
	{
		
		public string pFullName;
		public string pUserRole;

		public string pUserName;
		public string pPassword;
		public int pIsAdmin;
        public bool isEmployee;
        public string pEmployeeId;
        
        //0 For No, 1 For Yes


        clsData objData = clsData.Instance;

		clsUtility objUtility=new clsUtility();

		public clsSecurity()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		
		public void addUser()
		{
			string strFields="FullName, UserName,RoleID, Password, IsAdministrator, isEmployee, EmployeeId";
			//string strValues =pFullName+","+ pOccupation + ","+ pUserName +","+pPassword+","+pIsAdmin;			
			pPassword=objUtility.getHashedValue(pPassword);
            string strValues = "'" + pFullName + "','" + pUserName.ToUpper() + "','" + pUserRole + "','" + pPassword + "','" + pIsAdmin + "', '" + isEmployee + "','" + pEmployeeId + "'";
            
			objData.addNewRecord("Users",strFields,strValues,true);
			
		}

		public void addUserRight()
		{
           
		}

		public void deleteUserRight()
		{
           
		}

		public void updateUser()
		{
            string strValues;
            string strWhere =" rTrim(UserName) like '" +Program.sFrm.oldUName.ToUpper() + "%'";			
            string strFields = "FullName,UserName, [RoleID],password, IsAdministrator, IsEmployee, EmployeeId";
            
                strValues = "'" + pFullName + "','" + pUserName.ToUpper() + "','" + pUserRole + "','" + objUtility.getHashedValue(pPassword) + "','" + pIsAdmin + "', '" + isEmployee + "','" + pEmployeeId + "'";

          
            objData.updateRecord("Users",strFields,strValues,strWhere, true);			
		}

		public bool isPasswordCorrect(string strOldPword)
		{	
			strOldPword=objUtility.getHashedValue(strOldPword);
			string strWhere ="SELECT * FROM Users WHERE rTrim(UserName) like '" +pUserName.ToUpper() + "' AND rTrim(Password)  like '" + strOldPword +"'";
			bool bolIsValid =	objData.exists(strWhere);
			return bolIsValid;
		}
		public void updatePassword()
		{	
				string strWhere =" rTrim(UserName) like '" +pUserName.ToUpper() + "'";			
				string strFields="Password";
				string strValues =objUtility.getHashedValue(pPassword);
			
				objData.updateRecord("Users",strFields,strValues,strWhere, true);			
			
		}

        public void updateNonPassword()
        {
            string strWhere = " rTrim(UserName) like '" + pUserName.ToUpper() + "'";
            string strFields = "Password";
            string strValues = objUtility.getHashedValue(pPassword);

            objData.updateRecord("Users", strFields, strValues, strWhere, true);

        }


        public void deleteUser()
		{	
			string strWhere =" rTrim(UserName) like '" +pUserName + "'";			
			//objData.deleteRecord("UsersRight",strWhere);
			objData.deleteRecord("Users",strWhere);
			
		}

		public DataTable getUsers()
		{	
			DataTable dtblUser = new DataTable();
			DataRow drowUser;

            dtblUser.Columns.Add("FullName");
			dtblUser.Columns.Add("UserName");
            dtblUser.Columns.Add("UserRole");
            dtblUser.Columns.Add("Password");
            dtblUser.Columns.Add("IsAdministrator");
            dtblUser.Columns.Add("IsEmployee");
            dtblUser.Columns.Add("EmployeeId");


            string strSQL = "SELECT FullName,UserName,RoleID As [RoleID],Password,IsAdministrator,isEmployee, EmployeeID FROM Users Order By UserName";
		
			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
				drowUser = dtblUser.NewRow();
				drowUser[0] = vals[i,0].ToString();
				drowUser[1] = vals[i,1].ToString();
                drowUser[2] = vals[i,2].ToString();
                drowUser[3] = vals[i,3].ToString();
                drowUser[4] = vals[i,4].ToString();
                drowUser[5] = vals[i, 5].ToString();
                drowUser[6] = vals[i, 6].ToString();

				dtblUser.Rows.Add(drowUser);
			}
			return dtblUser;
		}
		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
		}

		public string getDistinctVal(string strSQL)
		{
			string val = objData.getFieldValue(strSQL);
			return val;
		}

		public void getUserInfo()			
		{	
			string strSQL="SELECT * FROM Users Where rTrim(UserName)  like '" + pUserName.ToUpper() +"'";
			string[,] vals = objData.getRecords(strSQL);
			
			if (vals.GetLength(0) > 0)
			{	
				pFullName = vals[0,0].ToString();
			    pUserName = vals[0, 1].ToString();
                pUserRole = vals[0, 2].ToString();
                pPassword = objUtility.getHashedValue(vals[0, 3].ToString());
                isEmployee = bool.Parse(vals[0, 7].ToString());
                pEmployeeId = vals[0, 8].ToString();

            //    for (int i = 4; i< 9; i++)
            //                  MessageBox.Show ( i.ToString() + "th Column:  " + vals[0,i].ToString());
            ////	pIsAdmin = Convert.ToInt32(vals[0,4].ToString());
			}			
		}
        public string EmployeeDept(string empID)
        {
            string strSQL = "SELECT Departments.DepartmentName FROM  Departments INNER JOIN  Employees ON " +
                " Departments.DepartmentId = Employees.DepartmentId Where Employees.EmployeeId  like '" + empID.ToUpper() + "'"; // AND IsAdministrator =1";
            return objData.getFieldValue(strSQL);
        }
        public string GetUserEmployeeId(string usrNam)
        {
            string strSQL = "SELECT EmployeeId FROM Users Where rTrim(UserName)  like '" + usrNam.ToUpper() + "'"; // AND IsAdministrator =1";
            return objData.getFieldValue(strSQL);
        }
        
        
        public bool IsAdmin(string usrNam)
		{
			string strSQL="SELECT * FROM Users Where rTrim(UserName)  like '" + usrNam.ToUpper() + "' AND IsAdministrator =1";
			return objData.exists(strSQL);
		}

        public bool IsEmployee(string usrNam)
        {
            string strSQL = "SELECT * FROM Users Where rTrim(UserName)  like '" + usrNam.ToUpper() + "' AND isEmployee =1";
            return objData.exists(strSQL);
        }


		public bool IsUsrNamPsWdValid(string usrNam, string passWd)
		{
			passWd=objUtility.getHashedValue(passWd);
			string strSQL="SELECT UserName FROM Users Where rTrim(UserName)  like '" + usrNam.ToUpper()+"'" +
							" AND rTrim(Password)  like '"+ passWd +"'"; 
			return objData.exists(strSQL);
		}

		public bool IsUserAllowedFor(string functName)
		{
			bool bolRetVal =false;
			string strSQL="SELECT FunctionalityName FROM UsersRight Where rTrim(UserName)  like '" + pUserName.ToUpper()+
							"' AND rTrim(FunctionalityName)  like '" + functName+"'" ;
			string val = objData.getFieldValue(strSQL);

			if (!val.Equals("")) 	bolRetVal=true;

			return bolRetVal;
		}
		public string getAccessLevl(string userNam, string functName)
		{
			string strSQL="SELECT AccessLevel FROM UsersRight Where rTrim(UserName)  like '" + userNam.ToUpper()+
							"' AND rTrim(FunctionalityName)  like '" + functName+"'" ;
			string val = objData.getFieldValue(strSQL);
			return val;
		}

		public bool executeCommand(string strSQL)
		{
			return objData.executeCommand(strSQL);
		}

        public void setRolePermissions(Form frm)
        {
            clsVariables.allow = false;

            switch (clsVariables.userRole.Trim())
            {
                case "Store":
                case "Inventory":
                case "Approver":
                    {
                        switch (frm.Name)
                        {
                            case "frmGoodReceivedNote":
                            case "frmIssue":
                            case "frmMaintenanceHome":
                            case "frmCustomersSuppliers":
                            case "frmCustomerTypes":
                            case "frmDepartment_Employees":
                            case "frmItemEdit":
                            case "frmItemsLst":
                            case "frmRequisitionsHome":
                            case "frmStoreHome":
                            case "frmTransfer":
                            case "frmViewGroupAll":
                            case "frmItemDetails":
                            case "nfrmCostPriceHistory":
                            case "frmBranch_Stores":
                            case "frmItemCategory":
                            case "frmItemRequisitions":
                                setFormPermissions(frm, true);
                                clsVariables.allow = true;
                              break;
                            default:
                                setFormPermissions(frm, false);
                              clsVariables.allow = false;
                              break;
                          }

                          
                    }
                    break;
                case "Finance":
                case "Sales":
                    {
                        switch (frm.Name)
                        {

                            case "frmMaintenanceHome":
                            case "frmCustomersSuppliers":
                            case "frmCustomerTypes":
                            case "frmDepartment_Employees":
                            case "frmItemEdit":
                            case "frmItemsLst":
                            case "frmRequisitionsHome":
                            case "frmStoreHome":
                            case "frmTransfer":
                            case "frmViewGroupAll":
                            case "frmItemDetails":
                            case "nfrmCostPriceHistory":
                            case "frmBranch_Stores":
                            case "frmItemCategory":
                            case "frmItemRequisitions":
                            case "frmInvoices":
                            case "frmAdvaceLoan":
                            case "frmCreditPayments":
                            case "frmMaintenanceReport": 
                          

                               setFormPermissions(frm, true);
                                clsVariables.allow = true;
                                break;
                            default:

                                setFormPermissions(frm, false);
                                clsVariables.allow = false;
                                break;
                        }
                    }
                    break;
                case "CustomerService":
                    {
                        switch (frm.Name)
                        {
                            case "frmMaintenanceHome":
                            case "frmCustomersSuppliers":
                            case "frmCustomerTypes":
                            case "frmDepartment_Employees":
                            case "frmItemEdit":
                            case "frmItemsLst":
                            case "frmRequisitionsHome":
                            case "frmStoreHome":
                            case "frmTransfer":
                            case "frmViewGroupAll":
                            case "frmItemDetails":
                            case "nfrmCostPriceHistory":
                            case "frmBranch_Stores":
                            case "frmItemCategory":
                            case "frmItemRequisitions":
                            case "frmInvoices":
                            case "frmAdvaceLoan":
                            case "frmCreditPayments":
                            case "frmVehicleMaintenance":
                            case "frmMaintenanceHomeCS":
                            case "frmMaintenanceReport":  
                                setFormPermissions(frm, true);
                                clsVariables.allow = true;
                                break;
                            default:

                                setFormPermissions(frm, false);
                                clsVariables.allow = false;
                                break;
                        }
                    }
                    break;

                case "Admin":
                case "Management":
                    setFormPermissions(frm, true);
                    clsVariables.allow = true;
                    break;

                default:
               
                    setFormPermissions(frm, false );
                    clsVariables.allow = false ;
                    break;
                    
            }
            if (frm.Name == "frmGoodReceivedNote" && clsVariables.userRole.Trim()!="Admin")
            {
                frmGoodReceivedNote f = (frmGoodReceivedNote)frm;
               // f.setPermissions();
            }






        }

        public static void setMainPermissions()
        {
            //if (clsVariables.userRole == "Admin")
            //{
                
            // //   Program.mainFrm.Maintainance.Visible = true;
            //}
            //else if (clsVariables.userRole == "Store")
            //{
            //    Program.mainFrm.Storage.Enabled = true;
            //    Program.mainFrm.CustomersSuppliers.Enabled = true;
            //    Program.mainFrm.InvoiceNumbers.Enabled = true;
            //}
            //else if (clsVariables.userRole == "Sales" || clsVariables.userRole == "Finance")
            //{
            //    Program.mainFrm.CustomersSuppliers.Enabled = true;
            //    Program.mainFrm.InvoiceNumbers.Enabled = true;
            //}
            //else if (clsVariables.userRole == "Maintenance")
            //    Program.mainFrm.Maintainance.Visible = true;


        }
        public void setFormPermissions(Control ctl, bool val)
        {
            try
            {
                val = true;  // TO BE REMOVED *******************************************************************************

                String cName = ctl.GetType().Name;
                if (cName.Equals("ListView") || cName.Equals("DataGridview"))
                {
                    Control CC = (Control) ctl.GetContainerControl();
                    CC.Enabled = true;
                    ctl.Enabled = true;
                }
                foreach (Control Cont in ctl.Controls)
                {
                            Cont.Enabled = val;
                            foreach (Control cCont in ctl.Controls)
                                  if (Cont.Name != "storeIDComboBox") setFormPermissions(cCont, val);
                    
                   if (Cont.GetType().Name.Equals("BindingNavigator"))
                           setNavPermissions((BindingNavigator)Cont, val);
                   if (Cont.GetType().Name.Equals("Panel"))
                       setFormPermissions((Panel)Cont, val);

                }
                
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        public bool userHasSuperPermission()
        {

            return (clsVariables.curUserName == "ADMIN" || clsVariables.curUserName == "TENSAE" ||
                         clsVariables.curUserName == "YARED" || clsVariables.curUserName == "BELAYAB" ||
                         clsVariables.curUserName == "TAYE" || clsVariables.curUserName == "TEFERA" || clsVariables.curUserName == "METSEHET");
            
        }

        private void setNavPermissions(BindingNavigator nav, bool val)
        {

            for (int i = 0; i < nav.Items.Count; i++)
                nav.Items[i].Enabled = val;
            
        }

        public void setCommonPermissionsMain( 
            ToolStripButton btnAdd,
            ToolStripButton btnSave,
            ToolStripButton btnDelete,
            ToolStripButton btnPrint,
            bool val)
                {
                    btnAdd.Enabled = val;
                    btnDelete.Enabled = val;
                    btnSave.Enabled = val;
                    btnPrint.Enabled = val;
                }


        public void setCommonPermissionsDetail(
         ToolStripButton btnAdd,
         ToolStripButton btnSave,
         ToolStripButton btnDelete,
         DataGridView dv,
         bool val)
        {
            btnAdd.Enabled = val;
            btnDelete.Enabled = val;
            btnSave.Enabled = val;
            if (dv != null)
            {
                dv.Enabled = true;
                dv.ReadOnly = !val;
            }
        }

        public string getUserRole(string USerName)
        {
            return objData.getUserRole(USerName);
        }

		public void beginTransact()
		{
			objData.beginTransact();
		}

		public void commitTransact()
		{
			objData.commitTransact();
		}

		public void rollbackTransact()
		{
			objData.rollbackTransact();
		}
	}
}
