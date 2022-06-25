using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
    public class clsDepartment
    {
        public string DepartmentId;
        public string DepartmentName;
        public string Head;
		

		clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();

        public clsDepartment()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void addDepartment()
		{
			string strFields="";
			string strValues="";
            strFields = "DepartmentId,DepartmentName,Head";
            strValues = "'"+DepartmentId + "','" + DepartmentName + "','" + Head+"'";
            objData.addNewRecord("Departments", strFields, strValues, true );
			
		}

        public void UpdateDepartment()
        {
            string strFields = "";
            string strValues = "";
            string others;


            strFields = "DepartmentId,DepartmentName,Head";
            strValues = "'" + DepartmentId.Trim() + "','" + DepartmentName + "','" + Head + "'";

          //  strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            others = "";

            string strWhere = "DepartmentId ='" + DepartmentId.Trim() + "'";
           
            objData.updateRecord("Departments", strFields, strValues, others, strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteDepartemnt()
        {
            string strWhere = "DepartmentId ='" + DepartmentId + "'";

            objData.deleteRecord("Departments", strWhere);

        }

		public DataTable getAllDepartments()
		{	
			DataTable dtDepartment = new DataTable();


            string[] strFields = { "DepartmentId", "DepartmentName", "Head" };

            objData.fillDataTable (dtDepartment, strFields,"Departments");
            
            return dtDepartment ;

		}

		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
		}

        public clsDepartment getDepartment(string brID)
        {
            SqlDataReader reader;
            clsDepartment brnch = new clsDepartment();
            string strSQL = "";

            strSQL = "SELECT DepartmentId, DepartmentName, Head,Remark FROM Departments where DepartmentId=" + brID + "'ORDER BY DepartmentName";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.DepartmentId = reader.GetString(0);
                brnch.DepartmentName = reader.GetString(0);
                brnch.Head = reader.GetString(0);

                return brnch;
            }
            else
                return null;

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


    public class clsEmployee
    {
        public string EmployeeId;
		public string EmployeeName;
        public string Telehone;
        public string DepartmentId;
        public string Woreda;
        public string Kebele;
        public string OfficeTel;
        public string storeID;
        //public string Photo;
        
        public clsDepartment empDep;

        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();



        public clsEmployee()
		{
		 
        }
        public void addEmployee()
        {
            string strFields = "";
            string strValues = "";
            strFields = "EmployeeId,EmployeeName,DepartmentID,Woreda,Kebele,OfficeTel,StoreID";
            strValues ="'"+ EmployeeId + "','" + EmployeeName + "','" + DepartmentId+"','"+Woreda+"','"+Kebele+"','"+OfficeTel + "','" + storeID + "'";
            objData.addNewRecord("Employees", strFields, strValues, true);

        }

        public void UpdateEmployee()
        {
            string strFields = "";
            string strValues = "";


            strFields = "EmployeeId,EmployeeName,DepartmentID,Woreda,Kebele,OfficeTel";
            strValues = "'"+EmployeeId+ "','" + EmployeeName + "','" + DepartmentId+"','"+Woreda+"','"+Kebele+"','"+OfficeTel + "','" + storeID + "'";//+Photo;


            string strWhere = "EmployeeId ='" + EmployeeId + "'";
            string others="";
            objData.updateRecord("Employees", strFields, strValues, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteEmployee()
        {
            string strWhere = "EmployeeId ='" + EmployeeId + "'";

            objData.deleteRecord("Employees", strWhere);

        }

        public DataTable getAllEmployees()
        {
            DataTable dtDepartment = new DataTable();


            string[] strFields = { "EmployeeId", "EmployeeName", "DepartmentId","Woreda", "Kebele", "OfficeTel", "StoreID"  };

            objData.fillDataTable(dtDepartment, strFields, "Employees Order BY EmployeeName");

            return dtDepartment;

        }

        public string[] getDistinctVals(string strSQL)
        {
            string[] vals = objData.getFieldValues(strSQL);
            return vals;
        }

        public clsEmployee getEmployee(string brID)
        {
            SqlDataReader reader;
            clsEmployee brnch = new clsEmployee();
            string strSQL = "";

            strSQL = "SELECT EmployeeId,EmployeeName,DepartmentID,Woreda,Kebele,OfficeTel, StoreID FROM Emplyees where EmployeeId=" + EmployeeId + "'";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.EmployeeId = reader.GetString(0);
                brnch.EmployeeName = reader.GetString(0);
                brnch.DepartmentId = reader.GetString(0);
                brnch.Woreda = reader.GetString(0);
                brnch.Kebele = reader.GetString(0);
                brnch.Telehone = reader.GetString(0);
                brnch.storeID = reader.GetString(0);
                return brnch;
            }
            else
                return null;

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
