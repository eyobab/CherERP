using System;
using System.Data;
using System.IO;


namespace Belayab
{
 
    class clsIOStream
    {
        
        public static void setWebInfo_Create()
        {
            //CLASS VARIABLES
            clsStatements sStatements = new clsStatements();

            //DATASET VARIABLES
            DataSet dsCustomers = new DataSet();
            DataSet dsSuppliers = new DataSet();
            DataSet dsEmployees = new DataSet();
            DataSet dsCategories = new DataSet();
            DataSet dsBranch = new DataSet();
            DataSet dsItems = new DataSet();
            DataSet dsItemsReceived = new DataSet();
            DataSet dsItemsReceivedDetails = new DataSet();
            DataSet dsInvoice = new DataSet();
            DataSet dsNoIssuedInvoice = new DataSet();
            DataSet dsNoIssuedRequistion = new DataSet();
           



            sStatements.setRecordCount(dsCustomers, "SELECT * FROM Customers", "Customers");
            sStatements.setRecordCount(dsSuppliers, "SELECT * FROM Suppliers", "Suppliers");
            sStatements.setRecordCount(dsEmployees, "SELECT * FROM Employees", "Employees");
            sStatements.setRecordCount(dsCategories,"SELECT * FROM Categories","Categories");
            sStatements.setRecordCount(dsBranch,"SELECT * FROM Branches","Branches");
            sStatements.setRecordCount(dsItems,"SELECT * FROM Items", "Items");
            sStatements.setRecordCount(dsItemsReceived, "SELECT ItemsReceivedDetails.ReceivedNumber, ItemsReceived.ReceivedDate FROM ItemsReceived INNER JOIN ItemsReceivedDetails ON ItemsReceived.ReceivedNumber = ItemsReceivedDetails.ReceivedNumber where ReceivedDate='"+ DateTime.Today+"'", "ItemsReceived");
            sStatements.setRecordCount(dsItemsReceivedDetails, "SELECT * FROM ItemsReceivedDetails", "ItemsReceivedDetails");
            sStatements.setRecordCount(dsInvoice, "SELECT InvoiceDetails.InvoiceNo, Invoices.InvoiceDate FROM Invoices INNER JOIN InvoiceDetails ON Invoices.InvoiceNo = InvoiceDetails.InvoiceNo where InvoiceDate='" + DateTime.Today + "'", "Invoices");
            sStatements.setRecordCount(dsNoIssuedInvoice, "SELECT dbo.Invoices.InvoiceNo,dbo.Invoices.CustomerId FROM dbo.Invoices LEFT OUTER JOIN dbo.ItemsIssued ON dbo.Invoices.InvoiceNo = dbo.ItemsIssued.ReferenceNumber WHERE (dbo.ItemsIssued.ReferenceNumber IS NULL)", "GetNonIssuedInvoices");
            sStatements.setRecordCount(dsNoIssuedRequistion, "SELECT RequisitionNumber,dbo.ItemRequisition.RequestedBy FROM dbo.ItemsIssued RIGHT OUTER JOIN  dbo.ItemRequisition ON dbo.ItemsIssued.ReferenceNumber = dbo.ItemRequisition.RequisitionNumber WHERE  (dbo.ItemsIssued.ReferenceNumber IS NULL)", "GetNonIssuedRequisitions");
            FileStream sFileStream = new FileStream(Path.GetTempPath().ToString() + @"webinfo.htm", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sStreamWriter = new StreamWriter(sFileStream);

            // Write to the file using StreamWriter class 
            sStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
            sStreamWriter.Write("<html>");
            sStreamWriter.Write("<body bgcolor = '#FFFFFF' leftmargin='5' topmargin='5' text='#209647'>");
            sStreamWriter.Write("<marquee behavior='scroll' direction='left' style='font-family:Arial, Helvetica, sans-serif; font-size:11px' scrolldelay='300'>");

            switch (clsVariables.userRole.Trim())
            {
                case "Store":
                    {
                        sStreamWriter.Write ("<strong> ---Total Categories: " + dsCategories.Tables["Categories"].Rows.Count + "</strong>");
                        sStreamWriter.Write("<strong> ---Total Item List: " + dsItems.Tables["Items"].Rows.Count + "</strong><");

                        sStreamWriter.Write("<strong> ---Total Item Sold Today  : " + dsInvoice.Tables["Invoices"].Rows.Count + "</strong><br>");
                        sStreamWriter.Write("<strong> ---Total Non-Issued Invoices: " + dsNoIssuedInvoice.Tables["GetNonIssuedInvoices"].Rows.Count + " </strong>");

                        for (int i = 0; i < dsNoIssuedInvoice.Tables["GetNonIssuedInvoices"].Rows.Count; i++)
                        {

                            sStreamWriter.Write("<strong> ---Invoice.No : " + dsNoIssuedInvoice.Tables["GetNonIssuedInvoices"].Rows[i]["InvoiceNo"].ToString() + " </strong>");
                            sStatements.setRecordCount(dsCustomers, "SELECT CustomerName FROM Customers where CustomerId='" + dsNoIssuedInvoice.Tables["GetNonIssuedInvoices"].Rows[i]["CustomerId"].ToString().Trim() + "'", "Customers");
                            sStreamWriter.Write("<strong> ---Customer Name: " + dsCustomers.Tables["Customers"].Rows[i]["CustomerName"].ToString() + " </strong>");

                        }
                        
                        sStreamWriter.Write("<strong> ---Total Non-Issued Requisitions: " + dsNoIssuedRequistion.Tables["GetNonIssuedRequisitions"].Rows.Count + " </strong>");
                        for (int i = 0; i < dsNoIssuedRequistion.Tables["GetNonIssuedRequisitions"].Rows.Count; i++)
                        {
                            sStreamWriter.Write("<strong> ---Req.No : " + dsNoIssuedRequistion.Tables["GetNonIssuedRequisitions"].Rows[i]["RequisitionNumber"].ToString() + " </strong>");
                            sStreamWriter.Write("<strong> ---Requested By: " + dsNoIssuedRequistion.Tables["GetNonIssuedRequisitions"].Rows[i]["RequestedBy"].ToString() + " </strong>");

                        }


                    }
                    break;
                case "Finance":
                case "Sales":
                    {
                        sStreamWriter.Write("<strong> ---  ---  Total Item Received Today: " + dsItemsReceived.Tables["ItemsReceived"].Rows.Count + "</strong><br>");
                        sStreamWriter.Write("<strong> ---Total Item Sold Today  : " + dsInvoice.Tables["Invoices"].Rows.Count + "</strong><br><br>");
                        sStreamWriter.Write("<strong> ---</strong>");
                        sStreamWriter.Write("<strong> ---</strong>");


                    }
                    break;
                case "Admin":
                    {

                        sStreamWriter.Write("<strong> -------- Total Item Received Today: " + dsItemsReceived.Tables["ItemsReceived"].Rows.Count + "</strong> ------ <strong>Total Item Sold Today  : " + dsInvoice.Tables["Invoices"].Rows.Count + "</strong>");
                        
                    }
                    break;


            }
            
      
           
            sStreamWriter.Write("</marquee>");
            sStreamWriter.Write("</body>");
            sStreamWriter.Write("</html>");
            sStreamWriter.Flush();
            sStreamWriter.Close();
            sStreamWriter = null;   
            sFileStream.Close();
            sFileStream = null;
        }

        public static void setWebInfo_Remove(){File.Delete(Path.GetTempPath().ToString() + @"webinfo.htm");}
    }
}
