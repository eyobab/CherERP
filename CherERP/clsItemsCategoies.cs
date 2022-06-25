using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
    public class clsItem
    {

        public string PartNumber;
        public string CategoryId;
        public string RowId;
        public string Description;
        public int MeasurementId;
        public float UnitPrice;
        public int OrderLevel;
        public object picture;


        public clsRow objRow;
        public clsData objData = clsData.Instance;

        public void addItem()
        {
            string strFields = "";
            string strValues = "";

            strFields = "PartNumber,CategoryId,RowId,Description,MeasurementId,UnitPrice,OrderLevel";

            strValues = "'" + PartNumber + "','" + CategoryId + "', '" + RowId + "', '" + Description + "', '" + MeasurementId + "', " + UnitPrice + "," + OrderLevel;

//            strValues = PartNumber + "~" + CategoryId + "~" + RowId + "~" + Description + "~" + MeasurementId + "~" + UnitPrice + "~" + OrderLevel;
            //Store = Store.
            // strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            objData.addNewRecord("Items", strFields, strValues, true);

        }

        public void UpdateItem()
        {
            string strFields = "";
            string strValues = "";
            string strOtherDataType = "";

            strFields = "PartNumber,CategoryId,RowId,Description";
            strValues = "'" + PartNumber + "','" + CategoryId + "', '" + RowId + "', '" + Description + "'";
            strOtherDataType= ", MeasurementId =" + MeasurementId + ",UnitPrice =" + UnitPrice + ",OrderLevel =" + OrderLevel;
            string strWhere = "PartNumber ='" + PartNumber + "'";
            

            objData.updateRecord("Items", strFields, strValues,strOtherDataType, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void DeleteItem()
        {
            string strWhere = "PartNumber ='" + PartNumber + "'";
            objData.deleteRecord("Items", strWhere);

        }

        public DataTable getAlltems()
        {
            DataTable dtItem = new DataTable();

            string[] strFields = { "PartNumber", "Description", "RowId", "CategoryId", "MeasurementId", "UnitPrice", "OrderLevel" };

            objData.fillDataTable(dtItem , strFields, "Items");

            return dtItem;
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

    public class clsCategory
    {
           public string CategoryId;
            public string CategoryName;
            public string Description;


            public clsData objData = clsData.Instance;

            public void addCategory()
            {
                string strFields = "";
                string strValues = "";

                strFields = "CategoryId,CategoryName,Description";
                strValues ="'"+ CategoryId + "','" + CategoryName + "','" + Description+"'";
                   objData.addNewRecord("Categories", strFields, strValues, true);

            }

            public void UpdateCatagory()
            {
                string strFields = "";
                string strValues = "";

                strFields = "CategoryId,CategoryName,Description";
                strValues = "'" + CategoryId + "','" + CategoryName + "','" + Description + "'";
                
                string strWhere = "CategoryId ='" + CategoryId  + "'";
                string others = "";

                objData.updateRecord("Categories", strFields, strValues, strWhere, true);

            }

            public string getDistinctVal(string strSQL)
            {
                string val = objData.getFieldValue(strSQL);
                return val;
            }

            public void DeleteCategory()
            {
                string strWhere = "CategoryId ='" + CategoryId + "'";
                objData.deleteRecord("Categories", strWhere);

            }

            public DataTable getAllCategories()
            {
                DataTable dtCategory = new DataTable();

                string[] strFields = {  "CategoryId","CategoryName" , "Description" };

                objData.fillDataTable(dtCategory, strFields, "Categories");

                return dtCategory;

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
