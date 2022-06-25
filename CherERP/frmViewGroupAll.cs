using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Belayab
{
    public partial class frmViewGroupAll : Form
    {
        clsData objData = clsData.Instance;
        string strSQL = "";
        int idx;
        DataSet dss;
        private static string fltr = "";

        String searchFieldName = "";
        
       public frmViewGroupAll()
        {
            InitializeComponent();
        }

        private void frmViewGroupAll_Load(object sender, EventArgs e)
        {
            TreeNode nod;
            
            nod=belTree.Nodes.Add("General");
            nod = belTree.Nodes[0].Nodes.Add("Categories");
            nod.Name = "Categories";
            nod= belTree.Nodes[0].Nodes.Add("Customers");
            nod.Name = "Customers";
            nod = belTree.Nodes[0].Nodes.Add("Suppliers");
            nod.Name = "Suppliers";
            nod = belTree.Nodes[0].Nodes.Add("Branches");
            nod.Name = "Branches";
            nod = belTree.Nodes[0].Nodes.Add("Stores");
            nod.Name = "Stores";
            nod = belTree.Nodes[0].Nodes.Add("Shelves");
            nod.Name = "Shelfs";
            nod = belTree.Nodes[0].Nodes.Add("Columns");
            nod.Name = "Columns";
            nod = belTree.Nodes[0].Nodes.Add("Rows");
            nod.Name = "Rows";

            nod= belTree.Nodes.Add("Stock");

            nod = belTree.Nodes[1].Nodes.Add("Items");
            nod.Name = "Items";
            nod = belTree.Nodes[1].Nodes.Add( "Received");
            nod.Name = "ItemsReceived";
            nod= belTree.Nodes[1].Nodes.Add("Issued");
            nod.Name = "ItemsIssued";
            nod= belTree.Nodes[1].Nodes.Add("Requested");
            nod.Name = "ItemRequisition";
            nod = belTree.Nodes[1].Nodes.Add("Transfered");
            nod.Name = "StoreTransfer";
            nod = belTree.Nodes[1].Nodes.Add("Purchase");
            nod.Name = "PurchaseOrder";



            nod = belTree.Nodes.Add("Sales");
            nod.Name = "Sales";

            nod =belTree.Nodes[2].Nodes.Add("Credit");
              nod.Name = "Credit";
            nod = belTree.Nodes[2].Nodes.Add("Cash");
              nod.Name = "Cash";

              nod = belTree.Nodes.Add("Maintenance");
              nod.Name = "Maintenance";

              nod = belTree.Nodes[3].Nodes.Add("Work Orders");
              nod.Name = "m_maintenanceList_V";
              nod = belTree.Nodes[3].Nodes.Add("Vehicles");
              nod.Name = "m_VehicleList_V";
              nod = belTree.Nodes[3].Nodes.Add("Mechanics");
              nod.Name = "m_MechanicList";
              nod = belTree.Nodes[3].Nodes.Add("Issued Items");
              nod.Name = "m_Items";
              nod = belTree.Nodes[3].Nodes[3].Nodes.Add("Parts");
              nod.Name = "m_Replaced";
              nod = belTree.Nodes[3].Nodes[3].Nodes.Add("Lubricants");
              nod.Name = "m_Fuel_Lubricatnts";


            ////nod = belTree.Nodes[2].Nodes.Add("Both");
            //  nod.Name = "Invoices";


         

        }

        //private void frmViewGroupAll_Resize(object sender, EventArgs e)
        //{
        //    belTree.Height = this.Height;
        //    dvData.Left = belTree.Width;
        //    dvData.Width = this.Width - belTree.Width-5;
        //    dvData.Height = this.Height - 2*bnav.Height;

            
        //}

        private void setGridSource()
        {
            

            bs.DataSource = dss;
            bs.DataMember = dss.Tables[0].TableName;

            dvData.DataSource = bs;

            searchFieldName = dss.Tables[0].Columns[0].ColumnName;
           // lblSearchBy.Text = "Search by " + dss.Tables[0].Columns[0].ColumnName;
            
          

        }

        private void belTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtSearchItem.Text = "";
            lblSearchBy.Text = "";
            try
            {
                if (e.Node.Parent.Name == "Sales")

                    if (e.Node.Name == "Credit")
                        strSQL = "SELECT  Distinct   InvoiceNo, CustomerName AS [Customer Name], InvoiceDate AS [Invoice Date], EmployeeName AS [Prepared By], CheckedBy AS [Checked By],Cashier, Cast(TotCreditAmt as Numeric(18,2)) as Amount , CurState as State FROM    dbo.VATInvoiceViewCredit ";
                    else
                        strSQL = "SELECT   Distinct  InvoiceNo, CustomerName AS [Customer Name], InvoiceDate AS [Invoice Date], EmployeeName AS [Prepared By], CheckedBy AS [Checked By],Cashier, Cast(TotCreditAmt as Numeric(18,2)) as Amount , CurState as State FROM    dbo.VATInvoiceView ";
                else
                    switch (e.Node.Name)
                    {
                        case "Categories":
                            strSQL = "SELECT  Categories.CategoryId, CategoryName as [Category Name],Categories.Description, VehicleType as [Vehicle Type] FROM   Categories Order By CategoryName";
                            break;
                        case "Items":
                            strSQL = "SELECT TOP 100 PERCENT dbo.Items.Description, dbo.Items.PartNumber, dbo.fItemReceived(ItemID) AS [Total In], dbo.fItemSoldIssued(ItemID) AS [Total Out],dbo.fItemInStock(ItemID) as [In Stock] ,dbo.Categories.CategoryName AS Category, " +
                  "dbo.Items.OrderLevel AS [Reorder Level], dbo.Items.Location FROM dbo.Items INNER JOIN " +
                            "dbo.Categories ON dbo.Items.CategoryId = dbo.Categories.CategoryId " +
                            " ORDER BY dbo.Items.Description";
                            break;
                        case "ItemsReceived":
                            strSQL = "SELECT     dbo.ItemsReceived.ReceivedNumber, dbo.Suppliers.SupplierName AS [Supplier Name],  dbo.ItemsReceived.LCNumber AS [LC Number], "
                             + " ItemsReceived.ReceivedDate AS [Received Date], dbo.Employees.EmployeeName AS [Received By],  dbo.ItemsReceived.DeliveredBy AS [Delivered By] "
                             + " , dbo.ItemsReceived.ReferenceNumber, dbo.ItemsReceived.VoucherType FROM         dbo.ItemsReceived INNER JOIN    " 
                             + " dbo.Suppliers ON dbo.ItemsReceived.SupplierId = dbo.Suppliers.SupplierId  Left outer JOIN dbo.Employees ON dbo.ItemsReceived.ReceivedBy = dbo.Employees.EmployeeId";
                            break;
                        case "ItemsIssued":
                            strSQL = " Select * From Items_Issued_Review";
                            break;
                        case "Customers":
                            strSQL = " SELECT CustomerId , CustomerName as [Customer Name], VATRegNumber as [VAT Reg No], TINNumber as [TIN No], Woreda, Kebele, HouseNo, ContactPerson, ContactTelephone  FROM   dbo.Customers";
                            break;

                        case "m_Replaced":
                           strSQL = "SELECT dbo.m_Replaced.[SIV No], dbo.m_Replaced.mNumber as [W.O.Number], dbo.Items.ItemID, dbo.Items.PartNumber, dbo.Items.Description, " +
                            " dbo.m_Replaced.Quantity, dbo.m_Replaced.UnitPrice, m_maintenance.Invoice_ref as [Invoice Ref]" +
                            "FROM  dbo.m_Replaced  INNER JOIN dbo.Items ON  dbo.m_Replaced.ItemID = dbo.Items.ItemID INNER JOIN m_maintenance On " +
                            "  dbo.m_Replaced.mNumber = m_maintenance.WorkOrderNumber" ;
                            break;
                        case "m_Fuel_Lubricatnts":
                            strSQL = " SELECT dbo.m_Fuel_Lubricatnts.[SIV No], dbo.m_Fuel_Lubricatnts.mNumber as [W.O.Number], dbo.m_Fuel_Lubricatnts.ItemID, dbo.Items.PartNumber,  " +
                             "dbo.Items.Description, dbo.m_Fuel_Lubricatnts.Quantity,   dbo.m_Fuel_Lubricatnts.UnitPrice, m_maintenance.Invoice_ref as [Invoice Ref] " +
                             " FROM         dbo.m_Fuel_Lubricatnts INNER JOIN " +
                            " dbo.Items ON dbo.m_Fuel_Lubricatnts.ItemID = dbo.Items.ItemID INNER JOIN m_maintenance On " +
                            "  dbo.m_Fuel_Lubricatnts.mNumber = m_maintenance.WorkOrderNumber";
                            break;
                        case "PurchaseOrder":
                            strSQL = " Select * From PurchaseRequisition";
                            break;
                        default:
                            strSQL = "Select * from " + e.Node.Name;
                            break;
                    }


                dss = objData.getDSet(strSQL, e.Node.Name);
                
                setGridSource();

                cboField.Items.Clear();

                foreach (DataColumn col in dss.Tables[0].Columns)
                    //if (col.ColumnName != "Branch" && col.ColumnName != "Purchase Type" && col.ColumnName != "Category"
                    //     && col.ColumnName != "Item Type" && col.ColumnName != "Vehicle Type")
                    cboField.Items.Add(col.ColumnName);
                cboField.SelectedIndex = 0;

                bs.Filter = "";


            }
            catch (Exception ex)
            {
                if(e.Node.Parent  !=null)  MessageBox.Show(ex.Message);
            }


        }

        private void grData_DoubleClick(object sender, EventArgs e)
        {
            switch (bs.DataMember)
            {
                case "Categories":
                    frmItemCategory fIC = new frmItemCategory(
                        dvData.Rows[dvData.CurrentCell.RowIndex].Cells["VehicleModel"].Value.ToString(),
                        dvData.Rows[dvData.CurrentCell.RowIndex].Cells["CategoryId"].Value.ToString());
                    Program.mainFrm.OpenOverFrm(fIC);
                    break;
                case "Customers":
                    frmCustomersSuppliers fC = new frmCustomersSuppliers();
                    Program.mainFrm.OpenOverFrm(fC);
                    fC.tabSupplier_Customer.SelectedIndex = 1;
                    fC.lvCustomer.FindItemWithText(dvData.Rows[dvData.CurrentCell.RowIndex].Cells["Customer Name"].Value.ToString().Trim());
                    break;
                case "Suppliers":
                    frmCustomersSuppliers fS = new frmCustomersSuppliers();
                    Program.mainFrm.OpenOverFrm(fS);
                    ListViewItem itm =  fS.lvSupplier.FindItemWithText(dvData.Rows[dvData.CurrentCell.RowIndex].Cells["SupplierName"].Value.ToString(),true, 0,false);
                  
                    //if (itm != null) 
                    //     fS.lvSupplier.Items[itm.Text].Selected = true;
                    // fS.lvSupplier.TopItem = itm;
              
                    break;             

                case "ItemsReceived":
                    clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["ReceivedNumber"].Value.ToString();
                    frmGoodReceivedNote fGRN = new frmGoodReceivedNote("");
                    Program.mainFrm.OpenOverFrm(fGRN);
                     break;
           //     case "Invoices":
                case "Credit":
                    clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["InvoiceNo"].Value.ToString();
                    frmInvoicesCredit fINVC = new frmInvoicesCredit("");
                    Program.mainFrm.OpenOverFrm(fINVC);
                    break;

                case "Cash":
                    clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["InvoiceNo"].Value.ToString();
                    frmInvoices fINV = new frmInvoices("");
                     Program.mainFrm.OpenOverFrm(fINV);
                     break;

                 case "ItemsIssued":
                     clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["IssueNo"].Value.ToString();
                     frmIssue fIssue = new frmIssue("");
                     Program.mainFrm.OpenOverFrm(fIssue);
                     break;

                 case "ItemRequisition":
                     clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["RequisitionNumber"].Value.ToString();
                     frmItemRequisitions fReq = new frmItemRequisitions("");
                     Program.mainFrm.OpenOverFrm(fReq);
                     break;
                 case "m_Replaced":
                 case "m_Fuel_Lubricants":
                   //  clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["W.O.Number"].Value.ToString();
                     Program.showWorkOrder(dvData.Rows[dvData.CurrentCell.RowIndex].Cells["W.O.Number"].Value.ToString(), false);
                     break;
                
                case "m_maintenanceList_V":
                     Program.showWorkOrder(dvData.Rows[dvData.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString(), false);
                     break;
                case "PurchaseOrder":
                    clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["PerchaseReqNo"].Value.ToString();
                    frmPurchaseRq frmPur = new frmPurchaseRq("");
                    Program.mainFrm.OpenOverFrm(frmPur);
                    break; break;
                    //    clsData.trNo = dvData.Rows[dvData.CurrentCell.RowIndex].Cells["WorkOrderNumber"].Value.ToString();
                    //    frmVehicleMaintenance fMnt = new frmVehicleMaintenance();
                    //    Program.mainFrm.OpenOverFrm(fMnt);
                    //    break;


            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {

            objData.filterData(bs, cboField.Text.Trim(), txtSearchItem.Text);
            //try
            //{

            //    if (txtSearchItem.Text != "")
            //        bs.Filter = searchFieldName + " Like '" + txtSearchItem.Text + "%'";
            //    else
            //        bs.Filter = "";


            //}
            //catch (Exception ex)
            //{
                
            //}
        }
      
        
    }
}