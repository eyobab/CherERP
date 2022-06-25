namespace Belayab
{
    partial class frmCustomersSuppliers
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
            this.tabSupplier_Customer = new System.Windows.Forms.TabControl();
            this.tbpSupplier = new System.Windows.Forms.TabPage();
            this.lvSupplier = new System.Windows.Forms.ListView();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPOBox = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPoBox = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.tbpCustomer = new System.Windows.Forms.TabPage();
            this.btnAdressDetails = new System.Windows.Forms.Button();
            this.btnEditCustomerType = new System.Windows.Forms.Button();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.customerTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbInvoices = new Belayab.BelayAbInvoices();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContactTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnAllCustomer = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimeVatRegdate = new System.Windows.Forms.DateTimePicker();
            this.txtTINNumber = new System.Windows.Forms.TextBox();
            this.txtVatRegNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblStoreRemark = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtWordaId = new System.Windows.Forms.TextBox();
            this.txtKebele = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.customerTypesTableAdapter = new Belayab.BelayAbInvoicesTableAdapters.CustomerTypesTableAdapter();
            this.lblSaved = new System.Windows.Forms.Label();
            this.tabSupplier_Customer.SuspendLayout();
            this.tbpSupplier.SuspendLayout();
            this.tbpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSupplier_Customer
            // 
            this.tabSupplier_Customer.AccessibleName = "";
            this.tabSupplier_Customer.Controls.Add(this.tbpSupplier);
            this.tabSupplier_Customer.Controls.Add(this.tbpCustomer);
            this.tabSupplier_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSupplier_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSupplier_Customer.Location = new System.Drawing.Point(0, 0);
            this.tabSupplier_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.tabSupplier_Customer.Name = "tabSupplier_Customer";
            this.tabSupplier_Customer.SelectedIndex = 0;
            this.tabSupplier_Customer.Size = new System.Drawing.Size(774, 508);
            this.tabSupplier_Customer.TabIndex = 4;
            this.tabSupplier_Customer.Tag = "";
            // 
            // tbpSupplier
            // 
            this.tbpSupplier.Controls.Add(this.lvSupplier);
            this.tbpSupplier.Controls.Add(this.txtEmailAddress);
            this.tbpSupplier.Controls.Add(this.txtPOBox);
            this.tbpSupplier.Controls.Add(this.lblEmailAddress);
            this.tbpSupplier.Controls.Add(this.lblPoBox);
            this.tbpSupplier.Controls.Add(this.txtTelephone);
            this.tbpSupplier.Controls.Add(this.txtSupplierName);
            this.tbpSupplier.Controls.Add(this.txtSupplierId);
            this.tbpSupplier.Controls.Add(this.lblLocation);
            this.tbpSupplier.Controls.Add(this.lblBranchName);
            this.tbpSupplier.Controls.Add(this.lblDepartmentId);
            this.tbpSupplier.Location = new System.Drawing.Point(4, 22);
            this.tbpSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.tbpSupplier.Name = "tbpSupplier";
            this.tbpSupplier.Padding = new System.Windows.Forms.Padding(2);
            this.tbpSupplier.Size = new System.Drawing.Size(766, 482);
            this.tbpSupplier.TabIndex = 0;
            this.tbpSupplier.Text = "Supplier";
            this.tbpSupplier.UseVisualStyleBackColor = true;
            // 
            // lvSupplier
            // 
            this.lvSupplier.BackColor = System.Drawing.Color.Gainsboro;
            this.lvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSupplier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvSupplier.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSupplier.FullRowSelect = true;
            this.lvSupplier.GridLines = true;
            this.lvSupplier.HideSelection = false;
            this.lvSupplier.Location = new System.Drawing.Point(2, 0);
            this.lvSupplier.MultiSelect = false;
            this.lvSupplier.Name = "lvSupplier";
            this.lvSupplier.Size = new System.Drawing.Size(265, 414);
            this.lvSupplier.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSupplier.TabIndex = 23;
            this.lvSupplier.UseCompatibleStateImageBehavior = false;
            this.lvSupplier.View = System.Windows.Forms.View.Details;
            this.lvSupplier.SelectedIndexChanged += new System.EventHandler(this.lvSupplier_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Supplier Name";
            this.columnHeader12.Width = 300;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Location = new System.Drawing.Point(396, 215);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(217, 20);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // txtPOBox
            // 
            this.txtPOBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOBox.Location = new System.Drawing.Point(395, 189);
            this.txtPOBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtPOBox.Name = "txtPOBox";
            this.txtPOBox.Size = new System.Drawing.Size(201, 20);
            this.txtPOBox.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(303, 219);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(86, 13);
            this.lblEmailAddress.TabIndex = 34;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblPoBox
            // 
            this.lblPoBox.AutoSize = true;
            this.lblPoBox.Location = new System.Drawing.Point(336, 194);
            this.lblPoBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoBox.Name = "lblPoBox";
            this.lblPoBox.Size = new System.Drawing.Size(53, 13);
            this.lblPoBox.TabIndex = 33;
            this.lblPoBox.Text = "P O Box";
            // 
            // txtTelephone
            // 
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephone.Location = new System.Drawing.Point(395, 162);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(115, 20);
            this.txtTelephone.TabIndex = 2;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Location = new System.Drawing.Point(395, 135);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(257, 20);
            this.txtSupplierName.TabIndex = 1;
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierId.Location = new System.Drawing.Point(395, 106);
            this.txtSupplierId.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(104, 20);
            this.txtSupplierId.TabIndex = 0;
            this.txtSupplierId.Visible = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(314, 164);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 15);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Telephone";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(282, 137);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(107, 15);
            this.lblBranchName.TabIndex = 28;
            this.lblBranchName.Text = "Supplier  Name";
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.Location = new System.Drawing.Point(310, 110);
            this.lblDepartmentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(79, 14);
            this.lblDepartmentId.TabIndex = 27;
            this.lblDepartmentId.Text = "Supplier Id";
            this.lblDepartmentId.Visible = false;
            // 
            // tbpCustomer
            // 
            this.tbpCustomer.Controls.Add(this.btnAdressDetails);
            this.tbpCustomer.Controls.Add(this.btnEditCustomerType);
            this.tbpCustomer.Controls.Add(this.cboCustomerType);
            this.tbpCustomer.Controls.Add(this.label8);
            this.tbpCustomer.Controls.Add(this.txtContactTel);
            this.tbpCustomer.Controls.Add(this.label7);
            this.tbpCustomer.Controls.Add(this.groupBox1);
            this.tbpCustomer.Controls.Add(this.btnAllCustomer);
            this.tbpCustomer.Controls.Add(this.btnPrint);
            this.tbpCustomer.Controls.Add(this.dateTimeVatRegdate);
            this.tbpCustomer.Controls.Add(this.txtTINNumber);
            this.tbpCustomer.Controls.Add(this.txtVatRegNumber);
            this.tbpCustomer.Controls.Add(this.label5);
            this.tbpCustomer.Controls.Add(this.label4);
            this.tbpCustomer.Controls.Add(this.label2);
            this.tbpCustomer.Controls.Add(this.lvCustomer);
            this.tbpCustomer.Controls.Add(this.lblCountry);
            this.tbpCustomer.Controls.Add(this.txtCountry);
            this.tbpCustomer.Controls.Add(this.txtCity);
            this.tbpCustomer.Controls.Add(this.lblCity);
            this.tbpCustomer.Controls.Add(this.txtCustomerId);
            this.tbpCustomer.Controls.Add(this.txtCustomerName);
            this.tbpCustomer.Controls.Add(this.lblStoreRemark);
            this.tbpCustomer.Controls.Add(this.txtCustomerPhone);
            this.tbpCustomer.Controls.Add(this.txtWordaId);
            this.tbpCustomer.Controls.Add(this.txtKebele);
            this.tbpCustomer.Controls.Add(this.lblStoreName);
            this.tbpCustomer.Controls.Add(this.label3);
            this.tbpCustomer.Controls.Add(this.label1);
            this.tbpCustomer.Controls.Add(this.lblStoreId);
            this.tbpCustomer.Location = new System.Drawing.Point(4, 22);
            this.tbpCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.tbpCustomer.Name = "tbpCustomer";
            this.tbpCustomer.Padding = new System.Windows.Forms.Padding(2);
            this.tbpCustomer.Size = new System.Drawing.Size(766, 482);
            this.tbpCustomer.TabIndex = 1;
            this.tbpCustomer.Text = "Customer";
            this.tbpCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAdressDetails
            // 
            this.btnAdressDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdressDetails.Location = new System.Drawing.Point(573, 208);
            this.btnAdressDetails.Name = "btnAdressDetails";
            this.btnAdressDetails.Size = new System.Drawing.Size(32, 23);
            this.btnAdressDetails.TabIndex = 42;
            this.btnAdressDetails.Text = "...";
            this.btnAdressDetails.UseVisualStyleBackColor = true;
            this.btnAdressDetails.Click += new System.EventHandler(this.btnAdressDetails_Click);
            // 
            // btnEditCustomerType
            // 
            this.btnEditCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomerType.Location = new System.Drawing.Point(727, 187);
            this.btnEditCustomerType.Name = "btnEditCustomerType";
            this.btnEditCustomerType.Size = new System.Drawing.Size(32, 23);
            this.btnEditCustomerType.TabIndex = 42;
            this.btnEditCustomerType.Text = "...";
            this.btnEditCustomerType.UseVisualStyleBackColor = true;
            this.btnEditCustomerType.Click += new System.EventHandler(this.btnEditCustomerType_Click);
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.DataSource = this.customerTypesBindingSource;
            this.cboCustomerType.DisplayMember = "CustomerTypeName";
            this.cboCustomerType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Location = new System.Drawing.Point(617, 164);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(143, 21);
            this.cboCustomerType.TabIndex = 10;
            this.cboCustomerType.ValueMember = "CustomerTypeId";
            // 
            // customerTypesBindingSource
            // 
            this.customerTypesBindingSource.DataMember = "CustomerTypes";
            this.customerTypesBindingSource.DataSource = this.belayAbInvoices;
            // 
            // belayAbInvoices
            // 
            this.belayAbInvoices.DataSetName = "BelayAbInvoices";
            this.belayAbInvoices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Telephone No";
            // 
            // txtContactTel
            // 
            this.txtContactTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContactTel.Location = new System.Drawing.Point(446, 210);
            this.txtContactTel.Name = "txtContactTel";
            this.txtContactTel.Size = new System.Drawing.Size(126, 20);
            this.txtContactTel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(613, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Customer Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFind);
            this.groupBox1.Location = new System.Drawing.Point(446, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 42);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Find>>";
            // 
            // txtFind
            // 
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(72, 14);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(170, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnAllCustomer
            // 
            this.btnAllCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllCustomer.Location = new System.Drawing.Point(613, 355);
            this.btnAllCustomer.Name = "btnAllCustomer";
            this.btnAllCustomer.Size = new System.Drawing.Size(126, 23);
            this.btnAllCustomer.TabIndex = 12;
            this.btnAllCustomer.Text = "Print All Customers";
            this.btnAllCustomer.UseVisualStyleBackColor = true;
            this.btnAllCustomer.Click += new System.EventHandler(this.btnAllCustomer_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(640, 329);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print PreView";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateTimeVatRegdate
            // 
            this.dateTimeVatRegdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVatRegdate.Location = new System.Drawing.Point(446, 272);
            this.dateTimeVatRegdate.Name = "dateTimeVatRegdate";
            this.dateTimeVatRegdate.Size = new System.Drawing.Size(127, 20);
            this.dateTimeVatRegdate.TabIndex = 6;
            // 
            // txtTINNumber
            // 
            this.txtTINNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTINNumber.Location = new System.Drawing.Point(446, 298);
            this.txtTINNumber.Name = "txtTINNumber";
            this.txtTINNumber.Size = new System.Drawing.Size(127, 20);
            this.txtTINNumber.TabIndex = 7;
            // 
            // txtVatRegNumber
            // 
            this.txtVatRegNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVatRegNumber.Location = new System.Drawing.Point(446, 242);
            this.txtVatRegNumber.Name = "txtVatRegNumber";
            this.txtVatRegNumber.Size = new System.Drawing.Size(126, 20);
            this.txtVatRegNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "TINNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "VATRegNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "VATRegDate";
            // 
            // lvCustomer
            // 
            this.lvCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.lvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCustomer.FullRowSelect = true;
            this.lvCustomer.GridLines = true;
            this.lvCustomer.HideSelection = false;
            this.lvCustomer.Location = new System.Drawing.Point(0, 0);
            this.lvCustomer.MultiSelect = false;
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(303, 427);
            this.lvCustomer.TabIndex = 10;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.Details;
            this.lvCustomer.SelectedIndexChanged += new System.EventHandler(this.lvCustomer_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Customer Name";
            this.columnHeader6.Width = 300;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(391, 367);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(50, 13);
            this.lblCountry.TabIndex = 30;
            this.lblCountry.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Location = new System.Drawing.Point(446, 358);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(127, 20);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.Text = "Ethiopia";
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(446, 328);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(127, 20);
            this.txtCity.TabIndex = 8;
            this.txtCity.Text = "Addis Ababa";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(412, 329);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 13);
            this.lblCity.TabIndex = 27;
            this.lblCity.Text = "City";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerId.Location = new System.Drawing.Point(330, 9);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(34, 20);
            this.txtCustomerId.TabIndex = 0;
            this.txtCustomerId.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(446, 69);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(317, 34);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lblStoreRemark
            // 
            this.lblStoreRemark.AutoSize = true;
            this.lblStoreRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreRemark.Location = new System.Drawing.Point(374, 187);
            this.lblStoreRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreRemark.Name = "lblStoreRemark";
            this.lblStoreRemark.Size = new System.Drawing.Size(67, 13);
            this.lblStoreRemark.TabIndex = 6;
            this.lblStoreRemark.Text = "House No.";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Location = new System.Drawing.Point(446, 178);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(128, 20);
            this.txtCustomerPhone.TabIndex = 3;
            // 
            // txtWordaId
            // 
            this.txtWordaId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWordaId.Location = new System.Drawing.Point(446, 118);
            this.txtWordaId.Margin = new System.Windows.Forms.Padding(2);
            this.txtWordaId.Name = "txtWordaId";
            this.txtWordaId.Size = new System.Drawing.Size(199, 20);
            this.txtWordaId.TabIndex = 1;
            // 
            // txtKebele
            // 
            this.txtKebele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKebele.Location = new System.Drawing.Point(446, 148);
            this.txtKebele.Margin = new System.Windows.Forms.Padding(2);
            this.txtKebele.Name = "txtKebele";
            this.txtKebele.Size = new System.Drawing.Size(127, 20);
            this.txtKebele.TabIndex = 2;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(389, 155);
            this.lblStoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(52, 15);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "Kebele";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer  Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id";
            this.label1.Visible = false;
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreId.Location = new System.Drawing.Point(394, 123);
            this.lblStoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(47, 15);
            this.lblStoreId.TabIndex = 0;
            this.lblStoreId.Text = "S. City";
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(207, 9);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(77, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(280, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(352, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(423, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.lblSaved);
            this.grp1.Controls.Add(this.btnClose);
            this.grp1.Controls.Add(this.btnDelete);
            this.grp1.Controls.Add(this.btnSave);
            this.grp1.Controls.Add(this.btnAddNew);
            this.grp1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp1.Location = new System.Drawing.Point(0, 474);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(774, 34);
            this.grp1.TabIndex = 5;
            this.grp1.TabStop = false;
            // 
            // customerTypesTableAdapter
            // 
            this.customerTypesTableAdapter.ClearBeforeFill = true;
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Location = new System.Drawing.Point(7, 16);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(16, 13);
            this.lblSaved.TabIndex = 4;
            this.lblSaved.Text = "   ";
            // 
            // frmCustomersSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 508);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.tabSupplier_Customer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCustomersSuppliers";
            this.Text = "Customer and Supplier Information";
            this.Load += new System.EventHandler(this.frmCustomersSuppliers_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomersSuppliers_FormClosed);
            this.Resize += new System.EventHandler(this.frmCustomersSuppliers_Resize);
            this.tabSupplier_Customer.ResumeLayout(false);
            this.tbpSupplier.ResumeLayout(false);
            this.tbpSupplier.PerformLayout();
            this.tbpCustomer.ResumeLayout(false);
            this.tbpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbInvoices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpSupplier;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabPage tbpCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblStoreRemark;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtWordaId;
        private System.Windows.Forms.TextBox txtKebele;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPoBox;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPOBox;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTINNumber;
        private System.Windows.Forms.TextBox txtVatRegNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeVatRegdate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAllCustomer;
        public System.Windows.Forms.TabControl tabSupplier_Customer;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grp1;
        public System.Windows.Forms.ListView lvSupplier;
        public System.Windows.Forms.ListView lvCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContactTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private BelayAbInvoices belayAbInvoices;
        private System.Windows.Forms.BindingSource customerTypesBindingSource;
        private Belayab.BelayAbInvoicesTableAdapters.CustomerTypesTableAdapter customerTypesTableAdapter;
        private System.Windows.Forms.Button btnEditCustomerType;
        private System.Windows.Forms.Button btnAdressDetails;
        private System.Windows.Forms.Label lblSaved;
    }
}