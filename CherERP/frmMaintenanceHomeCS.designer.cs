namespace Belayab
{
    partial class frmMaintenanceHomeCS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceHomeCS));
            this.grdRecentWos = new System.Windows.Forms.DataGridView();
            this.WorkOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOut1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maintenaceTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.workOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laborWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.mmaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isOut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.mVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllVehicles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdVehicleList = new System.Windows.Forms.DataGridView();
            this.PlateNumberV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdHistory = new System.Windows.Forms.DataGridView();
            this.WorkOrderNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kMReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mReceivedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deiveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenaceTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextKilometerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstOwners = new System.Windows.Forms.ListBox();
            this.partNumDescriptionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.fKItemsIssuedDetailsItemsIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsIssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKItemRequisionDetailsItemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbItemRequistions = new Belayab.BelayAbItemRequistions();
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
            this.belayAbVMaintainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceListTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.MaintenanceListTableAdapter();
            this.rdCusName = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsIssuedDetailsItemsIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemRequisionDetailsItemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRecentWos
            // 
            this.grdRecentWos.AllowUserToAddRows = false;
            this.grdRecentWos.AllowUserToDeleteRows = false;
            this.grdRecentWos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            this.grdRecentWos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdRecentWos.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRecentWos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdRecentWos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecentWos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkOrderNumber,
            this.CustomerName,
            this.VehicleType,
            this.PlateNumber,
            this.DateIn1,
            this.DateOut1,
            this.Duration1,
            this.isOutDataGridViewCheckBoxColumn1,
            this.maintenaceTotalDataGridViewTextBoxColumn1,
            this.ApprovedBy,
            this.remarksDataGridViewTextBoxColumn1});
            this.grdRecentWos.ContextMenuStrip = this.contextMenuStrip1;
            this.grdRecentWos.DataSource = this.maintenanceListBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRecentWos.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdRecentWos.Location = new System.Drawing.Point(12, 25);
            this.grdRecentWos.Name = "grdRecentWos";
            this.grdRecentWos.ReadOnly = true;
            this.grdRecentWos.Size = new System.Drawing.Size(1054, 215);
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
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 120;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "VehicleType";
            this.VehicleType.HeaderText = "Vehicle Type";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.ReadOnly = true;
            // 
            // PlateNumber
            // 
            this.PlateNumber.DataPropertyName = "PlateNumber";
            this.PlateNumber.HeaderText = "Plate Number";
            this.PlateNumber.Name = "PlateNumber";
            this.PlateNumber.ReadOnly = true;
            // 
            // DateIn1
            // 
            this.DateIn1.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.DateIn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateIn1.HeaderText = "Date In";
            this.DateIn1.Name = "DateIn1";
            this.DateIn1.ReadOnly = true;
            this.DateIn1.Width = 85;
            // 
            // DateOut1
            // 
            this.DateOut1.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DateOut1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateOut1.HeaderText = "Date Out";
            this.DateOut1.Name = "DateOut1";
            this.DateOut1.ReadOnly = true;
            this.DateOut1.Width = 85;
            // 
            // Duration1
            // 
            this.Duration1.HeaderText = "Duration";
            this.Duration1.Name = "Duration1";
            this.Duration1.ReadOnly = true;
            this.Duration1.Width = 80;
            // 
            // isOutDataGridViewCheckBoxColumn1
            // 
            this.isOutDataGridViewCheckBoxColumn1.DataPropertyName = "isOut";
            this.isOutDataGridViewCheckBoxColumn1.HeaderText = "is Out";
            this.isOutDataGridViewCheckBoxColumn1.Name = "isOutDataGridViewCheckBoxColumn1";
            this.isOutDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.isOutDataGridViewCheckBoxColumn1.Width = 60;
            // 
            // maintenaceTotalDataGridViewTextBoxColumn1
            // 
            this.maintenaceTotalDataGridViewTextBoxColumn1.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.maintenaceTotalDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.maintenaceTotalDataGridViewTextBoxColumn1.HeaderText = "Total";
            this.maintenaceTotalDataGridViewTextBoxColumn1.Name = "maintenaceTotalDataGridViewTextBoxColumn1";
            this.maintenaceTotalDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ApprovedBy
            // 
            this.ApprovedBy.DataPropertyName = "ApprovedBy";
            this.ApprovedBy.HeaderText = "Approver";
            this.ApprovedBy.Name = "ApprovedBy";
            this.ApprovedBy.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn1
            // 
            this.remarksDataGridViewTextBoxColumn1.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn1.Name = "remarksDataGridViewTextBoxColumn1";
            this.remarksDataGridViewTextBoxColumn1.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn1.Width = 300;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workOrderDetailsToolStripMenuItem,
            this.laborWorkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            // 
            // workOrderDetailsToolStripMenuItem
            // 
            this.workOrderDetailsToolStripMenuItem.Name = "workOrderDetailsToolStripMenuItem";
            this.workOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.workOrderDetailsToolStripMenuItem.Text = "Open Details";
            this.workOrderDetailsToolStripMenuItem.Click += new System.EventHandler(this.workOrderDetailsToolStripMenuItem_Click);
            // 
            // laborWorkToolStripMenuItem
            // 
            this.laborWorkToolStripMenuItem.Name = "laborWorkToolStripMenuItem";
            this.laborWorkToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.laborWorkToolStripMenuItem.Text = "Open Labor Assignments";
            this.laborWorkToolStripMenuItem.Click += new System.EventHandler(this.laborWorkToolStripMenuItem_Click);
            // 
            // maintenanceListBindingSource
            // 
            this.maintenanceListBindingSource.DataMember = "MaintenanceList";
            this.maintenanceListBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mmaintenanceBindingSource
            // 
            this.mmaintenanceBindingSource.DataMember = "m_maintenance";
            this.mmaintenanceBindingSource.DataSource = this.belayAbVMaintain;
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
            this.label1.Location = new System.Drawing.Point(19, 8);
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
            this.btnAllWorkOrders.Location = new System.Drawing.Point(902, 4);
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
            this.btnNew.Location = new System.Drawing.Point(991, 4);
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
            this.label5.Location = new System.Drawing.Point(263, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Find by>>";
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.Khaki;
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Location = new System.Drawing.Point(593, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(115, 13);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // rdWON
            // 
            this.rdWON.AutoSize = true;
            this.rdWON.Checked = true;
            this.rdWON.Location = new System.Drawing.Point(321, 1);
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
            this.rdPN.Location = new System.Drawing.Point(378, 1);
            this.rdPN.Name = "rdPN";
            this.rdPN.Size = new System.Drawing.Size(69, 17);
            this.rdPN.TabIndex = 9;
            this.rdPN.Text = "Plate No:";
            this.rdPN.UseVisualStyleBackColor = true;
            this.rdPN.CheckedChanged += new System.EventHandler(this.rdPN_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 258);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 430);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hystory";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAllVehicles);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grdVehicleList);
            this.groupBox1.Controls.Add(this.grdHistory);
            this.groupBox1.Controls.Add(this.lstOwners);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnAllVehicles
            // 
            this.btnAllVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllVehicles.Location = new System.Drawing.Point(546, 22);
            this.btnAllVehicles.Name = "btnAllVehicles";
            this.btnAllVehicles.Size = new System.Drawing.Size(85, 21);
            this.btnAllVehicles.TabIndex = 10;
            this.btnAllVehicles.Text = "Show All";
            this.btnAllVehicles.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Owner\'s Vehicles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vehicle\'s Maintenance History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Owners/Customers";
            // 
            // grdVehicleList
            // 
            this.grdVehicleList.AllowUserToAddRows = false;
            this.grdVehicleList.AllowUserToDeleteRows = false;
            this.grdVehicleList.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVehicleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdVehicleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehicleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlateNumberV,
            this.vehicleTypeDataGridViewTextBoxColumn,
            this.chasisNumberDataGridViewTextBoxColumn,
            this.engineNumberDataGridViewTextBoxColumn});
            this.grdVehicleList.DataSource = this.mVehiclesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVehicleList.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdVehicleList.Location = new System.Drawing.Point(225, 44);
            this.grdVehicleList.Name = "grdVehicleList";
            this.grdVehicleList.ReadOnly = true;
            this.grdVehicleList.Size = new System.Drawing.Size(510, 153);
            this.grdVehicleList.TabIndex = 6;
            this.grdVehicleList.SelectionChanged += new System.EventHandler(this.grdVehicleList_SelectionChanged);
            // 
            // PlateNumberV
            // 
            this.PlateNumberV.DataPropertyName = "Plate Number";
            this.PlateNumberV.HeaderText = "Plate Number";
            this.PlateNumberV.Name = "PlateNumberV";
            this.PlateNumberV.ReadOnly = true;
            // 
            // vehicleTypeDataGridViewTextBoxColumn
            // 
            this.vehicleTypeDataGridViewTextBoxColumn.DataPropertyName = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.HeaderText = "VehicleType";
            this.vehicleTypeDataGridViewTextBoxColumn.Name = "vehicleTypeDataGridViewTextBoxColumn";
            this.vehicleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chasisNumberDataGridViewTextBoxColumn
            // 
            this.chasisNumberDataGridViewTextBoxColumn.DataPropertyName = "Chasis Number";
            this.chasisNumberDataGridViewTextBoxColumn.HeaderText = "Chasis Number";
            this.chasisNumberDataGridViewTextBoxColumn.Name = "chasisNumberDataGridViewTextBoxColumn";
            this.chasisNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.chasisNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // engineNumberDataGridViewTextBoxColumn
            // 
            this.engineNumberDataGridViewTextBoxColumn.DataPropertyName = "EngineNumber";
            this.engineNumberDataGridViewTextBoxColumn.HeaderText = "EngineNumber";
            this.engineNumberDataGridViewTextBoxColumn.Name = "engineNumberDataGridViewTextBoxColumn";
            this.engineNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grdHistory
            // 
            this.grdHistory.AllowUserToAddRows = false;
            this.grdHistory.AllowUserToDeleteRows = false;
            this.grdHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdHistory.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkOrderNumber1,
            this.kMReadingDataGridViewTextBoxColumn,
            this.mReceivedDateDataGridViewTextBoxColumn,
            this.deiveryDateDataGridViewTextBoxColumn,
            this.maintenaceTotalDataGridViewTextBoxColumn,
            this.nextKilometerDataGridViewTextBoxColumn,
            this.isOutDataGridViewCheckBoxColumn,
            this.dataGridViewTextBoxColumn55});
            this.grdHistory.DataSource = this.m_maintenanceBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdHistory.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdHistory.Location = new System.Drawing.Point(224, 225);
            this.grdHistory.Name = "grdHistory";
            this.grdHistory.ReadOnly = true;
            this.grdHistory.Size = new System.Drawing.Size(648, 170);
            this.grdHistory.TabIndex = 5;
            this.grdHistory.DoubleClick += new System.EventHandler(this.grdHistory_DoubleClick);
            // 
            // WorkOrderNumber1
            // 
            this.WorkOrderNumber1.DataPropertyName = "WorkOrderNumber";
            this.WorkOrderNumber1.HeaderText = "W. O. No";
            this.WorkOrderNumber1.Name = "WorkOrderNumber1";
            this.WorkOrderNumber1.ReadOnly = true;
            // 
            // kMReadingDataGridViewTextBoxColumn
            // 
            this.kMReadingDataGridViewTextBoxColumn.DataPropertyName = "KM_Reading";
            this.kMReadingDataGridViewTextBoxColumn.HeaderText = "KM_Reading";
            this.kMReadingDataGridViewTextBoxColumn.Name = "kMReadingDataGridViewTextBoxColumn";
            this.kMReadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mReceivedDateDataGridViewTextBoxColumn
            // 
            this.mReceivedDateDataGridViewTextBoxColumn.DataPropertyName = "m_ReceivedDate";
            this.mReceivedDateDataGridViewTextBoxColumn.HeaderText = "Date In";
            this.mReceivedDateDataGridViewTextBoxColumn.Name = "mReceivedDateDataGridViewTextBoxColumn";
            this.mReceivedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deiveryDateDataGridViewTextBoxColumn
            // 
            this.deiveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeiveryDate";
            this.deiveryDateDataGridViewTextBoxColumn.HeaderText = "Date Out";
            this.deiveryDateDataGridViewTextBoxColumn.Name = "deiveryDateDataGridViewTextBoxColumn";
            this.deiveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maintenaceTotalDataGridViewTextBoxColumn
            // 
            this.maintenaceTotalDataGridViewTextBoxColumn.DataPropertyName = "Maintenace Total";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.maintenaceTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.maintenaceTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.maintenaceTotalDataGridViewTextBoxColumn.Name = "maintenaceTotalDataGridViewTextBoxColumn";
            this.maintenaceTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextKilometerDataGridViewTextBoxColumn
            // 
            this.nextKilometerDataGridViewTextBoxColumn.DataPropertyName = "Next Kilometer";
            this.nextKilometerDataGridViewTextBoxColumn.HeaderText = "Next Kilometer";
            this.nextKilometerDataGridViewTextBoxColumn.Name = "nextKilometerDataGridViewTextBoxColumn";
            this.nextKilometerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isOutDataGridViewCheckBoxColumn
            // 
            this.isOutDataGridViewCheckBoxColumn.DataPropertyName = "isOut";
            this.isOutDataGridViewCheckBoxColumn.HeaderText = "isOut";
            this.isOutDataGridViewCheckBoxColumn.Name = "isOutDataGridViewCheckBoxColumn";
            this.isOutDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn55.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            // 
            // m_maintenanceBindingSource
            // 
            this.m_maintenanceBindingSource.DataMember = "FK_m_maitanances_m_Vehicles";
            this.m_maintenanceBindingSource.DataSource = this.mVehiclesBindingSource;
            // 
            // lstOwners
            // 
            this.lstOwners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstOwners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstOwners.DataSource = this.customersBindingSource;
            this.lstOwners.DisplayMember = "CustomerName";
            this.lstOwners.FormattingEnabled = true;
            this.lstOwners.Location = new System.Drawing.Point(10, 29);
            this.lstOwners.Name = "lstOwners";
            this.lstOwners.Size = new System.Drawing.Size(211, 366);
            this.lstOwners.TabIndex = 4;
            this.lstOwners.ValueMember = "CustomerId";
            this.lstOwners.SelectedIndexChanged += new System.EventHandler(this.lstOwners_SelectedIndexChanged);
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
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle14.Format = "d";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle15.Format = "d";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Format = "d";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn33.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn33.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn34.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            dataGridViewCellStyle18.NullValue = "0";
            this.dataGridViewTextBoxColumn37.DefaultCellStyle = dataGridViewCellStyle18;
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
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            this.mReceivedDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            this.mReceivedDateDataGridViewTextBoxColumn1.HeaderText = "Date In";
            this.mReceivedDateDataGridViewTextBoxColumn1.Name = "mReceivedDateDataGridViewTextBoxColumn1";
            this.mReceivedDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // deiveryDateDataGridViewTextBoxColumn1
            // 
            this.deiveryDateDataGridViewTextBoxColumn1.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle20.Format = "d";
            dataGridViewCellStyle20.NullValue = null;
            this.deiveryDateDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "N2";
            dataGridViewCellStyle21.NullValue = "0";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column1.HeaderText = "Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "m_ReceivedDate";
            dataGridViewCellStyle22.Format = "d";
            dataGridViewCellStyle22.NullValue = null;
            this.DateIn.DefaultCellStyle = dataGridViewCellStyle22;
            this.DateIn.HeaderText = "Date In";
            this.DateIn.Name = "DateIn";
            this.DateIn.ReadOnly = true;
            // 
            // DateOut
            // 
            this.DateOut.DataPropertyName = "DeiveryDate";
            dataGridViewCellStyle23.Format = "d";
            this.DateOut.DefaultCellStyle = dataGridViewCellStyle23;
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
            this.bindingNavigator1.BindingSource = this.maintenanceListBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(733, 241);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(209, 25);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            // belayAbVMaintainBindingSource
            // 
            this.belayAbVMaintainBindingSource.DataSource = this.belayAbVMaintain;
            this.belayAbVMaintainBindingSource.Position = 0;
            // 
            // maintenanceListTableAdapter
            // 
            this.maintenanceListTableAdapter.ClearBeforeFill = true;
            // 
            // rdCusName
            // 
            this.rdCusName.AutoSize = true;
            this.rdCusName.Location = new System.Drawing.Point(454, 1);
            this.rdCusName.Name = "rdCusName";
            this.rdCusName.Size = new System.Drawing.Size(100, 17);
            this.rdCusName.TabIndex = 13;
            this.rdCusName.TabStop = true;
            this.rdCusName.Text = "Customer Name";
            this.rdCusName.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(777, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 21);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMaintenanceHomeCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 692);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rdCusName);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rdPN);
            this.Controls.Add(this.rdWON);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllWorkOrders);
            this.Controls.Add(this.grdRecentWos);
            this.Name = "frmMaintenanceHomeCS";
            this.Tag = "Manitenance Home CS";
            this.Text = "Maintenance Home";
            this.Load += new System.EventHandler(this.frmMaintenanceHome_Load);
            this.Resize += new System.EventHandler(this.frmMaintenanceHomeCS_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehicleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemsIssuedDetailsItemsIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsIssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKItemRequisionDetailsItemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbItemRequistions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintainBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.CustomersTableAdapter customersTableAdapter;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllVehicles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdVehicleList;
        private System.Windows.Forms.DataGridView grdHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn workOrderNumberH;
        private System.Windows.Forms.DataGridViewTextBoxColumn mReceivedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deiveryDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM_Reading;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextKilometerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.ListBox lstOwners;
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
        private System.Windows.Forms.BindingSource belayAbVMaintainBindingSource;
        private System.Windows.Forms.BindingSource maintenanceListBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.MaintenanceListTableAdapter maintenanceListTableAdapter;
        private System.Windows.Forms.BindingSource m_maintenanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrderNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kMReadingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mReceivedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deiveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenaceTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nextKilometerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.RadioButton rdCusName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workOrderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laborWorkToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumberV;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenaceTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnRefresh;
    }
}