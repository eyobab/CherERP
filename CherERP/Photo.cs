using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace Belayab
{
    public class clsPhoto
    {
        
        public clsEmployee Employee;
        public clsItem Item;
        public string photopath="";
      
        /// <summary>
        /// to be deleted
        /// </summary>
        public static DataSet DsStuds1;
        public static PictureBox picPhoto;

        public clsData objData = clsData.Instance;


        public void DisplayPhoto()
        {

            photopath = ShowPhoto(DsStuds1, "Photo", "");


            if (photopath != "")
                picPhoto.Load(photopath);
            else
                picPhoto.Image = null;

        }

        public string SavePhoto(string FileName, DataSet ds, string pos)
        {
            if (FileName =="")
                return FileName;

            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Read);

            byte[] MyData = new byte[fs.Length];


            fs.Read(MyData, 0, (int)fs.Length);

      
            fs.Close();

            int rowpos=0;
            DataRow myRow;

            //rowPos = Me.bs.Position;

            myRow = ds.Tables[0].Rows[rowpos];

            myRow["Photo"] = MyData;

            return FileName;
        }


        //'THIS FUNCTION LOADS IMAGE FROM IMAGE DATATYPE FIELD AND SAVES IT INTO A FILE.

        public string ShowPhoto(DataSet ds, string pos, string FileName)
        {

            int rowPos;
          DataRow myRow;

        try
        {
            FileName = Application.StartupPath + "\\photo.jpg";

            rowPos = 0;//bs.Position;


            myRow = ds.Tables[0].Rows[rowPos];

            byte[] myData;

            myData = (byte[])myRow["Photo"];

            long k;

            k = (int)myData.Length;


            FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);

            fs.Write(myData, 0, (int)k);
            fs.Close();

            fs = null;


            return FileName;

            }
            catch (Exception ex) 
                { MessageBox.Show(ex.Message);
                    return "";
                }
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



