namespace Belayab
{
    partial class frmPurchaseReqisition
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
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label perchaseReqNoLabel;
            System.Windows.Forms.Label supplierLabel;
            System.Windows.Forms.Label refrerenceLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label requestedByLabel;
            System.Windows.Forms.Label approvedByLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseReqisition));
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.perchaseReqNoTextBox = new System.Windows.Forms.TextBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrerenceComboBox = new System.Windows.Forms.ComboBox();
            this.mRequisitionNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.requestedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.purchaseRequisitionDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perchaseReqNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRequisitionDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bNavDetails = new System.Windows.Forms.BindingNavigator(this.components);
            this.bNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveDetails = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.supplierListTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.SupplierListTableAdapter();
            this.m_RequisitionNumbersTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.m_RequisitionNumbersTableAdapter();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.purchaseRequisitionDetailsTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PurchaseRequisitionDetailsTableAdapter();
            this.purchaseRequisitionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            perchaseReqNoLabel = new System.Windows.Forms.Label();
            supplierLabel = new System.Windows.Forms.Label();
            refrerenceLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            requestedByLabel = new System.Windows.Forms.Label();
            approvedByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRequisitionNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavDetails)).BeginInit();
            this.bNavDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(5, 547);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 60;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(5, 566);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(66, 13);
            updatedbyLabel.TabIndex = 61;
            updatedbyLabel.Text = "Updated By:";
            // 
            // perchaseReqNoLabel
            // 
            perchaseReqNoLabel.AutoSize = true;
            perchaseReqNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            perchaseReqNoLabel.Location = new System.Drawing.Point(16, 28);
            perchaseReqNoLabel.Name = "perchaseReqNoLabel";
            perchaseReqNoLabel.Size = new System.Drawing.Size(123, 15);
            perchaseReqNoLabel.TabIndex = 0;
            perchaseReqNoLabel.Text = "Perchase Req No:";
            // 
            // supplierLabel
            // 
            supplierLabel.AutoSize = true;
            supplierLabel.Location = new System.Drawing.Point(16, 54);
            supplierLabel.Name = "supplierLabel";
            supplierLabel.Size = new System.Drawing.Size(48, 13);
            supplierLabel.TabIndex = 2;
            supplierLabel.Text = "Supplier:";
            // 
            // refrerenceLabel
            // 
            refrerenceLabel.AutoSize = true;
            refrerenceLabel.Location = new System.Drawing.Point(16, 81);
            refrerenceLabel.Name = "refrerenceLabel";
            refrerenceLabel.Size = new System.Drawing.Size(63, 13);
            refrerenceLabel.TabIndex = 4;
            refrerenceLabel.Text = "Refrerence:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(16, 109);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 6;
            orderDateLabel.Text = "Order Date:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(391, 27);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "Status:";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(391, 122);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 10;
            remarksLabel.Text = "Remarks:";
            // 
            // requestedByLabel
            // 
            requestedByLabel.AutoSize = true;
            requestedByLabel.Location = new System.Drawing.Point(391, 57);
            requestedByLabel.Name = "requestedByLabel";
            requestedByLabel.Size = new System.Drawing.Size(77, 13);
            requestedByLabel.TabIndex = 12;
            requestedByLabel.Text = "Requested By:";
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.Location = new System.Drawing.Point(391, 84);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(71, 13);
            approvedByLabel.TabIndex = 14;
            approvedByLabel.Text = "Approved By:";
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(192)))));
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
            this.groupBox1.Controls.Add(this.remarksTextBox);
            this.groupBox1.Controls.Add(requestedByLabel);
            this.groupBox1.Controls.Add(this.requestedByComboBox);
            this.groupBox1.Controls.Add(approvedByLabel);
            this.groupBox1.Controls.Add(this.approvedByComboBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 186);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Main Info";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.purchaseRequisitionBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.saveToolStripButton,
            this.bindingNavigatorDeleteItem,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.bindingNavigator1.Location = new System.Drawing.Point(7, 158);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(313, 25);
            this.bindingNavigator1.TabIndex = 16;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // purchaseRequisitionBindingSource
            // 
            this.purchaseRequisitionBindingSource.DataMember = "PurchaseRequisition";
            this.purchaseRequisitionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // perchaseReqNoTextBox
            // 
            this.perchaseReqNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "PerchaseReqNo", true));
            this.perchaseReqNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perchaseReqNoTextBox.Location = new System.Drawing.Point(139, 25);
            this.perchaseReqNoTextBox.Name = "perchaseReqNoTextBox";
            this.perchaseReqNoTextBox.Size = new System.Drawing.Size(175, 21);
            this.perchaseReqNoTextBox.TabIndex = 1;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Supplier", true));
            this.supplierComboBox.DataSource = this.supplierListBindingSource;
            this.supplierComboBox.DisplayMember = "SupplierName";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(139, 51);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(187, 21);
            this.supplierComboBox.TabIndex = 3;
            this.supplierComboBox.ValueMember = "SupplierId";
            // 
            // supplierListBindingSource
            // 
            this.supplierListBindingSource.DataMember = "SupplierList";
            this.supplierListBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // refrerenceComboBox
            // 
            this.refrerenceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Refrerence", true));
            this.refrerenceComboBox.DataSource = this.mRequisitionNumbersBindingSource;
            this.refrerenceComboBox.DisplayMember = "RequisitionNumber";
            this.refrerenceComboBox.FormattingEnabled = true;
            this.refrerenceComboBox.Location = new System.Drawing.Point(139, 78);
            this.refrerenceComboBox.Name = "refrerenceComboBox";
            this.refrerenceComboBox.Size = new System.Drawing.Size(187, 21);
            this.refrerenceComboBox.TabIndex = 5;
            this.refrerenceComboBox.ValueMember = "RequisitionNumber";
            // 
            // mRequisitionNumbersBindingSource
            // 
            this.mRequisitionNumbersBindingSource.DataMember = "m_RequisitionNumbers";
            this.mRequisitionNumbersBindingSource.DataSource = this.belayAbSSDataSetBindingSource;
            // 
            // belayAbSSDataSetBindingSource
            // 
            this.belayAbSSDataSetBindingSource.DataSource = this.belayAbSSDataSet;
            this.belayAbSSDataSetBindingSource.Position = 0;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.orderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseRequisitionBindingSource, "OrderDate", true));
            this.orderDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(139, 105);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.orderDateDateTimePicker.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Status", true));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(492, 24);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 21);
            this.statusComboBox.TabIndex = 9;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(492, 119);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(246, 39);
            this.remarksTextBox.TabIndex = 11;
            // 
            // requestedByComboBox
            // 
            this.requestedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "RequestedBy", true));
            this.requestedByComboBox.DataSource = this.employeesLstBindingSource;
            this.requestedByComboBox.DisplayMember = "EmployeeName";
            this.requestedByComboBox.FormattingEnabled = true;
            this.requestedByComboBox.Location = new System.Drawing.Point(492, 54);
            this.requestedByComboBox.Name = "requestedByComboBox";
            this.requestedByComboBox.Size = new System.Drawing.Size(200, 21);
            this.requestedByComboBox.TabIndex = 13;
            this.requestedByComboBox.ValueMember = "EmployeeName";
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
            this.approvedByComboBox.Location = new System.Drawing.Point(492, 81);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(200, 21);
            this.approvedByComboBox.TabIndex = 15;
            this.approvedByComboBox.ValueMember = "EmployeeID";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 197);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 313);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.purchaseRequisitionDetailsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Purchase Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // purchaseRequisitionDetailsDataGridView
            // 
            this.purchaseRequisitionDetailsDataGridView.AllowUserToAddRows = false;
            this.purchaseRequisitionDetailsDataGridView.AllowUserToDeleteRows = false;
            this.purchaseRequisitionDetailsDataGridView.AutoGenerateColumns = false;
            this.purchaseRequisitionDetailsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.purchaseRequisitionDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.perchaseReqNoDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn});
            this.purchaseRequisitionDetailsDataGridView.DataSource = this.purchaseRequisitionDetailsBindingSource;
            this.purchaseRequisitionDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseRequisitionDetailsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.purchaseRequisitionDetailsDataGridView.Name = "purchaseRequisitionDetailsDataGridView";
            this.purchaseRequisitionDetailsDataGridView.Size = new System.Drawing.Size(762, 281);
            this.purchaseRequisitionDetailsDataGridView.TabIndex = 0;
            this.purchaseRequisitionDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.purchaseRequisitionDetailsDataGridView_DataError);
            this.purchaseRequisitionDetailsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.purchaseRequisitionDetailsDataGridView_EditingControlShowing);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "PartNumber";
            this.ItemID.DataSource = this.partNumDescriptionBindingSource;
            this.ItemID.DisplayMember = "Description";
            this.ItemID.DisplayStyleForCurrentCellOnly = true;
            this.ItemID.HeaderText = "Item";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemID.Width = 400;
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSetBindingSource;
            // 
            // perchaseReqNoDataGridViewTextBoxColumn
            // 
            this.perchaseReqNoDataGridViewTextBoxColumn.DataPropertyName = "PerchaseReqNo";
            this.perchaseReqNoDataGridViewTextBoxColumn.HeaderText = "PerchaseReqNo";
            this.perchaseReqNoDataGridViewTextBoxColumn.Name = "perchaseReqNoDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // purchaseRequisitionDetailsBindingSource
            // 
            this.purchaseRequisitionDetailsBindingSource.DataMember = "FK_PurchaseOrderDetails_PurchaseOrders";
            this.purchaseRequisitionDetailsBindingSource.DataSource = this.purchaseRequisitionBindingSource;
            // 
            // bNavDetails
            // 
            this.bNavDetails.AddNewItem = this.bNavAddnew;
            this.bNavDetails.BindingSource = this.purchaseRequisitionDetailsBindingSource;
            this.bNavDetails.CountItem = this.bindingNavigatorCountItem1;
            this.bNavDetails.DeleteItem = null;
            this.bNavDetails.Dock = System.Windows.Forms.DockStyle.None;
            this.bNavDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bNavAddnew,
            this.btnSaveDetails,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem1});
            this.bNavDetails.Location = new System.Drawing.Point(9, 511);
            this.bNavDetails.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bNavDetails.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bNavDetails.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bNavDetails.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bNavDetails.Name = "bNavDetails";
            this.bNavDetails.PositionItem = this.bindingNavigatorPositionItem1;
            this.bNavDetails.Size = new System.Drawing.Size(410, 25);
            this.bNavDetails.TabIndex = 15;
            this.bNavDetails.Text = "bindingNavigator1";
            // 
            // bNavAddnew
            // 
            this.bNavAddnew.Checked = true;
            this.bNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("bNavAddnew.Image")));
            this.bNavAddnew.Name = "bNavAddnew";
            this.bNavAddnew.RightToLeftAutoMirrorImage = true;
            this.bNavAddnew.Size = new System.Drawing.Size(74, 22);
            this.bNavAddnew.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
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
            // btnSaveDetails
            // 
            this.btnSaveDetails.Checked = true;
            this.btnSaveDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSaveDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveDetails.Image")));
            this.btnSaveDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDetails.Name = "btnSaveDetails";
            this.btnSaveDetails.Size = new System.Drawing.Size(51, 22);
            this.btnSaveDetails.Text = "Save";
            this.btnSaveDetails.Click += new System.EventHandler(this.btnSaveDetails_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
            this.toolStripLabel2.Text = " ";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.Checked = true;
            this.bindingNavigatorDeleteItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // supplierListTableAdapter
            // 
            this.supplierListTableAdapter.ClearBeforeFill = true;
            // 
            // m_RequisitionNumbersTableAdapter
            // 
            this.m_RequisitionNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(73, 547);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(198, 13);
            this.createdByTextBox.TabIndex = 62;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(73, 567);
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(198, 13);
            this.updatedbyTextBox.TabIndex = 63;
            // 
            // purchaseRequisitionDetailsTableAdapter
            // 
            this.purchaseRequisitionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseRequisitionTableAdapter
            // 
            this.purchaseRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // frmPurchaseReqisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 600);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.bNavDetails);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPurchaseReqisition";
            this.Text = "Purchase Requisition";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRequisitionNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavDetails)).EndInit();
            this.bNavDetails.ResumeLayout(false);
            this.bNavDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView purchaseRequisitionDetailsDataGridView;
        private System.Windows.Forms.BindingSource belayAbSSDataSetBindingSource;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.BindingNavigator bNavDetails;
        private System.Windows.Forms.ToolStripButton bNavAddnew;
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
        private System.Windows.Forms.ToolStripButton btnSaveDetails;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.BindingSource supplierListBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.SupplierListTableAdapter supplierListTableAdapter;
        private System.Windows.Forms.BindingSource mRequisitionNumbersBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.m_RequisitionNumbersTableAdapter m_RequisitionNumbersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        private BelayAbSSDataSetTableAdapters.PurchaseRequisitionDetailsTableAdapter purchaseRequisitionDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.BindingSource purchaseRequisitionBindingSource;
        private BelayAbSSDataSetTableAdapters.PurchaseRequisitionTableAdapter purchaseRequisitionTableAdapter;
        private System.Windows.Forms.TextBox perchaseReqNoTextBox;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.ComboBox refrerenceComboBox;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.ComboBox requestedByComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn perchaseReqNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource purchaseRequisitionDetailsBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}