using System;
using Microsoft.Win32;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace Belayab
{
	/// <summary>
	/// Summary description for clsUtility.
	/// </summary>
	public class clsUtility
	{

		

		RegistryKey rkCU=Registry.CurrentUser;
		RegistryKey rkLM=Registry.LocalMachine;
		RegistryKey rk1;

		public clsUtility()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public string getRegValue(long lngRegType,string strRegistryLoc, string strRegName)
		{
			if(lngRegType==1)
				rk1=rkLM.CreateSubKey(strRegistryLoc);
			else
				rk1=rkCU.CreateSubKey(strRegistryLoc);

			object objUN=rk1.GetValue(strRegName);

			if(objUN!=null)
				return objUN.ToString();
			else
				return "";
		}

		public void setRegValue(long lngRegType,string strRegistryLoc, string strRegName, string strRegValue)
		{
			if(lngRegType==1)
				rk1=rkLM.CreateSubKey(strRegistryLoc);
			else
				rk1=rkCU.CreateSubKey(strRegistryLoc);

			rk1.SetValue(strRegName,strRegValue);
		}

		public string getYearAmh(string strDateAmh)
		{
			string strYear;
			int intPos;
			
			strDateAmh=strDateAmh.Trim();

			if (strDateAmh.Equals("") )
				return "0";
			else
			{

				strDateAmh=ReverseString(strDateAmh);
				intPos=strDateAmh.IndexOf("/");
		
				strYear=strDateAmh.Substring(0,intPos);
				strYear=ReverseString(strYear);
		
			}

			return strYear;

		}
		public string  ReverseString(string strValue)
		{
			string strReversed="";
			for(int i=strValue.Length-1;i>=0;i--)
				strReversed=strReversed+strValue.Substring(i,1);

			return strReversed;

		}
		

				
		public bool isWholeNumber(string strVal)
		{
			bool bInteger=false;
			strVal=strVal.Trim();

			for(int i=0;i<strVal.Length;i++)
			{
				if((strVal[i]>='0' && strVal[i]<='9') )
					bInteger=true;
				else
					return false;

			}
			
			return bInteger;

		}

			
		public bool isInteger(string strVal)
		{
			bool bInteger=false;
			strVal=strVal.Trim();

			for(int i=0;i<strVal.Length;i++)
			{
				if((strVal[i]>='0' && strVal[i]<='9')|| strVal[i]=='-' )
					bInteger=true;
				else
					return false;

			}
			
			return bInteger;

		}

		public bool isNumeric(string strVal)
		{
			bool bNumeric=false;
			strVal=strVal.Trim();

			for(int i=0;i<strVal.Length;i++)
			{
				if((strVal[i]>='0' && strVal[i]<='9') || strVal[i]=='.' || strVal[i]=='-')
					bNumeric=true;
				else
					return false;

			}
			
			return bNumeric;

		}

		public bool isFileNumber(string strVal)
		{
			bool bFileNumber=false;
			strVal=strVal.Trim();

			for(int i=0;i<strVal.Length;i++)
			{
				if((strVal[i]>='0' && strVal[i]<='9') || strVal[i]=='/')
					bFileNumber=true;
				else
					return false;

			}
			
			return bFileNumber;

		}
		public void addToCombo(System.Windows.Forms.ComboBox cmbBox, string[] Vals,bool bSelFirstIndex)
		{
            try
            {
                cmbBox.Items.Clear();

                for (int i = 0; i < Vals.Length; i++)
                {
                    if (Vals[i].ToString() != "")
                        cmbBox.Items.Add(Vals[i]);
                }
                if (cmbBox.Items.Count > 0 && bSelFirstIndex) cmbBox.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

		}
		public void addToComboWithIndex(System.Windows.Forms.ComboBox cmbBox, string[,] Vals,ref int[] intIndex)
		{
			int i=0;
			cmbBox.Items.Clear();
			intIndex=new int[Vals.GetUpperBound(0)+1];
			for (i=0; i<=Vals.GetUpperBound(0);i++)
			{
				if (!Vals[i,1].Equals(""))
				{
					cmbBox.Items.Add(Vals[i,1]);
					intIndex[i]=Int32.Parse(Vals[i,0]);
				}
			}
		}

		
		public void addToListBox(System.Windows.Forms.ListBox lstBox, string[] Vals,bool bSelFirstIndex)
		{
			lstBox.Items.Clear();
			for (int i=0; i<Vals.Length;i++)
			{
				if (Vals[i].ToString()!="")	
					lstBox.Items.Add(Vals[i]);
			}
			if(lstBox.Items.Count>0 && bSelFirstIndex)	lstBox.SelectedIndex=0;
		}

		public void addToArrayListCollection(ArrayList arrList, string[] Vals)
		{
			arrList.Clear();
			for (int i=0; i<Vals.Length;i++)
				if (Vals[i].ToString()!="")	
					arrList.Add(Vals[i]);
		}

        

        public void fillComboValues(ComboBox cb, string strSQL)
        {
            try
            {
                if (clsData.connBel.State == ConnectionState.Open)
                {
                    clsData.connBel.Close();
                    clsData.connBel.Open();
                }
                SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);
               
                DataSet ds = new DataSet();
                da.Fill(ds, "Table");
                //    cb.DataSource = null;
                //   cb.Items.Clear();
                cb.DataSource = ds.Tables[0];
                //if (cb.Items.Count > 0) cb.SelectedIndex = 0;
                da.SelectCommand.Connection = null;
                da.Dispose();
                da = null;
                
            }
            catch (Exception ex) { 
              MessageBox.Show(ex.Message);
            }

        }

        public void fillComboValues(DataGridViewComboBoxColumn cb, string strSQL)
        {
            try
            {
                if (clsData.connBel.State == ConnectionState.Open)
                {
                    clsData.connBel.Close();
                    clsData.connBel.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);

                DataSet ds = new DataSet();
                da.Fill(ds, "Table");
                //    cb.DataSource = null;
                //   cb.Items.Clear();
                cb.DataSource = ds.Tables[0];
                //if (cb.Items.Count > 0) cb.SelectedIndex = 0;

                da.SelectCommand = null;
                //da.SelectCommand.Dispose();
                da.Dispose();
                da = null;

            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

       
        public void fillComboValuesWithAll(ComboBox cb, string strSQL, Boolean setAll=true)
        {

            SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);
            DataSet ds = new DataSet();

            try
            {
                if (clsData.connBel.State == ConnectionState.Open)
                {
                    clsData.connBel.Close();
                    clsData.connBel.Open();
                }

                
                da.Fill(ds, "Table");

                DataRow row = ds.Tables[0].NewRow();
                row[0] = "000";
                row[1] = "All";
                //  row["MDescription"] = "All";
                ds.Tables[0].Rows.Add(row);
                cb.DataSource = ds.Tables[0];
                if (setAll)  cb.SelectedValue = "000";
                                      
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                da = null;
                ds.Dispose();

            }
        }


        public void makeCellEditable(DataGridViewEditingControlShowingEventArgs e)
            {
            try
            {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null)
                {
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


                    cb.Width = 2 * cb.Width;
                }
            }
            catch (Exception ex) { }
        }
        
        public void AddComboValues(ComboBox cb, string strSQL)
        {
            if (clsData.connBel.State != ConnectionState.Open) clsData.connBel.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);

            DataSet ds = new DataSet();
           

            da.Fill(ds, "Table");


            DataRow row = ds.Tables[0].NewRow();
            row["VehicleType"] = "All";
          //  row["MDescription"] = "All";
            ds.Tables[0].Rows.Add(row);


            cb.DataSource = null;
            
            cb.Items.Clear();

            cb.DataSource = ds.Tables[0];
            
           
            if (cb.Items.Count > 0) cb.SelectedIndex = 0;



        }

        public void AddComboValues(ComboBox cb, string strSQL, string colName)
        {
            if (clsData.connBel.State != ConnectionState.Open) clsData.connBel.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);

            DataSet ds = new DataSet();


            da.Fill(ds, "Table");


            DataRow row = ds.Tables[0].NewRow();
            row[colName] = "All";
            //  row["MDescription"] = "All";
            ds.Tables[0].Rows.Add(row);


            cb.DataSource = null;

            cb.Items.Clear();

            cb.DataSource = ds.Tables[0];


            if (cb.Items.Count > 0) cb.SelectedIndex = 0;



        }

        public void enableControl(ComboBox cbx1)
        {

            if (clsVariables.sEmployeeDepartment.ToUpper() != "ADMIN" && clsVariables.userRole.ToUpper() != "APPROVER" && clsVariables.sUsername.Trim().ToUpper() != "ADMIN")
            {
                cbx1.Visible = true;
                cbx1.Enabled = false;
                //lstToolStripMenuItem.Visible = false;
            }
            else
            {
                cbx1.Visible = true;
                cbx1.Enabled = true;
                //lstToolStripMenuItem.Visible = false;
            }
        }

        public void enableIssueControl(ComboBox cbx1)
        {

            if ( clsVariables.userRole.ToUpper() != "STORE HEAD")
            {
                cbx1.Visible = true;
                cbx1.Enabled = false;
                //lstToolStripMenuItem.Visible = false;
            }
            else if (clsVariables.userRole.ToUpper() != "STORE CLERK")
            {

            }
            else
            {
                cbx1.Visible = true;
                cbx1.Enabled = true;
                //lstToolStripMenuItem.Visible = false;
            }
        }


        public void setApprover(ComboBox cbxStatus, ComboBox cbxAppr)
        {
            if (cbxStatus.Text.Trim().ToUpper() == "APPROVED")
                cbxAppr.Text = clsVariables.sUserEmployeeName;
            //else
            //    cbxAppr.Text = "";

            
        }

        public void ExportToExcel(DataGridView dv, string strFileName ="Exported_")
        {
            /// <summary> 
            /// Exports the datagridview values to Excel. The sample code is taken from MSDN online
            /// </summary> 

            //////// Creating a Excel object. 
            //////Excel._Application excel = new Excel.Application();
            //////Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            //////Excel.Worksheet worksheet = null;  // excel.ActiveSheet;

            //  Excel.Worksheet worksheet = excel.ActiveSheet;

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)app.ActiveSheet;

            //// get the reference of first sheet. By default its name is Sheet1.  
            //// store its reference to worksheet  
            //Object obj = (Object)workbook.Sheets["Sheet1"];
            //worksheet = (Excel.Worksheet)obj;
            ////////  worksheet = workbook.ActiveSheet;
            //// changing the name of active sheet  

            worksheet.Name = "Export_";

          //  AlertLabel.Visible = true;


            try
            {

                ////////Object obj = (Object)workbook.Worksheets[0];
                ////////    worksheet = (Excel.Worksheet)obj;
                ////////   worksheet.Name = "Export";

                //////    worksheet = workbook.ActiveSheet;

                ////  //  worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                //Loop through each row and read value from each column.

                for (int j = 0; j < dv.Columns.Count; j++)
                {
                    worksheet.Cells[cellRowIndex, cellColumnIndex] = dv.Columns[j].HeaderText;
                    cellColumnIndex++;
                }

                cellColumnIndex = 1;
                cellRowIndex++;
                //Loop through each row and read value from each column.
                for (int i = 0; i < dv.Rows.Count; i++)
                {
                    for (int j = 0; j < dv.Columns.Count; j++)
                    {
                        worksheet.Cells[cellRowIndex, cellColumnIndex] = dv.Rows[i].Cells[j].Value.ToString();
                        cellColumnIndex++;
                    }


                    cellColumnIndex = 1;
                    cellRowIndex++;
                }


                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = strFileName;

                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //AlertLabel.Visible = false;

                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");

                    //see the excel sheet behind the program
                    app.Visible = true;

                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // app.Quit();
               // AlertLabel.Visible = false;
                workbook = null;
                app = null;
            }

        }
        public void fillGridComboValues(DataGridViewComboBoxCell.ObjectCollection  col , string strSQL)
        {
           
            if (clsData.connBel.State != ConnectionState.Open) clsData.connBel.Open();

            SqlDataAdapter da = new SqlDataAdapter(strSQL, clsData.connBel);

            DataSet ds = new DataSet();
            da.Fill(ds, "Table");
            DataRow dr;
            
            //for( int i = 0; i< ds.Tables[0].Rows.Count ;i++)
            //      col.Add (dr[1].ToString);
        }

        public void FillListViewData(ListView lv, DataTable dt, int flds)
        {
            lv.Items.Clear();
            
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem itm = new ListViewItem(row[1].ToString());
                for (int i =0 ; i<flds; i++)
                     itm.SubItems.Add(row[i].ToString());
                lv.Items.AddRange(new ListViewItem[] { itm });
                if (lv.Items.Count > 0) lv.Items[0].Selected = true;
            }
        }

		public int getComboIndex(System.Windows.Forms.ComboBox cmbBox, string strValue)
		{
			for (int i=0; i<cmbBox.Items.Count;i++)
				if (cmbBox.Items[i].ToString().Trim().Equals(strValue.Trim()))
					return i;
			return -1;
		}


        public void sortGrid(DataGridView dv, int ord, string colName)
        {
                if (ord == 1)
                    dv.Sort(dv.Columns[colName], ListSortDirection.Ascending);
                else
                    dv.Sort(dv.Columns[colName], ListSortDirection.Descending);

             

        }
        public bool isDataValid(Control ctrlName)
        {


            foreach (Control Cont in ctrlName.Controls)
            {
                if (Cont.Tag != null)
                {

                    if (Cont.Tag.ToString().StartsWith("REQ-") && Cont.Text.Trim().Equals(""))
                    {
                        MessageBox.Show(Cont.Tag.ToString().Substring(4), "Stosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cont.Focus();
                        return false;
                    }

                }
            }
           
            return true;
        }

  
      
    

		public void clearControls(Control ctrlName)
		{
			foreach(Control Cont in ctrlName.Controls)
			{				
				if(Cont.GetType().Name.Equals("ComboBox"))
				{
					ComboBox cmbBx = (System.Windows.Forms.ComboBox)Cont ;
					cmbBx.SelectedIndex=-1;
				}
					
				else if(Cont.GetType().Name.Equals("CheckBox"))
				{
					CheckBox chkBx = (System.Windows.Forms.CheckBox)Cont ;
					chkBx.Checked=false;
				}
				else if(Cont.GetType().Name.Equals("TextBox"))
				{
					Cont.Text="";
				}	
			}
		}

		public string getHashedValue(string strToHash)
		{
			//hashes a string input and returns the hashed string output
			byte[] byteArrHashedResult; 
			ASCIIEncoding myAscii = new ASCIIEncoding();
			byte[] byteArrToHash = myAscii.GetBytes(strToHash);
			SHA1 sha = new SHA1CryptoServiceProvider(); 
			byteArrHashedResult = sha.ComputeHash(byteArrToHash);
			string strHashedResult="";
			for(int i=0;i<byteArrHashedResult.Length;i++)
				strHashedResult+=byteArrHashedResult[i].ToString();

			return strHashedResult;

		}

		public void logEvent()
		{
		}

		public void logError()
		{
		}

  

public string  NumberToText(string only_number)
{

    if (only_number.Length  > 66 || only_number.Length  == 0)
        return "";
    else
    {
        if (ValidateNumber(ref only_number)==0)
        {
            return "";
        }
           
    }

    string  [] one_array = {
        " ","one ", "two ", "three ", "four ", "five ","six ", "seven ", "eight ", "nine "
	};

    string  [] ten_array = {
		"ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", 
		"seventeen ", "eighteen ", "nineteen "
	};
    string  [] twenty_array= {
        " "," ","twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety "
	};
	string [] big_unit_array = {"vigintillion","novemdecillion","octodecillion","septendecillion",
		                           "sexdecillion","quindecillion","quattuordecillion","tredecillion",
								   "duodecillion","undecillion","decillion","nonillion","octillion",
								   "septillion","sextillion","quintillion","quadrillion","trillion ", 
								   "billion ", "million ", "thounsand ", "hundred "};
	const int MaxUnit = 21;
	string [] tempString = new string[150];
	//E.g. 1,234,567,890,123
	int i; //for only_number
	int j; //for tempString
	int rem;
	int sizeofNumber = (only_number.Length);
	bool tflag = false;
	for(i=0,j=0; i<sizeofNumber; i++) 
	{
		rem = (sizeofNumber-i)%3;
		if(rem == 0)
			tflag = false;
		if(only_number[i] != '0') 
		{
			if(rem == 1) //in oneth position
			{
                tempString[j++]=one_array[only_number[i]-48];
				tflag = true;
			}
			else if(rem == 2) 
			{ //in tenth position
                if(only_number[i] == '1')
					tempString[j++]=ten_array[only_number[++i]-48];
                else
					tempString[j++]=twenty_array[only_number[i]-48];
				tflag = true;
            }
            else if(rem == 0) 
			{// in hundredth position
				tempString[j++] =one_array[only_number[i]-48];
				tempString[j++]=big_unit_array[MaxUnit];
				tflag = true;
			}
		}
		if(tflag)
		{
			switch(sizeofNumber-i) 
			{
				//select which big_unit_array to be placed behind the number
			case 64: tempString[j++]=big_unit_array[MaxUnit-21]; break;
			case 61: tempString[j++]=big_unit_array[MaxUnit-20]; break;
			case 58: tempString[j++]=big_unit_array[MaxUnit-19]; break;
			case 55: tempString[j++]=big_unit_array[MaxUnit-18]; break;
			case 52: tempString[j++]=big_unit_array[MaxUnit-17]; break;
			case 49: tempString[j++]=big_unit_array[MaxUnit-16]; break;
			case 46: tempString[j++]=big_unit_array[MaxUnit-15]; break;
			case 43: tempString[j++]=big_unit_array[MaxUnit-14]; break;
			case 40: tempString[j++]=big_unit_array[MaxUnit-13]; break;
			case 37: tempString[j++]=big_unit_array[MaxUnit-12]; break;
			case 34: tempString[j++]=big_unit_array[MaxUnit-11]; break;
			case 31: tempString[j++]=big_unit_array[MaxUnit-10]; break;
			case 28: tempString[j++]=big_unit_array[MaxUnit-9]; break;
			case 25: tempString[j++]=big_unit_array[MaxUnit-8]; break;
			case 22: tempString[j++]=big_unit_array[MaxUnit-7]; break;
			case 19: tempString[j++]=big_unit_array[MaxUnit-6]; break;
			case 16: tempString[j++]=big_unit_array[MaxUnit-5]; break;
			case 13: tempString[j++]=big_unit_array[MaxUnit-4]; break;
			case 10: tempString[j++]=big_unit_array[MaxUnit-3]; break;
			case 7 : tempString[j++]=big_unit_array[MaxUnit-2]; break;
			case 4 : tempString[j++]=big_unit_array[MaxUnit-1]; break;
			}
		}
	}
	j--; 
	//to minus an extra increment of j
	//paste text from tempString to outputString

    string outputString;
    outputString=tempString[0];
    for(i=1; i<=j; i++)
       outputString+= tempString[i];
    
    
    return outputString;
}
/* End of NumberToText() */

int ValidateNumber(ref string number)
{
    string tempString="";
    int i;
    int len = number.Length ;
    for(i=0; i<len; i++)
	{
		if(isNumeric(number[i].ToString()))
			tempString+= number[i];
		else
			break;
	}
	number=tempString;
	if (tempString != "")
    return 1;
    else return 0;

}

 public string VoucherSymbol(String vType)
        {
            string vSymbol = "";
            switch (vType)
            {
                case "Import": vSymbol = "IM-"; break;
                case "Local":  vSymbol = "LO-"; break;
                case "InOut": vSymbol = "IO-"; break;
                case "Canibalized": vSymbol= "CA"; break;

            }

            return vSymbol;

        }

 



       
/* End of ValidateNumber() */


        
        
        
        public delegate int BFFCALLBACK ( IntPtr hwnd, uint uMsg, IntPtr lParam, IntPtr lpData );


		public struct BROWSEINFO
		{
			public IntPtr       hwndOwner;
			public IntPtr       pidlRoot;
			public IntPtr       pszDisplayName;
			[MarshalAs ( UnmanagedType.LPTStr )]
			public string       lpszTitle;
			public int          ulFlags;
			[MarshalAs ( UnmanagedType.FunctionPtr )]
			public BFFCALLBACK  lpfn;
			public IntPtr       lParam;
			public int          iImage;
		}




		// C# representation of the IMalloc interface.
		[InterfaceType ( ComInterfaceType.InterfaceIsIUnknown ),
			Guid ( "00000002-0000-0000-C000-000000000046" )]
			public interface IMalloc
		{
			[PreserveSig] IntPtr Alloc ( [In] int cb );
			[PreserveSig] IntPtr Realloc ( [In] IntPtr pv, [In] int cb );
			[PreserveSig] void   Free ( [In] IntPtr pv );
			[PreserveSig] int    GetSize ( [In] IntPtr pv );
			[PreserveSig] int    DidAlloc ( IntPtr pv );
			[PreserveSig] void   HeapMinimize ( );
		}

		[DllImport("User32.DLL")]
		public static extern IntPtr GetActiveWindow ( );


		[DllImport ( "Shell32.DLL" )]
		public static extern int SHGetMalloc ( out IMalloc ppMalloc );

		[DllImport ( "Shell32.DLL" )]
		public static extern int SHGetSpecialFolderLocation ( 
			IntPtr hwndOwner, int nFolder, out IntPtr ppidl );

		[DllImport ( "Shell32.DLL" )]
		public static extern int SHGetPathFromIDList ( 
			IntPtr pidl, StringBuilder Path );

		[DllImport ( "Shell32.DLL", CharSet=CharSet.Auto )]
		public static extern IntPtr SHBrowseForFolder ( ref BROWSEINFO bi );



	}
}

