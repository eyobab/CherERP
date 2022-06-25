using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
	/// <summary>
	/// </summary>
    /// 
	public class clsBranch
	{
	
		public string pBranchId;
		public string pBranchName;
        public string pLocation;	//used for update
        public string pRemark;
        public string oldbrId;
		

		clsData objData = clsData.Instance;
        public clsBranch()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void addBranch()
		{
			string strFields="";
			string strValues="";
            strFields = "BranchId,BranchName,Location,Remark";
            strValues = "'"+pBranchId + "','" + pBranchName + "','" + pLocation + "','" + pRemark+"'";
           // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            objData.addNewRecord("Branches", strFields, strValues, true );
			
		}

        public void UpdateBranch()
        {
            string strFields = "";
            string strValues = "";


            strFields = "BranchId,BranchName,Location,Remark";

            strValues = "'" + pBranchId + "','" + pBranchName + "','" + pLocation + "','" + pRemark+"'";

          //  strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;

            string strWhere = "BranchID ='" + Program.brsFrm.oldBrId  +"'";
            

            objData.updateRecord("Branches", strFields, strValues, strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteBranch()
        {
            string strWhere = "BranchID ='" + pBranchId + "'";

            objData.deleteRecord("Branches", strWhere);

        }

		public DataTable getAllBranches()
		{	
			DataTable dtbBranch = new DataTable();

            string[] strFields = { "BranchId", "BranchName", "Location","Remark"};

            objData.fillDataTable(dtbBranch, strFields, "Branches");

            return dtbBranch;

		}

		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
		}

        public clsBranch getBranch(string brID)
        {
            SqlDataReader reader;
            clsBranch brnch = new clsBranch();
            string strSQL = "";

            strSQL = "SELECT BranchId, BranchName, Location,Remark FROM Branches where BranchID=" + brID + "'ORDER BY BranchName";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.pBranchId = reader.GetString(0);
                brnch.pBranchName = reader.GetString(0);
                brnch.pLocation = reader.GetString(0);
                brnch.pRemark = reader.GetString(0);

                return brnch;
            }
            else
                return null;

        }


        
		
		public void beginTransact()
		{
			objData.beginTransact();
            List<SqlParameter> oParms = new List<SqlParameter>();

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
