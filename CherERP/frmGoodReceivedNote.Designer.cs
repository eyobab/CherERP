namespace Belayab
{
    partial class frmGoodReceivedNote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label receivedDateLabel;
            System.Windows.Forms.Label supplierInoviceNumberLabel;
            System.Windows.Forms.Label deliveredByLabel;
            System.Windows.Forms.Label receivedByLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label receivingTypeLabel;
            System.Windows.Forms.Label referenceNumberLabel;
            System.Windows.Forms.Label preparedByLabel;
            System.Windows.Forms.Label approvedByLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodReceivedNote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemsReceivedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbReceived = new Belayab.BelayAbReceived();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.itemsReceivedDetailsBNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddAll = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DetailNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.DetailNavSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DetailNavDelete = new System.Windows.Forms.ToolStripButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.supplierListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet1 = new Belayab.BelayAbSSDataSet();
            this.deliveredByListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.receivedNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsReceivedDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefreshItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.partNumDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.measurmentUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierListTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.SupplierListTableAdapter();
            this.delivered_ByListTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.Delivered_ByListTableAdapter();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditSuppliers = new System.Windows.Forms.Button();
            this.itemsReceivedTableAdapter = new Belayab.BelayAbReceivedTableAdapters.ItemsReceivedTableAdapter();
            this.measurmentUnitsTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.MeasurmentUnitsTableAdapter();
            this.itemsReceivedDetailsTableAdapter = new Belayab.BelayAbReceivedTableAdapters.ItemsReceivedDetailsTableAdapter();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.lblWorkorders = new System.Windows.Forms.Label();
            this.ReceivedByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPurchaseReqNo = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.MainNavSave = new System.Windows.Forms.ToolStripButton();
            this.MainNavDelete = new System.Windows.Forms.ToolStripButton();
            this.MainNavePrint = new System.Windows.Forms.ToolStripButton();
            this.receivedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseReqNumberTextBox = new System.Windows.Forms.TextBox();
            this.receivedNumberTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.deliveredByComboBox = new System.Windows.Forms.ComboBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.receivingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.receivingRemarkTextBox = new System.Windows.Forms.TextBox();
            this.referenceNumberComboBox = new System.Windows.Forms.ComboBox();
            this.cboVouchureType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.preparedByComboBox = new System.Windows.Forms.ComboBox();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.btnCloseActivate = new System.Windows.Forms.Button();
            this.lCNumberTextBox = new System.Windows.Forms.TextBox();
            this.lblLCNo = new System.Windows.Forms.Label();
            this.supplierInoviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.itemsReceivedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            label3 = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            receivedDateLabel = new System.Windows.Forms.Label();
            supplierInoviceNumberLabel = new System.Windows.Forms.Label();
            deliveredByLabel = new System.Windows.Forms.Label();
            receivedByLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            receivingTypeLabel = new System.Windows.Forms.Label();
            referenceNumberLabel = new System.Windows.Forms.Label();
            preparedByLabel = new System.Windows.Forms.Label();
            approvedByLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBNav)).BeginInit();
            this.itemsReceivedDetailsBNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredByListBindingSource)).BeginInit();
            this.DetailsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingNavigator)).BeginInit();
            this.itemsReceivedBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(515, 541);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 20);
            label3.TabIndex = 36;
            label3.Text = "Total Cost:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(36, 579);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 56;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(36, 598);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(66, 13);
            updatedbyLabel.TabIndex = 57;
            updatedbyLabel.Text = "Updated By:";
            // 
            // receivedDateLabel
            // 
            receivedDateLabel.AutoSize = true;
            receivedDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receivedDateLabel.Location = new System.Drawing.Point(39, 119);
            receivedDateLabel.Name = "receivedDateLabel";
            receivedDateLabel.Size = new System.Drawing.Size(96, 13);
            receivedDateLabel.TabIndex = 27;
            receivedDateLabel.Text = "Received Date:";
            // 
            // supplierInoviceNumberLabel
            // 
            supplierInoviceNumberLabel.AutoSize = true;
            supplierInoviceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supplierInoviceNumberLabel.Location = new System.Drawing.Point(423, 65);
            supplierInoviceNumberLabel.Name = "supplierInoviceNumberLabel";
            supplierInoviceNumberLabel.Size = new System.Drawing.Size(103, 13);
            supplierInoviceNumberLabel.TabIndex = 19;
            supplierInoviceNumberLabel.Text = "Supplier Inv. No:";
            // 
            // deliveredByLabel
            // 
            deliveredByLabel.AutoSize = true;
            deliveredByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deliveredByLabel.Location = new System.Drawing.Point(441, 141);
            deliveredByLabel.Name = "deliveredByLabel";
            deliveredByLabel.Size = new System.Drawing.Size(83, 13);
            deliveredByLabel.TabIndex = 41;
            deliveredByLabel.Text = "Delivered By:";
            // 
            // receivedByLabel
            // 
            receivedByLabel.AutoSize = true;
            receivedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receivedByLabel.Location = new System.Drawing.Point(432, 117);
            receivedByLabel.Name = "receivedByLabel";
            receivedByLabel.Size = new System.Drawing.Size(82, 13);
            receivedByLabel.TabIndex = 40;
            receivedByLabel.Text = "Ch && Rec By:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storeIDLabel.Location = new System.Drawing.Point(93, 145);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(41, 13);
            storeIDLabel.TabIndex = 46;
            storeIDLabel.Text = "Store:";
            // 
            // receivingTypeLabel
            // 
            receivingTypeLabel.AutoSize = true;
            receivingTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            receivingTypeLabel.Location = new System.Drawing.Point(426, 17);
            receivingTypeLabel.Name = "receivingTypeLabel";
            receivingTypeLabel.Size = new System.Drawing.Size(100, 13);
            receivingTypeLabel.TabIndex = 49;
            receivingTypeLabel.Text = "Receiving Type:";
            // 
            // referenceNumberLabel
            // 
            referenceNumberLabel.AutoSize = true;
            referenceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            referenceNumberLabel.Location = new System.Drawing.Point(408, 41);
            referenceNumberLabel.Name = "referenceNumberLabel";
            referenceNumberLabel.Size = new System.Drawing.Size(117, 13);
            referenceNumberLabel.TabIndex = 50;
            referenceNumberLabel.Text = "Reference Number:";
            // 
            // preparedByLabel
            // 
            preparedByLabel.AutoSize = true;
            preparedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            preparedByLabel.Location = new System.Drawing.Point(442, 91);
            preparedByLabel.Name = "preparedByLabel";
            preparedByLabel.Size = new System.Drawing.Size(84, 13);
            preparedByLabel.TabIndex = 81;
            preparedByLabel.Text = "Price Chk By:";
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            approvedByLabel.Location = new System.Drawing.Point(794, 39);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(74, 13);
            approvedByLabel.TabIndex = 82;
            approvedByLabel.Text = "Store Chief:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(826, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 13);
            label4.TabIndex = 86;
            label4.Text = "Status";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(782, 145);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 13);
            statusLabel.TabIndex = 87;
            statusLabel.Text = "Status:";
            statusLabel.Visible = false;
            // 
            // itemsReceivedBindingSource
            // 
            this.itemsReceivedBindingSource.DataMember = "ItemsReceived";
            this.itemsReceivedBindingSource.DataSource = this.belayAbReceived;
            // 
            // belayAbReceived
            // 
            this.belayAbReceived.DataSetName = "BelayAbReceived";
            this.belayAbReceived.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesLstBindingSource
            // 
            this.employeesLstBindingSource.DataMember = "EmployeesLst";
            this.employeesLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsReceivedDetailsBNav
            // 
            this.itemsReceivedDetailsBNav.AddNewItem = null;
            this.itemsReceivedDetailsBNav.CountItem = this.bindingNavigatorCountItem1;
            this.itemsReceivedDetailsBNav.DeleteItem = null;
            this.itemsReceivedDetailsBNav.Dock = System.Windows.Forms.DockStyle.None;
            this.itemsReceivedDetailsBNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemsReceivedDetailsBNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAll,
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.DetailNavAddnew,
            this.DetailNavSave,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.DetailNavDelete});
            this.itemsReceivedDetailsBNav.Location = new System.Drawing.Point(7, 540);
            this.itemsReceivedDetailsBNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.itemsReceivedDetailsBNav.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.itemsReceivedDetailsBNav.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.itemsReceivedDetailsBNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.itemsReceivedDetailsBNav.Name = "itemsReceivedDetailsBNav";
            this.itemsReceivedDetailsBNav.PositionItem = this.bindingNavigatorPositionItem1;
            this.itemsReceivedDetailsBNav.Size = new System.Drawing.Size(403, 27);
            this.itemsReceivedDetailsBNav.TabIndex = 35;
            this.itemsReceivedDetailsBNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // btnAddAll
            // 
            this.btnAddAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(50, 24);
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // DetailNavAddnew
            // 
            this.DetailNavAddnew.Checked = true;
            this.DetailNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DetailNavAddnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetailNavAddnew.Enabled = false;
            this.DetailNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("DetailNavAddnew.Image")));
            this.DetailNavAddnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailNavAddnew.Name = "DetailNavAddnew";
            this.DetailNavAddnew.Size = new System.Drawing.Size(44, 24);
            this.DetailNavAddnew.Tag = "btn";
            this.DetailNavAddnew.Text = "+& Add";
            this.DetailNavAddnew.Click += new System.EventHandler(this.toolStrAddNew_Click);
            // 
            // DetailNavSave
            // 
            this.DetailNavSave.Checked = true;
            this.DetailNavSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DetailNavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetailNavSave.Enabled = false;
            this.DetailNavSave.Image = ((System.Drawing.Image)(resources.GetObject("DetailNavSave.Image")));
            this.DetailNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailNavSave.Name = "DetailNavSave";
            this.DetailNavSave.Size = new System.Drawing.Size(35, 24);
            this.DetailNavSave.Tag = "sbtn";
            this.DetailNavSave.Text = "&Save";
            this.DetailNavSave.Click += new System.EventHandler(this.toolStrSaveDetails_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // DetailNavDelete
            // 
            this.DetailNavDelete.Checked = true;
            this.DetailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DetailNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetailNavDelete.Enabled = false;
            this.DetailNavDelete.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.DetailNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("DetailNavDelete.Image")));
            this.DetailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailNavDelete.Name = "DetailNavDelete";
            this.DetailNavDelete.Size = new System.Drawing.Size(49, 24);
            this.DetailNavDelete.Tag = "btn";
            this.DetailNavDelete.Text = "- &Delete";
            this.DetailNavDelete.Click += new System.EventHandler(this.toolStrpDelete_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(605, 539);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(199, 24);
            this.txtTotal.TabIndex = 37;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // supplierListBindingSource
            // 
            this.supplierListBindingSource.DataMember = "SupplierList";
            this.supplierListBindingSource.DataSource = this.belayAbSSDataSet1;
            // 
            // belayAbSSDataSet1
            // 
            this.belayAbSSDataSet1.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveredByListBindingSource
            // 
            this.deliveredByListBindingSource.DataMember = "Delivered_ByList";
            this.deliveredByListBindingSource.DataSource = this.belayAbSSDataSet1;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.DetailsTab.Controls.Add(this.tabPage1);
            this.DetailsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTab.Location = new System.Drawing.Point(3, 210);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(1008, 328);
            this.DetailsTab.TabIndex = 45;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.DetailGridView);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Received Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.AutoGenerateColumns = false;
            this.DetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.receivedNumberDataGridViewTextBoxColumn,
            this.UnitCost,
            this.Qty,
            this.TotalCost,
            this.remarkDataGridViewTextBoxColumn});
            this.DetailGridView.DataSource = this.itemsReceivedDetailsBindingSource;
            this.DetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailGridView.Location = new System.Drawing.Point(3, 3);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.Size = new System.Drawing.Size(994, 291);
            this.DetailGridView.TabIndex = 0;
            this.DetailGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailGridView_CellValueChanged);
            this.DetailGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DetailGridView_DataError);
            this.DetailGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DetailGridView_EditingControlShowing);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.DisplayStyleForCurrentCellOnly = true;
            this.ItemID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemID.HeaderText = "Item";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemID.Width = 400;
            // 
            // receivedNumberDataGridViewTextBoxColumn
            // 
            this.receivedNumberDataGridViewTextBoxColumn.DataPropertyName = "ReceivedNumber";
            this.receivedNumberDataGridViewTextBoxColumn.HeaderText = "ReceivedNumber";
            this.receivedNumberDataGridViewTextBoxColumn.Name = "receivedNumberDataGridViewTextBoxColumn";
            this.receivedNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // UnitCost
            // 
            this.UnitCost.DataPropertyName = "UnitCost";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.UnitCost.DefaultCellStyle = dataGridViewCellStyle1;
            this.UnitCost.HeaderText = "Unit Cost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.Width = 120;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.TotalCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 130;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemsReceivedDetailsBindingSource
            // 
            this.itemsReceivedDetailsBindingSource.DataMember = "FK_ItemsReceivedDetails_ItemsReceived";
            this.itemsReceivedDetailsBindingSource.DataSource = this.itemsReceivedBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshItems,
            this.mnuEditItem,
            this.mnuAllItems});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 70);
            // 
            // mnuRefreshItems
            // 
            this.mnuRefreshItems.Name = "mnuRefreshItems";
            this.mnuRefreshItems.Size = new System.Drawing.Size(145, 22);
            this.mnuRefreshItems.Text = "Refresh Items";
            this.mnuRefreshItems.Click += new System.EventHandler(this.mnuRefreshItems_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(145, 22);
            this.mnuEditItem.Text = "Edit Item (s)";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // mnuAllItems
            // 
            this.mnuAllItems.Name = "mnuAllItems";
            this.mnuAllItems.Size = new System.Drawing.Size(145, 22);
            this.mnuAllItems.Text = "Find Item";
            this.mnuAllItems.Click += new System.EventHandler(this.mnuAllItems_Click);
            // 
            // partNumDescriptionBindingSource1
            // 
            this.partNumDescriptionBindingSource1.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource1.DataSource = this.belayAbSSDataSet1;
            // 
            // measurmentUnitsBindingSource
            // 
            this.measurmentUnitsBindingSource.DataMember = "MeasurmentUnits";
            this.measurmentUnitsBindingSource.DataSource = this.belayAbSSDataSet1;
            // 
            // supplierListTableAdapter
            // 
            this.supplierListTableAdapter.ClearBeforeFill = true;
            // 
            // delivered_ByListTableAdapter
            // 
            this.delivered_ByListTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditSuppliers
            // 
            this.btnEditSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSuppliers.Location = new System.Drawing.Point(306, 62);
            this.btnEditSuppliers.Name = "btnEditSuppliers";
            this.btnEditSuppliers.Size = new System.Drawing.Size(31, 21);
            this.btnEditSuppliers.TabIndex = 42;
            this.btnEditSuppliers.Text = "...";
            this.toolTip.SetToolTip(this.btnEditSuppliers, "Edit Suppliers");
            this.btnEditSuppliers.UseVisualStyleBackColor = true;
            this.btnEditSuppliers.Click += new System.EventHandler(this.btnEditSuppliers_Click);
            // 
            // itemsReceivedTableAdapter
            // 
            this.itemsReceivedTableAdapter.ClearBeforeFill = true;
            // 
            // measurmentUnitsTableAdapter
            // 
            this.measurmentUnitsTableAdapter.ClearBeforeFill = true;
            // 
            // itemsReceivedDetailsTableAdapter
            // 
            this.itemsReceivedDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "CreatedBy", true));
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(104, 579);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(223, 13);
            this.createdByTextBox.TabIndex = 58;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "UpdatedBy", true));
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(104, 599);
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(223, 13);
            this.updatedbyTextBox.TabIndex = 59;
            // 
            // lblWorkorders
            // 
            this.lblWorkorders.AutoSize = true;
            this.lblWorkorders.Location = new System.Drawing.Point(354, 579);
            this.lblWorkorders.Name = "lblWorkorders";
            this.lblWorkorders.Size = new System.Drawing.Size(13, 13);
            this.lblWorkorders.TabIndex = 60;
            this.lblWorkorders.Text = "  ";
            // 
            // ReceivedByComboBox
            // 
            this.ReceivedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReceivedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReceivedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsReceivedBindingSource, "ReceivedBy", true));
            this.ReceivedByComboBox.DataSource = this.employeesLstBindingSource;
            this.ReceivedByComboBox.DisplayMember = "EmployeeName";
            this.ReceivedByComboBox.Enabled = false;
            this.ReceivedByComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedByComboBox.FormattingEnabled = true;
            this.ReceivedByComboBox.IntegralHeight = false;
            this.ReceivedByComboBox.ItemHeight = 16;
            this.ReceivedByComboBox.Location = new System.Drawing.Point(527, 111);
            this.ReceivedByComboBox.Name = "ReceivedByComboBox";
            this.ReceivedByComboBox.Size = new System.Drawing.Size(173, 24);
            this.ReceivedByComboBox.TabIndex = 6;
            this.ReceivedByComboBox.ValueMember = "EmployeeId";
            this.ReceivedByComboBox.SelectedIndexChanged += new System.EventHandler(this.ReceivedByComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiving Number:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(22, 63);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(53, 13);
            this.lblSupplier.TabIndex = 1;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblPurchaseReqNo
            // 
            this.lblPurchaseReqNo.AutoSize = true;
            this.lblPurchaseReqNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseReqNo.Location = new System.Drawing.Point(782, 93);
            this.lblPurchaseReqNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchaseReqNo.Name = "lblPurchaseReqNo";
            this.lblPurchaseReqNo.Size = new System.Drawing.Size(115, 13);
            this.lblPurchaseReqNo.TabIndex = 5;
            this.lblPurchaseReqNo.Text = "Purchase Req. No.";
            this.lblPurchaseReqNo.UseWaitCursor = true;
            this.lblPurchaseReqNo.Visible = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(632, 3);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(635, 31);
            this.miniToolStrip.TabIndex = 13;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // MainNavPosition
            // 
            this.MainNavPosition.AccessibleName = "Position";
            this.MainNavPosition.AutoSize = false;
            this.MainNavPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainNavPosition.Name = "MainNavPosition";
            this.MainNavPosition.ReadOnly = true;
            this.MainNavPosition.Size = new System.Drawing.Size(50, 23);
            this.MainNavPosition.Text = "0";
            this.MainNavPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Enabled = false;
            this.MainNavAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(98, 24);
            this.MainNavAddnew.Tag = "btn";
            this.MainNavAddnew.Text = "Add New";
            this.MainNavAddnew.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // MainNavSave
            // 
            this.MainNavSave.Enabled = false;
            this.MainNavSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavSave.Image = ((System.Drawing.Image)(resources.GetObject("MainNavSave.Image")));
            this.MainNavSave.Name = "MainNavSave";
            this.MainNavSave.Size = new System.Drawing.Size(109, 24);
            this.MainNavSave.Tag = "btn";
            this.MainNavSave.Text = "Sa&ve Data";
            this.MainNavSave.Click += new System.EventHandler(this.itemsReceivedBindingNavigatorSaveItem_Click);
            // 
            // MainNavDelete
            // 
            this.MainNavDelete.Enabled = false;
            this.MainNavDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("MainNavDelete.Image")));
            this.MainNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavDelete.Name = "MainNavDelete";
            this.MainNavDelete.Size = new System.Drawing.Size(80, 24);
            this.MainNavDelete.Tag = "btn";
            this.MainNavDelete.Text = "Del&ete";
            this.MainNavDelete.Click += new System.EventHandler(this.DeleteWrap_Click);
            // 
            // MainNavePrint
            // 
            this.MainNavePrint.Enabled = false;
            this.MainNavePrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavePrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavePrint.Name = "MainNavePrint";
            this.MainNavePrint.Size = new System.Drawing.Size(47, 24);
            this.MainNavePrint.Tag = "btn";
            this.MainNavePrint.Text = "Print";
            this.MainNavePrint.Click += new System.EventHandler(this.toolStrGRNPrint_Click);
            // 
            // receivedDateDateTimePicker
            // 
            this.receivedDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.receivedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsReceivedBindingSource, "ReceivedDate", true));
            this.receivedDateDateTimePicker.Enabled = false;
            this.receivedDateDateTimePicker.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receivedDateDateTimePicker.Location = new System.Drawing.Point(141, 115);
            this.receivedDateDateTimePicker.Name = "receivedDateDateTimePicker";
            this.receivedDateDateTimePicker.Size = new System.Drawing.Size(162, 21);
            this.receivedDateDateTimePicker.TabIndex = 3;
            this.receivedDateDateTimePicker.Tag = "btn";
            // 
            // purchaseReqNumberTextBox
            // 
            this.purchaseReqNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "PurchaseReqNumber", true));
            this.purchaseReqNumberTextBox.Enabled = false;
            this.purchaseReqNumberTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseReqNumberTextBox.Location = new System.Drawing.Point(898, 90);
            this.purchaseReqNumberTextBox.Name = "purchaseReqNumberTextBox";
            this.purchaseReqNumberTextBox.Size = new System.Drawing.Size(123, 21);
            this.purchaseReqNumberTextBox.TabIndex = 4;
            this.purchaseReqNumberTextBox.UseWaitCursor = true;
            this.purchaseReqNumberTextBox.Visible = false;
            // 
            // receivedNumberTextBox
            // 
            this.receivedNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "ReceivedNumber", true));
            this.receivedNumberTextBox.Enabled = false;
            this.receivedNumberTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedNumberTextBox.Location = new System.Drawing.Point(141, 89);
            this.receivedNumberTextBox.Name = "receivedNumberTextBox";
            this.receivedNumberTextBox.Size = new System.Drawing.Size(162, 21);
            this.receivedNumberTextBox.TabIndex = 2;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.supplierIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsReceivedBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.Enabled = false;
            this.supplierIdComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(80, 61);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(225, 24);
            this.supplierIdComboBox.TabIndex = 0;
            this.supplierIdComboBox.ValueMember = "SupplierID";
            // 
            // deliveredByComboBox
            // 
            this.deliveredByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.deliveredByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.deliveredByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "DeliveredBy", true));
            this.deliveredByComboBox.DataSource = this.deliveredByListBindingSource;
            this.deliveredByComboBox.DisplayMember = "DeliveredBy";
            this.deliveredByComboBox.Enabled = false;
            this.deliveredByComboBox.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveredByComboBox.FormattingEnabled = true;
            this.deliveredByComboBox.Location = new System.Drawing.Point(527, 138);
            this.deliveredByComboBox.Name = "deliveredByComboBox";
            this.deliveredByComboBox.Size = new System.Drawing.Size(174, 24);
            this.deliveredByComboBox.TabIndex = 7;
            this.deliveredByComboBox.ValueMember = "DeliveredBy";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto.Location = new System.Drawing.Point(304, 92);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(56, 17);
            this.chkAuto.TabIndex = 45;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "Status", true));
            this.statusComboBox.Enabled = false;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "New",
            "Verified",
            "Approved",
            "Closed"});
            this.statusComboBox.Location = new System.Drawing.Point(870, 11);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 46;
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsReceivedBindingSource, "StoreID", true));
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(140, 141);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(164, 21);
            this.storeIDComboBox.TabIndex = 47;
            this.storeIDComboBox.ValueMember = "StoreID";
            // 
            // receivingTypeComboBox
            // 
            this.receivingTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "ReceivingType", true));
            this.receivingTypeComboBox.FormattingEnabled = true;
            this.receivingTypeComboBox.Items.AddRange(new object[] {
            "PUR",
            "REC",
            "RETI",
            "RETT"});
            this.receivingTypeComboBox.Location = new System.Drawing.Point(529, 14);
            this.receivingTypeComboBox.Name = "receivingTypeComboBox";
            this.receivingTypeComboBox.Size = new System.Drawing.Size(129, 21);
            this.receivingTypeComboBox.TabIndex = 50;
            this.receivingTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.receivingTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Remarks:";
            // 
            // receivingRemarkTextBox
            // 
            this.receivingRemarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "ReceivingRemark", true));
            this.receivingRemarkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivingRemarkTextBox.Location = new System.Drawing.Point(619, 174);
            this.receivingRemarkTextBox.Multiline = true;
            this.receivingRemarkTextBox.Name = "receivingRemarkTextBox";
            this.receivingRemarkTextBox.Size = new System.Drawing.Size(407, 28);
            this.receivingRemarkTextBox.TabIndex = 49;
            // 
            // referenceNumberComboBox
            // 
            this.referenceNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "ReferenceNumber", true));
            this.referenceNumberComboBox.DisplayMember = "PerchaseReqNo";
            this.referenceNumberComboBox.FormattingEnabled = true;
            this.referenceNumberComboBox.Location = new System.Drawing.Point(529, 37);
            this.referenceNumberComboBox.Name = "referenceNumberComboBox";
            this.referenceNumberComboBox.Size = new System.Drawing.Size(151, 21);
            this.referenceNumberComboBox.TabIndex = 51;
            this.referenceNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.referenceNumberComboBox_SelectedIndexChanged);
            // 
            // cboVouchureType
            // 
            this.cboVouchureType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "VoucherType", true));
            this.cboVouchureType.Enabled = false;
            this.cboVouchureType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVouchureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVouchureType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cboVouchureType.FormattingEnabled = true;
            this.cboVouchureType.Items.AddRange(new object[] {
            "Import",
            "Local",
            "InOut",
            "Cannibalized",
            "All"});
            this.cboVouchureType.Location = new System.Drawing.Point(120, 20);
            this.cboVouchureType.Name = "cboVouchureType";
            this.cboVouchureType.Size = new System.Drawing.Size(164, 23);
            this.cboVouchureType.TabIndex = 80;
            this.cboVouchureType.Text = "Import";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(28, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Voucher Type";
            // 
            // preparedByComboBox
            // 
            this.preparedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "PreparedBy", true));
            this.preparedByComboBox.DisplayMember = "EmployeeName";
            this.preparedByComboBox.FormattingEnabled = true;
            this.preparedByComboBox.Location = new System.Drawing.Point(527, 86);
            this.preparedByComboBox.Name = "preparedByComboBox";
            this.preparedByComboBox.Size = new System.Drawing.Size(165, 21);
            this.preparedByComboBox.TabIndex = 82;
            this.preparedByComboBox.ValueMember = "EmployeeName";
            // 
            // approvedByComboBox
            // 
            this.approvedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "ApprovedBy", true));
            this.approvedByComboBox.DisplayMember = "EmployeeName";
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(870, 36);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(166, 21);
            this.approvedByComboBox.TabIndex = 83;
            this.approvedByComboBox.ValueMember = "EmployeeName";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.groupBox1.Controls.Add(this.StatusTextBox);
            this.groupBox1.Controls.Add(this.btnCloseActivate);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.lCNumberTextBox);
            this.groupBox1.Controls.Add(this.lblLCNo);
            this.groupBox1.Controls.Add(approvedByLabel);
            this.groupBox1.Controls.Add(this.approvedByComboBox);
            this.groupBox1.Controls.Add(preparedByLabel);
            this.groupBox1.Controls.Add(this.preparedByComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboVouchureType);
            this.groupBox1.Controls.Add(referenceNumberLabel);
            this.groupBox1.Controls.Add(this.referenceNumberComboBox);
            this.groupBox1.Controls.Add(receivingTypeLabel);
            this.groupBox1.Controls.Add(this.receivingRemarkTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.receivingTypeComboBox);
            this.groupBox1.Controls.Add(storeIDLabel);
            this.groupBox1.Controls.Add(this.storeIDComboBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.chkAuto);
            this.groupBox1.Controls.Add(this.btnEditSuppliers);
            this.groupBox1.Controls.Add(this.supplierInoviceNumberTextBox);
            this.groupBox1.Controls.Add(receivedByLabel);
            this.groupBox1.Controls.Add(deliveredByLabel);
            this.groupBox1.Controls.Add(this.deliveredByComboBox);
            this.groupBox1.Controls.Add(this.supplierIdComboBox);
            this.groupBox1.Controls.Add(this.receivedNumberTextBox);
            this.groupBox1.Controls.Add(supplierInoviceNumberLabel);
            this.groupBox1.Controls.Add(this.purchaseReqNumberTextBox);
            this.groupBox1.Controls.Add(receivedDateLabel);
            this.groupBox1.Controls.Add(this.receivedDateDateTimePicker);
            this.groupBox1.Controls.Add(this.itemsReceivedBindingNavigator);
            this.groupBox1.Controls.Add(this.lblPurchaseReqNo);
            this.groupBox1.Controls.Add(this.lblSupplier);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReceivedByComboBox);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1099, 223);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Receiving Information";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "Status", true));
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(837, 139);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(126, 21);
            this.StatusTextBox.TabIndex = 89;
            this.StatusTextBox.Visible = false;
            // 
            // btnCloseActivate
            // 
            this.btnCloseActivate.Location = new System.Drawing.Point(964, 136);
            this.btnCloseActivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseActivate.Name = "btnCloseActivate";
            this.btnCloseActivate.Size = new System.Drawing.Size(56, 24);
            this.btnCloseActivate.TabIndex = 88;
            this.btnCloseActivate.Text = "Close";
            this.btnCloseActivate.UseVisualStyleBackColor = true;
            this.btnCloseActivate.Visible = false;
            // 
            // lCNumberTextBox
            // 
            this.lCNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "LCNumber", true));
            this.lCNumberTextBox.Enabled = false;
            this.lCNumberTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCNumberTextBox.Location = new System.Drawing.Point(871, 63);
            this.lCNumberTextBox.Name = "lCNumberTextBox";
            this.lCNumberTextBox.Size = new System.Drawing.Size(165, 21);
            this.lCNumberTextBox.TabIndex = 84;
            // 
            // lblLCNo
            // 
            this.lblLCNo.AutoSize = true;
            this.lblLCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCNo.Location = new System.Drawing.Point(820, 68);
            this.lblLCNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLCNo.Name = "lblLCNo";
            this.lblLCNo.Size = new System.Drawing.Size(52, 13);
            this.lblLCNo.TabIndex = 85;
            this.lblLCNo.Text = "L/C No.";
            // 
            // supplierInoviceNumberTextBox
            // 
            this.supplierInoviceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsReceivedBindingSource, "SupplierInoviceNumber", true));
            this.supplierInoviceNumberTextBox.Enabled = false;
            this.supplierInoviceNumberTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierInoviceNumberTextBox.Location = new System.Drawing.Point(529, 62);
            this.supplierInoviceNumberTextBox.Name = "supplierInoviceNumberTextBox";
            this.supplierInoviceNumberTextBox.Size = new System.Drawing.Size(142, 21);
            this.supplierInoviceNumberTextBox.TabIndex = 1;
            // 
            // itemsReceivedBindingNavigator
            // 
            this.itemsReceivedBindingNavigator.AddNewItem = null;
            this.itemsReceivedBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.itemsReceivedBindingNavigator.BindingSource = this.itemsReceivedBindingSource;
            this.itemsReceivedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsReceivedBindingNavigator.DeleteItem = null;
            this.itemsReceivedBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.itemsReceivedBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemsReceivedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.MainNavPosition,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.MainNavAddnew,
            this.MainNavSave,
            this.MainNavDelete,
            this.MainNavePrint});
            this.itemsReceivedBindingNavigator.Location = new System.Drawing.Point(1, 174);
            this.itemsReceivedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsReceivedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsReceivedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsReceivedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsReceivedBindingNavigator.Name = "itemsReceivedBindingNavigator";
            this.itemsReceivedBindingNavigator.PositionItem = this.MainNavPosition;
            this.itemsReceivedBindingNavigator.Size = new System.Drawing.Size(547, 27);
            this.itemsReceivedBindingNavigator.TabIndex = 13;
            this.itemsReceivedBindingNavigator.Text = "bindingNavigator1";
            // 
            // frmGoodReceivedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(200)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.lblWorkorders);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(label3);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(this.itemsReceivedDetailsBNav);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.DetailsTab);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGoodReceivedNote";
            this.Text = "Goods  Receiving";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmGoodReceivedNote_Activated);
            this.Load += new System.EventHandler(this.frmGoodReceivedNote_Load);
            this.Shown += new System.EventHandler(this.frmGoodReceivedNote_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGoodReceivedNote_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBNav)).EndInit();
            this.itemsReceivedDetailsBNav.ResumeLayout(false);
            this.itemsReceivedDetailsBNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveredByListBindingSource)).EndInit();
            this.DetailsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDetailsBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingNavigator)).EndInit();
            this.itemsReceivedBindingNavigator.ResumeLayout(false);
            this.itemsReceivedBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator itemsReceivedDetailsBNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TextBox txtTotal;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.ToolStripButton DetailNavSave;
        public System.Windows.Forms.ToolStripButton DetailNavDelete;
        public System.Windows.Forms.ToolStripButton DetailNavAddnew;
        private System.Windows.Forms.BindingSource supplierListBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.SupplierListTableAdapter supplierListTableAdapter;
        private Belayab.BelayAbSSDataSetTableAdapters.Delivered_ByListTableAdapter delivered_ByListTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
        private BelayAbReceived belayAbReceived;
        private Belayab.BelayAbReceivedTableAdapters.ItemsReceivedTableAdapter itemsReceivedTableAdapter;
        private BelayAbSSDataSet belayAbSSDataSet1;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource1;
        private System.Windows.Forms.BindingSource measurmentUnitsBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.MeasurmentUnitsTableAdapter measurmentUnitsTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshItems;
        private System.Windows.Forms.ToolStripMenuItem mnuAllItems;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView DetailGridView;
        private System.Windows.Forms.BindingSource itemsReceivedDetailsBindingSource;
        private Belayab.BelayAbReceivedTableAdapters.ItemsReceivedDetailsTableAdapter itemsReceivedDetailsTableAdapter;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        public System.Windows.Forms.BindingSource itemsReceivedBindingSource;
        private System.Windows.Forms.ToolStripButton btnAddAll;
        private System.Windows.Forms.BindingSource deliveredByListBindingSource;
        private System.Windows.Forms.Label lblWorkorders;
        private System.Windows.Forms.ComboBox ReceivedByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPurchaseReqNo;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox MainNavPosition;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.ToolStripButton MainNavAddnew;
        public System.Windows.Forms.ToolStripButton MainNavSave;
        public System.Windows.Forms.ToolStripButton MainNavDelete;
        public System.Windows.Forms.ToolStripButton MainNavePrint;
        private System.Windows.Forms.DateTimePicker receivedDateDateTimePicker;
        private System.Windows.Forms.TextBox purchaseReqNumberTextBox;
        private System.Windows.Forms.TextBox receivedNumberTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.ComboBox deliveredByComboBox;
        private System.Windows.Forms.Button btnEditSuppliers;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.ComboBox receivingTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox receivingRemarkTextBox;
        private System.Windows.Forms.ComboBox referenceNumberComboBox;
        public System.Windows.Forms.ComboBox cboVouchureType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox preparedByComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lCNumberTextBox;
        private System.Windows.Forms.Label lblLCNo;
        private System.Windows.Forms.TextBox supplierInoviceNumberTextBox;
        private System.Windows.Forms.BindingNavigator itemsReceivedBindingNavigator;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button btnCloseActivate;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}