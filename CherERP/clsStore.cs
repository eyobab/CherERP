using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Belayab
{
   public class clsStore
   {
        public string pStoreId;
        public string pBranchId;
        public string pStoreName;
        public string pRemark;
       
        public clsBranch pBranch = new clsBranch();

       
              
       clsData objData = clsData.Instance;
       
       
		public void addStore()
		{
			string strFields="";
			string strValues="";
     
            strFields = "StoreId,BranchId,StoreName,Remark";
            strValues = "'" + pStoreId + "','" + pBranchId + "','" + pStoreName + "','" + pRemark+"'";
            //pBranch = pBranch.getBranch(pBranchId);
           // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            objData.addNewRecord("Stores", strFields, strValues, true );
			
		}

        public void UpdateStore()
        {
            string strFields = "";
            string strValues = "";


            strFields = "StoreId,BranchId,StoreName,Remark";

            strValues = "'" + pStoreId + "','" + pBranchId + "','" + pStoreName + "','" + pRemark+"'";

           string strWhere = "StoreId ='" + Program.brsFrm.oldStId  +"'";


            objData.updateRecord("Stores", strFields, strValues, strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteStore()
        {
            string strWhere = "StoreId ='" + pStoreId + "'";
            objData.deleteRecord("Stores", strWhere);

        }

		public DataTable getAllStores()
		{	
			DataTable dtStore = new DataTable();
			DataRow drowStore;
				
			dtStore.Columns.Add("StoreId");
			dtStore.Columns.Add("BranchId");
			dtStore.Columns.Add("StoreName");
			dtStore.Columns.Add("Remark");
			
			string strSQL="";

            strSQL = "SELECT DISTINCT StoreId, StoreName,BranchId, Remark FROM Stores ORDER BY StoreName";
		

			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
				drowStore= dtStore.NewRow();
				drowStore[0] = vals[i,0].ToString();
                drowStore[1] = vals[i, 1].ToString();
                drowStore[2] = vals[i, 2].ToString();
                drowStore[3] = vals[i, 3].ToString();

                dtStore.Rows.Add(drowStore);
			}
			return dtStore;

		}
		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
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
    
    

