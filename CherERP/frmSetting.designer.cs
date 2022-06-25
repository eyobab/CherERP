namespace Belayab
{
    partial class frmSetting
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
            System.Windows.Forms.Label settiningDateLabel;
            System.Windows.Forms.Label receivedNumberLabel;
            System.Windows.Forms.Label receivedNumberLabel1;
            System.Windows.Forms.Label priceTypeIDLabel;
            System.Windows.Forms.Label itemPriceIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtWorda = new System.Windows.Forms.TextBox();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStoreRemark = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboEmpDepartmentId = new System.Windows.Forms.ComboBox();
            this.txtKebele = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbpPriceSetting = new System.Windows.Forms.TabPage();
            this.itemPriceIDTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkFilterByReceiveNo = new System.Windows.Forms.CheckBox();
            this.receivedNumberComboBox = new System.Windows.Forms.ComboBox();
            this.receivedNumberTextBox = new System.Windows.Forms.TextBox();
            this.detailNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.itemPriceSettingsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.detailNavmoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.detailNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.detailNavSave = new System.Windows.Forms.ToolStripButton();
            this.detailNavDelete = new System.Windows.Forms.ToolStripButton();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.DetailGrid = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitPrceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnImportPrices = new System.Windows.Forms.Button();
            this.priceTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.itemPriceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.mainNavMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.mainNavMoveprev = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.mainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.mainNavSave = new System.Windows.Forms.ToolStripButton();
            this.mainNavDelete = new System.Windows.Forms.ToolStripButton();
            this.mainNavPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settiningDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.tabSetting = new System.Windows.Forms.TabControl();
            this.tbpUnitMeasurment = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lvUnitMeasurment = new System.Windows.Forms.ListView();
            this.ClhUnitMeasurment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUnitMeasured = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.txtMeasurementId = new System.Windows.Forms.TextBox();
            this.lblUnitMeasured = new System.Windows.Forms.Label();
            this.lblMeasurementId = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.itemPriceSettingsDetailsTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceSettingsDetailsTableAdapter();
            this.itemPriceSettingsTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceSettingsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceTypesTableAdapter();
            settiningDateLabel = new System.Windows.Forms.Label();
            receivedNumberLabel = new System.Windows.Forms.Label();
            receivedNumberLabel1 = new System.Windows.Forms.Label();
            priceTypeIDLabel = new System.Windows.Forms.Label();
            itemPriceIDLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tbpPriceSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailNav)).BeginInit();
            this.detailNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceSettingsDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGrid)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNav)).BeginInit();
            this.mainNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            this.tabSetting.SuspendLayout();
            this.tbpUnitMeasurment.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settiningDateLabel
            // 
            settiningDateLabel.AutoSize = true;
            settiningDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            settiningDateLabel.Location = new System.Drawing.Point(11, 9);
            settiningDateLabel.Name = "settiningDateLabel";
            settiningDateLabel.Size = new System.Drawing.Size(92, 13);
            settiningDateLabel.TabIndex = 75;
            settiningDateLabel.Text = "Settining Date:";
            // 
            // receivedNumberLabel
            // 
            receivedNumberLabel.AutoSize = true;
            receivedNumberLabel.Enabled = false;
            receivedNumberLabel.Location = new System.Drawing.Point(13, 12);
            receivedNumberLabel.Name = "receivedNumberLabel";
            receivedNumberLabel.Size = new System.Drawing.Size(0, 13);
            receivedNumberLabel.TabIndex = 77;
            // 
            // receivedNumberLabel1
            // 
            receivedNumberLabel1.AutoSize = true;
            receivedNumberLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            receivedNumberLabel1.Location = new System.Drawing.Point(46, 130);
            receivedNumberLabel1.Name = "receivedNumberLabel1";
            receivedNumberLabel1.Size = new System.Drawing.Size(112, 13);
            receivedNumberLabel1.TabIndex = 92;
            receivedNumberLabel1.Text = "Received Number:";
            // 
            // priceTypeIDLabel
            // 
            priceTypeIDLabel.AutoSize = true;
            priceTypeIDLabel.Location = new System.Drawing.Point(11, 36);
            priceTypeIDLabel.Name = "priceTypeIDLabel";
            priceTypeIDLabel.Size = new System.Drawing.Size(72, 13);
            priceTypeIDLabel.TabIndex = 87;
            priceTypeIDLabel.Text = "Price Type:";
            // 
            // itemPriceIDLabel
            // 
            itemPriceIDLabel.AutoSize = true;
            itemPriceIDLabel.Location = new System.Drawing.Point(409, 16);
            itemPriceIDLabel.Name = "itemPriceIDLabel";
            itemPriceIDLabel.Size = new System.Drawing.Size(85, 13);
            itemPriceIDLabel.TabIndex = 98;
            itemPriceIDLabel.Text = "Item Price ID:";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(457, 318);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(310, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtWorda
            // 
            this.txtWorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorda.Location = new System.Drawing.Point(457, 258);
            this.txtWorda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWorda.Name = "txtWorda";
            this.txtWorda.Size = new System.Drawing.Size(118, 20);
            this.txtWorda.TabIndex = 4;
            // 
            // lvEmployee
            // 
            this.lvEmployee.BackColor = System.Drawing.Color.Gainsboro;
            this.lvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployee.FullRowSelect = true;
            this.lvEmployee.GridLines = true;
            this.lvEmployee.HideSelection = false;
            this.lvEmployee.Location = new System.Drawing.Point(4, 0);
            this.lvEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.lvEmployee.MultiSelect = false;
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(235, 491);
            this.lvEmployee.TabIndex = 22;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvEmployee);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 394);
            this.panel3.TabIndex = 25;
            // 
            // lblStoreRemark
            // 
            this.lblStoreRemark.AutoSize = true;
            this.lblStoreRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreRemark.Location = new System.Drawing.Point(331, 326);
            this.lblStoreRemark.Name = "lblStoreRemark";
            this.lblStoreRemark.Size = new System.Drawing.Size(115, 17);
            this.lblStoreRemark.TabIndex = 6;
            this.lblStoreRemark.Text = "Phone Number";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee Name";
            this.columnHeader6.Width = 174;
            // 
            // cboEmpDepartmentId
            // 
            this.cboEmpDepartmentId.DisplayMember = "DepartmentName";
            this.cboEmpDepartmentId.FormattingEnabled = true;
            this.cboEmpDepartmentId.Location = new System.Drawing.Point(457, 106);
            this.cboEmpDepartmentId.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmpDepartmentId.Name = "cboEmpDepartmentId";
            this.cboEmpDepartmentId.Size = new System.Drawing.Size(221, 21);
            this.cboEmpDepartmentId.TabIndex = 27;
            this.cboEmpDepartmentId.ValueMember = "DepartmentId";
            // 
            // txtKebele
            // 
            this.txtKebele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKebele.Location = new System.Drawing.Point(457, 288);
            this.txtKebele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKebele.Name = "txtKebele";
            this.txtKebele.Size = new System.Drawing.Size(265, 20);
            this.txtKebele.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Location = new System.Drawing.Point(457, 68);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(289, 20);
            this.txtEmployeeName.TabIndex = 26;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId.Location = new System.Drawing.Point(459, 31);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(117, 20);
            this.txtEmployeeId.TabIndex = 26;
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(464, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 56;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbpPriceSetting
            // 
            this.tbpPriceSetting.AutoScroll = true;
            this.tbpPriceSetting.Controls.Add(itemPriceIDLabel);
            this.tbpPriceSetting.Controls.Add(this.itemPriceIDTextBox);
            this.tbpPriceSetting.Controls.Add(this.panel4);
            this.tbpPriceSetting.Controls.Add(this.receivedNumberTextBox);
            this.tbpPriceSetting.Controls.Add(receivedNumberLabel1);
            this.tbpPriceSetting.Controls.Add(this.detailNav);
            this.tbpPriceSetting.Controls.Add(receivedNumberLabel);
            this.tbpPriceSetting.Controls.Add(this.remarksTextBox);
            this.tbpPriceSetting.Controls.Add(this.DetailGrid);
            this.tbpPriceSetting.Controls.Add(this.txtEmpName);
            this.tbpPriceSetting.Controls.Add(this.label15);
            this.tbpPriceSetting.Controls.Add(this.label17);
            this.tbpPriceSetting.Controls.Add(this.lblEmployeeId);
            this.tbpPriceSetting.Controls.Add(this.panel5);
            this.tbpPriceSetting.Location = new System.Drawing.Point(4, 22);
            this.tbpPriceSetting.Margin = new System.Windows.Forms.Padding(2);
            this.tbpPriceSetting.Name = "tbpPriceSetting";
            this.tbpPriceSetting.Size = new System.Drawing.Size(732, 626);
            this.tbpPriceSetting.TabIndex = 1;
            this.tbpPriceSetting.Text = "Price Setting";
            this.tbpPriceSetting.UseVisualStyleBackColor = true;
            // 
            // itemPriceIDTextBox
            // 
            this.itemPriceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceSettingsBindingSource, "ItemPriceID", true));
            this.itemPriceIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceIDTextBox.Location = new System.Drawing.Point(500, 13);
            this.itemPriceIDTextBox.Name = "itemPriceIDTextBox";
            this.itemPriceIDTextBox.ReadOnly = true;
            this.itemPriceIDTextBox.Size = new System.Drawing.Size(116, 22);
            this.itemPriceIDTextBox.TabIndex = 99;
            // 
            // itemPriceSettingsBindingSource
            // 
            this.itemPriceSettingsBindingSource.DataMember = "ItemPriceSettings";
            this.itemPriceSettingsBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            this.itemPriceSettingsBindingSource.CurrentChanged += new System.EventHandler(this.itemPriceSettingsBindingSource_CurrentChanged);
            this.itemPriceSettingsBindingSource.PositionChanged += new System.EventHandler(this.itemPriceSettingsBindingSource_PositionChanged);
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.chkFilterByReceiveNo);
            this.panel4.Controls.Add(this.receivedNumberComboBox);
            this.panel4.Location = new System.Drawing.Point(33, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 50);
            this.panel4.TabIndex = 97;
            // 
            // chkFilterByReceiveNo
            // 
            this.chkFilterByReceiveNo.AutoSize = true;
            this.chkFilterByReceiveNo.Enabled = false;
            this.chkFilterByReceiveNo.Location = new System.Drawing.Point(26, 4);
            this.chkFilterByReceiveNo.Name = "chkFilterByReceiveNo";
            this.chkFilterByReceiveNo.Size = new System.Drawing.Size(215, 17);
            this.chkFilterByReceiveNo.TabIndex = 92;
            this.chkFilterByReceiveNo.Text = "Filter Items By Received Number:";
            this.chkFilterByReceiveNo.UseVisualStyleBackColor = true;
            this.chkFilterByReceiveNo.CheckStateChanged += new System.EventHandler(this.chkFilterByReceiveNo_CheckedChanged);
            // 
            // receivedNumberComboBox
            // 
            this.receivedNumberComboBox.DisplayMember = "ReceivedDesc";
            this.receivedNumberComboBox.Enabled = false;
            this.receivedNumberComboBox.FormattingEnabled = true;
            this.receivedNumberComboBox.Location = new System.Drawing.Point(26, 23);
            this.receivedNumberComboBox.Name = "receivedNumberComboBox";
            this.receivedNumberComboBox.Size = new System.Drawing.Size(215, 21);
            this.receivedNumberComboBox.TabIndex = 91;
            this.receivedNumberComboBox.ValueMember = "ReceivedNumber";
            this.receivedNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.receivedNumberComboBox_SelectedIndexChanged);
            this.receivedNumberComboBox.Validated += new System.EventHandler(this.lvUnitMeasurment_SelectedIndexChanged);
            // 
            // receivedNumberTextBox
            // 
            this.receivedNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceSettingsBindingSource, "ReceivedNumber", true));
            this.receivedNumberTextBox.Location = new System.Drawing.Point(161, 127);
            this.receivedNumberTextBox.Name = "receivedNumberTextBox";
            this.receivedNumberTextBox.Size = new System.Drawing.Size(141, 20);
            this.receivedNumberTextBox.TabIndex = 93;
            this.receivedNumberTextBox.TextChanged += new System.EventHandler(this.receivedNumberTextBox_TextChanged);
            // 
            // detailNav
            // 
            this.detailNav.AddNewItem = null;
            this.detailNav.BindingSource = this.itemPriceSettingsDetailsBindingSource;
            this.detailNav.CountItem = this.bindingNavigatorCountItem;
            this.detailNav.DeleteItem = null;
            this.detailNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.detailNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailNavmoveFirst,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.detailNavAddnew,
            this.detailNavSave,
            this.detailNavDelete});
            this.detailNav.Location = new System.Drawing.Point(0, 601);
            this.detailNav.MoveFirstItem = this.detailNavmoveFirst;
            this.detailNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.detailNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.detailNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.detailNav.Name = "detailNav";
            this.detailNav.PositionItem = this.bindingNavigatorPositionItem;
            this.detailNav.Size = new System.Drawing.Size(732, 25);
            this.detailNav.Stretch = true;
            this.detailNav.TabIndex = 86;
            this.detailNav.TabStop = true;
            this.detailNav.Text = "bindingNavigator1";
            // 
            // itemPriceSettingsDetailsBindingSource
            // 
            this.itemPriceSettingsDetailsBindingSource.DataMember = "FK_ItemPriceSettingsDetails_ItemPriceSettings";
            this.itemPriceSettingsDetailsBindingSource.DataSource = this.itemPriceSettingsBindingSource;
            this.itemPriceSettingsDetailsBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.itemPriceSettingsDetailsBindingSource_AddingNew);
            this.itemPriceSettingsDetailsBindingSource.PositionChanged += new System.EventHandler(this.itemPriceSettingsDetailsBindingSource_PositionChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // detailNavmoveFirst
            // 
            this.detailNavmoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.detailNavmoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("detailNavmoveFirst.Image")));
            this.detailNavmoveFirst.Name = "detailNavmoveFirst";
            this.detailNavmoveFirst.RightToLeftAutoMirrorImage = true;
            this.detailNavmoveFirst.Size = new System.Drawing.Size(23, 22);
            this.detailNavmoveFirst.Text = "Move first";
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
            // detailNavAddnew
            // 
            this.detailNavAddnew.Checked = true;
            this.detailNavAddnew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavAddnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("detailNavAddnew.Image")));
            this.detailNavAddnew.Name = "detailNavAddnew";
            this.detailNavAddnew.RightToLeftAutoMirrorImage = true;
            this.detailNavAddnew.Size = new System.Drawing.Size(44, 22);
            this.detailNavAddnew.Text = "+ Add";
            this.detailNavAddnew.Click += new System.EventHandler(this.detailNavAddnew_Click);
            // 
            // detailNavSave
            // 
            this.detailNavSave.Checked = true;
            this.detailNavSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavSave.Image = ((System.Drawing.Image)(resources.GetObject("detailNavSave.Image")));
            this.detailNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavSave.Name = "detailNavSave";
            this.detailNavSave.Size = new System.Drawing.Size(35, 22);
            this.detailNavSave.Text = "&Save";
            this.detailNavSave.Click += new System.EventHandler(this.detailNavSave_Click);
            // 
            // detailNavDelete
            // 
            this.detailNavDelete.Checked = true;
            this.detailNavDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailNavDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.detailNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("detailNavDelete.Image")));
            this.detailNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.detailNavDelete.Name = "detailNavDelete";
            this.detailNavDelete.Size = new System.Drawing.Size(44, 22);
            this.detailNavDelete.Text = "Delete";
            this.detailNavDelete.Click += new System.EventHandler(this.detailNavDelete_Click);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceSettingsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(409, 79);
            this.remarksTextBox.Multiline = true;
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(277, 44);
            this.remarksTextBox.TabIndex = 82;
            // 
            // DetailGrid
            // 
            this.DetailGrid.AllowDrop = true;
            this.DetailGrid.AllowUserToAddRows = false;
            this.DetailGrid.AllowUserToDeleteRows = false;
            this.DetailGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailGrid.AutoGenerateColumns = false;
            this.DetailGrid.CausesValidation = false;
            this.DetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.unitPrceDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.HD});
            this.DetailGrid.DataSource = this.itemPriceSettingsDetailsBindingSource;
            this.DetailGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DetailGrid.Location = new System.Drawing.Point(35, 211);
            this.DetailGrid.Name = "DetailGrid";
            this.DetailGrid.Size = new System.Drawing.Size(661, 361);
            this.DetailGrid.TabIndex = 73;
            this.DetailGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailGrid_CellValueChanged);
            this.DetailGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DetailGrid_ColumnHeaderMouseClick);
            this.DetailGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DetailGrid_DataError);
            this.DetailGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DetailGrid_EditingControlShowing);
            this.DetailGrid.Leave += new System.EventHandler(this.DetailGrid_Leave);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item";
            this.ItemID.Name = "ItemID";
            this.ItemID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemID.Width = 250;
            // 
            // unitPrceDataGridViewTextBoxColumn
            // 
            this.unitPrceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrce";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.unitPrceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.unitPrceDataGridViewTextBoxColumn.HeaderText = "Unit Prce";
            this.unitPrceDataGridViewTextBoxColumn.Name = "unitPrceDataGridViewTextBoxColumn";
            this.unitPrceDataGridViewTextBoxColumn.Width = 110;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.Width = 200;
            // 
            // HD
            // 
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.Visible = false;
            // 
            // txtEmpName
            // 
            this.txtEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemPriceSettingsBindingSource, "EmployeeId", true));
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(465, 578);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(231, 21);
            this.txtEmpName.TabIndex = 70;
            this.txtEmpName.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(412, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 13);
            this.label15.TabIndex = 65;
            this.label15.Text = "Price Setting Remarks";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(34, 194);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 61;
            this.label17.Text = "Items and Prices";
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeId.Location = new System.Drawing.Point(364, 581);
            this.lblEmployeeId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(88, 15);
            this.lblEmployeeId.TabIndex = 61;
            this.lblEmployeeId.Text = "Price Set By:";
            this.lblEmployeeId.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnImportPrices);
            this.panel5.Controls.Add(priceTypeIDLabel);
            this.panel5.Controls.Add(this.priceTypeIDComboBox);
            this.panel5.Controls.Add(this.mainNav);
            this.panel5.Controls.Add(this.settiningDateDateTimePicker);
            this.panel5.Controls.Add(settiningDateLabel);
            this.panel5.Location = new System.Drawing.Point(34, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(657, 130);
            this.panel5.TabIndex = 98;
            // 
            // btnImportPrices
            // 
            this.btnImportPrices.Location = new System.Drawing.Point(505, 93);
            this.btnImportPrices.Name = "btnImportPrices";
            this.btnImportPrices.Size = new System.Drawing.Size(125, 27);
            this.btnImportPrices.TabIndex = 100;
            this.btnImportPrices.Text = "Import Prices...";
            this.btnImportPrices.UseVisualStyleBackColor = true;
            this.btnImportPrices.Click += new System.EventHandler(this.btnImportPrices_Click);
            // 
            // priceTypeIDComboBox
            // 
            this.priceTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemPriceSettingsBindingSource, "PriceTypeID", true));
            this.priceTypeIDComboBox.DataSource = this.itemPriceTypesBindingSource;
            this.priceTypeIDComboBox.DisplayMember = "PriceType";
            this.priceTypeIDComboBox.FormattingEnabled = true;
            this.priceTypeIDComboBox.Location = new System.Drawing.Point(125, 33);
            this.priceTypeIDComboBox.Name = "priceTypeIDComboBox";
            this.priceTypeIDComboBox.Size = new System.Drawing.Size(141, 21);
            this.priceTypeIDComboBox.TabIndex = 88;
            this.priceTypeIDComboBox.ValueMember = "PriceTypeID";
            // 
            // itemPriceTypesBindingSource
            // 
            this.itemPriceTypesBindingSource.DataMember = "ItemPriceTypes";
            this.itemPriceTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // mainNav
            // 
            this.mainNav.AddNewItem = null;
            this.mainNav.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.mainNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainNav.BindingSource = this.itemPriceSettingsBindingSource;
            this.mainNav.CountItem = this.bindingNavigatorCountItem1;
            this.mainNav.DeleteItem = null;
            this.mainNav.Dock = System.Windows.Forms.DockStyle.None;
            this.mainNav.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainNavMoveFirst,
            this.mainNavMoveprev,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.mainNavAddnew,
            this.mainNavSave,
            this.mainNavDelete,
            this.mainNavPrint,
            this.toolStripSeparator1});
            this.mainNav.Location = new System.Drawing.Point(7, 96);
            this.mainNav.MoveFirstItem = this.mainNavMoveFirst;
            this.mainNav.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.mainNav.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.mainNav.MovePreviousItem = this.mainNavMoveprev;
            this.mainNav.Name = "mainNav";
            this.mainNav.PositionItem = this.bindingNavigatorPositionItem1;
            this.mainNav.Size = new System.Drawing.Size(495, 25);
            this.mainNav.TabIndex = 87;
            this.mainNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(47, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // mainNavMoveFirst
            // 
            this.mainNavMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainNavMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("mainNavMoveFirst.Image")));
            this.mainNavMoveFirst.Name = "mainNavMoveFirst";
            this.mainNavMoveFirst.RightToLeftAutoMirrorImage = true;
            this.mainNavMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.mainNavMoveFirst.Text = "Move first";
            // 
            // mainNavMoveprev
            // 
            this.mainNavMoveprev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mainNavMoveprev.Image = ((System.Drawing.Image)(resources.GetObject("mainNavMoveprev.Image")));
            this.mainNavMoveprev.Name = "mainNavMoveprev";
            this.mainNavMoveprev.RightToLeftAutoMirrorImage = true;
            this.mainNavMoveprev.Size = new System.Drawing.Size(23, 22);
            this.mainNavMoveprev.Text = "Move previous";
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
            // mainNavAddnew
            // 
            this.mainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("mainNavAddnew.Image")));
            this.mainNavAddnew.Name = "mainNavAddnew";
            this.mainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.mainNavAddnew.Size = new System.Drawing.Size(85, 22);
            this.mainNavAddnew.Text = "Add new";
            this.mainNavAddnew.Click += new System.EventHandler(this.mainNavAddnew_Click);
            // 
            // mainNavSave
            // 
            this.mainNavSave.Image = ((System.Drawing.Image)(resources.GetObject("mainNavSave.Image")));
            this.mainNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNavSave.Name = "mainNavSave";
            this.mainNavSave.Size = new System.Drawing.Size(60, 22);
            this.mainNavSave.Text = "&Save";
            this.mainNavSave.Click += new System.EventHandler(this.mainNavSave_Click);
            // 
            // mainNavDelete
            // 
            this.mainNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("mainNavDelete.Image")));
            this.mainNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNavDelete.Name = "mainNavDelete";
            this.mainNavDelete.Size = new System.Drawing.Size(70, 22);
            this.mainNavDelete.Text = "Delete";
            this.mainNavDelete.Click += new System.EventHandler(this.mainNavDelete_Click);
            // 
            // mainNavPrint
            // 
            this.mainNavPrint.Image = ((System.Drawing.Image)(resources.GetObject("mainNavPrint.Image")));
            this.mainNavPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mainNavPrint.Name = "mainNavPrint";
            this.mainNavPrint.Size = new System.Drawing.Size(59, 22);
            this.mainNavPrint.Text = "&Print";
            this.mainNavPrint.Click += new System.EventHandler(this.mainNavPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // settiningDateDateTimePicker
            // 
            this.settiningDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.settiningDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.itemPriceSettingsBindingSource, "SettiningDate", true));
            this.settiningDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.settiningDateDateTimePicker.Location = new System.Drawing.Point(125, 6);
            this.settiningDateDateTimePicker.Name = "settiningDateDateTimePicker";
            this.settiningDateDateTimePicker.Size = new System.Drawing.Size(141, 20);
            this.settiningDateDateTimePicker.TabIndex = 76;
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
            // tabSetting
            // 
            this.tabSetting.AccessibleName = "";
            this.tabSetting.Controls.Add(this.tbpPriceSetting);
            this.tabSetting.Controls.Add(this.tbpUnitMeasurment);
            this.tabSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetting.Location = new System.Drawing.Point(0, 0);
            this.tabSetting.Margin = new System.Windows.Forms.Padding(2);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.SelectedIndex = 0;
            this.tabSetting.Size = new System.Drawing.Size(740, 652);
            this.tabSetting.TabIndex = 52;
            this.tabSetting.Tag = "";
            // 
            // tbpUnitMeasurment
            // 
            this.tbpUnitMeasurment.Controls.Add(this.btnClose);
            this.tbpUnitMeasurment.Controls.Add(this.btnDelete);
            this.tbpUnitMeasurment.Controls.Add(this.lvUnitMeasurment);
            this.tbpUnitMeasurment.Controls.Add(this.btnSave);
            this.tbpUnitMeasurment.Controls.Add(this.txtUnitMeasured);
            this.tbpUnitMeasurment.Controls.Add(this.btnAddNew);
            this.tbpUnitMeasurment.Controls.Add(this.txtMeasurementId);
            this.tbpUnitMeasurment.Controls.Add(this.lblUnitMeasured);
            this.tbpUnitMeasurment.Controls.Add(this.lblMeasurementId);
            this.tbpUnitMeasurment.Location = new System.Drawing.Point(4, 22);
            this.tbpUnitMeasurment.Margin = new System.Windows.Forms.Padding(2);
            this.tbpUnitMeasurment.Name = "tbpUnitMeasurment";
            this.tbpUnitMeasurment.Padding = new System.Windows.Forms.Padding(2);
            this.tbpUnitMeasurment.Size = new System.Drawing.Size(732, 630);
            this.tbpUnitMeasurment.TabIndex = 0;
            this.tbpUnitMeasurment.Text = "Unit Measurment";
            this.tbpUnitMeasurment.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(392, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lvUnitMeasurment
            // 
            this.lvUnitMeasurment.BackColor = System.Drawing.Color.Gainsboro;
            this.lvUnitMeasurment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUnitMeasurment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClhUnitMeasurment});
            this.lvUnitMeasurment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvUnitMeasurment.FullRowSelect = true;
            this.lvUnitMeasurment.GridLines = true;
            this.lvUnitMeasurment.HideSelection = false;
            this.lvUnitMeasurment.Location = new System.Drawing.Point(3, 0);
            this.lvUnitMeasurment.MultiSelect = false;
            this.lvUnitMeasurment.Name = "lvUnitMeasurment";
            this.lvUnitMeasurment.Size = new System.Drawing.Size(200, 540);
            this.lvUnitMeasurment.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvUnitMeasurment.TabIndex = 23;
            this.lvUnitMeasurment.UseCompatibleStateImageBehavior = false;
            this.lvUnitMeasurment.View = System.Windows.Forms.View.Details;
            this.lvUnitMeasurment.SelectedIndexChanged += new System.EventHandler(this.lvUnitMeasurment_SelectedIndexChanged);
            // 
            // ClhUnitMeasurment
            // 
            this.ClhUnitMeasurment.Text = "Unit Measured By";
            this.ClhUnitMeasurment.Width = 202;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(320, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUnitMeasured
            // 
            this.txtUnitMeasured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitMeasured.Enabled = false;
            this.txtUnitMeasured.Location = new System.Drawing.Point(337, 146);
            this.txtUnitMeasured.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitMeasured.Name = "txtUnitMeasured";
            this.txtUnitMeasured.Size = new System.Drawing.Size(211, 20);
            this.txtUnitMeasured.TabIndex = 31;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Enabled = false;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(248, 414);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(77, 23);
            this.btnAddNew.TabIndex = 53;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // txtMeasurementId
            // 
            this.txtMeasurementId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMeasurementId.Enabled = false;
            this.txtMeasurementId.Location = new System.Drawing.Point(337, 114);
            this.txtMeasurementId.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeasurementId.Name = "txtMeasurementId";
            this.txtMeasurementId.Size = new System.Drawing.Size(104, 20);
            this.txtMeasurementId.TabIndex = 30;
            // 
            // lblUnitMeasured
            // 
            this.lblUnitMeasured.AutoSize = true;
            this.lblUnitMeasured.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitMeasured.Location = new System.Drawing.Point(208, 146);
            this.lblUnitMeasured.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitMeasured.Name = "lblUnitMeasured";
            this.lblUnitMeasured.Size = new System.Drawing.Size(120, 15);
            this.lblUnitMeasured.TabIndex = 28;
            this.lblUnitMeasured.Text = "Unit Measured By";
            // 
            // lblMeasurementId
            // 
            this.lblMeasurementId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasurementId.Location = new System.Drawing.Point(208, 118);
            this.lblMeasurementId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMeasurementId.Name = "lblMeasurementId";
            this.lblMeasurementId.Size = new System.Drawing.Size(115, 14);
            this.lblMeasurementId.TabIndex = 27;
            this.lblMeasurementId.Text = "Measurement Id";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(459, 31);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(117, 20);
            this.textBox9.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "DepartmentName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(457, 106);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(221, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.ValueMember = "DepartmentId";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 394);
            this.panel2.TabIndex = 25;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Gainsboro;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(4, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(235, 491);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee Name";
            this.columnHeader2.Width = 174;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(457, 68);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(289, 20);
            this.textBox10.TabIndex = 26;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(457, 288);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(265, 20);
            this.textBox8.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Worda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Department";
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(457, 258);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 20);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(457, 318);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(310, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(295, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Employee Id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(295, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Full Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(331, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Worda";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(295, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Department";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kebele";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Phone Number";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(457, 258);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(457, 318);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "DepartmentName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "DepartmentId";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(457, 288);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 20);
            this.textBox3.TabIndex = 3;
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreId.Location = new System.Drawing.Point(331, 261);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(58, 18);
            this.lblStoreId.TabIndex = 0;
            this.lblStoreId.Text = "Worda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(331, 294);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(59, 18);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "Kebele";
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchId.Location = new System.Drawing.Point(295, 106);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(95, 18);
            this.lblBranchId.TabIndex = 1;
            this.lblBranchId.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kebele";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(295, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Employee Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Full Name";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(457, 68);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(289, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(459, 31);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 26;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(235, 491);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Employee Name";
            this.columnHeader1.Width = 174;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 394);
            this.panel1.TabIndex = 25;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // itemPriceSettingsDetailsTableAdapter
            // 
            this.itemPriceSettingsDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // itemPriceSettingsTableAdapter
            // 
            this.itemPriceSettingsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SettingDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Setting Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UnitPrce";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Unit Prce";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarks";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 190;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SettingDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "SettingDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrce";
            this.dataGridViewTextBoxColumn5.HeaderText = "UnitPrce";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn6.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // itemPriceTypesTableAdapter
            // 
            this.itemPriceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 652);
            this.Controls.Add(this.tabSetting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.Text = "Setting Information";
            this.Activated += new System.EventHandler(this.frmSetting_Activated);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.panel3.ResumeLayout(false);
            this.tbpPriceSetting.ResumeLayout(false);
            this.tbpPriceSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailNav)).EndInit();
            this.detailNav.ResumeLayout(false);
            this.detailNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceSettingsDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailGrid)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainNav)).EndInit();
            this.mainNav.ResumeLayout(false);
            this.mainNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            this.tabSetting.ResumeLayout(false);
            this.tbpUnitMeasurment.ResumeLayout(false);
            this.tbpUnitMeasurment.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtWorda;
        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStoreRemark;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox cboEmpDepartmentId;
        private System.Windows.Forms.TextBox txtKebele;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tbpPriceSetting;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TabControl tabSetting;
        private System.Windows.Forms.TabPage tbpUnitMeasurment;
        private System.Windows.Forms.TextBox txtUnitMeasured;
        private System.Windows.Forms.TextBox txtMeasurementId;
        private System.Windows.Forms.Label lblUnitMeasured;
        private System.Windows.Forms.Label lblMeasurementId;
        private System.Windows.Forms.ListView lvUnitMeasurment;
        private System.Windows.Forms.ColumnHeader ClhUnitMeasurment;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.DataGridView DetailGrid;
        private System.Windows.Forms.Label label17;
        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceSettingsDetailsTableAdapter itemPriceSettingsDetailsTableAdapter;
        private System.Windows.Forms.BindingSource itemPriceSettingsBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceSettingsTableAdapter itemPriceSettingsTableAdapter;
        private System.Windows.Forms.DateTimePicker settiningDateDateTimePicker;
        private System.Windows.Forms.TextBox remarksTextBox;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.BindingNavigator mainNav;
        private System.Windows.Forms.ToolStripButton mainNavAddnew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton mainNavMoveFirst;
        private System.Windows.Forms.ToolStripButton mainNavMoveprev;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripButton mainNavDelete;
        private System.Windows.Forms.ToolStripButton mainNavSave;
        private System.Windows.Forms.ToolStripButton mainNavPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.BindingNavigator detailNav;
        private System.Windows.Forms.ToolStripButton detailNavAddnew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton detailNavmoveFirst;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton detailNavSave;
        private System.Windows.Forms.ToolStripButton detailNavDelete;
        private System.Windows.Forms.BindingSource itemPriceSettingsDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.CheckBox chkFilterByReceiveNo;
        private System.Windows.Forms.ComboBox receivedNumberComboBox;
        private System.Windows.Forms.TextBox receivedNumberTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox priceTypeIDComboBox;
        private System.Windows.Forms.BindingSource itemPriceTypesBindingSource;
        private BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPriceTypesTableAdapter itemPriceTypesTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.TextBox itemPriceIDTextBox;
        private System.Windows.Forms.Button btnImportPrices;
    }
}