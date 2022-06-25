using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Runtime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Windows.Forms;
using Belayab.Reports;

namespace Belayab
{
	#region MainForm
	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        public Form fm, fDlg;
     
        public static string strUserName;
        public static string LoginTime;
        public static bool bCloseAfterBackup = false;
        private clsSecurity objSecurity = new clsSecurity();

      

        Form[] childforms =new Form[20];

        int size=0;

        
       
        clsData objData = clsData.Instance;
        clsImage objImage = new clsImage();
        


        private IContainer components;
		#region Class Data

        private StatusStrip stBar;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel stlblLoginTime;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel stlblUserName;
        private WebBrowser wbInformation;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem showMenuToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tileToolStripMenuItem;
        private ToolStripMenuItem hirzibtallyToolStripMenuItem;
        private ToolStripMenuItem verticallyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem closeAllToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem topicsToolStripMenuItem;
        private ToolStripMenuItem abautToolStripMenuItem;
        private ToolStripMenuItem maniDataToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem suppiersToolStripMenuItem;
        private ToolStripMenuItem employeesToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem storeToolStripMenuItem;
        private ToolStripMenuItem receivingToolStripMenuItem;
        private ToolStripMenuItem issuingToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem cashInvoicesToolStripMenuItem;
        private ToolStripMenuItem creditInvoicesToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem securityToolStripMenuItem;
        private ToolStripMenuItem autoNumbersToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem receivablesToolStripMenuItem;
        private ToolStripMenuItem storeSummaryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem reviewToolStripMenuItem;
        private MenuStrip mnuMain;
        private ToolStripMenuItem locationsToolStripMenuItem;
        private ToolStripMenuItem quantitiesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuCreditReceiving;
        private ToolStripMenuItem transferToolStripMenuItem;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem maintenanceToolStripMenuItem;
        private ToolStripMenuItem workOrdersToolStripMenuItem;
        private ToolStripMenuItem mechanicsToolStripMenuItem;
        private ToolStripMenuItem vehiclesToolStripMenuItem;
        private PictureBox picUser;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mechanicToolStripMenuItem;
        private ToolStripMenuItem mantenanceToolStripMenuItem;
        private ToolStripMenuItem requisitionsToolStripMenuItem;
        private BelayAbBranchStore belayAbBranchStore1;
        private ToolStripMenuItem vehicleTypesToolStripMenuItem;
        private ToolStripMenuItem flatRatesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem assignmentsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem performanceToolStripMenuItem;
        private ToolStripMenuItem mantenanceItemTypesToolStripMenuItem;
        private ToolStripMenuItem salesOrderToolStripMenuItem;
        private ToolStripMenuItem itemTypesToolStripMenuItem;
        private ToolStripMenuItem storeToolStripMenuItem1;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripMenuItem reportsToolStripMenuItem1;
        private ToolStripMenuItem salesToolStripMenuItem1;
        private ToolStripMenuItem dailyActivityToolStripMenuItem;
        private ToolStripMenuItem workOrdesNonIssuedToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem1;
        private ToolStripMenuItem sendItemsToolStripMenuItem;
        private ToolStripMenuItem receiveItemsToolStripMenuItem;
        private ToolStripMenuItem lstToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem;
        private ToolStripMenuItem newRequestToolStripMenuItem;
        private ToolStripMenuItem listToolStripMenuItem1;
        private ToolStripMenuItem startNewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem dataImportToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator summaryiesToolStripMenuItem;
        private ToolStripMenuItem summariesToolStripMenuItem;
        private ToolStripMenuItem stockSummaryToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem itemTransactionsToolStripMenuItem;
        private ToolStripMenuItem stockListToolStripMenuItem1;
        private ToolStripMenuItem stockListToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem localToolStripMenuItem1;
        private ToolStripMenuItem inOutToolStripMenuItem;
        private ToolStripMenuItem canibalizedToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem1;
        private ToolStripMenuItem localToolStripMenuItem2;
        private ToolStripMenuItem inOutToolStripMenuItem1;
        private ToolStripMenuItem canibalizedToolStripMenuItem1;
        private ToolStripMenuItem importToolStripMenuItem2;
        private ToolStripMenuItem localToolStripMenuItem3;
        private ToolStripMenuItem inOutToolStripMenuItem2;
        private ToolStripMenuItem canibalizedToolStripMenuItem2;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem1;
        private ToolStripMenuItem importToolStripMenuItem3;
        private ToolStripMenuItem localToolStripMenuItem4;
        private ToolStripMenuItem inOutToolStripMenuItem3;
        private ToolStripMenuItem canibalizedToolStripMenuItem3;
        private ToolStripMenuItem allToolStripMenuItem2;
        private Timer timer1;

		#endregion


		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.wbInformation = new System.Windows.Forms.WebBrowser();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hirzibtallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maniDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.dataImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.requisitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.canibalizedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.inOutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.canibalizedToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canibalizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.lstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.stockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditInvoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCreditReceiving = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.flatRatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryiesToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.summariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workOrdesNonIssuedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mechanicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mantenanceItemTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mechanicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.performanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.belayAbBranchStore1 = new Belayab.BelayAbBranchStore();
            this.importToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.inOutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.canibalizedToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stBar.SuspendLayout();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stBar
            // 
            this.stBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlblUserName,
            this.stlblLoginTime,
            this.toolStripStatusLabel3});
            this.stBar.Location = new System.Drawing.Point(0, 711);
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(1034, 22);
            this.stBar.TabIndex = 52;
            this.stBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel1.Text = "stlblUserName";
            // 
            // stlblUserName
            // 
            this.stlblUserName.Name = "stlblUserName";
            this.stlblUserName.Size = new System.Drawing.Size(0, 17);
            // 
            // stlblLoginTime
            // 
            this.stlblLoginTime.Name = "stlblLoginTime";
            this.stlblLoginTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // wbInformation
            // 
            this.wbInformation.Location = new System.Drawing.Point(896, 927);
            this.wbInformation.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbInformation.Name = "wbInformation";
            this.wbInformation.ScrollBarsEnabled = false;
            this.wbInformation.Size = new System.Drawing.Size(433, 26);
            this.wbInformation.TabIndex = 55;
            this.wbInformation.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMenuToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showMenuToolStripMenuItem
            // 
            this.showMenuToolStripMenuItem.Checked = true;
            this.showMenuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMenuToolStripMenuItem.Name = "showMenuToolStripMenuItem";
            this.showMenuToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.showMenuToolStripMenuItem.Text = "Show Menu";
            this.showMenuToolStripMenuItem.Visible = false;
            this.showMenuToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showMenuToolStripMenuItem_CheckStateChanged);
            this.showMenuToolStripMenuItem.Click += new System.EventHandler(this.showMenuToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.viewToolStripMenuItem.Text = "Window";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hirzibtallyToolStripMenuItem,
            this.verticallyToolStripMenuItem});
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.tileToolStripMenuItem.Text = "Tile";
            // 
            // hirzibtallyToolStripMenuItem
            // 
            this.hirzibtallyToolStripMenuItem.Name = "hirzibtallyToolStripMenuItem";
            this.hirzibtallyToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.hirzibtallyToolStripMenuItem.Text = "Horizontally";
            this.hirzibtallyToolStripMenuItem.Click += new System.EventHandler(this.hirzibtallyToolStripMenuItem_Click);
            // 
            // verticallyToolStripMenuItem
            // 
            this.verticallyToolStripMenuItem.Name = "verticallyToolStripMenuItem";
            this.verticallyToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.verticallyToolStripMenuItem.Text = "Vertically";
            this.verticallyToolStripMenuItem.Click += new System.EventHandler(this.verticallyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicsToolStripMenuItem,
            this.abautToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // topicsToolStripMenuItem
            // 
            this.topicsToolStripMenuItem.Name = "topicsToolStripMenuItem";
            this.topicsToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.topicsToolStripMenuItem.Text = "Topics";
            this.topicsToolStripMenuItem.Click += new System.EventHandler(this.topicsToolStripMenuItem_Click);
            // 
            // abautToolStripMenuItem
            // 
            this.abautToolStripMenuItem.Name = "abautToolStripMenuItem";
            this.abautToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.abautToolStripMenuItem.Text = "About";
            this.abautToolStripMenuItem.Click += new System.EventHandler(this.abautToolStripMenuItem_Click);
            // 
            // maniDataToolStripMenuItem
            // 
            this.maniDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.suppiersToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.toolStripSeparator15,
            this.dataImportToolStripMenuItem});
            this.maniDataToolStripMenuItem.Name = "maniDataToolStripMenuItem";
            this.maniDataToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.maniDataToolStripMenuItem.Text = "Main Data";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // suppiersToolStripMenuItem
            // 
            this.suppiersToolStripMenuItem.Name = "suppiersToolStripMenuItem";
            this.suppiersToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.suppiersToolStripMenuItem.Text = "Suppiers";
            this.suppiersToolStripMenuItem.Click += new System.EventHandler(this.suppiersToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.departmentsToolStripMenuItem.Text = "Departments";
            this.departmentsToolStripMenuItem.Click += new System.EventHandler(this.departmentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(167, 6);
            // 
            // dataImportToolStripMenuItem
            // 
            this.dataImportToolStripMenuItem.Name = "dataImportToolStripMenuItem";
            this.dataImportToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.dataImportToolStripMenuItem.Text = "Data Import";
            this.dataImportToolStripMenuItem.Click += new System.EventHandler(this.dataImportToolStripMenuItem_Click);
            // 
            // storeToolStripMenuItem
            // 
            this.storeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.itemTypesToolStripMenuItem,
            this.locationsToolStripMenuItem,
            this.toolStripSeparator4,
            this.requisitionsToolStripMenuItem,
            this.issuingToolStripMenuItem,
            this.receivingToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.toolStripSeparator5,
            this.stockListToolStripMenuItem,
            this.itemTransactionsToolStripMenuItem});
            this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
            this.storeToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.storeToolStripMenuItem.Text = "Inventory";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // itemTypesToolStripMenuItem
            // 
            this.itemTypesToolStripMenuItem.Name = "itemTypesToolStripMenuItem";
            this.itemTypesToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.itemTypesToolStripMenuItem.Text = "ItemTypes";
            this.itemTypesToolStripMenuItem.Click += new System.EventHandler(this.itemTypesToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.locationsToolStripMenuItem.Text = "Branches && Stores";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // requisitionsToolStripMenuItem
            // 
            this.requisitionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeToolStripMenuItem1,
            this.transferToolStripMenuItem1,
            this.purchaseToolStripMenuItem});
            this.requisitionsToolStripMenuItem.Name = "requisitionsToolStripMenuItem";
            this.requisitionsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.requisitionsToolStripMenuItem.Text = "Requisition";
            // 
            // storeToolStripMenuItem1
            // 
            this.storeToolStripMenuItem1.Name = "storeToolStripMenuItem1";
            this.storeToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.storeToolStripMenuItem1.Text = "Local Store";
            this.storeToolStripMenuItem1.Click += new System.EventHandler(this.storeToolStripMenuItem1_Click);
            // 
            // transferToolStripMenuItem1
            // 
            this.transferToolStripMenuItem1.Name = "transferToolStripMenuItem1";
            this.transferToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.transferToolStripMenuItem1.Text = "Transfer";
            this.transferToolStripMenuItem1.Click += new System.EventHandler(this.transferToolStripMenuItem1_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
            // 
            // issuingToolStripMenuItem
            // 
            this.issuingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem,
            this.startNewToolStripMenuItem,
            this.toolStripSeparator13,
            this.listToolStripMenuItem1,
            this.importToolStripMenuItem3,
            this.localToolStripMenuItem4,
            this.inOutToolStripMenuItem3,
            this.canibalizedToolStripMenuItem3,
            this.allToolStripMenuItem2});
            this.issuingToolStripMenuItem.Name = "issuingToolStripMenuItem";
            this.issuingToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.issuingToolStripMenuItem.Text = "Issuing";
            this.issuingToolStripMenuItem.Click += new System.EventHandler(this.issuingToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.localToolStripMenuItem.Text = "From Requisition";
            this.localToolStripMenuItem.Visible = false;
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // startNewToolStripMenuItem
            // 
            this.startNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localToolStripMenuItem2,
            this.inOutToolStripMenuItem1,
            this.canibalizedToolStripMenuItem1,
            this.importToolStripMenuItem1});
            this.startNewToolStripMenuItem.Name = "startNewToolStripMenuItem";
            this.startNewToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.startNewToolStripMenuItem.Text = "Issue";
            this.startNewToolStripMenuItem.Visible = false;
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.importToolStripMenuItem1.Text = "Import";
            this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
            // 
            // localToolStripMenuItem2
            // 
            this.localToolStripMenuItem2.Name = "localToolStripMenuItem2";
            this.localToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.localToolStripMenuItem2.Text = "Local";
            this.localToolStripMenuItem2.Click += new System.EventHandler(this.localToolStripMenuItem2_Click);
            // 
            // inOutToolStripMenuItem1
            // 
            this.inOutToolStripMenuItem1.Name = "inOutToolStripMenuItem1";
            this.inOutToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.inOutToolStripMenuItem1.Text = "InOut";
            this.inOutToolStripMenuItem1.Click += new System.EventHandler(this.inOutToolStripMenuItem1_Click);
            // 
            // canibalizedToolStripMenuItem1
            // 
            this.canibalizedToolStripMenuItem1.Name = "canibalizedToolStripMenuItem1";
            this.canibalizedToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.canibalizedToolStripMenuItem1.Text = "Canibalized";
            this.canibalizedToolStripMenuItem1.Click += new System.EventHandler(this.canibalizedToolStripMenuItem1_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(193, 6);
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inOutToolStripMenuItem2,
            this.canibalizedToolStripMenuItem2,
            this.allToolStripMenuItem,
            this.importToolStripMenuItem2,
            this.localToolStripMenuItem3});
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(196, 26);
            this.listToolStripMenuItem1.Text = "List";
            this.listToolStripMenuItem1.Visible = false;
            // 
            // importToolStripMenuItem2
            // 
            this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
            this.importToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.importToolStripMenuItem2.Text = "Import";
            this.importToolStripMenuItem2.Click += new System.EventHandler(this.importToolStripMenuItem2_Click);
            // 
            // localToolStripMenuItem3
            // 
            this.localToolStripMenuItem3.Name = "localToolStripMenuItem3";
            this.localToolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
            this.localToolStripMenuItem3.Text = "Local";
            this.localToolStripMenuItem3.Click += new System.EventHandler(this.localToolStripMenuItem3_Click);
            // 
            // inOutToolStripMenuItem2
            // 
            this.inOutToolStripMenuItem2.Name = "inOutToolStripMenuItem2";
            this.inOutToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.inOutToolStripMenuItem2.Text = "InOut";
            this.inOutToolStripMenuItem2.Click += new System.EventHandler(this.inOutToolStripMenuItem2_Click);
            // 
            // canibalizedToolStripMenuItem2
            // 
            this.canibalizedToolStripMenuItem2.Name = "canibalizedToolStripMenuItem2";
            this.canibalizedToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.canibalizedToolStripMenuItem2.Text = "Canibalized";
            this.canibalizedToolStripMenuItem2.Click += new System.EventHandler(this.canibalizedToolStripMenuItem2_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // receivingToolStripMenuItem
            // 
            this.receivingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.localToolStripMenuItem1,
            this.inOutToolStripMenuItem,
            this.canibalizedToolStripMenuItem,
            this.allToolStripMenuItem1});
            this.receivingToolStripMenuItem.Name = "receivingToolStripMenuItem";
            this.receivingToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.receivingToolStripMenuItem.Text = "Receiving";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem1
            // 
            this.localToolStripMenuItem1.Name = "localToolStripMenuItem1";
            this.localToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.localToolStripMenuItem1.Text = "Local";
            this.localToolStripMenuItem1.Click += new System.EventHandler(this.localToolStripMenuItem1_Click);
            // 
            // inOutToolStripMenuItem
            // 
            this.inOutToolStripMenuItem.Name = "inOutToolStripMenuItem";
            this.inOutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.inOutToolStripMenuItem.Text = "InOut";
            this.inOutToolStripMenuItem.Click += new System.EventHandler(this.inOutToolStripMenuItem_Click);
            // 
            // canibalizedToolStripMenuItem
            // 
            this.canibalizedToolStripMenuItem.Name = "canibalizedToolStripMenuItem";
            this.canibalizedToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.canibalizedToolStripMenuItem.Text = "Canibalized";
            this.canibalizedToolStripMenuItem.Click += new System.EventHandler(this.canibalizedToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem1
            // 
            this.allToolStripMenuItem1.Name = "allToolStripMenuItem1";
            this.allToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.allToolStripMenuItem1.Text = "All";
            this.allToolStripMenuItem1.Click += new System.EventHandler(this.allToolStripMenuItem1_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem,
            this.sendItemsToolStripMenuItem,
            this.receiveItemsToolStripMenuItem,
            this.toolStripSeparator14,
            this.lstToolStripMenuItem});
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newRequestToolStripMenuItem.Text = "New Request";
            this.newRequestToolStripMenuItem.Click += new System.EventHandler(this.newRequestToolStripMenuItem_Click);
            // 
            // sendItemsToolStripMenuItem
            // 
            this.sendItemsToolStripMenuItem.Name = "sendItemsToolStripMenuItem";
            this.sendItemsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sendItemsToolStripMenuItem.Text = "Send Items";
            this.sendItemsToolStripMenuItem.Click += new System.EventHandler(this.sendItemsToolStripMenuItem_Click);
            // 
            // receiveItemsToolStripMenuItem
            // 
            this.receiveItemsToolStripMenuItem.Name = "receiveItemsToolStripMenuItem";
            this.receiveItemsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.receiveItemsToolStripMenuItem.Text = "Receive Items";
            this.receiveItemsToolStripMenuItem.Click += new System.EventHandler(this.receiveItemsToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(178, 6);
            // 
            // lstToolStripMenuItem
            // 
            this.lstToolStripMenuItem.Name = "lstToolStripMenuItem";
            this.lstToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lstToolStripMenuItem.Text = "List";
            this.lstToolStripMenuItem.Click += new System.EventHandler(this.lstToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(201, 6);
            // 
            // stockListToolStripMenuItem
            // 
            this.stockListToolStripMenuItem.Name = "stockListToolStripMenuItem";
            this.stockListToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.stockListToolStripMenuItem.Text = "Stock List";
            this.stockListToolStripMenuItem.Click += new System.EventHandler(this.stockListToolStripMenuItem_Click);
            // 
            // itemTransactionsToolStripMenuItem
            // 
            this.itemTransactionsToolStripMenuItem.Name = "itemTransactionsToolStripMenuItem";
            this.itemTransactionsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.itemTransactionsToolStripMenuItem.Text = "Item Transactions";
            this.itemTransactionsToolStripMenuItem.Click += new System.EventHandler(this.itemTransactionsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOrderToolStripMenuItem,
            this.cashInvoicesToolStripMenuItem,
            this.creditInvoicesToolStripMenuItem,
            this.toolStripSeparator3,
            this.mnuCreditReceiving,
            this.toolStripSeparator12,
            this.reportsToolStripMenuItem1});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // salesOrderToolStripMenuItem
            // 
            this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
            this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.salesOrderToolStripMenuItem.Text = "Sales Order";
            this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.salesOrderToolStripMenuItem_Click);
            // 
            // cashInvoicesToolStripMenuItem
            // 
            this.cashInvoicesToolStripMenuItem.Name = "cashInvoicesToolStripMenuItem";
            this.cashInvoicesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cashInvoicesToolStripMenuItem.Text = "Cash Invoices";
            this.cashInvoicesToolStripMenuItem.Click += new System.EventHandler(this.cashInvoicesToolStripMenuItem_Click);
            // 
            // creditInvoicesToolStripMenuItem
            // 
            this.creditInvoicesToolStripMenuItem.Name = "creditInvoicesToolStripMenuItem";
            this.creditInvoicesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.creditInvoicesToolStripMenuItem.Text = "Credit Invoices";
            this.creditInvoicesToolStripMenuItem.Click += new System.EventHandler(this.creditInvoicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // mnuCreditReceiving
            // 
            this.mnuCreditReceiving.Name = "mnuCreditReceiving";
            this.mnuCreditReceiving.Size = new System.Drawing.Size(192, 26);
            this.mnuCreditReceiving.Text = "Credit Receiving";
            this.mnuCreditReceiving.Click += new System.EventHandler(this.mnuCreditReceiving_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(189, 6);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem1});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // salesToolStripMenuItem1
            // 
            this.salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            this.salesToolStripMenuItem1.Size = new System.Drawing.Size(137, 26);
            this.salesToolStripMenuItem1.Text = "Periodic";
            this.salesToolStripMenuItem1.Click += new System.EventHandler(this.salesToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.autoNumbersToolStripMenuItem,
            this.toolStripSeparator8,
            this.securityToolStripMenuItem,
            this.toolStripSeparator7,
            this.flatRatesToolStripMenuItem,
            this.testToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.settingsToolStripMenuItem.Text = "General Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // autoNumbersToolStripMenuItem
            // 
            this.autoNumbersToolStripMenuItem.Name = "autoNumbersToolStripMenuItem";
            this.autoNumbersToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.autoNumbersToolStripMenuItem.Text = "Auto Numbers";
            this.autoNumbersToolStripMenuItem.Click += new System.EventHandler(this.autoNumbersToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(189, 6);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.securityToolStripMenuItem.Text = "Security";
            this.securityToolStripMenuItem.Click += new System.EventHandler(this.securityToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(189, 6);
            // 
            // flatRatesToolStripMenuItem
            // 
            this.flatRatesToolStripMenuItem.Name = "flatRatesToolStripMenuItem";
            this.flatRatesToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.flatRatesToolStripMenuItem.Text = "Flat Rates";
            this.flatRatesToolStripMenuItem.Click += new System.EventHandler(this.flatRatesToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivablesToolStripMenuItem,
            this.quantitiesToolStripMenuItem,
            this.storeSummaryToolStripMenuItem,
            this.toolStripSeparator2,
            this.reviewToolStripMenuItem,
            this.dailyActivityToolStripMenuItem,
            this.summaryiesToolStripMenuItem,
            this.summariesToolStripMenuItem,
            this.toolStripMenuItem2});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // receivablesToolStripMenuItem
            // 
            this.receivablesToolStripMenuItem.Name = "receivablesToolStripMenuItem";
            this.receivablesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.receivablesToolStripMenuItem.Text = "Receivables";
            this.receivablesToolStripMenuItem.Click += new System.EventHandler(this.receivablesToolStripMenuItem_Click);
            // 
            // quantitiesToolStripMenuItem
            // 
            this.quantitiesToolStripMenuItem.Name = "quantitiesToolStripMenuItem";
            this.quantitiesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.quantitiesToolStripMenuItem.Text = "Transaction";
            this.quantitiesToolStripMenuItem.Click += new System.EventHandler(this.quantitiesToolStripMenuItem_Click);
            // 
            // storeSummaryToolStripMenuItem
            // 
            this.storeSummaryToolStripMenuItem.Name = "storeSummaryToolStripMenuItem";
            this.storeSummaryToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.storeSummaryToolStripMenuItem.Text = "Store Summary";
            this.storeSummaryToolStripMenuItem.Visible = false;
            this.storeSummaryToolStripMenuItem.Click += new System.EventHandler(this.storeSummaryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(198, 6);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.reviewToolStripMenuItem.Text = "Review";
            this.reviewToolStripMenuItem.Click += new System.EventHandler(this.reviewToolStripMenuItem_Click);
            // 
            // dailyActivityToolStripMenuItem
            // 
            this.dailyActivityToolStripMenuItem.Name = "dailyActivityToolStripMenuItem";
            this.dailyActivityToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.dailyActivityToolStripMenuItem.Text = "Periodic Activities";
            this.dailyActivityToolStripMenuItem.Click += new System.EventHandler(this.dailyActivityToolStripMenuItem_Click);
            // 
            // summaryiesToolStripMenuItem
            // 
            this.summaryiesToolStripMenuItem.Name = "summaryiesToolStripMenuItem";
            this.summaryiesToolStripMenuItem.Size = new System.Drawing.Size(198, 6);
            // 
            // summariesToolStripMenuItem
            // 
            this.summariesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockListToolStripMenuItem1,
            this.stockSummaryToolStripMenuItem});
            this.summariesToolStripMenuItem.Name = "summariesToolStripMenuItem";
            this.summariesToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.summariesToolStripMenuItem.Text = "Summaries";
            // 
            // stockListToolStripMenuItem1
            // 
            this.stockListToolStripMenuItem1.Name = "stockListToolStripMenuItem1";
            this.stockListToolStripMenuItem1.Size = new System.Drawing.Size(186, 26);
            this.stockListToolStripMenuItem1.Text = "Stock List";
            this.stockListToolStripMenuItem1.Click += new System.EventHandler(this.stockListToolStripMenuItem1_Click);
            // 
            // stockSummaryToolStripMenuItem
            // 
            this.stockSummaryToolStripMenuItem.Name = "stockSummaryToolStripMenuItem";
            this.stockSummaryToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.stockSummaryToolStripMenuItem.Text = "Stock Summary";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 26);
            this.toolStripMenuItem2.Text = "Stock List";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maniDataToolStripMenuItem,
            this.storeToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.viewToolStripMenuItem;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1034, 28);
            this.mnuMain.TabIndex = 46;
            this.mnuMain.Text = "mainMenu";
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrdersToolStripMenuItem,
            this.workOrdesNonIssuedToolStripMenuItem,
            this.toolStripSeparator10,
            this.mechanicsToolStripMenuItem,
            this.assignmentsToolStripMenuItem,
            this.toolStripSeparator9,
            this.mantenanceItemTypesToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.vehicleTypesToolStripMenuItem,
            this.toolStripSeparator6,
            this.toolStripMenuItem1});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // workOrdersToolStripMenuItem
            // 
            this.workOrdersToolStripMenuItem.Name = "workOrdersToolStripMenuItem";
            this.workOrdersToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.workOrdersToolStripMenuItem.Text = "Work Orders";
            this.workOrdersToolStripMenuItem.Click += new System.EventHandler(this.workOrdersToolStripMenuItem_Click);
            // 
            // workOrdesNonIssuedToolStripMenuItem
            // 
            this.workOrdesNonIssuedToolStripMenuItem.Name = "workOrdesNonIssuedToolStripMenuItem";
            this.workOrdesNonIssuedToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.workOrdesNonIssuedToolStripMenuItem.Text = "Work Ordes (Non Issued)";
            this.workOrdesNonIssuedToolStripMenuItem.Click += new System.EventHandler(this.workOrdesNonIssuedToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(245, 6);
            // 
            // mechanicsToolStripMenuItem
            // 
            this.mechanicsToolStripMenuItem.Name = "mechanicsToolStripMenuItem";
            this.mechanicsToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.mechanicsToolStripMenuItem.Text = "Mechanics";
            this.mechanicsToolStripMenuItem.Click += new System.EventHandler(this.mechanicsToolStripMenuItem_Click);
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.assignmentsToolStripMenuItem.Text = "Assignments";
            this.assignmentsToolStripMenuItem.Click += new System.EventHandler(this.assignmentsToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(245, 6);
            // 
            // mantenanceItemTypesToolStripMenuItem
            // 
            this.mantenanceItemTypesToolStripMenuItem.Name = "mantenanceItemTypesToolStripMenuItem";
            this.mantenanceItemTypesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.mantenanceItemTypesToolStripMenuItem.Text = "Mantenance Item Types";
            this.mantenanceItemTypesToolStripMenuItem.Click += new System.EventHandler(this.mantenanceItemTypesToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.vehiclesToolStripMenuItem.Text = "Vehicles/Items";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // vehicleTypesToolStripMenuItem
            // 
            this.vehicleTypesToolStripMenuItem.Name = "vehicleTypesToolStripMenuItem";
            this.vehicleTypesToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.vehicleTypesToolStripMenuItem.Text = "Vehicle Types";
            this.vehicleTypesToolStripMenuItem.Click += new System.EventHandler(this.vehicleTypesToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(245, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenanceToolStripMenuItem,
            this.mechanicToolStripMenuItem,
            this.toolStripSeparator11,
            this.performanceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(248, 26);
            this.toolStripMenuItem1.Text = "Periodic Report";
            // 
            // mantenanceToolStripMenuItem
            // 
            this.mantenanceToolStripMenuItem.Name = "mantenanceToolStripMenuItem";
            this.mantenanceToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.mantenanceToolStripMenuItem.Text = "Mantenance";
            this.mantenanceToolStripMenuItem.Click += new System.EventHandler(this.mantenanceToolStripMenuItem_Click);
            // 
            // mechanicToolStripMenuItem
            // 
            this.mechanicToolStripMenuItem.Name = "mechanicToolStripMenuItem";
            this.mechanicToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.mechanicToolStripMenuItem.Text = "Mechanic";
            this.mechanicToolStripMenuItem.Click += new System.EventHandler(this.mechanicToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(164, 6);
            // 
            // performanceToolStripMenuItem
            // 
            this.performanceToolStripMenuItem.Name = "performanceToolStripMenuItem";
            this.performanceToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.performanceToolStripMenuItem.Text = "Performance";
            this.performanceToolStripMenuItem.Click += new System.EventHandler(this.performanceToolStripMenuItem_Click);
            // 
            // picUser
            // 
            this.picUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("picUser.InitialImage")));
            this.picUser.Location = new System.Drawing.Point(134, 888);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(14, 12);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 57;
            this.picUser.TabStop = false;
            this.picUser.Visible = false;
            // 
            // belayAbBranchStore1
            // 
            this.belayAbBranchStore1.DataSetName = "BelayAbBranchStore";
            this.belayAbBranchStore1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importToolStripMenuItem3
            // 
            this.importToolStripMenuItem3.Name = "importToolStripMenuItem3";
            this.importToolStripMenuItem3.Size = new System.Drawing.Size(196, 26);
            this.importToolStripMenuItem3.Text = "Import";
            this.importToolStripMenuItem3.Click += new System.EventHandler(this.importToolStripMenuItem3_Click);
            // 
            // localToolStripMenuItem4
            // 
            this.localToolStripMenuItem4.Name = "localToolStripMenuItem4";
            this.localToolStripMenuItem4.Size = new System.Drawing.Size(196, 26);
            this.localToolStripMenuItem4.Text = "Local";
            this.localToolStripMenuItem4.Click += new System.EventHandler(this.localToolStripMenuItem4_Click);
            // 
            // inOutToolStripMenuItem3
            // 
            this.inOutToolStripMenuItem3.Name = "inOutToolStripMenuItem3";
            this.inOutToolStripMenuItem3.Size = new System.Drawing.Size(196, 26);
            this.inOutToolStripMenuItem3.Text = "InOut";
            this.inOutToolStripMenuItem3.Click += new System.EventHandler(this.inOutToolStripMenuItem3_Click);
            // 
            // canibalizedToolStripMenuItem3
            // 
            this.canibalizedToolStripMenuItem3.Name = "canibalizedToolStripMenuItem3";
            this.canibalizedToolStripMenuItem3.Size = new System.Drawing.Size(196, 26);
            this.canibalizedToolStripMenuItem3.Text = "Canibalized";
            this.canibalizedToolStripMenuItem3.Click += new System.EventHandler(this.canibalizedToolStripMenuItem3_Click);
            // 
            // allToolStripMenuItem2
            // 
            this.allToolStripMenuItem2.Name = "allToolStripMenuItem2";
            this.allToolStripMenuItem2.Size = new System.Drawing.Size(196, 26);
            this.allToolStripMenuItem2.Text = "All";
            this.allToolStripMenuItem2.Click += new System.EventHandler(this.allToolStripMenuItem2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Belayab.Properties.Resources.Belayab_Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 733);
            this.Controls.Add(this.wbInformation);
            this.Controls.Add(this.stBar);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.picUser);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "Vehicle Mentenace Information System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.stBar.ResumeLayout(false);
            this.stBar.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		/// <summary>
		/// 
		/// </summary>
		private void InitialiseDescriptors()
		{
		}

		#endregion


		#region Methods

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}

			base.Dispose(disposing);
		}


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

		#endregion


		#region Events

		#region Menu
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cycleMenuItem_Click(object sender, System.EventArgs e)
		{
			//this.systemTaskPane.Expandos.MoveToBottom(this.systemTaskPane.Expandos[0]);
		}


	



	
/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        //private void myNetworkMenuItem_Click(object sender, System.EventArgs e)
        //{
        //    if (this.Adminitstration.Collapsed)
        //    {
        //        return;
        //    }
			
        //    this.myNetworkMenuItem.Checked = !this.myNetworkMenuItem.Checked;
			
        //    if (!this.myNetworkMenuItem.Checked)
        //    {
        //        this.Adminitstration.HideControl(this.myNetworkPlacesTaskItem);
        //    }
        //    else
        //    {
        //        this.Adminitstration.ShowControl(this.myNetworkPlacesTaskItem);
        //    }
        //}


		

		#endregion

        private void ItemsCategories_Click(object sender, EventArgs e)
        {
            frmItemEdit  f = new frmItemEdit ();
            OpenFrm(f);
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

            wbInformation.Left = this.Right - wbInformation.Width;
            wbInformation.Top = stBar.Top;

            wbInformation.BringToFront();

            picUser.Top = this.Height - picUser.Height -stBar.Height;


           
            if (fm != null)
            {
                PositionForm(fm);
                
            }
        }

        private void SalesInvoices_Click(object sender, EventArgs e)
        {
            frmInvoices f = new frmInvoices();
            OpenFrm(f);
        }

        public  void OpenFrm(Form f)
        {
            size = 0;
            objSecurity.setRolePermissions(f);

            foreach (Form frm in Application.OpenForms)
                if (frm.Name == f.Name && frm.Name != "frmReportsViewer")
                {
                    f = frm;
                    f.Show();
                    f.BringToFront();
                    return;
                }

            f.MdiParent = this;
            f.WindowState  = FormWindowState.Normal;
            f.AutoScroll = true;
            f.Show();

            PositionForm(f);

            fm = f;

            childforms[size++] = f;
        }


        public void OpenOverFrm(Form f)
        {

            f.MdiParent = this;
            f.WindowState = FormWindowState.Normal;


            foreach (Form frm in Application.OpenForms)
                if (frm.Name == f.Name)
                {
                    f = frm;
                    f.Show();
                    f.BringToFront();
                    return;
                }

            
            f.Show();

            PositionForm(f);
         
            fm = f;

            childforms[size++] = f;

            //objSecurity.setRolePermissions(f);

        }

        private void shareFolderTaskItem_Click(object sender, EventArgs e)
        {
            frmIssue f = new frmIssue();
            OpenFrm(f);
        }

        public  void OpenwithOutMaxi(Form f)
        {
            OpenFrm (f);
            fm = f;
            childforms[size++] = f;
            objSecurity.setRolePermissions(f);
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            frmBranch_Store f = new frmBranch_Store();
            OpenFrm(f);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomersSuppliers_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers f = new frmCustomersSuppliers();
            OpenFrm(f);
        }

        private void goodsReceiving_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNote f = new frmGoodReceivedNote();
            OpenFrm(f);
          
        }

        private void goodsRequisition_Click(object sender, EventArgs e)
        {
            frmItemRequisitions f = new frmItemRequisitions();
            OpenFrm(f);
        }

        private void employeesDepartments_Click(object sender, EventArgs e)
        {
            frmDepartment_Employees f = new frmDepartment_Employees();
            OpenFrm(f);

        }

        

        private void UsersPermissions_Click(object sender, EventArgs e)
        {
            frmSecurity f = new frmSecurity();
            OpenFrm(f);
        }

      

        private void GeneralSettings_Click(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting();
            OpenwithOutMaxi(f);
        }

        private void Closefrms()
        {
            
        }

        private void CreditInvoices_Click(object sender, EventArgs e)
        {
            frmInvoicesCredit f = new frmInvoicesCredit();
            OpenFrm(f);
        }
        private void CreditPayments_Click(object sender, EventArgs e)
        {
            frmCreditPayments f = new frmCreditPayments();
            OpenFrm(f);
            f.calculateAllCredits();
        }

        private void AdvanceLoan_Click(object sender, EventArgs e)
        {
            frmAdvanceLoan f = new frmAdvanceLoan();
            OpenFrm(f);
 
        }

        private void CustomerHistory_Click(object sender, EventArgs e)
        {
            FrmViewItemDetails_Tx f = new FrmViewItemDetails_Tx();
            OpenFrm(f);

        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_StockSummary";

            frmv.SetReport(new rptStockSummary(), strSQL, "rpt_StockSummary");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void Employeelist_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_SoldOnCash ";

            frmv.SetReport(new rptSoldOnCashSummary(), strSQL, "rpt_SoldOnCash");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
         
            if (clsVariables.sStore != "All")
            {

                string strSQL = "SELECT     Branches.BranchName  FROM   Stores INNER JOIN  Branches ON Stores.BranchId = " +
                             " Branches.BranchId Where Stores.StoreId='" + clsVariables.sStore + "'";
                clsVariables.sBranch = objData.getFieldValue(strSQL);

            }

            else
                clsVariables.sBranch = "None"; 
            
           
           
            stlblUserName.Text = "User Name: " + strUserName.ToUpper() + ",  Working Branch ->  " + clsVariables.sBranch.ToUpper();
            
                   
            string Uname = objData.getStringValue("Select FullName From USers Where UserName = '" + strUserName.ToUpper() + "'");
            

            clsVariables.OHAmt = 0.01M* objData.getFieldAmt("Select Percentage from Percentages Where ValueDescription ='OverHead'");
            clsVariables.VATAmt = 0.01M* objData.getFieldAmt("Select Percentage from Percentages Where ValueDescription ='VAT'");

            clsVariables.mLaborRate = objData.getFieldAmt("Select Value from m_KeyValuePairs Where VKey='LaborRate'");


 
            if (clsVariables.sEmployeeDepartment != "ADMIN" && clsVariables.userRole != "APPROVER")
                issuingToolStripMenuItem.Visible = false;

            if (clsVariables.userRole.ToUpper() == "STORE HEAD")
                issuingToolStripMenuItem.Visible = true;

            if (clsVariables.sEmployeeDepartment!= "ADMIN" && clsVariables.userRole != "APPROVER"  )
            {
                employeesToolStripMenuItem.Visible = false;
                departmentsToolStripMenuItem.Visible = false;
               //lstToolStripMenuItem.Visible = false;
            }

            if (clsVariables.userRole.ToUpper() == "APPROVER")
            {
              
                lstToolStripMenuItem.Visible = true;
                issuingToolStripMenuItem.Visible = true;
            }

            if (clsVariables.sEmployeeDepartment.ToUpper() == "Inventory".ToUpper())
            {
                 issuingToolStripMenuItem.Visible = false;
                 maintenanceToolStripMenuItem.Visible = false;
                 salesOrderToolStripMenuItem.Visible= false;
                 optionsToolStripMenuItem.Visible = false;
                 salesToolStripMenuItem.Visible = false;
            }

            if (clsVariables.sEmployeeDepartment.ToUpper() == "Maintenance".ToUpper())
            {
                optionsToolStripMenuItem.Visible = false;
                salesToolStripMenuItem.Visible = false;
            }

            MainForm_Resize(null, null);
        }
        public void setWebTotals()
        {
            try
            {
                
                wbInformation.Navigate("");
                clsIOStream.setWebInfo_Remove();
                clsIOStream.setWebInfo_Create();
                wbInformation.Navigate(Path.GetTempPath().ToString() + @"webinfo.htm");
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
        }
           }

        private void timer1_Tick(object sender, EventArgs e)
        {
           setWebTotals();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            frmViewGroupAll f = new frmViewGroupAll();
            OpenFrm(f);
        }


        private void PositionForm(Form f)
        {
            Point p = new Point(0, 0);
            f.Location = p;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Active");
        }

        private void taskItem1_Click(object sender, EventArgs e)
        {
            Form frm = null;
            
            if (clsVariables.userRole == "Admin")
            {
                if (clsVariables.curUserName.Contains("Nat") || clsVariables.curUserName.Contains("CS"))
                {
                    frm = new frmMaintenanceHomeCS();
                    
                }
                else
                {
                    frm = new frmMaintenanceHomeCS();
                   
                }
            }
            else
            {
                frm = new frmMaintenanceHomeCS();
             
            }

           if (frm!=null) 
               OpenFrm(frm);
            
        }

        private void taskItem2_Click(object sender, EventArgs e)
        {
            frmMechanic f = new frmMechanic();
            OpenFrm(f);
        }

        private void taskItem3_Click(object sender, EventArgs e)
        {
             frmVehicles f = new frmVehicles();
             OpenFrm(f);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Program.loginFrm.Visible = true;
            Program.loginFrm.txtUserName.Text  = "";
            Program.loginFrm.txtPassword.Text = "";
            this.Visible = false;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMenuToolStripMenuItem.Checked = !showMenuToolStripMenuItem.Checked;
            

        }

        private void showMenuToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            wbInformation.Visible = (showMenuToolStripMenuItem.CheckState == CheckState.Checked);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
        }

        private void hirzibtallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void PeriodicReports_Click(object sender, EventArgs e)
        {

            if (fDlg != null)
            {
                if (fDlg.Name != "frmReportForm")
                {
                    fDlg.Close();
                    fDlg = new frmReportForm();
                }
            }
            else
                fDlg = new frmReportForm();
                fDlg.ShowDialog();
        }

        private void m_monthlySummary_Click(object sender, EventArgs e)
        {
            if (fDlg != null)
            {
                if (fDlg.Name != "frmMaintenanceReport")
                {
                    fDlg.Close();
                    fDlg = new frmMaintenanceReport();
                }

            }
            else
               fDlg = new frmMaintenanceReport();
               fDlg.ShowDialog();    
        }

        private void topicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + "\\BHNew.chm");
        }

        private void abautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStartup fst = new frmStartup(1);
            fst.ShowDialog();
        }

        private void InvoiceNumbers_Click(object sender, EventArgs e)
        {
            frmNumberSettings fnm = new frmNumberSettings();
            OpenFrm(fnm);

        }

        private void MainPanel_Click(object sender, EventArgs e)
        {

        }

        private void Vehcles_Click(object sender, EventArgs e)
        {

        }

      

        private void PurchaeRequisition_Click(object sender, EventArgs e)
        {
            frmPurchaseReqisition mf = new frmPurchaseReqisition();
            OpenFrm(mf);

        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit the application?", "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
           
                e.Cancel = true;
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemEdit f = new frmItemEdit();
            OpenFrm(f);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories f = new frmCategories();
            Program.mainFrm.OpenFrm(f);
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranch_Store f = new frmBranch_Store();
            OpenFrm(f);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers f = new frmCustomersSuppliers();
            OpenFrm(f);
            f.tabSupplier_Customer.SelectedIndex = 1;
        }

        private void suppiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersSuppliers f = new frmCustomersSuppliers();
            OpenFrm(f);
            f.tabSupplier_Customer.SelectedIndex = 0;
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment_Employees f = new frmDepartment_Employees();
            OpenFrm(f);
            f.tabEmployee.SelectedIndex = 1;

        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment_Employees f = new frmDepartment_Employees();
            OpenFrm(f);
            f.tabEmployee.SelectedIndex = 0;

        }

      

        private void issuingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cashInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoices f = new frmInvoices();
            OpenFrm(f);
        }
        private void creditInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoicesCredit f = new frmInvoicesCredit();
            OpenFrm(f);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSetting f = new frmSetting();
            OpenFrm(f);
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecurity f = new frmSecurity();
            OpenFrm(f);

        }

        private void autoNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumberSettings f = new frmNumberSettings();
            OpenFrm(f);

        }

        private void receivablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReportForm(1);
        }

        private void quantitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReportForm(0);
        }


        private void openReportForm(int tabIdx)
        {
            if (fDlg != null)
            {
                if (fDlg.Name != "frmReportForm")
                {
                    fDlg.Close();
                    fDlg.Dispose();
                }
            }
                frmReportForm frm = new frmReportForm();
                frm.tabPeriodicReport.SelectedIndex = tabIdx;
                fDlg = frm;
                fDlg.ShowDialog();
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewGroupAll f = new frmViewGroupAll();
            OpenFrm(f);
        }

        private void storeSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportsViewer frmv = new frmReportsViewer();

            string strSQL = "Select * from rpt_StockSummary";

            frmv.SetReport(new rptStockSummary(), strSQL, "rpt_StockSummary");

            Program.mainFrm.OpenOverFrm(frmv);
        }

        private void mnuCreditReceiving_Click(object sender, EventArgs e)
        {
            frmCreditPayments f = new frmCreditPayments();
            OpenFrm(f);
            f.calculateAllCredits();
        }

      

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmItemCurrentBalance f = new frmItemCurrentBalance();

            OpenFrm(f);
            f.fillAll();
            
        }

        private void workOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskItem1_Click(new object(), new EventArgs());
        }

        private void mechanicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskItem2_Click(new object(), new EventArgs());
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskItem3_Click(new object(), new EventArgs());
        }

        private void mantenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenanceReport f = new frmMaintenanceReport();
            OpenFrm(f);
            f.tbMaintenanceReports.SelectedIndex = 0;
        }

        private void mechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenanceReport f = new frmMaintenanceReport();
            OpenFrm(f);
            f.tbMaintenanceReports.SelectedIndex = 1;
        }

        

        private void vehicleTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehicleModels frvm = new frmVehicleModels();
           
            Program.mainFrm.OpenFrm(frvm);
        }

        private void flatRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFlatRates flr = new frmFlatRates();
            Program.mainFrm.OpenFrm(flr);
        }

        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVLaborCostDetails flbc = new frmVLaborCostDetails();
            Program.mainFrm.OpenFrm(flbc);

        }

        private void performanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMPerformance frPer = new frmMPerformance();
            Program.mainFrm.OpenFrm(frPer);

        }

        private void mantenanceItemTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMItemTypes frItm = new frmMItemTypes();
            Program.mainFrm.OpenFrm(frItm);

        }

        private void salesOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoicesHome f = new frmInvoicesHome();

            OpenFrm(f);
            
        }


        private void storeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItemRequisitionsHome f = new frmItemRequisitionsHome();
            OpenFrm(f);
            f.btnSendItems.Visible = false;
            f.btnSendItems.Visible = false;
            f.lblReqType.Visible = false;
            f.workingLocal = true;
            f.FillLocalRequistions(f.displayFor);

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseRqHome f = new frmPurchaseRqHome();
            OpenFrm(f);
        }

        private void itemTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmItemTypes f = new FrmItemTypes();
            OpenFrm(f);
        }

        private void dailyActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodicActivities f = new frmPeriodicActivities();
            OpenFrm(f);
        }

        private void workOrdesNonIssuedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWOrkshopItemsNonIssued f = new frmWOrkshopItemsNonIssued();
            OpenFrm(f);
        }

      
        private void receiveItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmItemRequisitionsHome f = new frmItemRequisitionsHome();
            OpenFrm(f);
            f.requsitionType = "TR";
            f.ReqTypeComboBox.Text = "TR_R_Sent";
            f.FillTransferRequisions();
            f.btnReceiveItems.Visible = true;
            f.btnSendItems.Visible = false;
            
        }

       

        private void sendItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemRequisitionsHome f = new frmItemRequisitionsHome();
            OpenFrm(f);
            f.requsitionType = "TR";
            f.ReqTypeComboBox.Text = "TR_R_Rec";
            f.FillTransferRequisions();
            f.btnSendItems.Visible = true;
            f.btnReceiveItems.Visible = false;
            
        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmItemRequisitionsHome f = new frmItemRequisitionsHome();
            OpenFrm(f);
            f.requsitionType = "TR";
            f.ReqTypeComboBox.Text = "TR_R_Rec";
            f.FillTransferRequisions();
            f.lblReqType.Visible = true;
            f.workingLocal = false;

        }

        private void lstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferHome f = new frmTransferHome();
            OpenFrm(f);
            f.FillByStore(clsVariables.sStore);
        }

      

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemRequisitionsHome f = new frmItemRequisitionsHome();
            OpenFrm(f);
            f.fillNonIssuedLocalRequisitions();
            f.btnIssueLocal.Visible = true;
            f.btnReceiveItems.Visible = false;
            f.btnSendItems.Visible = false;
            f.displayFor = 1;
            f.FillLocalRequistions(f.displayFor);
            

        }

        private void newRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemRequisitions f = new frmItemRequisitions();
            Program.mainFrm.OpenOverFrm(f);
            f.tooStrDetailAddnew_Click(null, null);
            f.requisitionTypeComboBox.Text = "TR";
        }

       
        private void dataImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataImport fdi = new frmDataImport();
            Program.mainFrm.OpenFrm(fdi);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        
        private void salesSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openReportForm(0);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsData.distributeData();
        }

        private void itemTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewItemDetails_Tx f = new FrmViewItemDetails_Tx();
            f.showstoreAll = false;
            Program.mainFrm.OpenFrm(f);
        }

        private void stockListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stockListToolStripMenuItem_Click(sender, e);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            stockListToolStripMenuItem_Click(sender, e);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNoteHome f = new frmGoodReceivedNoteHome();
            f.vType = "Import";
            OpenFrm(f);
        }

        private void localToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNoteHome f = new frmGoodReceivedNoteHome();
            f.vType = "Local";
            OpenFrm(f);
        }

        private void inOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNoteHome f = new frmGoodReceivedNoteHome();
            f.vType = "InOut";
            OpenFrm(f);
        }

        private void canibalizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNoteHome f = new frmGoodReceivedNoteHome();
            f.vType = "Canibalized";
            OpenFrm(f); 
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            fis.itemsIssuedBindingSource.AddNew();
            fis.vType = "Import";
            fis.StartNewIsssue();
        }

        private void localToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            fis.itemsIssuedBindingSource.AddNew();
            fis.vType = "Local";
            fis.StartNewIsssue();
        }

        private void inOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            fis.itemsIssuedBindingSource.AddNew();
            fis.vType = "InOut";
            fis.StartNewIsssue();
        }

        private void canibalizedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIssue fis = new frmIssue();
            Program.mainFrm.OpenFrm(fis);
            fis.itemsIssuedBindingSource.AddNew();
            fis.vType = "Canibalized";
            fis.StartNewIsssue();
        }

        private void importToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Import";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void localToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Local";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void inOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "InOut";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void canibalizedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Canibalized";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "All";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void allToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoodReceivedNoteHome f = new frmGoodReceivedNoteHome();
            f.vType = "All";
            OpenFrm(f);
            f.toolStripAddNew.Visible = false;
        }

        private void importToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Import";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void localToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Local";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void inOutToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "InOut";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void canibalizedToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "Canibalized";
            Program.mainFrm.OpenOverFrm(fish);
            fish.FillIssueData();
        }

        private void allToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmIssueHome fish = new frmIssueHome();
            fish.vType = "All";
            Program.mainFrm.OpenOverFrm(fish);
            fish.toolStripAddNew.Visible = false;
            fish.FillIssueData();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openReportForm(0);
        }

        
        #region Custom Settings

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        #endregion




        #endregion
    }

    #endregion


    #region ICustomTypeDescriptors

    #region TaskPaneDescriptor

    /// <summary>
    /// 
    /// </summary>


    #endregion





    #endregion


}