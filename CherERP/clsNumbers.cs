using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Belayab
{
    public class clsNumbers 
    {
        public string NumType;
        public int firstNo;
        public int lastNo;
     //   public string prefix;
        public byte length;

        clsData objData = clsData.Instance;
        clsUtility objUtility = new clsUtility();

        public clsNumbers()
        {
        }


        public void UpdateNumbers()
        {
            try
            {
                string strFields = "";
                string strValues = "";
                string strOthers = "";

              //  if(objData == null) objData = clsData.Instance;

                strFields = "";

                strValues = "";

                strOthers = "firstNo=" + firstNo.ToString() + ", lastNo=" + lastNo.ToString() + ", length =" + length.ToString();

                string strWhere = "NumType ='" + NumType + "'";


                objData.updateRecord("InvoiceNumberRanges", "", "", strOthers, strWhere, true);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
                

        }

        public string getDistinctVal(string strSQL)
        {
            string val = objData.getFieldValue(strSQL);
            return val;
        }



        public DataTable getAllNumberRanges()
        {
            DataTable dtNumber = new DataTable();

            string[] strFields = { "numType", "startNo", "lastNo", "length" };

            objData.fillDataTable(dtNumber, strFields, "InvoiceNumberRanges");

            return dtNumber;

        }

        public string[] getDistinctVals(string strSQL)
        {
            string[] vals = objData.getFieldValues(strSQL);
            return vals;
        }

        public void getNumberRange(string numType)
        {
            SqlDataReader reader;
           // clsNumbers num = new clsNumbers();
            string strSQL = "";

            strSQL = "SELECT numType, firstNo, lastNo,length, suffix FROM InvoiceNumberRanges where numType= '" + numType + "' ORDER BY numType";

            objData = clsData.Instance;

            reader = objData.getOneRecord(strSQL);

            if (reader.Read())
            {
                this.NumType = reader.GetString(0);
                this.firstNo = reader.GetInt32(1);
                this.lastNo = reader.GetInt32(2);
                this.length = reader.GetByte(3);
           }

            reader = null;
            
        }


        public string formatNumber(string fval, string nType)
        {

            getNumberRange(nType);

            while (fval.Length < this.length)
                fval = '0' + fval;

            if (clsData.connBel.State == ConnectionState.Open)
            {
                clsData.connBel.Close();
                clsData.connBel.Open();
            }

            return fval;

        }

        public string getNextAutoNumber(string Ntype)
        {

            string invNo;
            invNo = objData.getNextInvoiceNumber(Ntype);
            invNo = formatNumber(invNo, Ntype);
            return invNo;
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

    //pubilc class Details
}
