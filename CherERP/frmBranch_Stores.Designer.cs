namespace Belayab
{
    partial class frmBranch_Stores
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.tbBranchStore = new System.Windows.Forms.TabControl();
            this.tbpBranch = new System.Windows.Forms.TabPage();
            this.lvBranch = new System.Windows.Forms.ListView();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtBranchId = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.tbpStore = new System.Windows.Forms.TabPage();
            this.cboBranchId = new System.Windows.Forms.ComboBox();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbBranchStore = new Belayab.BelayAbBranchStore();
            this.lvStore = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.lblStoreRemark = new System.Windows.Forms.Label();
            this.txtStoreRemark = new System.Windows.Forms.TextBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblBranchId = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.tbpShelf = new System.Windows.Forms.TabPage();
            this.comboStoreId = new System.Windows.Forms.ComboBox();
            this.lvShelf = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.txtShelfName = new System.Windows.Forms.TextBox();
            this.txtShelfId = new System.Windows.Forms.TextBox();
            this.txtShelfRemark = new System.Windows.Forms.TextBox();
            this.lblShelfRemark = new System.Windows.Forms.Label();
            this.lblDescrption = new System.Windows.Forms.Label();
            this.lblShelfId = new System.Windows.Forms.Label();
            this.lblShelfStoreName = new System.Windows.Forms.Label();
            this.tbpColumn = new System.Windows.Forms.TabPage();
            this.lvColumn = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cboShelfId = new System.Windows.Forms.ComboBox();
            this.txtColumnId = new System.Windows.Forms.TextBox();
            this.txtColumnDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumnShelfName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpRow = new System.Windows.Forms.TabPage();
            this.lvRow = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.cboColumnId = new System.Windows.Forms.ComboBox();
            this.txtRowDescription = new System.Windows.Forms.TextBox();
            this.txtRowId = new System.Windows.Forms.TextBox();
            this.lblRowDescription = new System.Windows.Forms.Label();
            this.lblRowId = new System.Windows.Forms.Label();
            this.lblRowColumnId = new System.Windows.Forms.Label();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.branchesTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.BranchesTableAdapter();
            this.grp2.SuspendLayout();
            this.tbBranchStore.SuspendLayout();
            this.tbpBranch.SuspendLayout();
            this.tbpStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).BeginInit();
            this.tbpShelf.SuspendLayout();
            this.tbpColumn.SuspendLayout();
            this.tbpRow.SuspendLayout();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(220, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(291, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(415, 16);
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
            this.btnDelete.Location = new System.Drawing.Point(341, 16);
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
            this.btnSave.Location = new System.Drawing.Point(267, 16);
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
            this.btnAddNew.Location = new System.Drawing.Point(191, 16);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(77, 23);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.btnClose);
            this.grp2.Controls.Add(this.btnDelete);
            this.grp2.Controls.Add(this.btnSave);
            this.grp2.Controls.Add(this.btnAddNew);
            this.grp2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp2.Location = new System.Drawing.Point(0, 461);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(690, 65);
            this.grp2.TabIndex = 45;
            this.grp2.TabStop = false;
            // 
            // tbBranchStore
            // 
            this.tbBranchStore.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbBranchStore.Controls.Add(this.tbpBranch);
            this.tbBranchStore.Controls.Add(this.tbpStore);
            this.tbBranchStore.Controls.Add(this.tbpShelf);
            this.tbBranchStore.Controls.Add(this.tbpColumn);
            this.tbBranchStore.Controls.Add(this.tbpRow);
            this.tbBranchStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBranchStore.Location = new System.Drawing.Point(1, 11);
            this.tbBranchStore.Margin = new System.Windows.Forms.Padding(2);
            this.tbBranchStore.Name = "tbBranchStore";
            this.tbBranchStore.SelectedIndex = 0;
            this.tbBranchStore.Size = new System.Drawing.Size(665, 452);
            this.tbBranchStore.TabIndex = 0;
            this.tbBranchStore.TabIndexChanged += new System.EventHandler(this.tbBranchStore_TabIndexChanged);
            // 
            // tbpBranch
            // 
            this.tbpBranch.Controls.Add(this.lvBranch);
            this.tbpBranch.Controls.Add(this.txtRemark);
            this.tbpBranch.Controls.Add(this.txtLocation);
            this.tbpBranch.Controls.Add(this.txtBranchName);
            this.tbpBranch.Controls.Add(this.txtBranchId);
            this.tbpBranch.Controls.Add(this.lblRemark);
            this.tbpBranch.Controls.Add(this.lblLocation);
            this.tbpBranch.Controls.Add(this.lblBranchName);
            this.tbpBranch.Controls.Add(this.lblDepartmentId);
            this.tbpBranch.Location = new System.Drawing.Point(4, 25);
            this.tbpBranch.Margin = new System.Windows.Forms.Padding(2);
            this.tbpBranch.Name = "tbpBranch";
            this.tbpBranch.Padding = new System.Windows.Forms.Padding(2);
            this.tbpBranch.Size = new System.Drawing.Size(657, 423);
            this.tbpBranch.TabIndex = 0;
            this.tbpBranch.Text = "  Branch  ";
            this.tbpBranch.UseVisualStyleBackColor = true;
            // 
            // lvBranch
            // 
            this.lvBranch.BackColor = System.Drawing.Color.Gainsboro;
            this.lvBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBranch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12});
            this.lvBranch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBranch.FullRowSelect = true;
            this.lvBranch.GridLines = true;
            this.lvBranch.HideSelection = false;
            this.lvBranch.Location = new System.Drawing.Point(5, 0);
            this.lvBranch.MultiSelect = false;
            this.lvBranch.Name = "lvBranch";
            this.lvBranch.Size = new System.Drawing.Size(213, 418);
            this.lvBranch.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvBranch.TabIndex = 4;
            this.lvBranch.UseCompatibleStateImageBehavior = false;
            this.lvBranch.View = System.Windows.Forms.View.Details;
            this.lvBranch.SelectedIndexChanged += new System.EventHandler(this.lvBranch_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Branch Name";
            this.columnHeader12.Width = 250;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(382, 192);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(211, 20);
            this.txtRemark.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Location = new System.Drawing.Point(382, 163);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(211, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Location = new System.Drawing.Point(382, 136);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(127, 20);
            this.txtBranchName.TabIndex = 1;
            // 
            // txtBranchId
            // 
            this.txtBranchId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchId.Location = new System.Drawing.Point(382, 104);
            this.txtBranchId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBranchId.Name = "txtBranchId";
            this.txtBranchId.Size = new System.Drawing.Size(73, 20);
            this.txtBranchId.TabIndex = 0;
            this.txtBranchId.Enter += new System.EventHandler(this.txtBranchId_Enter);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemark.Location = new System.Drawing.Point(268, 192);
            this.lblRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(57, 15);
            this.lblRemark.TabIndex = 31;
            this.lblRemark.Text = "Remark";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(268, 163);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 15);
            this.lblLocation.TabIndex = 30;
            this.lblLocation.Text = "Location";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(268, 136);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(94, 15);
            this.lblBranchName.TabIndex = 29;
            this.lblBranchName.Text = "Branch Name";
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentId.Location = new System.Drawing.Point(268, 108);
            this.lblDepartmentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(115, 14);
            this.lblDepartmentId.TabIndex = 28;
            this.lblDepartmentId.Text = "Branch Id";
            // 
            // tbpStore
            // 
            this.tbpStore.Controls.Add(this.cboBranchId);
            this.tbpStore.Controls.Add(this.lvStore);
            this.tbpStore.Controls.Add(this.lblStoreRemark);
            this.tbpStore.Controls.Add(this.txtStoreRemark);
            this.tbpStore.Controls.Add(this.txtStoreId);
            this.tbpStore.Controls.Add(this.txtStoreName);
            this.tbpStore.Controls.Add(this.lblStoreName);
            this.tbpStore.Controls.Add(this.lblBranchId);
            this.tbpStore.Controls.Add(this.lblStoreId);
            this.tbpStore.Location = new System.Drawing.Point(4, 25);
            this.tbpStore.Margin = new System.Windows.Forms.Padding(2);
            this.tbpStore.Name = "tbpStore";
            this.tbpStore.Padding = new System.Windows.Forms.Padding(2);
            this.tbpStore.Size = new System.Drawing.Size(657, 423);
            this.tbpStore.TabIndex = 1;
            this.tbpStore.Text = "  Store   ";
            this.tbpStore.UseVisualStyleBackColor = true;
            // 
            // cboBranchId
            // 
            this.cboBranchId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBranchId.DataSource = this.branchesBindingSource;
            this.cboBranchId.DisplayMember = "BranchName";
            this.cboBranchId.FormattingEnabled = true;
            this.cboBranchId.Location = new System.Drawing.Point(348, 110);
            this.cboBranchId.Name = "cboBranchId";
            this.cboBranchId.Size = new System.Drawing.Size(210, 21);
            this.cboBranchId.TabIndex = 0;
            this.cboBranchId.ValueMember = "BranchId";
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.belayAbBranchStore;
            // 
            // belayAbBranchStore
            // 
            this.belayAbBranchStore.DataSetName = "BelayAbBranchStore";
            this.belayAbBranchStore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lvStore
            // 
            this.lvStore.BackColor = System.Drawing.Color.Gainsboro;
            this.lvStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvStore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStore.FullRowSelect = true;
            this.lvStore.GridLines = true;
            this.lvStore.HideSelection = false;
            this.lvStore.Location = new System.Drawing.Point(0, 3);
            this.lvStore.MultiSelect = false;
            this.lvStore.Name = "lvStore";
            this.lvStore.Size = new System.Drawing.Size(217, 407);
            this.lvStore.TabIndex = 4;
            this.lvStore.UseCompatibleStateImageBehavior = false;
            this.lvStore.View = System.Windows.Forms.View.Details;
            this.lvStore.SelectedIndexChanged += new System.EventHandler(this.lvStore_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Store Name";
            this.columnHeader6.Width = 248;
            // 
            // lblStoreRemark
            // 
            this.lblStoreRemark.AutoSize = true;
            this.lblStoreRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreRemark.Location = new System.Drawing.Point(253, 215);
            this.lblStoreRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreRemark.Name = "lblStoreRemark";
            this.lblStoreRemark.Size = new System.Drawing.Size(50, 13);
            this.lblStoreRemark.TabIndex = 6;
            this.lblStoreRemark.Text = "Remark";
            // 
            // txtStoreRemark
            // 
            this.txtStoreRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreRemark.Location = new System.Drawing.Point(348, 215);
            this.txtStoreRemark.Margin = new System.Windows.Forms.Padding(2);
            this.txtStoreRemark.Name = "txtStoreRemark";
            this.txtStoreRemark.Size = new System.Drawing.Size(233, 20);
            this.txtStoreRemark.TabIndex = 3;
            // 
            // txtStoreId
            // 
            this.txtStoreId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreId.Location = new System.Drawing.Point(348, 142);
            this.txtStoreId.Margin = new System.Windows.Forms.Padding(2);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(89, 20);
            this.txtStoreId.TabIndex = 1;
            this.txtStoreId.Enter += new System.EventHandler(this.txtStoreId_Enter);
            // 
            // txtStoreName
            // 
            this.txtStoreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreName.Location = new System.Drawing.Point(348, 176);
            this.txtStoreName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(152, 20);
            this.txtStoreName.TabIndex = 2;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(253, 178);
            this.lblStoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(83, 15);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "Store Name";
            // 
            // lblBranchId
            // 
            this.lblBranchId.AutoSize = true;
            this.lblBranchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchId.Location = new System.Drawing.Point(253, 110);
            this.lblBranchId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranchId.Name = "lblBranchId";
            this.lblBranchId.Size = new System.Drawing.Size(94, 15);
            this.lblBranchId.TabIndex = 1;
            this.lblBranchId.Text = "Branch Name";
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreId.Location = new System.Drawing.Point(253, 144);
            this.lblStoreId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(57, 15);
            this.lblStoreId.TabIndex = 0;
            this.lblStoreId.Text = "Store Id";
            // 
            // tbpShelf
            // 
            this.tbpShelf.Controls.Add(this.comboStoreId);
            this.tbpShelf.Controls.Add(this.lvShelf);
            this.tbpShelf.Controls.Add(this.txtShelfName);
            this.tbpShelf.Controls.Add(this.txtShelfId);
            this.tbpShelf.Controls.Add(this.txtShelfRemark);
            this.tbpShelf.Controls.Add(this.lblShelfRemark);
            this.tbpShelf.Controls.Add(this.lblDescrption);
            this.tbpShelf.Controls.Add(this.lblShelfId);
            this.tbpShelf.Controls.Add(this.lblShelfStoreName);
            this.tbpShelf.Location = new System.Drawing.Point(4, 25);
            this.tbpShelf.Margin = new System.Windows.Forms.Padding(2);
            this.tbpShelf.Name = "tbpShelf";
            this.tbpShelf.Size = new System.Drawing.Size(657, 423);
            this.tbpShelf.TabIndex = 2;
            this.tbpShelf.Text = "  Shelf   ";
            this.tbpShelf.UseVisualStyleBackColor = true;
            // 
            // comboStoreId
            // 
            this.comboStoreId.DisplayMember = "StoreName";
            this.comboStoreId.FormattingEnabled = true;
            this.comboStoreId.Location = new System.Drawing.Point(368, 112);
            this.comboStoreId.Name = "comboStoreId";
            this.comboStoreId.Size = new System.Drawing.Size(142, 21);
            this.comboStoreId.TabIndex = 0;
            this.comboStoreId.ValueMember = "StoreId";
            // 
            // lvShelf
            // 
            this.lvShelf.BackColor = System.Drawing.Color.Gainsboro;
            this.lvShelf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvShelf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lvShelf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShelf.FullRowSelect = true;
            this.lvShelf.GridLines = true;
            this.lvShelf.HideSelection = false;
            this.lvShelf.Location = new System.Drawing.Point(1, 3);
            this.lvShelf.MultiSelect = false;
            this.lvShelf.Name = "lvShelf";
            this.lvShelf.Size = new System.Drawing.Size(212, 417);
            this.lvShelf.TabIndex = 4;
            this.lvShelf.UseCompatibleStateImageBehavior = false;
            this.lvShelf.View = System.Windows.Forms.View.Details;
            this.lvShelf.SelectedIndexChanged += new System.EventHandler(this.lvShelf_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Shelf Name";
            this.columnHeader4.Width = 250;
            // 
            // txtShelfName
            // 
            this.txtShelfName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfName.Location = new System.Drawing.Point(368, 175);
            this.txtShelfName.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelfName.Name = "txtShelfName";
            this.txtShelfName.Size = new System.Drawing.Size(139, 20);
            this.txtShelfName.TabIndex = 2;
            // 
            // txtShelfId
            // 
            this.txtShelfId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfId.Location = new System.Drawing.Point(368, 141);
            this.txtShelfId.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelfId.Name = "txtShelfId";
            this.txtShelfId.Size = new System.Drawing.Size(48, 20);
            this.txtShelfId.TabIndex = 1;
            this.txtShelfId.TextChanged += new System.EventHandler(this.txtShelfId_TextChanged);
            // 
            // txtShelfRemark
            // 
            this.txtShelfRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShelfRemark.Location = new System.Drawing.Point(368, 209);
            this.txtShelfRemark.Margin = new System.Windows.Forms.Padding(2);
            this.txtShelfRemark.Name = "txtShelfRemark";
            this.txtShelfRemark.Size = new System.Drawing.Size(191, 20);
            this.txtShelfRemark.TabIndex = 3;
            // 
            // lblShelfRemark
            // 
            this.lblShelfRemark.AutoSize = true;
            this.lblShelfRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfRemark.Location = new System.Drawing.Point(282, 210);
            this.lblShelfRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShelfRemark.Name = "lblShelfRemark";
            this.lblShelfRemark.Size = new System.Drawing.Size(50, 13);
            this.lblShelfRemark.TabIndex = 3;
            this.lblShelfRemark.Text = "Remark";
            // 
            // lblDescrption
            // 
            this.lblDescrption.AutoSize = true;
            this.lblDescrption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrption.Location = new System.Drawing.Point(260, 175);
            this.lblDescrption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescrption.Name = "lblDescrption";
            this.lblDescrption.Size = new System.Drawing.Size(72, 13);
            this.lblDescrption.TabIndex = 2;
            this.lblDescrption.Text = "Shelf Name";
            // 
            // lblShelfId
            // 
            this.lblShelfId.AutoSize = true;
            this.lblShelfId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfId.Location = new System.Drawing.Point(281, 143);
            this.lblShelfId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShelfId.Name = "lblShelfId";
            this.lblShelfId.Size = new System.Drawing.Size(51, 13);
            this.lblShelfId.TabIndex = 1;
            this.lblShelfId.Text = "Shelf Id";
            // 
            // lblShelfStoreName
            // 
            this.lblShelfStoreName.AutoSize = true;
            this.lblShelfStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShelfStoreName.Location = new System.Drawing.Point(263, 113);
            this.lblShelfStoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShelfStoreName.Name = "lblShelfStoreName";
            this.lblShelfStoreName.Size = new System.Drawing.Size(73, 13);
            this.lblShelfStoreName.TabIndex = 0;
            this.lblShelfStoreName.Text = "Store Name";
            // 
            // tbpColumn
            // 
            this.tbpColumn.Controls.Add(this.lvColumn);
            this.tbpColumn.Controls.Add(this.cboShelfId);
            this.tbpColumn.Controls.Add(this.txtColumnId);
            this.tbpColumn.Controls.Add(this.txtColumnDescription);
            this.tbpColumn.Controls.Add(this.label1);
            this.tbpColumn.Controls.Add(this.lblColumnShelfName);
            this.tbpColumn.Controls.Add(this.label2);
            this.tbpColumn.Location = new System.Drawing.Point(4, 25);
            this.tbpColumn.Margin = new System.Windows.Forms.Padding(2);
            this.tbpColumn.Name = "tbpColumn";
            this.tbpColumn.Size = new System.Drawing.Size(657, 423);
            this.tbpColumn.TabIndex = 3;
            this.tbpColumn.Text = "  Column  ";
            this.tbpColumn.UseVisualStyleBackColor = true;
            // 
            // lvColumn
            // 
            this.lvColumn.BackColor = System.Drawing.Color.Gainsboro;
            this.lvColumn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvColumn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvColumn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvColumn.FullRowSelect = true;
            this.lvColumn.GridLines = true;
            this.lvColumn.HideSelection = false;
            this.lvColumn.Location = new System.Drawing.Point(3, 0);
            this.lvColumn.MultiSelect = false;
            this.lvColumn.Name = "lvColumn";
            this.lvColumn.Size = new System.Drawing.Size(212, 420);
            this.lvColumn.TabIndex = 3;
            this.lvColumn.UseCompatibleStateImageBehavior = false;
            this.lvColumn.View = System.Windows.Forms.View.Details;
            this.lvColumn.SelectedIndexChanged += new System.EventHandler(this.lvColumn_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Column Name";
            this.columnHeader2.Width = 250;
            // 
            // cboShelfId
            // 
            this.cboShelfId.DisplayMember = "ShelfName";
            this.cboShelfId.FormattingEnabled = true;
            this.cboShelfId.Location = new System.Drawing.Point(377, 132);
            this.cboShelfId.Name = "cboShelfId";
            this.cboShelfId.Size = new System.Drawing.Size(120, 21);
            this.cboShelfId.TabIndex = 0;
            this.cboShelfId.ValueMember = "ShelfId";
            // 
            // txtColumnId
            // 
            this.txtColumnId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColumnId.Location = new System.Drawing.Point(377, 177);
            this.txtColumnId.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumnId.Name = "txtColumnId";
            this.txtColumnId.Size = new System.Drawing.Size(76, 20);
            this.txtColumnId.TabIndex = 1;
            this.txtColumnId.Enter += new System.EventHandler(this.txtColumnId_Enter);
            // 
            // txtColumnDescription
            // 
            this.txtColumnDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColumnDescription.Location = new System.Drawing.Point(377, 212);
            this.txtColumnDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumnDescription.Name = "txtColumnDescription";
            this.txtColumnDescription.Size = new System.Drawing.Size(210, 20);
            this.txtColumnDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Column Name";
            // 
            // lblColumnShelfName
            // 
            this.lblColumnShelfName.AutoSize = true;
            this.lblColumnShelfName.Location = new System.Drawing.Point(290, 139);
            this.lblColumnShelfName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumnShelfName.Name = "lblColumnShelfName";
            this.lblColumnShelfName.Size = new System.Drawing.Size(72, 13);
            this.lblColumnShelfName.TabIndex = 1;
            this.lblColumnShelfName.Text = "Shelf Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Column Id";
            // 
            // tbpRow
            // 
            this.tbpRow.Controls.Add(this.lvRow);
            this.tbpRow.Controls.Add(this.cboColumnId);
            this.tbpRow.Controls.Add(this.txtRowDescription);
            this.tbpRow.Controls.Add(this.txtRowId);
            this.tbpRow.Controls.Add(this.lblRowDescription);
            this.tbpRow.Controls.Add(this.lblRowId);
            this.tbpRow.Controls.Add(this.lblRowColumnId);
            this.tbpRow.Location = new System.Drawing.Point(4, 25);
            this.tbpRow.Margin = new System.Windows.Forms.Padding(2);
            this.tbpRow.Name = "tbpRow";
            this.tbpRow.Size = new System.Drawing.Size(657, 423);
            this.tbpRow.TabIndex = 4;
            this.tbpRow.Text = "  Row      ";
            this.tbpRow.UseVisualStyleBackColor = true;
            // 
            // lvRow
            // 
            this.lvRow.BackColor = System.Drawing.Color.Gainsboro;
            this.lvRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10});
            this.lvRow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRow.FullRowSelect = true;
            this.lvRow.GridLines = true;
            this.lvRow.HideSelection = false;
            this.lvRow.Location = new System.Drawing.Point(3, 3);
            this.lvRow.MultiSelect = false;
            this.lvRow.Name = "lvRow";
            this.lvRow.Size = new System.Drawing.Size(214, 417);
            this.lvRow.TabIndex = 3;
            this.lvRow.UseCompatibleStateImageBehavior = false;
            this.lvRow.View = System.Windows.Forms.View.Details;
            this.lvRow.SelectedIndexChanged += new System.EventHandler(this.lvRow_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = " Row Name";
            this.columnHeader10.Width = 250;
            // 
            // cboColumnId
            // 
            this.cboColumnId.DisplayMember = "Description";
            this.cboColumnId.FormattingEnabled = true;
            this.cboColumnId.Location = new System.Drawing.Point(374, 129);
            this.cboColumnId.Name = "cboColumnId";
            this.cboColumnId.Size = new System.Drawing.Size(148, 21);
            this.cboColumnId.TabIndex = 0;
            this.cboColumnId.ValueMember = "ColumnId";
            // 
            // txtRowDescription
            // 
            this.txtRowDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRowDescription.Location = new System.Drawing.Point(375, 207);
            this.txtRowDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtRowDescription.Name = "txtRowDescription";
            this.txtRowDescription.Size = new System.Drawing.Size(203, 20);
            this.txtRowDescription.TabIndex = 2;
            // 
            // txtRowId
            // 
            this.txtRowId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRowId.Location = new System.Drawing.Point(375, 167);
            this.txtRowId.Margin = new System.Windows.Forms.Padding(2);
            this.txtRowId.Name = "txtRowId";
            this.txtRowId.Size = new System.Drawing.Size(60, 20);
            this.txtRowId.TabIndex = 1;
            this.txtRowId.Enter += new System.EventHandler(this.txtRowId_Enter);
            // 
            // lblRowDescription
            // 
            this.lblRowDescription.AutoSize = true;
            this.lblRowDescription.Location = new System.Drawing.Point(290, 211);
            this.lblRowDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRowDescription.Name = "lblRowDescription";
            this.lblRowDescription.Size = new System.Drawing.Size(68, 13);
            this.lblRowDescription.TabIndex = 2;
            this.lblRowDescription.Text = "Row Name";
            // 
            // lblRowId
            // 
            this.lblRowId.AutoSize = true;
            this.lblRowId.Location = new System.Drawing.Point(314, 174);
            this.lblRowId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRowId.Name = "lblRowId";
            this.lblRowId.Size = new System.Drawing.Size(47, 13);
            this.lblRowId.TabIndex = 1;
            this.lblRowId.Text = "Row Id";
            // 
            // lblRowColumnId
            // 
            this.lblRowColumnId.AutoSize = true;
            this.lblRowColumnId.Location = new System.Drawing.Point(277, 132);
            this.lblRowColumnId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRowColumnId.Name = "lblRowColumnId";
            this.lblRowColumnId.Size = new System.Drawing.Size(84, 13);
            this.lblRowColumnId.TabIndex = 0;
            this.lblRowColumnId.Text = "Column Name";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.tbBranchStore);
            this.grp1.Location = new System.Drawing.Point(0, -3);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(678, 472);
            this.grp1.TabIndex = 44;
            this.grp1.TabStop = false;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // frmBranch_Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 526);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBranch_Stores";
            this.Text = "Branch And Store";
            this.Resize += new System.EventHandler(this.frmBranch_Stores_Resize);
            this.Load += new System.EventHandler(this.frmBranch_Stores_Load);
            this.grp2.ResumeLayout(false);
            this.tbBranchStore.ResumeLayout(false);
            this.tbpBranch.ResumeLayout(false);
            this.tbpBranch.PerformLayout();
            this.tbpStore.ResumeLayout(false);
            this.tbpStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).EndInit();
            this.tbpShelf.ResumeLayout(false);
            this.tbpShelf.PerformLayout();
            this.tbpColumn.ResumeLayout(false);
            this.tbpColumn.PerformLayout();
            this.tbpRow.ResumeLayout(false);
            this.tbpRow.PerformLayout();
            this.grp1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox grp2;
        public System.Windows.Forms.TabControl tbBranchStore;
        private System.Windows.Forms.TabPage tbpBranch;
        private System.Windows.Forms.ListView lvBranch;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtBranchName;
        public System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.TabPage tbpStore;
        private System.Windows.Forms.ComboBox cboBranchId;
        private System.Windows.Forms.ListView lvStore;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblStoreRemark;
        private System.Windows.Forms.TextBox txtStoreRemark;
        public System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.TabPage tbpShelf;
        private System.Windows.Forms.ComboBox comboStoreId;
        private System.Windows.Forms.ListView lvShelf;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtShelfName;
        public System.Windows.Forms.TextBox txtShelfId;
        private System.Windows.Forms.TextBox txtShelfRemark;
        private System.Windows.Forms.Label lblShelfRemark;
        private System.Windows.Forms.Label lblDescrption;
        private System.Windows.Forms.Label lblShelfId;
        private System.Windows.Forms.Label lblShelfStoreName;
        private System.Windows.Forms.TabPage tbpColumn;
        private System.Windows.Forms.ListView lvColumn;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cboShelfId;
        public System.Windows.Forms.TextBox txtColumnId;
        private System.Windows.Forms.TextBox txtColumnDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColumnShelfName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbpRow;
        private System.Windows.Forms.ListView lvRow;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cboColumnId;
        private System.Windows.Forms.TextBox txtRowDescription;
        public System.Windows.Forms.TextBox txtRowId;
        private System.Windows.Forms.Label lblRowDescription;
        private System.Windows.Forms.Label lblRowId;
        private System.Windows.Forms.Label lblRowColumnId;
        private System.Windows.Forms.GroupBox grp1;
        private BelayAbBranchStore belayAbBranchStore;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.BranchesTableAdapter branchesTableAdapter;


    }
}

