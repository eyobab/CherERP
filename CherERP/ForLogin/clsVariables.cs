using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Belayab

{
    class clsVariables
    {
        ////SQL CONNECTION VARIABLES
        //public SqlConnection conn = new SqlConnection();

        ////SQL DATA ADAPTER VARIABLES
        //public SqlDataAdapter sAdapter = new SqlDataAdapter();

        ////DATASET VARIABLES
        //public DataSet sDataSet = new DataSet();

        //LISTVIEW COLUMN SORTER VARIABLES
        //public ListViewColumnSorter lvwColumnSorter = null;

        //BOOL VARIABLES
        public static bool allow = false;
        public static bool sUserIsEmployee=true;

        //LONG VARIABLES
        public long m_lImageFileLength = 0;
        public long PAGE_CURRENT;
        public long PAGE_NEXT;
        public long PAGE_PREVIOUS;
        public long PAGE_TOTAL;

        //User VARIABLES
        public static string sMessageBox = "Belayab Stock and Sales";
        public static string sUserEmployeeId;
        public static string sUserEmployeeName;
        public static string sEmployeeDepartment;
        public static string sUsername;
        public static string sUserFullname;
        public static string sUserLogin;
        public static string sUserType;
        public static string sDBUserID = "";
        public static string sDBPassword= "goodwork";
        public static string curUserName = "";
        public static string userRole = "";
        public static string sCompanyName;
        public static string sContactName;
        public static string sCompanyAddress;
        public static string sPhoneNumber;
        public static string sFaxNumber;
        public static string sEmailAddress;
        public static string sWebAddress;

        //Server VARIABLES
        public static string sServer;
        public static string sDatabase="";
     

        //Context (Branch) Values
        public static string sBranch="Saris";
        public static string sStore = "HOS1";
        

        //Percentages
        public static decimal VATAmt;
        public static decimal OHAmt;
        //public static decimal OHAmt;
        public static decimal OHAmt1k =0.2M;
        public static decimal OHAmt10k=0.15M;
        public static decimal OHAmt25k=0.1M;
        public static decimal OHAmt50k=0.00M;
        public static decimal OHAmt100k=0.05M;
        public static decimal OHAmt100kl=0.03M;

   

        //Labor rate
        public static decimal mLaborRate = 0M;

        //BYTE VARIABLES
        public static byte[] m_barrImg;

        //FILE DIALOG VARIABLES
        public OpenFileDialog openIMG = new OpenFileDialog();
    }
}
