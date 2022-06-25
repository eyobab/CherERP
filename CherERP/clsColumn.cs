using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
    public class clsColumn
    {
        public string pcolumnID;
        public string pDescription;
        public string pshelfId;
       
        public clsShelf Shelf;

        public clsData objData = clsData.Instance;
        
        public void addColumn()
		{
			string strFields="";
			string strValues="";
     
            strFields = "ColumnId,ShelfId,Description";
            strValues = "'"+pcolumnID  + "','" + pshelfId  + "','" + pDescription+ "'" ;
            //Store = Store.
           // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            objData.addNewRecord("Columns", strFields, strValues, true );
			
		}

        public void UpdateColumn()
        {
            string strFields = "";
            string strValues = "";

            strFields = "ColumnId,ShelfId,Description";
            
            strValues = "'" + pcolumnID  + "','" + pshelfId  + "','" + pDescription+"'" ;

           string strWhere = "ColumnId ='" + Program.brsFrm.oldColId +"'";
           string others = "";

            objData.updateRecord("Columns", strFields, strValues,others, strWhere,true );

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteColumn()
        {
            string strWhere = "ColumnId ='" + pcolumnID + "'";
            objData.deleteRecord("Columns", strWhere);

        }

		public DataTable getAllColumns()
		{	
			DataTable dtColumn= new DataTable();
			DataRow drowColumn;
				
			dtColumn.Columns.Add("ColumnId");
			dtColumn.Columns.Add("Description");
			dtColumn.Columns.Add("ShelfId");
			
			string strSQL="";

            strSQL = "SELECT DISTINCT ColumnId,Description, ShelfId FROM Columns ORDER BY Description";
		

			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
				drowColumn= dtColumn.NewRow();
				drowColumn[0] = vals[i,0].ToString();
                drowColumn[1] = vals[i, 1].ToString();
                drowColumn[2] = vals[i, 2].ToString();
            
                dtColumn.Rows.Add(drowColumn);
			}
			return dtColumn;

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

