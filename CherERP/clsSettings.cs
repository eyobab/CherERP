using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Belayab
{
    /// <summary>
    /// </summary>
    /// Unit Measurment
    public class clsUnitMeasurment
    {

        public string pMeasurementId;
        public string pDescription;
        

        clsData objData = clsData.Instance;
        public clsUnitMeasurment()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void addUnitMeasurment()
        {
            string strFields = "";
            string strValues = "";
            strFields = "MeasurementId,Description";
            strValues = "'" + pMeasurementId + "','" + pDescription + "'";
            objData.addNewRecord("MeasurmentTypes", strFields, strValues, true);

        }

        public void UpdateUnitMeasurment()
        {
            string strFields = "";
            string strValues = "";


            strFields = "MeasurementId,Description";
            strValues = "'" + pMeasurementId + "','" + pDescription + "'";

            //  strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;

            string strWhere = "MeasurementId ='" + pMeasurementId + "'";


            objData.updateRecord("MeasurmentTypes", strFields, strValues, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteUnitMeasurment()
        {
            string strWhere = "MeasurementId ='" + pMeasurementId + "'";

            objData.deleteRecord("MeasurmentTypes", strWhere);

        }

        public DataTable getAllUnitMeasurment()
        {
            DataTable dtbBranch = new DataTable();

            string[] strFields = { "MeasurementId", "Description" };

            objData.fillDataTable(dtbBranch, strFields, "MeasurmentTypes");

            return dtbBranch;

        }

        public string[] getDistinctVals(string strSQL)
        {
            string[] vals = objData.getFieldValues(strSQL);
            return vals;
        }

        public clsUnitMeasurment getUnitMeasurment(string brID)
        {
            SqlDataReader reader;
            clsUnitMeasurment brnch = new clsUnitMeasurment();
            string strSQL = "";

            strSQL = "SELECT MeasurementId, Description FROM MeasurmentTypes where MeasurementId=" + brID + "'ORDER BY Description";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.pMeasurementId = reader.GetString(0);
                brnch.pMeasurementId = reader.GetString(0);
               
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
    /// Price Setting
    public class clsPriceSetting
    {

        public string pPartNumber;
        public string pDate;
        public float pUnitPrice;
        public string pEmployeeId;
        public string pRemark;


        clsData objData = clsData.Instance;
        public clsPriceSetting()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void addPriceSetting()
        {
            string strFields = "";
            string strValues = "";
            strFields = "PartNumber,SettingDate,UnitPrce,Remarks,EmployeeId";
            strValues = "'" + pPartNumber+ "','" + pDate + "'," + pUnitPrice + ",'" + pRemark + "','" + pEmployeeId + "'";
            objData.addNewRecord("ItemPriceSettings", strFields, strValues, true);

        }

        public void UpdatePriceSetting()
        {
            string strFields = "";
            string strValues = "";
            string strOtherDataType="";

            strFields = "PartNumber,SettingDate,UnitPrce,Remarks,EmployeeId";
            strValues = "'" + pPartNumber + "','" + pDate + "'," + pUnitPrice + ",'" + pRemark + "','" + pEmployeeId + "'";
            //  strValues = pBranchId + "," + pBranchName + "," + pLocation + "," + pRemark;
            strOtherDataType = "UnitPrce=" + pUnitPrice;
            string strWhere = "PartNumber ='" + pPartNumber + "' And SettingDate='"+pDate+"'";

            
            objData.updateRecord("ItemPriceSettings", strFields, strValues,strOtherDataType, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deletePriceSetting()
        {
            string strWhere = "PartNumber ='" + pPartNumber + "'";

            objData.deleteRecord("ItemPriceSettings", strWhere);

        }

        public DataTable getAllPriceSetting()
        {
            DataTable dtbBranch = new DataTable();

            string[] strFields = { "PartNumber", "SettingDate", "UnitPrce", "Remarks", "EmployeeId" };

            objData.fillDataTable(dtbBranch, strFields, "ItemPriceSettings");

            return dtbBranch;

        }

        public string[] getDistinctVals(string strSQL)
        {
            string[] vals = objData.getFieldValues(strSQL);
            return vals;
        }

        public clsPriceSetting getPriceSetting(string brID)
        {
            SqlDataReader reader;
            clsPriceSetting brnch = new clsPriceSetting();
            string strSQL = "";

            strSQL = "SELECT PartNumber,SettingDate,UnitPrce,Remarks,EmployeeId FROM ItemPriceSettings where PartNumber=" + brID + "'ORDER BY PartNumber";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.pPartNumber = reader.GetString(0);
                brnch.pDate = reader.GetString(0);
                brnch.pUnitPrice = float.Parse(reader.GetString(0));
                brnch.pRemark = reader.GetString(0);
                brnch.pEmployeeId = reader.GetString(0);

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
