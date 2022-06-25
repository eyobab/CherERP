namespace Belayab
{
    partial class frmInvoicesCredit
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
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label payTypeIdLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label checkedByLabel;
            System.Windows.Forms.Label cashierLabel;
            System.Windows.Forms.Label checkNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoicesCredit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkNumberTextBox = new System.Windows.Forms.TextBox();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.cashierComboBox = new System.Windows.Forms.ComboBox();
            this.checkedByComboBox = new System.Windows.Forms.ComboBox();
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
            this.itemsReceivedBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.DeleteWrap = new System.Windows.Forms.ToolStripButton();
            this.toolStrPrintInvoice = new System.Windows.Forms.ToolStripButton();
            this.salesPersonIdComboBox = new System.Windows.Forms.ComboBox();
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.paymentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.totCreditAmtTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefreshItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetPrices = new System.Windows.Forms.ToolStripMenuItem();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detailNavigtor = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.detailNavDelete = new System.Windows.Forms.ToolStripButton();
            this.invoicesTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.InvoicesTableAdapter();
            this.invoiceDetailsTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.InvoiceDetailsTableAdapter();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.employeesLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter();
            this.paymentTypesTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.paymentTypesTableAdapter();
            this.customerListTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.CustomerListTableAdapter();
            this.DetailsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPayments = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtTotWithVAT = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.invoices_CreditTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.Invoices_CreditTableAdapter();
            this.invoiceDetails_CreditTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.InvoiceDetails_CreditTableAdapter();
            invoiceDateLabel = new System.Windows.Forms.Label();
            payTypeIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            checkedByLabel = new System.Windows.Forms.Label();
            cashierLabel = new System.Windows.Forms.Label();
            checkNumberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).BeginInit();
            this.mainNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).BeginInit();
            this.detailNavigtor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            this.DetailsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceDateLabel.Location = new System.Drawing.Point(518, 122);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(79, 15);
            invoiceDateLabel.TabIndex = 4;
            invoiceDateLabel.Text = "Invoice Date:";
            // 
            // payTypeIdLabel
            // 
            payTypeIdLabel.AutoSize = true;
            payTypeIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payTypeIdLabel.Location = new System.Drawing.Point(15, 64);
            payTypeIdLabel.Name = "payTypeIdLabel";
            payTypeIdLabel.Size = new System.Drawing.Size(77, 15);
            payTypeIdLabel.TabIndex = 8;
            payTypeIdLabel.Text = "Invoice Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(611, 537);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 20);
            label1.TabIndex = 34;
            label1.Text = "Total Price";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(7, 30);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(99, 15);
            customerIdLabel.TabIndex = 25;
            customerIdLabel.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(612, 563);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 47;
            label2.Text = "VAT(15%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(584, 590);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(125, 20);
            label3.TabIndex = 49;
            label3.Text = "Total with VAT";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(527, 539);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(60, 15);
            discountLabel.TabIndex = 55;
            discountLabel.Text = "Discount:";
            discountLabel.Visible = false;
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceNoLabel.Location = new System.Drawing.Point(25, 95);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(65, 15);
            invoiceNoLabel.TabIndex = 0;
            invoiceNoLabel.Text = "Invoice No";
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarksLabel.Location = new System.Drawing.Point(10, 565);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(62, 15);
            remarksLabel.TabIndex = 62;
            remarksLabel.Text = "Remarks:";
            // 
            // checkedByLabel
            // 
            checkedByLabel.AutoSize = true;
            checkedByLabel.Location = new System.Drawing.Point(509, 56);
            checkedByLabel.Name = "checkedByLabel";
            checkedByLabel.Size = new System.Drawing.Size(87, 16);
            checkedByLabel.TabIndex = 28;
            checkedByLabel.Text = "Checked By:";
            // 
            // cashierLabel
            // 
            cashierLabel.AutoSize = true;
            cashierLabel.Location = new System.Drawing.Point(542, 88);
            cashierLabel.Name = "cashierLabel";
            cashierLabel.Size = new System.Drawing.Size(60, 16);
            cashierLabel.TabIndex = 29;
            cashierLabel.Text = "Cashier:";
            // 
            // checkNumberLabel
            // 
            checkNumberLabel.AutoSize = true;
            checkNumberLabel.Location = new System.Drawing.Point(9, 128);
            checkNumberLabel.Name = "checkNumberLabel";
            checkNumberLabel.Size = new System.Drawing.Size(101, 16);
            checkNumberLabel.TabIndex = 29;
            checkNumberLabel.Text = "Check Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 211);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.chkAuto);
            this.groupBox1.Controls.Add(this.btnEditCustomers);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(checkNumberLabel);
            this.groupBox1.Controls.Add(this.checkNumberTextBox);
            this.groupBox1.Controls.Add(this.invoiceNoTextBox);
            this.groupBox1.Controls.Add(cashierLabel);
            this.groupBox1.Controls.Add(this.cashierComboBox);
            this.groupBox1.Controls.Add(checkedByLabel);
            this.groupBox1.Controls.Add(this.checkedByComboBox);
            this.groupBox1.Controls.Add(this.mainNavigator);
            this.groupBox1.Controls.Add(this.salesPersonIdComboBox);
            this.groupBox1.Controls.Add(customerIdLabel);
            this.groupBox1.Controls.Add(this.customerIdComboBox);
            this.groupBox1.Controls.Add(invoiceNoLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(invoiceDateLabel);
            this.groupBox1.Controls.Add(this.invoiceDateDateTimePicker);
            this.groupBox1.Controls.Add(payTypeIdLabel);
            this.groupBox1.Controls.Add(this.payTypeIdComboBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(35, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Invoice Info";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(285, 96);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(60, 20);
            this.chkAuto.TabIndex = 45;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCustomers.Location = new System.Drawing.Point(379, 27);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(32, 21);
            this.btnEditCustomers.TabIndex = 43;
            this.btnEditCustomers.Text = "...";
            this.toolTip.SetToolTip(this.btnEditCustomers, "Edit Customers");
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // checkNumberTextBox
            // 
            this.checkNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CheckNumber", true));
            this.checkNumberTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkNumberTextBox.Location = new System.Drawing.Point(109, 125);
            this.checkNumberTextBox.Name = "checkNumberTextBox";
            this.checkNumberTextBox.Size = new System.Drawing.Size(164, 25);
            this.checkNumberTextBox.TabIndex = 30;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices_Credit";
            this.invoicesBindingSource.DataSource = this.belayAbInvoices;
            this.invoicesBindingSource.CurrentChanged += new System.EventHandler(this.invoicesBindingSource_CurrentChanged);
            this.invoicesBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.invoicesBindingSource_AddingNew);
            this.invoicesBindingSource.PositionChanged += new System.EventHandler(this.invoicesBindingSource_PositionChanged);
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.AllowDrop = true;
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Enabled = false;
            this.invoiceNoTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(109, 91);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(164, 25);
            this.invoiceNoTextBox.TabIndex = 2;
            // 
            // cashierComboBox
            // 
            this.cashierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cashierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cashierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Cashier", true));
            this.cashierComboBox.DisplayMember = "EmployeeName";
            this.cashierComboBox.Enabled = false;
            this.cashierComboBox.FormattingEnabled = true;
            this.cashierComboBox.Location = new System.Drawing.Point(602, 85);
            this.cashierComboBox.Name = "cashierComboBox";
            this.cashierComboBox.Size = new System.Drawing.Size(164, 24);
            this.cashierComboBox.TabIndex = 5;
            this.cashierComboBox.ValueMember = "EmployeeName";
            // 
            // checkedByComboBox
            // 
            this.checkedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.checkedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.checkedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CheckedBy", true));
            this.checkedByComboBox.DisplayMember = "Employeename";
            this.checkedByComboBox.Enabled = false;
            this.checkedByComboBox.FormattingEnabled = true;
            this.checkedByComboBox.Location = new System.Drawing.Point(602, 53);
            this.checkedByComboBox.Name = "checkedByComboBox";
            this.checkedByComboBox.Size = new System.Drawing.Size(164, 24);
            this.checkedByComboBox.TabIndex = 4;
            this.checkedByComboBox.ValueMember = "EmployeeName";
            // 
            // mainNavigator
            // 
            this.mainNavigator.AddNewItem = null;
            this.mainNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mainNavigator.BindingSource = this.invoicesBindingSource;
            this.mainNavigator.CountItem = this.toolStripLabel1;
            this.mainNavigator.DeleteItem = null;
            this.mainNavigator.Dock = System.Windows.Forms.DockStyle.None;
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
            this.itemsReceivedBindingNavigatorSaveItem,
            this.DeleteWrap,
            this.toolStrPrintInvoice});
            this.mainNavigator.Location = new System.Drawing.Point(127, 157);
            this.mainNavigator.MoveFirstItem = this.MainNavFirst;
            this.mainNavigator.MoveLastItem = this.toolStripButton6;
            this.mainNavigator.MoveNextItem = this.toolStripButton5;
            this.mainNavigator.MovePreviousItem = this.MainNavPrevious;
            this.mainNavigator.Name = "mainNavigator";
            this.mainNavigator.PositionItem = this.MainNavPosition;
            this.mainNavigator.Size = new System.Drawing.Size(543, 25);
            this.mainNavigator.TabIndex = 28;
            this.mainNavigator.Text = "ManNav";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.MainNavAddnew.Click += new System.EventHandler(this.tooStripAddnew_Click);
            // 
            // itemsReceivedBindingNavigatorSaveItem
            // 
            this.itemsReceivedBindingNavigatorSaveItem.Enabled = false;
            this.itemsReceivedBindingNavigatorSaveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.itemsReceivedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsReceivedBindingNavigatorSaveItem.Image")));
            this.itemsReceivedBindingNavigatorSaveItem.Name = "itemsReceivedBindingNavigatorSaveItem";
            this.itemsReceivedBindingNavigatorSaveItem.Size = new System.Drawing.Size(105, 22);
            this.itemsReceivedBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsReceivedBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsReceivedBindingNavigatorSaveItem_Click);
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
            // salesPersonIdComboBox
            // 
            this.salesPersonIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.salesPersonIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.salesPersonIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "SalesPersonId", true));
            this.salesPersonIdComboBox.DisplayMember = "EmployeeName";
            this.salesPersonIdComboBox.Enabled = false;
            this.salesPersonIdComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPersonIdComboBox.FormattingEnabled = true;
            this.salesPersonIdComboBox.Location = new System.Drawing.Point(602, 20);
            this.salesPersonIdComboBox.Name = "salesPersonIdComboBox";
            this.salesPersonIdComboBox.Size = new System.Drawing.Size(164, 23);
            this.salesPersonIdComboBox.TabIndex = 3;
            this.salesPersonIdComboBox.ValueMember = "EmployeeID";
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "CustomerId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.customerIdComboBox.DataSource = this.customerListBindingSource;
            this.customerIdComboBox.DisplayMember = "CustomerName";
            this.customerIdComboBox.DropDownWidth = 160;
            this.customerIdComboBox.Enabled = false;
            this.customerIdComboBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(109, 27);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(265, 23);
            this.customerIdComboBox.TabIndex = 0;
            this.customerIdComboBox.ValueMember = "CustomerId";
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataMember = "CustomerList";
            this.customerListBindingSource.DataSource = this.belayAbInvoices;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prepared By";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Enabled = false;
            this.invoiceDateDateTimePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(603, 117);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(163, 21);
            this.invoiceDateDateTimePicker.TabIndex = 6;
            this.invoiceDateDateTimePicker.Value = new System.DateTime(2007, 6, 17, 0, 0, 0, 0);
            // 
            // payTypeIdComboBox
            // 
            this.payTypeIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.payTypeIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.payTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "PayTypeId", true));
            this.payTypeIdComboBox.DataSource = this.paymentTypesBindingSource;
            this.payTypeIdComboBox.DisplayMember = "PayTypeId";
            this.payTypeIdComboBox.Enabled = false;
            this.payTypeIdComboBox.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTypeIdComboBox.ForeColor = System.Drawing.Color.Blue;
            this.payTypeIdComboBox.FormattingEnabled = true;
            this.payTypeIdComboBox.Location = new System.Drawing.Point(109, 59);
            this.payTypeIdComboBox.Name = "payTypeIdComboBox";
            this.payTypeIdComboBox.Size = new System.Drawing.Size(173, 25);
            this.payTypeIdComboBox.TabIndex = 1;
            this.payTypeIdComboBox.ValueMember = "PayTypeId";
            // 
            // paymentTypesBindingSource
            // 
            this.paymentTypesBindingSource.DataMember = "paymentTypes";
            this.paymentTypesBindingSource.DataSource = this.belayAbInvoices;
            // 
            // belayAbItemRequistionsBindingSource
            // 
            this.belayAbItemRequistionsBindingSource.DataSource = this.belayAbItemRequistions;
            this.belayAbItemRequistionsBindingSource.Position = 0;
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totCreditAmtTextBox
            // 
            this.totCreditAmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "TotCreditAmt", true));
            this.totCreditAmtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totCreditAmtTextBox.Location = new System.Drawing.Point(370, 182);
            this.totCreditAmtTextBox.Name = "totCreditAmtTextBox";
            this.totCreditAmtTextBox.ReadOnly = true;
            this.totCreditAmtTextBox.Size = new System.Drawing.Size(114, 24);
            this.totCreditAmtTextBox.TabIndex = 11;
            this.totCreditAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // invoiceDetailsBindingSource
            // 
            this.invoiceDetailsBindingSource.DataMember = "FK_InvoiceDetails_Credit_Invoices_Credit";
            this.invoiceDetailsBindingSource.DataSource = this.invoicesBindingSource;
            this.invoiceDetailsBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.invoiceDetailsBindingSource_DataError);
            // 
            // invoiceDetailsDataGridView
            // 
            this.invoiceDetailsDataGridView.AllowUserToAddRows = false;
            this.invoiceDetailsDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            this.invoiceDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invoiceDetailsDataGridView.AutoGenerateColumns = false;
            this.invoiceDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.PartNumber,
            this.Units,
            this.InStock,
            this.Qty,
            this.UnitPrice,
            this.TotalPrice,
            this.Remark,
            this.HD,
            this.Edited});
            this.invoiceDetailsDataGridView.DataSource = this.invoiceDetailsBindingSource;
            this.invoiceDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDetailsDataGridView.Enabled = false;
            this.invoiceDetailsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.invoiceDetailsDataGridView.Name = "invoiceDetailsDataGridView";
            this.invoiceDetailsDataGridView.Size = new System.Drawing.Size(932, 291);
            this.invoiceDetailsDataGridView.TabIndex = 0;
            this.invoiceDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailsDataGridView_CellValueChanged_1);
            this.invoiceDetailsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.invoiceDetailsDataGridView_CellBeginEdit);
            this.invoiceDetailsDataGridView.Sorted += new System.EventHandler(this.invoiceDetailsDataGridView_Sorted);
            this.invoiceDetailsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invoiceDetailsDataGridView_ColumnHeaderMouseClick);
            this.invoiceDetailsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.invoiceDetailsDataGridView_CellValidating);
            this.invoiceDetailsDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailsDataGridView_RowValidated);
            this.invoiceDetailsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.invoiceDetailsDataGridView_EditingControlShowing);
            this.invoiceDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.invoiceDetailsDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // PartNumber
            // 
            this.PartNumber.ContextMenuStrip = this.contextMenuStrip1;
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.DataSource = this.partNumDescriptionBindingSource;
            this.PartNumber.DisplayMember = "Description";
            this.PartNumber.DisplayStyleForCurrentCellOnly = true;
            this.PartNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartNumber.HeaderText = "Item";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PartNumber.ValueMember = "PartNumber";
            this.PartNumber.Width = 320;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshItems,
            this.mnuEditItem,
            this.allItemsToolStripMenuItem,
            this.mnuSetPrices});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 92);
            // 
            // mnuRefreshItems
            // 
            this.mnuRefreshItems.Name = "mnuRefreshItems";
            this.mnuRefreshItems.Size = new System.Drawing.Size(153, 22);
            this.mnuRefreshItems.Text = "Refresh Items";
            this.mnuRefreshItems.Click += new System.EventHandler(this.mnuRefreshItems_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(153, 22);
            this.mnuEditItem.Text = "Edit Item(s)";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // allItemsToolStripMenuItem
            // 
            this.allItemsToolStripMenuItem.Name = "allItemsToolStripMenuItem";
            this.allItemsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.allItemsToolStripMenuItem.Text = "Find Item";
            this.allItemsToolStripMenuItem.Click += new System.EventHandler(this.allItemsToolStripMenuItem_Click);
            // 
            // mnuSetPrices
            // 
            this.mnuSetPrices.Name = "mnuSetPrices";
            this.mnuSetPrices.Size = new System.Drawing.Size(153, 22);
            this.mnuSetPrices.Text = "Set Prices";
            this.mnuSetPrices.Click += new System.EventHandler(this.mnuSetPrices_Click);
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
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 85;
            // 
            // InStock
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 95;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "Br #,##0.00";
            dataGridViewCellStyle5.NullValue = "0";
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 101;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            // 
            // HD
            // 
            this.HD.DataPropertyName = "HD";
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.HD.Visible = false;
            // 
            // Edited
            // 
            this.Edited.HeaderText = "Column1";
            this.Edited.Name = "Edited";
            this.Edited.Visible = false;
            // 
            // detailNavigtor
            // 
            this.detailNavigtor.AddNewItem = null;
            this.detailNavigtor.BindingSource = this.invoiceDetailsBindingSource;
            this.detailNavigtor.CountItem = this.bindingNavigatorCountItem1;
            this.detailNavigtor.DeleteItem = null;
            this.detailNavigtor.Dock = System.Windows.Forms.DockStyle.None;
            this.detailNavigtor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.detailNavDelete});
            this.detailNavigtor.Location = new System.Drawing.Point(6, 534);
            this.detailNavigtor.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.detailNavigtor.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.detailNavigtor.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.detailNavigtor.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.detailNavigtor.Name = "detailNavigtor";
            this.detailNavigtor.PositionItem = this.bindingNavigatorPositionItem1;
            this.detailNavigtor.Size = new System.Drawing.Size(345, 25);
            this.detailNavigtor.TabIndex = 2;
            this.detailNavigtor.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(36, 22);
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
            // detailNavAddnew
            // 
            this.detailNavAddnew.Checked = true;
            this.detailNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavAddnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavAddnew.Enabled = false;
            this.detailNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("detailNavAddnew.Image")));
            this.detailNavAddnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavAddnew.Name = "detailNavAddnew";
            this.detailNavAddnew.Size = new System.Drawing.Size(41, 22);
            this.detailNavAddnew.Text = "+ Add";
            this.detailNavAddnew.Click += new System.EventHandler(this.detailNavAddnew_Click);
            // 
            // detailNavSave
            // 
            this.detailNavSave.Checked = true;
            this.detailNavSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavSave.Enabled = false;
            this.detailNavSave.Image = ((System.Drawing.Image)(resources.GetObject("detailNavSave.Image")));
            this.detailNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavSave.Name = "detailNavSave";
            this.detailNavSave.Size = new System.Drawing.Size(35, 22);
            this.detailNavSave.Text = "Save";
            this.detailNavSave.Click += new System.EventHandler(this.toolstrDetailSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // detailNavDelete
            // 
            this.detailNavDelete.Checked = true;
            this.detailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavDelete.Enabled = false;
            this.detailNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("detailNavDelete.Image")));
            this.detailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavDelete.Name = "detailNavDelete";
            this.detailNavDelete.Size = new System.Drawing.Size(49, 22);
            this.detailNavDelete.Text = "- Delete";
            this.detailNavDelete.Click += new System.EventHandler(this.toolStrDetailDelete_Click);
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDetailsTableAdapter
            // 
            this.invoiceDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(709, 533);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(197, 24);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // employeesLstBindingSource
            // 
            this.employeesLstBindingSource.DataMember = "EmployeesLst";
            this.employeesLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // employeesLstTableAdapter
            // 
            this.employeesLstTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTypesTableAdapter
            // 
            this.paymentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // customerListTableAdapter
            // 
            this.customerListTableAdapter.ClearBeforeFill = true;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.tabPage1);
            this.DetailsTab.Controls.Add(this.tabPage2);
            this.DetailsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsTab.Location = new System.Drawing.Point(3, 210);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(946, 325);
            this.DetailsTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.DetailsTab.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.invoiceDetailsDataGridView);
            this.tabPage1.Controls.Add(this.totCreditAmtTextBox);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(938, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sold Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtBalance);
            this.tabPage2.Controls.Add(this.txtPayments);
            this.tabPage2.Controls.Add(this.txtCredits);
            this.tabPage2.Controls.Add(this.txtLoan);
            this.tabPage2.Controls.Add(this.txtAdvance);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(938, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 72;
            this.label9.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 71;
            this.label8.Text = "All Payments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Customer Payable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 15);
            this.label6.TabIndex = 75;
            this.label6.Text = "Other Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "Advance Payments";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBalance.Location = new System.Drawing.Point(174, 122);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(171, 21);
            this.txtBalance.TabIndex = 67;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPayments
            // 
            this.txtPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments.Location = new System.Drawing.Point(174, 96);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(171, 21);
            this.txtPayments.TabIndex = 66;
            this.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCredits
            // 
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(174, 72);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(171, 21);
            this.txtCredits.TabIndex = 68;
            this.txtCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoan.Location = new System.Drawing.Point(174, 49);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(171, 21);
            this.txtLoan.TabIndex = 70;
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(174, 27);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(171, 21);
            this.txtAdvance.TabIndex = 69;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(709, 559);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(197, 24);
            this.txtVAT.TabIndex = 48;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotWithVAT
            // 
            this.txtTotWithVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotWithVAT.Location = new System.Drawing.Point(709, 586);
            this.txtTotWithVAT.Name = "txtTotWithVAT";
            this.txtTotWithVAT.ReadOnly = true;
            this.txtTotWithVAT.Size = new System.Drawing.Size(197, 24);
            this.txtTotWithVAT.TabIndex = 50;
            this.txtTotWithVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(526, 555);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(70, 21);
            this.discountTextBox.TabIndex = 1;
            this.discountTextBox.Visible = false;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Remarks", true));
            this.remarksTextBox.Enabled = false;
            this.remarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTextBox.Location = new System.Drawing.Point(13, 583);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(494, 22);
            this.remarksTextBox.TabIndex = 0;
            // 
            // invoices_CreditTableAdapter
            // 
            this.invoices_CreditTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDetails_CreditTableAdapter
            // 
            this.invoiceDetails_CreditTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoicesCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(969, 636);
            this.Controls.Add(this.detailNavigtor);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.txtTotWithVAT);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(label1);
            this.Controls.Add(this.DetailsTab);
            this.Name = "frmInvoicesCredit";
            this.Text = "Credit Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Shown += new System.EventHandler(this.frmInvoicesCredit_Shown);
            this.Activated += new System.EventHandler(this.frmInvoicesCredit_Activated);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).EndInit();
            this.mainNavigator.ResumeLayout(false);
            this.mainNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).EndInit();
            this.detailNavigtor.ResumeLayout(false);
            this.detailNavigtor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            this.DetailsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BelayAbInvoices belayAbInvoices;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox payTypeIdComboBox;
        private System.Windows.Forms.TextBox totCreditAmtTextBox;
        private System.Windows.Forms.BindingSource invoiceDetailsBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.InvoiceDetailsTableAdapter invoiceDetailsTableAdapter;
        private System.Windows.Forms.DataGridView invoiceDetailsDataGridView;
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
        private System.Windows.Forms.ToolStripButton detailNavSave;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.TextBox txtTotal;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource employeesLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.EmployeesLstTableAdapter employeesLstTableAdapter;
        private System.Windows.Forms.BindingSource paymentTypesBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.paymentTypesTableAdapter paymentTypesTableAdapter;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.CustomerListTableAdapter customerListTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource belayAbItemRequistionsBindingSource;
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
        private System.Windows.Forms.ToolStripButton itemsReceivedBindingNavigatorSaveItem;
        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton detailNavDelete;
        private System.Windows.Forms.ToolStripButton detailNavAddnew;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtTotWithVAT;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.ComboBox salesPersonIdComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cashierComboBox;
        private System.Windows.Forms.ComboBox checkedByComboBox;
        private System.Windows.Forms.ToolStripButton toolStrPrintInvoice;
        private System.Windows.Forms.TextBox checkNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.ToolTip toolTip;
        private Belayab.BelayAbInvoicesTableAdapters.Invoices_CreditTableAdapter invoices_CreditTableAdapter;
        private Belayab.BelayAbInvoicesTableAdapters.InvoiceDetails_CreditTableAdapter invoiceDetails_CreditTableAdapter;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshItems;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPayments;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem allItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSetPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edited;
    }
}