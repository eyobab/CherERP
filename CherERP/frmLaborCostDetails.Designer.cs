namespace Belayab
{
    partial class frmLaborCostDetails
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
            System.Windows.Forms.Label lbCostIdLabel;
            System.Windows.Forms.Label sessionNoLabel;
            System.Windows.Forms.Label mechanicLabel;
            System.Windows.Forms.Label sesionStartLabel;
            System.Windows.Forms.Label sessionEndLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label mNumberLabel;
            System.Windows.Forms.Label labor_TypeLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaborCostDetails));
            this.m_LaborCostDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.m_LaborCostDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
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
            this.m_LaborCostDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lbCostIdTextBox = new System.Windows.Forms.TextBox();
            this.sessionNoTextBox = new System.Windows.Forms.TextBox();
            this.sesionStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sessionEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.m_LaborCostDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mMechanicListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SessionStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSessionStart = new System.Windows.Forms.Button();
            this.btnSessionEnd = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLbCostID = new System.Windows.Forms.TextBox();
            this.m_Labor_MainInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labor_TypeTextBox = new System.Windows.Forms.TextBox();
            this.mNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCurrentHours = new System.Windows.Forms.TextBox();
            this.m_LaborCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_LaborCostDetailsTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_LaborCostDetailsTableAdapter();
            this.m_LaborCostTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_LaborCostTableAdapter();
            this.m_Labor_MainInfoTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_Labor_MainInfoTableAdapter();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.mechanicComboBox = new System.Windows.Forms.ComboBox();
            this.m_MechanicListTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter();
            this.btnSessionSuspend = new System.Windows.Forms.Button();
            lbCostIdLabel = new System.Windows.Forms.Label();
            sessionNoLabel = new System.Windows.Forms.Label();
            mechanicLabel = new System.Windows.Forms.Label();
            sesionStartLabel = new System.Windows.Forms.Label();
            sessionEndLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            mNumberLabel = new System.Windows.Forms.Label();
            labor_TypeLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsBindingNavigator)).BeginInit();
            this.m_LaborCostDetailsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Labor_MainInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCostIdLabel
            // 
            lbCostIdLabel.AutoSize = true;
            lbCostIdLabel.Location = new System.Drawing.Point(15, 209);
            lbCostIdLabel.Name = "lbCostIdLabel";
            lbCostIdLabel.Size = new System.Drawing.Size(58, 13);
            lbCostIdLabel.TabIndex = 1;
            lbCostIdLabel.Text = "Lb Cost Id:";
            // 
            // sessionNoLabel
            // 
            sessionNoLabel.AutoSize = true;
            sessionNoLabel.Location = new System.Drawing.Point(0, 235);
            sessionNoLabel.Name = "sessionNoLabel";
            sessionNoLabel.Size = new System.Drawing.Size(84, 13);
            sessionNoLabel.TabIndex = 3;
            sessionNoLabel.Text = "Current Session ";
            // 
            // mechanicLabel
            // 
            mechanicLabel.AutoSize = true;
            mechanicLabel.Location = new System.Drawing.Point(15, 261);
            mechanicLabel.Name = "mechanicLabel";
            mechanicLabel.Size = new System.Drawing.Size(57, 13);
            mechanicLabel.TabIndex = 5;
            mechanicLabel.Text = "Mechanic:";
            // 
            // sesionStartLabel
            // 
            sesionStartLabel.AutoSize = true;
            sesionStartLabel.Location = new System.Drawing.Point(15, 288);
            sesionStartLabel.Name = "sesionStartLabel";
            sesionStartLabel.Size = new System.Drawing.Size(67, 13);
            sesionStartLabel.TabIndex = 7;
            sesionStartLabel.Text = "Sesion Start:";
            // 
            // sessionEndLabel
            // 
            sessionEndLabel.AutoSize = true;
            sessionEndLabel.Location = new System.Drawing.Point(15, 314);
            sessionEndLabel.Name = "sessionEndLabel";
            sessionEndLabel.Size = new System.Drawing.Size(69, 13);
            sessionEndLabel.TabIndex = 9;
            sessionEndLabel.Text = "Session End:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(15, 339);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(50, 13);
            durationLabel.TabIndex = 11;
            durationLabel.Text = "Duration:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(15, 365);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 391);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "Description:";
            // 
            // mNumberLabel
            // 
            mNumberLabel.AutoSize = true;
            mNumberLabel.Location = new System.Drawing.Point(166, 42);
            mNumberLabel.Name = "mNumberLabel";
            mNumberLabel.Size = new System.Drawing.Size(65, 13);
            mNumberLabel.TabIndex = 2;
            mNumberLabel.Text = "Work Order:";
            // 
            // labor_TypeLabel
            // 
            labor_TypeLabel.AutoSize = true;
            labor_TypeLabel.Location = new System.Drawing.Point(167, 68);
            labor_TypeLabel.Name = "labor_TypeLabel";
            labor_TypeLabel.Size = new System.Drawing.Size(64, 13);
            labor_TypeLabel.TabIndex = 4;
            labor_TypeLabel.Text = "Labor Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(167, 97);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 13);
            label5.TabIndex = 4;
            label5.Text = "Standard Hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(674, 479);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(62, 13);
            label6.TabIndex = 4;
            label6.Text = "Total Hours";
            // 
            // m_LaborCostDetailsBindingNavigator
            // 
            this.m_LaborCostDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_LaborCostDetailsBindingNavigator.BindingSource = this.m_LaborCostDetailsBindingSource;
            this.m_LaborCostDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_LaborCostDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.m_LaborCostDetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.m_LaborCostDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.m_LaborCostDetailsBindingNavigatorSaveItem});
            this.m_LaborCostDetailsBindingNavigator.Location = new System.Drawing.Point(321, 476);
            this.m_LaborCostDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_LaborCostDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_LaborCostDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_LaborCostDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_LaborCostDetailsBindingNavigator.Name = "m_LaborCostDetailsBindingNavigator";
            this.m_LaborCostDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_LaborCostDetailsBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.m_LaborCostDetailsBindingNavigator.TabIndex = 0;
            this.m_LaborCostDetailsBindingNavigator.Text = "bindingNavigator1";
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
            // m_LaborCostDetailsBindingSource
            // 
            this.m_LaborCostDetailsBindingSource.DataMember = "m_LaborCostDetails";
            this.m_LaborCostDetailsBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // m_LaborCostDetailsBindingNavigatorSaveItem
            // 
            this.m_LaborCostDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_LaborCostDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_LaborCostDetailsBindingNavigatorSaveItem.Image")));
            this.m_LaborCostDetailsBindingNavigatorSaveItem.Name = "m_LaborCostDetailsBindingNavigatorSaveItem";
            this.m_LaborCostDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_LaborCostDetailsBindingNavigatorSaveItem.Text = "Save Data";
            this.m_LaborCostDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_LaborCostDetailsBindingNavigatorSaveItem_Click_1);
            // 
            // lbCostIdTextBox
            // 
            this.lbCostIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "LbCostId", true));
            this.lbCostIdTextBox.Location = new System.Drawing.Point(90, 206);
            this.lbCostIdTextBox.Name = "lbCostIdTextBox";
            this.lbCostIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.lbCostIdTextBox.TabIndex = 2;
            // 
            // sessionNoTextBox
            // 
            this.sessionNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "SessionNo", true));
            this.sessionNoTextBox.Location = new System.Drawing.Point(90, 232);
            this.sessionNoTextBox.Name = "sessionNoTextBox";
            this.sessionNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sessionNoTextBox.TabIndex = 4;
            // 
            // sesionStartDateTimePicker
            // 
            this.sesionStartDateTimePicker.CustomFormat = "MMM dd, yyyy  hh:mm:ss tt";
            this.sesionStartDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.m_LaborCostDetailsBindingSource, "SesionStart", true));
            this.sesionStartDateTimePicker.Enabled = false;
            this.sesionStartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sesionStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sesionStartDateTimePicker.Location = new System.Drawing.Point(90, 284);
            this.sesionStartDateTimePicker.Name = "sesionStartDateTimePicker";
            this.sesionStartDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.sesionStartDateTimePicker.TabIndex = 8;
            // 
            // sessionEndDateTimePicker
            // 
            this.sessionEndDateTimePicker.CustomFormat = "MMM dd, yyyy  hh:mm:ss tt";
            this.sessionEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.m_LaborCostDetailsBindingSource, "SessionEnd", true));
            this.sessionEndDateTimePicker.Enabled = false;
            this.sessionEndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sessionEndDateTimePicker.Location = new System.Drawing.Point(90, 310);
            this.sessionEndDateTimePicker.Name = "sessionEndDateTimePicker";
            this.sessionEndDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.sessionEndDateTimePicker.TabIndex = 10;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(90, 336);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(200, 20);
            this.durationTextBox.TabIndex = 12;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(90, 362);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(90, 388);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // m_LaborCostDetailsDataGridView
            // 
            this.m_LaborCostDetailsDataGridView.AllowUserToAddRows = false;
            this.m_LaborCostDetailsDataGridView.AllowUserToDeleteRows = false;
            this.m_LaborCostDetailsDataGridView.AllowUserToOrderColumns = true;
            this.m_LaborCostDetailsDataGridView.AutoGenerateColumns = false;
            this.m_LaborCostDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_LaborCostDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Duration,
            this.SessionStatus,
            this.dataGridViewTextBoxColumn8});
            this.m_LaborCostDetailsDataGridView.DataSource = this.m_LaborCostDetailsBindingSource;
            this.m_LaborCostDetailsDataGridView.Location = new System.Drawing.Point(296, 203);
            this.m_LaborCostDetailsDataGridView.Name = "m_LaborCostDetailsDataGridView";
            this.m_LaborCostDetailsDataGridView.Size = new System.Drawing.Size(645, 267);
            this.m_LaborCostDetailsDataGridView.TabIndex = 19;
            this.m_LaborCostDetailsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_LaborCostDetailsDataGridView_RowEnter);
            this.m_LaborCostDetailsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.m_LaborCostDetailsDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SessionNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "SessionNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Mechanic";
            this.dataGridViewTextBoxColumn3.DataSource = this.mMechanicListBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "FullName";
            this.dataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Mechanic";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "MechanicID";
            // 
            // mMechanicListBindingSource
            // 
            this.mMechanicListBindingSource.DataMember = "m_MechanicList";
            this.mMechanicListBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SesionStart";
            this.dataGridViewTextBoxColumn4.HeaderText = "SesionStart";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SessionEnd";
            this.dataGridViewTextBoxColumn5.HeaderText = "SessionEnd";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Duration
            // 
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // SessionStatus
            // 
            this.SessionStatus.DataPropertyName = "Status";
            this.SessionStatus.HeaderText = "Status";
            this.SessionStatus.Name = "SessionStatus";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Description";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnSessionStart
            // 
            this.btnSessionStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSessionStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSessionStart.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionStart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSessionStart.Location = new System.Drawing.Point(14, 415);
            this.btnSessionStart.Name = "btnSessionStart";
            this.btnSessionStart.Size = new System.Drawing.Size(130, 33);
            this.btnSessionStart.TabIndex = 20;
            this.btnSessionStart.Text = "Sart";
            this.btnSessionStart.UseVisualStyleBackColor = false;
            this.btnSessionStart.Click += new System.EventHandler(this.btnSessionStart_Click);
            // 
            // btnSessionEnd
            // 
            this.btnSessionEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSessionEnd.BackColor = System.Drawing.Color.LightPink;
            this.btnSessionEnd.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionEnd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSessionEnd.Location = new System.Drawing.Point(150, 415);
            this.btnSessionEnd.Name = "btnSessionEnd";
            this.btnSessionEnd.Size = new System.Drawing.Size(130, 33);
            this.btnSessionEnd.TabIndex = 20;
            this.btnSessionEnd.Text = "End";
            this.btnSessionEnd.UseVisualStyleBackColor = false;
            this.btnSessionEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(474, 148);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(484, 38);
            this.lblCurrentTime.TabIndex = 21;
            this.lblCurrentTime.Text = "      ";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtLbCostID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCurrentTime);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(labor_TypeLabel);
            this.groupBox1.Controls.Add(this.labor_TypeTextBox);
            this.groupBox1.Controls.Add(mNumberLabel);
            this.groupBox1.Controls.Add(this.mNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 193);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignments";
            // 
            // txtLbCostID
            // 
            this.txtLbCostID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLbCostID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLbCostID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "LbCostId", true));
            this.txtLbCostID.Enabled = false;
            this.txtLbCostID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLbCostID.Location = new System.Drawing.Point(917, 13);
            this.txtLbCostID.Name = "txtLbCostID";
            this.txtLbCostID.ReadOnly = true;
            this.txtLbCostID.Size = new System.Drawing.Size(41, 13);
            this.txtLbCostID.TabIndex = 8;
            this.txtLbCostID.TextChanged += new System.EventHandler(this.txtLbCostID_TextChanged);
            // 
            // m_Labor_MainInfoBindingSource
            // 
            this.m_Labor_MainInfoBindingSource.DataMember = "m_Labor_MainInfo";
            this.m_Labor_MainInfoBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "Plate Number", true));
            this.textBox3.Location = new System.Drawing.Point(504, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "CustomerName", true));
            this.textBox2.Location = new System.Drawing.Point(504, 94);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(290, 34);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vehcle";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "VehicleType", true));
            this.textBox1.Location = new System.Drawing.Point(504, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(271, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labor_TypeTextBox
            // 
            this.labor_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "Labor Type", true));
            this.labor_TypeTextBox.Location = new System.Drawing.Point(237, 65);
            this.labor_TypeTextBox.Name = "labor_TypeTextBox";
            this.labor_TypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.labor_TypeTextBox.TabIndex = 5;
            // 
            // mNumberTextBox
            // 
            this.mNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_Labor_MainInfoBindingSource, "mNumber", true));
            this.mNumberTextBox.Location = new System.Drawing.Point(237, 39);
            this.mNumberTextBox.Name = "mNumberTextBox";
            this.mNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.mNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Work Orders";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.m_Labor_MainInfoBindingSource;
            this.listBox1.DisplayMember = "mNumber";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 147);
            this.listBox1.TabIndex = 0;
            // 
            // txtCurrentHours
            // 
            this.txtCurrentHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHours.Location = new System.Drawing.Point(742, 476);
            this.txtCurrentHours.Name = "txtCurrentHours";
            this.txtCurrentHours.Size = new System.Drawing.Size(104, 20);
            this.txtCurrentHours.TabIndex = 5;
            this.txtCurrentHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_LaborCostBindingSource
            // 
            this.m_LaborCostBindingSource.DataMember = "m_LaborCost";
            this.m_LaborCostBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // m_LaborCostDetailsTableAdapter
            // 
            this.m_LaborCostDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // m_LaborCostTableAdapter
            // 
            this.m_LaborCostTableAdapter.ClearBeforeFill = true;
            // 
            // m_Labor_MainInfoTableAdapter
            // 
            this.m_Labor_MainInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalize.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFinalize.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFinalize.Location = new System.Drawing.Point(150, 459);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(130, 37);
            this.btnFinalize.TabIndex = 23;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // mechanicComboBox
            // 
            this.mechanicComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_LaborCostDetailsBindingSource, "Mechanic", true));
            this.mechanicComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.m_LaborCostDetailsBindingSource, "Mechanic", true));
            this.mechanicComboBox.DataSource = this.mMechanicListBindingSource;
            this.mechanicComboBox.DisplayMember = "FullName";
            this.mechanicComboBox.FormattingEnabled = true;
            this.mechanicComboBox.Location = new System.Drawing.Point(90, 258);
            this.mechanicComboBox.Name = "mechanicComboBox";
            this.mechanicComboBox.Size = new System.Drawing.Size(200, 21);
            this.mechanicComboBox.TabIndex = 25;
            this.mechanicComboBox.ValueMember = "MechanicID";
            // 
            // m_MechanicListTableAdapter
            // 
            this.m_MechanicListTableAdapter.ClearBeforeFill = true;
            // 
            // btnSessionSuspend
            // 
            this.btnSessionSuspend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSessionSuspend.BackColor = System.Drawing.Color.Coral;
            this.btnSessionSuspend.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSessionSuspend.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSessionSuspend.Location = new System.Drawing.Point(14, 459);
            this.btnSessionSuspend.Name = "btnSessionSuspend";
            this.btnSessionSuspend.Size = new System.Drawing.Size(130, 37);
            this.btnSessionSuspend.TabIndex = 23;
            this.btnSessionSuspend.Text = "Suspend";
            this.btnSessionSuspend.UseVisualStyleBackColor = false;
            this.btnSessionSuspend.Click += new System.EventHandler(this.btnSessionSuspend_Click);
            // 
            // frmLaborCostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 572);
            this.Controls.Add(this.mechanicComboBox);
            this.Controls.Add(this.btnSessionSuspend);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSessionEnd);
            this.Controls.Add(this.btnSessionStart);
            this.Controls.Add(this.m_LaborCostDetailsDataGridView);
            this.Controls.Add(label6);
            this.Controls.Add(lbCostIdLabel);
            this.Controls.Add(this.txtCurrentHours);
            this.Controls.Add(this.lbCostIdTextBox);
            this.Controls.Add(sessionNoLabel);
            this.Controls.Add(this.sessionNoTextBox);
            this.Controls.Add(mechanicLabel);
            this.Controls.Add(sesionStartLabel);
            this.Controls.Add(this.sesionStartDateTimePicker);
            this.Controls.Add(sessionEndLabel);
            this.Controls.Add(this.sessionEndDateTimePicker);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.m_LaborCostDetailsBindingNavigator);
            this.Name = "frmLaborCostDetails";
            this.Text = "Labor Cost Details";
            this.Load += new System.EventHandler(this.frmLaborCostDetails_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLaborCostDetails_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsBindingNavigator)).EndInit();
            this.m_LaborCostDetailsBindingNavigator.ResumeLayout(false);
            this.m_LaborCostDetailsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Labor_MainInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource m_LaborCostDetailsBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_LaborCostDetailsTableAdapter m_LaborCostDetailsTableAdapter;
        private System.Windows.Forms.BindingNavigator m_LaborCostDetailsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_LaborCostDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox lbCostIdTextBox;
        private System.Windows.Forms.TextBox sessionNoTextBox;
        private System.Windows.Forms.DateTimePicker sesionStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker sessionEndDateTimePicker;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DataGridView m_LaborCostDetailsDataGridView;
        private System.Windows.Forms.Button btnSessionStart;
        private System.Windows.Forms.Button btnSessionEnd;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource m_LaborCostBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_LaborCostTableAdapter m_LaborCostTableAdapter;
        private System.Windows.Forms.TextBox labor_TypeTextBox;
        private System.Windows.Forms.TextBox mNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtCurrentHours;
        private System.Windows.Forms.BindingSource m_Labor_MainInfoBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_Labor_MainInfoTableAdapter m_Labor_MainInfoTableAdapter;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.TextBox txtLbCostID;
        private System.Windows.Forms.ComboBox mechanicComboBox;
        private System.Windows.Forms.BindingSource mMechanicListBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter m_MechanicListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SessionStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnSessionSuspend;

    }
}