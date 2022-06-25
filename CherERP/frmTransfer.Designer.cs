namespace Belayab
{
    partial class frmTransfer
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
            System.Windows.Forms.Label itemTransferNoLabel;
            System.Windows.Forms.Label itemTransferDateLabel;
            System.Windows.Forms.Label fromStoreLabel;
            System.Windows.Forms.Label toStoreLabel;
            System.Windows.Forms.Label issuedByLabel;
            System.Windows.Forms.Label receivedByLabel;
            System.Windows.Forms.Label approvedByLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label referenceNumberLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label itemReceivedDateLabel;
            System.Windows.Forms.Label remarksLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.belayAbReceived = new Belayab.BelayAbReceived();
            this.storeTransferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeTransferTableAdapter = new Belayab.BelayAbReceivedTableAdapters.StoreTransferTableAdapter();
            this.itemTransferNoTextBox = new System.Windows.Forms.TextBox();
            this.itemTransferDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromStoreComboBox = new System.Windows.Forms.ComboBox();
            this.toStoreComboBox = new System.Windows.Forms.ComboBox();
            this.issuedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.receivedByComboBox = new System.Windows.Forms.ComboBox();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.storeTransferDetalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.allStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.MainNavFirst = new System.Windows.Forms.ToolStripButton();
            this.MainNavPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavPosition = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.itemsReceivedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteWrap = new System.Windows.Forms.ToolStripButton();
            this.toolStrPrintInvoice = new System.Windows.Forms.ToolStripButton();
            this.DetailNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonAddAll = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.detailNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.detailNavSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.detailNavDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.storeTransferDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TransferedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.remarksTextBox1 = new System.Windows.Forms.TextBox();
            this.itemReceivedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSendItems = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusTextbox = new System.Windows.Forms.TextBox();
            this.btnCloseActivate = new System.Windows.Forms.Button();
            this.referenceNumberComboBox = new System.Windows.Forms.ComboBox();
            this.storeTransferDetailsTableAdapter = new Belayab.BelayAbReceivedTableAdapters.StoreTransferDetailsTableAdapter();
            this.allStatesTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.AllStatesTableAdapter();
            itemTransferNoLabel = new System.Windows.Forms.Label();
            itemTransferDateLabel = new System.Windows.Forms.Label();
            fromStoreLabel = new System.Windows.Forms.Label();
            toStoreLabel = new System.Windows.Forms.Label();
            issuedByLabel = new System.Windows.Forms.Label();
            receivedByLabel = new System.Windows.Forms.Label();
            approvedByLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            referenceNumberLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            itemReceivedDateLabel = new System.Windows.Forms.Label();
            remarksLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferDetalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).BeginInit();
            this.mainNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailNavigator)).BeginInit();
            this.DetailNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferDetailsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemTransferNoLabel
            // 
            itemTransferNoLabel.AutoSize = true;
            itemTransferNoLabel.Location = new System.Drawing.Point(26, 24);
            itemTransferNoLabel.Name = "itemTransferNoLabel";
            itemTransferNoLabel.Size = new System.Drawing.Size(89, 13);
            itemTransferNoLabel.TabIndex = 1;
            itemTransferNoLabel.Text = "Item Transfer No:";
            // 
            // itemTransferDateLabel
            // 
            itemTransferDateLabel.AutoSize = true;
            itemTransferDateLabel.Location = new System.Drawing.Point(17, 53);
            itemTransferDateLabel.Name = "itemTransferDateLabel";
            itemTransferDateLabel.Size = new System.Drawing.Size(98, 13);
            itemTransferDateLabel.TabIndex = 3;
            itemTransferDateLabel.Text = "Item Transfer Date:";
            // 
            // fromStoreLabel
            // 
            fromStoreLabel.AutoSize = true;
            fromStoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fromStoreLabel.Location = new System.Drawing.Point(304, 25);
            fromStoreLabel.Name = "fromStoreLabel";
            fromStoreLabel.Size = new System.Drawing.Size(77, 16);
            fromStoreLabel.TabIndex = 5;
            fromStoreLabel.Text = "From Store:";
            // 
            // toStoreLabel
            // 
            toStoreLabel.AutoSize = true;
            toStoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            toStoreLabel.Location = new System.Drawing.Point(318, 54);
            toStoreLabel.Name = "toStoreLabel";
            toStoreLabel.Size = new System.Drawing.Size(63, 16);
            toStoreLabel.TabIndex = 7;
            toStoreLabel.Text = "To Store:";
            // 
            // issuedByLabel
            // 
            issuedByLabel.AutoSize = true;
            issuedByLabel.Location = new System.Drawing.Point(596, 27);
            issuedByLabel.Name = "issuedByLabel";
            issuedByLabel.Size = new System.Drawing.Size(56, 13);
            issuedByLabel.TabIndex = 9;
            issuedByLabel.Text = "Issued By:";
            // 
            // receivedByLabel
            // 
            receivedByLabel.AutoSize = true;
            receivedByLabel.Location = new System.Drawing.Point(581, 55);
            receivedByLabel.Name = "receivedByLabel";
            receivedByLabel.Size = new System.Drawing.Size(71, 13);
            receivedByLabel.TabIndex = 11;
            receivedByLabel.Text = "Received By:";
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.Location = new System.Drawing.Point(581, 84);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(71, 13);
            approvedByLabel.TabIndex = 13;
            approvedByLabel.Text = "Approved By:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(72, 119);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 20;
            statusLabel.Text = "Status:";
            // 
            // referenceNumberLabel
            // 
            referenceNumberLabel.AutoSize = true;
            referenceNumberLabel.Location = new System.Drawing.Point(278, 83);
            referenceNumberLabel.Name = "referenceNumberLabel";
            referenceNumberLabel.Size = new System.Drawing.Size(100, 13);
            referenceNumberLabel.TabIndex = 29;
            referenceNumberLabel.Text = "Reference Number:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(8, 294);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 64;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(7, 315);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(66, 13);
            updatedbyLabel.TabIndex = 65;
            updatedbyLabel.Text = "Updated By:";
            // 
            // itemReceivedDateLabel
            // 
            itemReceivedDateLabel.AutoSize = true;
            itemReceivedDateLabel.Location = new System.Drawing.Point(11, 79);
            itemReceivedDateLabel.Name = "itemReceivedDateLabel";
            itemReceivedDateLabel.Size = new System.Drawing.Size(105, 13);
            itemReceivedDateLabel.TabIndex = 82;
            itemReceivedDateLabel.Text = "Item Received Date:";
            // 
            // remarksLabel1
            // 
            remarksLabel1.AutoSize = true;
            remarksLabel1.Location = new System.Drawing.Point(581, 119);
            remarksLabel1.Name = "remarksLabel1";
            remarksLabel1.Size = new System.Drawing.Size(52, 13);
            remarksLabel1.TabIndex = 83;
            remarksLabel1.Text = "Remarks:";
            // 
            // belayAbReceived
            // 
            this.belayAbReceived.DataSetName = "BelayAbReceived";
            this.belayAbReceived.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeTransferBindingSource
            // 
            this.storeTransferBindingSource.DataMember = "StoreTransfer";
            this.storeTransferBindingSource.DataSource = this.belayAbReceived;
            this.storeTransferBindingSource.PositionChanged += new System.EventHandler(this.storeTransferBindingSource_PositionChanged);
            // 
            // storeTransferTableAdapter
            // 
            this.storeTransferTableAdapter.ClearBeforeFill = true;
            // 
            // itemTransferNoTextBox
            // 
            this.itemTransferNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "StoreTransferNo", true));
            this.itemTransferNoTextBox.Location = new System.Drawing.Point(121, 21);
            this.itemTransferNoTextBox.Name = "itemTransferNoTextBox";
            this.itemTransferNoTextBox.Size = new System.Drawing.Size(136, 20);
            this.itemTransferNoTextBox.TabIndex = 2;
            // 
            // itemTransferDateDateTimePicker
            // 
            this.itemTransferDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.itemTransferDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storeTransferBindingSource, "ItemTransferDate", true));
            this.itemTransferDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemTransferDateDateTimePicker.Location = new System.Drawing.Point(122, 49);
            this.itemTransferDateDateTimePicker.Name = "itemTransferDateDateTimePicker";
            this.itemTransferDateDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.itemTransferDateDateTimePicker.TabIndex = 4;
            // 
            // fromStoreComboBox
            // 
            this.fromStoreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.storeTransferBindingSource, "FromStore", true));
            this.fromStoreComboBox.DisplayMember = "StoreName";
            this.fromStoreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStoreComboBox.FormattingEnabled = true;
            this.fromStoreComboBox.Location = new System.Drawing.Point(382, 22);
            this.fromStoreComboBox.Name = "fromStoreComboBox";
            this.fromStoreComboBox.Size = new System.Drawing.Size(164, 23);
            this.fromStoreComboBox.TabIndex = 6;
            this.fromStoreComboBox.ValueMember = "StoreId";
            this.fromStoreComboBox.SelectedIndexChanged += new System.EventHandler(this.fromStoreComboBox_SelectedIndexChanged);
            // 
            // toStoreComboBox
            // 
            this.toStoreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.storeTransferBindingSource, "ToStore", true));
            this.toStoreComboBox.DisplayMember = "StoreName";
            this.toStoreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStoreComboBox.FormattingEnabled = true;
            this.toStoreComboBox.Location = new System.Drawing.Point(382, 51);
            this.toStoreComboBox.Name = "toStoreComboBox";
            this.toStoreComboBox.Size = new System.Drawing.Size(164, 23);
            this.toStoreComboBox.TabIndex = 8;
            this.toStoreComboBox.ValueMember = "StoreId";
            this.toStoreComboBox.SelectedIndexChanged += new System.EventHandler(this.toStoreComboBox_SelectedIndexChanged);
            // 
            // issuedByComboBox
            // 
            this.issuedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.storeTransferBindingSource, "IssuedBy", true));
            this.issuedByComboBox.DataSource = this.employeesLstBindingSource;
            this.issuedByComboBox.DisplayMember = "EmployeeName";
            this.issuedByComboBox.Enabled = false;
            this.issuedByComboBox.FormattingEnabled = true;
            this.issuedByComboBox.Location = new System.Drawing.Point(662, 21);
            this.issuedByComboBox.Name = "issuedByComboBox";
            this.issuedByComboBox.Size = new System.Drawing.Size(158, 21);
            this.issuedByComboBox.TabIndex = 10;
            this.issuedByComboBox.ValueMember = "EmployeeName";
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
            // receivedByComboBox
            // 
            this.receivedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "ReceivedBy", true));
            this.receivedByComboBox.DataSource = this.employeesLstBindingSource;
            this.receivedByComboBox.DisplayMember = "EmployeeName";
            this.receivedByComboBox.Enabled = false;
            this.receivedByComboBox.FormattingEnabled = true;
            this.receivedByComboBox.Location = new System.Drawing.Point(662, 49);
            this.receivedByComboBox.Name = "receivedByComboBox";
            this.receivedByComboBox.Size = new System.Drawing.Size(158, 21);
            this.receivedByComboBox.TabIndex = 12;
            this.receivedByComboBox.ValueMember = "EmployeeId";
            // 
            // approvedByComboBox
            // 
            this.approvedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "ApprovedBy", true));
            this.approvedByComboBox.DataSource = this.employeesLstBindingSource;
            this.approvedByComboBox.DisplayMember = "EmployeeName";
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(662, 78);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(158, 21);
            this.approvedByComboBox.TabIndex = 14;
            this.approvedByComboBox.ValueMember = "EmployeeId";
            // 
            // storeTransferDetalsBindingSource
            // 
            this.storeTransferDetalsBindingSource.DataMember = "FK_StoreTransferDetails_StoreTransfer";
            this.storeTransferDetalsBindingSource.DataSource = this.storeTransferBindingSource;
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
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "Status", true));
            this.statusComboBox.DataSource = this.allStatesBindingSource;
            this.statusComboBox.DisplayMember = "State";
            this.statusComboBox.Enabled = false;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(123, 113);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(134, 21);
            this.statusComboBox.TabIndex = 21;
            this.statusComboBox.ValueMember = "State";
            // 
            // allStatesBindingSource
            // 
            this.allStatesBindingSource.DataMember = "AllStates";
            this.allStatesBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // mainNavigator
            // 
            this.mainNavigator.AddNewItem = null;
            this.mainNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainNavigator.BindingSource = this.storeTransferBindingSource;
            this.mainNavigator.CountItem = this.toolStripLabel2;
            this.mainNavigator.DeleteItem = null;
            this.mainNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.mainNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainNavFirst,
            this.MainNavPrevious,
            this.toolStripSeparator6,
            this.MainNavPosition,
            this.toolStripLabel2,
            this.toolStripSeparator7,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.MainNavAddnew,
            this.itemsReceivedBindingNavigatorSaveItem,
            this.DeleteWrap,
            this.toolStrPrintInvoice});
            this.mainNavigator.Location = new System.Drawing.Point(8, 149);
            this.mainNavigator.MoveFirstItem = this.MainNavFirst;
            this.mainNavigator.MoveLastItem = this.toolStripButton8;
            this.mainNavigator.MoveNextItem = this.toolStripButton7;
            this.mainNavigator.MovePreviousItem = this.MainNavPrevious;
            this.mainNavigator.Name = "mainNavigator";
            this.mainNavigator.PositionItem = this.MainNavPosition;
            this.mainNavigator.Size = new System.Drawing.Size(575, 25);
            this.mainNavigator.TabIndex = 29;
            this.mainNavigator.Text = "ManNav";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // MainNavFirst
            // 
            this.MainNavFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavFirst.Image = ((System.Drawing.Image)(resources.GetObject("MainNavFirst.Image")));
            this.MainNavFirst.Name = "MainNavFirst";
            this.MainNavFirst.RightToLeftAutoMirrorImage = true;
            this.MainNavFirst.Size = new System.Drawing.Size(23, 22);
            this.MainNavFirst.Text = "Move first";
            // 
            // MainNavPrevious
            // 
            this.MainNavPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavPrevious.Image = ((System.Drawing.Image)(resources.GetObject("MainNavPrevious.Image")));
            this.MainNavPrevious.Name = "MainNavPrevious";
            this.MainNavPrevious.RightToLeftAutoMirrorImage = true;
            this.MainNavPrevious.Size = new System.Drawing.Size(23, 22);
            this.MainNavPrevious.Text = "Move previous";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // MainNavPosition
            // 
            this.MainNavPosition.AccessibleName = "Position";
            this.MainNavPosition.AutoSize = false;
            this.MainNavPosition.Name = "MainNavPosition";
            this.MainNavPosition.Size = new System.Drawing.Size(50, 21);
            this.MainNavPosition.Text = "0";
            this.MainNavPosition.ToolTipText = "Current position";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Enabled = false;
            this.MainNavAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(91, 22);
            this.MainNavAddnew.Text = "Add new";
            this.MainNavAddnew.Visible = false;
            this.MainNavAddnew.Click += new System.EventHandler(this.MainNavAddnew_Click);
            // 
            // itemsReceivedBindingNavigatorSaveItem
            // 
            this.itemsReceivedBindingNavigatorSaveItem.Enabled = false;
            this.itemsReceivedBindingNavigatorSaveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.itemsReceivedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsReceivedBindingNavigatorSaveItem.Image")));
            this.itemsReceivedBindingNavigatorSaveItem.Name = "itemsReceivedBindingNavigatorSaveItem";
            this.itemsReceivedBindingNavigatorSaveItem.Size = new System.Drawing.Size(105, 22);
            this.itemsReceivedBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsReceivedBindingNavigatorSaveItem.Click += new System.EventHandler(this.storeTransferBindingNavigatorSaveItem_Click);
            // 
            // DeleteWrap
            // 
            this.DeleteWrap.Enabled = false;
            this.DeleteWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWrap.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWrap.Image")));
            this.DeleteWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteWrap.Name = "DeleteWrap";
            this.DeleteWrap.Size = new System.Drawing.Size(76, 22);
            this.DeleteWrap.Text = "Delete";
            this.DeleteWrap.Click += new System.EventHandler(this.DeleteWrap_Click);
            // 
            // toolStrPrintInvoice
            // 
            this.toolStrPrintInvoice.Enabled = false;
            this.toolStrPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStrPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("toolStrPrintInvoice.Image")));
            this.toolStrPrintInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrPrintInvoice.Name = "toolStrPrintInvoice";
            this.toolStrPrintInvoice.Size = new System.Drawing.Size(63, 22);
            this.toolStrPrintInvoice.Text = "Print";
            this.toolStrPrintInvoice.Click += new System.EventHandler(this.toolStrPrintInvoice_Click);
            // 
            // DetailNavigator
            // 
            this.DetailNavigator.AddNewItem = null;
            this.DetailNavigator.BindingSource = this.storeTransferDetalsBindingSource;
            this.DetailNavigator.CountItem = this.bindingNavigatorCountItem1;
            this.DetailNavigator.DeleteItem = null;
            this.DetailNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.DetailNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddAll,
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.detailNavAddnew,
            this.detailNavSave,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.detailNavDelete});
            this.DetailNavigator.Location = new System.Drawing.Point(8, 259);
            this.DetailNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.DetailNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.DetailNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.DetailNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.DetailNavigator.Name = "DetailNavigator";
            this.DetailNavigator.PositionItem = this.bindingNavigatorPositionItem1;
            this.DetailNavigator.Size = new System.Drawing.Size(438, 25);
            this.DetailNavigator.TabIndex = 31;
            this.DetailNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // toolStripButtonAddAll
            // 
            this.toolStripButtonAddAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddAll.Image")));
            this.toolStripButtonAddAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddAll.Name = "toolStripButtonAddAll";
            this.toolStripButtonAddAll.Size = new System.Drawing.Size(50, 22);
            this.toolStripButtonAddAll.Text = "Add All";
            this.toolStripButtonAddAll.Click += new System.EventHandler(this.toolStripButtonAddAll_Click);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // detailNavAddnew
            // 
            this.detailNavAddnew.Checked = true;
            this.detailNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavAddnew.Enabled = false;
            this.detailNavAddnew.Image = global::Belayab.Properties.Resources.bindingNavigatorAddNewItem2_Image;
            this.detailNavAddnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavAddnew.Name = "detailNavAddnew";
            this.detailNavAddnew.Size = new System.Drawing.Size(49, 22);
            this.detailNavAddnew.Text = "Add";
            this.detailNavAddnew.Click += new System.EventHandler(this.detailNavAddnew_Click);
            // 
            // detailNavSave
            // 
            this.detailNavSave.Checked = true;
            this.detailNavSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavSave.Enabled = false;
            this.detailNavSave.Image = global::Belayab.Properties.Resources.bNavSaveCats_Image;
            this.detailNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavSave.Name = "detailNavSave";
            this.detailNavSave.Size = new System.Drawing.Size(51, 22);
            this.detailNavSave.Text = "Save";
            this.detailNavSave.Click += new System.EventHandler(this.detailNavSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel3.Text = "  ";
            // 
            // detailNavDelete
            // 
            this.detailNavDelete.Checked = true;
            this.detailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavDelete.Enabled = false;
            this.detailNavDelete.Image = global::Belayab.Properties.Resources.bindingNavigatorDeleteItem_Image;
            this.detailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavDelete.Name = "detailNavDelete";
            this.detailNavDelete.Size = new System.Drawing.Size(60, 22);
            this.detailNavDelete.Text = "Delete";
            this.detailNavDelete.Click += new System.EventHandler(this.detailNavDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.createdByTextBox);
            this.groupBox1.Controls.Add(createdByLabel);
            this.groupBox1.Controls.Add(this.updatedbyTextBox);
            this.groupBox1.Controls.Add(updatedbyLabel);
            this.groupBox1.Controls.Add(this.storeTransferDetailsDataGridView);
            this.groupBox1.Controls.Add(this.DetailNavigator);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 341);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfered Items";
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(75, 292);
            this.createdByTextBox.Multiline = true;
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(313, 17);
            this.createdByTextBox.TabIndex = 66;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(76, 315);
            this.updatedbyTextBox.Multiline = true;
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(312, 16);
            this.updatedbyTextBox.TabIndex = 67;
            // 
            // storeTransferDetailsDataGridView
            // 
            this.storeTransferDetailsDataGridView.AllowUserToAddRows = false;
            this.storeTransferDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.storeTransferDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.storeTransferDetailsDataGridView.AutoGenerateColumns = false;
            this.storeTransferDetailsDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.storeTransferDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeTransferDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.TransferedQty,
            this.InStock,
            this.dataGridViewTextBoxColumn8});
            this.storeTransferDetailsDataGridView.DataSource = this.storeTransferDetalsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.storeTransferDetailsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.storeTransferDetailsDataGridView.Location = new System.Drawing.Point(8, 19);
            this.storeTransferDetailsDataGridView.Name = "storeTransferDetailsDataGridView";
            this.storeTransferDetailsDataGridView.Size = new System.Drawing.Size(1026, 240);
            this.storeTransferDetailsDataGridView.TabIndex = 31;
            this.storeTransferDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.storeTransferDetailsDataGridView_CellValueChanged);
            this.storeTransferDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.storeTransferDetailsDataGridView_DataError);
            this.storeTransferDetailsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.storeTransferDetailsDataGridView_EditingControlShowing);
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
            this.ItemID.Width = 400;
            // 
            // TransferedQty
            // 
            this.TransferedQty.DataPropertyName = "Quantity";
            this.TransferedQty.HeaderText = "Quantity";
            this.TransferedQty.Name = "TransferedQty";
            // 
            // InStock
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.InStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(remarksLabel1);
            this.groupBox2.Controls.Add(this.remarksTextBox1);
            this.groupBox2.Controls.Add(itemReceivedDateLabel);
            this.groupBox2.Controls.Add(this.itemReceivedDateDateTimePicker);
            this.groupBox2.Controls.Add(this.btnSendItems);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.StatusTextbox);
            this.groupBox2.Controls.Add(this.btnCloseActivate);
            this.groupBox2.Controls.Add(referenceNumberLabel);
            this.groupBox2.Controls.Add(this.referenceNumberComboBox);
            this.groupBox2.Controls.Add(this.mainNavigator);
            this.groupBox2.Controls.Add(statusLabel);
            this.groupBox2.Controls.Add(this.statusComboBox);
            this.groupBox2.Controls.Add(itemTransferNoLabel);
            this.groupBox2.Controls.Add(this.itemTransferNoTextBox);
            this.groupBox2.Controls.Add(itemTransferDateLabel);
            this.groupBox2.Controls.Add(this.itemTransferDateDateTimePicker);
            this.groupBox2.Controls.Add(fromStoreLabel);
            this.groupBox2.Controls.Add(this.fromStoreComboBox);
            this.groupBox2.Controls.Add(toStoreLabel);
            this.groupBox2.Controls.Add(this.toStoreComboBox);
            this.groupBox2.Controls.Add(issuedByLabel);
            this.groupBox2.Controls.Add(this.issuedByComboBox);
            this.groupBox2.Controls.Add(receivedByLabel);
            this.groupBox2.Controls.Add(this.receivedByComboBox);
            this.groupBox2.Controls.Add(approvedByLabel);
            this.groupBox2.Controls.Add(this.approvedByComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1494, 177);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer Info";
            // 
            // remarksTextBox1
            // 
            this.remarksTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "Remarks", true));
            this.remarksTextBox1.Location = new System.Drawing.Point(634, 116);
            this.remarksTextBox1.Multiline = true;
            this.remarksTextBox1.Name = "remarksTextBox1";
            this.remarksTextBox1.Size = new System.Drawing.Size(400, 58);
            this.remarksTextBox1.TabIndex = 84;
            // 
            // itemReceivedDateDateTimePicker
            // 
            this.itemReceivedDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.itemReceivedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.storeTransferBindingSource, "ItemReceivedDate", true));
            this.itemReceivedDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.itemReceivedDateDateTimePicker.Location = new System.Drawing.Point(122, 75);
            this.itemReceivedDateDateTimePicker.Name = "itemReceivedDateDateTimePicker";
            this.itemReceivedDateDateTimePicker.Size = new System.Drawing.Size(136, 20);
            this.itemReceivedDateDateTimePicker.TabIndex = 83;
            // 
            // btnSendItems
            // 
            this.btnSendItems.Location = new System.Drawing.Point(866, 34);
            this.btnSendItems.Name = "btnSendItems";
            this.btnSendItems.Size = new System.Drawing.Size(110, 50);
            this.btnSendItems.TabIndex = 82;
            this.btnSendItems.Text = "Send Items";
            this.btnSendItems.UseVisualStyleBackColor = true;
            this.btnSendItems.Visible = false;
            this.btnSendItems.Click += new System.EventHandler(this.btnSendItems_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(875, 19);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(110, 50);
            this.btnReceive.TabIndex = 81;
            this.btnReceive.Text = "Recieve";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Visible = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(707, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Status";
            this.label11.Visible = false;
            // 
            // StatusTextbox
            // 
            this.StatusTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "ActionStatus", true));
            this.StatusTextbox.Enabled = false;
            this.StatusTextbox.Location = new System.Drawing.Point(263, 114);
            this.StatusTextbox.Name = "StatusTextbox";
            this.StatusTextbox.ReadOnly = true;
            this.StatusTextbox.Size = new System.Drawing.Size(79, 20);
            this.StatusTextbox.TabIndex = 79;
            this.StatusTextbox.TabStop = false;
            this.StatusTextbox.TextChanged += new System.EventHandler(this.StatusTextbox_TextChanged);
            // 
            // btnCloseActivate
            // 
            this.btnCloseActivate.Location = new System.Drawing.Point(341, 112);
            this.btnCloseActivate.Name = "btnCloseActivate";
            this.btnCloseActivate.Size = new System.Drawing.Size(63, 23);
            this.btnCloseActivate.TabIndex = 78;
            this.btnCloseActivate.Text = "Close";
            this.btnCloseActivate.UseVisualStyleBackColor = true;
            this.btnCloseActivate.Click += new System.EventHandler(this.btnCloseActivate_Click);
            // 
            // referenceNumberComboBox
            // 
            this.referenceNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "ReferenceNumber", true));
            this.referenceNumberComboBox.FormattingEnabled = true;
            this.referenceNumberComboBox.Location = new System.Drawing.Point(384, 80);
            this.referenceNumberComboBox.Name = "referenceNumberComboBox";
            this.referenceNumberComboBox.Size = new System.Drawing.Size(162, 21);
            this.referenceNumberComboBox.TabIndex = 30;
            this.referenceNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.referenceNumberComboBox_SelectedIndexChanged);
            this.referenceNumberComboBox.TextUpdate += new System.EventHandler(this.referenceNumberComboBox_TextUpdate);
            // 
            // storeTransferDetailsTableAdapter
            // 
            this.storeTransferDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // allStatesTableAdapter
            // 
            this.allStatesTableAdapter.ClearBeforeFill = true;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 546);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.storeTransferBindingSource, "ActionStatus", true));
            this.Name = "frmTransfer";
            this.Text = "Store Item Transfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferDetalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).EndInit();
            this.mainNavigator.ResumeLayout(false);
            this.mainNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailNavigator)).EndInit();
            this.DetailNavigator.ResumeLayout(false);
            this.DetailNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeTransferDetailsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BelayAbReceived belayAbReceived;
        private Belayab.BelayAbReceivedTableAdapters.StoreTransferTableAdapter storeTransferTableAdapter;
        private System.Windows.Forms.TextBox itemTransferNoTextBox;
        private System.Windows.Forms.DateTimePicker itemTransferDateDateTimePicker;
        private System.Windows.Forms.ComboBox issuedByComboBox;
        private System.Windows.Forms.ComboBox receivedByComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.BindingSource storeTransferDetalsBindingSource;
        private Belayab.BelayAbReceivedTableAdapters.StoreTransferDetailsTableAdapter storeTransferDetalsTableAdapter;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingNavigator mainNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton MainNavFirst;
        private System.Windows.Forms.ToolStripButton MainNavPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox MainNavPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton MainNavAddnew;
        private System.Windows.Forms.ToolStripButton itemsReceivedBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton DeleteWrap;
        private System.Windows.Forms.ToolStripButton toolStrPrintInvoice;
           private System.Windows.Forms.BindingNavigator DetailNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton detailNavAddnew;
        private System.Windows.Forms.ToolStripButton detailNavSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton detailNavDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Belayab.BelayAbReceivedTableAdapters.StoreTransferDetailsTableAdapter storeTransferDetailsTableAdapter;
        private System.Windows.Forms.DataGridView storeTransferDetailsDataGridView;
        private System.Windows.Forms.BindingSource allStatesBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.AllStatesTableAdapter allStatesTableAdapter;
        public System.Windows.Forms.BindingSource storeTransferBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddAll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StatusTextbox;
        private System.Windows.Forms.Button btnCloseActivate;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        public System.Windows.Forms.Button btnReceive;
        public System.Windows.Forms.Button btnSendItems;
        public System.Windows.Forms.ComboBox fromStoreComboBox;
        public System.Windows.Forms.ComboBox toStoreComboBox;
        public System.Windows.Forms.ComboBox referenceNumberComboBox;
        private System.Windows.Forms.DateTimePicker itemReceivedDateDateTimePicker;
        private System.Windows.Forms.TextBox remarksTextBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}