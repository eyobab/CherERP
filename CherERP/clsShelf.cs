using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Belayab
{
    public class clsShelf
    {
        public string pshelfId;
        public string pstoreId;
        public string pshelfName;
        public string pRemark;
        public clsStore Store;

        clsData objData = clsData.Instance;

        
		public void addShelf()
		{
			string strFields="";
			string strValues="";

            strFields = "ShelfId,StoreId,ShelfName,Remark";
            strValues = "'"+pshelfId + "','" + pstoreId + "','" + pshelfName + "','" + pRemark+"'";
            //Store = Store.
           // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark+"'";
            objData.addNewRecord("Shelfs", strFields, strValues, true);
			
		}

        public void UpdateShelf()
        {
            string strFields = "";
            string strValues = "";


            strFields = "ShelfId,ShelfName,StoreId,Remark";

            strValues = "'" + pshelfId + "','" + pshelfName + "','" + pstoreId + "','" + pRemark+"'";
           
           string strWhere = "ShelfId ='" + Program.brsFrm.oldShId +"'";

            objData.updateRecord("Shelfs", strFields, strValues,strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteShelf()
        {
            string strWhere = "ShelfId ='" + pshelfId + "'";
            objData.deleteRecord("Shelfs", strWhere);

        }

		public DataTable getAllShelves()
		{	
			DataTable dtShelf = new DataTable();
			DataRow drowShelf;
				
			dtShelf.Columns.Add("ShelfId");			
			dtShelf.Columns.Add("ShelfName");
            dtShelf.Columns.Add("StoreId");
			dtShelf.Columns.Add("Remark");
			
			string strSQL="";

            strSQL = "SELECT DISTINCT ShelfId,ShelfName,StoreId,Remark FROM Shelfs ORDER BY ShelfName";
		

			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
				drowShelf= dtShelf.NewRow();
				drowShelf[0] = vals[i,0].ToString();
                drowShelf[1] = vals[i, 1].ToString();
                drowShelf[2] = vals[i, 2].ToString();
                drowShelf[3] = vals[i, 3].ToString();

                dtShelf.Rows.Add(drowShelf);
			}
			return dtShelf;

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
