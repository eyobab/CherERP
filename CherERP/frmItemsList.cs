using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Belayab.Reports;



namespace Belayab
{
    public partial class frmItemsList : Form
    {
        int curRow = 0;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        clsData objData = clsData.Instance;
        string strSQL;
        string strFilterCat, strFilterIType, strFilterVType, strFilter;
        string strFilterBranch, strFilterPurchaseType;

        clsUtility objUtility = new clsUtility();

        string callerName = "";
        Object frmObj=null;

        public frmItemsList()
        {
            InitializeComponent();
        }

        public frmItemsList(string caller, Object Obj)
        {

            InitializeComponent();
            callerName = caller;
            frmObj = Obj;
        }

        private void frmItemsList_Load(object sender, EventArgs e)
        {

            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = clsData.connBel;

       
            strSQL = "Select CategoryId, CategoryName From Categories Order by CategoryID";
            objUtility.fillComboValuesWithAll(cboCategory, strSQL);
       
            strSQL = "Select ItemTypeID, ItemTypeDescreption From ItemTypes Order by ItemTypeID";
            objUtility.fillComboValuesWithAll(cboItemType, strSQL);

            strSQL = "Select VehicleType, Description From m_VehicleType Order by VehicleType";
            objUtility.fillComboValuesWithAll(cboVehicleType, strSQL);

            strSQL = "Select StoreId, StoreName From Stores Order by StoreName";
            objUtility.fillComboValuesWithAll(cboBranch, strSQL,false);

            //  cboBranch.SelectedValue = clsVariables.sStore;

           // fillDS(); // Fill the date set

            bs.DataSource= ds;
            bs.DataMember="Items";

            //  itemsGrid.DataSource = bs;
            grdNew.DataSource = bs;
            navItemList.BindingSource = bs;


            cboField.Items.Clear();
          
            foreach (DataColumn col in ds.Tables[0].Columns)
               if(col.ColumnName != "Branch" && col.ColumnName != "Purchase Type" && col.ColumnName != "Category"
                    && col.ColumnName != "Item Type" && col.ColumnName != "Vehicle Type")
                                 cboField.Items.Add(col.ColumnName);

            bs.Filter = "";

        
            
        }

        private void fillDS()
        {

            //strSQL = "SELECT Items.ItemID, Items.PartNumber AS [Part Number], Items.Description, Items.ItemTypeID, Items.VehicleTypeID, Items.CategoryId" +
            // " ORDER BY Items.Description";

            ds.Clear();

            if (cboBranch.SelectedValue.ToString() != "000")

                 strSQL = " SELECT Branch, ItemID, ItemPurchaseType As [Purchase Type], Description, [Item Type], [Vehicle Type], Category,orderLevel as [Order level],  Balance, [First Qty] As [Year Begin], YearIn, YearOut, Received, Issued, Sold, SoldCr, TransferIn, TransferOut" +
                      " FROM rpt_Item_Balances Where Branch='" + cboBranch.SelectedValue.ToString() + "' and ItemPurchaseType <> 'Local InOut' order by ItemPurchaseType, [Vehicle Type], [Item Type], [ItemID]";
            else
                strSQL = " SELECT Branch, ItemID, ItemPurchaseType As [Purchase Type], Description, [Item Type], [Vehicle Type], Category,orderLevel as [Order level],  Balance, [First Qty] As [Year Begin], YearIn, YearOut, Received, Issued, Sold, SoldCr, TransferIn, TransferOut" +
                  " FROM rpt_Item_Balances Where ItemPurchaseType <> 'Local InOut' order by ItemPurchaseType, [Vehicle Type], [Item Type], [ItemID]";

            
            da.SelectCommand.CommandText = strSQL;

            da.Fill(ds, "Items");


        }

        private void applyFilter()
        {

            strFilter = "";

            try
            {
                if (cboField.Text.ToUpper() == "Order Level".ToUpper())
                {
                    strFilter = "[Order Level] >=";
                    cboCompare.SelectedIndex = 4; 
                    //txtSearch.Text = "0";
                    goto nxt;
                }

                switch (cboCompare.Text)
                {
                    case "Begins with":
                        strFilter = "[" + cboField.Text + "] Like '" + txtSearch.Text + "%'";
                        break;
                    case "Contains":
                        strFilter = "[" + cboField.Text + "] Like '%" + txtSearch.Text + "%'";
                        break;
                    case "Is Equal to":
                        strFilter = "[" + cboField.Text + "]='" + txtSearch.Text + "'";
                        break;
                    case "Is Greater Than":
                        strFilter = "[" + cboField.Text + "]>" + txtSearch.Text;
                        break;
                    case "Is Greater Than or Equal to":
                        strFilter = "[" + cboField.Text + "]>=" + txtSearch.Text;
                        break;
                    case "Is Less Than":
                        strFilter = "[" + cboField.Text + "]<" + txtSearch.Text;
                        break;
                    case "Is Less Than or Equal to":
                        strFilter = "[" + cboField.Text + "]<=" + txtSearch.Text;
                        break;
                    case "Between":
                        if (cboField.SelectedItem.ToString().ToUpper() == "ITEMID" || cboField.SelectedItem.ToString().ToUpper() == "DESCRIPTION")
                           strFilter = "([" + cboField.Text + "]>= '" + txtSearch.Text + "' and [" + cboField.Text + "]<= '" + txtSearch1.Text + "')";
                        else
                            strFilter = "([" + cboField.Text + "]>=" + txtSearch.Text + " and [" + cboField.Text + "]<= " + txtSearch1.Text + ")";
                        break;

                    default:
                        strFilter = "";
                        break;
                }

               // if (strFilter != "") strFilter += " and ";
                // getAllInstock();
         nxt:
                if (cboCategory.Text != "" && cboCategory.Text != null && cboCategory.Text!="All")
                    if (strFilter != "")
                        strFilter += " and " + strFilterCat;
                    else
                        strFilter += strFilterCat;

                 if (cboItemType.Text != "" && cboItemType.Text != null && cboItemType.Text != "All")
                    if (strFilter != "")
                        strFilter +=  " And " + strFilterIType;
                    else
                        strFilter += strFilterIType;

                if (cboVehicleType.Text != "" && cboVehicleType.Text != null && cboVehicleType.Text != "All")
                    if (strFilter != "")
                        strFilter  += " And " + strFilterVType;
                    else
                        strFilter += strFilterVType;

                if (cboBranch.Text != "" && cboBranch.Text != null && cboBranch.Text != "All" && strFilterBranch !=null)
                    if (strFilter != "")
                        strFilter += " And " + strFilterBranch;
                    else
                        strFilter += strFilterBranch;

                if (cboPurchaseType.Text != "" && cboPurchaseType.Text != null && cboPurchaseType.Text != "All")
                    if (strFilter != "")
                        strFilter += " And " + strFilterPurchaseType;
                    else
                        strFilter += strFilterPurchaseType;


                bs.Filter = strFilter;
             
              //  bs.Filter = "CategoryId ='" + cboCategory.SelectedValue + "'";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void frmItemsList_Resize(object sender, EventArgs e)
        {
            //itemsGrid.Height = this.Height - 100;
            //itemsGrid.Width = this.Width - 20;

            grdNew.Height = this.Height - 140;
            grdNew.Width = this.Width - 40;
            grdNew.Left = 0;
            grdNew.Top = cboField.Top + cboField.Height + 10;

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            applyFilter();
        }

       
        private void getAllInstock()
        {
            try
            {
                decimal val;
                string pNum;



                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //Unit price
                     pNum =ds.Tables[0].Rows[i]["ItemID"].ToString();
                     val = objData.getUnitPrice(pNum);
                     ds.Tables[0].Rows[i]["Unit Price"] = val.ToString();
                
                    
                    ds.Tables[0].Rows[i]["In Stock"] = objData.ReturnInstock( "GetNetItemsInStock_AfterDate",pNum, clsVariables.sStore );
                  
                  
                }
                grdNew.Refresh();

                //lblRecs.Text = itemsGrid.Rows.Count.ToString() + " Items";
            }
            catch (Exception ex) {MessageBox.Show(ex.Message,"Stosa"); }
            
        }

        private void getInstock()
        {

            decimal val;
            string pNum;
            
            ////pNum = grdNew.Table.CurrentRecord.GetValue("Part Number").ToString();
            ////val = objData.getUnitPrice(pNum);
            ////grdNew.Table.CurrentRecord.SetValue("In Stock", objData.ReturnInstock("GetNetItemsInStock", pNum));
            ////grdNew.Table.CurrentRecord.SetValue("Unit Price",val.ToString());
            

        //    grdNew.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bs.Filter = "";
     //       getAllInstock();
        }

        private void frmItemsList_Activated(object sender, EventArgs e)
        {
      //      getAllInstock();
        }

        private void itemsGrid_Sorted(object sender, EventArgs e)
        {
     //       getAllInstock();
        }

        private void itemsGrid_DoubleClick(object sender, EventArgs e)
        {
            FrmViewItemDetails_Tx f = new FrmViewItemDetails_Tx(grdNew.Rows[grdNew.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString());
            f.showstoreAll = false;
            Program.mainFrm.OpenFrm(f);
        }

        private void mnuEditItem_Click(object sender, EventArgs e)
        {
            try
            {
                clsData.pNum = grdNew.Rows[grdNew.CurrentCell.RowIndex].Cells["ItemID"].Value.ToString();
                MessageBox.Show(clsData.pNum);
                frmItemEdit fitem = new frmItemEdit();
                Program.mainFrm.OpenOverFrm(fitem);
               
            }
            catch (Exception ex)
            {
                Program.mainFrm.OpenOverFrm(new frmItemEdit());
            }
           
        }

        private void mnuDetails_Click(object sender, EventArgs e)
        {
            itemsGrid_DoubleClick(new object(), new EventArgs());
        }

      
    
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();
           
            getAllInstock();
           
            ds.Tables[0].TableName = "rpt_ItemList";

            frmv.SetReport(new rptItemList(),ds);

            Program.mainFrm.OpenOverFrm(frmv);

        }

        private void mnuGetDetails_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (grdNew  != null)
            {
                try
                {
                   
                    //// GridPrintDocument pd = new GridPrintDocument(this.grdNew.TableControl, true); 
                    //// PrintPreviewDialog ppv = new PrintPreviewDialog(); 
                    ////ppv.Document = pd; 
                    ////pd.DefaultPageSettings.Landscape = true;
                    ////pd.DefaultPageSettings.Landscape = true;
                    ////pd.DefaultPageSettings.Margins.Left = 50;
                    ////pd.DefaultPageSettings.Margins.Right = 50;
                    ////pd.DefaultPageSettings.Margins.Top = 50;
                    ////pd.DefaultPageSettings.Margins.Bottom = 50;

                    ////ppv.ShowDialog();  
                    }
             
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred attempting to preview the file to print - " + ex.Message);
                }
            }
        }

      
        private void btnStockValues_Click(object sender, EventArgs e)
        {
            getAllInstock();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFilterCat = "Category ='" + cboCategory.Text.Trim() + "'";
            applyFilter();
        }

        private void mnuExportToExcel_Click(object sender, EventArgs e)
        {

          
            String strFileName = "Export_Item_Balance_" + DateTime.Today.ToString("ddMMMyyyy");
            objUtility.ExportToExcel(grdNew, strFileName);
        }

        private void cboBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //strFilterBranch = "Branch ='" + cboBranch.SelectedValue.ToString() + "'";
            //applyFilter();
            fillDS();
        }

        private void cboPurchaseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFilterPurchaseType = "[Purchase Type] ='" + cboPurchaseType.Text.Trim() + "'";
            applyFilter();
        }

        private void chkByDate_CheckedChanged(object sender, EventArgs e)
        {
            dtFrom.Visible = chkByDate.Checked;
            dtTo.Visible = chkByDate.Checked;
        }

        private void cboCompare_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool show = (cboCompare.SelectedItem.ToString() == "Between");
            txtSearch1.Visible = show;
            lblAnd.Visible = show;
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboField.Text.ToUpper() == "Order Level".ToUpper())
            {
                strFilter = "[Order Level] >= Balance";
                cboCompare.SelectedIndex = 4;
                txtSearch.Text = "Balance";
            }
            else
                if (txtSearch.Text == "Balance")
                txtSearch.Text = "";

           
        }

        private void cboItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFilterIType = "[Item Type] ='" + cboItemType.Text.Trim() + "'";
           applyFilter(); 
        }

        private void cboVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            strFilterVType = "[Vehicle Type] ='" + cboVehicleType.SelectedValue + "'";
            applyFilter();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            bs.Filter = "";
            cboCategory.SelectedValue = "000";
            cboItemType.SelectedValue = "000";
            cboVehicleType.SelectedValue = "000";
           // cboBranch.SelectedValue = "000";
            cboPurchaseType.SelectedValue = "All";
            cboField.SelectedIndex = -1;
            cboCompare.SelectedIndex = -1;
            txtSearch.Text = "";
        }
        
  
    }
}