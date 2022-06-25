using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Belayab
{
    public class clsReceiving
    {
        public SqlDataAdapter daReceived, daRDetails;
        public DataSet dsReceived = new DataSet();
        public DataSet dsRDetails = new DataSet();
        public BindingSource bsReceived = new BindingSource(), bsRDetails = new BindingSource();
        
        

        public clsReceiving()
        {
            string sqlStr =
                "SELECT * FROM ItemsReceived";

            daReceived  = new SqlDataAdapter(sqlStr, clsData.connBel);
            daReceived.Fill(dsReceived  , "Received");

            sqlStr = "SELECT * FROM ItemsReceivedDetails";

            daReceived.SelectCommand.CommandText = sqlStr;
            daReceived.Fill(dsReceived, "ReceivedDetails");

            dsReceived.Relations.Add("Received_Details_Relation", dsReceived.Tables["Received"].Columns["ReceivedNumber"],
                    dsReceived.Tables["ReceivedDetails"].Columns["ReceivedNumber"]);

            bsReceived.DataSource = dsReceived;
            bsReceived.DataMember = dsReceived.Tables["Received"].TableName;
            bsRDetails.DataSource = dsReceived;
            bsRDetails.DataMember = dsReceived.Tables["ReceivedDetails"].TableName;
            //bsRDetails.DataMember = dsReceived.Relations[0].RelationName;




          
        }
    }
}
