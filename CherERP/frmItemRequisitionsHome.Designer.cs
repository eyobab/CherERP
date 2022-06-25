namespace Belayab
{
    partial class frmItemRequisitionsHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemRequisitionsHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemRequisitionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.itemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.lblReqType = new System.Windows.Forms.ToolStripLabel();
            this.ReqTypeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnSendItems = new System.Windows.Forms.ToolStripButton();
            this.btnReceiveItems = new System.Windows.Forms.ToolStripButton();
            this.btnIssueLocal = new System.Windows.Forms.ToolStripButton();
            this.itemRequisitionDataGridView = new System.Windows.Forms.DataGridView();
            this.RequisitionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequisitionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRequisitionDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemRequisitionDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRequisitionTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter();
            this.departmentLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemRequisitionDetailsTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter();
            this.departmentLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingNavigator)).BeginInit();
            this.itemRequisitionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemRequisitionBindingNavigator
            // 
            this.itemRequisitionBindingNavigator.AddNewItem = null;
            this.itemRequisitionBindingNavigator.BindingSource = this.itemRequisitionBindingSource;
            this.itemRequisitionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemRequisitionBindingNavigator.DeleteItem = null;
            this.itemRequisitionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblReqType,
            this.ReqTypeComboBox,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtFind,
            this.btnNew,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripRefresh,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.btnSendItems,
            this.btnReceiveItems,
            this.btnIssueLocal});
            this.itemRequisitionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemRequisitionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemRequisitionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemRequisitionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemRequisitionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemRequisitionBindingNavigator.Name = "itemRequisitionBindingNavigator";
            this.itemRequisitionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemRequisitionBindingNavigator.Size = new System.Drawing.Size(1117, 25);
            this.itemRequisitionBindingNavigator.TabIndex = 0;
            this.itemRequisitionBindingNavigator.Text = "bindingNavigator1";
            // 
            // itemRequisitionBindingSource
            // 
            this.itemRequisitionBindingSource.DataMember = "ItemRequisition";
            this.itemRequisitionBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // lblReqType
            // 
            this.lblReqType.Name = "lblReqType";
            this.lblReqType.Size = new System.Drawing.Size(47, 22);
            this.lblReqType.Text = "Type>>";
            // 
            // ReqTypeComboBox
            // 
            this.ReqTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ST_R",
            "TR_R_Rec",
            "TR_R_Sent",
            "All"});
            this.ReqTypeComboBox.Enabled = false;
            this.ReqTypeComboBox.Items.AddRange(new object[] {
            "ST_R",
            "TR_R_Rec",
            "TR_R_Sent",
            "All"});
            this.ReqTypeComboBox.Name = "ReqTypeComboBox";
            this.ReqTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this.ReqTypeComboBox.Text = "All";
            this.ReqTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ReqTypeComboBox_SelectedIndexChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Find>>";
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 25);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(60, 22);
            this.btnNew.Text = "Add New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel3.Text = "   ";
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefresh.Image")));
            this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolStripRefresh.Text = "Refresh";
            this.toolStripRefresh.Click += new System.EventHandler(this.toolStripRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel4.Text = "   ";
            // 
            // btnSendItems
            // 
            this.btnSendItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSendItems.Image = ((System.Drawing.Image)(resources.GetObject("btnSendItems.Image")));
            this.btnSendItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendItems.Name = "btnSendItems";
            this.btnSendItems.Size = new System.Drawing.Size(52, 22);
            this.btnSendItems.Text = "Transfer";
            this.btnSendItems.Visible = false;
            this.btnSendItems.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnReceiveItems
            // 
            this.btnReceiveItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReceiveItems.Image = ((System.Drawing.Image)(resources.GetObject("btnReceiveItems.Image")));
            this.btnReceiveItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceiveItems.Name = "btnReceiveItems";
            this.btnReceiveItems.Size = new System.Drawing.Size(51, 22);
            this.btnReceiveItems.Text = "Receive";
            this.btnReceiveItems.Visible = false;
            this.btnReceiveItems.Click += new System.EventHandler(this.btnReceiveItems_Click);
            // 
            // btnIssueLocal
            // 
            this.btnIssueLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnIssueLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueLocal.Image")));
            this.btnIssueLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIssueLocal.Name = "btnIssueLocal";
            this.btnIssueLocal.Size = new System.Drawing.Size(37, 22);
            this.btnIssueLocal.Text = "Issue";
            this.btnIssueLocal.Visible = false;
            this.btnIssueLocal.Click += new System.EventHandler(this.btnIssueLocal_Click);
            // 
            // itemRequisitionDataGridView
            // 
            this.itemRequisitionDataGridView.AllowUserToAddRows = false;
            this.itemRequisitionDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.itemRequisitionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.itemRequisitionDataGridView.AutoGenerateColumns = false;
            this.itemRequisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemRequisitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequisitionType,
            this.RequisitionNumber,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.StoreID,
            this.FromStore,
            this.Status});
            this.itemRequisitionDataGridView.DataSource = this.itemRequisitionBindingSource;
            this.itemRequisitionDataGridView.Location = new System.Drawing.Point(2, 28);
            this.itemRequisitionDataGridView.Name = "itemRequisitionDataGridView";
            this.itemRequisitionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemRequisitionDataGridView.Size = new System.Drawing.Size(858, 475);
            this.itemRequisitionDataGridView.TabIndex = 1;
            this.itemRequisitionDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.itemRequisitionDataGridView_DataError);
            this.itemRequisitionDataGridView.SelectionChanged += new System.EventHandler(this.itemRequisitionDataGridView_SelectionChanged);
            this.itemRequisitionDataGridView.DoubleClick += new System.EventHandler(this.itemRequisitionDataGridView_DoubleClick);
            // 
            // RequisitionType
            // 
            this.RequisitionType.DataPropertyName = "RequisitionType";
            this.RequisitionType.HeaderText = "Type";
            this.RequisitionType.Name = "RequisitionType";
            this.RequisitionType.Width = 60;
            // 
            // RequisitionNumber
            // 
            this.RequisitionNumber.DataPropertyName = "RequisitionNumber";
            this.RequisitionNumber.HeaderText = "Requisition Number";
            this.RequisitionNumber.Name = "RequisitionNumber";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RequestedBy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Requested By";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ApprovedBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "Approved By";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RequistionDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Requistion Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // StoreID
            // 
            this.StoreID.DataPropertyName = "StoreID";
            this.StoreID.HeaderText = "Store";
            this.StoreID.Name = "StoreID";
            // 
            // FromStore
            // 
            this.FromStore.DataPropertyName = "FromStore";
            this.FromStore.HeaderText = "FromStore";
            this.FromStore.Name = "FromStore";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // itemRequisitionDetailsBindingSource
            // 
            this.itemRequisitionDetailsBindingSource.DataMember = "FK_ItemRequisionDetails_ItemRequisition";
            this.itemRequisitionDetailsBindingSource.DataSource = this.itemRequisitionBindingSource;
            // 
            // itemRequisitionDetailsDataGridView
            // 
            this.itemRequisitionDetailsDataGridView.AllowUserToAddRows = false;
            this.itemRequisitionDetailsDataGridView.AllowUserToDeleteRows = false;
            this.itemRequisitionDetailsDataGridView.AutoGenerateColumns = false;
            this.itemRequisitionDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemRequisitionDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.dataGridViewTextBoxColumn10});
            this.itemRequisitionDetailsDataGridView.DataSource = this.itemRequisitionDetailsBindingSource;
            this.itemRequisitionDetailsDataGridView.Location = new System.Drawing.Point(866, 28);
            this.itemRequisitionDetailsDataGridView.Name = "itemRequisitionDetailsDataGridView";
            this.itemRequisitionDetailsDataGridView.Size = new System.Drawing.Size(251, 156);
            this.itemRequisitionDetailsDataGridView.TabIndex = 2;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RequestedQuantity";
            this.dataGridViewTextBoxColumn10.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RequisitionNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Requisition Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RequestedBy";
            this.dataGridViewTextBoxColumn3.HeaderText = "RequestedBy";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RequestedQuantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RequestedQuantity";
            this.dataGridViewTextBoxColumn11.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // itemRequisitionTableAdapter
            // 
            this.itemRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // departmentLstBindingSource
            // 
            this.departmentLstBindingSource.DataMember = "DepartmentLst";
            this.departmentLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // itemRequisitionDetailsTableAdapter
            // 
            this.itemRequisitionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // departmentLstTableAdapter
            // 
            this.departmentLstTableAdapter.ClearBeforeFill = true;
            // 
            // frmRequisitionsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 501);
            this.Controls.Add(this.itemRequisitionDetailsDataGridView);
            this.Controls.Add(this.itemRequisitionDataGridView);
            this.Controls.Add(this.itemRequisitionBindingNavigator);
            this.Name = "frmRequisitionsHome";
            this.Text = "Item Requisitions";
            this.Load += new System.EventHandler(this.frmRequisitionsHome_Load);
            this.Resize += new System.EventHandler(this.frmRequisitionsHome_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingNavigator)).EndInit();
            this.itemRequisitionBindingNavigator.ResumeLayout(false);
            this.itemRequisitionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource itemRequisitionBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter itemRequisitionTableAdapter;
        private System.Windows.Forms.BindingNavigator itemRequisitionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView itemRequisitionDataGridView;
        private System.Windows.Forms.BindingSource itemRequisitionDetailsBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter itemRequisitionDetailsTableAdapter;
        private System.Windows.Forms.DataGridView itemRequisitionDetailsDataGridView;
        private System.Windows.Forms.BindingSource departmentLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter departmentLstTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequisitionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequisitionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        public System.Windows.Forms.ToolStripComboBox ReqTypeComboBox;
        public System.Windows.Forms.ToolStripButton btnSendItems;
        public System.Windows.Forms.ToolStripButton btnReceiveItems;
        public System.Windows.Forms.ToolStripButton btnIssueLocal;
        public System.Windows.Forms.ToolStripLabel lblReqType;
    }
}