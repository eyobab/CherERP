using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using System.IO;


namespace Belayab 
{
	/// <summary>
	/// Summary description for clsData.
	/// </summary>
	public class clsData
	{

		public static SqlConnection connBel= new SqlConnection(); 
		public static SqlConnection conAdmin =new SqlConnection(
            "data source=" + clsVariables.sServer + ";initial catalog=" + clsVariables.sDatabase +
            ";persist security info=True;MultipleActiveResultSets=true; user id=Sa;password=goodwork; Connection timeout =7"); 
		public static SqlTransaction BelTrans;

        public static SqlDataAdapter daPhoto, daDs = new SqlDataAdapter();
        public static DataSet dsPhoto;

        private static SqlCommand cmd = new SqlCommand();

        public  static SqlCommand cmdShared = new SqlCommand();

        public static clsSecurity objSecurity = new clsSecurity();

        //public static decimal vatRate = 0.15M;

        private static  clsData _clsDataInstance = null;// new clsData();

        //Common search values
        public static string pNum =""; // to search for part number
        public static string trNo = ""; // to search for trasactions Invoice,GRN,Issue,...
   

        public clsData()
		{
            //if (_clsDataInstance == null) _clsDataInstance = clsData.Instance;
		
            //  _clsDataInstance.creatConnection();

            //  this = _clsDataInstance();
		
		} 
        
        public static clsData Instance
        {
            get
            {
                if (_clsDataInstance == null) _clsDataInstance = new clsData();

                _clsDataInstance.creatConnection();

                return _clsDataInstance;
            }
        }
		
       
		
		private  void creatConnection()
		{	
		try
			{ 
				if(connBel.State!= ConnectionState.Open)
				{
					string strBelConnectionString;
					string usrNameConn; string pasWordConn;
                    string servName;
                    string dbName;

                    
                    usrNameConn = clsVariables.sDBUserID;
                    pasWordConn = clsVariables.sDBPassword;
                    //added

                    servName = clsVariables.sServer;
                    //servName = "PENIEL\\NEW";
                    dbName = clsVariables.sDatabase;
                    
                    
                    if (clsVariables.sDBUserID == "NoUser") return;

					//strBelConnectionString = "data source="+servName+ ";initial catalog=" + dbName+";persist security info=False;user id="+usrNameConn+";password="+pasWordConn;
                    strBelConnectionString = "data source=" + servName + ";initial catalog=" + dbName + ";persist security info=False; MultipleActiveResultSets=true; user id=" + usrNameConn + ";password=" + pasWordConn;
					connBel = new SqlConnection(strBelConnectionString);
					connBel.Open();


                    CreateAdminConnection();


				}
			}
        catch(Exception exp)
            {
            
            if (clsVariables.sDBUserID != "NoUser")
                  MessageBox.Show(exp.Message,"Stosa",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		
        
          }

        private void reConnect()
        {
            try
            {
                if (connBel.State == ConnectionState.Open) connBel.Close();

              
                    string strBelConnectionString;
                    string usrNameConn; string pasWordConn;
                    string servName;
                    string dbName;


                    usrNameConn = clsVariables.sDBUserID;
                    pasWordConn = clsVariables.sDBPassword;
                    //added

                    servName = clsVariables.sServer;
                    //servName = "PENIEL\\NEW";
                    dbName = clsVariables.sDatabase;


                    if (clsVariables.sDBUserID == "NoUser") return;

                    //strBelConnectionString = "data source="+servName+ ";initial catalog=" + dbName+";persist security info=False;user id="+usrNameConn+";password="+pasWordConn;
                    strBelConnectionString = "data source=" + servName + ";initial catalog=" + dbName + ";persist security info=False; MultipleActiveResultSets=true; user id=" + usrNameConn + ";password=" + pasWordConn;
                    connBel = new SqlConnection(strBelConnectionString);
                    connBel.Open();


               
            }
            catch (Exception exp)
            {

                if (clsVariables.sDBUserID != "NoUser")
                    MessageBox.Show(exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static string Location(string server)
        {
            string sloc = "(local)";

            switch (server)
            {
                case "Workshop1":
                    sloc = "SBS1";
                    break;
                case "KWorkShop1":
                    sloc = "KBS1";
                    break;
                case "ADWorkshop1":
                    sloc = "ADBS1";
                    break;
                case "HOWorkshop1":
                    sloc = "HBS1";
                    break;
                case "RCWorkshop1":
                    sloc = "RCBS1";
                    break;
                case "MWorkshop1":
                    sloc = "MBS1";
                    break;
                default:
                    sloc = "(local)";
                    break;
            }
            return sloc;
        }

        public static void  CreateAdminConnection()
        {

           conAdmin.Open();
            
        }
			
		public string[] getFieldValues(string strSQL)
		{
			SqlCommand commBel = new SqlCommand(strSQL);
			commBel.Connection = connBel;
			
            SqlDataReader readerBel = null;
			
			ArrayList Vals=new ArrayList();
			
			try
			{
                commBel.Transaction = BelTrans;
                readerBel= commBel.ExecuteReader(); 
                
                while (readerBel.Read())
					Vals.Add(readerBel.GetValue(0).ToString());

				readerBel.Close();
				commBel=null;
				string[] strVals=new string[Vals.Count];
				for(int i=0;i<Vals.Count;i++)
					strVals[i]=Vals[i].ToString();

				Vals.Clear();
                
                readerBel = null;
				
                return strVals;
                
			}
		catch(Exception ee)
			{
				Vals =null;
				if (readerBel != null) readerBel.Close();
				commBel=null;
			}
	
			return null;

		}

        public void fillDataTable(DataTable dTable,string[] strFields, string TbName)
        {
            string strSQLPart =strFields[0];

            int numf = strFields.Length;

            for (int i = 0; i < numf; i++)
            {
                dTable.Columns.Add(strFields[i]);
                if (i > 0)
                {
                    string str = strSQLPart + ",";
                    strSQLPart = str + strFields[i];
                }
            }
           
            string strSQL = "";

            strSQL = "SELECT DISTINCT " + strSQLPart + " FROM "+ TbName ;


            string[,] vals = getRecords(strSQL);

            DataRow rw;

            for (int i = 0; i < vals.GetLength(0); i++)
            {
                rw = dTable.NewRow();
                for (int j = 0; j<numf;j++)
                      rw[j] = vals[i, j].ToString();
            
                dTable.Rows.Add(rw);
            }
            
        }

        public string[,] getRecords(string strSQL)
		{		

			SqlCommand commBel=null;
			SqlDataReader readerBel=null;
			string[,] Vals={{""}};

			try
			{
	
			    commBel = new SqlCommand(strSQL);
				commBel.Connection = connBel;
				commBel.Transaction = BelTrans;
				//commBel.ExecuteNonQuery();
				readerBel = commBel.ExecuteReader(); 

				int i=0;
				int intTotalRec =0;
				int intColCount =readerBel.FieldCount;
				//Temp: to get Recordcount
				while (readerBel.Read())
					intTotalRec++;
			
				readerBel.Close();
				readerBel = commBel.ExecuteReader(); 

				Vals = new string[intTotalRec ,intColCount];

				while (readerBel.Read())
				{
					for(int j=0; j<intColCount;j++)
						Vals[i,j]=readerBel.GetValue(j).ToString();
							
					i++;

				}

                readerBel.Close();
                readerBel = null;
                commBel = null;
                return Vals;
			}

            catch (Exception ee)
            {
              if (readerBel!=null) readerBel.Close();
                commBel = null;
                return null;
            }	

	     
		}


        public string[] getColumnRecords(string strSQL)
        {

            SqlCommand commBel = null;
            SqlDataReader readerBel = null;
            string[] Vals = {""};

            try
            {

                commBel = new SqlCommand(strSQL);
                commBel.Connection = connBel;
                commBel.Transaction = BelTrans;
                //commBel.ExecuteNonQuery();
                readerBel = commBel.ExecuteReader();

                int i = 0;
                int intTotalRec = 0;
                //Temp: to get Recordcount
                while (readerBel.Read())
                    intTotalRec++;

                readerBel.Close();
                readerBel = commBel.ExecuteReader();

                Vals = new string[intTotalRec];

                while (readerBel.Read())
                {
                    Vals[i] = readerBel.GetValue(0).ToString();
                    i++;

                }

                readerBel.Close();
                readerBel = null;
                commBel = null;
                return Vals;
            }

            catch (Exception ee)
            {
                if (readerBel != null) readerBel.Close();
                commBel = null;
                return null;
            }


        }


        public SqlDataReader getOneRecord(string strSQL)
		{		

			SqlCommand commBel=null;
			SqlDataReader readerBel=null;
			
            try
			{
	
			    commBel = new SqlCommand(strSQL);
                if (connBel.State == ConnectionState.Open)
                {
                    connBel.Close();
                    connBel.Open();
                }
				commBel.Connection = connBel;
				//commBel.Transaction = BelTrans;
				readerBel = commBel.ExecuteReader();
                return readerBel;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null; }
        }



		public string getFieldValue(string strSQL)
		{
			SqlCommand commBel=null;
			SqlDataReader readerBel=null;
			          
	
			    commBel = new SqlCommand(strSQL);
                if (connBel.State == ConnectionState.Open)
                {
                    connBel.Close();
                    connBel.Open();
                }

                commBel.Connection = connBel;
                commBel.Transaction = BelTrans;

                readerBel = commBel.ExecuteReader();

			string Val="";
			if (readerBel.Read())
				Val=readerBel.GetValue(0).ToString();
			else
				Val ="";		
				
			readerBel.Close();
            readerBel = null;
			return Val;
		}

        public string getNextValue(string strSQL)
        {
            SqlCommand commBel = null;
            SqlDataReader readerBel = null;


            commBel = new SqlCommand(strSQL);
            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }

            commBel.Connection = connBel;
            commBel.Transaction = BelTrans;

            readerBel = commBel.ExecuteReader();

            string Val = "";
            if (readerBel.Read())
                Val = readerBel.GetValue(0).ToString();
            else
                Val = "";

            readerBel.Close();
            readerBel = null;
            return Val;
        }
        public decimal getFieldAmt(string strSQL)
        {
            SqlCommand commBel = new SqlCommand(strSQL);
            commBel.Connection = connBel;
            commBel.Transaction = BelTrans;
            //commBel.ExecuteNonQuery();
            SqlDataReader readerBel = commBel.ExecuteReader();

            decimal Val =0,test = 0;
            if (readerBel.Read())
               if(decimal.TryParse(readerBel.GetValue(0).ToString(), out test))
                    Val = test;//@@

            readerBel.Close();
            readerBel = null;
            commBel = null;
            return Val;
        }
        public void filterData(BindingSource bss, string searchFieldName, string filterString)
        {

            try
            {

                if (filterString != "")
                    bss.Filter =  "[" + searchFieldName + "] Like '" + filterString + "%'";
                else
                    bss.Filter = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
		
		
		public void addNewRecord(string strTableName, string strFields, string strValues, bool putAsUniCode)
		{
			string strChangedValues=strValues;

			//if (putAsUniCode)	strChangedValues ="N'" + strValues.Replace(",","',N'") +"'";
		    //  if (putAsUniCode)	strChangedValues ="N'" + strValues.Replace("~", "',N'") +"'";

			string strSQL ="INSERT INTO "+ strTableName+" ("+ strFields +")  Values(" + strChangedValues +")";
         
			SqlCommand commBel = new SqlCommand(strSQL);
			commBel.Connection = connBel;
			commBel.Transaction = BelTrans;
			commBel.ExecuteNonQuery();	
			commBel=null;
			
		}

        public void updateRecord(string strTableName, string strFields, string strValues, string strWHERE, bool putAsUniCode)
        {
            string[] strFldArray = strFields.Split(new char[] { ',' });
            string[] strValArray = strValues.Split(new char[] { ',' });

            string strBoth = "";

            for (int i = 0; i < strFldArray.Length; i++)
            {
                strBoth = strBoth + strFldArray[i].ToString().Trim() + "=" + strValArray[i].ToString().Trim() + ",";
            }


            strBoth = strBoth.Substring(0, strBoth.Length - 1);	//To remove the last comma

            string strSQL;
            strSQL = "UPDATE " + strTableName + " SET " + strBoth + " WHERE " + strWHERE;

            SqlCommand commBel = new SqlCommand(strSQL);
            commBel.Connection = connBel;
            commBel.Transaction = BelTrans;
            commBel.ExecuteNonQuery();
            commBel = null;

        }

        // if there is non string dataType		
        public void updateRecord(string strTableName, string strFields, string strValues, string others, string strWHERE, bool putAsUniCode)
        {
            string[] strFldArray = strFields.Split(new char[] { ',' });
            string[] strValArray = strValues.Split(new char[] { ',' });

                       
            string [] strvals = new string[strValArray.Length+ others.Length];

      

            string strBoth = "";
            int i,k;

            if (strFields != "")
            {
                for (i = 0; i < strValArray.Length; i++)
                {
                    strBoth = strBoth + strFldArray[i].ToString().Trim() + "=" + strValArray[i].ToString().Trim() + ",";
                }



                strBoth = strBoth.Substring(0, strBoth.Length - 1);	//To remove the last comma
            }

            string strSQL;

            strSQL = "UPDATE " + strTableName + " SET " + strBoth + others + " WHERE " + strWHERE;

            SqlCommand commBel = new SqlCommand(strSQL);

            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }

            commBel.Connection = connBel;
            commBel.Transaction = BelTrans;
            commBel.ExecuteNonQuery();
            commBel = null;

        }
		
        public void deleteRecord(string strTableName, string strWhere)
		{	
			string strSQL = "DELETE From " + strTableName + " WHERE " + strWhere;

            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            } 
            
            
            SqlCommand commBel = new SqlCommand(strSQL);
			commBel.Connection = connBel;
			commBel.Transaction=BelTrans;
			commBel.ExecuteNonQuery();	
			commBel=null;
		}
	
		public bool exists(string strSQL) 
		{
			SqlCommand commBel = new SqlCommand(strSQL);
			
			bool bExist=false;
			try
			{
                if (connBel.State == ConnectionState.Open)
                {
                    connBel.Close();
                    connBel.Open();
                }

                commBel.Connection = connBel;
				commBel.Transaction = BelTrans;
			    SqlDataReader readerBel = commBel.ExecuteReader(); 
				bExist= readerBel.Read();
				readerBel.Close();	
				return bExist;
			}

            catch (Exception exp)
            {
                commBel = null;
                MessageBox.Show(exp.Message, "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }			
         
			return false;
		}


		public bool executeCommand(string strSQL)
		{

            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            } 
            
            
            SqlCommand commBel = new SqlCommand(strSQL);
			commBel.Connection = connBel;
			commBel.Transaction = BelTrans;
			long lngRowsAffected=commBel.ExecuteNonQuery();
			if(lngRowsAffected>0)
				return true;
			return false;
		}


        public void GetInstock(DataGridView dv, int Rx, string spName, string storeID)
        {
            SqlCommand comm = new SqlCommand();
            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }
            comm.Connection = connBel;
            SqlDataReader dRead = null;
           
          try
            {
                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = spName;

                SqlParameter pr1 = new SqlParameter("@Pn", SqlDbType.NVarChar, 50);

                pr1.Value = dv.Rows[Rx].Cells["ItemID"].Value.ToString().Trim();


                SqlParameter pr2 = new SqlParameter("@Instock", SqlDbType.Int);
                pr2.Direction = ParameterDirection.Output;

                SqlParameter pr3 = new SqlParameter("@ReorderLevel", SqlDbType.Int);
                pr3.Direction = ParameterDirection.Output;

                SqlParameter pr4 = new SqlParameter("@Store", SqlDbType.NVarChar, 50);
                pr4.Value = storeID;



                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3); 
                comm.Parameters.Add(pr4);

               
                dRead = comm.ExecuteReader();

                dv.Rows[Rx].Cells["InStock"].Value = pr2.Value.ToString();

                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Alignment = DataGridViewContentAlignment.MiddleCenter;

               if (int.Parse(pr2.Value.ToString()) <= int.Parse(pr3.Value.ToString())) 
                  {
                     
                      style.ForeColor= Color.Red;
                      dv.Rows[Rx].Cells["InStock"].ErrorText = "Item Less than reorder level \n which is: "+ pr3.Value.ToString();
                      dv.Rows[Rx].Cells["InStock"].Style = style;
                  }
                                   
               else
                   {  dv.Rows[Rx].Cells["InStock"].Style = dv.Rows[Rx].Cells["ItemID"].Style;
                       dv.Rows[Rx].Cells["InStock"].ErrorText = "";
                   }
                  
              }

            
            catch (InvalidOperationException ex)
            {
              //  MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dRead != null)
                {
                    dRead.Dispose();
                    dRead.Close();
                    dRead = null;
                }
                if (comm != null)
                {
                    comm.Dispose();
                    comm = null;
                }

            }    

       }

        public int inStock(string pNum, string spName, string storeID)
        {
            SqlCommand comm = new SqlCommand();
            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }
            comm.Connection = connBel;
            SqlDataReader dRead = null;

            try
            {

                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = spName;

                SqlParameter pr1 = new SqlParameter("@Pn", SqlDbType.NVarChar, 50);

                pr1.Value = pNum;


                SqlParameter pr2 = new SqlParameter("@Instock", SqlDbType.Int);
                pr2.Direction = ParameterDirection.Output;

                SqlParameter pr3 = new SqlParameter("@ReorderLevel", SqlDbType.Int);
                pr3.Direction = ParameterDirection.Output;

                SqlParameter pr4 = new SqlParameter("@Store", SqlDbType.NVarChar, 50);
                pr4.Value = storeID;



                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3);
                comm.Parameters.Add(pr4);



                dRead = comm.ExecuteReader();

                return  int.Parse(pr2.Value.ToString());

             }


            catch (InvalidOperationException ex)
            {
                //  MessageBox.Show(ex.Message);
                return 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                if (dRead != null)
                {
                    dRead.Dispose();
                    dRead.Close();
                    dRead = null;
                }
                if (comm != null)
                {
                    comm.Dispose();
                    comm = null;
                }

            }

        }

        public int ReturnInstock( string spName, string pn, string storeID)
        {
            SqlCommand comm = new SqlCommand();
            int retVal = 0;
            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }
            comm.Connection = connBel;
            SqlDataReader dRead = null;

            try
            {

                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = spName;

                SqlParameter pr1 = new SqlParameter("@Pn", SqlDbType.NVarChar, 50);
                pr1.Value = pn;


                SqlParameter pr2 = new SqlParameter("@Instock", SqlDbType.Int);
                pr2.Direction = ParameterDirection.Output;

                SqlParameter pr3 = new SqlParameter("@ReorderLevel", SqlDbType.Int);
                pr3.Direction = ParameterDirection.Output;

                SqlParameter pr4 = new SqlParameter("@Store", SqlDbType.NVarChar, 50);
                pr4.Value = storeID;
                  
                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3); 
                comm.Parameters.Add(pr4);


                dRead = comm.ExecuteReader();

               return  (int)pr2.Value;
               
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return  retVal;
            }
            finally
            {
                if (dRead != null)
                {
                    dRead.Dispose();
                    dRead.Close();
                    dRead = null;
                }
                if (comm != null)
                {
                    comm.Dispose();
                    comm = null;
                }

               

            }
          }

        public decimal GetCustomerPayments(string spName, string cusId)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = connBel;


            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = spName;

                SqlParameter pr1 = new SqlParameter("@cusId", SqlDbType.NVarChar, 50);

                pr1.Value = cusId;


                SqlParameter pr2 = new SqlParameter("@amt", SqlDbType.Money);
                pr2.Direction = ParameterDirection.Output;


                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);

                SqlDataReader dRead = comm.ExecuteReader();

               
                comm = null;
                dRead.Close();
                dRead = null;
                
                
                return decimal.Parse(pr2.Value.ToString());



            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (comm != null) comm.Dispose();
                comm = null;
               

            }
            return 0;
        }


        public void GetCreditsAndPayments(DataGridView dv, int Rx)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = connBel;


            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "GetCreditsAndPayments";

                SqlParameter pr1 = new SqlParameter("@InvNo", SqlDbType.NVarChar, 50);

                pr1.Value = dv.Rows[Rx].Cells["InvoiceNo"].Value.ToString().Trim();


                SqlParameter pr2 = new SqlParameter("@Credit", SqlDbType.Money);
                pr2.Direction = ParameterDirection.Output;

                SqlParameter pr3 = new SqlParameter("@Payed", SqlDbType.Money);
                pr3.Direction = ParameterDirection.Output;
                

                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3);
                
                SqlDataReader dRead = comm.ExecuteReader();

              //  dv.Rows[Rx].Cells["Credits"].Value =  pr2.Value;
                dv.Rows[Rx].Cells["Payed"].Value =  pr3.Value;
                
                decimal bal = decimal.Parse(pr2.Value.ToString()) - decimal.Parse(pr3.Value.ToString());
                dv.Rows[Rx].Cells["Balance"].Value = bal;

                

                dRead.Close();
                dRead = null;

                comm.Dispose();
                comm = null;
                
            }
            catch (InvalidOperationException ex)
            {
                // Leave it
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (comm != null) comm.Dispose();
                comm = null;

            }

        }

        public void GetCustomerCredPayments(string cusId, out decimal credit, out decimal payed)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = connBel;


            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "CustomerCredits";

                SqlParameter pr1 = new SqlParameter("@cusId", SqlDbType.NVarChar, 50);

                pr1.Value = cusId;


                SqlParameter pr2 = new SqlParameter("@Credit", SqlDbType.Money);
                SqlParameter pr3 = new SqlParameter("@Payed", SqlDbType.Money);
              

                pr2.Direction = ParameterDirection.Output;
                pr3.Direction = ParameterDirection.Output;



                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3);

                SqlDataReader dRead = comm.ExecuteReader();

                credit = decimal.Parse(pr2.Value.ToString());
                payed = decimal.Parse(pr3.Value.ToString());


                comm = null;
                dRead.Close();
     

            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                credit = 0;
                payed = 0;
            }
            
            
            
        }

        
        public void setItemUnit(DataGridView dv, int Rx)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connBel;

                SqlDataReader Dread;


                cmd.Connection = clsData.connBel;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "GetUnit '" + dv.Rows[Rx].Cells["ItemID"].Value.ToString().Trim() + "'";



                Dread = cmd.ExecuteReader();

                if (Dread.Read())
                    dv.Rows[Rx].Cells["Units"].Value = Dread[0].ToString();


                Dread.Close();
                Dread.Dispose();
                Dread = null;
                cmd.Dispose();
                cmd = null;
            }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }

        }


        public int GetValueInOrder(string pn, string refNo , string issueCase)
        {

            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;

            if (connBel.State == ConnectionState.Open)
            {
                connBel.Close();
                connBel.Open();
            }
     
            comm.Connection = clsData.connBel;
            int qty;

            switch (issueCase)
            {
                case "Cash Sales":
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 2";
                    break;
                case "Credit Sales":
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 3";
                    break;
                case "Requisition":
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 1";
                    break;
                case "PUR": //Purchased to be received
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 4";
                    break;
                case "POR": // To be Purachase ordered
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 5";
                    break;
                case "RETI":
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 6";
                    break;
                case "RETT":
                    comm.CommandText = "GetQtyInOrder '" + pn.Trim() + "','" + refNo + "', 7";
                    break;

            }

            qty = (int)float.Parse( comm.ExecuteScalar().ToString());
            comm = null;
            return qty;
        }


        public decimal getUnitPrice(string Pno)
        {
            SqlCommand comm = new SqlCommand();

            try
            {

                comm.Connection = clsData.connBel;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "GetUnitPrice";

                SqlParameter pr1 = new SqlParameter("@pn", SqlDbType.NVarChar, 50);
                SqlParameter pr2 = new SqlParameter("@Upr", SqlDbType.Money);

                pr1.Value = Pno;
                pr2.Direction = ParameterDirection.Output;

                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);

                decimal Price;

                comm.ExecuteScalar();

                Price = decimal.Parse(pr2.Value.ToString());

                return Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                comm.Dispose();
                comm = null;
            }
                
        }

        public void setItemBeginningBalance(string Pno, string store, DateTime dt, double qty)
        {
            SqlCommand comm = new SqlCommand();

            try
            {

                comm.Connection = clsData.connBel;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "SetItemBeginningBalance";

                SqlParameter pr1 = new SqlParameter("@pn", SqlDbType.NVarChar, 50);
                SqlParameter pr2 = new SqlParameter("@FirstQty", SqlDbType.Decimal);
                SqlParameter pr3 = new SqlParameter("@aDate", SqlDbType.SmallDateTime);
                SqlParameter pr4 = new SqlParameter("@Store", SqlDbType.NVarChar, 50);


                pr1.Value = Pno;
                pr2.Value = qty;
                pr3.Value = dt;
                pr4.Value = store;

                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3);
                comm.Parameters.Add(pr4);

                comm.ExecuteScalar();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                comm.Dispose();
                comm = null;
            }

        }

        public decimal getUnitPriceSelling(string Pno, string pType)
        {
            SqlCommand comm = new SqlCommand();

            try
            {

                comm.Connection = clsData.connBel;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "GetUnitPrice_Selling";

                SqlParameter pr1 = new SqlParameter("@pn", SqlDbType.NVarChar, 50);
                SqlParameter pr2 = new SqlParameter("@Upr", SqlDbType.Money);
                SqlParameter pr3 = new SqlParameter("@pType", SqlDbType.NVarChar, 50);

                pr1.Value = Pno;
                pr2.Direction = ParameterDirection.Output;

                pr3.Value = pType;

                comm.Parameters.Add(pr1);
                comm.Parameters.Add(pr2);
                comm.Parameters.Add(pr3);

                decimal Price;

                comm.ExecuteScalar();

                Price = decimal.Parse(pr2.Value.ToString());

                return Price;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                comm.Dispose();
                comm = null;
            }

        }
        

        public string getStringValue(string str )
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.Connection = clsData.conAdmin;
                SqlDataReader dRead;
           
                comm.CommandText = str;

                if (comm.ExecuteScalar() != null)
                    return comm.ExecuteScalar().ToString();
                else
                    return "";

            
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Stosa");
                return "";
            }


        }
        
        
        
        
        
        public void saveChanges(BindingSource bs, SqlDataAdapter da, DataTable dt)
        {
             bs.EndEdit();
             da.Update(dt);

           
        }


        public DataSet getDSet(string strSQL, string dsName)
        {
            SqlDataAdapter da = new SqlDataAdapter(strSQL, connBel);
            DataSet ds = new DataSet();

            da.Fill(ds, dsName);

            return ds;

        }


        public string getUserRole(string USerName)
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.Connection = clsData.connBel;
            comm.CommandText = "Select RoleID from Users where UserName='" + clsVariables.curUserName.TrimEnd() +"'";

            return comm.ExecuteScalar().ToString();
            comm.Dispose();
            comm = null;

        }



        public void setStartingID(int start, string idType)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clsData.connBel;

                if (idType == "Cash")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from InvoiceNumbers_Cash";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "  Alter table InvoiceNumbers_Cash    Drop column InvoiceNoCash";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " Alter table InvoiceNumbers_Cash      Add InvoiceNoCash bigint Identity (" + start + " , 1) not null";
                    cmd.ExecuteNonQuery();
                }
                else if (idType ==  "Credit")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from InvoiceNumbers_Credit";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "  Alter table InvoiceNumbers_Credit    Drop column InvoiceNoCredit";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " Alter table InvoiceNumbers_Credit     Add InvoiceNoCredit bigint Identity ( " + start + " , 1) Not null ";
                    cmd.ExecuteNonQuery();
                }

                else if (idType == "GRN")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from InvoiceNumbers_GRN";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "  Alter table InvoiceNumbers_GRN    Drop column InvoiceNoGRN";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " Alter table InvoiceNumbers_GRN     Add InvoiceNoGRN bigint Identity ( " + start + " , 1) Not null ";
                    cmd.ExecuteNonQuery();
                }

                else if (idType == "SIV")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from InvoiceNumbers_SIV";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "  Alter table InvoiceNumbers_SIV    Drop column InvoiceNoSIV";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " Alter table InvoiceNumbers_SIV     Add InvoiceNoSIV bigint Identity ( " + start + " , 1) Not null ";
                    cmd.ExecuteNonQuery();
                }

                else if (idType == "Req")
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete from InvoiceNumbers_Req";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "  Alter table InvoiceNumbers_Req    Drop column InvoiceNoReq";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " Alter table InvoiceNumbers_Req     Add InvoiceNoReq bigint Identity ( " + start + " , 1) Not null ";
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public string getNextInvoiceNumber(string invType)
        {
            
            SqlTransaction tr = connBel.BeginTransaction(IsolationLevel.Serializable);
       
            try
            {
                cmd.Parameters.Clear();

                cmd.Connection = connBel;
                cmd.Transaction = tr;

                cmd.CommandType = CommandType.Text;

               

               // pr2.Direction = ParameterDirection.Output;

                
                cmd.CommandText = "InsertNewInvoiceNumber '"+invType + "'";

                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pr1 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
                pr1.Direction = ParameterDirection.Input;
                pr1.Value = invType;
                cmd.Parameters.Add(pr1);

                SqlParameter pr2 = new SqlParameter("@val", SqlDbType.BigInt, 50);
                pr2.Direction = ParameterDirection.Output;
                pr2.Value = 0;
                cmd.Parameters.Add(pr2);

                cmd.CommandText = "GetNextNumber";

                cmd.ExecuteNonQuery();

                string val = pr2.Value.ToString();

                tr.Commit();


                return val;


              

            }

            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);
                tr.Rollback();
                return "";

            }
                        
        }

        public  void resetChanges(DataGridView dv)
        {
            for (int k = 0; k < dv.Rows.Count; k++)
            {
                dv.Rows[k].Cells["Edited"].Value = false;
            }
        }
        

        public static void distributeData ()
        {
           
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", "InsTest");
            ExecJob.Connection = connBel; //assign the connection to the command.

             ExecJob.ExecuteNonQuery();
       
        }

        public void beginTransact()
		{
            try
            {
                BelTrans = connBel.BeginTransaction();

            } catch(Exception ex) { MessageBox.Show(ex.Message,"Stosa");}

		}

		public void commitTransact()
		{
		    BelTrans.Commit();
		}

		public void rollbackTransact()
		{
			BelTrans.Rollback();
		}

	}


    public class clsImage
    {

        public static string imagePath = Application.StartupPath + "\\ItemImage.jpg";
        public static string newImagePath = "";
        public static string noPhotoPath = Application.StartupPath + "\\noPhoto.jpg";



        public void SavePhotoToDB(ref string FileName, DataTable dt, string pos, int rowpos)
        {
            try
            {
                FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);

                byte[] MyData = new byte[fs.Length];


                fs.Read(MyData, 0, (int)fs.Length);
                fs.Close();

                DataRow myRow;

                myRow = dt.Rows[rowpos];

                myRow[pos] = MyData;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stosa");

            }
        }


        //'THIS FUNCTION LOADS IMAGE FROM IMAGE DATATYPE FIELD AND SAVES IT INTO A FILE.

        public void getImageToFile(DataTable dt, string pos, ref string FileName, int rowPos)
        {


            DataRow myRow;

            try
            {

                if (rowPos < 0)
                {
                    FileName = "";
                    return;
                }

                myRow = dt.Rows[rowPos];

                byte[] myData;


                if (myRow[pos].GetType().ToString() == "System.DBNull")
                {
                    FileName = "";
                    return;
                }

                myData = (byte[])myRow[pos];

                int k;

                k = myData.Length;


                FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);

                fs.Write(myData, 0, k);
                fs.Close();

                fs = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stosa");
                FileName = "";
            }
        }


        public void DisplayPhoto(DataTable dt, string tblName, string fldName,string wfldName, string criteria, PictureBox picBox, string iPath)
        {
            try
            {
                setPhoto(dt, tblName, fldName, wfldName, criteria, ref iPath);

                if (iPath != "")
                    picBox.Load(iPath);
                else
                    picBox.Load(Application.StartupPath + "\\noPhoto.jpg");


            }
            catch (Exception ex) { }
            

        }
     
 

    public void SavePhoto(DataTable dt , string tblName,  string  fldName,string  wfldName , string criteria, ref string imPath)
    {

        if (imPath == "")
            return;

        FileStream fs = new FileStream(imPath, FileMode.Open, FileAccess.Read);

        try
        {

            string cmdText;

            //'     Dim connectionString As String = "Enter your Connection String"
            //' ***   Dim imageStream As Stream = ImageFile.PostedFile.InputStream
            //'  Dim byteData(ImageFile.PostedFile.ContentLength) As Byte
            //'   Dim objConn As New SqlClient.SqlConnection(connectionString)

            cmdText = "Update " + tblName +  " set " + fldName + "=@image Where " + wfldName + "='" +  criteria + "'";

            SqlCommand  objCommand = new SqlCommand(cmdText, clsData.connBel);

            SqlParameter objParam = new SqlParameter("@image", SqlDbType.Image);


            byte[] myData = new byte[fs.Length];

            fs.Read(myData, 0, (int)fs.Length);

            objParam.Value = myData;
            objCommand.Parameters.Add(objParam);

            objCommand.ExecuteNonQuery();
        }
        catch( Exception  exc ){
            MessageBox.Show(exc.ToString());
        }
        finally{
            fs.Close();
        }
    }
    

  //  'THIS FUNCTION LOADS IMAGE FROM IMAGE DATATYPE FIELD AND SAVES IT INTO A FILE.
    public void setPhoto(DataTable dt, string tblName, string fldName, string wfldName,string criteria, ref string iPath)
    {
        byte [] myData;
        FileStream fs; 
        SqlDataReader objReader =  null;
        SqlCommand objCommand ; 

        try {

            string commandText = "SELECT " + fldName + " FROM " + tblName + " Where " + wfldName + " ='" + criteria + "'";

            if (clsData.connBel.State == ConnectionState.Open)
            {
                clsData.connBel.Close();
                clsData.connBel.Open();
            }
            
            objCommand = new SqlCommand(commandText, clsData.connBel);
            
            objReader = objCommand.ExecuteReader();

             if ( objReader.Read() )
                 if ( objReader[fldName]!= null )
                 {
                     myData = (byte[])objReader[fldName];

                     int K;
                     K = myData.Length;

                     //if (K < 4092) { 
                     //    iPath = clsImage.noPhotoPath;
                     //    return; }

                     fs = new FileStream(iPath, FileMode.Create, FileAccess.Write);

                     fs.Write(myData, 0, K);
                     fs.Close();
                     fs = null;
                    
                 }
                 else
                 {
                     iPath = "";
                     return;
                 }

        }

        catch (Exception exc){
       //     MessageBox.Show(exc.Message, "Image Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            iPath = ""; 
        }
        finally 
        {
            fs = null;
            if (objReader !=null) objReader.Close();
            objReader = null ;
            objCommand = null;
        }
    }


        public void getPicture(PictureBox sPictureBox, string sSQL)
        {
            try
            {
               
                SqlCommand cmdSelect = new SqlCommand(sSQL, clsData.connBel);
             

                byte[] barrImg = (byte[])cmdSelect.ExecuteScalar();
                string imgPath = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(imgPath, FileMode.CreateNew, FileAccess.Write);
                fs.Write(barrImg, 0, barrImg.Length);
                fs.Flush();
                fs.Close();

                sPictureBox.Image = Image.FromFile(imgPath);

            }
            catch (Exception ex)
            {
               sPictureBox.Visible = false;

            }
     
             
        }

   
            
    }
}



