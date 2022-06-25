namespace Belayab
{
    partial class frmMaintenanceHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceHome));
            this.grdRecentWos = new System.Windows.Forms.DataGridView();
            this.WorkOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kMReadingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mReceivedDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deiveryDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.isOut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mmaintenanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain1 = new Belayab.BelayAbVMaintain();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_maintenanceTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_maintenanceTableAdapter();
            this.m_VehiclesTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_VehiclesTableAdapter();
            this.customersTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.CustomersTableAdapter();
            this.btnAllWorkOrders = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.rdWON = new System.Windows.Forms.RadioButton();
            this.rdPN = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.partNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partNumDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.requestedQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKItemsIssuedDetailsItemsIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.issueNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remariksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKItemRequisionDetailsItemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdRequistions = new System.Windows.Forms.DataGridView();
            this.RequistionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requistionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemRequisitionTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter();
            this.itemRequisitionDetailsTableAdapter = new Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter();
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.itemsIssuedTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedTableAdapter();
            this.itemsIssuedDetailsTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedDetailsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderNumberH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mReceivedDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deiveryDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM_Reading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextKilometerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workOrderNumberL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsIssuedDetailsItemsIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemRequisionDetailsItemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdRecentWos
            // 
            this.grdRecentWos.AllowUserToAddRows = false;
            this.grdRecentWos.AllowUserToDeleteRows = false;
            this.grdRecentWos.AllowUserToResizeRows = false;
            this.grdRecentWos.AutoGenerateColumns = false;
            this.grdRecentWos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecentWos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkOrderNumber,
            this.plateNumberDataGridViewTextBoxColumn1,
            this.kMReadingDataGridViewTextBoxColumn1,
            this.isOutDataGridViewCheckBoxColumn1,
            this.mReceivedDateDataGridViewTextBoxColumn2,
            this.deiveryDateDataGridViewTextBoxColumn2,
            this.durationDataGridViewTextBoxColumn1,
            this.remarksDataGridViewTextBoxColumn1});
            this.grdRecentWos.DataSource = this.mmaintenanceBindingSource;
            this.grdRecentWos.Location = new System.Drawing.Point(12, 26);
            this.grdRecentWos.Name = "grdRecentWos";
            this.grdRecentWos.ReadOnly = true;
            this.grdRecentWos.Size = new System.Drawing.Size(928, 332);
            this.grdRecentWos.TabIndex = 2;
            this.grdRecentWos.DoubleClick += new System.EventHandler(this.grdRecentWos_DoubleClick);
            this.grdRecentWos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecentWos_CellClick);
            // 
            // WorkOrderNumber
            // 
            this.WorkOrderNumber.DataPropertyName = "WorkOrderNumber";
            this.WorkOrderNumber.HeaderText = "W. O. No.";
            this.WorkOrderNumber.Name = "WorkOrderNumber";
            this.WorkOrderNumber.ReadOnly = true;
            // 
            // plateNumberDataGridViewTextBoxColumn1
            // 
            this.plateNumberDataGridViewTextBoxColumn1.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn1.HeaderText = "Plate Number";
            this.plateNumberDataGridViewTextBoxColumn1.Name = "plateNumberDataGridViewTextBoxColumn1";
            this.plateNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kMReadingDataGridViewTextBoxColumn1
            // 
            this.kMReadingDataGridViewTextBoxColumn1.DataPropertyName = "KM_Reading";
            this.kMReadingDataGridViewTextBoxColumn1.HeaderText = "KM_Reading";
            this.kMReadingDataGridViewTextBoxColumn1.Name = "kMReadingDataGridViewTextBoxColumn1";
            this.kMReadingDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // isOutDataGridViewCheckBoxColumn1
            // 
            this.isOutDataGridViewCheckBoxColumn1.DataPropertyName = "isOut";
            this.isOutDataGridViewCheckBoxColumn1.HeaderText = "is Out";
            this.isOutDataGridViewCheckBoxColumn1.Name = "isOutDataGridViewCheckBoxColumn1";
            this.isOutDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // mReceivedDateDataGridViewTextBoxColumn2
            // 
            this.mReceivedDateDataGridViewTextBoxColumn2.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.mReceivedDateDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.mReceivedDateDataGridViewTextBoxColumn2.HeaderText = "Date In";
            this.mReceivedDateDataGridViewTextBoxColumn2.Name = "mReceivedDateDataGridViewTextBoxColumn2";
            this.mReceivedDateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // deiveryDateDataGridViewTextBoxColumn2
            // 
            this.deiveryDateDataGridViewTextBoxColumn2.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.deiveryDateDataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.deiveryDateDataGridViewTextBoxColumn2.HeaderText = "Date Out";
            this.deiveryDateDataGridViewTextBoxColumn2.Name = "deiveryDateDataGridViewTextBoxColumn2";
            this.deiveryDateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn1
            // 
            this.durationDataGridViewTextBoxColumn1.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn1.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn1.Name = "durationDataGridViewTextBoxColumn1";
            this.durationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn1
            // 
            this.remarksDataGridViewTextBoxColumn1.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.Name = "remarksDataGridViewTextBoxColumn1";
            this.remarksDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mmaintenanceBindingSource
            // 
            this.mmaintenanceBindingSource.DataMember = "m_maintenance";
            this.mmaintenanceBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isOut
            // 
            this.isOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isOut.DataPropertyName = "isOut";
            this.isOut.FalseValue = "No";
            this.isOut.HeaderText = "Is Out";
            this.isOut.Name = "isOut";
            this.isOut.ReadOnly = true;
            this.isOut.TrueValue = "Yes";
            this.isOut.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Active/Recent Workorders";
            // 
            // mVehiclesBindingSource
            // 
            this.mVehiclesBindingSource.DataMember = "m_Vehicles";
            this.mVehiclesBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // mmaintenanceBindingSource1
            // 
            this.mmaintenanceBindingSource1.DataMember = "m_maintenance";
            this.mmaintenanceBindingSource1.DataSource = this.belayAbVMaintain1;
            // 
            // belayAbVMaintain1
            // 
            this.belayAbVMaintain1.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // m_maintenanceTableAdapter
            // 
            this.m_maintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // m_VehiclesTableAdapter
            // 
            this.m_VehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnAllWorkOrders
            // 
            this.btnAllWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllWorkOrders.Location = new System.Drawing.Point(759, 5);
            this.btnAllWorkOrders.Name = "btnAllWorkOrders";
            this.btnAllWorkOrders.Size = new System.Drawing.Size(88, 21);
            this.btnAllWorkOrders.TabIndex = 5;
            this.btnAllWorkOrders.Text = "Show All";
            this.btnAllWorkOrders.UseVisualStyleBackColor = true;
            this.btnAllWorkOrders.Click += new System.EventHandler(this.btnAllWorkOrders_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(864, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 21);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Find by>>";
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Khaki;
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Location = new System.Drawing.Point(617, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(115, 13);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // rdWON
            // 
            this.rdWON.AutoSize = true;
            this.rdWON.Checked = true;
            this.rdWON.Location = new System.Drawing.Point(490, 6);
            this.rdWON.Name = "rdWON";
            this.rdWON.Size = new System.Drawing.Size(52, 17);
            this.rdWON.TabIndex = 9;
            this.rdWON.TabStop = true;
            this.rdWON.Text = "WON";
            this.rdWON.UseVisualStyleBackColor = true;
            this.rdWON.CheckedChanged += new System.EventHandler(this.rdWON_CheckedChanged);
            // 
            // rdPN
            // 
            this.rdPN.AutoSize = true;
            this.rdPN.Location = new System.Drawing.Point(542, 6);
            this.rdPN.Name = "rdPN";
            this.rdPN.Size = new System.Drawing.Size(69, 17);
            this.rdPN.TabIndex = 9;
            this.rdPN.Text = "Plate No:";
            this.rdPN.UseVisualStyleBackColor = true;
            this.rdPN.CheckedChanged += new System.EventHandler(this.rdPN_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 366);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 394);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Process";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView4);
            this.groupBox5.Location = new System.Drawing.Point(439, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 198);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Issue Details";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNumberDataGridViewTextBoxColumn1,
            this.requestedQtyDataGridViewTextBoxColumn,
            this.issuedQtyDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.fKItemsIssuedDetailsItemsIssuedBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(7, 16);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(466, 176);
            this.dataGridView4.TabIndex = 2;
            // 
            // partNumberDataGridViewTextBoxColumn1
            // 
            this.partNumberDataGridViewTextBoxColumn1.DataPropertyName = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn1.DataSource = this.partNumDescriptionBindingSource1;
            this.partNumberDataGridViewTextBoxColumn1.DisplayMember = "Description";
            this.partNumberDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.partNumberDataGridViewTextBoxColumn1.HeaderText = "Item";
            this.partNumberDataGridViewTextBoxColumn1.Name = "partNumberDataGridViewTextBoxColumn1";
            this.partNumberDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.partNumberDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.partNumberDataGridViewTextBoxColumn1.ValueMember = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn1.Width = 150;
            // 
            // partNumDescriptionBindingSource1
            // 
            this.partNumDescriptionBindingSource1.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource1.DataSource = this.belayAbSSDataSet;
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requestedQtyDataGridViewTextBoxColumn
            // 
            this.requestedQtyDataGridViewTextBoxColumn.DataPropertyName = "RequestedQty";
            this.requestedQtyDataGridViewTextBoxColumn.HeaderText = "Requested";
            this.requestedQtyDataGridViewTextBoxColumn.Name = "requestedQtyDataGridViewTextBoxColumn";
            // 
            // issuedQtyDataGridViewTextBoxColumn
            // 
            this.issuedQtyDataGridViewTextBoxColumn.DataPropertyName = "IssuedQty";
            this.issuedQtyDataGridViewTextBoxColumn.HeaderText = "Issued";
            this.issuedQtyDataGridViewTextBoxColumn.Name = "issuedQtyDataGridViewTextBoxColumn";
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            // 
            // fKItemsIssuedDetailsItemsIssuedBindingSource
            // 
            this.fKItemsIssuedDetailsItemsIssuedBindingSource.DataMember = "FK_ItemsIssuedDetails_ItemsIssued";
            this.fKItemsIssuedDetailsItemsIssuedBindingSource.DataSource = this.itemsIssuedBindingSource;
            // 
            // itemsIssuedBindingSource
            // 
            this.itemsIssuedBindingSource.DataMember = "ItemsIssued";
            this.itemsIssuedBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Location = new System.Drawing.Point(439, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(479, 128);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Issues";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issueNoDataGridViewTextBoxColumn,
            this.preparedByDataGridViewTextBoxColumn,
            this.approvedByDataGridViewTextBoxColumn1,
            this.issueDateDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.itemsIssuedBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(7, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(466, 100);
            this.dataGridView3.TabIndex = 2;
            // 
            // issueNoDataGridViewTextBoxColumn
            // 
            this.issueNoDataGridViewTextBoxColumn.DataPropertyName = "IssueNo";
            this.issueNoDataGridViewTextBoxColumn.HeaderText = "Issue No";
            this.issueNoDataGridViewTextBoxColumn.Name = "issueNoDataGridViewTextBoxColumn";
            // 
            // preparedByDataGridViewTextBoxColumn
            // 
            this.preparedByDataGridViewTextBoxColumn.DataPropertyName = "PreparedBy";
            this.preparedByDataGridViewTextBoxColumn.HeaderText = "Prepared By";
            this.preparedByDataGridViewTextBoxColumn.Name = "preparedByDataGridViewTextBoxColumn";
            // 
            // approvedByDataGridViewTextBoxColumn1
            // 
            this.approvedByDataGridViewTextBoxColumn1.DataPropertyName = "ApprovedBy";
            this.approvedByDataGridViewTextBoxColumn1.HeaderText = "Approved By";
            this.approvedByDataGridViewTextBoxColumn1.Name = "approvedByDataGridViewTextBoxColumn1";
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "Issue Date";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(6, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 198);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requision Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.requestedQuantityDataGridViewTextBoxColumn,
            this.remariksDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKItemRequisionDetailsItemRequisitionBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(415, 167);
            this.dataGridView2.TabIndex = 0;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "PartNumber";
            this.Description.DataSource = this.partNumDescriptionBindingSource;
            this.Description.DisplayMember = "Description";
            this.Description.HeaderText = "Item";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Description.ValueMember = "PartNumber";
            this.Description.Width = 220;
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // requestedQuantityDataGridViewTextBoxColumn
            // 
            this.requestedQuantityDataGridViewTextBoxColumn.DataPropertyName = "RequestedQuantity";
            this.requestedQuantityDataGridViewTextBoxColumn.HeaderText = "Req Quantity";
            this.requestedQuantityDataGridViewTextBoxColumn.Name = "requestedQuantityDataGridViewTextBoxColumn";
            // 
            // remariksDataGridViewTextBoxColumn
            // 
            this.remariksDataGridViewTextBoxColumn.DataPropertyName = "Remariks";
            this.remariksDataGridViewTextBoxColumn.HeaderText = "Remariks";
            this.remariksDataGridViewTextBoxColumn.Name = "remariksDataGridViewTextBoxColumn";
            // 
            // fKItemRequisionDetailsItemRequisitionBindingSource
            // 
            this.fKItemRequisionDetailsItemRequisitionBindingSource.DataMember = "FK_ItemRequisionDetails_ItemRequisition";
            this.fKItemRequisionDetailsItemRequisitionBindingSource.DataSource = this.itemRequisitionBindingSource;
            // 
            // itemRequisitionBindingSource
            // 
            this.itemRequisitionBindingSource.DataMember = "ItemRequisition";
            this.itemRequisitionBindingSource.DataSource = this.belayAbItemRequistions;
            // 
            // belayAbItemRequistions
            // 
            this.belayAbItemRequistions.DataSetName = "BelayAbItemRequistions";
            this.belayAbItemRequistions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdRequistions);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requisions";
            // 
            // grdRequistions
            // 
            this.grdRequistions.AllowUserToAddRows = false;
            this.grdRequistions.AllowUserToDeleteRows = false;
            this.grdRequistions.AutoGenerateColumns = false;
            this.grdRequistions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequistions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequistionNumber,
            this.requestedByDataGridViewTextBoxColumn,
            this.approvedByDataGridViewTextBoxColumn,
            this.requistionDateDataGridViewTextBoxColumn});
            this.grdRequistions.DataSource = this.itemRequisitionBindingSource;
            this.grdRequistions.Location = new System.Drawing.Point(6, 19);
            this.grdRequistions.Name = "grdRequistions";
            this.grdRequistions.Size = new System.Drawing.Size(415, 100);
            this.grdRequistions.TabIndex = 0;
            this.grdRequistions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRequistions_CellClick);
            // 
            // RequistionNumber
            // 
            this.RequistionNumber.DataPropertyName = "RequisitionNumber";
            this.RequistionNumber.HeaderText = "Req No";
            this.RequistionNumber.Name = "RequistionNumber";
            // 
            // requestedByDataGridViewTextBoxColumn
            // 
            this.requestedByDataGridViewTextBoxColumn.DataPropertyName = "RequestedBy";
            this.requestedByDataGridViewTextBoxColumn.HeaderText = "Requseted By";
            this.requestedByDataGridViewTextBoxColumn.Name = "requestedByDataGridViewTextBoxColumn";
            // 
            // approvedByDataGridViewTextBoxColumn
            // 
            this.approvedByDataGridViewTextBoxColumn.DataPropertyName = "ApprovedBy";
            this.approvedByDataGridViewTextBoxColumn.HeaderText = "Approved By";
            this.approvedByDataGridViewTextBoxColumn.Name = "approvedByDataGridViewTextBoxColumn";
            // 
            // requistionDateDataGridViewTextBoxColumn
            // 
            this.requistionDateDataGridViewTextBoxColumn.DataPropertyName = "RequistionDate";
            this.requistionDateDataGridViewTextBoxColumn.HeaderText = "Req Date";
            this.requistionDateDataGridViewTextBoxColumn.Name = "requistionDateDataGridViewTextBoxColumn";
            // 
            // itemRequisitionTableAdapter
            // 
            this.itemRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // itemRequisitionDetailsTableAdapter
            // 
            this.itemRequisitionDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // itemsIssuedTableAdapter
            // 
            this.itemsIssuedTableAdapter.ClearBeforeFill = true;
            // 
            // itemsIssuedDetailsTableAdapter
            // 
            this.itemsIssuedDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Maintenace Total";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KM_Reading";
            this.dataGridViewTextBoxColumn2.HeaderText = "KM Reading";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle6.Format = "d";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "Date Out";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KM_Reading";
            this.dataGridViewTextBoxColumn6.HeaderText = "KM Reading";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 300;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn8.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IssueNo";
            this.dataGridViewTextBoxColumn9.HeaderText = "IssueNo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PartNumber";
            this.dataGridViewTextBoxColumn10.HeaderText = "PartNumber";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Units";
            this.dataGridViewTextBoxColumn11.HeaderText = "Units";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "RequestedQty";
            this.dataGridViewTextBoxColumn12.HeaderText = "RequestedQty";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IssuedQty";
            this.dataGridViewTextBoxColumn13.HeaderText = "IssuedQty";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn15.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ReturnCase";
            this.dataGridViewTextBoxColumn16.HeaderText = "ReturnCase";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "HD";
            this.dataGridViewTextBoxColumn17.HeaderText = "HD";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RequestedQuantity";
            this.dataGridViewTextBoxColumn18.HeaderText = "Req Quantity";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Remariks";
            this.dataGridViewTextBoxColumn19.HeaderText = "Remariks";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "IssueNo";
            this.dataGridViewTextBoxColumn20.HeaderText = "IssueNo";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "PreparedBy";
            this.dataGridViewTextBoxColumn21.HeaderText = "PreparedBy";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ApprovedBy";
            this.dataGridViewTextBoxColumn22.HeaderText = "ApprovedBy";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "IssueDate";
            this.dataGridViewTextBoxColumn23.HeaderText = "IssueDate";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn24.HeaderText = "State";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "RequisitionNumber";
            this.dataGridViewTextBoxColumn25.HeaderText = "Req No";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "RequestedBy";
            this.dataGridViewTextBoxColumn26.HeaderText = "Req By";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ApprovedBy";
            this.dataGridViewTextBoxColumn27.HeaderText = "Approved By";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "RequistionDate";
            this.dataGridViewTextBoxColumn28.HeaderText = "Req Date";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Plate Number";
            this.dataGridViewTextBoxColumn29.HeaderText = "Plate Number";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "VehicleType";
            this.dataGridViewTextBoxColumn30.HeaderText = "VehicleType";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Chasis Number";
            this.dataGridViewTextBoxColumn31.HeaderText = "Chasis Number";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "WorkOrderNumber";
            this.dataGridViewTextBoxColumn32.HeaderText = "Work Order No";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn33.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn34.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn34.HeaderText = "Date Out";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "KM_Reading";
            this.dataGridViewTextBoxColumn35.HeaderText = "KM_Reading";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Next Kilometer";
            this.dataGridViewTextBoxColumn36.HeaderText = "Next Kilometer";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0";
            this.dataGridViewTextBoxColumn37.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn37.HeaderText = "Maintenace Total";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn38.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "ApprovalDate";
            this.dataGridViewTextBoxColumn39.HeaderText = "ApprovalDate";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "MechanicID";
            this.dataGridViewTextBoxColumn40.HeaderText = "MechanicID";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "m_CompletedDate";
            this.dataGridViewTextBoxColumn41.HeaderText = "m_CompletedDate";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "m_ReceivedBy";
            this.dataGridViewTextBoxColumn42.HeaderText = "m_ReceivedBy";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "m_ReceivedDate";
            this.dataGridViewTextBoxColumn43.HeaderText = "m_ReceivedDate";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "Next Service Date";
            this.dataGridViewTextBoxColumn44.HeaderText = "Next Service Date";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Next Kilometer";
            this.dataGridViewTextBoxColumn45.HeaderText = "Next Kilometer";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Maintenace Total";
            this.dataGridViewTextBoxColumn46.HeaderText = "Maintenace Total";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "LTotal";
            this.dataGridViewTextBoxColumn47.HeaderText = "LTotal";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "FTotal";
            this.dataGridViewTextBoxColumn48.HeaderText = "FTotal";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "RTotal";
            this.dataGridViewTextBoxColumn49.HeaderText = "RTotal";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn50.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 300;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn51.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "OWTotal";
            this.dataGridViewTextBoxColumn52.HeaderText = "OWTotal";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "CreatedBy";
            this.dataGridViewTextBoxColumn53.HeaderText = "CreatedBy";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Updatedby";
            this.dataGridViewTextBoxColumn54.HeaderText = "Updatedby";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            // 
            // workOrderNumberH
            // 
            this.workOrderNumberH.DataPropertyName = "WorkOrderNumber";
            this.workOrderNumberH.HeaderText = "Work Order No";
            this.workOrderNumberH.Name = "workOrderNumberH";
            this.workOrderNumberH.ReadOnly = true;
            // 
            // mReceivedDateDataGridViewTextBoxColumn1
            // 
            this.mReceivedDateDataGridViewTextBoxColumn1.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.mReceivedDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.mReceivedDateDataGridViewTextBoxColumn1.HeaderText = "Date In";
            this.mReceivedDateDataGridViewTextBoxColumn1.Name = "mReceivedDateDataGridViewTextBoxColumn1";
            this.mReceivedDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deiveryDateDataGridViewTextBoxColumn1
            // 
            this.deiveryDateDataGridViewTextBoxColumn1.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.deiveryDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.deiveryDateDataGridViewTextBoxColumn1.HeaderText = "Date Out";
            this.deiveryDateDataGridViewTextBoxColumn1.Name = "deiveryDateDataGridViewTextBoxColumn1";
            this.deiveryDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // KM_Reading
            // 
            this.KM_Reading.DataPropertyName = "KM_Reading";
            this.KM_Reading.HeaderText = "KM_Reading";
            this.KM_Reading.Name = "KM_Reading";
            this.KM_Reading.ReadOnly = true;
            // 
            // nextKilometerDataGridViewTextBoxColumn1
            // 
            this.nextKilometerDataGridViewTextBoxColumn1.DataPropertyName = "Next Kilometer";
            this.nextKilometerDataGridViewTextBoxColumn1.HeaderText = "Next Kilometer";
            this.nextKilometerDataGridViewTextBoxColumn1.Name = "nextKilometerDataGridViewTextBoxColumn1";
            this.nextKilometerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // workOrderNumberL
            // 
            this.workOrderNumberL.DataPropertyName = "WorkOrderNumber";
            this.workOrderNumberL.HeaderText = "Work Order No";
            this.workOrderNumberL.Name = "workOrderNumberL";
            this.workOrderNumberL.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.DateIn.DefaultCellStyle = dataGridViewCellStyle13;
            this.DateIn.HeaderText = "Date In";
            this.DateIn.Name = "DateIn";
            this.DateIn.ReadOnly = true;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle14.Format = "d";
            this.DateOut.DefaultCellStyle = dataGridViewCellStyle14;
            this.DateOut.HeaderText = "Date Out";
            this.DateOut.Name = "DateOut";
            this.DateOut.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bindingNavigator1.BindingSource = this.mmaintenanceBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(156, 1);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(208, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Control;
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
            // frmMaintenanceHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 764);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rdPN);
            this.Controls.Add(this.rdWON);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAllWorkOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdRecentWos);
            this.MaximizeBox = false;
            this.Name = "frmMaintenanceHome";
            this.Tag = "MaintenanceHome";
            this.Text = "Maintenance Home";
            this.Load += new System.EventHandler(this.frmMaintenanceHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsIssuedDetailsItemsIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemRequisionDetailsItemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRecentWos;
        private System.Windows.Forms.Label label1;
        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource mmaintenanceBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_maintenanceTableAdapter m_maintenanceTableAdapter;
        private System.Windows.Forms.BindingSource mVehiclesBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_VehiclesTableAdapter m_VehiclesTableAdapter;
        private System.Windows.Forms.BindingSource mmaintenanceBindingSource1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.CustomersTableAdapter customersTableAdapter;
        private BelayAbVMaintain belayAbVMaintain1;
        private System.Windows.Forms.Button btnAllWorkOrders;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rdWON;
        private System.Windows.Forms.RadioButton rdPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderNumberL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderNumberH;
        private System.Windows.Forms.DataGridViewTextBoxColumn mReceivedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deiveryDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM_Reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextKilometerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView grdRequistions;
        private BelayAbItemRequistions belayAbItemRequistions;
        private System.Windows.Forms.BindingSource itemRequisitionBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionTableAdapter itemRequisitionTableAdapter;
        private System.Windows.Forms.BindingSource fKItemRequisionDetailsItemRequisitionBindingSource;
        private Belayab.BelayAbItemRequistionsTableAdapters.ItemRequisitionDetailsTableAdapter itemRequisitionDetailsTableAdapter;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.BindingSource itemsIssuedBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedTableAdapter itemsIssuedTableAdapter;
        private System.Windows.Forms.BindingSource fKItemsIssuedDetailsItemsIssuedBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.ItemsIssuedDetailsTableAdapter itemsIssuedDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remariksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewComboBoxColumn partNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preparedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequistionNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requistionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kMReadingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mReceivedDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn deiveryDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn1;
    }
}