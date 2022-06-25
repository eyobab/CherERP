using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace Belayab
{
    public partial class frmDataImport : Form
    {
        clsData objData = new clsData();
        public frmSetting fset = null;
        public frmDataImport()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xls*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            txtSourcefile.Text = openFileDialog1.FileName;
        }

        private void btnProcessImport_Click(object sender, EventArgs e)
        {
            if (txtSourcefile.Text == "") btnBrowse_Click(null, null);
            if (txtSourcefile.Text == "") return;
            string fieldlist="";
            string valuelist="";
            int insertCount = 0, errorCount = 0, balCount =0 ;
            FileStream stream = null;

            try
            {
                stream = new FileStream(txtSourcefile.Text, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet(
                    new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                DataTable tbl = result.Tables[0];
                prgImport.Maximum = tbl.Rows.Count;

                if (tabType.SelectedIndex == 0)
                {
                    int prgCount = 0;
                    foreach (DataRow row in tbl.Rows)
                    {
                        try
                        {
                            prgCount++;
                            
                            
                            if (chkItems.Checked)
                            {
                                string ItemID = row["ItemID"].ToString();
                                string PartNumber = row["PartNumber"].ToString();
                                string Description = row["Description"].ToString();
                                string MeasurementID = row["Units"].ToString();
                                double UnitPrice = Convert.ToDouble(row["UnitPrice"].ToString());
                               // int VatTaxed = row["Taxed"].ToString().ToUpper() == "YES" ? 1 : 0;
                               // string Location = row["Location"].ToString();
                                string CategoryId = row["Category"].ToString();
                                string VehicleTypeID = row["VehicleType"].ToString();
                              //  double OrderLevel = Convert.ToDouble(row["orderlevel"].ToString());
                                string ItemPurchaseType = row["PurchaseType"].ToString();
                                string ItemTypeID = row["ItemType"].ToString();
                                string Remark = "Excel-Import-" + DateTime.Today.ToShortDateString();

                                if (!objData.exists("Select ItemID From Items Where ItemID ='" + ItemID + "'"))
                                {
                                    //fieldlist = "ItemID, PartNumber,Description, MeasurementID, UnitPrice, VatTaxed, Location, CategoryId, VehicleTypeID, OrderLevel, ItemPurchaseType, ItemTypeID, Remark";
                                    //valuelist = "'" + ItemID + "', '" + PartNumber + "', '" + Description + "', " + MeasurementID.ToString() + ", " +
                                    //                  UnitPrice.ToString() + ", " + VatTaxed.ToString() + ", '" + Location + "', '" +
                                    //                  CategoryId + "', '" + VehicleTypeID + "', " + OrderLevel.ToString() + ", '" +
                                    //                  ItemPurchaseType + "', '" + ItemTypeID + "' , '" + Remark + "'";


                                    fieldlist = "ItemID, PartNumber,Description, MeasurementID, UnitPrice, CategoryId, VehicleTypeID, ItemPurchaseType, ItemTypeID, Remark";
                                    valuelist = "'" + ItemID + "', '" + PartNumber + "', '" + Description + "', " + MeasurementID.ToString() + ", " +
                                                      UnitPrice.ToString() + ", '" +  CategoryId + "', '" + VehicleTypeID + "', '" + ItemPurchaseType + "', '" + ItemTypeID + "' , '" + Remark + "'";


                                    objData.addNewRecord("Items", fieldlist, valuelist, false);
                                    insertCount++;
                                }
                            }
                            else
                            {
                                // Update current balance
                                string ItemID = row["ItemID"].ToString();
                                double cQty = Convert.ToDouble(row["Quantity"].ToString());
                                objData.setItemBeginningBalance(ItemID, clsVariables.sStore, DateTime.Today, cQty);
                                balCount++;
                            }

                        }
                        catch (Exception ex)
                        {
                            if (fieldlist != "")
                            {
                                fieldlist += ", ErrorMsg";
                                valuelist += ", " + ex.Message + "'";
                                errorCount++;
                            }
                        }

                        prgImport.Value = prgCount;

                    } // for each

                    // After Finishing the loop
                    lblMessage.Text = tbl.Rows.Count.ToString() + " - Rows Processed!";
                    lblMessage.ForeColor = Color.Green;

                    lblMessage.Text = insertCount.ToString() + " - Rows Inserted!";
                    lblMessage.ForeColor = Color.Green;
                    lblBalMessage.Text = balCount.ToString() + " - Balances Updated";
                    lblBalMessage.ForeColor = Color.Green;
                }
            
            else
            {
                    int prgCount = 0;
                    foreach (DataRow row in tbl.Rows)
                    {
                        try
                        {
                            prgCount++;
                            string ItemPriceID = this.itemPriceIDTextBox.Text.Trim(); 
                            string ItemID = row["ItemID"].ToString();
                            //string PartNumber = row["PartNumber"].ToString();
                           // string Description = row["Description"].ToString();
                            double UnitPrice = Convert.ToDouble(row["UnitPrice"].ToString());
    
                            fieldlist = "ItemPriceID, ItemID, UnitPrce";
                            valuelist = "'" + ItemPriceID + "', '"  + ItemID + "', "  +   UnitPrice.ToString() ;

                            objData.addNewRecord("ItemPriceSettingsDetails", fieldlist, valuelist, false);
                            insertCount++;

                            if (fset != null) fset.RefreshPriceList();

                           
                        }
                        catch (Exception ex)
                        {
                            if (fieldlist != "")
                            {
                                fieldlist += ", ErrorMsg";
                                valuelist += ", " + ex.Message + "'";

                                //      objData.addNewRecord("AImportErrors", fieldlist, valuelist, false);
                                errorCount++;
                            }
                        }

                        prgImport.Value = prgCount;

                    } // for each

                    // After Finishing the loop
                    lblMessage.Text = tbl.Rows.Count.ToString() + " - Rows Processed!";
                    lblMessage.ForeColor = Color.Green;

                    lblMessage.Text = insertCount.ToString() + " - Rows Inserted!";
                    lblMessage.ForeColor = Color.Green;
                    lblBalMessage.Text = balCount.ToString() + " - Balances Updated";
                    lblBalMessage.ForeColor = Color.Green;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // After Finishing ...
            lblError.Text = errorCount.ToString() + " - Errors!";
            lblError.ForeColor = Color.Red;
            if (stream!=null) stream.Close();
            stream.Dispose();
        }

        private void frmDataImport_Load(object sender, EventArgs e)
        {
            chkItems.Checked = true;
            chkBalances.Checked = false;
            //dtPriceSetting.Value = DateTime.Today;

        }
    }
}
