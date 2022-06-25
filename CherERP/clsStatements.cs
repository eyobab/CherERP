using System;
using System.Data;
using System.Data.SqlClient;

namespace Belayab
{
    class clsStatements: clsVariables
    {
        public static SqlConnection conn;

        public clsStatements()
        {
            conn  = new SqlConnection(clsData.conAdmin.ConnectionString);
            conn.Open();
        }

        public void setCommand(DataSet dsFill, SqlDataAdapter daFill, string sSQL, string sTable)
        {
            if (conn.State == ConnectionState.Open) conn.Close();
            daFill.SelectCommand = new SqlCommand(sSQL, conn);
            dsFill.Clear();
            daFill.Fill(dsFill, sTable);
        }

        public void setRecordCount(DataSet dsFill, string sSQL, string sTable)
        {

            if (conn.State == ConnectionState.Open) conn.Close();
            SqlDataAdapter sAdapter = new SqlDataAdapter();
            sAdapter.SelectCommand = new SqlCommand(sSQL, conn);
            dsFill.Clear();
            sAdapter.Fill(dsFill, sTable);
        }

        public void setSqlCommand(string sSQL)
        {
            //Set Connection
            SqlCommand sCommand = new SqlCommand();
            sCommand.Connection = conn;
            sCommand.CommandText = sSQL;
            sCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
