namespace Belayab
{
    partial class frmInvoices
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label remarksLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label checkedByLabel;
            System.Windows.Forms.Label cashierLabel;
            System.Windows.Forms.Label payTypeIdLabel;
            System.Windows.Forms.Label checkNumberLabel;
            System.Windows.Forms.Label invoice_refLabel;
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label updatedbyLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.allStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.customerListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoices_CreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.totCreditAmtTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefreshItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetPrices = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
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
            this.btnEditCustomers = new System.Windows.Forms.Button();
            this.allStatesTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.AllStatesTableAdapter();
            this.txtInText = new System.Windows.Forms.TextBox();
            this.invoices_CreditTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.Invoices_CreditTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StatusTextbox = new System.Windows.Forms.TextBox();
            this.btnCloseActivate = new System.Windows.Forms.Button();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbBranchStore = new Belayab.BelayAbBranchStore();
            this.invoice_refTextBox = new System.Windows.Forms.TextBox();
            this.totCreditAmtTextBox1 = new System.Windows.Forms.TextBox();
            this.curStateLabel = new System.Windows.Forms.Label();
            this.curStateComboBox = new System.Windows.Forms.ComboBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.cashierComboBox = new System.Windows.Forms.ComboBox();
            this.checkedByComboBox = new System.Windows.Forms.ComboBox();
            this.mainNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.label4 = new System.Windows.Forms.Label();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkNumberTextBox = new System.Windows.Forms.TextBox();
            this.storesTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.StoresTableAdapter();
            this.createdByTextBox = new System.Windows.Forms.TextBox();
            this.updatedbyTextBox = new System.Windows.Forms.TextBox();
            this.Edited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            checkedByLabel = new System.Windows.Forms.Label();
            cashierLabel = new System.Windows.Forms.Label();
            payTypeIdLabel = new System.Windows.Forms.Label();
            checkNumberLabel = new System.Windows.Forms.Label();
            invoice_refLabel = new System.Windows.Forms.Label();
            storeIDLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            updatedbyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoices_CreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).BeginInit();
            this.detailNavigtor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).BeginInit();
            this.DetailsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).BeginInit();
            this.mainNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(799, 705);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 25);
            label1.TabIndex = 34;
            label1.Text = "Total Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(800, 737);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 25);
            label2.TabIndex = 47;
            label2.Text = "VAT(15%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(763, 770);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(155, 25);
            label3.TabIndex = 49;
            label3.Text = "Total with VAT";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(687, 711);
            discountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(75, 18);
            discountLabel.TabIndex = 55;
            discountLabel.Text = "Discount:";
            discountLabel.Visible = false;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarksLabel.Location = new System.Drawing.Point(15, 741);
            remarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(74, 18);
            remarksLabel.TabIndex = 62;
            remarksLabel.Text = "Remarks:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceDateLabel.Location = new System.Drawing.Point(37, 132);
            invoiceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(91, 18);
            invoiceDateLabel.TabIndex = 4;
            invoiceDateLabel.Text = "Order Date:";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoiceNoLabel.Location = new System.Drawing.Point(56, 96);
            invoiceNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(74, 18);
            invoiceNoLabel.TabIndex = 0;
            invoiceNoLabel.Text = "Order No";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(11, 28);
            customerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(121, 18);
            customerIdLabel.TabIndex = 25;
            customerIdLabel.Text = "Customer Name";
            // 
            // checkedByLabel
            // 
            checkedByLabel.AutoSize = true;
            checkedByLabel.Location = new System.Drawing.Point(571, 58);
            checkedByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            checkedByLabel.Name = "checkedByLabel";
            checkedByLabel.Size = new System.Drawing.Size(97, 18);
            checkedByLabel.TabIndex = 28;
            checkedByLabel.Text = "Checked By:";
            // 
            // cashierLabel
            // 
            cashierLabel.AutoSize = true;
            cashierLabel.Location = new System.Drawing.Point(601, 91);
            cashierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cashierLabel.Name = "cashierLabel";
            cashierLabel.Size = new System.Drawing.Size(67, 18);
            cashierLabel.TabIndex = 29;
            cashierLabel.Text = "Cashier:";
            // 
            // payTypeIdLabel
            // 
            payTypeIdLabel.AutoSize = true;
            payTypeIdLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payTypeIdLabel.Location = new System.Drawing.Point(40, 60);
            payTypeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            payTypeIdLabel.Name = "payTypeIdLabel";
            payTypeIdLabel.Size = new System.Drawing.Size(88, 18);
            payTypeIdLabel.TabIndex = 8;
            payTypeIdLabel.Text = "Order Type";
            // 
            // checkNumberLabel
            // 
            checkNumberLabel.AutoSize = true;
            checkNumberLabel.Location = new System.Drawing.Point(25, 841);
            checkNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            checkNumberLabel.Name = "checkNumberLabel";
            checkNumberLabel.Size = new System.Drawing.Size(101, 17);
            checkNumberLabel.TabIndex = 65;
            checkNumberLabel.Text = "Check Number";
            // 
            // invoice_refLabel
            // 
            invoice_refLabel.AutoSize = true;
            invoice_refLabel.Location = new System.Drawing.Point(908, 21);
            invoice_refLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            invoice_refLabel.Name = "invoice_refLabel";
            invoice_refLabel.Size = new System.Drawing.Size(88, 18);
            invoice_refLabel.TabIndex = 45;
            invoice_refLabel.Text = "Invoice ref:";
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(927, 55);
            storeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(70, 18);
            storeIDLabel.TabIndex = 46;
            storeIDLabel.Text = "Store ID:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(374, 834);
            createdByLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(82, 17);
            createdByLabel.TabIndex = 75;
            createdByLabel.Text = "Created By:";
            // 
            // updatedbyLabel
            // 
            updatedbyLabel.AutoSize = true;
            updatedbyLabel.Location = new System.Drawing.Point(374, 857);
            updatedbyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            updatedbyLabel.Name = "updatedbyLabel";
            updatedbyLabel.Size = new System.Drawing.Size(86, 17);
            updatedbyLabel.TabIndex = 76;
            updatedbyLabel.Text = "Updated By:";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.belayAbInvoices;
            this.invoicesBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.invoicesBindingSource_AddingNew);
            this.invoicesBindingSource.CurrentChanged += new System.EventHandler(this.invoicesBindingSource_CurrentChanged);
            this.invoicesBindingSource.PositionChanged += new System.EventHandler(this.invoicesBindingSource_PositionChanged);
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allStatesBindingSource
            // 
            this.allStatesBindingSource.DataMember = "AllStates";
            this.allStatesBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerListBindingSource
            // 
            this.customerListBindingSource.DataMember = "CustomerList";
            this.customerListBindingSource.DataSource = this.belayAbInvoices;
            // 
            // paymentTypesBindingSource
            // 
            this.paymentTypesBindingSource.DataMember = "paymentTypes";
            this.paymentTypesBindingSource.DataSource = this.belayAbInvoices;
            // 
            // invoices_CreditBindingSource
            // 
            this.invoices_CreditBindingSource.DataMember = "Invoices_Credit";
            this.invoices_CreditBindingSource.DataSource = this.belayAbInvoices;
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
            this.totCreditAmtTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(175)))));
            this.totCreditAmtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totCreditAmtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "TotCreditAmt", true));
            this.totCreditAmtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totCreditAmtTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(175)))));
            this.totCreditAmtTextBox.Location = new System.Drawing.Point(865, 806);
            this.totCreditAmtTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totCreditAmtTextBox.Name = "totCreditAmtTextBox";
            this.totCreditAmtTextBox.ReadOnly = true;
            this.totCreditAmtTextBox.Size = new System.Drawing.Size(55, 22);
            this.totCreditAmtTextBox.TabIndex = 11;
            this.totCreditAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // invoiceDetailsBindingSource
            // 
            this.invoiceDetailsBindingSource.DataMember = "FK_InvoiceDetails_Invoices";
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
            this.ItemID,
            this.HD,
            this.Units,
            this.Qty,
            this.InStock,
            this.UnitPrice,
            this.TotalPrice,
            this.dataGridViewTextBoxColumn5,
            this.Edited});
            this.invoiceDetailsDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.invoiceDetailsDataGridView.DataSource = this.invoiceDetailsBindingSource;
            this.invoiceDetailsDataGridView.Location = new System.Drawing.Point(8, 4);
            this.invoiceDetailsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDetailsDataGridView.Name = "invoiceDetailsDataGridView";
            this.invoiceDetailsDataGridView.Size = new System.Drawing.Size(1260, 420);
            this.invoiceDetailsDataGridView.StandardTab = true;
            this.invoiceDetailsDataGridView.TabIndex = 0;
            this.invoiceDetailsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.invoiceDetailsDataGridView_CellBeginEdit);
            this.invoiceDetailsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.invoiceDetailsDataGridView_CellValidating);
            this.invoiceDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailsDataGridView_CellValueChanged_1);
            this.invoiceDetailsDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invoiceDetailsDataGridView_ColumnHeaderMouseClick);
            this.invoiceDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.invoiceDetailsDataGridView_DataError);
            this.invoiceDetailsDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.invoiceDetailsDataGridView_EditingControlShowing);
            this.invoiceDetailsDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDetailsDataGridView_RowValidated);
            this.invoiceDetailsDataGridView.Sorted += new System.EventHandler(this.invoiceDetailsDataGridView_Sorted);
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshItems,
            this.mnuAllItems,
            this.mnuEditItem,
            this.mnuSetPrices});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 108);
            // 
            // mnuRefreshItems
            // 
            this.mnuRefreshItems.Name = "mnuRefreshItems";
            this.mnuRefreshItems.Size = new System.Drawing.Size(173, 26);
            this.mnuRefreshItems.Text = "Refresh Items";
            this.mnuRefreshItems.Click += new System.EventHandler(this.mnuRefreshItems_Click);
            // 
            // mnuAllItems
            // 
            this.mnuAllItems.Name = "mnuAllItems";
            this.mnuAllItems.Size = new System.Drawing.Size(173, 26);
            this.mnuAllItems.Text = "Find Item";
            this.mnuAllItems.Click += new System.EventHandler(this.mnuAllItems_Click);
            // 
            // mnuEditItem
            // 
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(173, 26);
            this.mnuEditItem.Text = "Edit Item";
            this.mnuEditItem.Click += new System.EventHandler(this.mnuEditItem_Click);
            // 
            // mnuSetPrices
            // 
            this.mnuSetPrices.Name = "mnuSetPrices";
            this.mnuSetPrices.Size = new System.Drawing.Size(173, 26);
            this.mnuSetPrices.Text = "Set Prices";
            this.mnuSetPrices.Click += new System.EventHandler(this.mnuSetPrices_Click);
            // 
            // detailNavigtor
            // 
            this.detailNavigtor.AddNewItem = null;
            this.detailNavigtor.BindingSource = this.invoiceDetailsBindingSource;
            this.detailNavigtor.CountItem = this.bindingNavigatorCountItem1;
            this.detailNavigtor.DeleteItem = null;
            this.detailNavigtor.Dock = System.Windows.Forms.DockStyle.None;
            this.detailNavigtor.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.toolStripSeparator7,
            this.toolStripSeparator6,
            this.toolStripLabel2,
            this.detailNavDelete});
            this.detailNavigtor.Location = new System.Drawing.Point(4, 702);
            this.detailNavigtor.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.detailNavigtor.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.detailNavigtor.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.detailNavigtor.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.detailNavigtor.Name = "detailNavigtor";
            this.detailNavigtor.PositionItem = this.bindingNavigatorPositionItem1;
            this.detailNavigtor.Size = new System.Drawing.Size(463, 27);
            this.detailNavigtor.TabIndex = 2;
            this.detailNavigtor.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
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
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 27);
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
            // detailNavAddnew
            // 
            this.detailNavAddnew.Checked = true;
            this.detailNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavAddnew.Enabled = false;
            this.detailNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("detailNavAddnew.Image")));
            this.detailNavAddnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavAddnew.Name = "detailNavAddnew";
            this.detailNavAddnew.Size = new System.Drawing.Size(61, 24);
            this.detailNavAddnew.Text = "Add";
            this.detailNavAddnew.Click += new System.EventHandler(this.detailNavAddnew_Click);
            // 
            // detailNavSave
            // 
            this.detailNavSave.Checked = true;
            this.detailNavSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavSave.Enabled = false;
            this.detailNavSave.Image = ((System.Drawing.Image)(resources.GetObject("detailNavSave.Image")));
            this.detailNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavSave.Name = "detailNavSave";
            this.detailNavSave.Size = new System.Drawing.Size(64, 24);
            this.detailNavSave.Text = "Save";
            this.detailNavSave.Click += new System.EventHandler(this.toolstrDetailSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(0, 24);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(17, 24);
            this.toolStripLabel2.Text = "  ";
            // 
            // detailNavDelete
            // 
            this.detailNavDelete.Checked = true;
            this.detailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavDelete.Enabled = false;
            this.detailNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("detailNavDelete.Image")));
            this.detailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavDelete.Name = "detailNavDelete";
            this.detailNavDelete.Size = new System.Drawing.Size(77, 24);
            this.detailNavDelete.Text = "Delete";
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
            this.txtTotal.Location = new System.Drawing.Point(929, 700);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(261, 29);
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
            this.DetailsTab.Location = new System.Drawing.Point(1, 244);
            this.DetailsTab.Margin = new System.Windows.Forms.Padding(4);
            this.DetailsTab.Multiline = true;
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.SelectedIndex = 0;
            this.DetailsTab.Size = new System.Drawing.Size(1289, 458);
            this.DetailsTab.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.DetailsTab.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPage1.Controls.Add(this.invoiceDetailsDataGridView);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1281, 427);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1281, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 72;
            this.label9.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "All Payments";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Customer Payable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 75;
            this.label6.Text = "Other Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "Advance Payments";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBalance.Location = new System.Drawing.Point(265, 191);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(227, 24);
            this.txtBalance.TabIndex = 67;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPayments
            // 
            this.txtPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayments.Location = new System.Drawing.Point(265, 159);
            this.txtPayments.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(227, 24);
            this.txtPayments.TabIndex = 66;
            this.txtPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCredits
            // 
            this.txtCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredits.Location = new System.Drawing.Point(265, 129);
            this.txtCredits.Margin = new System.Windows.Forms.Padding(4);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(227, 24);
            this.txtCredits.TabIndex = 68;
            this.txtCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoan.Location = new System.Drawing.Point(265, 101);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(227, 24);
            this.txtLoan.TabIndex = 70;
            this.txtLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.Location = new System.Drawing.Point(265, 74);
            this.txtAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(227, 24);
            this.txtAdvance.TabIndex = 69;
            this.txtAdvance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(929, 732);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(261, 29);
            this.txtVAT.TabIndex = 48;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotWithVAT
            // 
            this.txtTotWithVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotWithVAT.Location = new System.Drawing.Point(929, 766);
            this.txtTotWithVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotWithVAT.Name = "txtTotWithVAT";
            this.txtTotWithVAT.ReadOnly = true;
            this.txtTotWithVAT.Size = new System.Drawing.Size(261, 29);
            this.txtTotWithVAT.TabIndex = 50;
            this.txtTotWithVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(685, 731);
            this.discountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(92, 25);
            this.discountTextBox.TabIndex = 1;
            this.discountTextBox.Visible = false;
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Remarks", true));
            this.remarksTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarksTextBox.Location = new System.Drawing.Point(19, 763);
            this.remarksTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(649, 63);
            this.remarksTextBox.TabIndex = 0;
            // 
            // btnEditCustomers
            // 
            this.btnEditCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditCustomers.Location = new System.Drawing.Point(501, 26);
            this.btnEditCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCustomers.Name = "btnEditCustomers";
            this.btnEditCustomers.Size = new System.Drawing.Size(43, 26);
            this.btnEditCustomers.TabIndex = 43;
            this.btnEditCustomers.Text = "...";
            this.toolTip.SetToolTip(this.btnEditCustomers, "Edit Customers");
            this.btnEditCustomers.UseVisualStyleBackColor = true;
            this.btnEditCustomers.Click += new System.EventHandler(this.btnEditCustomers_Click);
            // 
            // allStatesTableAdapter
            // 
            this.allStatesTableAdapter.ClearBeforeFill = true;
            // 
            // txtInText
            // 
            this.txtInText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "AmtInText", true));
            this.txtInText.Location = new System.Drawing.Point(804, 800);
            this.txtInText.Margin = new System.Windows.Forms.Padding(4);
            this.txtInText.Multiline = true;
            this.txtInText.Name = "txtInText";
            this.txtInText.ReadOnly = true;
            this.txtInText.Size = new System.Drawing.Size(387, 41);
            this.txtInText.TabIndex = 63;
            // 
            // invoices_CreditTableAdapter
            // 
            this.invoices_CreditTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.StatusTextbox);
            this.groupBox1.Controls.Add(this.btnCloseActivate);
            this.groupBox1.Controls.Add(storeIDLabel);
            this.groupBox1.Controls.Add(this.storeIDComboBox);
            this.groupBox1.Controls.Add(invoice_refLabel);
            this.groupBox1.Controls.Add(this.invoice_refTextBox);
            this.groupBox1.Controls.Add(this.totCreditAmtTextBox1);
            this.groupBox1.Controls.Add(this.curStateLabel);
            this.groupBox1.Controls.Add(this.curStateComboBox);
            this.groupBox1.Controls.Add(this.chkAuto);
            this.groupBox1.Controls.Add(this.btnEditCustomers);
            this.groupBox1.Controls.Add(this.label10);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1288, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(944, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 74;
            this.label11.Text = "Status";
            this.label11.Visible = false;
            // 
            // StatusTextbox
            // 
            this.StatusTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CurState", true));
            this.StatusTextbox.Enabled = false;
            this.StatusTextbox.Location = new System.Drawing.Point(1008, 88);
            this.StatusTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.StatusTextbox.Name = "StatusTextbox";
            this.StatusTextbox.ReadOnly = true;
            this.StatusTextbox.Size = new System.Drawing.Size(180, 25);
            this.StatusTextbox.TabIndex = 72;
            this.StatusTextbox.TabStop = false;
            // 
            // btnCloseActivate
            // 
            this.btnCloseActivate.Location = new System.Drawing.Point(1192, 87);
            this.btnCloseActivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseActivate.Name = "btnCloseActivate";
            this.btnCloseActivate.Size = new System.Drawing.Size(84, 28);
            this.btnCloseActivate.TabIndex = 71;
            this.btnCloseActivate.Text = "Close";
            this.btnCloseActivate.UseVisualStyleBackColor = true;
            this.btnCloseActivate.Click += new System.EventHandler(this.btnCloseActivate_Click);
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "StoreID", true));
            this.storeIDComboBox.DataSource = this.storesBindingSource;
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(1008, 51);
            this.storeIDComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(179, 26);
            this.storeIDComboBox.TabIndex = 47;
            this.storeIDComboBox.ValueMember = "StoreId";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "Stores";
            this.storesBindingSource.DataSource = this.belayAbBranchStore;
            // 
            // belayAbBranchStore
            // 
            this.belayAbBranchStore.DataSetName = "BelayAbBranchStore";
            this.belayAbBranchStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoice_refTextBox
            // 
            this.invoice_refTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Invoice_ref", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.invoice_refTextBox.Location = new System.Drawing.Point(1008, 17);
            this.invoice_refTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoice_refTextBox.Name = "invoice_refTextBox";
            this.invoice_refTextBox.Size = new System.Drawing.Size(179, 25);
            this.invoice_refTextBox.TabIndex = 46;
            // 
            // totCreditAmtTextBox1
            // 
            this.totCreditAmtTextBox1.Location = new System.Drawing.Point(479, 87);
            this.totCreditAmtTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.totCreditAmtTextBox1.Name = "totCreditAmtTextBox1";
            this.totCreditAmtTextBox1.Size = new System.Drawing.Size(49, 25);
            this.totCreditAmtTextBox1.TabIndex = 45;
            this.totCreditAmtTextBox1.Visible = false;
            // 
            // curStateLabel
            // 
            this.curStateLabel.AutoSize = true;
            this.curStateLabel.Location = new System.Drawing.Point(615, 126);
            this.curStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curStateLabel.Name = "curStateLabel";
            this.curStateLabel.Size = new System.Drawing.Size(53, 18);
            this.curStateLabel.TabIndex = 44;
            this.curStateLabel.Text = "Status";
            this.curStateLabel.Visible = false;
            // 
            // curStateComboBox
            // 
            this.curStateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.curStateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.curStateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "CurState", true));
            this.curStateComboBox.DataSource = this.allStatesBindingSource;
            this.curStateComboBox.DisplayMember = "State";
            this.curStateComboBox.Enabled = false;
            this.curStateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curStateComboBox.Location = new System.Drawing.Point(681, 122);
            this.curStateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.curStateComboBox.Name = "curStateComboBox";
            this.curStateComboBox.Size = new System.Drawing.Size(217, 25);
            this.curStateComboBox.TabIndex = 8;
            this.curStateComboBox.ValueMember = "State";
            this.curStateComboBox.Visible = false;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Location = new System.Drawing.Point(371, 94);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(4);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(66, 22);
            this.chkAuto.TabIndex = 44;
            this.chkAuto.Text = "Auto ";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.AllowDrop = true;
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(144, 90);
            this.invoiceNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(217, 23);
            this.invoiceNoTextBox.TabIndex = 2;
            // 
            // cashierComboBox
            // 
            this.cashierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cashierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cashierComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Cashier", true));
            this.cashierComboBox.DisplayMember = "EmployeeName";
            this.cashierComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierComboBox.FormattingEnabled = true;
            this.cashierComboBox.Location = new System.Drawing.Point(681, 87);
            this.cashierComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cashierComboBox.Name = "cashierComboBox";
            this.cashierComboBox.Size = new System.Drawing.Size(217, 25);
            this.cashierComboBox.TabIndex = 6;
            this.cashierComboBox.ValueMember = "EmployeeName";
            // 
            // checkedByComboBox
            // 
            this.checkedByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.checkedByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.checkedByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CheckedBy", true));
            this.checkedByComboBox.DisplayMember = "Employeename";
            this.checkedByComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedByComboBox.FormattingEnabled = true;
            this.checkedByComboBox.Location = new System.Drawing.Point(681, 54);
            this.checkedByComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkedByComboBox.Name = "checkedByComboBox";
            this.checkedByComboBox.Size = new System.Drawing.Size(217, 25);
            this.checkedByComboBox.TabIndex = 5;
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
            this.mainNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
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
            this.mainNavigator.Location = new System.Drawing.Point(145, 174);
            this.mainNavigator.MoveFirstItem = this.MainNavFirst;
            this.mainNavigator.MoveLastItem = this.toolStripButton6;
            this.mainNavigator.MoveNextItem = this.toolStripButton5;
            this.mainNavigator.MovePreviousItem = this.MainNavPrevious;
            this.mainNavigator.Name = "mainNavigator";
            this.mainNavigator.PositionItem = this.MainNavPosition;
            this.mainNavigator.Size = new System.Drawing.Size(658, 31);
            this.mainNavigator.TabIndex = 28;
            this.mainNavigator.Text = "ManNav";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 28);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // MainNavFirst
            // 
            this.MainNavFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavFirst.Image = ((System.Drawing.Image)(resources.GetObject("MainNavFirst.Image")));
            this.MainNavFirst.Name = "MainNavFirst";
            this.MainNavFirst.RightToLeftAutoMirrorImage = true;
            this.MainNavFirst.Size = new System.Drawing.Size(24, 28);
            this.MainNavFirst.Text = "Move first";
            // 
            // MainNavPrevious
            // 
            this.MainNavPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MainNavPrevious.Image = ((System.Drawing.Image)(resources.GetObject("MainNavPrevious.Image")));
            this.MainNavPrevious.Name = "MainNavPrevious";
            this.MainNavPrevious.RightToLeftAutoMirrorImage = true;
            this.MainNavPrevious.Size = new System.Drawing.Size(24, 28);
            this.MainNavPrevious.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // MainNavPosition
            // 
            this.MainNavPosition.AccessibleName = "Position";
            this.MainNavPosition.AutoSize = false;
            this.MainNavPosition.Name = "MainNavPosition";
            this.MainNavPosition.Size = new System.Drawing.Size(65, 27);
            this.MainNavPosition.Text = "0";
            this.MainNavPosition.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 28);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(117, 28);
            this.MainNavAddnew.Text = "Add new";
            this.MainNavAddnew.Click += new System.EventHandler(this.tooStripAddnew_Click);
            // 
            // itemsReceivedBindingNavigatorSaveItem
            // 
            this.itemsReceivedBindingNavigatorSaveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.itemsReceivedBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsReceivedBindingNavigatorSaveItem.Image")));
            this.itemsReceivedBindingNavigatorSaveItem.Name = "itemsReceivedBindingNavigatorSaveItem";
            this.itemsReceivedBindingNavigatorSaveItem.Size = new System.Drawing.Size(127, 28);
            this.itemsReceivedBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsReceivedBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsReceivedBindingNavigatorSaveItem_Click);
            // 
            // DeleteWrap
            // 
            this.DeleteWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteWrap.Image = ((System.Drawing.Image)(resources.GetObject("DeleteWrap.Image")));
            this.DeleteWrap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteWrap.Name = "DeleteWrap";
            this.DeleteWrap.Size = new System.Drawing.Size(94, 28);
            this.DeleteWrap.Text = "Delete";
            this.DeleteWrap.Click += new System.EventHandler(this.DeleteWrap_Click);
            // 
            // toolStrPrintInvoice
            // 
            this.toolStrPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStrPrintInvoice.Image = ((System.Drawing.Image)(resources.GetObject("toolStrPrintInvoice.Image")));
            this.toolStrPrintInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrPrintInvoice.Name = "toolStrPrintInvoice";
            this.toolStrPrintInvoice.Size = new System.Drawing.Size(76, 28);
            this.toolStrPrintInvoice.Text = "Print";
            this.toolStrPrintInvoice.Click += new System.EventHandler(this.toolStrPrintInvoice_Click);
            // 
            // salesPersonIdComboBox
            // 
            this.salesPersonIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.salesPersonIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.salesPersonIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "SalesPersonId", true));
            this.salesPersonIdComboBox.DisplayMember = "EmployeeName";
            this.salesPersonIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPersonIdComboBox.FormattingEnabled = true;
            this.salesPersonIdComboBox.Location = new System.Drawing.Point(681, 21);
            this.salesPersonIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesPersonIdComboBox.Name = "salesPersonIdComboBox";
            this.salesPersonIdComboBox.Size = new System.Drawing.Size(217, 25);
            this.salesPersonIdComboBox.TabIndex = 4;
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
            this.customerIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(145, 25);
            this.customerIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(351, 25);
            this.customerIdComboBox.TabIndex = 0;
            this.customerIdComboBox.ValueMember = "CustomerId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prepared By";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoicesBindingSource, "InvoiceDate", true));
            this.invoiceDateDateTimePicker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(144, 126);
            this.invoiceDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(216, 25);
            this.invoiceDateDateTimePicker.TabIndex = 7;
            this.invoiceDateDateTimePicker.Value = new System.DateTime(2007, 6, 17, 0, 0, 0, 0);
            // 
            // payTypeIdComboBox
            // 
            this.payTypeIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.payTypeIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.payTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "PayTypeId", true));
            this.payTypeIdComboBox.DataSource = this.paymentTypesBindingSource;
            this.payTypeIdComboBox.DisplayMember = "PayTypeId";
            this.payTypeIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payTypeIdComboBox.ForeColor = System.Drawing.Color.Blue;
            this.payTypeIdComboBox.FormattingEnabled = true;
            this.payTypeIdComboBox.Location = new System.Drawing.Point(145, 55);
            this.payTypeIdComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.payTypeIdComboBox.Name = "payTypeIdComboBox";
            this.payTypeIdComboBox.Size = new System.Drawing.Size(161, 25);
            this.payTypeIdComboBox.TabIndex = 1;
            this.payTypeIdComboBox.ValueMember = "PayTypeId";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 249);
            this.panel1.TabIndex = 0;
            // 
            // checkNumberTextBox
            // 
            this.checkNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CheckNumber", true));
            this.checkNumberTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkNumberTextBox.Location = new System.Drawing.Point(149, 834);
            this.checkNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkNumberTextBox.Name = "checkNumberTextBox";
            this.checkNumberTextBox.Size = new System.Drawing.Size(217, 29);
            this.checkNumberTextBox.TabIndex = 64;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // createdByTextBox
            // 
            this.createdByTextBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.createdByTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "CreatedBy", true));
            this.createdByTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdByTextBox.Location = new System.Drawing.Point(465, 834);
            this.createdByTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.createdByTextBox.Name = "createdByTextBox";
            this.createdByTextBox.ReadOnly = true;
            this.createdByTextBox.Size = new System.Drawing.Size(297, 16);
            this.createdByTextBox.TabIndex = 77;
            // 
            // updatedbyTextBox
            // 
            this.updatedbyTextBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.updatedbyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.updatedbyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "UpdatedBy", true));
            this.updatedbyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatedbyTextBox.Location = new System.Drawing.Point(465, 858);
            this.updatedbyTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.updatedbyTextBox.Name = "updatedbyTextBox";
            this.updatedbyTextBox.ReadOnly = true;
            this.updatedbyTextBox.Size = new System.Drawing.Size(297, 16);
            this.updatedbyTextBox.TabIndex = 78;
            // 
            // Edited
            // 
            this.Edited.HeaderText = "OldQ";
            this.Edited.Name = "Edited";
            this.Edited.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edited.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edited.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 82;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 119;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 111;
            // 
            // InStock
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.InStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.InStock.HeaderText = "In Stock";
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 83;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            dataGridViewCellStyle2.Format = "#";
            dataGridViewCellStyle2.NullValue = "0";
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 52;
            // 
            // Units
            // 
            this.Units.HeaderText = "Units";
            this.Units.Name = "Units";
            this.Units.ReadOnly = true;
            this.Units.Width = 65;
            // 
            // HD
            // 
            this.HD.DataPropertyName = "HD";
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.HD.Visible = false;
            this.HD.Width = 52;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // frmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(160)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(1296, 875);
            this.Controls.Add(this.createdByTextBox);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(checkNumberLabel);
            this.Controls.Add(this.updatedbyTextBox);
            this.Controls.Add(this.checkNumberTextBox);
            this.Controls.Add(updatedbyLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.txtInText);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.txtTotWithVAT);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetailsTab);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.detailNavigtor);
            this.Controls.Add(label1);
            this.Controls.Add(this.totCreditAmtTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInvoices";
            this.Text = "Cash Sales Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmInvoices_Activated);
            this.Load += new System.EventHandler(this.frmInvoices_Load);
            this.Shown += new System.EventHandler(this.frmInvoices_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoices_CreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailNavigtor)).EndInit();
            this.detailNavigtor.ResumeLayout(false);
            this.detailNavigtor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesLstBindingSource)).EndInit();
            this.DetailsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNavigator)).EndInit();
            this.mainNavigator.ResumeLayout(false);
            this.mainNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbInvoices belayAbInvoices;
        private Belayab.BelayAbInvoicesTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.TextBox totCreditAmtTextBox;
        private System.Windows.Forms.BindingSource invoiceDetailsBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.InvoiceDetailsTableAdapter invoiceDetailsTableAdapter;
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
        private System.Windows.Forms.BindingSource customerListBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.CustomerListTableAdapter customerListTableAdapter;
        private System.Windows.Forms.BindingSource belayAbItemRequistionsBindingSource;
        private System.Windows.Forms.TabControl DetailsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripButton detailNavDelete;
        private System.Windows.Forms.ToolStripButton detailNavAddnew;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.TextBox txtTotWithVAT;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshItems;
        private System.Windows.Forms.ToolStripMenuItem mnuAllItems;
        private System.Windows.Forms.ToolStripMenuItem mnuSetPrices;
        private System.Windows.Forms.BindingSource allStatesBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.AllStatesTableAdapter allStatesTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
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
        private System.Windows.Forms.TextBox txtInText;
        private System.Windows.Forms.DataGridViewComboBoxColumn PartNumber;
        public System.Windows.Forms.DataGridView invoiceDetailsDataGridView;
        private System.Windows.Forms.BindingSource invoices_CreditBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.Invoices_CreditTableAdapter invoices_CreditTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox totCreditAmtTextBox1;
        private System.Windows.Forms.Label curStateLabel;
        private System.Windows.Forms.ComboBox curStateComboBox;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Button btnEditCustomers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.ComboBox cashierComboBox;
        private System.Windows.Forms.ComboBox checkedByComboBox;
        private System.Windows.Forms.BindingNavigator mainNavigator;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton MainNavFirst;
        private System.Windows.Forms.ToolStripButton MainNavPrevious;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox MainNavPosition;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton MainNavAddnew;
        private System.Windows.Forms.ToolStripButton itemsReceivedBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton DeleteWrap;
        private System.Windows.Forms.ToolStripButton toolStrPrintInvoice;
        private System.Windows.Forms.ComboBox salesPersonIdComboBox;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.ComboBox payTypeIdComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox checkNumberTextBox;
        private System.Windows.Forms.TextBox invoice_refTextBox;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private BelayAbBranchStore belayAbBranchStore;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.StoresTableAdapter storesTableAdapter;
        public System.Windows.Forms.BindingSource invoicesBindingSource;
        private System.Windows.Forms.TextBox StatusTextbox;
        private System.Windows.Forms.Button btnCloseActivate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox createdByTextBox;
        private System.Windows.Forms.TextBox updatedbyTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Units;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Edited;
    }
}