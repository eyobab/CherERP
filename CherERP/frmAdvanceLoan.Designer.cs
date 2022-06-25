namespace Belayab
{
    partial class frmAdvanceLoan
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvanceLoan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.CustomerNavigatorFindTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.customerLoansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceAdvancePrepaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.advanceNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.AdvanceNavAdd = new System.Windows.Forms.ToolStripButton();
            this.AdvanceNavDelete = new System.Windows.Forms.ToolStripButton();
            this.AdvanceNavSave = new System.Windows.Forms.ToolStripButton();
            this.advanceNavPrint = new System.Windows.Forms.ToolStripButton();
            this.customersTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.CustomersTableAdapter();
            this.customerLoansTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.CustomerLoansTableAdapter();
            this.invoiceAdvancePrepaymentsTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.InvoiceAdvancePrepaymentsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.invoiceAdvancePrepaymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LoanNavAdd = new System.Windows.Forms.ToolStripButton();
            this.LoanNavDelete = new System.Windows.Forms.ToolStripButton();
            this.LoanNavSave = new System.Windows.Forms.ToolStripButton();
            this.LoanNavPrint = new System.Windows.Forms.ToolStripButton();
            this.customerLoansDataGridView = new System.Windows.Forms.DataGridView();
            this.ReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new Belayab.CalendarColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerNameLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
            this.customersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLoansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdvancePrepaymentsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advanceNav)).BeginInit();
            this.advanceNav.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdvancePrepaymentsDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerLoansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerNameLabel.Location = new System.Drawing.Point(108, 22);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(114, 15);
            customerNameLabel.TabIndex = 1;
            customerNameLabel.Text = "Customer Name:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerIdLabel.Location = new System.Drawing.Point(127, 48);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(88, 15);
            customerIdLabel.TabIndex = 3;
            customerIdLabel.Text = "Customer Id:";
            // 
            // customersBindingNavigator
            // 
            this.customersBindingNavigator.AddNewItem = null;
            this.customersBindingNavigator.BindingSource = this.customersBindingSource;
            this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customersBindingNavigator.DeleteItem = null;
            this.customersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel3,
            this.CustomerNavigatorFindTextBox});
            this.customersBindingNavigator.Location = new System.Drawing.Point(88, 85);
            this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customersBindingNavigator.Name = "customersBindingNavigator";
            this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customersBindingNavigator.Size = new System.Drawing.Size(386, 25);
            this.customersBindingNavigator.TabIndex = 0;
            this.customersBindingNavigator.Text = "bindingNavigator1";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.belayAbInvoices;
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel3.Text = "Type to find >";
            // 
            // CustomerNavigatorFindTextBox
            // 
            this.CustomerNavigatorFindTextBox.Name = "CustomerNavigatorFindTextBox";
            this.CustomerNavigatorFindTextBox.Size = new System.Drawing.Size(100, 25);
            this.CustomerNavigatorFindTextBox.ToolTipText = "Type Customer Name To automatically find";
            this.CustomerNavigatorFindTextBox.TextChanged += new System.EventHandler(this.CustomerNavigatorFindTextBox_TextChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerName", true));
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(228, 19);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(211, 21);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerId", true));
            this.customerIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTextBox.Location = new System.Drawing.Point(228, 45);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.ReadOnly = true;
            this.customerIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.customerIdTextBox.TabIndex = 4;
            // 
            // customerLoansBindingSource
            // 
            this.customerLoansBindingSource.DataMember = "FK_CustomerLoans_Customers";
            this.customerLoansBindingSource.DataSource = this.customersBindingSource;
            // 
            // invoiceAdvancePrepaymentsBindingSource
            // 
            this.invoiceAdvancePrepaymentsBindingSource.DataMember = "FK_InvoiceAdvancePrepayments_Customers";
            this.invoiceAdvancePrepaymentsBindingSource.DataSource = this.customersBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(customerIdLabel);
            this.groupBox1.Controls.Add(this.customerIdTextBox);
            this.groupBox1.Controls.Add(customerNameLabel);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.customersBindingNavigator);
            this.groupBox1.Location = new System.Drawing.Point(83, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 134);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // advanceNav
            // 
            this.advanceNav.AddNewItem = null;
            this.advanceNav.BindingSource = this.invoiceAdvancePrepaymentsBindingSource;
            this.advanceNav.CountItem = this.toolStripLabel2;
            this.advanceNav.DeleteItem = null;
            this.advanceNav.Dock = System.Windows.Forms.DockStyle.None;
            this.advanceNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.AdvanceNavAdd,
            this.AdvanceNavDelete,
            this.AdvanceNavSave,
            this.advanceNavPrint});
            this.advanceNav.Location = new System.Drawing.Point(3, 187);
            this.advanceNav.MoveFirstItem = this.toolStripButton10;
            this.advanceNav.MoveLastItem = this.toolStripButton13;
            this.advanceNav.MoveNextItem = this.toolStripButton12;
            this.advanceNav.MovePreviousItem = this.toolStripButton11;
            this.advanceNav.Name = "advanceNav";
            this.advanceNav.PositionItem = this.toolStripTextBox2;
            this.advanceNav.Size = new System.Drawing.Size(326, 25);
            this.advanceNav.TabIndex = 10;
            this.advanceNav.Text = "bindingNavigator1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move first";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move next";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // AdvanceNavAdd
            // 
            this.AdvanceNavAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdvanceNavAdd.Enabled = false;
            this.AdvanceNavAdd.Image = ((System.Drawing.Image)(resources.GetObject("AdvanceNavAdd.Image")));
            this.AdvanceNavAdd.Name = "AdvanceNavAdd";
            this.AdvanceNavAdd.RightToLeftAutoMirrorImage = true;
            this.AdvanceNavAdd.Size = new System.Drawing.Size(23, 22);
            this.AdvanceNavAdd.Text = "Add new";
            this.AdvanceNavAdd.Click += new System.EventHandler(this.AdvanceNavAdd_Click);
            // 
            // AdvanceNavDelete
            // 
            this.AdvanceNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdvanceNavDelete.Enabled = false;
            this.AdvanceNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("AdvanceNavDelete.Image")));
            this.AdvanceNavDelete.Name = "AdvanceNavDelete";
            this.AdvanceNavDelete.RightToLeftAutoMirrorImage = true;
            this.AdvanceNavDelete.Size = new System.Drawing.Size(23, 22);
            this.AdvanceNavDelete.Text = "Delete";
            this.AdvanceNavDelete.Click += new System.EventHandler(this.AdvanceNavDelete_Click);
            // 
            // AdvanceNavSave
            // 
            this.AdvanceNavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AdvanceNavSave.Enabled = false;
            this.AdvanceNavSave.Image = ((System.Drawing.Image)(resources.GetObject("AdvanceNavSave.Image")));
            this.AdvanceNavSave.Name = "AdvanceNavSave";
            this.AdvanceNavSave.Size = new System.Drawing.Size(23, 22);
            this.AdvanceNavSave.Text = "Save Data";
            this.AdvanceNavSave.Click += new System.EventHandler(this.AdvanceNavSave_Click);
            // 
            // advanceNavPrint
            // 
            this.advanceNavPrint.Enabled = false;
            this.advanceNavPrint.Image = ((System.Drawing.Image)(resources.GetObject("advanceNavPrint.Image")));
            this.advanceNavPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.advanceNavPrint.Name = "advanceNavPrint";
            this.advanceNavPrint.Size = new System.Drawing.Size(49, 22);
            this.advanceNavPrint.Text = "Print";
            this.advanceNavPrint.Click += new System.EventHandler(this.advanceNavPrint_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customerLoansTableAdapter
            // 
            this.customerLoansTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceAdvancePrepaymentsTableAdapter
            // 
            this.invoiceAdvancePrepaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.invoiceAdvancePrepaymentsDataGridView);
            this.groupBox2.Controls.Add(this.advanceNav);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 215);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Advance Payments";
            // 
            // invoiceAdvancePrepaymentsDataGridView
            // 
            this.invoiceAdvancePrepaymentsDataGridView.AllowUserToAddRows = false;
            this.invoiceAdvancePrepaymentsDataGridView.AllowUserToDeleteRows = false;
            this.invoiceAdvancePrepaymentsDataGridView.AutoGenerateColumns = false;
            this.invoiceAdvancePrepaymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecieptNo,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.PaymentDate,
            this.dataGridViewTextBoxColumn9});
            this.invoiceAdvancePrepaymentsDataGridView.DataSource = this.invoiceAdvancePrepaymentsBindingSource;
            this.invoiceAdvancePrepaymentsDataGridView.Enabled = false;
            this.invoiceAdvancePrepaymentsDataGridView.Location = new System.Drawing.Point(6, 21);
            this.invoiceAdvancePrepaymentsDataGridView.Name = "invoiceAdvancePrepaymentsDataGridView";
            this.invoiceAdvancePrepaymentsDataGridView.Size = new System.Drawing.Size(743, 163);
            this.invoiceAdvancePrepaymentsDataGridView.TabIndex = 11;
            this.invoiceAdvancePrepaymentsDataGridView.Leave += new System.EventHandler(this.invoiceAdvancePrepaymentsDataGridView_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.bindingNavigator1);
            this.groupBox3.Controls.Add(this.customerLoansDataGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 212);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other Payments";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.customerLoansBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.LoanNavAdd,
            this.LoanNavDelete,
            this.LoanNavSave,
            this.LoanNavPrint});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 169);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(326, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 21);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
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
            // LoanNavAdd
            // 
            this.LoanNavAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoanNavAdd.Enabled = false;
            this.LoanNavAdd.Image = ((System.Drawing.Image)(resources.GetObject("LoanNavAdd.Image")));
            this.LoanNavAdd.Name = "LoanNavAdd";
            this.LoanNavAdd.RightToLeftAutoMirrorImage = true;
            this.LoanNavAdd.Size = new System.Drawing.Size(23, 22);
            this.LoanNavAdd.Text = "Add new";
            this.LoanNavAdd.Click += new System.EventHandler(this.LoanNavAdd_Click);
            // 
            // LoanNavDelete
            // 
            this.LoanNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoanNavDelete.Enabled = false;
            this.LoanNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("LoanNavDelete.Image")));
            this.LoanNavDelete.Name = "LoanNavDelete";
            this.LoanNavDelete.RightToLeftAutoMirrorImage = true;
            this.LoanNavDelete.Size = new System.Drawing.Size(23, 22);
            this.LoanNavDelete.Text = "Delete";
            this.LoanNavDelete.Click += new System.EventHandler(this.LoanNavDelete_Click);
            // 
            // LoanNavSave
            // 
            this.LoanNavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoanNavSave.Enabled = false;
            this.LoanNavSave.Image = ((System.Drawing.Image)(resources.GetObject("LoanNavSave.Image")));
            this.LoanNavSave.Name = "LoanNavSave";
            this.LoanNavSave.Size = new System.Drawing.Size(23, 22);
            this.LoanNavSave.Text = "Save Data";
            this.LoanNavSave.Click += new System.EventHandler(this.LoanNavSave_Click);
            // 
            // LoanNavPrint
            // 
            this.LoanNavPrint.Enabled = false;
            this.LoanNavPrint.Image = ((System.Drawing.Image)(resources.GetObject("LoanNavPrint.Image")));
            this.LoanNavPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoanNavPrint.Name = "LoanNavPrint";
            this.LoanNavPrint.Size = new System.Drawing.Size(49, 22);
            this.LoanNavPrint.Text = "Print";
            this.LoanNavPrint.Click += new System.EventHandler(this.LoanNavPrint_Click);
            // 
            // customerLoansDataGridView
            // 
            this.customerLoansDataGridView.AllowUserToAddRows = false;
            this.customerLoansDataGridView.AllowUserToDeleteRows = false;
            this.customerLoansDataGridView.AutoGenerateColumns = false;
            this.customerLoansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptNumber,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.LPaymentDate,
            this.Description});
            this.customerLoansDataGridView.DataSource = this.customerLoansBindingSource;
            this.customerLoansDataGridView.Enabled = false;
            this.customerLoansDataGridView.Location = new System.Drawing.Point(6, 23);
            this.customerLoansDataGridView.Name = "customerLoansDataGridView";
            this.customerLoansDataGridView.Size = new System.Drawing.Size(743, 143);
            this.customerLoansDataGridView.TabIndex = 10;
            this.customerLoansDataGridView.Leave += new System.EventHandler(this.customerLoansDataGridView_Leave);
            // 
            // ReceiptNumber
            // 
            this.ReceiptNumber.DataPropertyName = "ReceiptNumber";
            this.ReceiptNumber.HeaderText = "Receipt Number";
            this.ReceiptNumber.Name = "ReceiptNumber";
            this.ReceiptNumber.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoanAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Payed Amt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // LPaymentDate
            // 
            this.LPaymentDate.DataPropertyName = "LoanDate";
            this.LPaymentDate.HeaderText = "Date";
            this.LPaymentDate.Name = "LPaymentDate";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 400;
            // 
            // RecieptNo
            // 
            this.RecieptNo.DataPropertyName = "ReceiptNumber";
            this.RecieptNo.HeaderText = "Receipt Number";
            this.RecieptNo.Name = "RecieptNo";
            this.RecieptNo.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn7.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PayedAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "Payed Amt";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = " Date";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PaymentDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Description";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 400;
            // 
            // frmAdvanceLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 646);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdvanceLoan";
            this.Text = "Advance Payments and Loans";
            this.Load += new System.EventHandler(this.frmAdvanceLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
            this.customersBindingNavigator.ResumeLayout(false);
            this.customersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLoansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdvancePrepaymentsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advanceNav)).EndInit();
            this.advanceNav.ResumeLayout(false);
            this.advanceNav.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceAdvancePrepaymentsDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerLoansDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BelayAbInvoices belayAbInvoices;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingNavigator customersBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.BindingSource customerLoansBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.CustomerLoansTableAdapter customerLoansTableAdapter;
        private System.Windows.Forms.BindingSource invoiceAdvancePrepaymentsBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.InvoiceAdvancePrepaymentsTableAdapter invoiceAdvancePrepaymentsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingNavigator advanceNav;
        private System.Windows.Forms.ToolStripButton AdvanceNavAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton AdvanceNavDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton AdvanceNavSave;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox CustomerNavigatorFindTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView invoiceAdvancePrepaymentsDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton LoanNavAdd;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton LoanNavDelete;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton LoanNavSave;
        private System.Windows.Forms.DataGridView customerLoansDataGridView;
        private System.Windows.Forms.ToolStripButton advanceNavPrint;
        private System.Windows.Forms.ToolStripButton LoanNavPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private CalendarColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}