using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;


namespace Belayab
{
    public partial class FrmViewItemDetails_Tx : Form
    {
        //  clsData objData = new clsData();
        DataSet ds = new DataSet();
        DataSet dsTr = new DataSet();

        clsUtility objUtility = new clsUtility();

        SqlDataAdapter da;// = new SqlDataAdapter("",clsData.connBel);

        BindingSource bsItem = new BindingSource();
        BindingSource bsReceived = new BindingSource();
        BindingSource bsIssued = new BindingSource();
        BindingSource bsTransferIn = new BindingSource();
        BindingSource bsTransferOut = new BindingSource();

        string store;
        string partNum = "";
        string strBetween= "";
        string sqlStr = "";
        string strWhichtore = "";

        public bool showstoreAll = false;


        ////GridModel gridModel = null;
        ////GridModelDataBinder gridBinder = null;


        public FrmViewItemDetails_Tx()
        {
            InitializeComponent();
        }

        public FrmViewItemDetails_Tx(string pn)
        {
            InitializeComponent();
            partNum = pn;
        }

        private void FrmViewItemDetails_Load(object sender, EventArgs e)
        {
            try
            {

                Program.waitForm.Hide();
            }
            catch (Exception ex) { }
          
            if (showstoreAll)
                store = "All";
            else
                store = clsVariables.sStore;

            showItemDetails();

            
            DateTime dt = DateTime.Today;

            //if  (dt.Month < 7 || (dt.Month == 7 && dt.Day <= 7))
            //    dt = dt.AddYears(-1);
            if (dt.Month <=6 ) dt = dt.AddYears(-1);

            dateFrom.Value = Convert.ToDateTime("07/" + "01/" + string.Format("{0:yyyy}", dt).ToString());

        }

        private void FrmViewItemDetails_Resize(object sender, EventArgs e)
        {
            grdIssued.Width = this.Width;
            grdIssued.Height = this.Height - 20;
            grdIssued.Top = 1;

        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {

            ////GridPrintDocument pd;
            ////PrintPreviewDialog ppv = new PrintPreviewDialog();
            ////if (tabItemTran.SelectedIndex == 0)
            ////    pd = new GridPrintDocument(this.grdTranList.TableControl, true);
            ////else
            ////    pd = new GridPrintDocument(this.fpItemList.TableControl, true);

            ////ppv.Document = pd;
            ////pd.DefaultPageSettings.Landscape = true;
            ////pd.DefaultPageSettings.Margins.Left = 50;
            ////pd.DefaultPageSettings.Margins.Right = 50;
            ////pd.DefaultPageSettings.Margins.Top = 50;
            ////pd.DefaultPageSettings.Margins.Bottom = 50;

            ////ppv.ShowDialog();


        }

   

        private void showItemDetails()
        {
           string str = " ItemID ='" + partNum + "'";

          if (showstoreAll)
              store = "All";
           else
              store = clsVariables.sStore;

            try
            {
                
                {

                    if (partNum != "")
                        sqlStr =
                      "SELECT ItemCurrentBalance.ItemID, Items.Description, ItemCurrentBalance.FirstQty As YearBegin, ItemCurrentBalance.YearIn, ItemCurrentBalance.YearOut, ItemCurrentBalance.CurrentBalance, ItemCurrentBalance.BalanceDate, " +
                      " ItemCurrentBalance.BranchID FROM ItemCurrentBalance INNER JOIN Items ON ItemCurrentBalance.ItemID = Items.ItemID " +
                      " Where dbo.Items.ItemID ='" + partNum + "' and ItemCurrentBalance.BranchID ='" + clsVariables.sStore + "'  ORDER BY dbo.Items.Description ";

                    else

                        sqlStr =
                      "SELECT ItemCurrentBalance.ItemID, Items.Description, ItemCurrentBalance.FirstQty As YearBegin, ItemCurrentBalance.YearIn, ItemCurrentBalance.YearOut, ItemCurrentBalance.CurrentBalance, ItemCurrentBalance.BalanceDate, " +
                        " ItemCurrentBalance.BranchID FROM ItemCurrentBalance INNER JOIN Items ON ItemCurrentBalance.ItemID = Items.ItemID " +
                      " Where ItemCurrentBalance.BranchID ='" + clsVariables.sStore + "'  ORDER BY dbo.Items.Description ";

                     /*
                          if (partNum != "")
                          sqlStr =
                           "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.ItemID, dbo.Items.PartNumber, dbo.fItemReceived(ItemID, '" + store + "') AS [Total In], " +
                           " dbo.fItemSoldIssued(ItemID, '" + store + "') AS [Total Out], dbo.fItemInStock(ItemID, '" + store + "') as [In Stock] ,dbo.Categories.CategoryName AS Category, '" + store + "' as Store , " +
                             " dbo.Items.OrderLevel AS [Reorder Level] FROM dbo.Items INNER JOIN " +
                                       "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                                       " Where dbo.Items.ItemID ='" + partNum + "' ORDER BY dbo.Items.Description";

                      else
                          sqlStr = " SELECT  dbo.Items.Description, dbo.Items.ItemID, dbo.Items.PartNumber, dbo.fItemReceived(ItemID, '" + store + "') AS [Total In],  " +
                       " dbo.fItemSoldIssued(ItemID, '" + store + "') AS  [Total Out],dbo.fItemInStock(ItemID,'" + store + "') as [In Stock] ,dbo.Categories.CategoryName " +
                       " AS Category, '" + store + "' as Store  , dbo.Items.OrderLevel AS [Reorder Level]  FROM dbo.Items INNER JOIN " +
                       " dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId  ORDER BY dbo.Items.Description";
                   
                        */


                    if (da == null) da = new SqlDataAdapter(sqlStr, clsData.connBel);

                    clearDataSet(ds);
                    //    clearDataSet(dsTr);

                    da.Fill(ds, "Items");
                    //  da.Fill(dsTr, "Items");

                    //  MessageBox.Show(ds.Tables["Items"].Rows.Count.ToString());

                    getData();

                    //Fill the Store Combo values

                    string sql = "Select StoreID, StoreName From Stores Order by StoreName";
                    objUtility.fillComboValuesWithAll(cboStoreList, sql);
                    ////cboStoreList.DisplayMember = "StoreName";
                    ////cboStoreList.ValueMember = "StoreID";

                }

        
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        public void includeWhichStore(bool add)
        {
            if (add)
            { if (strWhichtore != "") sqlStr += " And " + strWhichtore; }
            else
              if(strWhichtore!="")  sqlStr += " Where " + strWhichtore;
        }

        private void getData()
        {

            if (!showstoreAll)
            {
                //For the Initial Quantities listing
                sqlStr = "Select * from Items_Quantities Where StoreID='" + store + "'";
                //     if (strBetween != null && strBetween != "") sqlStr += " Where [Date] " + strBetween;
                da.SelectCommand.CommandText = sqlStr;
                // ds.Tables["ItemBegin"].Clear();
                da.Fill(ds, "ItemBegin");

                ds.Relations.Add("Begining Qty",
                   ds.Tables["Items"].Columns["ItemID"],
                       ds.Tables["ItemBegin"].Columns["ItemID"], false);


                sqlStr = "Select * From rev_ReceivedHistory Where StoreID='" + store + "'";
                if (strBetween != null && strBetween != "") sqlStr += " And ReceivedDate " + strBetween;


                da.SelectCommand.CommandText = sqlStr;
                da.Fill(ds, "Received");


                ds.Relations.Add("Received History",
                    ds.Tables["Items"].Columns["ItemID"],
                        ds.Tables["Received"].Columns["ItemID"], false);


                //sqlStr = "Select * From rev_InvoiceHistory ";//where ItemID ='" + partNum + "'";
                //if (partNum != "") sqlStr += str;

                //da.SelectCommand.CommandText = sqlStr;
                //da.Fill(ds, "Invoices");

                //ds.Relations.Add("Invoice History",
                //ds.Tables["Items"].Columns["ItemID"],
                //ds.Tables["Invoices"].Columns["ItemID"]);


                sqlStr = "Select * From rev_IssuedHistory Where StoreID='" + store + "'";
                if (strBetween != null && strBetween != "") sqlStr += " And IssuedDate " + strBetween;


                da.SelectCommand.CommandText = sqlStr;
                da.Fill(ds, "Issued");

                ds.Relations.Add("Issued History",
                ds.Tables["Items"].Columns["ItemID"],
                ds.Tables["Issued"].Columns["ItemID"], false);


                //For the transaction listing
                sqlStr = "Select * from rpt_ItemTransaction_INV_GRN Where Store='" + store + "'";
                if (strBetween != null && strBetween != "") sqlStr += " Where [Date] " + strBetween;


                da.SelectCommand.CommandText = sqlStr;

                //da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction";
                da.Fill(ds, "ItemTrans");

                DataSet dss = new DataSet();
               
                
                da.Fill(dss, "ItemTrans");

                // Test for all Item Trans list

             ////   dataGridView1.DataSource = dss;
             ////    dataGridView1.DataMember = "ItemTrans";

                ds.Relations.Add("Trans",
                ds.Tables["Items"].Columns["ItemID"],
                ds.Tables["ItemTrans"].Columns["ItemID"], false);

                // MessageBox.Show(dsTr.Tables["Items"].Rows.Count.ToString());

                // LInk the transaction grid

                bsItem.DataSource = ds;
                bsItem.DataMember = "Items";

                grdTranList.DataSource = bsItem;

                //Set the received data source
                bsReceived.DataSource = bsItem;
                bsReceived.DataMember = "Received History";

                grdReceived.DataSource = bsReceived;

                //////Set the issued data source
                bsIssued.DataSource = bsItem;
                bsIssued.DataMember = "Issued History";

                grdIssued.DataSource = bsIssued;

                //Set the transfer-in data source
                bsTransferIn.DataSource = bsItem;
                bsTransferIn.DataMember = "Trans";

                grdTransferIn.DataSource = bsTransferIn;
               
            }
            else
            {
                //For the Initial Quantities listing
                sqlStr = "Select * from Items_Quantities ";
                //     if (strBetween != null && strBetween != "") sqlStr += " Where [Date] " + strBetween;
                da.SelectCommand.CommandText = sqlStr;
                // ds.Tables["ItemBegin"].Clear();
                da.Fill(ds, "ItemBegin");

                ds.Relations.Add("Begining Qty",
                   ds.Tables["Items"].Columns["ItemID"],
                       ds.Tables["ItemBegin"].Columns["ItemID"], false);


                sqlStr = "Select * From rev_ReceivedHistory ";
                if (strBetween != null && strBetween != "") sqlStr += " Where ReceivedDate " + strBetween;


                da.SelectCommand.CommandText = sqlStr;
                da.Fill(ds, "Received");


                ds.Relations.Add("Received History",
                    ds.Tables["Items"].Columns["ItemID"],
                        ds.Tables["Received"].Columns["ItemID"], false);


           
                sqlStr = "Select * From rev_IssuedHistory";
                if (strBetween != null && strBetween != "") sqlStr += " And IssuedDate " + strBetween;

        
                da.SelectCommand.CommandText = sqlStr;
                da.Fill(ds, "Issued");

                ds.Relations.Add("Issued History",
                ds.Tables["Items"].Columns["ItemID"],
                ds.Tables["Issued"].Columns["ItemID"], false);


                //For the transaction listing
                sqlStr = "Select * from rpt_Item_Values_In_Store Where ItemID='" + partNum +"'";
              //  if (strBetween != null && strBetween != "") sqlStr += " Where [Date] " + strBetween;


                da.SelectCommand.CommandText = sqlStr;

                //da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction";
                da.Fill(ds, "ItemTrans");

                ds.Relations.Add("Trans",
               ds.Tables["Items"].Columns["ItemID"],
               ds.Tables["ItemTrans"].Columns["ItemID"], false);
                
   
                //       MessageBox.Show(dsTr.Tables["Items"].Rows.Count.ToString());

                // LInk the transaction grid

                bsItem.DataSource = ds;
                bsItem.DataMember = "Items";

                grdTranList.DataSource = bsItem;

                //Set the received data source
                bsReceived.DataSource = bsItem;
                bsReceived.DataMember = "Received History";

                grdReceived.DataSource = bsReceived;

                //////Set the issued data source
                bsIssued.DataSource = bsItem;
                bsIssued.DataMember = "Issued History";

                grdIssued.DataSource = bsIssued;

                //Set the transfer-in data source
                bsTransferIn.DataSource = bsItem;
                bsTransferIn.DataMember = "Trans";

                grdTransferIn.DataSource = bsTransferIn;
               
            }

        }

        private void reLoadData()
        {

            if (!showstoreAll)
            {

                sqlStr = "Select * From rev_ReceivedHistory Where StoreID='" + store + "'";
                if (strBetween != null && strBetween != "")
                {
                    sqlStr += " And ReceivedDate " + strBetween;
                    includeWhichStore(true);
                }
                else
                    includeWhichStore(false);
                da.SelectCommand.CommandText = sqlStr;
                ds.Tables["Received"].Clear();
                da.Fill(ds, "Received");


                sqlStr = "Select * From rev_IssuedHistory Where StoreID='" + store + "'";
                if (strBetween != null && strBetween != "")
                {
                    sqlStr += " And IssueDate " + strBetween;
                    includeWhichStore(true);
                }
                else
                    includeWhichStore(false);

                da.SelectCommand.CommandText = sqlStr;
                ds.Tables["Issued"].Clear();
                da.Fill(ds, "Issued");


                //For the transaction listing
                sqlStr = "Select * from rpt_ItemTransaction_INV_GRN Where Store='" + store + "'";
                if (strBetween != null && strBetween != "") sqlStr += " And [Date] " + strBetween;
                da.SelectCommand.CommandText = sqlStr;
                ds.Tables["ItemTrans"].Clear();
                da.Fill(ds, "ItemTrans");
            }
            else
            {
                         
            sqlStr = "Select * From rev_ReceivedHistory ";
            if (strBetween != null && strBetween != "")
            {
                sqlStr += " Where ReceivedDate " + strBetween;
                includeWhichStore(true);
            }
            else
                includeWhichStore(false);
            da.SelectCommand.CommandText = sqlStr;
            ds.Tables["Received"].Clear();
            da.Fill(ds, "Received");


            sqlStr = "Select * From rev_IssuedHistory ";
            if (strBetween != null && strBetween != "")
            {
                sqlStr += " Where IssueDate " + strBetween;
                includeWhichStore(true);
            }
            else
                includeWhichStore(false);

            da.SelectCommand.CommandText = sqlStr;
            ds.Tables["Issued"].Clear();
            da.Fill(ds, "Issued");


            //For the transaction listing
            sqlStr = "Select * from rpt_Item_Values_In_Store Where ItemID='" + partNum + "'";
            if (strBetween != null && strBetween != "") sqlStr += " Where  [Date] " + strBetween;
            da.SelectCommand.CommandText = sqlStr;
            ds.Tables["ItemTrans"].Clear();
            da.Fill(ds, "ItemTrans");
            }
          
        }
        private void clearDataSet(DataSet dsToClear)
        {
            dsToClear.Clear();
            foreach (DataTable dt in ds.Tables)
                dt.Constraints.Clear();
            dsToClear.Relations.Clear();
            ds.Tables.Clear();

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showItemDetails();
        }

        private void store1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showItemDetails();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFind.Text != "")
                    bsItem.Filter = "Description Like '%" + txtFind.Text + "%' Or ItemID Like '%" + txtFind.Text + "%'";//  Or ItemID Like '%" + txtFind.Text + "%'";
                else
                    bsItem.Filter = "";

                txtFind.Focus();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            strBetween= " Between '" +  dateFrom.Value.ToShortDateString() + " 0:00:00' And '" + dateTo.Value.ToShortDateString() + " 23:59:00'";
            reLoadData();
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            strBetween = " Between '" + dateFrom.Value.ToShortDateString() + " 0:00:00' And '" + dateTo.Value.ToShortDateString() + " 23:59:59'";
            reLoadData();
        }

        private void cboStoreList_SelectedIndexChanged(object sender, EventArgs e)
        {
           //if (cboStoreList.Text !="All")
           //  strWhichtore = " StoreID ='" + cboStoreList.SelectedValue + "'";
           //else 
           //    strWhichtore ="";

           reLoadData();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            FrmViewItemDetails_Tx ff = new FrmViewItemDetails_Tx(partNum);
            ff.showstoreAll = true;
            //Program.mainFrm.OpenFrm(ff);
            ff.Show();
            ff.btnSummary.Visible = false;
            ff.MdiParent = Program.mainFrm; 
        }

        private void btnFilterTrans_Click(object sender, EventArgs e)
        {
            if (btnFilterTrans.Text== "Filter")
               bsTransferIn.Filter = " [Date] >= '" + dateFrom.Value.ToShortDateString() + " 00:00:00' and [Date] <='" + dateTo.Value.ToShortDateString() + " 23:00:00'";
                
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
           // bsTransferIn.Filter = "";
      //        bsTransferIn.RemoveFilter();
           // getData();
        }

        private void grdTransferIn_DoubleClick(object sender, EventArgs e)
        {
            string trType = grdTransferIn.Rows[grdTransferIn.CurrentCell.RowIndex].Cells["Tr Type"].Value.ToString().Trim();
            string TrNo = grdTransferIn.Rows[grdTransferIn.CurrentCell.RowIndex].Cells["Tr No"].Value.ToString().Trim();
            //string iFltr = grdTransferIn.Rows[grdTransferIn.CurrentCell.RowIndex].Cells["IssueNo"].Value.ToString().Trim();

            switch (trType)
            {
                case "GRN":
                    frmGoodReceivedNote fgn = new frmGoodReceivedNote();
                    Program.mainFrm.OpenFrm(fgn);
                    break;
                case "ISS":
                    frmIssue fis = new frmIssue(TrNo);
                    Program.mainFrm.OpenFrm(fis);
                    break;
                case "INV":
                    frmInvoices fiv = new frmInvoices(TrNo);
                    Program.mainFrm.OpenFrm(fiv);
                    break;
                case "TRI":
                case "TRO":
                    frmTransfer ftr = new frmTransfer(TrNo);
                    Program.mainFrm.OpenFrm(ftr);
                    break;
                default:
                   break ;
            }


            }
            
            
        }
    }
