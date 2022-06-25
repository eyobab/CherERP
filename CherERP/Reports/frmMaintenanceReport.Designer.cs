namespace Belayab.Reports
{
    partial class frmMaintenanceReport
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
            this.tbMaintenanceReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboServiceType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboCusType = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lnkNone = new System.Windows.Forms.LinkLabel();
            this.lnkAll = new System.Windows.Forms.LinkLabel();
            this.lstMechanicList = new System.Windows.Forms.ListBox();
            this.mMechanicListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboLaborWorkType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdBothDeliverdandNonDelivered = new System.Windows.Forms.RadioButton();
            this.rdnonDelivered = new System.Windows.Forms.RadioButton();
            this.rdDelivered = new System.Windows.Forms.RadioButton();
            this.rptGroup = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cboItemServiceType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optNone = new System.Windows.Forms.RadioButton();
            this.optSType = new System.Windows.Forms.RadioButton();
            this.optVType = new System.Windows.Forms.RadioButton();
            this.optCusType = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.m_MechanicListTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptMechanicLabourBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpt_Mechanic_LabourTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.rpt_Mechanic_LabourTableAdapter();
            this.chkDetails = new System.Windows.Forms.CheckBox();
            this.chkLaborDetails = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grpLaborDetails = new System.Windows.Forms.GroupBox();
            this.optLaborNoDetails = new System.Windows.Forms.RadioButton();
            this.opLaborDetails = new System.Windows.Forms.RadioButton();
            this.optLaborBoth = new System.Windows.Forms.RadioButton();
            this.tbMaintenanceReports.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.rptGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rptMechanicLabourBindingSource)).BeginInit();
            this.grpLaborDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaintenanceReports
            // 
            this.tbMaintenanceReports.Controls.Add(this.tabPage1);
            this.tbMaintenanceReports.Controls.Add(this.tabPage2);
            this.tbMaintenanceReports.Controls.Add(this.tabPage3);
            this.tbMaintenanceReports.Controls.Add(this.tabPage4);
            this.tbMaintenanceReports.Location = new System.Drawing.Point(0, 0);
            this.tbMaintenanceReports.Name = "tbMaintenanceReports";
            this.tbMaintenanceReports.SelectedIndex = 0;
            this.tbMaintenanceReports.Size = new System.Drawing.Size(225, 297);
            this.tbMaintenanceReports.TabIndex = 0;
            this.tbMaintenanceReports.SelectedIndexChanged += new System.EventHandler(this.tbMaintenanceReports_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(217, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Maintenance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboServiceType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboVehicleType);
            this.groupBox1.Location = new System.Drawing.Point(11, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 127);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Selections";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Service Type";
            // 
            // cboServiceType
            // 
            this.cboServiceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboServiceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboServiceType.FormattingEnabled = true;
            this.cboServiceType.Location = new System.Drawing.Point(21, 91);
            this.cboServiceType.Name = "cboServiceType";
            this.cboServiceType.Size = new System.Drawing.Size(136, 21);
            this.cboServiceType.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vehicle Type";
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVehicleType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(21, 43);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(136, 21);
            this.cboVehicleType.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cboCustomer);
            this.groupBox5.Controls.Add(this.cboCusType);
            this.groupBox5.Location = new System.Drawing.Point(11, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 120);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Customer Selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Type";
            // 
            // cboCustomer
            // 
            this.cboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(19, 81);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(152, 21);
            this.cboCustomer.TabIndex = 1;
            // 
            // cboCusType
            // 
            this.cboCusType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCusType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCusType.FormattingEnabled = true;
            this.cboCusType.Location = new System.Drawing.Point(18, 38);
            this.cboCusType.Name = "cboCusType";
            this.cboCusType.Size = new System.Drawing.Size(153, 21);
            this.cboCusType.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lnkNone);
            this.tabPage2.Controls.Add(this.lnkAll);
            this.tabPage2.Controls.Add(this.lstMechanicList);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(217, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mechanic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lnkNone
            // 
            this.lnkNone.AutoSize = true;
            this.lnkNone.Location = new System.Drawing.Point(170, 113);
            this.lnkNone.Name = "lnkNone";
            this.lnkNone.Size = new System.Drawing.Size(42, 13);
            this.lnkNone.TabIndex = 39;
            this.lnkNone.TabStop = true;
            this.lnkNone.Text = "None...";
            this.lnkNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNone_LinkClicked);
            // 
            // lnkAll
            // 
            this.lnkAll.AutoSize = true;
            this.lnkAll.Location = new System.Drawing.Point(171, 90);
            this.lnkAll.Name = "lnkAll";
            this.lnkAll.Size = new System.Drawing.Size(24, 13);
            this.lnkAll.TabIndex = 39;
            this.lnkAll.TabStop = true;
            this.lnkAll.Text = "All..";
            this.lnkAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAll_LinkClicked);
            // 
            // lstMechanicList
            // 
            this.lstMechanicList.DataSource = this.mMechanicListBindingSource;
            this.lstMechanicList.DisplayMember = "FullName";
            this.lstMechanicList.FormattingEnabled = true;
            this.lstMechanicList.Location = new System.Drawing.Point(15, 21);
            this.lstMechanicList.Name = "lstMechanicList";
            this.lstMechanicList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMechanicList.Size = new System.Drawing.Size(153, 251);
            this.lstMechanicList.TabIndex = 35;
            this.lstMechanicList.ValueMember = "MechanicID";
            // 
            // mMechanicListBindingSource
            // 
            this.mMechanicListBindingSource.DataMember = "m_MechanicList";
            this.mMechanicListBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mechanic";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cboLaborWorkType);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(217, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Labor ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboLaborWorkType
            // 
            this.cboLaborWorkType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLaborWorkType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLaborWorkType.FormattingEnabled = true;
            this.cboLaborWorkType.Location = new System.Drawing.Point(40, 133);
            this.cboLaborWorkType.Name = "cboLaborWorkType";
            this.cboLaborWorkType.Size = new System.Drawing.Size(136, 21);
            this.cboLaborWorkType.TabIndex = 21;
            this.cboLaborWorkType.SelectedIndexChanged += new System.EventHandler(this.cboLaborWorkType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Labor Work Type";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(217, 271);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Items";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(9, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 109);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Items Served";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdBothDeliverdandNonDelivered);
            this.groupBox4.Controls.Add(this.rdnonDelivered);
            this.groupBox4.Controls.Add(this.rdDelivered);
            this.groupBox4.Location = new System.Drawing.Point(255, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 72);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // rdBothDeliverdandNonDelivered
            // 
            this.rdBothDeliverdandNonDelivered.AutoSize = true;
            this.rdBothDeliverdandNonDelivered.Checked = true;
            this.rdBothDeliverdandNonDelivered.Location = new System.Drawing.Point(107, 20);
            this.rdBothDeliverdandNonDelivered.Name = "rdBothDeliverdandNonDelivered";
            this.rdBothDeliverdandNonDelivered.Size = new System.Drawing.Size(36, 17);
            this.rdBothDeliverdandNonDelivered.TabIndex = 25;
            this.rdBothDeliverdandNonDelivered.TabStop = true;
            this.rdBothDeliverdandNonDelivered.Text = "All";
            this.rdBothDeliverdandNonDelivered.UseVisualStyleBackColor = true;
            this.rdBothDeliverdandNonDelivered.Click += new System.EventHandler(this.rdBothDeliverdandNonDelivered_CheckedChanged);
            // 
            // rdnonDelivered
            // 
            this.rdnonDelivered.AutoSize = true;
            this.rdnonDelivered.Location = new System.Drawing.Point(13, 43);
            this.rdnonDelivered.Name = "rdnonDelivered";
            this.rdnonDelivered.Size = new System.Drawing.Size(93, 17);
            this.rdnonDelivered.TabIndex = 25;
            this.rdnonDelivered.TabStop = true;
            this.rdnonDelivered.Text = "Non-Delivered";
            this.rdnonDelivered.UseVisualStyleBackColor = true;
            this.rdnonDelivered.Click += new System.EventHandler(this.rdnonDelivered_Click);
            // 
            // rdDelivered
            // 
            this.rdDelivered.AutoSize = true;
            this.rdDelivered.Location = new System.Drawing.Point(13, 20);
            this.rdDelivered.Name = "rdDelivered";
            this.rdDelivered.Size = new System.Drawing.Size(70, 17);
            this.rdDelivered.TabIndex = 25;
            this.rdDelivered.TabStop = true;
            this.rdDelivered.Text = "Delivered";
            this.rdDelivered.UseVisualStyleBackColor = true;
            this.rdDelivered.Click += new System.EventHandler(this.rdDelivered_Click);
            // 
            // rptGroup
            // 
            this.rptGroup.Controls.Add(this.radioButton5);
            this.rptGroup.Controls.Add(this.radioButton6);
            this.rptGroup.Controls.Add(this.radioButton1);
            this.rptGroup.Controls.Add(this.radioButton2);
            this.rptGroup.Controls.Add(this.radioButton4);
            this.rptGroup.Controls.Add(this.radioButton3);
            this.rptGroup.Location = new System.Drawing.Point(254, 24);
            this.rptGroup.Name = "rptGroup";
            this.rptGroup.Size = new System.Drawing.Size(201, 151);
            this.rptGroup.TabIndex = 40;
            this.rptGroup.TabStop = false;
            this.rptGroup.Text = "Duration Grouping Method";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(22, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(91, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Semi Annually";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(23, 130);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Yearly";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monthly";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quarterly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(23, 41);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Weakly";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Daily";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Item Type";
            this.label7.Visible = false;
            // 
            // cboItemServiceType
            // 
            this.cboItemServiceType.DropDownHeight = 200;
            this.cboItemServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemServiceType.FormattingEnabled = true;
            this.cboItemServiceType.IntegralHeight = false;
            this.cboItemServiceType.Items.AddRange(new object[] {
            "All",
            "Parts Sales",
            "Vehicle Sales",
            "Maintenance",
            "Rentals"});
            this.cboItemServiceType.Location = new System.Drawing.Point(197, 310);
            this.cboItemServiceType.Name = "cboItemServiceType";
            this.cboItemServiceType.Size = new System.Drawing.Size(10, 21);
            this.cboItemServiceType.TabIndex = 38;
            this.cboItemServiceType.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optNone);
            this.groupBox2.Controls.Add(this.optSType);
            this.groupBox2.Controls.Add(this.optVType);
            this.groupBox2.Controls.Add(this.optCusType);
            this.groupBox2.Location = new System.Drawing.Point(461, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 119);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group records by";
            // 
            // optNone
            // 
            this.optNone.AutoSize = true;
            this.optNone.Checked = true;
            this.optNone.Location = new System.Drawing.Point(34, 19);
            this.optNone.Name = "optNone";
            this.optNone.Size = new System.Drawing.Size(51, 17);
            this.optNone.TabIndex = 2;
            this.optNone.TabStop = true;
            this.optNone.Text = "None";
            this.optNone.UseVisualStyleBackColor = true;
            this.optNone.CheckedChanged += new System.EventHandler(this.optNone_CheckedChanged);
            // 
            // optSType
            // 
            this.optSType.AutoSize = true;
            this.optSType.Location = new System.Drawing.Point(34, 84);
            this.optSType.Name = "optSType";
            this.optSType.Size = new System.Drawing.Size(88, 17);
            this.optSType.TabIndex = 1;
            this.optSType.Text = "Service Type";
            this.optSType.UseVisualStyleBackColor = true;
            // 
            // optVType
            // 
            this.optVType.AutoSize = true;
            this.optVType.Location = new System.Drawing.Point(34, 62);
            this.optVType.Name = "optVType";
            this.optVType.Size = new System.Drawing.Size(87, 17);
            this.optVType.TabIndex = 1;
            this.optVType.Text = "Vehicle Type";
            this.optVType.UseVisualStyleBackColor = true;
            this.optVType.CheckedChanged += new System.EventHandler(this.optVType_CheckedChanged);
            // 
            // optCusType
            // 
            this.optCusType.AutoSize = true;
            this.optCusType.Location = new System.Drawing.Point(34, 40);
            this.optCusType.Name = "optCusType";
            this.optCusType.Size = new System.Drawing.Size(96, 17);
            this.optCusType.TabIndex = 0;
            this.optCusType.Text = "Customer Type";
            this.optCusType.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(516, 257);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(105, 22);
            this.btnGo.TabIndex = 36;
            this.btnGo.Text = "Show Report";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtTo);
            this.groupBox3.Controls.Add(this.dtFrom);
            this.groupBox3.Location = new System.Drawing.Point(461, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 99);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MMM dd, yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(48, 58);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(105, 20);
            this.dtTo.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MMM dd, yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(48, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(105, 20);
            this.dtFrom.TabIndex = 0;
            // 
            // m_MechanicListTableAdapter
            // 
            this.m_MechanicListTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 10);
            this.panel1.TabIndex = 42;
            // 
            // rptMechanicLabourBindingSource
            // 
            this.rptMechanicLabourBindingSource.DataMember = "rpt_Mechanic_Labour";
            this.rptMechanicLabourBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // rpt_Mechanic_LabourTableAdapter
            // 
            this.rpt_Mechanic_LabourTableAdapter.ClearBeforeFill = true;
            // 
            // chkDetails
            // 
            this.chkDetails.AutoSize = true;
            this.chkDetails.Location = new System.Drawing.Point(310, 260);
            this.chkDetails.Name = "chkDetails";
            this.chkDetails.Size = new System.Drawing.Size(88, 17);
            this.chkDetails.TabIndex = 43;
            this.chkDetails.Text = "Show Details";
            this.chkDetails.UseVisualStyleBackColor = true;
            this.chkDetails.Visible = false;
            // 
            // chkLaborDetails
            // 
            this.chkLaborDetails.AutoSize = true;
            this.chkLaborDetails.Location = new System.Drawing.Point(503, 313);
            this.chkLaborDetails.Name = "chkLaborDetails";
            this.chkLaborDetails.Size = new System.Drawing.Size(88, 17);
            this.chkLaborDetails.TabIndex = 44;
            this.chkLaborDetails.Text = "Show Details";
            this.chkLaborDetails.UseVisualStyleBackColor = true;
            this.chkLaborDetails.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(579, 297);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Item list";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // grpLaborDetails
            // 
            this.grpLaborDetails.Controls.Add(this.optLaborNoDetails);
            this.grpLaborDetails.Controls.Add(this.opLaborDetails);
            this.grpLaborDetails.Controls.Add(this.optLaborBoth);
            this.grpLaborDetails.Location = new System.Drawing.Point(255, 261);
            this.grpLaborDetails.Name = "grpLaborDetails";
            this.grpLaborDetails.Size = new System.Drawing.Size(200, 71);
            this.grpLaborDetails.TabIndex = 46;
            this.grpLaborDetails.TabStop = false;
            this.grpLaborDetails.Text = "Labor Details";
            // 
            // optLaborNoDetails
            // 
            this.optLaborNoDetails.AutoSize = true;
            this.optLaborNoDetails.Location = new System.Drawing.Point(13, 42);
            this.optLaborNoDetails.Name = "optLaborNoDetails";
            this.optLaborNoDetails.Size = new System.Drawing.Size(74, 17);
            this.optLaborNoDetails.TabIndex = 25;
            this.optLaborNoDetails.Text = "No Details";
            this.optLaborNoDetails.UseVisualStyleBackColor = true;
            this.optLaborNoDetails.Click += new System.EventHandler(this.rdDelivered_Click);
            this.optLaborNoDetails.CheckedChanged += new System.EventHandler(this.optLaborNoDetails_CheckedChanged);
            // 
            // opLaborDetails
            // 
            this.opLaborDetails.AutoSize = true;
            this.opLaborDetails.Location = new System.Drawing.Point(13, 19);
            this.opLaborDetails.Name = "opLaborDetails";
            this.opLaborDetails.Size = new System.Drawing.Size(57, 17);
            this.opLaborDetails.TabIndex = 25;
            this.opLaborDetails.Text = "Details";
            this.opLaborDetails.UseVisualStyleBackColor = true;
            this.opLaborDetails.Click += new System.EventHandler(this.rdDelivered_Click);
            this.opLaborDetails.CheckedChanged += new System.EventHandler(this.opLaborDetails_CheckedChanged);
            // 
            // optLaborBoth
            // 
            this.optLaborBoth.AutoSize = true;
            this.optLaborBoth.Checked = true;
            this.optLaborBoth.Location = new System.Drawing.Point(107, 19);
            this.optLaborBoth.Name = "optLaborBoth";
            this.optLaborBoth.Size = new System.Drawing.Size(47, 17);
            this.optLaborBoth.TabIndex = 25;
            this.optLaborBoth.TabStop = true;
            this.optLaborBoth.Text = "Both";
            this.optLaborBoth.UseVisualStyleBackColor = true;
            this.optLaborBoth.Click += new System.EventHandler(this.rdDelivered_Click);
            this.optLaborBoth.CheckedChanged += new System.EventHandler(this.optLaborBoth_CheckedChanged);
            // 
            // frmMaintenanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 363);
            this.Controls.Add(this.chkLaborDetails);
            this.Controls.Add(this.grpLaborDetails);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chkDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rptGroup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboItemServiceType);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tbMaintenanceReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMaintenanceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance Specifications";
            this.Load += new System.EventHandler(this.frmMaintenanceReport_Load);
            this.tbMaintenanceReports.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mMechanicListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.rptGroup.ResumeLayout(false);
            this.rptGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rptMechanicLabourBindingSource)).EndInit();
            this.grpLaborDetails.ResumeLayout(false);
            this.grpLaborDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboServiceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboCusType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdBothDeliverdandNonDelivered;
        private System.Windows.Forms.RadioButton rdnonDelivered;
        private System.Windows.Forms.RadioButton rdDelivered;
        public System.Windows.Forms.GroupBox rptGroup;
        public System.Windows.Forms.RadioButton radioButton5;
        public System.Windows.Forms.RadioButton radioButton6;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton4;
        public System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboItemServiceType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optNone;
        private System.Windows.Forms.RadioButton optSType;
        private System.Windows.Forms.RadioButton optVType;
        private System.Windows.Forms.RadioButton optCusType;
        public System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtTo;
        public System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label8;
        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource mMechanicListBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_MechanicListTableAdapter m_MechanicListTableAdapter;
        private System.Windows.Forms.ListBox lstMechanicList;
        private System.Windows.Forms.LinkLabel lnkNone;
        private System.Windows.Forms.LinkLabel lnkAll;
        public System.Windows.Forms.TabControl tbMaintenanceReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource rptMechanicLabourBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.rpt_Mechanic_LabourTableAdapter rpt_Mechanic_LabourTableAdapter;
        private System.Windows.Forms.CheckBox chkDetails;
        private System.Windows.Forms.CheckBox chkLaborDetails;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox grpLaborDetails;
        private System.Windows.Forms.RadioButton optLaborNoDetails;
        private System.Windows.Forms.RadioButton opLaborDetails;
        private System.Windows.Forms.RadioButton optLaborBoth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cboLaborWorkType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;




    }
}