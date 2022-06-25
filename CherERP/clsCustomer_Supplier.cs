using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Belayab
{
 
    public class clsSupplier
    {
        public string SupplierId;
		public string SupplierName;
        public string TelePhone;	//used for update
        public string PoBox;
        public string EmailAddress;
		

		clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();
        public clsSupplier()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void addSupplier()
		{
			string strFields="";
			string strValues="";
            strFields = "SupplierName,TelePhoneNo,POBox,EmailAddress";
            strValues = "'" + SupplierName + "','" + TelePhone + "','" + PoBox + "','" + EmailAddress+"'";
            objData.addNewRecord("Suppliers", strFields, strValues, true );
			
		}

        public void UpdateSupplier()
        {
            string strFields = "";
            string strValues = "";


            strFields = "SupplierName,TelePhoneNo,POBox,EmailAddress";
            strValues = "'" + SupplierName + "','" + TelePhone + "','" + PoBox + "','" + EmailAddress + "'";

            string strWhere = "SupplierId ='" + SupplierId + "'";

            objData.updateRecord("Suppliers", strFields, strValues, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteSupplier()
        {
            string strWhere = "SupplierID ='" + SupplierId + "'";

            objData.deleteRecord("Suppliers", strWhere);

        }

		public DataTable getAllSuppliers()
		{	
			DataTable dtSupp = new DataTable();


            string[] strFields = { "SupplierId", "SupplierName", "TelephoneNo", "POBox", "EmailAddress" };

            objData.fillDataTable(dtSupp, strFields, "Suppliers");

            return dtSupp;

		}

		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
		}

        public clsSupplier getSuppliers(string brID)
        {
            SqlDataReader reader;
            clsSupplier brnch = new clsSupplier();
            string strSQL = "";

            strSQL = "SELECT SupplierId, SupplierName,TelePhoneNo,POBox,EmailAddress FROM Suppliers where SupplierId=" + brID + "' ORDER BY SupplierName";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.SupplierId = reader.GetString(0);
                brnch.SupplierName = reader.GetString(0);
                brnch.TelePhone = reader.GetString(0);
                brnch.PoBox= reader.GetString(0);
                brnch.EmailAddress = reader.GetString(0);

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
    
    public class clsCustomer
    {
        public string pCustomerId;
        public string pCustomerName;
        public string pWoreda;	//used for update
        public string pKebele;
        public string pHouseNo;
        public string pCity;
        public string pCountry;
        public string pVATRegNumber;
        public string pVATRegDate;
        public string pTINNumber;
        public string pCustomerTypeId;
        public string pContactTelephone;
		

		clsData objData = clsData.Instance;
        public clsCustomer()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public void addCustomer()
		{
			string strFields="";
			string strValues="";
            strFields = "CustomerName,Woreda,Kebele,HouseNo,City,Country,VATRegNumber,VATRegDate,TINNumber,CustomerTypeId,ContactTelephone";
            strValues = "'" + pCustomerName + "','" + pWoreda + "','" + pKebele + "','" + pHouseNo + "','" + pCity + "','" + pCountry + "','" + pVATRegNumber + "','" + pVATRegDate + "','" + pTINNumber + "','" + pCustomerTypeId + "','" + pContactTelephone + "'";
            objData.addNewRecord("Customers", strFields, strValues, true);
			
		}

        public void UpdateCustomer()
        {
            string strFields = "";
            string strValues = "";


            strFields = "CustomerName,Woreda,Kebele,HouseNo,City,Country,VATRegNumber,VATRegDate,TINNumber,CustomerTypeId,ContactTelephone";
            strValues = "'" + pCustomerName + "','" + pWoreda + "','" + pKebele + "','" + pHouseNo + "','" + pCity + "','" + pCountry + "','" + pVATRegNumber + "','" + pVATRegDate + "','" + pTINNumber + "','" + pCustomerTypeId +"','" + pContactTelephone + "'";
    

            string strWhere = "CustomerId ='" + pCustomerId + "'";

            objData.updateRecord("Customers", strFields, strValues, strWhere, true);

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }

        public void deleteCustomer()
        {
            string strWhere = "CustomerId ='" + pCustomerId + "'";

            objData.deleteRecord("Customers", strWhere);

        }

        public DataTable getAllCustomers()
		{	
			DataTable dtbCustomer = new DataTable();
			DataRow drowCustomer;

            dtbCustomer.Columns.Add("CustomerId");
            dtbCustomer.Columns.Add("CustomerName");
            dtbCustomer.Columns.Add("Woreda");
            dtbCustomer.Columns.Add("Kebele");
            dtbCustomer.Columns.Add("HouseNo");
            dtbCustomer.Columns.Add("City");
            dtbCustomer.Columns.Add("Country");
            dtbCustomer.Columns.Add("VATRegNumber");
            dtbCustomer.Columns.Add("VATRegDate");
            dtbCustomer.Columns.Add("TINNumber");
            dtbCustomer.Columns.Add("CustomerTypeId");
            dtbCustomer.Columns.Add("ContactTelephone");

            
			string strSQL="";

            strSQL = "SELECT DISTINCT CustomerId, CustomerName, Woreda,Kebele,HouseNo,City,Country,VATRegNumber,VATRegDate,TINNumber,CustomerTypeId,ContactTelephone FROM Customers ORDER BY CustomerName";
		
			string[,] vals = objData.getRecords(strSQL);

			for (int i=0; i < vals.GetLength(0);i++)
			{
                drowCustomer = dtbCustomer.NewRow();
                drowCustomer[0] = vals[i, 0].ToString();
                drowCustomer[1] = vals[i, 1].ToString();
                drowCustomer[2] = vals[i, 2].ToString();
                drowCustomer[3] = vals[i, 3].ToString();
                drowCustomer[4] = vals[i, 4].ToString();
                drowCustomer[5] = vals[i, 5].ToString();
                drowCustomer[6] = vals[i, 6].ToString();
                drowCustomer[7] = vals[i, 7].ToString();
                drowCustomer[8] = vals[i, 8].ToString();
                drowCustomer[9] = vals[i, 9].ToString();
                drowCustomer[10] = vals[i, 10].ToString();
                drowCustomer[11] = vals[i, 11].ToString();



				dtbCustomer.Rows.Add(drowCustomer);
			}
			return dtbCustomer;

		}

		public string[] getDistinctVals(string strSQL)
		{
			string[] vals = objData.getFieldValues(strSQL);
			return vals;
		}

        public clsCustomer getCustomer(string brID)
        {
            SqlDataReader reader;
            clsCustomer brnch = new clsCustomer();
            string strSQL = "";

            strSQL = "SELECT DISTINCT CustomerId, CustomerName, Woreda,Kebele,HouseNo,City,Country,VATRegNumber,VATRegDate,TINNumber,CustomerTypeId,ContactTelephone FROM Customers ORDER BY CustomerName";
            reader = objData.getOneRecord(strSQL);
            if (reader.Read())
            {
                brnch.pCustomerId = reader.GetString(0);
                brnch.pCustomerName = reader.GetString(0);
                brnch.pKebele = reader.GetString(0);
                brnch.pWoreda = reader.GetString(0);
                brnch.pHouseNo = reader.GetString(0);
                brnch.pCity = reader.GetString(0);
                brnch.pCountry = reader.GetString(0);
                brnch.pVATRegNumber = reader.GetString(0);
                brnch.pVATRegDate= reader.GetString(0);
                brnch.pTINNumber= reader.GetString(0);
                


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
