namespace Belayab
{
    partial class frmIssue
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label issueRemarksLabel;
            System.Windows.Forms.Label issueNoLabel;
            System.Windows.Forms.Label issueDateLabel;
            System.Windows.Forms.Label preparedByLabel;
            System.Windows.Forms.Label approvedByLabel;
            System.Windows.Forms.Label requestedByLabel;
            System.Windows.Forms.Label issueTypeIdLabel;
            System.Windows.Forms.Label lblRefNumber;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label approvalStatusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.approvalStatusComboBox = new System.Windows.Forms.ComboBox();
            this.itemsIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboVouchureType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusTextbox = new System.Windows.Forms.TextBox();
            this.btnCloseActivate = new System.Windows.Forms.Button();
            this.btnUpdateRequests = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.issueRemarksTextBox = new System.Windows.Forms.TextBox();
            this.issueNoTextBox = new System.Windows.Forms.TextBox();
            this.issueDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.preparedByComboBox = new System.Windows.Forms.ComboBox();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.approvedByComboBox = new System.Windows.Forms.ComboBox();
            this.requestedByComboBox = new System.Windows.Forms.ComboBox();
            this.issueTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.issuetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.referenceNumberComboBox = new System.Windows.Forms.ComboBox();
            this.mainNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.MainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.MainNavFirst = new System.Windows.Forms.ToolStripButton();
            this.MainNavPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavPosition = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavSave = new System.Windows.Forms.ToolStripButton();
            this.MainNavDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrPrintIssue = new System.Windows.Forms.ToolStripButton();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsIssuedDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsIssuedTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedTableAdapter();
            this.itemsIssuedDetailsTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedDetailsTableAdapter();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.detailNavigtor = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAddAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.DetailNavAddNew = new System.Windows.Forms.ToolStripButton();
            this.DetailNavSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.DetailNavDelete = new System.Windows.Forms.ToolStripButton();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.DetailsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DetailGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuetypesTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.IssuetypesTableAdapter();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.lblWorkorders = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            issueRemarksLabel = new System.Windows.Forms.Label();
            issueNoLabel = new System.Windows.Forms.Label();
            issueDateLabel = new System.Windows.Forms.Label();
            preparedByLabel = new System.Windows.Forms.Label();
            approvedByLabel = new System.Windows.Forms.Label();
            requestedByLabel = new System.Windows.Forms.Label();
            issueTypeIdLabel = new System.Windows.Forms.Label();
            lblRefNumber = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            approvalStatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuetypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).BeginInit();
            this.mainNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).BeginInit();
            this.detailNavigtor.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(602, 549);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 20);
            label1.TabIndex = 36;
            label1.Text = "Total Price";
            // 
            // issueRemarksLabel
            // 
            issueRemarksLabel.AutoSize = true;
            issueRemarksLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            issueRemarksLabel.Location = new System.Drawing.Point(759, 77);
            issueRemarksLabel.Name = "issueRemarksLabel";
            issueRemarksLabel.Size = new System.Drawing.Size(60, 14);
            issueRemarksLabel.TabIndex = 40;
            issueRemarksLabel.Text = "Remarks:";
            // 
            // issueNoLabel
            // 
            issueNoLabel.AutoSize = true;
            issueNoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            issueNoLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issueNoLabel.Location = new System.Drawing.Point(53, 66);
            issueNoLabel.Name = "issueNoLabel";
            issueNoLabel.Size = new System.Drawing.Size(59, 15);
            issueNoLabel.TabIndex = 21;
            issueNoLabel.Text = "Issue No:";
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            issueDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issueDateLabel.Location = new System.Drawing.Point(42, 92);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new System.Drawing.Size(70, 15);
            issueDateLabel.TabIndex = 23;
            issueDateLabel.Text = "Issue Date:";
            // 
            // preparedByLabel
            // 
            preparedByLabel.AutoSize = true;
            preparedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            preparedByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preparedByLabel.Location = new System.Drawing.Point(33, 118);
            preparedByLabel.Name = "preparedByLabel";
            preparedByLabel.Size = new System.Drawing.Size(73, 15);
            preparedByLabel.TabIndex = 25;
            preparedByLabel.Text = "Store Chief:";
            // 
            // approvedByLabel
            // 
            approvedByLabel.AutoSize = true;
            approvedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            approvedByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            approvedByLabel.Location = new System.Drawing.Point(760, 44);
            approvedByLabel.Name = "approvedByLabel";
            approvedByLabel.Size = new System.Drawing.Size(81, 15);
            approvedByLabel.TabIndex = 27;
            approvedByLabel.Text = "Approved By:";
            // 
            // requestedByLabel
            // 
            requestedByLabel.AutoSize = true;
            requestedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            requestedByLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requestedByLabel.Location = new System.Drawing.Point(26, 145);
            requestedByLabel.Name = "requestedByLabel";
            requestedByLabel.Size = new System.Drawing.Size(88, 15);
            requestedByLabel.TabIndex = 29;
            requestedByLabel.Text = "Requested By:";
            // 
            // issueTypeIdLabel
            // 
            issueTypeIdLabel.AutoSize = true;
            issueTypeIdLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            issueTypeIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issueTypeIdLabel.Location = new System.Drawing.Point(442, 22);
            issueTypeIdLabel.Name = "issueTypeIdLabel";
            issueTypeIdLabel.Size = new System.Drawing.Size(87, 15);
            issueTypeIdLabel.TabIndex = 31;
            issueTypeIdLabel.Text = "Issue Reason:";
            // 
            // lblRefNumber
            // 
            lblRefNumber.AutoSize = true;
            lblRefNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            lblRefNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRefNumber.Location = new System.Drawing.Point(412, 46);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new System.Drawing.Size(117, 15);
            lblRefNumber.TabIndex = 33;
            lblRefNumber.Text = "Reference Number:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(8, 586);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(62, 13);
            createdByLabel.TabIndex = 60;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(7, 607);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(66, 13);
            updatedbyLabel.TabIndex = 61;
            updatedbyLabel.Text = "Updated By:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storeIDLabel.Location = new System.Drawing.Point(488, 75);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(45, 13);
            storeIDLabel.TabIndex = 45;
            storeIDLabel.Text = "Store: ";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stateLabel.Location = new System.Drawing.Point(836, 173);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(51, 13);
            stateLabel.TabIndex = 46;
            stateLabel.Text = "Status: ";
            stateLabel.Visible = false;
            // 
            // approvalStatusLabel
            // 
            approvalStatusLabel.AutoSize = true;
            approvalStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            approvalStatusLabel.Location = new System.Drawing.Point(787, 16);
            approvalStatusLabel.Name = "approvalStatusLabel";
            approvalStatusLabel.Size = new System.Drawing.Size(51, 15);
            approvalStatusLabel.TabIndex = 80;
            approvalStatusLabel.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 231);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(180)))));
            this.groupBox2.Controls.Add(approvalStatusLabel);
            this.groupBox2.Controls.Add(this.approvalStatusComboBox);
            this.groupBox2.Controls.Add(this.btnDelivery);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboVouchureType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.StatusTextbox);
            this.groupBox2.Controls.Add(this.btnCloseActivate);
            this.groupBox2.Controls.Add(this.btnUpdateRequests);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(stateLabel);
            this.groupBox2.Controls.Add(this.stateComboBox);
            this.groupBox2.Controls.Add(storeIDLabel);
            this.groupBox2.Controls.Add(this.storeIDComboBox);
            this.groupBox2.Controls.Add(this.chkAuto);
            this.groupBox2.Controls.Add(this.issueRemarksTextBox);
            this.groupBox2.Controls.Add(issueRemarksLabel);
            this.groupBox2.Controls.Add(issueNoLabel);
            this.groupBox2.Controls.Add(this.issueNoTextBox);
            this.groupBox2.Controls.Add(issueDateLabel);
            this.groupBox2.Controls.Add(this.issueDateDateTimePicker);
            this.groupBox2.Controls.Add(preparedByLabel);
            this.groupBox2.Controls.Add(this.preparedByComboBox);
            this.groupBox2.Controls.Add(approvedByLabel);
            this.groupBox2.Controls.Add(this.approvedByComboBox);
            this.groupBox2.Controls.Add(requestedByLabel);
            this.groupBox2.Controls.Add(this.requestedByComboBox);
            this.groupBox2.Controls.Add(issueTypeIdLabel);
            this.groupBox2.Controls.Add(this.issueTypeIdComboBox);
            this.groupBox2.Controls.Add(lblRefNumber);
            this.groupBox2.Controls.Add(this.referenceNumberComboBox);
            this.groupBox2.Controls.Add(this.mainNavigator);
            this.groupBox2.Location = new System.Drawing.Point(-2, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1074, 226);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issuing Main Information";
            // 
            // approvalStatusComboBox
            // 
            this.approvalStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "ApprovalStatus", true));
            this.approvalStatusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalStatusComboBox.FormattingEnabled = true;
            this.approvalStatusComboBox.Items.AddRange(new object[] {
            "New",
            "Approved"});
            this.approvalStatusComboBox.Location = new System.Drawing.Point(845, 13);
            this.approvalStatusComboBox.Name = "approvalStatusComboBox";
            this.approvalStatusComboBox.Size = new System.Drawing.Size(144, 23);
            this.approvalStatusComboBox.TabIndex = 81;
            this.approvalStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.approvalStatusComboBox_SelectedIndexChanged);
            // 
            // itemsIssuedBindingSource
            // 
            this.itemsIssuedBindingSource.DataMember = "ItemsIssued";
            this.itemsIssuedBindingSource.DataSource = this.belayAbSSDataSet;
            this.itemsIssuedBindingSource.PositionChanged += new System.EventHandler(this.itemsIssuedBindingSource_PositionChanged);
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelivery
            // 
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Location = new System.Drawing.Point(762, 164);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(131, 32);
            this.btnDelivery.TabIndex = 80;
            this.btnDelivery.Text = " Deliver";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Visible = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Voucher Type";
            // 
            // cboVouchureType
            // 
            this.cboVouchureType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "VoucherType", true));
            this.cboVouchureType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVouchureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVouchureType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cboVouchureType.FormattingEnabled = true;
            this.cboVouchureType.Items.AddRange(new object[] {
            "Import",
            "Local",
            "InOut",
            "Cannibalized"});
            this.cboVouchureType.Location = new System.Drawing.Point(119, 22);
            this.cboVouchureType.Name = "cboVouchureType";
            this.cboVouchureType.Size = new System.Drawing.Size(147, 23);
            this.cboVouchureType.TabIndex = 78;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "Edit Status";
            this.label11.Visible = false;
            // 
            // StatusTextbox
            // 
            this.StatusTextbox.Enabled = false;
            this.StatusTextbox.Location = new System.Drawing.Point(536, 99);
            this.StatusTextbox.Name = "StatusTextbox";
            this.StatusTextbox.ReadOnly = true;
            this.StatusTextbox.Size = new System.Drawing.Size(136, 20);
            this.StatusTextbox.TabIndex = 76;
            this.StatusTextbox.TabStop = false;
            this.StatusTextbox.Visible = false;
            // 
            // btnCloseActivate
            // 
            this.btnCloseActivate.Location = new System.Drawing.Point(674, 98);
            this.btnCloseActivate.Name = "btnCloseActivate";
            this.btnCloseActivate.Size = new System.Drawing.Size(63, 23);
            this.btnCloseActivate.TabIndex = 75;
            this.btnCloseActivate.Text = "Close";
            this.btnCloseActivate.UseVisualStyleBackColor = true;
            this.btnCloseActivate.Visible = false;
            // 
            // btnUpdateRequests
            // 
            this.btnUpdateRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRequests.Location = new System.Drawing.Point(577, 173);
            this.btnUpdateRequests.Name = "btnUpdateRequests";
            this.btnUpdateRequests.Size = new System.Drawing.Size(138, 23);
            this.btnUpdateRequests.TabIndex = 65;
            this.btnUpdateRequests.Text = "Update Workorders";
            this.btnUpdateRequests.UseVisualStyleBackColor = true;
            this.btnUpdateRequests.Visible = false;
            this.btnUpdateRequests.Click += new System.EventHandler(this.btnUpdateRequests_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(996, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "State", true));
            this.stateComboBox.DisplayMember = "State";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.stateComboBox.Enabled = false;
            this.stateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(893, 166);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(138, 30);
            this.stateComboBox.TabIndex = 47;
            this.stateComboBox.ValueMember = "State";
            this.stateComboBox.Visible = false;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged);
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsIssuedBindingSource, "StoreID", true));
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.Enabled = false;
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(536, 72);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(160, 21);
            this.storeIDComboBox.TabIndex = 46;
            this.storeIDComboBox.ValueMember = "StoreID";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuto.Location = new System.Drawing.Point(266, 66);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(56, 17);
            this.chkAuto.TabIndex = 45;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // issueRemarksTextBox
            // 
            this.issueRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "IssueRemarks", true));
            this.issueRemarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueRemarksTextBox.Location = new System.Drawing.Point(760, 90);
            this.issueRemarksTextBox.Multiline = true;
            this.issueRemarksTextBox.Name = "issueRemarksTextBox";
            this.issueRemarksTextBox.Size = new System.Drawing.Size(271, 62);
            this.issueRemarksTextBox.TabIndex = 41;
            // 
            // issueNoTextBox
            // 
            this.issueNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "IssueNo", true));
            this.issueNoTextBox.Enabled = false;
            this.issueNoTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueNoTextBox.Location = new System.Drawing.Point(118, 63);
            this.issueNoTextBox.Name = "issueNoTextBox";
            this.issueNoTextBox.Size = new System.Drawing.Size(142, 21);
            this.issueNoTextBox.TabIndex = 0;
            // 
            // issueDateDateTimePicker
            // 
            this.issueDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.issueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemsIssuedBindingSource, "IssueDate", true));
            this.issueDateDateTimePicker.Enabled = false;
            this.issueDateDateTimePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issueDateDateTimePicker.Location = new System.Drawing.Point(118, 89);
            this.issueDateDateTimePicker.Name = "issueDateDateTimePicker";
            this.issueDateDateTimePicker.Size = new System.Drawing.Size(154, 21);
            this.issueDateDateTimePicker.TabIndex = 1;
            // 
            // preparedByComboBox
            // 
            this.preparedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.preparedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.preparedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsIssuedBindingSource, "PreparedBy", true));
            this.preparedByComboBox.DataSource = this.employeesLstBindingSource;
            this.preparedByComboBox.DisplayMember = "EmployeeName";
            this.preparedByComboBox.Enabled = false;
            this.preparedByComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preparedByComboBox.FormattingEnabled = true;
            this.preparedByComboBox.Location = new System.Drawing.Point(119, 115);
            this.preparedByComboBox.Name = "preparedByComboBox";
            this.preparedByComboBox.Size = new System.Drawing.Size(164, 23);
            this.preparedByComboBox.TabIndex = 2;
            this.preparedByComboBox.ValueMember = "EmployeeId";
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
            this.approvedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.approvedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.approvedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "ApprovedBy", true));
            this.approvedByComboBox.DisplayMember = "EmployeeName";
            this.approvedByComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvedByComboBox.FormattingEnabled = true;
            this.approvedByComboBox.Location = new System.Drawing.Point(845, 41);
            this.approvedByComboBox.Name = "approvedByComboBox";
            this.approvedByComboBox.Size = new System.Drawing.Size(164, 23);
            this.approvedByComboBox.TabIndex = 3;
            this.approvedByComboBox.ValueMember = "EmployeeName";
            // 
            // requestedByComboBox
            // 
            this.requestedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.requestedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.requestedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "RequestedBy", true));
            this.requestedByComboBox.DisplayMember = "EmployeeName";
            this.requestedByComboBox.Enabled = false;
            this.requestedByComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestedByComboBox.FormattingEnabled = true;
            this.requestedByComboBox.Location = new System.Drawing.Point(118, 142);
            this.requestedByComboBox.Name = "requestedByComboBox";
            this.requestedByComboBox.Size = new System.Drawing.Size(179, 23);
            this.requestedByComboBox.TabIndex = 4;
            this.requestedByComboBox.ValueMember = "EmployeeId";
            // 
            // issueTypeIdComboBox
            // 
            this.issueTypeIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.issueTypeIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.issueTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsIssuedBindingSource, "IssueTypeId", true));
            this.issueTypeIdComboBox.DataSource = this.issuetypesBindingSource;
            this.issueTypeIdComboBox.DisplayMember = "IssueType";
            this.issueTypeIdComboBox.Enabled = false;
            this.issueTypeIdComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueTypeIdComboBox.FormattingEnabled = true;
            this.issueTypeIdComboBox.Location = new System.Drawing.Point(536, 14);
            this.issueTypeIdComboBox.Name = "issueTypeIdComboBox";
            this.issueTypeIdComboBox.Size = new System.Drawing.Size(179, 23);
            this.issueTypeIdComboBox.TabIndex = 5;
            this.issueTypeIdComboBox.ValueMember = "IssueTypeID";
            this.issueTypeIdComboBox.SelectedIndexChanged += new System.EventHandler(this.issueTypeIdComboBox_SelectedIndexChanged);
            this.issueTypeIdComboBox.TextChanged += new System.EventHandler(this.issueTypeIdComboBox_SelectedIndexChanged);
            // 
            // issuetypesBindingSource
            // 
            this.issuetypesBindingSource.DataMember = "Issuetypes";
            this.issuetypesBindingSource.DataSource = this.belayAbInvoices;
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referenceNumberComboBox
            // 
            this.referenceNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.referenceNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.referenceNumberComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "ReferenceNumber", true));
            this.referenceNumberComboBox.Enabled = false;
            this.referenceNumberComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNumberComboBox.FormattingEnabled = true;
            this.referenceNumberComboBox.Location = new System.Drawing.Point(536, 43);
            this.referenceNumberComboBox.Name = "referenceNumberComboBox";
            this.referenceNumberComboBox.Size = new System.Drawing.Size(179, 23);
            this.referenceNumberComboBox.TabIndex = 6;
            this.referenceNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.referenceNumberComboBox_SelectedIndexChanged);
            this.referenceNumberComboBox.TextChanged += new System.EventHandler(this.referenceNumberComboBox_SelectedIndexChanged);
            // 
            // mainNavigator
            // 
            this.mainNavigator.AddNewItem = this.MainNavAddnew;
            this.mainNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainNavigator.BindingSource = this.itemsIssuedBindingSource;
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
            this.MainNavSave,
            this.MainNavDelete,
            this.toolStrPrintIssue});
            this.mainNavigator.Location = new System.Drawing.Point(4, 173);
            this.mainNavigator.MoveFirstItem = this.MainNavFirst;
            this.mainNavigator.MoveLastItem = this.toolStripButton6;
            this.mainNavigator.MoveNextItem = this.toolStripButton5;
            this.mainNavigator.MovePreviousItem = this.MainNavPrevious;
            this.mainNavigator.Name = "mainNavigator";
            this.mainNavigator.PositionItem = this.MainNavPosition;
            this.mainNavigator.Size = new System.Drawing.Size(595, 27);
            this.mainNavigator.TabIndex = 20;
            this.mainNavigator.Text = "bindingNavigator1";
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Enabled = false;
            this.MainNavAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(95, 24);
            this.MainNavAddnew.Tag = "btn";
            this.MainNavAddnew.Text = "Add new";
            this.MainNavAddnew.Click += new System.EventHandler(this.MainNavAddnew_Click);
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
            // MainNavSave
            // 
            this.MainNavSave.Enabled = false;
            this.MainNavSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavSave.Image = ((System.Drawing.Image)(resources.GetObject("MainNavSave.Image")));
            this.MainNavSave.Name = "MainNavSave";
            this.MainNavSave.Size = new System.Drawing.Size(109, 24);
            this.MainNavSave.Tag = "btn";
            this.MainNavSave.Text = "Save Data";
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
            this.MainNavDelete.Text = "Delete";
            this.MainNavDelete.Click += new System.EventHandler(this.DeleteWrap_Click);
            // 
            // toolStrPrintIssue
            // 
            this.toolStrPrintIssue.Enabled = false;
            this.toolStrPrintIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStrPrintIssue.Image = ((System.Drawing.Image)(resources.GetObject("toolStrPrintIssue.Image")));
            this.toolStrPrintIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrPrintIssue.Name = "toolStrPrintIssue";
            this.toolStrPrintIssue.Size = new System.Drawing.Size(67, 24);
            this.toolStrPrintIssue.Tag = "btn";
            this.toolStrPrintIssue.Text = "Print";
            this.toolStrPrintIssue.Click += new System.EventHandler(this.toolStrPrintIssue_Click);
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // itemsIssuedDetailsBindingSource
            // 
            this.itemsIssuedDetailsBindingSource.DataMember = "FK_ItemsIssuedDetails_ItemsIssued";
            this.itemsIssuedDetailsBindingSource.DataSource = this.itemsIssuedBindingSource;
            // 
            // itemsIssuedTableAdapter
            // 
            this.itemsIssuedTableAdapter.ClearBeforeFill = true;
            // 
            // itemsIssuedDetailsTableAdapter
            // 
            this.itemsIssuedDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // detailNavigtor
            // 
            this.detailNavigtor.AddNewItem = null;
            this.detailNavigtor.BindingSource = this.itemsIssuedDetailsBindingSource;
            this.detailNavigtor.CountItem = this.bindingNavigatorCountItem1;
            this.detailNavigtor.DeleteItem = null;
            this.detailNavigtor.Dock = System.Windows.Forms.DockStyle.None;
            this.detailNavigtor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.detailNavigtor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAll,
            this.toolStripSeparator4,
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.DetailNavAddNew,
            this.DetailNavSave,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.DetailNavDelete});
            this.detailNavigtor.Location = new System.Drawing.Point(8, 546);
            this.detailNavigtor.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.detailNavigtor.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.detailNavigtor.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.detailNavigtor.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.detailNavigtor.Name = "detailNavigtor";
            this.detailNavigtor.PositionItem = this.bindingNavigatorPositionItem1;
            this.detailNavigtor.Size = new System.Drawing.Size(428, 27);
            this.detailNavigtor.TabIndex = 37;
            this.detailNavigtor.Text = "bindingNavigator1";
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
            this.btnAddAll.Checked = true;
            this.btnAddAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAddAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(66, 24);
            this.btnAddAll.Text = "++Add All";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
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
            // DetailNavAddNew
            // 
            this.DetailNavAddNew.Checked = true;
            this.DetailNavAddNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DetailNavAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetailNavAddNew.Enabled = false;
            this.DetailNavAddNew.Image = ((System.Drawing.Image)(resources.GetObject("DetailNavAddNew.Image")));
            this.DetailNavAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailNavAddNew.Name = "DetailNavAddNew";
            this.DetailNavAddNew.Size = new System.Drawing.Size(44, 24);
            this.DetailNavAddNew.Tag = "btn";
            this.DetailNavAddNew.Text = "+ Add";
            this.DetailNavAddNew.Click += new System.EventHandler(this.toolStripDetailAddNnew_Click);
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
            this.DetailNavSave.Text = "Save";
            this.DetailNavSave.Click += new System.EventHandler(this.toolStrSaveDetails_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // DetailNavDelete
            // 
            this.DetailNavDelete.Checked = true;
            this.DetailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DetailNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DetailNavDelete.Enabled = false;
            this.DetailNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("DetailNavDelete.Image")));
            this.DetailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DetailNavDelete.Name = "DetailNavDelete";
            this.DetailNavDelete.Size = new System.Drawing.Size(52, 24);
            this.DetailNavDelete.Tag = "btn";
            this.DetailNavDelete.Text = "- Delete";
            this.DetailNavDelete.Click += new System.EventHandler(this.toolStrpDelete_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(701, 546);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 24);
            this.txtTotal.TabIndex = 39;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.DetailsTab.Controls.Add(this.tabPage1);
            this.DetailsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTab.Location = new System.Drawing.Point(3, 214);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(1042, 332);
            this.DetailsTab.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.DetailGridView);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Issued Items";
            // 
            // DetailGridView
            // 
            this.DetailGridView.AllowUserToAddRows = false;
            this.DetailGridView.AllowUserToDeleteRows = false;
            this.DetailGridView.AutoGenerateColumns = false;
            this.DetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.Units,
            this.HD,
            this.InStock,
            this.RequestedQty,
            this.Qty,
            this.UnitPrice,
            this.TotalPrice,
            this.dataGridViewTextBoxColumn8,
            this.Edited,
            this.dataGridViewTextBoxColumn1});
            this.DetailGridView.DataSource = this.itemsIssuedDetailsBindingSource;
            this.DetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailGridView.Enabled = false;
            this.DetailGridView.Location = new System.Drawing.Point(3, 3);
            this.DetailGridView.Name = "DetailGridView";
            this.DetailGridView.Size = new System.Drawing.Size(1028, 295);
            this.DetailGridView.TabIndex = 0;
            this.DetailGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DetailGridView_CellBeginEdit);
            this.DetailGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.invoiceDetailsDataGridView_CellValidating);
            this.DetailGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailsDataGridView_CellValueChanged_1);
            this.DetailGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DetailGridView_ColumnHeaderMouseClick);
            this.DetailGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.itemsIssuedDetailsDataGridView_DataError);
            this.DetailGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsIssuedDetailsDataGridView_RowValidated);
            this.DetailGridView.Sorted += new System.EventHandler(this.DetailGridView_Sorted);
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
            this.ItemID.Width = 300;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 50;
            // 
            // HD
            // 
            this.HD.DataPropertyName = "HD";
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.HD.Visible = false;
            // 
            // InStock
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 80;
            // 
            // RequestedQty
            // 
            this.RequestedQty.DataPropertyName = "RequestedQty";
            this.RequestedQty.HeaderText = "Req. Qty";
            this.RequestedQty.Name = "RequestedQty";
            this.RequestedQty.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "IssuedQty";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qty.HeaderText = "Issued Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 80;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0";
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 105;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // Edited
            // 
            this.Edited.HeaderText = "Column1";
            this.Edited.Name = "Edited";
            this.Edited.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IssueNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IssueNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // issuetypesTableAdapter
            // 
            this.issuetypesTableAdapter.ClearBeforeFill = true;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "CreatedBy", true));
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(75, 584);
            this.createdByTextBox.Multiline = true;
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(313, 19);
            this.createdByTextBox.TabIndex = 62;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsIssuedBindingSource, "UpdatedBy", true));
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(76, 607);
            this.updatedbyTextBox.Multiline = true;
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(312, 17);
            this.updatedbyTextBox.TabIndex = 63;
            // 
            // lblWorkorders
            // 
            this.lblWorkorders.AutoSize = true;
            this.lblWorkorders.Location = new System.Drawing.Point(445, 554);
            this.lblWorkorders.Name = "lblWorkorders";
            this.lblWorkorders.Size = new System.Drawing.Size(10, 13);
            this.lblWorkorders.TabIndex = 64;
            this.lblWorkorders.Text = " ";
            // 
            // frmIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(190)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1072, 633);
            this.Controls.Add(this.lblWorkorders);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.DetailsTab);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.detailNavigtor);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmIssue";
            this.Text = "Items Issuing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIssue_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuetypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).EndInit();
            this.mainNavigator.ResumeLayout(false);
            this.mainNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).EndInit();
            this.detailNavigtor.ResumeLayout(false);
            this.detailNavigtor.PerformLayout();
            this.DetailsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BelayAbSSDataSet belayAbSSDataSet;
        private Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedTableAdapter itemsIssuedTableAdapter;
        private System.Windows.Forms.BindingSource itemsIssuedDetailsBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedDetailsTableAdapter itemsIssuedDetailsTableAdapter;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.BindingNavigator detailNavigtor;
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
        private System.Windows.Forms.TextBox issueRemarksTextBox;
        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator mainNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton MainNavFirst;
        private System.Windows.Forms.ToolStripButton MainNavPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox MainNavPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.TextBox issueNoTextBox;
        private System.Windows.Forms.DateTimePicker issueDateDateTimePicker;
        private System.Windows.Forms.ComboBox preparedByComboBox;
        private System.Windows.Forms.ComboBox approvedByComboBox;
        private System.Windows.Forms.ComboBox requestedByComboBox;
        private System.Windows.Forms.ComboBox issueTypeIdComboBox;
        private BelayAbInvoices belayAbInvoices;
        private System.Windows.Forms.BindingSource issuetypesBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.IssuetypesTableAdapter issuetypesTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStrPrintIssue;
        public System.Windows.Forms.ToolStripButton DetailNavSave;
        public System.Windows.Forms.DataGridView DetailGridView;
        public System.Windows.Forms.ToolStripButton DetailNavDelete;
        public System.Windows.Forms.ToolStripButton MainNavAddnew;
        public System.Windows.Forms.ToolStripButton MainNavDelete;
        public System.Windows.Forms.ToolStripButton MainNavSave;
        public System.Windows.Forms.ToolStripButton DetailNavAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.ToolStripButton btnAddAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.DataGridViewComboBoxColumn PartNumber;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label lblWorkorders;
        public System.Windows.Forms.BindingSource itemsIssuedBindingSource;
        private System.Windows.Forms.Button btnUpdateRequests;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edited;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StatusTextbox;
        private System.Windows.Forms.Button btnCloseActivate;
        public System.Windows.Forms.ComboBox referenceNumberComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboVouchureType;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.ComboBox approvalStatusComboBox;
    }
}