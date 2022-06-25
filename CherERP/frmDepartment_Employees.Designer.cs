namespace Belayab
{
    partial class frmDepartment_Employees
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
            System.Windows.Forms.Label storeIDLabel;
            System.Windows.Forms.Label officeTelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartment_Employees));
            this.tbpEmployee = new System.Windows.Forms.TabPage();
            this.officeTelTextBox = new System.Windows.Forms.TextBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmployees = new Belayab.dsEmployees();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.iStoreListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cboEmpDepartmentId = new System.Windows.Forms.ComboBox();
            this.departmentLstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.btnPrintAllEmployee = new System.Windows.Forms.Button();
            this.btnEmployeePrint = new System.Windows.Forms.Button();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.imgPhoto = new System.Windows.Forms.PictureBox();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblStoreRemark = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtWorda = new System.Windows.Forms.TextBox();
            this.txtKebele = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.tbpDepartment = new System.Windows.Forms.TabPage();
            this.lvDepartment = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txDepartmentName = new System.Windows.Forms.TextBox();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daSql = new System.Data.SqlClient.SqlDataAdapter();
            this.departmentLstTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter();
            this.i_StoreListTableAdapter = new Belayab.dsEmployeesTableAdapters.I_StoreListTableAdapter();
            this.employeesTableAdapter = new Belayab.dsEmployeesTableAdapters.EmployeesTableAdapter();
            storeIDLabel = new System.Windows.Forms.Label();
            officeTelLabel = new System.Windows.Forms.Label();
            this.tbpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iStoreListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).BeginInit();
            this.tbpDepartment.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeIDLabel
            // 
            storeIDLabel.AutoSize = true;
            storeIDLabel.Location = new System.Drawing.Point(222, 114);
            storeIDLabel.Name = "storeIDLabel";
            storeIDLabel.Size = new System.Drawing.Size(60, 13);
            storeIDLabel.TabIndex = 33;
            storeIDLabel.Text = "Location:";
            // 
            // officeTelLabel
            // 
            officeTelLabel.AutoSize = true;
            officeTelLabel.Location = new System.Drawing.Point(211, 149);
            officeTelLabel.Name = "officeTelLabel";
            officeTelLabel.Size = new System.Drawing.Size(71, 13);
            officeTelLabel.TabIndex = 34;
            officeTelLabel.Text = "Telephone:";
            // 
            // tbpEmployee
            // 
            this.tbpEmployee.AutoScroll = true;
            this.tbpEmployee.Controls.Add(officeTelLabel);
            this.tbpEmployee.Controls.Add(this.officeTelTextBox);
            this.tbpEmployee.Controls.Add(storeIDLabel);
            this.tbpEmployee.Controls.Add(this.storeIDComboBox);
            this.tbpEmployee.Controls.Add(this.label2);
            this.tbpEmployee.Controls.Add(this.cboEmpDepartmentId);
            this.tbpEmployee.Controls.Add(this.btnPrintAllEmployee);
            this.tbpEmployee.Controls.Add(this.btnEmployeePrint);
            this.tbpEmployee.Controls.Add(this.lvEmployee);
            this.tbpEmployee.Controls.Add(this.btnChangePhoto);
            this.tbpEmployee.Controls.Add(this.imgPhoto);
            this.tbpEmployee.Controls.Add(this.txtEmployeeId);
            this.tbpEmployee.Controls.Add(this.txtEmployeeName);
            this.tbpEmployee.Controls.Add(this.lblStoreRemark);
            this.tbpEmployee.Controls.Add(this.txtPhone);
            this.tbpEmployee.Controls.Add(this.txtWorda);
            this.tbpEmployee.Controls.Add(this.txtKebele);
            this.tbpEmployee.Controls.Add(this.lblStoreName);
            this.tbpEmployee.Controls.Add(this.label3);
            this.tbpEmployee.Controls.Add(this.label1);
            this.tbpEmployee.Controls.Add(this.lblBranchId);
            this.tbpEmployee.Controls.Add(this.lblStoreId);
            this.tbpEmployee.Location = new System.Drawing.Point(4, 22);
            this.tbpEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tbpEmployee.Name = "tbpEmployee";
            this.tbpEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.tbpEmployee.Size = new System.Drawing.Size(730, 337);
            this.tbpEmployee.TabIndex = 1;
            this.tbpEmployee.Text = "Employee";
            this.tbpEmployee.UseVisualStyleBackColor = true;
            // 
            // officeTelTextBox
            // 
            this.officeTelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "OfficeTel", true));
            this.officeTelTextBox.Location = new System.Drawing.Point(294, 146);
            this.officeTelTextBox.Name = "officeTelTextBox";
            this.officeTelTextBox.Size = new System.Drawing.Size(205, 20);
            this.officeTelTextBox.TabIndex = 35;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.dsEmployees;
            // 
            // dsEmployees
            // 
            this.dsEmployees.DataSetName = "dsEmployees";
            this.dsEmployees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "StoreID", true));
            this.storeIDComboBox.DataSource = this.iStoreListBindingSource;
            this.storeIDComboBox.DisplayMember = "StoreName";
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(294, 111);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(186, 21);
            this.storeIDComboBox.TabIndex = 34;
            this.storeIDComboBox.ValueMember = "StoreId";
            // 
            // iStoreListBindingSource
            // 
            this.iStoreListBindingSource.DataMember = "I_StoreList";
            this.iStoreListBindingSource.DataSource = this.dsEmployees;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Photo";
            // 
            // cboEmpDepartmentId
            // 
            this.cboEmpDepartmentId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "DepartmentId", true));
            this.cboEmpDepartmentId.DataSource = this.departmentLstBindingSource;
            this.cboEmpDepartmentId.DisplayMember = "DepartmentName";
            this.cboEmpDepartmentId.FormattingEnabled = true;
            this.cboEmpDepartmentId.Location = new System.Drawing.Point(295, 74);
            this.cboEmpDepartmentId.Name = "cboEmpDepartmentId";
            this.cboEmpDepartmentId.Size = new System.Drawing.Size(211, 21);
            this.cboEmpDepartmentId.TabIndex = 2;
            this.cboEmpDepartmentId.ValueMember = "DepartmentId";
            // 
            // departmentLstBindingSource
            // 
            this.departmentLstBindingSource.DataMember = "DepartmentLst";
            this.departmentLstBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrintAllEmployee
            // 
            this.btnPrintAllEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAllEmployee.Location = new System.Drawing.Point(494, 309);
            this.btnPrintAllEmployee.Name = "btnPrintAllEmployee";
            this.btnPrintAllEmployee.Size = new System.Drawing.Size(187, 23);
            this.btnPrintAllEmployee.TabIndex = 8;
            this.btnPrintAllEmployee.Text = "Employee List Print preview";
            this.btnPrintAllEmployee.UseVisualStyleBackColor = true;
            this.btnPrintAllEmployee.Click += new System.EventHandler(this.btnPrintAllEmployee_Click);
            // 
            // btnEmployeePrint
            // 
            this.btnEmployeePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeePrint.Location = new System.Drawing.Point(533, 280);
            this.btnEmployeePrint.Name = "btnEmployeePrint";
            this.btnEmployeePrint.Size = new System.Drawing.Size(148, 23);
            this.btnEmployeePrint.TabIndex = 7;
            this.btnEmployeePrint.Text = "Print PreView";
            this.btnEmployeePrint.UseVisualStyleBackColor = true;
            this.btnEmployeePrint.Click += new System.EventHandler(this.btnEmployeePrint_Click);
            // 
            // lvEmployee
            // 
            this.lvEmployee.BackColor = System.Drawing.Color.Gainsboro;
            this.lvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvEmployee.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployee.FullRowSelect = true;
            this.lvEmployee.GridLines = true;
            this.lvEmployee.HideSelection = false;
            this.lvEmployee.Location = new System.Drawing.Point(3, 2);
            this.lvEmployee.MultiSelect = false;
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(172, 330);
            this.lvEmployee.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEmployee.TabIndex = 9;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
            this.lvEmployee.SelectedIndexChanged += new System.EventHandler(this.lvEmployee_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Employee Name";
            this.columnHeader6.Width = 170;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhoto.Location = new System.Drawing.Point(558, 199);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(75, 24);
            this.btnChangePhoto.TabIndex = 6;
            this.btnChangePhoto.Text = "Change...";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // imgPhoto
            // 
            this.imgPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgPhoto.InitialImage")));
            this.imgPhoto.Location = new System.Drawing.Point(541, 84);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(112, 113);
            this.imgPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPhoto.TabIndex = 28;
            this.imgPhoto.TabStop = false;
            this.imgPhoto.Click += new System.EventHandler(this.imgPhoto_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeId", true));
            this.txtEmployeeId.Location = new System.Drawing.Point(295, 12);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(88, 20);
            this.txtEmployeeId.TabIndex = 0;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeName", true));
            this.txtEmployeeName.Location = new System.Drawing.Point(294, 42);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(249, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // lblStoreRemark
            // 
            this.lblStoreRemark.AutoSize = true;
            this.lblStoreRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreRemark.Location = new System.Drawing.Point(192, 235);
            this.lblStoreRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreRemark.Name = "lblStoreRemark";
            this.lblStoreRemark.Size = new System.Drawing.Size(90, 13);
            this.lblStoreRemark.TabIndex = 6;
            this.lblStoreRemark.Text = "Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(296, 226);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(233, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtWorda
            // 
            this.txtWorda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorda.Location = new System.Drawing.Point(296, 178);
            this.txtWorda.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorda.Name = "txtWorda";
            this.txtWorda.Size = new System.Drawing.Size(89, 20);
            this.txtWorda.TabIndex = 3;
            // 
            // txtKebele
            // 
            this.txtKebele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKebele.Location = new System.Drawing.Point(296, 202);
            this.txtKebele.Margin = new System.Windows.Forms.Padding(2);
            this.txtKebele.Name = "txtKebele";
            this.txtKebele.Size = new System.Drawing.Size(199, 20);
            this.txtKebele.TabIndex = 4;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(230, 209);
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
            this.label3.Location = new System.Drawing.Point(209, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Id";
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchId.Location = new System.Drawing.Point(200, 76);
            this.lblBranchId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(82, 15);
            this.lblBranchId.TabIndex = 1;
            this.lblBranchId.Text = "Department";
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreId.Location = new System.Drawing.Point(234, 182);
            this.lblStoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(48, 15);
            this.lblStoreId.TabIndex = 0;
            this.lblStoreId.Text = "Worda";
            // 
            // tbpDepartment
            // 
            this.tbpDepartment.Controls.Add(this.lvDepartment);
            this.tbpDepartment.Controls.Add(this.txtHead);
            this.tbpDepartment.Controls.Add(this.txDepartmentName);
            this.tbpDepartment.Controls.Add(this.txtDepartmentId);
            this.tbpDepartment.Controls.Add(this.lblLocation);
            this.tbpDepartment.Controls.Add(this.lblBranchName);
            this.tbpDepartment.Controls.Add(this.lblDepartmentId);
            this.tbpDepartment.Location = new System.Drawing.Point(4, 22);
            this.tbpDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.tbpDepartment.Name = "tbpDepartment";
            this.tbpDepartment.Padding = new System.Windows.Forms.Padding(2);
            this.tbpDepartment.Size = new System.Drawing.Size(730, 337);
            this.tbpDepartment.TabIndex = 0;
            this.tbpDepartment.Text = "Department";
            this.tbpDepartment.UseVisualStyleBackColor = true;
            // 
            // lvDepartment
            // 
            this.lvDepartment.BackColor = System.Drawing.Color.Gainsboro;
            this.lvDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDepartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvDepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDepartment.FullRowSelect = true;
            this.lvDepartment.GridLines = true;
            this.lvDepartment.HideSelection = false;
            this.lvDepartment.Location = new System.Drawing.Point(0, 0);
            this.lvDepartment.MultiSelect = false;
            this.lvDepartment.Name = "lvDepartment";
            this.lvDepartment.Size = new System.Drawing.Size(172, 332);
            this.lvDepartment.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvDepartment.TabIndex = 3;
            this.lvDepartment.UseCompatibleStateImageBehavior = false;
            this.lvDepartment.View = System.Windows.Forms.View.Details;
            this.lvDepartment.SelectedIndexChanged += new System.EventHandler(this.lvDepartment_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Department Name";
            this.columnHeader12.Width = 170;
            // 
            // txtHead
            // 
            this.txtHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHead.Location = new System.Drawing.Point(337, 173);
            this.txtHead.Margin = new System.Windows.Forms.Padding(2);
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(115, 20);
            this.txtHead.TabIndex = 2;
            // 
            // txDepartmentName
            // 
            this.txDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDepartmentName.Location = new System.Drawing.Point(337, 146);
            this.txDepartmentName.Margin = new System.Windows.Forms.Padding(2);
            this.txDepartmentName.Name = "txDepartmentName";
            this.txDepartmentName.Size = new System.Drawing.Size(211, 20);
            this.txDepartmentName.TabIndex = 1;
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepartmentId.Location = new System.Drawing.Point(337, 114);
            this.txtDepartmentId.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(104, 20);
            this.txtDepartmentId.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(291, 176);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(41, 15);
            this.lblLocation.TabIndex = 29;
            this.lblLocation.Text = "Head";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(208, 149);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(124, 15);
            this.lblBranchName.TabIndex = 28;
            this.lblBranchName.Text = "Department Name";
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.Location = new System.Drawing.Point(231, 116);
            this.lblDepartmentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(101, 14);
            this.lblDepartmentId.TabIndex = 27;
            this.lblDepartmentId.Text = "Department Id";
            // 
            // tabEmployee
            // 
            this.tabEmployee.AccessibleName = "";
            this.tabEmployee.Controls.Add(this.tbpDepartment);
            this.tabEmployee.Controls.Add(this.tbpEmployee);
            this.tabEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployee.Location = new System.Drawing.Point(5, 6);
            this.tabEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.SelectedIndex = 0;
            this.tabEmployee.Size = new System.Drawing.Size(738, 363);
            this.tabEmployee.TabIndex = 0;
            this.tabEmployee.Tag = "";
            this.tabEmployee.SelectedIndexChanged += new System.EventHandler(this.tabEmployee_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(414, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(343, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(271, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(198, 375);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(77, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     EmployeeId, EmployeeName, DepartmentId, Woreda, Kebele, OfficeTel, Pho" +
    "to\r\nFROM         Employees\r\nORDER BY EmployeeName";
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EmployeeId", System.Data.SqlDbType.NVarChar, 0, "EmployeeId"),
            new System.Data.SqlClient.SqlParameter("@EmployeeName", System.Data.SqlDbType.NVarChar, 0, "EmployeeName"),
            new System.Data.SqlClient.SqlParameter("@DepartmentId", System.Data.SqlDbType.Char, 0, "DepartmentId"),
            new System.Data.SqlClient.SqlParameter("@Woreda", System.Data.SqlDbType.NVarChar, 0, "Woreda"),
            new System.Data.SqlClient.SqlParameter("@Kebele", System.Data.SqlDbType.NVarChar, 0, "Kebele"),
            new System.Data.SqlClient.SqlParameter("@OfficeTel", System.Data.SqlDbType.NVarChar, 0, "OfficeTel"),
            new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.Image, 0, "Photo")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@EmployeeId", System.Data.SqlDbType.NVarChar, 0, "EmployeeId"),
            new System.Data.SqlClient.SqlParameter("@EmployeeName", System.Data.SqlDbType.NVarChar, 0, "EmployeeName"),
            new System.Data.SqlClient.SqlParameter("@DepartmentId", System.Data.SqlDbType.Char, 0, "DepartmentId"),
            new System.Data.SqlClient.SqlParameter("@Woreda", System.Data.SqlDbType.NVarChar, 0, "Woreda"),
            new System.Data.SqlClient.SqlParameter("@Kebele", System.Data.SqlDbType.NVarChar, 0, "Kebele"),
            new System.Data.SqlClient.SqlParameter("@OfficeTel", System.Data.SqlDbType.NVarChar, 0, "OfficeTel"),
            new System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.Image, 0, "Photo"),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeId", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmployeeName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DepartmentId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DepartmentId", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DepartmentId", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DepartmentId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Woreda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Woreda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Woreda", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Woreda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Kebele", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Kebele", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Kebele", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kebele", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OfficeTel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OfficeTel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OfficeTel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OfficeTel", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeId", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EmployeeName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EmployeeName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DepartmentId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DepartmentId", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DepartmentId", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DepartmentId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Woreda", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Woreda", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Woreda", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Woreda", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Kebele", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Kebele", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Kebele", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Kebele", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OfficeTel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OfficeTel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OfficeTel", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OfficeTel", System.Data.DataRowVersion.Original, null)});
            // 
            // daSql
            // 
            this.daSql.DeleteCommand = this.sqlDeleteCommand1;
            this.daSql.InsertCommand = this.sqlInsertCommand1;
            this.daSql.SelectCommand = this.sqlSelectCommand1;
            this.daSql.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employees", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeId", "EmployeeId"),
                        new System.Data.Common.DataColumnMapping("EmployeeName", "EmployeeName"),
                        new System.Data.Common.DataColumnMapping("DepartmentId", "DepartmentId"),
                        new System.Data.Common.DataColumnMapping("Woreda", "Woreda"),
                        new System.Data.Common.DataColumnMapping("Kebele", "Kebele"),
                        new System.Data.Common.DataColumnMapping("OfficeTel", "OfficeTel"),
                        new System.Data.Common.DataColumnMapping("Photo", "Photo")})});
            this.daSql.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // departmentLstTableAdapter
            // 
            this.departmentLstTableAdapter.ClearBeforeFill = true;
            // 
            // i_StoreListTableAdapter
            // 
            this.i_StoreListTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // frmDepartment_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 411);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.tabEmployee);
            this.MaximizeBox = false;
            this.Name = "frmDepartment_Employees";
            this.Text = "Department and Employee information";
            this.Load += new System.EventHandler(this.frmDepartment_Employees_Load);
            this.tbpEmployee.ResumeLayout(false);
            this.tbpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iStoreListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentLstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPhoto)).EndInit();
            this.tbpDepartment.ResumeLayout(false);
            this.tbpDepartment.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpEmployee;
        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblStoreRemark;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtWorda;
        private System.Windows.Forms.TextBox txtKebele;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.TabPage tbpDepartment;
        private System.Windows.Forms.ListView lvDepartment;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txDepartmentName;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.PictureBox imgPhoto;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daSql;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private BelayAbInvoices belayAbInvoices;
        private System.Windows.Forms.Button btnEmployeePrint;
        private System.Windows.Forms.Button btnPrintAllEmployee;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource departmentLstBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.DepartmentLstTableAdapter departmentLstTableAdapter;
        private System.Windows.Forms.ComboBox cboEmpDepartmentId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl tabEmployee;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.BindingSource iStoreListBindingSource;
        private dsEmployeesTableAdapters.I_StoreListTableAdapter i_StoreListTableAdapter;
        private dsEmployees dsEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private dsEmployeesTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.TextBox officeTelTextBox;
    }
}