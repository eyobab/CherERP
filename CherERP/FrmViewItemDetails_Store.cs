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
    public partial class FrmViewItemDetails_Store : Form
    {
        //  clsData objData = new clsData();
        DataSet ds = new DataSet();
        DataSet dsTr = new DataSet();

        string partNum = "";


       


        public FrmViewItemDetails_Store()
        {
            InitializeComponent();
        }

        public FrmViewItemDetails_Store(string pn)
        {
            InitializeComponent();
            partNum = pn;
        }

        private void FrmViewItemDetails_Load(object sender, EventArgs e)
        {


            setAdapterConnectionString();

            // TODO: This line of code loads data into the 'belayAbBranchStore.I_StoreList' table. You can move, or remove it, as needed.
            this.i_StoreListTableAdapter.Fill(this.belayAbBranchStore.I_StoreList);
          
            
           
            cboStore.SelectedIndex = 0;
        }


        

        private void setAdapterConnectionString()
        {

            this.i_StoreListTableAdapter.Connection = clsData.connBel;
            
        }
        private void FrmViewItemDetails_Resize(object sender, EventArgs e)
        {

            grdTranList.Height = this.Height - toolStrip1.Height - 5;
            //fpItemList.Width = this.Width;
            //fpItemList.Height = this.Height - 20;
            //fpItemList.Top = 1;

        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {

            //GridPrintDocument pd;
            //PrintPreviewDialog ppv = new PrintPreviewDialog();
            //if (tabItemTran.SelectedIndex == 0)
            //    pd = new GridPrintDocument(this.grdTranList.TableControl, true);
            //else
            //    pd = new GridPrintDocument(this.fpItemList.TableControl, true);

            //ppv.Document = pd;
            //pd.DefaultPageSettings.Landscape = true;
            //pd.DefaultPageSettings.Margins.Left = 50;
            //pd.DefaultPageSettings.Margins.Right = 50;
            //pd.DefaultPageSettings.Margins.Top = 50;
            //pd.DefaultPageSettings.Margins.Bottom = 50;

            //ppv.ShowDialog();


        }

        

        private void showItemDetails(string store)
        {
            string sqlStr, strSQLTtr;
            string str = " where PartNumber ='" + partNum + "'";
            SqlDataAdapter da = null;


            try
            {
                if (store == "Main")
                {

                    if (partNum != "")
                        sqlStr =
                         "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.PartNumber, dbo.fItemReceived(PartNumber) AS [Total In], dbo.fItemTransfered(PartNumber) AS [Total Out], dbo.fItemInMainStock(PartNumber) as [In Stock] ,dbo.Categories.CategoryName AS Category, dbo.Items.MeasurementId AS Units, " +
                           " dbo.Items.OrderLevel AS [Reorder Level] FROM dbo.Items INNER JOIN " +
                                     "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                                     " Where dbo.Items.PartNumber ='" + partNum + "' ORDER BY dbo.Items.Description";

                    else
                        sqlStr =
                      "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.PartNumber, dbo.fItemReceived(PartNumber) AS [Total In], dbo.fItemTransfered(PartNumber) AS [Total Out],dbo.fItemInMainStock(PartNumber) as [In Stock] ,dbo.Categories.CategoryName AS Category, dbo.Items.MeasurementId AS Units, " +
                        "dbo.Items.OrderLevel AS [Reorder Level] FROM dbo.Items INNER JOIN " +
                                  "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                                  " ORDER BY dbo.Items.Description";


                    if (da == null) da = new SqlDataAdapter(sqlStr, clsData.connBel);

                    clearDataSet(ds);
                    clearDataSet(dsTr);

                    da.Fill(ds, "Items");
                    da.Fill(dsTr, "Items");



                    //sqlStr = "Select * From rev_ReceivedHistory";// where PartNumber ='" + partNum + "'";
                    //if (partNum != "") sqlStr += str;

                    //da.SelectCommand.CommandText = sqlStr;
                    //da.Fill(ds, "Received");

                    //ds.Relations.Add("Received History",
                    //ds.Tables["Items"].Columns["PartNumber"],
                    //ds.Tables["Received"].Columns["PartNumber"]);


                    //sqlStr = "Select * From rev_InvoiceHistory ";//where PartNumber ='" + partNum + "'";
                    //if (partNum != "") sqlStr += str;

                    //da.SelectCommand.CommandText = sqlStr;
                    //da.Fill(ds, "Invoices");

                    //ds.Relations.Add("Invoice History",
                    //ds.Tables["Items"].Columns["PartNumber"],
                    //ds.Tables["Invoices"].Columns["PartNumber"]);

                    sqlStr = "Select * From rev_TransferedHistory";// where PartNumber ='" + partNum + "'";
                    if (partNum != "") sqlStr += str;

                    da.SelectCommand.CommandText = sqlStr;
                    da.Fill(ds, "Transfered");

                    ds.Relations.Add("Transfered History",
                    ds.Tables["Items"].Columns["PartNumber"],
                    ds.Tables["Transfered"].Columns["PartNumber"]);

                    // link the sequential list
     //               fpItemList.DataSource = ds;
     //               fpItemList.DataMember = "Items";


                    //For the transaction listing

                    da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction_Tran_GRN";
                    //da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction";
                    da.Fill(dsTr, "ItemTrans");

                    dsTr.Relations.Add("Transactions",
                   dsTr.Tables["Items"].Columns["PartNumber"],
                   dsTr.Tables["ItemTrans"].Columns["Part Number"], false);


                    // LInk the transaction grid

                    grdTranList.DataSource = dsTr;
                    grdTranList.DataMember = "Items";

                }

                else if (store == "Store1")
                {
                    if (partNum != "")
                        sqlStr =
                         "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.PartNumber, dbo.fItemTransfered(PartNumber) AS [Total In], dbo.fItemSoldIssued(PartNumber) AS [Total Out], dbo.fItemInSubStock(PartNumber) as [In Stock] ,dbo.Categories.CategoryName AS Category, dbo.Items.MeasurementId AS Units, " +
                           " dbo.Items.OrderLevel AS [Reorder Level], dbo.Items.Location FROM dbo.Items INNER JOIN " +
                                     "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                                     " Where dbo.Items.PartNumber ='" + partNum + "' ORDER BY dbo.Items.Description";

                    else
                        sqlStr =
                      "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.PartNumber, dbo.fItemTransfered(PartNumber) AS [Total In], dbo.fItemSoldIssued(PartNumber) AS [Total Out],dbo.fItemInSubStock(PartNumber) as [In Stock] ,dbo.Categories.CategoryName AS Category, dbo.Items.MeasurementId AS Units, " +
                        "dbo.Items.OrderLevel AS [Reorder Level], dbo.Items.Location FROM dbo.Items INNER JOIN " +
                                  "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                                  " ORDER BY dbo.Items.Description";



                    if (da == null) da = new SqlDataAdapter(sqlStr, clsData.connBel);


                    clearDataSet(ds);
                    clearDataSet(dsTr);

                    da.Fill(ds, "Items");
                    da.Fill(dsTr, "Items");

                    //sqlStr = "Select * From rev_ReceivedHistory";// where PartNumber ='" + partNum + "'";
                    //if (partNum != "") sqlStr += str;

                    //da.SelectCommand.CommandText = sqlStr;
                    //da.Fill(ds, "Received");

                    //ds.Relations.Add("Received History",
                    //ds.Tables["Items"].Columns["PartNumber"],
                    //ds.Tables["Received"].Columns["PartNumber"]);


                    //sqlStr = "Select * From rev_InvoiceHistory ";//where PartNumber ='" + partNum + "'";
                    //if (partNum != "") sqlStr += str;

                    //da.SelectCommand.CommandText = sqlStr;
                    //da.Fill(ds, "Invoices");

                    //ds.Relations.Add("Invoice History",
                    //ds.Tables["Items"].Columns["PartNumber"],
                    //ds.Tables["Invoices"].Columns["PartNumber"]);

                    //sqlStr = "Select * From rev_IssuedHistory";// where PartNumber ='" + partNum + "'";
                    //if (partNum != "") sqlStr += str;

                    //da.SelectCommand.CommandText = sqlStr;
                    //da.Fill(ds, "Issued");

                    //ds.Relations.Add("Issued History",
                    //ds.Tables["Items"].Columns["PartNumber"],
                    //ds.Tables["Issued"].Columns["PartNumber"]);

                    // link the sequential list
       //             fpItemList.DataSource = ds;
      //              fpItemList.DataMember = "Items";


                    //For the transaction listing

                    da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction_INV_TRN";
                    //da.SelectCommand.CommandText = "Select * from rpt_ItemTransaction";
                    da.Fill(dsTr, "ItemTrans");

                    dsTr.Relations.Add("Transactions",
                   dsTr.Tables["Items"].Columns["PartNumber"],
                   dsTr.Tables["ItemTrans"].Columns["Part Number"], false);


                    // LInk the transaction grid

                    grdTranList.DataSource = dsTr;
                    grdTranList.DataMember = "Items";

                }

           //     if (partNum != "") this.fpItemList.Table.ExpandAllRecords();
            }
            catch (Exception ex) {  }// MessageBox.Show(ex.Message); }
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
            showItemDetails("Main");
        }

        private void store1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showItemDetails("Store1");
        }

        private void cboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            showItemDetails(cboStore.Text);
        }

       
    }










}
