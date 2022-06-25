namespace Belayab
{
    partial class frmItemCategory
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
            System.Windows.Forms.Label truckTypeLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemCategory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.measurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.measurmentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatTaxedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.locationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuShowAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItembindingNavigatorItem = new System.Windows.Forms.BindingNavigator(this.components);
            this.ItembindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.ItembindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.ItembindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ItembindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ItembindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.ItembindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.AddItem = new System.Windows.Forms.ToolStripButton();
            this.saveItemss = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCategories = new System.Windows.Forms.ToolStripButton();
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.lstCats = new System.Windows.Forms.ListBox();
            this.mainNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.categoriesbindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.categorybindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.categorybindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriesbindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.categorybindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.categorybindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.MainNavAddnew = new System.Windows.Forms.ToolStripButton();
            this.MainNavSave = new System.Windows.Forms.ToolStripButton();
            this.MainNavDelete = new System.Windows.Forms.ToolStripButton();
            this.MainNavPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPrintAllItems = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintCurrentCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrintCurrentVModel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.serviceTypeTextBox = new System.Windows.Forms.TextBox();
            this.truckTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.truckTypeComboBox = new System.Windows.Forms.ComboBox();
            this.btnNewTruck = new System.Windows.Forms.Button();
            this.lnkShowAll = new System.Windows.Forms.LinkLabel();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optOthers = new System.Windows.Forms.RadioButton();
            this.optMaintenance = new System.Windows.Forms.RadioButton();
            this.optVehicles = new System.Windows.Forms.RadioButton();
            this.optParts = new System.Windows.Forms.RadioButton();
            this.categoriesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoriesTableAdapter();
            this.itemsTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemsTableAdapter();
            this.locationViewTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.LocationViewTableAdapter();
            this.measurmentTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.MeasurmentTypesTableAdapter();
            this.categoryListTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoryListTableAdapter();
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.partNumDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partNumDescriptionTableAdapter = new Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkEditItems = new System.Windows.Forms.LinkLabel();
            truckTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.ItemDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingNavigatorItem)).BeginInit();
            this.ItembindingNavigatorItem.SuspendLayout();
            this.gbCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainNav)).BeginInit();
            this.mainNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // truckTypeLabel
            // 
            truckTypeLabel.AutoSize = true;
            truckTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            truckTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            truckTypeLabel.Location = new System.Drawing.Point(9, 9);
            truckTypeLabel.Name = "truckTypeLabel";
            truckTypeLabel.Size = new System.Drawing.Size(108, 16);
            truckTypeLabel.TabIndex = 30;
            truckTypeLabel.Text = "Main Category";
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AllowUserToAddRows = false;
            this.itemsDataGridView.AllowUserToDeleteRows = false;
            this.itemsDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.itemsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartNumber,
            this.Description,
            this.Category,
            this.measurementIdDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.orderLevelDataGridViewTextBoxColumn,
            this.vatTaxedDataGridViewCheckBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.itemsDataGridView.DataSource = this.itemsBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.itemsDataGridView.Location = new System.Drawing.Point(0, 3);
            this.itemsDataGridView.Name = "itemsDataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.itemsDataGridView.Size = new System.Drawing.Size(926, 332);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_RowEnter);
            this.itemsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.itemsDataGridView_RowValidating);
            this.itemsDataGridView.DoubleClick += new System.EventHandler(this.itemsDataGridView_DoubleClick);
            this.itemsDataGridView.Leave += new System.EventHandler(this.itemsDataGridView_Leave);
            this.itemsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.itemsDataGridView_CellValidating);
            this.itemsDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_RowValidated);
            this.itemsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.itemsDataGridView_DataError);
            this.itemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellContentClick);
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.HeaderText = "Part Number / Code";
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartNumber.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 280;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CategoryId";
            this.Category.DataSource = this.categoryListBindingSource;
            this.Category.DisplayMember = "CatDescription";
            this.Category.DisplayStyleForCurrentCellOnly = true;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Category.ValueMember = "CategoryId";
            this.Category.Visible = false;
            this.Category.Width = 150;
            // 
            // categoryListBindingSource
            // 
            this.categoryListBindingSource.DataMember = "CategoryList";
            this.categoryListBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measurementIdDataGridViewTextBoxColumn
            // 
            this.measurementIdDataGridViewTextBoxColumn.DataPropertyName = "MeasurementId";
            this.measurementIdDataGridViewTextBoxColumn.DataSource = this.measurmentTypesBindingSource;
            this.measurementIdDataGridViewTextBoxColumn.DisplayMember = "Description";
            this.measurementIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.measurementIdDataGridViewTextBoxColumn.HeaderText = "Units";
            this.measurementIdDataGridViewTextBoxColumn.Name = "measurementIdDataGridViewTextBoxColumn";
            this.measurementIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.measurementIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.measurementIdDataGridViewTextBoxColumn.ValueMember = "MeasurementId";
            // 
            // measurmentTypesBindingSource
            // 
            this.measurmentTypesBindingSource.DataMember = "MeasurmentTypes";
            this.measurmentTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // orderLevelDataGridViewTextBoxColumn
            // 
            this.orderLevelDataGridViewTextBoxColumn.DataPropertyName = "OrderLevel";
            this.orderLevelDataGridViewTextBoxColumn.HeaderText = "O. Level";
            this.orderLevelDataGridViewTextBoxColumn.Name = "orderLevelDataGridViewTextBoxColumn";
            this.orderLevelDataGridViewTextBoxColumn.Width = 70;
            // 
            // vatTaxedDataGridViewCheckBoxColumn
            // 
            this.vatTaxedDataGridViewCheckBoxColumn.DataPropertyName = "VatTaxed";
            this.vatTaxedDataGridViewCheckBoxColumn.HeaderText = "Taxed";
            this.vatTaxedDataGridViewCheckBoxColumn.Name = "vatTaxedDataGridViewCheckBoxColumn";
            this.vatTaxedDataGridViewCheckBoxColumn.Width = 60;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.DataSource = this.locationViewBindingSource;
            this.locationDataGridViewTextBoxColumn.DisplayMember = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.locationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.locationDataGridViewTextBoxColumn.ValueMember = "Location";
            this.locationDataGridViewTextBoxColumn.Width = 120;
            // 
            // locationViewBindingSource
            // 
            this.locationViewBindingSource.DataMember = "LocationView";
            this.locationViewBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "FK_Items_Categories";
            this.itemsBindingSource.DataSource = this.categoriesBindingSource;
            this.itemsBindingSource.PositionChanged += new System.EventHandler(this.itemsBindingSource_PositionChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            this.categoriesBindingSource.PositionChanged += new System.EventHandler(this.categoriesBindingSource_PositionChanged);
            // 
            // ItemDetail
            // 
            this.ItemDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowAllItems});
            this.ItemDetail.Name = "ItemDetail";
            this.ItemDetail.ShowCheckMargin = true;
            this.ItemDetail.Size = new System.Drawing.Size(217, 26);
            this.ItemDetail.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ItemDetail_ItemClicked);
            // 
            // mnuShowAllItems
            // 
            this.mnuShowAllItems.Name = "mnuShowAllItems";
            this.mnuShowAllItems.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuShowAllItems.Size = new System.Drawing.Size(216, 22);
            this.mnuShowAllItems.Text = "Show All Items";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemsDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 364);
            this.panel1.TabIndex = 2;
            // 
            // ItembindingNavigatorItem
            // 
            this.ItembindingNavigatorItem.AddNewItem = null;
            this.ItembindingNavigatorItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ItembindingNavigatorItem.BindingSource = this.itemsBindingSource;
            this.ItembindingNavigatorItem.CountItem = this.ItembindingNavigatorCountItem;
            this.ItembindingNavigatorItem.DeleteItem = null;
            this.ItembindingNavigatorItem.Dock = System.Windows.Forms.DockStyle.None;
            this.ItembindingNavigatorItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItembindingNavigatorItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItembindingNavigatorMoveFirstItem,
            this.ItembindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator3,
            this.ItembindingNavigatorPositionItem,
            this.ItembindingNavigatorCountItem,
            this.bindingNavigatorSeparator4,
            this.ItembindingNavigatorMoveNextItem,
            this.ItembindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator5,
            this.AddItem,
            this.saveItemss,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.DeleteItem,
            this.toolStripSeparator1,
            this.btnEditCategories});
            this.ItembindingNavigatorItem.Location = new System.Drawing.Point(12, 578);
            this.ItembindingNavigatorItem.MoveFirstItem = this.ItembindingNavigatorMoveFirstItem;
            this.ItembindingNavigatorItem.MoveLastItem = this.ItembindingNavigatorMoveLastItem;
            this.ItembindingNavigatorItem.MoveNextItem = this.ItembindingNavigatorMoveNextItem;
            this.ItembindingNavigatorItem.MovePreviousItem = this.ItembindingNavigatorMovePreviousItem;
            this.ItembindingNavigatorItem.Name = "ItembindingNavigatorItem";
            this.ItembindingNavigatorItem.PositionItem = this.ItembindingNavigatorPositionItem;
            this.ItembindingNavigatorItem.Size = new System.Drawing.Size(531, 25);
            this.ItembindingNavigatorItem.TabIndex = 2;
            this.ItembindingNavigatorItem.Text = "ItembindingNavigatorItem";
            // 
            // ItembindingNavigatorCountItem
            // 
            this.ItembindingNavigatorCountItem.Name = "ItembindingNavigatorCountItem";
            this.ItembindingNavigatorCountItem.Size = new System.Drawing.Size(47, 22);
            this.ItembindingNavigatorCountItem.Text = "of {0}";
            this.ItembindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // ItembindingNavigatorMoveFirstItem
            // 
            this.ItembindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItembindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("ItembindingNavigatorMoveFirstItem.Image")));
            this.ItembindingNavigatorMoveFirstItem.Name = "ItembindingNavigatorMoveFirstItem";
            this.ItembindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.ItembindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.ItembindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // ItembindingNavigatorMovePreviousItem
            // 
            this.ItembindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItembindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("ItembindingNavigatorMovePreviousItem.Image")));
            this.ItembindingNavigatorMovePreviousItem.Name = "ItembindingNavigatorMovePreviousItem";
            this.ItembindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.ItembindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.ItembindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ItembindingNavigatorPositionItem
            // 
            this.ItembindingNavigatorPositionItem.AccessibleName = "Position";
            this.ItembindingNavigatorPositionItem.AutoSize = false;
            this.ItembindingNavigatorPositionItem.Enabled = false;
            this.ItembindingNavigatorPositionItem.Name = "ItembindingNavigatorPositionItem";
            this.ItembindingNavigatorPositionItem.ReadOnly = true;
            this.ItembindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.ItembindingNavigatorPositionItem.Text = "0";
            this.ItembindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ItembindingNavigatorMoveNextItem
            // 
            this.ItembindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItembindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("ItembindingNavigatorMoveNextItem.Image")));
            this.ItembindingNavigatorMoveNextItem.Name = "ItembindingNavigatorMoveNextItem";
            this.ItembindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.ItembindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.ItembindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // ItembindingNavigatorMoveLastItem
            // 
            this.ItembindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItembindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("ItembindingNavigatorMoveLastItem.Image")));
            this.ItembindingNavigatorMoveLastItem.Name = "ItembindingNavigatorMoveLastItem";
            this.ItembindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.ItembindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.ItembindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // AddItem
            // 
            this.AddItem.Checked = true;
            this.AddItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddItem.Enabled = false;
            this.AddItem.Image = ((System.Drawing.Image)(resources.GetObject("AddItem.Image")));
            this.AddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(54, 22);
            this.AddItem.Text = "Add";
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // saveItemss
            // 
            this.saveItemss.Checked = true;
            this.saveItemss.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveItemss.Enabled = false;
            this.saveItemss.Image = ((System.Drawing.Image)(resources.GetObject("saveItemss.Image")));
            this.saveItemss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveItemss.Name = "saveItemss";
            this.saveItemss.Size = new System.Drawing.Size(60, 22);
            this.saveItemss.Text = "Save";
            this.saveItemss.Click += new System.EventHandler(this.saveItemss_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Checked = true;
            this.DeleteItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DeleteItem.Enabled = false;
            this.DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItem.Image")));
            this.DeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(70, 22);
            this.DeleteItem.Text = "Delete";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditCategories
            // 
            this.btnEditCategories.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategories.Image")));
            this.btnEditCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCategories.Name = "btnEditCategories";
            this.btnEditCategories.Size = new System.Drawing.Size(110, 22);
            this.btnEditCategories.Text = "Edit Categories";
            this.btnEditCategories.Click += new System.EventHandler(this.btnEditCategories_Click);
            // 
            // gbCategories
            // 
            this.gbCategories.BackColor = System.Drawing.Color.Silver;
            this.gbCategories.Controls.Add(this.lstCats);
            this.gbCategories.Controls.Add(this.mainNav);
            this.gbCategories.Controls.Add(this.txtDescription);
            this.gbCategories.Controls.Add(this.lblDescription);
            this.gbCategories.Controls.Add(this.txtCategoryName);
            this.gbCategories.Controls.Add(this.lblCategoryName);
            this.gbCategories.Controls.Add(this.txtCategoryId);
            this.gbCategories.Controls.Add(this.lblCategoryId);
            this.gbCategories.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategories.Location = new System.Drawing.Point(54, 42);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.Size = new System.Drawing.Size(668, 146);
            this.gbCategories.TabIndex = 3;
            this.gbCategories.TabStop = false;
            this.gbCategories.Text = "Sub Categgories";
            // 
            // lstCats
            // 
            this.lstCats.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstCats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCats.DisplayMember = "CategoryName";
            this.lstCats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCats.FormattingEnabled = true;
            this.lstCats.ItemHeight = 15;
            this.lstCats.Location = new System.Drawing.Point(12, 27);
            this.lstCats.Name = "lstCats";
            this.lstCats.Size = new System.Drawing.Size(217, 77);
            this.lstCats.TabIndex = 20;
            this.lstCats.ValueMember = "CategoryName";
            // 
            // mainNav
            // 
            this.mainNav.AddNewItem = null;
            this.mainNav.BackColor = System.Drawing.Color.PeachPuff;
            this.mainNav.BindingSource = this.categoriesBindingSource;
            this.mainNav.CountItem = this.categoriesbindingNavigatorCountItem;
            this.mainNav.DeleteItem = null;
            this.mainNav.Dock = System.Windows.Forms.DockStyle.None;
            this.mainNav.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorybindingNavigatorMoveFirstItem,
            this.categorybindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator6,
            this.categoriesbindingNavigatorPositionItem,
            this.categoriesbindingNavigatorCountItem,
            this.bindingNavigatorSeparator7,
            this.categorybindingNavigatorMoveNextItem,
            this.categorybindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator8,
            this.MainNavAddnew,
            this.MainNavSave,
            this.MainNavDelete,
            this.MainNavPrint});
            this.mainNav.Location = new System.Drawing.Point(12, 118);
            this.mainNav.MoveFirstItem = this.categorybindingNavigatorMoveFirstItem;
            this.mainNav.MoveLastItem = this.categorybindingNavigatorMoveLastItem;
            this.mainNav.MoveNextItem = this.categorybindingNavigatorMoveNextItem;
            this.mainNav.MovePreviousItem = this.categorybindingNavigatorMovePreviousItem;
            this.mainNav.Name = "mainNav";
            this.mainNav.PositionItem = this.categoriesbindingNavigatorPositionItem;
            this.mainNav.Size = new System.Drawing.Size(496, 25);
            this.mainNav.TabIndex = 19;
            this.mainNav.Text = "bindingNavigator1";
            // 
            // categoriesbindingNavigatorCountItem
            // 
            this.categoriesbindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesbindingNavigatorCountItem.Name = "categoriesbindingNavigatorCountItem";
            this.categoriesbindingNavigatorCountItem.Size = new System.Drawing.Size(42, 22);
            this.categoriesbindingNavigatorCountItem.Text = "of {0}";
            this.categoriesbindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // categorybindingNavigatorMoveFirstItem
            // 
            this.categorybindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorybindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("categorybindingNavigatorMoveFirstItem.Image")));
            this.categorybindingNavigatorMoveFirstItem.Name = "categorybindingNavigatorMoveFirstItem";
            this.categorybindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.categorybindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.categorybindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // categorybindingNavigatorMovePreviousItem
            // 
            this.categorybindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorybindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("categorybindingNavigatorMovePreviousItem.Image")));
            this.categorybindingNavigatorMovePreviousItem.Name = "categorybindingNavigatorMovePreviousItem";
            this.categorybindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.categorybindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.categorybindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriesbindingNavigatorPositionItem
            // 
            this.categoriesbindingNavigatorPositionItem.AccessibleName = "Position";
            this.categoriesbindingNavigatorPositionItem.AutoSize = false;
            this.categoriesbindingNavigatorPositionItem.Enabled = false;
            this.categoriesbindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesbindingNavigatorPositionItem.Name = "categoriesbindingNavigatorPositionItem";
            this.categoriesbindingNavigatorPositionItem.ReadOnly = true;
            this.categoriesbindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 22);
            this.categoriesbindingNavigatorPositionItem.Text = "0";
            this.categoriesbindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // categorybindingNavigatorMoveNextItem
            // 
            this.categorybindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorybindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("categorybindingNavigatorMoveNextItem.Image")));
            this.categorybindingNavigatorMoveNextItem.Name = "categorybindingNavigatorMoveNextItem";
            this.categorybindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.categorybindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.categorybindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // categorybindingNavigatorMoveLastItem
            // 
            this.categorybindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categorybindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("categorybindingNavigatorMoveLastItem.Image")));
            this.categorybindingNavigatorMoveLastItem.Name = "categorybindingNavigatorMoveLastItem";
            this.categorybindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.categorybindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.categorybindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // MainNavAddnew
            // 
            this.MainNavAddnew.Enabled = false;
            this.MainNavAddnew.Image = ((System.Drawing.Image)(resources.GetObject("MainNavAddnew.Image")));
            this.MainNavAddnew.Name = "MainNavAddnew";
            this.MainNavAddnew.RightToLeftAutoMirrorImage = true;
            this.MainNavAddnew.Size = new System.Drawing.Size(88, 22);
            this.MainNavAddnew.Text = "Add new";
            this.MainNavAddnew.Click += new System.EventHandler(this.categoriesbindingNavigatorAddNewItem_Click);
            // 
            // MainNavSave
            // 
            this.MainNavSave.Enabled = false;
            this.MainNavSave.Image = ((System.Drawing.Image)(resources.GetObject("MainNavSave.Image")));
            this.MainNavSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavSave.Name = "MainNavSave";
            this.MainNavSave.Size = new System.Drawing.Size(64, 22);
            this.MainNavSave.Text = "Save";
            this.MainNavSave.Click += new System.EventHandler(this.categoriesbindingNavigatorSaveItem_Click);
            // 
            // MainNavDelete
            // 
            this.MainNavDelete.Enabled = false;
            this.MainNavDelete.Image = ((System.Drawing.Image)(resources.GetObject("MainNavDelete.Image")));
            this.MainNavDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavDelete.Name = "MainNavDelete";
            this.MainNavDelete.Size = new System.Drawing.Size(75, 22);
            this.MainNavDelete.Text = "Delete";
            this.MainNavDelete.Click += new System.EventHandler(this.categoriesBindingNavigtorDeleteItem_Click);
            // 
            // MainNavPrint
            // 
            this.MainNavPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MainNavPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrintAllItems,
            this.btnPrintCurrentCategory,
            this.btnPrintCurrentVModel});
            this.MainNavPrint.Enabled = false;
            this.MainNavPrint.Image = ((System.Drawing.Image)(resources.GetObject("MainNavPrint.Image")));
            this.MainNavPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainNavPrint.Name = "MainNavPrint";
            this.MainNavPrint.Size = new System.Drawing.Size(55, 22);
            this.MainNavPrint.Text = "Print";
            // 
            // btnPrintAllItems
            // 
            this.btnPrintAllItems.Name = "btnPrintAllItems";
            this.btnPrintAllItems.Size = new System.Drawing.Size(252, 22);
            this.btnPrintAllItems.Text = "All Items";
            this.btnPrintAllItems.Click += new System.EventHandler(this.btnPrintAllItems_Click);
            // 
            // btnPrintCurrentCategory
            // 
            this.btnPrintCurrentCategory.Name = "btnPrintCurrentCategory";
            this.btnPrintCurrentCategory.Size = new System.Drawing.Size(254, 22);
            this.btnPrintCurrentCategory.Text = "Current Sub Category";
            this.btnPrintCurrentCategory.Click += new System.EventHandler(this.btnPrintCurrentCategory_Click);
            // 
            // btnPrintCurrentVModel
            // 
            this.btnPrintCurrentVModel.Name = "btnPrintCurrentVModel";
            this.btnPrintCurrentVModel.Size = new System.Drawing.Size(254, 22);
            this.btnPrintCurrentVModel.Text = "Currrent Main Category";
            this.btnPrintCurrentVModel.Click += new System.EventHandler(this.btnPrintCurrentVModel_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Description", true));
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(343, 75);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(318, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(255, 75);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryName", true));
            this.txtCategoryName.Enabled = false;
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.Location = new System.Drawing.Point(343, 50);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(250, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(232, 50);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(116, 16);
            this.lblCategoryName.TabIndex = 15;
            this.lblCategoryName.Text = "Category Name";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryId", true));
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryId.Location = new System.Drawing.Point(343, 25);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(134, 22);
            this.txtCategoryId.TabIndex = 0;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryId.Location = new System.Drawing.Point(255, 25);
            this.lblCategoryId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(88, 16);
            this.lblCategoryId.TabIndex = 13;
            this.lblCategoryId.Text = "Category Id";
            // 
            // serviceTypeTextBox
            // 
            this.serviceTypeTextBox.BackColor = System.Drawing.Color.Silver;
            this.serviceTypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "ServiceType", true));
            this.serviceTypeTextBox.ForeColor = System.Drawing.Color.Silver;
            this.serviceTypeTextBox.Location = new System.Drawing.Point(17, 171);
            this.serviceTypeTextBox.Name = "serviceTypeTextBox";
            this.serviceTypeTextBox.ReadOnly = true;
            this.serviceTypeTextBox.Size = new System.Drawing.Size(10, 13);
            this.serviceTypeTextBox.TabIndex = 22;
            // 
            // truckTypeIdTextBox
            // 
            this.truckTypeIdTextBox.BackColor = System.Drawing.Color.Silver;
            this.truckTypeIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.truckTypeIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "VehicleType", true));
            this.truckTypeIdTextBox.Enabled = false;
            this.truckTypeIdTextBox.ForeColor = System.Drawing.Color.Silver;
            this.truckTypeIdTextBox.Location = new System.Drawing.Point(-1, 153);
            this.truckTypeIdTextBox.Name = "truckTypeIdTextBox";
            this.truckTypeIdTextBox.Size = new System.Drawing.Size(28, 13);
            this.truckTypeIdTextBox.TabIndex = 21;
            this.truckTypeIdTextBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "tID";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(783, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item Picture";
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.Location = new System.Drawing.Point(874, 127);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(69, 25);
            this.btnChangePhoto.TabIndex = 2;
            this.btnChangePhoto.Text = "Change...";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // truckTypeComboBox
            // 
            this.truckTypeComboBox.DisplayMember = "MDescription";
            this.truckTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.truckTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.truckTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckTypeComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.truckTypeComboBox.FormattingEnabled = true;
            this.truckTypeComboBox.Location = new System.Drawing.Point(115, 5);
            this.truckTypeComboBox.Name = "truckTypeComboBox";
            this.truckTypeComboBox.Size = new System.Drawing.Size(296, 24);
            this.truckTypeComboBox.TabIndex = 0;
            this.truckTypeComboBox.ValueMember = "VehicleModel";
            this.truckTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.truckTypeComboBox_SelectedIndexChanged);
            // 
            // btnNewTruck
            // 
            this.btnNewTruck.Enabled = false;
            this.btnNewTruck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTruck.Location = new System.Drawing.Point(417, 6);
            this.btnNewTruck.Name = "btnNewTruck";
            this.btnNewTruck.Size = new System.Drawing.Size(70, 23);
            this.btnNewTruck.TabIndex = 1;
            this.btnNewTruck.Text = "Edit...";
            this.btnNewTruck.UseVisualStyleBackColor = true;
            this.btnNewTruck.Click += new System.EventHandler(this.btnNewTruck_Click);
            // 
            // lnkShowAll
            // 
            this.lnkShowAll.AutoSize = true;
            this.lnkShowAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkShowAll.Location = new System.Drawing.Point(772, 582);
            this.lnkShowAll.Name = "lnkShowAll";
            this.lnkShowAll.Size = new System.Drawing.Size(126, 17);
            this.lnkShowAll.TabIndex = 31;
            this.lnkShowAll.TabStop = true;
            this.lnkShowAll.Text = "Search for Itmems";
            this.lnkShowAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkShowAll_LinkClicked);
            // 
            // imgItem
            // 
            this.imgItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgItem.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgItem.InitialImage")));
            this.imgItem.Location = new System.Drawing.Point(770, 93);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(101, 99);
            this.imgItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgItem.TabIndex = 4;
            this.imgItem.TabStop = false;
            this.imgItem.DoubleClick += new System.EventHandler(this.imgItem_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.optAll);
            this.groupBox1.Controls.Add(this.optOthers);
            this.groupBox1.Controls.Add(this.optMaintenance);
            this.groupBox1.Controls.Add(this.optVehicles);
            this.groupBox1.Controls.Add(this.optParts);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(620, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 17);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Service Type";
            this.groupBox1.Visible = false;
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAll.Location = new System.Drawing.Point(285, 22);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(44, 22);
            this.optAll.TabIndex = 5;
            this.optAll.TabStop = true;
            this.optAll.Tag = "A";
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = true;
            this.optAll.CheckedChanged += new System.EventHandler(this.optAll_CheckedChanged);
            // 
            // optOthers
            // 
            this.optOthers.AutoSize = true;
            this.optOthers.Location = new System.Drawing.Point(458, 21);
            this.optOthers.Name = "optOthers";
            this.optOthers.Size = new System.Drawing.Size(71, 20);
            this.optOthers.TabIndex = 5;
            this.optOthers.TabStop = true;
            this.optOthers.Tag = "O";
            this.optOthers.Text = "Others";
            this.optOthers.UseVisualStyleBackColor = true;
            this.optOthers.UseWaitCursor = true;
            this.optOthers.CheckedChanged += new System.EventHandler(this.optOthers_CheckedChanged);
            // 
            // optMaintenance
            // 
            this.optMaintenance.AutoSize = true;
            this.optMaintenance.Location = new System.Drawing.Point(449, 22);
            this.optMaintenance.Name = "optMaintenance";
            this.optMaintenance.Size = new System.Drawing.Size(114, 20);
            this.optMaintenance.TabIndex = 5;
            this.optMaintenance.TabStop = true;
            this.optMaintenance.Tag = "M";
            this.optMaintenance.Text = "Maintenance";
            this.optMaintenance.UseVisualStyleBackColor = true;
            this.optMaintenance.UseWaitCursor = true;
            this.optMaintenance.CheckedChanged += new System.EventHandler(this.optMaintenance_CheckedChanged);
            // 
            // optVehicles
            // 
            this.optVehicles.AutoSize = true;
            this.optVehicles.Location = new System.Drawing.Point(148, 24);
            this.optVehicles.Name = "optVehicles";
            this.optVehicles.Size = new System.Drawing.Size(122, 20);
            this.optVehicles.TabIndex = 4;
            this.optVehicles.TabStop = true;
            this.optVehicles.Tag = "S";
            this.optVehicles.Text = "Vehicle Sales";
            this.optVehicles.UseVisualStyleBackColor = true;
            this.optVehicles.CheckedChanged += new System.EventHandler(this.optVehicles_CheckedChanged);
            // 
            // optParts
            // 
            this.optParts.AutoSize = true;
            this.optParts.Location = new System.Drawing.Point(27, 24);
            this.optParts.Name = "optParts";
            this.optParts.Size = new System.Drawing.Size(108, 20);
            this.optParts.TabIndex = 3;
            this.optParts.TabStop = true;
            this.optParts.Tag = "P";
            this.optParts.Text = "Spare Parts";
            this.optParts.UseVisualStyleBackColor = true;
            this.optParts.CheckedChanged += new System.EventHandler(this.optParts_CheckedChanged);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // locationViewTableAdapter
            // 
            this.locationViewTableAdapter.ClearBeforeFill = true;
            // 
            // measurmentTypesTableAdapter
            // 
            this.measurmentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // categoryListTableAdapter
            // 
            this.categoryListTableAdapter.ClearBeforeFill = true;
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partNumDescriptionBindingSource
            // 
            this.partNumDescriptionBindingSource.DataMember = "PartNumDescription";
            this.partNumDescriptionBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // partNumDescriptionTableAdapter
            // 
            this.partNumDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartNumber";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = "0";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn1.HeaderText = "PartNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = "0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderLevel";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderLevel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderLevel";
            this.dataGridViewTextBoxColumn5.HeaderText = "In Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderLevel";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order Level";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lnkEditItems
            // 
            this.lnkEditItems.AutoSize = true;
            this.lnkEditItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditItems.Location = new System.Drawing.Point(680, 582);
            this.lnkEditItems.Name = "lnkEditItems";
            this.lnkEditItems.Size = new System.Drawing.Size(73, 17);
            this.lnkEditItems.TabIndex = 33;
            this.lnkEditItems.TabStop = true;
            this.lnkEditItems.Text = "Edit Items";
            this.lnkEditItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditItems_LinkClicked);
            // 
            // frmItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(943, 635);
            this.Controls.Add(this.lnkEditItems);
            this.Controls.Add(this.serviceTypeTextBox);
            this.Controls.Add(this.truckTypeIdTextBox);
            this.Controls.Add(this.gbCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ItembindingNavigatorItem);
            this.Controls.Add(this.lnkShowAll);
            this.Controls.Add(this.truckTypeComboBox);
            this.Controls.Add(this.imgItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(truckTypeLabel);
            this.Controls.Add(this.btnNewTruck);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.label1);
            this.Name = "frmItemCategory";
            this.Text = "Categories and Item Registration";
            this.Load += new System.EventHandler(this.frmItemCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ItemDetail.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItembindingNavigatorItem)).EndInit();
            this.ItembindingNavigatorItem.ResumeLayout(false);
            this.ItembindingNavigatorItem.PerformLayout();
            this.gbCategories.ResumeLayout(false);
            this.gbCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainNav)).EndInit();
            this.mainNav.ResumeLayout(false);
            this.mainNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumDescriptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator ItembindingNavigatorItem;
        private System.Windows.Forms.ToolStripLabel ItembindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton ItembindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton ItembindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox ItembindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton ItembindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton ItembindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource locationViewBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.LocationViewTableAdapter locationViewTableAdapter;
        private System.Windows.Forms.BindingSource measurmentTypesBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.MeasurmentTypesTableAdapter measurmentTypesTableAdapter;
        private System.Windows.Forms.ToolStripButton AddItem;
        private System.Windows.Forms.ToolStripButton DeleteItem;
        private System.Windows.Forms.ToolStripButton saveItemss;
        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.BindingNavigator mainNav;
        private System.Windows.Forms.ToolStripButton MainNavAddnew;
        private System.Windows.Forms.ToolStripLabel categoriesbindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton categorybindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton categorybindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox categoriesbindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton categorybindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton categorybindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.ToolStripButton MainNavDelete;
        private System.Windows.Forms.ToolStripButton MainNavSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox imgItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.Button btnChangePhoto;
       private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox truckTypeIdTextBox;
        private System.Windows.Forms.Button btnNewTruck;
        public System.Windows.Forms.ComboBox truckTypeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ContextMenuStrip ItemDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuShowAllItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource categoryListBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoryListTableAdapter categoryListTableAdapter;
        private System.Windows.Forms.LinkLabel lnkShowAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optVehicles;
        private System.Windows.Forms.RadioButton optParts;
        private System.Windows.Forms.RadioButton optOthers;
        private System.Windows.Forms.TextBox serviceTypeTextBox;
        private System.Windows.Forms.RadioButton optAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditCategories;
        private System.Windows.Forms.RadioButton optMaintenance;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource partNumDescriptionBindingSource;
        private Belayab.BelayAbSSDataSetTableAdapters.PartNumDescriptionTableAdapter partNumDescriptionTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListBox lstCats;
        private System.Windows.Forms.ToolStripDropDownButton MainNavPrint;
        private System.Windows.Forms.ToolStripMenuItem btnPrintAllItems;
        private System.Windows.Forms.ToolStripMenuItem btnPrintCurrentCategory;
        private System.Windows.Forms.ToolStripMenuItem btnPrintCurrentVModel;
        private System.Windows.Forms.LinkLabel lnkEditItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.DataGridViewComboBoxColumn measurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vatTaxedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn locationDataGridViewTextBoxColumn;
    }
}