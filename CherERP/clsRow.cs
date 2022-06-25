using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
    public class clsRow
    {
        public string pRowID;
        public string pDescription;
        public string pcolumnId;
        public clsColumn Col;
         public clsData objData = clsData.Instance;
        
        public void addRow()
		{
			string strFields="";
			string strValues="";
     
            strFields = "RowId,Description,ColumnId";
            strValues = "'"+pRowID  + "','" + pDescription   + "','" + pcolumnId +"'";
            //Store = Store.
           // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            objData.addNewRecord("Rows", strFields, strValues, true);
			
		}

        public void UpdateRow()
        {
            string strFields = "";
            string strValues = "";

            strFields = "RowId,Description,ColumnId";
            strValues = "'"+pRowID + "','" +pDescription + "','" + pcolumnId+"'";

           string strWhere = "RowId ='" + Program.brsFrm.oldRowId +"'";

            objData.updateRecord("Rows", strFields, strValues, strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteRow()
        {
            string strWhere = "RowId ='" + pRowID + "'";
            objData.deleteRecord("Rows", strWhere);

        }

		public DataTable getAllRows()
		{	
			DataTable dtRow= new DataTable();
			DataRow drowRow;
				
			dtRow.Columns.Add("RowId");
			dtRow.Columns.Add("Description");
			dtRow.Columns.Add("ColumnId");
			
			string strSQL="";

            strSQL = "SELECT DISTINCT RowID,Description, ColumnId FROM Rows ORDER BY Description";
		

			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
				drowRow= dtRow.NewRow();
				drowRow[0] = vals[i,0].ToString();
                drowRow[1] = vals[i, 1].ToString();
                drowRow[2] = vals[i, 2].ToString();
             
                dtRow.Rows.Add(drowRow);
			}
			return dtRow;

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
