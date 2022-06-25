using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Belayab
{
	/// <summary>
	/// Summary description for clsAudit.
	/// </summary>
	public enum  Function
	{
		Case = 1, Appointment,Plaintiff,Defendant , Witness , Victims , ThirdParty , FileMovmentHistory,
		Decision , BenchDailyInformation , JudgesCalendar , PresidantsAndJudges , Prosecutors , Lowyers , 
		ChargList , CaseRelated ,Location, CourtRank , Courts ,Benches , PayRate , General , Security ,JudgesOrder,Attachments ,
		PreliminaryDecision ,JudgesAppointment , LowyersClients , ProsecutorsClients , DefaultSettings, BackUp
	}
	

	public enum AuditAction
	{   ADD = 1 , DELETE , UPDATE , VIEW , ATTACH }

	
	public class clsAudit

	{
		clsData  objdata ;
		string AsName="";
		string AdName="";
		string sName="";
		string dName="";
		public clsAudit()
		{
			
			objdata = clsData.Instance; 
			ReadAuditSetting();
			
			//
			// TODO: Add constructor logic here
			//
		}

		// Overlodded Fuctions

		public void RecordAudit(DateTime Time, string Uname , AuditAction ActionId,Function FunctionId, string CaseNumber, string key , string Description) 
		{  
			
			double Motivateiontime = 2 ;  // 2 minutes
			bool IsFirstAction=false;
			string Ref= ""; // used  as reference to calculate Sleep time of Current Action 
			string strSQL = " SELECT * FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "'" ;
			if(objdata.exists(strSQL))  //There is Previous Action 
			{
				strSQL="SELECT TOP 1 Time FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "' ORDER BY Time DESC" ;
				Ref=objdata.getFieldValue(strSQL);
			}
			else  // This is the first Action So take login time as a reference
			{
					Ref = MainForm.LoginTime ; 
				    IsFirstAction=true; 
			}
			
			string Values=  Time + "~" + Uname + "~" + Convert.ToInt16(ActionId) + "~" + Convert.ToInt16(FunctionId) + "~" + CaseNumber + "~" + key + "~" + Description + "~" + Environment.MachineName ;
			string Fields= "[Time],UserId , [ActionId] ,FunctionId, CaseNumber ,[Key],Description,Machine";
			objdata.addNewRecord("Audit",Fields,Values,true); 

			strSQL="SELECT Sleep From SleepTime Where FunctionId ='" + Convert.ToInt16(FunctionId) + "' AND " + " ActionId = '" + Convert.ToInt16(ActionId) + "'";
			string Temp=objdata.getFieldValue(strSQL); 
			if(!Temp.Equals(""))
			{ 
				double CurrActionSleepTime = Convert.ToDouble(Temp);
				double CurrActionTakes = MinDifference(DateTime.Parse(Ref) , Time);
				double Diff=IsFirstAction ? CurrActionTakes -CurrActionSleepTime-Motivateiontime :CurrActionTakes -CurrActionSleepTime ;
				if(Diff>0)  // there is a sleep time
				{ 
					strSQL = " UPDATE LoginSession SET Sleep = Sleep + " + Diff + " WHERE LogIn= ' " + MainForm.LoginTime + "' AND UserId = '" + Uname + "'";
					objdata.executeCommand(strSQL);
				}
			}

		}
		
		public void RecordAudit(DateTime Time, string Uname , AuditAction ActionId,Function FunctionId,  string key , string Description) 
		{  
						
			double Motivateiontime = 2 ;  // 2 minutes
			bool IsFirstAction=false;	
			string Ref= ""; // used  as reference to calculate Sleep time of Current Action 
			string strSQL = " SELECT * FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "'" ;
			if(objdata.exists(strSQL))  //There is Previous Action 
			{
				strSQL="SELECT TOP 1 Time FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "' ORDER BY Time DESC" ;
				Ref=objdata.getFieldValue(strSQL);
			}
			else  // This is the first Action So take login time as reference
			{
				Ref = MainForm.LoginTime ; 
				IsFirstAction=true; 
			}
			
			
			string Values=  Time + "~" + Uname + "~" + Convert.ToInt16(ActionId) + "~" + Convert.ToInt16(FunctionId) + "~" + key + "~" + Description + "~" + Environment.MachineName;
			string Fields= "[Time],UserId , [ActionId] ,FunctionId,[Key],Description,Machine";
			objdata.addNewRecord("Audit",Fields,Values,true); 


			strSQL="SELECT Sleep From SleepTime Where FunctionId ='" + Convert.ToInt16(FunctionId) + "' AND " + " ActionId = '" + Convert.ToInt16(ActionId) + "'";
			string Temp=objdata.getFieldValue(strSQL); 
			if(!Temp.Equals(""))
			{ 
				double CurrActionSleepTime = Convert.ToDouble(Temp);
				double CurrActionTakes = MinDifference(DateTime.Parse(Ref) , Time);
				double Diff=IsFirstAction ? CurrActionTakes -CurrActionSleepTime-Motivateiontime :CurrActionTakes -CurrActionSleepTime ;
				if(Diff>0)  // there is a sleep time
				{ 
					strSQL = " UPDATE LoginSession SET Sleep = Sleep + " + Diff + " WHERE LogIn= ' " + MainForm.LoginTime + "' AND UserId = '" + Uname + "'";
					objdata.executeCommand(strSQL);
				}
			}


		}

		
		public void RecordLogin(DateTime LogIn,string Uname)
		{
			string Values =Uname + "~" +LogIn + "~" + Environment.MachineName ;
			string Fields="UserId , LogIn , Machine";
			objdata.addNewRecord("LoginSession",Fields ,Values ,true); 
		}
		public void RecordLogOut(DateTime LogIn , DateTime LogOut , string Uname)
		{
			
			
			string Ref= ""; // used  as reference to calculate Sleep time of Current Action 
			string strSQL = " SELECT * FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "'" ;
			if(objdata.exists(strSQL))  //There is Previous Action 
			{
				strSQL="SELECT TOP 1 Time FROM Audit WHERE Time > '" + MainForm.LoginTime + "' AND UserId = '" + Uname + "' ORDER BY Time DESC" ;
				Ref=objdata.getFieldValue(strSQL);
			}
			else  // This is the first Action So take login time as reference
				Ref = MainForm.LoginTime ; 


			double LogOutSleepVal = 1;  // two minutes  ( can be modified
			double CurrActionTakes = MinDifference(DateTime.Parse(Ref) , LogOut);
			double Diff=  CurrActionTakes -LogOutSleepVal ;
			if(Diff>0)  // there is a sleep time
			{ 
				strSQL = " UPDATE LoginSession SET Sleep = Sleep + " + Diff + " WHERE LogIn= ' " + MainForm.LoginTime + "' AND UserId = '" + Uname + "'";
				objdata.executeCommand(strSQL);
			}
	
			
			
			
			
			double TMin = MinDifference(LogIn ,LogOut);
			 strSQL = " UPDATE LoginSession SET LogOut = '" + LogOut + "' , MinWorked= " + TMin  + " WHERE LogIn= '" + LogIn + "' AND UserId = '" + Uname + "'";
			objdata.executeCommand(strSQL); 
		
		}
		public double HrsDifference(DateTime Begin , DateTime End)
		{  
			System.TimeSpan T = End.Subtract(Begin);
			return T.TotalHours ;
		}
		public double MinDifference(DateTime Begin , DateTime End)
		{  
			System.TimeSpan T = End.Subtract(Begin);
			return T.TotalMinutes;
		}

		
		public double  SleepTime(string  LogIn , string LogOut)
		{
			string strWhere=" Time >= '" + LogIn + "' AND Time  <= '" + LogOut+ "' AND UserId = '" + MainForm.strUserName + "'";
			string strSQL = " SELECT Time ,ActionId , FunctionId From Audit WHERE " + strWhere + " ORDER BY Time";
            
			clsData obj = clsData.Instance;      																										              				        				               
			string[,] Input = obj.getRecords(strSQL);
			int inputSize=Input.GetUpperBound(0);
			DateTime Ref = DateTime.Parse(LogIn);
			double Sleep=0;
			for(int i=0 ; i<=inputSize; i++)
			{  
				DateTime Curr = DateTime.Parse(Input[i,0]);
				strSQL="SELECT Sleep From SleepTime Where FunctionId ='" + Input[i,1] + "' AND " + " ActionId = '" + Input[i,2] + "'";
				string Temp=obj.getFieldValue(strSQL); 
				if(Temp!=null) 
				{ 
					double CurrSleep= Convert.ToDouble(Temp) ;
					double Mdiff=MinDifference(Ref,Curr);
					if(Mdiff>CurrSleep)
						Sleep+=Mdiff-CurrSleep;
				}
				Ref=Curr ;
			}
			return Sleep ;
				 
		}

		public bool executeCommand(string strSQL)
		{
			return objdata.executeCommand(strSQL);
		}

		public bool exists(string strSQL)
		{
			return objdata.exists(strSQL);
		}
		public void ExportAudit()
		{
			try
			{

				if(TestConnection()!=true)
				{
					return;
				}

				//bool comat = CheckCompatebility();
				if(CheckCompatebility()==false)
				{
					return;
				}


				#region Audit
				string strConnAudit="data source="+AsName+ ";initial catalog=" + AdName+" ;user id=CourtStarAdmin;password=court2004CS ; Connect Timeout =40";
			
				string strConnCCMS="data source="+sName+ ";initial catalog=" +dName+" ;user id=CourtStarAdmin;password=court2004CS ; Connect Timeout =40";

				string strwhere="";
				SqlConnection conn = new SqlConnection(strConnAudit);

				SqlDataAdapter Adapter= new SqlDataAdapter("select max([Time]) from dbo.Audit",conn);

				conn.Open();
				SqlCommand cmd = new SqlCommand("select max([Time]) from dbo.Audit",conn);
			
				object maxTime= cmd.ExecuteScalar(); 
			
				if(!maxTime.Equals(DBNull.Value))
				{
					strwhere=" where [Time]>'" + maxTime + "'";
				}
				else
				{
					strwhere="";
				}

			
		
			
				string Sql = "INSERT INTO " + AsName.Trim() + "."+ AdName.Trim()+".dbo.Audit ";
				Sql = Sql + "Select * from " + sName.Trim() + "."+ dName.Trim()+".dbo.Audit ";
				Sql = Sql +   strwhere;

				cmd.CommandText = Sql;
				cmd.CommandType = CommandType.Text;

				cmd.ExecuteNonQuery();

				conn.Close();

				#endregion

				#region Login session
 
				conn.Open();

				cmd = new SqlCommand("select max([LogOut]) from dbo.LoginSession",conn);
			
				maxTime= cmd.ExecuteScalar(); 
			
				if(!maxTime.Equals(DBNull.Value))
				{
					strwhere=" where [LogOut]>'" + maxTime + "'";
				}
				else
				{
					strwhere="";
				}

			

		
			
				Sql = "INSERT INTO " + AsName.Trim() + "."+AdName.Trim()+".dbo.LoginSession ";
				Sql = Sql + "Select * from " + sName.Trim() + "."+ dName.Trim()+".dbo.LoginSession ";
				Sql = Sql +   strwhere;

				cmd.CommandText = Sql;
				cmd.CommandType = CommandType.Text;

				cmd.ExecuteNonQuery();

				conn.Close();

				conn.Open();
					
				strwhere="Where UserName Not In ";
				strwhere = strwhere + "(select UserName From " + AsName.Trim() + "." + AdName.Trim()+ ".dbo.Users)";
			
			
			
				Sql = "INSERT INTO " + AsName.Trim() + "."+ AdName.Trim()+".dbo.Users ";
				Sql = Sql + "Select * from " + sName.Trim() + "."+ dName.Trim()+".dbo.Users ";
				Sql = Sql +   strwhere;

				cmd.CommandText = Sql;
				cmd.CommandType = CommandType.Text;

				cmd.ExecuteNonQuery();

		
				conn.Close();
				#endregion 

				#region Settings

				conn.Open();

				Sql = "select count(*) from " + AsName.Trim() + "." + AdName.Trim()+ ".dbo.CaseSettings";
				cmd.CommandText = Sql;
				cmd.CommandType = CommandType.Text;
				int res = (int)cmd.ExecuteScalar();

				if(res<=0)
				{


					strwhere="Where  ThisCourt Not In ";
					strwhere = strwhere + "(select ThisCourt From " + AsName.Trim() + "." + AdName.Trim()+ ".dbo.CaseSettings)";	
					Sql = "INSERT INTO " +AsName.Trim() + "."+ AdName.Trim()+".dbo.CaseSettings ";
					Sql = Sql + "Select ThisCourt from " + sName.Trim() + "." + dName.Trim()+".dbo.CaseSettings ";
					Sql = Sql +   strwhere;

					cmd.CommandText = Sql;
					cmd.CommandType = CommandType.Text;

					cmd.ExecuteNonQuery();

				}

				conn.Close();

				MessageBox.Show("Export Successful","CourtStar");
				#endregion
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"CourtStar");
			}

		}
		

		private bool TestConnection()
		{
				
			SqlConnection conn ;
			try
			{
				if(AsName.Trim()  == "")
				{
					MessageBox.Show("Audit Server is Empty ","CourtStar");
					return false;
				}
				if(AdName.Trim()  == "")
				{
					MessageBox.Show("Audit DataBase is Empty ","CourtStar");
					return false;;
				}
			
				
				
				string strConn="data source="+AsName.Trim()+ ";initial catalog=" + AdName.Trim() +" ;user id=CourtStarAdmin;password=court2004CS ; Connect Timeout =5";
			
				conn = new SqlConnection(strConn);

				conn.Open();
				conn.Close();			
				return true;
			}
			
			catch(Exception ex)
			{

				MessageBox.Show("Audit Server Error \n" + ex.Message,"CourtStar",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);

				return false;
			}

		}


		private bool CheckCompatebility()
		{
			

			try
			{
				string SQl = "select count(*) from  CaseSettings";
				string Connectionstring="data source="+AsName+ ";initial catalog=" + AdName+" ;user id=CourtStarAdmin;password=court2004CS ; Connect Timeout =40";
				SqlConnection Acon = new SqlConnection(Connectionstring);
				Acon.Open();
				SqlCommand cmd = new SqlCommand(SQl,Acon);
			
			
				
			
				object temp =cmd.ExecuteScalar();
				int res = (int)cmd.ExecuteScalar();

				Acon.Close();
				if(res<=0)
					return  true;


				SQl = "select count(*) from  CaseSettings where ThisCourt in (select ThisCourt from " + sName+ "."+ dName.Trim()+".dbo.CaseSettings)";
				Acon.Open();
				cmd = new SqlCommand(SQl,Acon);

				res = (int)cmd.ExecuteScalar();
				Acon.Close();

				if(res >0)
				{
					return true;
				}
				else
				{
					
					string mes = "The Audit data in the Database Named " + AsName + "." + AdName + " is Not Compateble with the Audit data in the database "; 
					mes = mes + sName + "." + dName + " Are You Sure You Want To Continue? ";

					if(MessageBox.Show(mes,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes )
					{
						return true;
					}
					else
					{
						return false;
					}
				
				}
			}
			catch(SqlException seq)
			{
				MessageBox.Show(seq.Message);
				return false;
			}
		}


		private void ReadAuditSetting()
		{
			clsXmlAccess xmlReader=new clsXmlAccess();
			sName=xmlReader.readWord("Name","serverSpec").ToUpper();
			dName=xmlReader.readWord("Name","database"); 
			AsName=xmlReader.readWord("Name","Auditserver");
			AdName=xmlReader.readWord("Name","Auditdatabase"); 
			
			
		}
		
			
	}
	        
		
		
		
		








}

