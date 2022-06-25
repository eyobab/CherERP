namespace Belayab
{
    partial class frmPurchaseRq
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
            System.Windows.Forms.Label perchaseReqNoLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label refrerenceLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label requestedByLabel;
            System.Windows.Forms.Label approvedByLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label requestTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseRq));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.purchaseRequisitionDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseRequisitionDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRequisitionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter();
            this.purchaseRequisitionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.btnAddAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.purchaseRequisitionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.perchaseReqNoTextBox = new System.Windows.Forms.TextBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrerenceComboBox = new System.Windows.Forms.ComboBox();
            this.mRequisitionNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.requestedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.purchaseRequisitionDetailsTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PurchaseRequisitionDetailsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.supplierListTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.SupplierListTableAdapter();
            this.belayAbSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_RequisitionNumbersTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.m_RequisitionNumbersTableAdapter();
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.requestTypeComboBox = new System.Windows.Forms.ComboBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.btnCloseActivate = new System.Windows.Forms.Button();
            this.WorkOrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            perchaseReqNoLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            refrerenceLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            requestedByLabel = new System.Windows.Forms.Label();
            approvedByLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            requestTypeLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).BeginInit();
            this.purchaseRequisitionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRequisitionNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // perchaseReqNoLabel
            // 
            perchaseReqNoLabel.AutoSize = true;
            perchaseReqNoLabel.Location = new System.Drawing.Point(42, 22);
            perchaseReqNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            perchaseReqNoLabel.Name = "perchaseReqNoLabel";
            perchaseReqNoLabel.Size = new System.Drawing.Size(135, 17);
            perchaseReqNoLabel.TabIndex = 2;
            perchaseReqNoLabel.Text = "Perchase Order No:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Location = new System.Drawing.Point(113, 90);
            supplierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(64, 17);
            supplierLabel.TabIndex = 4;
            supplierLabel.Text = "Supplier:";
            // 
            // refrerenceLabel
            // 
            refrerenceLabel.AutoSize = true;
            refrerenceLabel.Location = new System.Drawing.Point(94, 123);
            refrerenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            refrerenceLabel.Name = "refrerenceLabel";
            refrerenceLabel.Size = new System.Drawing.Size(83, 17);
            refrerenceLabel.TabIndex = 6;
            refrerenceLabel.Text = "Refrerence:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(94, 186);
            orderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(83, 17);
            orderDateLabel.TabIndex = 8;
            orderDateLabel.Text = "Order Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(691, 60);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(48, 17);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(604, 190);
            remarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(68, 17);
            remarksLabel.TabIndex = 12;
            remarksLabel.Text = "Remarks:";
            // 
            // requestedByLabel
            // 
            requestedByLabel.AutoSize = true;
            requestedByLabel.Location = new System.Drawing.Point(638, 91);
            requestedByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            requestedByLabel.Name = "requestedByLabel";
            requestedByLabel.Size = new System.Drawing.Size(101, 17);
            requestedByLabel.TabIndex = 14;
            requestedByLabel.Text = "Requested By:";
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.Location = new System.Drawing.Point(646, 125);
            approvedByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(93, 17);
            approvedByLabel.TabIndex = 16;
            approvedByLabel.Text = "Approved By:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(693, 23);
            storeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(46, 17);
            storeIDLabel.TabIndex = 18;
            storeIDLabel.Text = "Store:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(28, 631);
            createdByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(82, 17);
            createdByLabel.TabIndex = 64;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(26, 657);
            updatedbyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(86, 17);
            updatedbyLabel.TabIndex = 65;
            updatedbyLabel.Text = "Updated By:";
            // 
            // requestTypeLabel
            // 
            requestTypeLabel.AutoSize = true;
            requestTypeLabel.Location = new System.Drawing.Point(76, 59);
            requestTypeLabel.Name = "requestTypeLabel";
            requestTypeLabel.Size = new System.Drawing.Size(101, 17);
            requestTypeLabel.TabIndex = 92;
            requestTypeLabel.Text = "Request Type:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(16, 257);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.purchaseRequisitionDetailsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1024, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parchase Requistion Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // purchaseRequisitionDetailsDataGridView
            // 
            this.purchaseRequisitionDetailsDataGridView.AllowUserToAddRows = false;
            this.purchaseRequisitionDetailsDataGridView.AllowUserToDeleteRows = false;
            this.purchaseRequisitionDetailsDataGridView.AutoGenerateColumns = false;
            this.purchaseRequisitionDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseRequisitionDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.dataGridViewTextBoxColumn1,
            this.Qty,
            this.Units,
            this.InStock});
            this.purchaseRequisitionDetailsDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.purchaseRequisitionDetailsDataGridView.DataSource = this.purchaseRequisitionDetailsBindingSource;
            this.purchaseRequisitionDetailsDataGridView.Location = new System.Drawing.Point(4, 7);
            this.purchaseRequisitionDetailsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.purchaseRequisitionDetailsDataGridView.Name = "purchaseRequisitionDetailsDataGridView";
            this.purchaseRequisitionDetailsDataGridView.Size = new System.Drawing.Size(1016, 297);
            this.purchaseRequisitionDetailsDataGridView.TabIndex = 0;
            this.purchaseRequisitionDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseRequisitionDetailsDataGridView_CellValueChanged);
            this.purchaseRequisitionDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.purchaseRequisitionDetailsDataGridView_DataError);
            this.purchaseRequisitionDetailsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.purchaseRequisitionDetailsDataGridView_EditingControlShowing);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.DataSource = this.partNumDescriptionBindingSource;
            this.ItemID.DisplayMember = "Description";
            this.ItemID.HeaderText = "Item";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemID.ValueMember = "ItemID";
            this.ItemID.Width = 350;
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PerchaseReqNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "PerchaseReqNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // InStock
            // 
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBalancesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 28);
            // 
            // itemBalancesToolStripMenuItem
            // 
            this.itemBalancesToolStripMenuItem.Name = "itemBalancesToolStripMenuItem";
            this.itemBalancesToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.itemBalancesToolStripMenuItem.Text = "Item Balances";
            this.itemBalancesToolStripMenuItem.Click += new System.EventHandler(this.itemBalancesToolStripMenuItem_Click);
            // 
            // purchaseRequisitionDetailsBindingSource
            // 
            this.purchaseRequisitionDetailsBindingSource.DataMember = "FK_PurchaseOrderDetails_PurchaseOrders";
            this.purchaseRequisitionDetailsBindingSource.DataSource = this.purchaseRequisitionBindingSource;
            // 
            // purchaseRequisitionBindingSource
            // 
            this.purchaseRequisitionBindingSource.DataMember = "PurchaseRequisition";
            this.purchaseRequisitionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // purchaseRequisitionTableAdapter
            // 
            this.purchaseRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseRequisitionBindingNavigator
            // 
            this.purchaseRequisitionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseRequisitionBindingNavigator.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.purchaseRequisitionBindingNavigator.BindingSource = this.purchaseRequisitionDetailsBindingSource;
            this.purchaseRequisitionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseRequisitionBindingNavigator.DeleteItem = null;
            this.purchaseRequisitionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.purchaseRequisitionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.purchaseRequisitionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAll,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.purchaseRequisitionBindingNavigatorSaveItem,
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem});
            this.purchaseRequisitionBindingNavigator.Location = new System.Drawing.Point(21, 587);
            this.purchaseRequisitionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseRequisitionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseRequisitionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseRequisitionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseRequisitionBindingNavigator.Name = "purchaseRequisitionBindingNavigator";
            this.purchaseRequisitionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseRequisitionBindingNavigator.Size = new System.Drawing.Size(482, 27);
            this.purchaseRequisitionBindingNavigator.TabIndex = 1;
            this.purchaseRequisitionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(72, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // btnAddAll
            // 
            this.btnAddAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(59, 24);
            this.btnAddAll.Text = "AddAll";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "Move first";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // purchaseRequisitionBindingNavigatorSaveItem
            // 
            this.purchaseRequisitionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.purchaseRequisitionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseRequisitionBindingNavigatorSaveItem.Image")));
            this.purchaseRequisitionBindingNavigatorSaveItem.Name = "purchaseRequisitionBindingNavigatorSaveItem";
            this.purchaseRequisitionBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 24);
            this.purchaseRequisitionBindingNavigatorSaveItem.Text = "Save";
            this.purchaseRequisitionBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseRequisitionBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(57, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // perchaseReqNoTextBox
            // 
            this.perchaseReqNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "PerchaseReqNo", true));
            this.perchaseReqNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perchaseReqNoTextBox.Location = new System.Drawing.Point(182, 18);
            this.perchaseReqNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.perchaseReqNoTextBox.Name = "perchaseReqNoTextBox";
            this.perchaseReqNoTextBox.Size = new System.Drawing.Size(196, 24);
            this.perchaseReqNoTextBox.TabIndex = 3;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseRequisitionBindingSource, "Supplier", true));
            this.supplierComboBox.DisplayMember = "SupplierName";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(182, 87);
            this.supplierComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(298, 24);
            this.supplierComboBox.TabIndex = 5;
            this.supplierComboBox.ValueMember = "SupplierId";
            // 
            // supplierListBindingSource
            // 
            this.supplierListBindingSource.DataMember = "SupplierList";
            this.supplierListBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // refrerenceComboBox
            // 
            this.refrerenceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.refrerenceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.refrerenceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Refrerence", true));
            this.refrerenceComboBox.FormattingEnabled = true;
            this.refrerenceComboBox.Location = new System.Drawing.Point(182, 119);
            this.refrerenceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.refrerenceComboBox.Name = "refrerenceComboBox";
            this.refrerenceComboBox.Size = new System.Drawing.Size(220, 24);
            this.refrerenceComboBox.TabIndex = 7;
            this.refrerenceComboBox.SelectedValueChanged += new System.EventHandler(this.refrerenceComboBox_SelectedValueChanged);
            // 
            // mRequisitionNumbersBindingSource
            // 
            this.mRequisitionNumbersBindingSource.DataMember = "m_RequisitionNumbers";
            this.mRequisitionNumbersBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseRequisitionBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(184, 181);
            this.orderDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(162, 22);
            this.orderDateDateTimePicker.TabIndex = 9;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Status", true));
            this.statusComboBox.DisplayMember = "State";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(748, 55);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(186, 24);
            this.statusComboBox.TabIndex = 11;
            this.statusComboBox.ValueMember = "State";
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(677, 183);
            this.remarksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(411, 62);
            this.remarksTextBox.TabIndex = 13;
            // 
            // requestedByComboBox
            // 
            this.requestedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "RequestedBy", true));
            this.requestedByComboBox.DataSource = this.employeesLstBindingSource;
            this.requestedByComboBox.DisplayMember = "EmployeeName";
            this.requestedByComboBox.FormattingEnabled = true;
            this.requestedByComboBox.Location = new System.Drawing.Point(748, 88);
            this.requestedByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.requestedByComboBox.Name = "requestedByComboBox";
            this.requestedByComboBox.Size = new System.Drawing.Size(243, 24);
            this.requestedByComboBox.TabIndex = 15;
            this.requestedByComboBox.ValueMember = "EmployeeId";
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
            // approvedByComboBox
            // 
            this.approvedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "ApprovedBy", true));
            this.approvedByComboBox.DisplayMember = "EmployeeName";
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(748, 121);
            this.approvedByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(243, 24);
            this.approvedByComboBox.TabIndex = 17;
            this.approvedByComboBox.ValueMember = "EmployeeId";
            // 
            // purchaseRequisitionDetailsTableAdapter
            // 
            this.purchaseRequisitionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bindingNavigator1.BindingSource = this.purchaseRequisitionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripSeparator,
            this.printToolStripButton});
            this.bindingNavigator1.Location = new System.Drawing.Point(11, 216);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(525, 32);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(49, 29);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 26);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 29);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(90, 29);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(55, 29);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(70, 29);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.printToolStripButton.Text = "&Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // supplierListTableAdapter
            // 
            this.supplierListTableAdapter.ClearBeforeFill = true;
            // 
            // belayAbSSDataSetBindingSource
            // 
            this.belayAbSSDataSetBindingSource.DataSource = this.belayAbSSDataSet;
            this.belayAbSSDataSetBindingSource.Position = 0;
            // 
            // m_RequisitionNumbersTableAdapter
            // 
            this.m_RequisitionNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.chkAuto);
            this.groupBox1.Controls.Add(requestTypeLabel);
            this.groupBox1.Controls.Add(this.requestTypeComboBox);
            this.groupBox1.Controls.Add(this.StatusTextBox);
            this.groupBox1.Controls.Add(this.btnCloseActivate);
            this.groupBox1.Controls.Add(this.remarksTextBox);
            this.groupBox1.Controls.Add(this.WorkOrderNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(storeIDLabel);
            this.groupBox1.Controls.Add(this.storeIDComboBox);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(perchaseReqNoLabel);
            this.groupBox1.Controls.Add(this.perchaseReqNoTextBox);
            this.groupBox1.Controls.Add(supplierLabel);
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(refrerenceLabel);
            this.groupBox1.Controls.Add(this.refrerenceComboBox);
            this.groupBox1.Controls.Add(orderDateLabel);
            this.groupBox1.Controls.Add(this.orderDateDateTimePicker);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(remarksLabel);
            this.groupBox1.Controls.Add(requestedByLabel);
            this.groupBox1.Controls.Add(this.requestedByComboBox);
            this.groupBox1.Controls.Add(approvedByLabel);
            this.groupBox1.Controls.Add(this.approvedByComboBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1130, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto.Location = new System.Drawing.Point(386, 19);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(4);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(68, 21);
            this.chkAuto.TabIndex = 94;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            // 
            // requestTypeComboBox
            // 
            this.requestTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "RequestType", true));
            this.requestTypeComboBox.FormattingEnabled = true;
            this.requestTypeComboBox.Items.AddRange(new object[] {
            "Purchase Order",
            "Proforma Request"});
            this.requestTypeComboBox.Location = new System.Drawing.Point(184, 56);
            this.requestTypeComboBox.Name = "requestTypeComboBox";
            this.requestTypeComboBox.Size = new System.Drawing.Size(205, 24);
            this.requestTypeComboBox.TabIndex = 93;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(866, 145);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(167, 25);
            this.StatusTextBox.TabIndex = 92;
            this.StatusTextBox.Visible = false;
            // 
            // btnCloseActivate
            // 
            this.btnCloseActivate.Location = new System.Drawing.Point(1035, 142);
            this.btnCloseActivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseActivate.Name = "btnCloseActivate";
            this.btnCloseActivate.Size = new System.Drawing.Size(75, 30);
            this.btnCloseActivate.TabIndex = 91;
            this.btnCloseActivate.Text = "Close";
            this.btnCloseActivate.UseVisualStyleBackColor = true;
            this.btnCloseActivate.Visible = false;
            // 
            // WorkOrderNumberTextBox
            // 
            this.WorkOrderNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkOrderNumberTextBox.Location = new System.Drawing.Point(182, 150);
            this.WorkOrderNumberTextBox.Name = "WorkOrderNumberTextBox";
            this.WorkOrderNumberTextBox.ReadOnly = true;
            this.WorkOrderNumberTextBox.Size = new System.Drawing.Size(196, 22);
            this.WorkOrderNumberTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Work Order No:";
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.purchaseRequisitionBindingSource, "StoreID", true));
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.Enabled = false;
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(747, 19);
            this.storeIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(244, 24);
            this.storeIDComboBox.TabIndex = 19;
            this.storeIDComboBox.ValueMember = "StoreId";
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.Cornsilk;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "CreatedBy", true));
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(117, 629);
            this.createdByTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.createdByTextBox.Multiline = true;
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(417, 23);
            this.createdByTextBox.TabIndex = 66;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LightGray;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "UpdatedBy", true));
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(118, 657);
            this.updatedbyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updatedbyTextBox.Multiline = true;
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(416, 21);
            this.updatedbyTextBox.TabIndex = 67;
            // 
            // frmPurchaseRq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 680);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.purchaseRequisitionBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPurchaseRq";
            this.Text = "Purchase Requision / Order";
            this.Load += new System.EventHandler(this.frmPurchaseRq_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).EndInit();
            this.purchaseRequisitionBindingNavigator.ResumeLayout(false);
            this.purchaseRequisitionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRequisitionNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource purchaseRequisitionBindingSource;
        private BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter purchaseRequisitionTableAdapter;
        private System.Windows.Forms.BindingNavigator purchaseRequisitionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton purchaseRequisitionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox perchaseReqNoTextBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox refrerenceComboBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.ComboBox requestedByComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.BindingSource purchaseRequisitionDetailsBindingSource;
        private BelayAbSSDataSetTableAdapters.PurchaseRequisitionDetailsTableAdapter purchaseRequisitionDetailsTableAdapter;
        private System.Windows.Forms.DataGridView purchaseRequisitionDetailsDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.BindingSource supplierListBindingSource;
        private BelayAbSSDataSetTableAdapters.SupplierListTableAdapter supplierListTableAdapter;
        private System.Windows.Forms.BindingSource belayAbSSDataSetBindingSource;
        private System.Windows.Forms.BindingSource mRequisitionNumbersBindingSource;
        private BelayAbSSDataSetTableAdapters.m_RequisitionNumbersTableAdapter m_RequisitionNumbersTableAdapter;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox WorkOrderNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemBalancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnAddAll;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button btnCloseActivate;
        private System.Windows.Forms.ComboBox requestTypeComboBox;
        private System.Windows.Forms.CheckBox chkAuto;
    }
}