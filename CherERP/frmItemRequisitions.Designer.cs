namespace Belayab
{
    partial class frmItemRequisitions
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
            System.Windows.Forms.Label approvedByLabel;
            System.Windows.Forms.Label requistionDateLabel;
            System.Windows.Forms.Label requestedByLabel;
            System.Windows.Forms.Label requestToLabel;
            System.Windows.Forms.Label departmentIdLabel;
            System.Windows.Forms.Label requisitionNumberLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label requisitionTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemRequisitions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.itemRequistionDetailsbSouce = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemRequisitionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.itemRequisitionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.requistionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requestedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mWorkOrderNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisitionNumberTextBox = new System.Windows.Forms.TextBox();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.itemRequisitionTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter();
            this.itemRequisitionDetailsTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter();
            this.departmentLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter();
            this.belayAbSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.itemRequistionDetailsBNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.detailNaveAddNew = new System.Windows.Forms.ToolStripButton();
            this.detailNaveSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.detailNaveDelete = new System.Windows.Forms.ToolStripButton();
            this.mainNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MainNavFirst = new System.Windows.Forms.ToolStripButton();
            this.MainNavPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavPosition = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.MainNaveSave = new System.Windows.Forms.ToolStripButton();
            this.DeleteWrap = new System.Windows.Forms.ToolStripButton();
            this.MainNavPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fromStoreLabel = new System.Windows.Forms.Label();
            this.fromStoreComboBox = new System.Windows.Forms.ComboBox();
            this.requisitionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.departmentIdComboBox = new System.Windows.Forms.ComboBox();
            this.workOrderNoComboBox = new System.Windows.Forms.ComboBox();
            this.btnGotoPurchaseRequisition = new System.Windows.Forms.Button();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.DetailsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemRequistionDetailsView = new System.Windows.Forms.DataGridView();
            this.requistionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RequestedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remariksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowAll = new System.Windows.Forms.ToolStripMenuItem();
            this.m_WorkOrderNumbersTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_WorkOrderNumbersTableAdapter();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.lstRequsitions = new System.Windows.Forms.ListBox();
            approvedByLabel = new System.Windows.Forms.Label();
            requistionDateLabel = new System.Windows.Forms.Label();
            requestedByLabel = new System.Windows.Forms.Label();
            requestToLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            requisitionNumberLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            requisitionTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequistionDetailsbSouce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingNavigator)).BeginInit();
            this.itemRequisitionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mWorkOrderNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequistionDetailsBNav)).BeginInit();
            this.itemRequistionDetailsBNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).BeginInit();
            this.mainNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemRequistionDetailsView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            approvedByLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            approvedByLabel.Location = new System.Drawing.Point(604, 48);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(82, 13);
            approvedByLabel.TabIndex = 11;
            approvedByLabel.Text = "Approved By:";
            // 
            // requistionDateLabel
            // 
            requistionDateLabel.AutoSize = true;
            requistionDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            requistionDateLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requistionDateLabel.Location = new System.Drawing.Point(35, 134);
            requistionDateLabel.Name = "requistionDateLabel";
            requistionDateLabel.Size = new System.Drawing.Size(100, 13);
            requistionDateLabel.TabIndex = 9;
            requistionDateLabel.Text = "Requistion Date:";
            // 
            // requestedByLabel
            // 
            requestedByLabel.AutoSize = true;
            requestedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            requestedByLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requestedByLabel.Location = new System.Drawing.Point(43, 109);
            requestedByLabel.Name = "requestedByLabel";
            requestedByLabel.Size = new System.Drawing.Size(88, 13);
            requestedByLabel.TabIndex = 7;
            requestedByLabel.Text = "Requested By:";
            // 
            // requestToLabel
            // 
            requestToLabel.AutoSize = true;
            requestToLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            requestToLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requestToLabel.Location = new System.Drawing.Point(15, 81);
            requestToLabel.Name = "requestToLabel";
            requestToLabel.Size = new System.Drawing.Size(116, 13);
            requestToLabel.TabIndex = 5;
            requestToLabel.Text = "Rererence Number:";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            departmentIdLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            departmentIdLabel.Location = new System.Drawing.Point(46, 54);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(79, 13);
            departmentIdLabel.TabIndex = 3;
            departmentIdLabel.Text = "Department:";
            // 
            // requisitionNumberLabel
            // 
            requisitionNumberLabel.AutoSize = true;
            requisitionNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            requisitionNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requisitionNumberLabel.Location = new System.Drawing.Point(5, 27);
            requisitionNumberLabel.Name = "requisitionNumberLabel";
            requisitionNumberLabel.Size = new System.Drawing.Size(120, 13);
            requisitionNumberLabel.TabIndex = 1;
            requisitionNumberLabel.Text = "Requisition Number:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(421, 602);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 56;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(421, 626);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(66, 13);
            updatedbyLabel.TabIndex = 57;
            updatedbyLabel.Text = "Updated By:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(638, 21);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 13);
            statusLabel.TabIndex = 49;
            statusLabel.Text = "Status:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storeIDLabel.Location = new System.Drawing.Point(377, 23);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(41, 13);
            storeIDLabel.TabIndex = 51;
            storeIDLabel.Text = "Store:";
            // 
            // requisitionTypeLabel
            // 
            requisitionTypeLabel.AutoSize = true;
            requisitionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requisitionTypeLabel.Location = new System.Drawing.Point(377, 54);
            requisitionTypeLabel.Name = "requisitionTypeLabel";
            requisitionTypeLabel.Size = new System.Drawing.Size(106, 13);
            requisitionTypeLabel.TabIndex = 52;
            requisitionTypeLabel.Text = "Requisition Type:";
            // 
            // itemRequisitionBindingSource
            // 
            this.itemRequisitionBindingSource.DataMember = "ItemRequisition";
            this.itemRequisitionBindingSource.DataSource = this.belayAbItemRequistions;
            this.itemRequisitionBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.itemRequisitionBindingSource_AddingNew);
            this.itemRequisitionBindingSource.PositionChanged += new System.EventHandler(this.itemRequisitionBindingSource_PositionChanged);
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemRequistionDetailsbSouce
            // 
            this.itemRequistionDetailsbSouce.DataMember = "FK_ItemRequisionDetails_ItemRequisition";
            this.itemRequistionDetailsbSouce.DataSource = this.itemRequisitionBindingSource;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // itemRequisitionBindingNavigatorSaveItem
            // 
            this.itemRequisitionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemRequisitionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemRequisitionBindingNavigatorSaveItem.Image")));
            this.itemRequisitionBindingNavigatorSaveItem.Name = "itemRequisitionBindingNavigatorSaveItem";
            this.itemRequisitionBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.itemRequisitionBindingNavigatorSaveItem.Text = "Save Data";
            this.itemRequisitionBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemRequisitionBindingNavigatorSaveItem_Click);
            // 
            // itemRequisitionBindingNavigator
            // 
            this.itemRequisitionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemRequisitionBindingNavigator.BindingSource = this.itemRequisitionBindingSource;
            this.itemRequisitionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemRequisitionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemRequisitionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.itemRequisitionBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemRequisitionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.itemRequisitionBindingNavigatorSaveItem});
            this.itemRequisitionBindingNavigator.Location = new System.Drawing.Point(58, 296);
            this.itemRequisitionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemRequisitionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemRequisitionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemRequisitionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemRequisitionBindingNavigator.Name = "itemRequisitionBindingNavigator";
            this.itemRequisitionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemRequisitionBindingNavigator.Size = new System.Drawing.Size(285, 27);
            this.itemRequisitionBindingNavigator.TabIndex = 0;
            this.itemRequisitionBindingNavigator.Text = "bindingNavigator1";
            this.itemRequisitionBindingNavigator.Visible = false;
            // 
            // approvedByComboBox
            // 
            this.approvedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.approvedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.approvedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "ApprovedBy", true));
            this.approvedByComboBox.DataSource = this.employeesLstBindingSource2;
            this.approvedByComboBox.DisplayMember = "EmployeeName";
            this.approvedByComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(692, 45);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(144, 21);
            this.approvedByComboBox.TabIndex = 3;
            this.approvedByComboBox.ValueMember = "EmployeeId";
            // 
            // employeesLstBindingSource2
            // 
            this.employeesLstBindingSource2.DataMember = "EmployeesLst";
            this.employeesLstBindingSource2.DataSource = this.belayAbItemRequistions;
            // 
            // requistionDateDateTimePicker
            // 
            this.requistionDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.requistionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemRequisitionBindingSource, "RequistionDate", true));
            this.requistionDateDateTimePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requistionDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.requistionDateDateTimePicker.Location = new System.Drawing.Point(143, 133);
            this.requistionDateDateTimePicker.Name = "requistionDateDateTimePicker";
            this.requistionDateDateTimePicker.Size = new System.Drawing.Size(135, 21);
            this.requistionDateDateTimePicker.TabIndex = 2;
            // 
            // requestedByComboBox
            // 
            this.requestedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.requestedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.requestedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "RequestedBy", true));
            this.requestedByComboBox.DataSource = this.employeesLstBindingSource1;
            this.requestedByComboBox.DisplayMember = "EmployeeName";
            this.requestedByComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedByComboBox.FormattingEnabled = true;
            this.requestedByComboBox.Location = new System.Drawing.Point(141, 105);
            this.requestedByComboBox.Name = "requestedByComboBox";
            this.requestedByComboBox.Size = new System.Drawing.Size(184, 21);
            this.requestedByComboBox.TabIndex = 1;
            this.requestedByComboBox.ValueMember = "EmployeeId";
            // 
            // employeesLstBindingSource1
            // 
            this.employeesLstBindingSource1.DataMember = "EmployeesLst";
            this.employeesLstBindingSource1.DataSource = this.belayAbItemRequistions;
            // 
            // mWorkOrderNumbersBindingSource
            // 
            this.mWorkOrderNumbersBindingSource.DataMember = "m_WorkOrderNumbers";
            this.mWorkOrderNumbersBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesLstBindingSource
            // 
            this.employeesLstBindingSource.DataMember = "EmployeesLst";
            this.employeesLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // departmentLstBindingSource
            // 
            this.departmentLstBindingSource.DataMember = "DepartmentLst";
            this.departmentLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // requisitionNumberTextBox
            // 
            this.requisitionNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "RequisitionNumber", true));
            this.requisitionNumberTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requisitionNumberTextBox.Location = new System.Drawing.Point(140, 24);
            this.requisitionNumberTextBox.Name = "requisitionNumberTextBox";
            this.requisitionNumberTextBox.Size = new System.Drawing.Size(132, 21);
            this.requisitionNumberTextBox.TabIndex = 0;
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
            // itemRequisitionTableAdapter
            // 
            this.itemRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // itemRequisitionDetailsTableAdapter
            // 
            this.itemRequisitionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // departmentLstTableAdapter
            // 
            this.departmentLstTableAdapter.ClearBeforeFill = true;
            // 
            // belayAbSSDataSetBindingSource
            // 
            this.belayAbSSDataSetBindingSource.DataSource = this.belayAbSSDataSet;
            this.belayAbSSDataSetBindingSource.Position = 0;
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // itemRequistionDetailsBNav
            // 
            this.itemRequistionDetailsBNav.AddNewItem = null;
            this.itemRequistionDetailsBNav.CountItem = this.bindingNavigatorCountItem1;
            this.itemRequistionDetailsBNav.DeleteItem = null;
            this.itemRequistionDetailsBNav.Dock = System.Windows.Forms.DockStyle.None;
            this.itemRequistionDetailsBNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemRequistionDetailsBNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.detailNaveAddNew,
            this.detailNaveSave,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.detailNaveDelete});
            this.itemRequistionDetailsBNav.Location = new System.Drawing.Point(11, 597);
            this.itemRequistionDetailsBNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.itemRequistionDetailsBNav.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.itemRequistionDetailsBNav.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.itemRequistionDetailsBNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.itemRequistionDetailsBNav.Name = "itemRequistionDetailsBNav";
            this.itemRequistionDetailsBNav.PositionItem = this.bindingNavigatorPositionItem1;
            this.itemRequistionDetailsBNav.Size = new System.Drawing.Size(423, 27);
            this.itemRequistionDetailsBNav.TabIndex = 18;
            this.itemRequistionDetailsBNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
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
            // detailNaveAddNew
            // 
            this.detailNaveAddNew.Checked = true;
            this.detailNaveAddNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNaveAddNew.Image = ((System.Drawing.Image)(resources.GetObject("detailNaveAddNew.Image")));
            this.detailNaveAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNaveAddNew.Name = "detailNaveAddNew";
            this.detailNaveAddNew.Size = new System.Drawing.Size(64, 24);
            this.detailNaveAddNew.Text = "+ Add";
            this.detailNaveAddNew.Click += new System.EventHandler(this.toolStrDetailAddNew_Click);
            // 
            // detailNaveSave
            // 
            this.detailNaveSave.Checked = true;
            this.detailNaveSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNaveSave.Image = ((System.Drawing.Image)(resources.GetObject("detailNaveSave.Image")));
            this.detailNaveSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNaveSave.Name = "detailNaveSave";
            this.detailNaveSave.Size = new System.Drawing.Size(55, 24);
            this.detailNaveSave.Text = "Save";
            this.detailNaveSave.Click += new System.EventHandler(this.toolstrDetailsSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 24);
            this.toolStripLabel2.Text = "  ";
            // 
            // detailNaveDelete
            // 
            this.detailNaveDelete.Checked = true;
            this.detailNaveDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNaveDelete.Image = ((System.Drawing.Image)(resources.GetObject("detailNaveDelete.Image")));
            this.detailNaveDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNaveDelete.Name = "detailNaveDelete";
            this.detailNaveDelete.Size = new System.Drawing.Size(72, 24);
            this.detailNaveDelete.Text = "- Delete";
            this.detailNaveDelete.Click += new System.EventHandler(this.toolStrDetailDelete_Click);
            // 
            // mainNavigator
            // 
            this.mainNavigator.AddNewItem = null;
            this.mainNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainNavigator.BindingSource = this.itemRequisitionBindingSource;
            this.mainNavigator.CountItem = this.toolStripLabel1;
            this.mainNavigator.DeleteItem = null;
            this.mainNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.mainNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainNavFirst,
            this.MainNavPrevious,
            this.toolStripSeparator1,
            this.MainNavPosition,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.MainNavAddnew,
            this.MainNaveSave,
            this.DeleteWrap,
            this.MainNavPrint});
            this.mainNavigator.Location = new System.Drawing.Point(3, 182);
            this.mainNavigator.MoveFirstItem = this.MainNavFirst;
            this.mainNavigator.MoveLastItem = this.toolStripButton6;
            this.mainNavigator.MoveNextItem = this.toolStripButton5;
            this.mainNavigator.MovePreviousItem = this.MainNavPrevious;
            this.mainNavigator.Name = "mainNavigator";
            this.mainNavigator.PositionItem = this.MainNavPosition;
            this.mainNavigator.Size = new System.Drawing.Size(564, 27);
            this.mainNavigator.TabIndex = 0;
            this.mainNavigator.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 24);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // MainNavFirst
            // 
            this.MainNavFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavFirst.Image = ((System.Drawing.Image)(resources.GetObject("MainNavFirst.Image")));
            this.MainNavFirst.Name = "MainNavFirst";
            this.MainNavFirst.RightToLeftAutoMirrorImage = true;
            this.MainNavFirst.Size = new System.Drawing.Size(24, 24);
            this.MainNavFirst.Text = "Move first";
            // 
            // MainNavPrevious
            // 
            this.MainNavPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavPrevious.Image = ((System.Drawing.Image)(resources.GetObject("MainNavPrevious.Image")));
            this.MainNavPrevious.Name = "MainNavPrevious";
            this.MainNavPrevious.RightToLeftAutoMirrorImage = true;
            this.MainNavPrevious.Size = new System.Drawing.Size(24, 24);
            this.MainNavPrevious.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // MainNavPosition
            // 
            this.MainNavPosition.AccessibleName = "Position";
            this.MainNavPosition.AutoSize = false;
            this.MainNavPosition.Name = "MainNavPosition";
            this.MainNavPosition.Size = new System.Drawing.Size(50, 23);
            this.MainNavPosition.Text = "0";
            this.MainNavPosition.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(95, 24);
            this.MainNavAddnew.Text = "Add new";
            this.MainNavAddnew.Click += new System.EventHandler(this.tooStrDetailAddnew_Click);
            // 
            // MainNaveSave
            // 
            this.MainNaveSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainNaveSave.Image = ((System.Drawing.Image)(resources.GetObject("MainNaveSave.Image")));
            this.MainNaveSave.Name = "MainNaveSave";
            this.MainNaveSave.Size = new System.Drawing.Size(109, 24);
            this.MainNaveSave.Text = "Save Data";
            this.MainNaveSave.Click += new System.EventHandler(this.itemsReceivedBindingNavigatorSaveItem_Click);
            // 
            // DeleteWrap
            // 
            this.DeleteWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.DeleteWrap.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWrap.Image")));
            this.DeleteWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteWrap.Name = "DeleteWrap";
            this.DeleteWrap.Size = new System.Drawing.Size(80, 24);
            this.DeleteWrap.Text = "Delete";
            this.DeleteWrap.Click += new System.EventHandler(this.DeleteWrap_Click);
            // 
            // MainNavPrint
            // 
            this.MainNavPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavPrint.Image = ((System.Drawing.Image)(resources.GetObject("MainNavPrint.Image")));
            this.MainNavPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavPrint.Name = "MainNavPrint";
            this.MainNavPrint.Size = new System.Drawing.Size(67, 24);
            this.MainNavPrint.Text = "Print";
            this.MainNavPrint.Click += new System.EventHandler(this.MainNavPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.groupBox1.Controls.Add(this.fromStoreLabel);
            this.groupBox1.Controls.Add(this.fromStoreComboBox);
            this.groupBox1.Controls.Add(requisitionTypeLabel);
            this.groupBox1.Controls.Add(this.requisitionTypeComboBox);
            this.groupBox1.Controls.Add(storeIDLabel);
            this.groupBox1.Controls.Add(this.storeIDComboBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.departmentIdComboBox);
            this.groupBox1.Controls.Add(this.workOrderNoComboBox);
            this.groupBox1.Controls.Add(this.btnGotoPurchaseRequisition);
            this.groupBox1.Controls.Add(this.chkAuto);
            this.groupBox1.Controls.Add(this.mainNavigator);
            this.groupBox1.Controls.Add(requisitionNumberLabel);
            this.groupBox1.Controls.Add(departmentIdLabel);
            this.groupBox1.Controls.Add(requestToLabel);
            this.groupBox1.Controls.Add(requestedByLabel);
            this.groupBox1.Controls.Add(this.requisitionNumberTextBox);
            this.groupBox1.Controls.Add(this.requestedByComboBox);
            this.groupBox1.Controls.Add(requistionDateLabel);
            this.groupBox1.Controls.Add(this.approvedByComboBox);
            this.groupBox1.Controls.Add(this.requistionDateDateTimePicker);
            this.groupBox1.Controls.Add(approvedByLabel);
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requisition Main Information";
            // 
            // fromStoreLabel
            // 
            this.fromStoreLabel.AutoSize = true;
            this.fromStoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStoreLabel.Location = new System.Drawing.Point(358, 84);
            this.fromStoreLabel.Name = "fromStoreLabel";
            this.fromStoreLabel.Size = new System.Drawing.Size(72, 13);
            this.fromStoreLabel.TabIndex = 55;
            this.fromStoreLabel.Text = "From Store:";
            // 
            // fromStoreComboBox
            // 
            this.fromStoreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemRequisitionBindingSource, "FromStore", true));
            this.fromStoreComboBox.DisplayMember = "Storename";
            this.fromStoreComboBox.FormattingEnabled = true;
            this.fromStoreComboBox.Location = new System.Drawing.Point(431, 81);
            this.fromStoreComboBox.Name = "fromStoreComboBox";
            this.fromStoreComboBox.Size = new System.Drawing.Size(149, 21);
            this.fromStoreComboBox.TabIndex = 54;
            this.fromStoreComboBox.ValueMember = "StoreId";
            // 
            // requisitionTypeComboBox
            // 
            this.requisitionTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "RequisitionType", true));
            this.requisitionTypeComboBox.FormattingEnabled = true;
            this.requisitionTypeComboBox.Items.AddRange(new object[] {
            "ST",
            "TR"});
            this.requisitionTypeComboBox.Location = new System.Drawing.Point(490, 49);
            this.requisitionTypeComboBox.Name = "requisitionTypeComboBox";
            this.requisitionTypeComboBox.Size = new System.Drawing.Size(76, 21);
            this.requisitionTypeComboBox.TabIndex = 53;
            this.requisitionTypeComboBox.Text = "ST";
            this.requisitionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.requisitionTypeComboBox_SelectedIndexChanged);
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemRequisitionBindingSource, "StoreID", true));
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(429, 19);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(149, 21);
            this.storeIDComboBox.TabIndex = 52;
            this.storeIDComboBox.ValueMember = "StoreID";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "Status", true));
            this.statusComboBox.DisplayMember = "State";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(691, 15);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(142, 21);
            this.statusComboBox.TabIndex = 50;
            this.statusComboBox.ValueMember = "State";
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // departmentIdComboBox
            // 
            this.departmentIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemRequisitionBindingSource, "DepartmentId", true));
            this.departmentIdComboBox.DataSource = this.departmentLstBindingSource;
            this.departmentIdComboBox.DisplayMember = "DepartmentName";
            this.departmentIdComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentIdComboBox.FormattingEnabled = true;
            this.departmentIdComboBox.Location = new System.Drawing.Point(140, 50);
            this.departmentIdComboBox.Name = "departmentIdComboBox";
            this.departmentIdComboBox.Size = new System.Drawing.Size(185, 21);
            this.departmentIdComboBox.TabIndex = 49;
            this.departmentIdComboBox.ValueMember = "DepartmentId";
            // 
            // workOrderNoComboBox
            // 
            this.workOrderNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.workOrderNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.workOrderNoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemRequisitionBindingSource, "Reference", true));
            this.workOrderNoComboBox.DataSource = this.mWorkOrderNumbersBindingSource;
            this.workOrderNoComboBox.DisplayMember = "WorkOrderNumber";
            this.workOrderNoComboBox.FormattingEnabled = true;
            this.workOrderNoComboBox.Location = new System.Drawing.Point(140, 77);
            this.workOrderNoComboBox.Name = "workOrderNoComboBox";
            this.workOrderNoComboBox.Size = new System.Drawing.Size(185, 21);
            this.workOrderNoComboBox.TabIndex = 48;
            this.workOrderNoComboBox.ValueMember = "WorkOrderNumber";
            // 
            // btnGotoPurchaseRequisition
            // 
            this.btnGotoPurchaseRequisition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotoPurchaseRequisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotoPurchaseRequisition.Location = new System.Drawing.Point(727, 173);
            this.btnGotoPurchaseRequisition.Name = "btnGotoPurchaseRequisition";
            this.btnGotoPurchaseRequisition.Size = new System.Drawing.Size(78, 27);
            this.btnGotoPurchaseRequisition.TabIndex = 47;
            this.btnGotoPurchaseRequisition.Text = "Goto PR";
            this.btnGotoPurchaseRequisition.UseVisualStyleBackColor = true;
            this.btnGotoPurchaseRequisition.Click += new System.EventHandler(this.btnGotoPurchaseRequisition_Click);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto.Location = new System.Drawing.Point(278, 26);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(56, 17);
            this.chkAuto.TabIndex = 46;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // DetailsTab
            // 
            this.DetailsTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.DetailsTab.Controls.Add(this.tabPage1);
            this.DetailsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTab.Location = new System.Drawing.Point(9, 233);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(939, 366);
            this.DetailsTab.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.ItemRequistionDetailsView);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(931, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Requested Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemRequistionDetailsView
            // 
            this.ItemRequistionDetailsView.AllowUserToAddRows = false;
            this.ItemRequistionDetailsView.AllowUserToDeleteRows = false;
            this.ItemRequistionDetailsView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRequistionDetailsView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemRequistionDetailsView.AutoGenerateColumns = false;
            this.ItemRequistionDetailsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ItemRequistionDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ItemRequistionDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requistionNumberDataGridViewTextBoxColumn,
            this.ItemID,
            this.RequestedQty,
            this.HD,
            this.Units,
            this.InStock,
            this.remariksDataGridViewTextBoxColumn});
            this.ItemRequistionDetailsView.ContextMenuStrip = this.contextMenuStrip1;
            this.ItemRequistionDetailsView.DataSource = this.itemRequistionDetailsbSouce;
            this.ItemRequistionDetailsView.Location = new System.Drawing.Point(8, 9);
            this.ItemRequistionDetailsView.Name = "ItemRequistionDetailsView";
            this.ItemRequistionDetailsView.Size = new System.Drawing.Size(917, 320);
            this.ItemRequistionDetailsView.TabIndex = 0;
            this.ItemRequistionDetailsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemRequistionDetailsView_CellContentClick);
            this.ItemRequistionDetailsView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ItemRequistionDetailsView_CellValidating);
            this.ItemRequistionDetailsView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemRequistionDetailsView_CellValueChanged);
            this.ItemRequistionDetailsView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ItemRequistionDetailsView_ColumnHeaderMouseClick);
            this.ItemRequistionDetailsView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ItemRequistionDetailsView_DataError);
            this.ItemRequistionDetailsView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ItemRequistionDetailsView_EditingControlShowing);
            this.ItemRequistionDetailsView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemRequistionDetailsView_RowValidated);
            this.ItemRequistionDetailsView.Sorted += new System.EventHandler(this.ItemRequistionDetailsView_Sorted);
            this.ItemRequistionDetailsView.Leave += new System.EventHandler(this.ItemRequistionDetailsView_Leave);
            // 
            // requistionNumberDataGridViewTextBoxColumn
            // 
            this.requistionNumberDataGridViewTextBoxColumn.DataPropertyName = "RequistionNumber";
            this.requistionNumberDataGridViewTextBoxColumn.HeaderText = "RequistionNumber";
            this.requistionNumberDataGridViewTextBoxColumn.Name = "requistionNumberDataGridViewTextBoxColumn";
            this.requistionNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.DataSource = this.partNumDescriptionBindingSource;
            this.ItemID.DisplayMember = "Description";
            this.ItemID.HeaderText = "Item ";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemID.ValueMember = "ItemID";
            this.ItemID.Width = 300;
            // 
            // RequestedQty
            // 
            this.RequestedQty.DataPropertyName = "RequestedQuantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.RequestedQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.RequestedQty.HeaderText = "Requested Qty";
            this.RequestedQty.Name = "RequestedQty";
            this.RequestedQty.Width = 120;
            // 
            // HD
            // 
            this.HD.DataPropertyName = "HD";
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.Visible = false;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            // 
            // InStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.InStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // remariksDataGridViewTextBoxColumn
            // 
            this.remariksDataGridViewTextBoxColumn.DataPropertyName = "Remariks";
            this.remariksDataGridViewTextBoxColumn.HeaderText = "Remarik";
            this.remariksDataGridViewTextBoxColumn.Name = "remariksDataGridViewTextBoxColumn";
            this.remariksDataGridViewTextBoxColumn.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBalancesToolStripMenuItem,
            this.mnuRefreshItems,
            this.mnuShowAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 70);
            // 
            // itemBalancesToolStripMenuItem
            // 
            this.itemBalancesToolStripMenuItem.Name = "itemBalancesToolStripMenuItem";
            this.itemBalancesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.itemBalancesToolStripMenuItem.Text = "Item Balances";
            this.itemBalancesToolStripMenuItem.Click += new System.EventHandler(this.itemBalancesToolStripMenuItem_Click);
            // 
            // mnuRefreshItems
            // 
            this.mnuRefreshItems.Name = "mnuRefreshItems";
            this.mnuRefreshItems.Size = new System.Drawing.Size(147, 22);
            this.mnuRefreshItems.Text = "Refresh Items";
            this.mnuRefreshItems.Click += new System.EventHandler(this.mnuRefreshItems_Click);
            // 
            // mnuShowAll
            // 
            this.mnuShowAll.Name = "mnuShowAll";
            this.mnuShowAll.Size = new System.Drawing.Size(147, 22);
            this.mnuShowAll.Text = "Find Item";
            this.mnuShowAll.Click += new System.EventHandler(this.mnuShowAll_Click);
            // 
            // m_WorkOrderNumbersTableAdapter
            // 
            this.m_WorkOrderNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "CreatedBy", true));
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(489, 602);
            this.createdByTextBox.Multiline = true;
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(200, 20);
            this.createdByTextBox.TabIndex = 58;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemRequisitionBindingSource, "UpdatedBy", true));
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(489, 625);
            this.updatedbyTextBox.Multiline = true;
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(200, 20);
            this.updatedbyTextBox.TabIndex = 59;
            // 
            // lstRequsitions
            // 
            this.lstRequsitions.DataSource = this.itemRequisitionBindingSource;
            this.lstRequsitions.DisplayMember = "RequisitionNumber";
            this.lstRequsitions.FormattingEnabled = true;
            this.lstRequsitions.Location = new System.Drawing.Point(9, 17);
            this.lstRequsitions.Name = "lstRequsitions";
            this.lstRequsitions.Size = new System.Drawing.Size(124, 199);
            this.lstRequsitions.TabIndex = 60;
            this.lstRequsitions.ValueMember = "RequisitionNumber";
            this.lstRequsitions.Visible = false;
            // 
            // frmItemRequisitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(987, 515);
            this.Controls.Add(this.lstRequsitions);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.itemRequistionDetailsBNav);
            this.Controls.Add(this.DetailsTab);
            this.Controls.Add(this.itemRequisitionBindingNavigator);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmItemRequisitions";
            this.Text = "Item Requistions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmItemRequisitions_Activated);
            this.Load += new System.EventHandler(this.frmItemRequisitions_Load);
            this.Shown += new System.EventHandler(this.frmItemRequisitions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequistionDetailsbSouce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingNavigator)).EndInit();
            this.itemRequisitionBindingNavigator.ResumeLayout(false);
            this.itemRequisitionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mWorkOrderNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequistionDetailsBNav)).EndInit();
            this.itemRequistionDetailsBNav.ResumeLayout(false);
            this.itemRequistionDetailsBNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).EndInit();
            this.mainNavigator.ResumeLayout(false);
            this.mainNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DetailsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemRequistionDetailsView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource itemRequisitionBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter itemRequisitionTableAdapter;
        private System.Windows.Forms.BindingSource itemRequistionDetailsbSouce;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter itemRequisitionDetailsTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton itemRequisitionBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator itemRequisitionBindingNavigator;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.DateTimePicker requistionDateDateTimePicker;
        private System.Windows.Forms.ComboBox requestedByComboBox;
        private System.Windows.Forms.TextBox requisitionNumberTextBox;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.BindingSource departmentLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter departmentLstTableAdapter;
        private System.Windows.Forms.BindingSource belayAbSSDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.BindingSource employeesLstBindingSource2;
        private System.Windows.Forms.BindingSource employeesLstBindingSource1;
        private System.Windows.Forms.BindingNavigator itemRequistionDetailsBNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton detailNaveSave;
        private System.Windows.Forms.BindingNavigator mainNavigator;
        private System.Windows.Forms.ToolStripButton MainNavAddnew;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton MainNavFirst;
        private System.Windows.Forms.ToolStripButton MainNavPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox MainNavPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton DeleteWrap;
        private System.Windows.Forms.ToolStripButton MainNaveSave;
        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView ItemRequistionDetailsView;
        private System.Windows.Forms.ToolStripButton detailNaveDelete;
        private System.Windows.Forms.ToolStripButton detailNaveAddNew;
        private System.Windows.Forms.ToolStripButton MainNavPrint;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshItems;
        private System.Windows.Forms.ToolStripMenuItem mnuShowAll;
        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource mWorkOrderNumbersBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_WorkOrderNumbersTableAdapter m_WorkOrderNumbersTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btnGotoPurchaseRequisition;
        private System.Windows.Forms.ComboBox workOrderNoComboBox;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        private System.Windows.Forms.ComboBox departmentIdComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn requistionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn remariksDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.ComboBox fromStoreComboBox;
        private System.Windows.Forms.Label fromStoreLabel;
        public System.Windows.Forms.ComboBox requisitionTypeComboBox;
        public System.Windows.Forms.ListBox lstRequsitions;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem itemBalancesToolStripMenuItem;
    }
}