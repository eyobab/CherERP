namespace Belayab
{
    partial class frmItemEdit
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
            System.Windows.Forms.Label partNumberLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label measurementIdLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label orderLevelLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label vatTaxedLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label itemTypeIDLabel;
            System.Windows.Forms.Label vehicleTypeIDLabel;
            System.Windows.Forms.Label itemPurchaseTypeLabel;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemEdit));
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemsTableAdapter();
            this.bNavItems = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.categoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.categoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.locationViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.measurementIdComboBox = new System.Windows.Forms.ComboBox();
            this.measurmentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measurmentUnitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSet = new Belayab.BelayAbSSDataSet();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderLevelTextBox = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditImage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteImage = new System.Windows.Forms.ToolStripMenuItem();
            this.vatTaxedCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemPurchaseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.itemPurchaseTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditVehiceTypes = new System.Windows.Forms.Button();
            this.btnEdiItemTypes = new System.Windows.Forms.Button();
            this.vehicleTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.mVehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditCats = new System.Windows.Forms.Button();
            this.categoryListTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoryListTableAdapter();
            this.locationViewTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.LocationViewTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdNew = new System.Windows.Forms.LinkLabel();
            this.btnReceive = new System.Windows.Forms.Button();
            this.cboReceivedNo = new System.Windows.Forms.ComboBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSItemDetails = new System.Windows.Forms.ToolStripButton();
            this.btnBrowseItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAllItems = new System.Windows.Forms.ToolStripButton();
            this.grdItemList = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.vatTaxedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtYearBegining = new System.Windows.Forms.TextBox();
            this.lnkItemBalances = new System.Windows.Forms.LinkLabel();
            this.lnkHistory = new System.Windows.Forms.LinkLabel();
            this.lnkSetBeginning = new System.Windows.Forms.LinkLabel();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.itemIDTextBox = new System.Windows.Forms.TextBox();
            this.itemTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemTypesTableAdapter();
            this.m_VehicleTypeTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter();
            this.measurmentTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.MeasurmentTypesTableAdapter();
            this.itemPurchaseTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPurchaseTypesTableAdapter();
            partNumberLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            measurementIdLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            orderLevelLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            vatTaxedLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            itemIDLabel = new System.Windows.Forms.Label();
            itemTypeIDLabel = new System.Windows.Forms.Label();
            vehicleTypeIDLabel = new System.Windows.Forms.Label();
            itemPurchaseTypeLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavItems)).BeginInit();
            this.bNavItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentUnitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPurchaseTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            partNumberLabel.Location = new System.Drawing.Point(660, 50);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new System.Drawing.Size(77, 15);
            partNumberLabel.TabIndex = 1;
            partNumberLabel.Text = "Part Number";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryIdLabel.Location = new System.Drawing.Point(18, 28);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(95, 15);
            categoryIdLabel.TabIndex = 3;
            categoryIdLabel.Text = "Category Name:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel.Location = new System.Drawing.Point(51, 57);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(57, 15);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(397, 78);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(72, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // measurementIdLabel
            // 
            measurementIdLabel.AutoSize = true;
            measurementIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            measurementIdLabel.Location = new System.Drawing.Point(437, 104);
            measurementIdLabel.Name = "measurementIdLabel";
            measurementIdLabel.Size = new System.Drawing.Size(32, 15);
            measurementIdLabel.TabIndex = 9;
            measurementIdLabel.Text = "Unit:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unitPriceLabel.Location = new System.Drawing.Point(406, 137);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(63, 15);
            unitPriceLabel.TabIndex = 11;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // orderLevelLabel
            // 
            orderLevelLabel.AutoSize = true;
            orderLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderLevelLabel.Location = new System.Drawing.Point(415, 163);
            orderLevelLabel.Name = "orderLevelLabel";
            orderLevelLabel.Size = new System.Drawing.Size(54, 15);
            orderLevelLabel.TabIndex = 13;
            orderLevelLabel.Text = "O. Level:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pictureLabel.Location = new System.Drawing.Point(864, 77);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(52, 16);
            pictureLabel.TabIndex = 15;
            pictureLabel.Text = "Picture:";
            pictureLabel.Visible = false;
            // 
            // vatTaxedLabel
            // 
            vatTaxedLabel.AutoSize = true;
            vatTaxedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vatTaxedLabel.Location = new System.Drawing.Point(425, 189);
            vatTaxedLabel.Name = "vatTaxedLabel";
            vatTaxedLabel.Size = new System.Drawing.Size(44, 15);
            vatTaxedLabel.TabIndex = 17;
            vatTaxedLabel.Text = "Taxed:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(224, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 15);
            label1.TabIndex = 19;
            label1.Text = "Unit Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(229, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 17;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(6, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 15;
            label3.Text = "Receved No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(17, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 15);
            label4.TabIndex = 25;
            label4.Text = "In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(290, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 15);
            label5.TabIndex = 25;
            label5.Text = "Unit Price";
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(422, 53);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(44, 13);
            itemIDLabel.TabIndex = 23;
            itemIDLabel.Text = "Item ID:";
            // 
            // itemTypeIDLabel
            // 
            itemTypeIDLabel.AutoSize = true;
            itemTypeIDLabel.Location = new System.Drawing.Point(361, 28);
            itemTypeIDLabel.Name = "itemTypeIDLabel";
            itemTypeIDLabel.Size = new System.Drawing.Size(63, 15);
            itemTypeIDLabel.TabIndex = 7;
            itemTypeIDLabel.Text = "Item Type:";
            // 
            // vehicleTypeIDLabel
            // 
            vehicleTypeIDLabel.AutoSize = true;
            vehicleTypeIDLabel.Location = new System.Drawing.Point(344, 62);
            vehicleTypeIDLabel.Name = "vehicleTypeIDLabel";
            vehicleTypeIDLabel.Size = new System.Drawing.Size(79, 15);
            vehicleTypeIDLabel.TabIndex = 8;
            vehicleTypeIDLabel.Text = "Vehicle Type:";
            // 
            // itemPurchaseTypeLabel
            // 
            itemPurchaseTypeLabel.AutoSize = true;
            itemPurchaseTypeLabel.Location = new System.Drawing.Point(10, 86);
            itemPurchaseTypeLabel.Name = "itemPurchaseTypeLabel";
            itemPurchaseTypeLabel.Size = new System.Drawing.Size(118, 15);
            itemPurchaseTypeLabel.TabIndex = 11;
            itemPurchaseTypeLabel.Text = "Item Purchase Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(17, 55);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 15);
            label6.TabIndex = 29;
            label6.Text = "Year Begin:";
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            this.itemsBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.itemsBindingSource_ListChanged);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // bNavItems
            // 
            this.bNavItems.AddNewItem = null;
            this.bNavItems.BindingSource = this.itemsBindingSource;
            this.bNavItems.CountItem = this.bindingNavigatorCountItem;
            this.bNavItems.DeleteItem = null;
            this.bNavItems.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bNavItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemsBindingNavigatorSaveItem,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtFind});
            this.bNavItems.Location = new System.Drawing.Point(0, 0);
            this.bNavItems.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNavItems.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNavItems.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNavItems.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNavItems.Name = "bNavItems";
            this.bNavItems.PositionItem = this.bindingNavigatorPositionItem;
            this.bNavItems.Size = new System.Drawing.Size(1097, 27);
            this.bNavItems.TabIndex = 0;
            this.bNavItems.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Checked = true;
            this.bindingNavigatorAddNewItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(78, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // itemsBindingNavigatorSaveItem
            // 
            this.itemsBindingNavigatorSaveItem.Checked = true;
            this.itemsBindingNavigatorSaveItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsBindingNavigatorSaveItem.Image")));
            this.itemsBindingNavigatorSaveItem.Name = "itemsBindingNavigatorSaveItem";
            this.itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(82, 24);
            this.itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(10, 24);
            this.toolStripLabel2.Text = " ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnDelete
            // 
            this.btnDelete.Checked = true;
            this.btnDelete.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(64, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(49, 24);
            this.toolStripLabel1.Text = "Find >>";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // txtFind
            // 
            this.txtFind.AutoToolTip = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(200, 27);
            this.txtFind.ToolTipText = "Type part of Description or Part Number";
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "PartNumber", true));
            this.partNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberTextBox.Location = new System.Drawing.Point(740, 48);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(201, 21);
            this.partNumberTextBox.TabIndex = 2;
            // 
            // categoryIdComboBox
            // 
            this.categoryIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "CategoryId", true));
            this.categoryIdComboBox.DataSource = this.categoryListBindingSource;
            this.categoryIdComboBox.DisplayMember = "CategoryName";
            this.categoryIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIdComboBox.FormattingEnabled = true;
            this.categoryIdComboBox.Location = new System.Drawing.Point(116, 25);
            this.categoryIdComboBox.Name = "categoryIdComboBox";
            this.categoryIdComboBox.Size = new System.Drawing.Size(170, 23);
            this.categoryIdComboBox.TabIndex = 4;
            this.categoryIdComboBox.ValueMember = "CategoryId";
            // 
            // categoryListBindingSource
            // 
            this.categoryListBindingSource.DataMember = "CategoryList";
            this.categoryListBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Location", true));
            this.locationComboBox.DataSource = this.locationViewBindingSource;
            this.locationComboBox.DisplayMember = "Location";
            this.locationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(116, 54);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(170, 23);
            this.locationComboBox.TabIndex = 6;
            this.locationComboBox.ValueMember = "Location";
            // 
            // locationViewBindingSource
            // 
            this.locationViewBindingSource.DataMember = "LocationView";
            this.locationViewBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(470, 75);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(250, 21);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // measurementIdComboBox
            // 
            this.measurementIdComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.measurementIdComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.measurementIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "MeasurementId", true));
            this.measurementIdComboBox.DataSource = this.measurmentTypesBindingSource;
            this.measurementIdComboBox.DisplayMember = "Description";
            this.measurementIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measurementIdComboBox.FormattingEnabled = true;
            this.measurementIdComboBox.Location = new System.Drawing.Point(470, 101);
            this.measurementIdComboBox.Name = "measurementIdComboBox";
            this.measurementIdComboBox.Size = new System.Drawing.Size(121, 23);
            this.measurementIdComboBox.TabIndex = 10;
            this.measurementIdComboBox.ValueMember = "MeasurementId";
            // 
            // measurmentTypesBindingSource
            // 
            this.measurmentTypesBindingSource.DataMember = "MeasurmentTypes";
            this.measurmentTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // measurmentUnitsBindingSource
            // 
            this.measurmentUnitsBindingSource.DataMember = "MeasurmentUnits";
            this.measurmentUnitsBindingSource.DataSource = this.belayAbSSDataSet;
            // 
            // belayAbSSDataSet
            // 
            this.belayAbSSDataSet.DataSetName = "BelayAbSSDataSet";
            this.belayAbSSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceTextBox.Location = new System.Drawing.Point(470, 134);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(179, 21);
            this.unitPriceTextBox.TabIndex = 12;
            // 
            // orderLevelTextBox
            // 
            this.orderLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "OrderLevel", true));
            this.orderLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLevelTextBox.Location = new System.Drawing.Point(470, 160);
            this.orderLevelTextBox.Name = "orderLevelTextBox";
            this.orderLevelTextBox.Size = new System.Drawing.Size(121, 21);
            this.orderLevelTextBox.TabIndex = 14;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImage.ContextMenuStrip = this.contextMenuStrip1;
            this.picImage.Location = new System.Drawing.Point(837, 99);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(132, 113);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 16;
            this.picImage.TabStop = false;
            this.picImage.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditImage,
            this.mnuDeleteImage});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // mnuEditImage
            // 
            this.mnuEditImage.Name = "mnuEditImage";
            this.mnuEditImage.Size = new System.Drawing.Size(107, 22);
            this.mnuEditImage.Text = "Edit";
            this.mnuEditImage.Click += new System.EventHandler(this.mnuEditImage_Click);
            // 
            // mnuDeleteImage
            // 
            this.mnuDeleteImage.Name = "mnuDeleteImage";
            this.mnuDeleteImage.Size = new System.Drawing.Size(107, 22);
            this.mnuDeleteImage.Text = "Delete";
            this.mnuDeleteImage.Click += new System.EventHandler(this.mnuDeleteImage_Click);
            // 
            // vatTaxedCheckBox
            // 
            this.vatTaxedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.itemsBindingSource, "VatTaxed", true));
            this.vatTaxedCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vatTaxedCheckBox.Location = new System.Drawing.Point(470, 187);
            this.vatTaxedCheckBox.Name = "vatTaxedCheckBox";
            this.vatTaxedCheckBox.Size = new System.Drawing.Size(121, 24);
            this.vatTaxedCheckBox.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(itemPurchaseTypeLabel);
            this.groupBox1.Controls.Add(this.itemPurchaseTypeComboBox);
            this.groupBox1.Controls.Add(this.btnEditVehiceTypes);
            this.groupBox1.Controls.Add(this.btnEdiItemTypes);
            this.groupBox1.Controls.Add(vehicleTypeIDLabel);
            this.groupBox1.Controls.Add(this.vehicleTypeIDComboBox);
            this.groupBox1.Controls.Add(itemTypeIDLabel);
            this.groupBox1.Controls.Add(this.itemTypeIDComboBox);
            this.groupBox1.Controls.Add(this.btnEditCats);
            this.groupBox1.Controls.Add(categoryIdLabel);
            this.groupBox1.Controls.Add(this.categoryIdComboBox);
            this.groupBox1.Controls.Add(locationLabel);
            this.groupBox1.Controls.Add(this.locationComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(373, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 128);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Group:";
            // 
            // itemPurchaseTypeComboBox
            // 
            this.itemPurchaseTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemPurchaseType", true));
            this.itemPurchaseTypeComboBox.DataSource = this.itemPurchaseTypesBindingSource;
            this.itemPurchaseTypeComboBox.DisplayMember = "ItemPurchaseTypeDescription";
            this.itemPurchaseTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPurchaseTypeComboBox.ForeColor = System.Drawing.Color.Red;
            this.itemPurchaseTypeComboBox.FormattingEnabled = true;
            this.itemPurchaseTypeComboBox.Location = new System.Drawing.Point(132, 83);
            this.itemPurchaseTypeComboBox.Name = "itemPurchaseTypeComboBox";
            this.itemPurchaseTypeComboBox.Size = new System.Drawing.Size(153, 23);
            this.itemPurchaseTypeComboBox.TabIndex = 12;
            this.itemPurchaseTypeComboBox.ValueMember = "ItemPuchaseTypeID";
            // 
            // itemPurchaseTypesBindingSource
            // 
            this.itemPurchaseTypesBindingSource.DataMember = "ItemPurchaseTypes";
            this.itemPurchaseTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // btnEditVehiceTypes
            // 
            this.btnEditVehiceTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditVehiceTypes.Location = new System.Drawing.Point(647, 59);
            this.btnEditVehiceTypes.Name = "btnEditVehiceTypes";
            this.btnEditVehiceTypes.Size = new System.Drawing.Size(26, 23);
            this.btnEditVehiceTypes.TabIndex = 11;
            this.btnEditVehiceTypes.Tag = "Categoires";
            this.btnEditVehiceTypes.Text = "...";
            this.btnEditVehiceTypes.UseVisualStyleBackColor = true;
            this.btnEditVehiceTypes.Click += new System.EventHandler(this.btnEditVehiceTypes_Click);
            // 
            // btnEdiItemTypes
            // 
            this.btnEdiItemTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdiItemTypes.Location = new System.Drawing.Point(647, 26);
            this.btnEdiItemTypes.Name = "btnEdiItemTypes";
            this.btnEdiItemTypes.Size = new System.Drawing.Size(26, 23);
            this.btnEdiItemTypes.TabIndex = 10;
            this.btnEdiItemTypes.Tag = "Categoires";
            this.btnEdiItemTypes.Text = "...";
            this.btnEdiItemTypes.UseVisualStyleBackColor = true;
            this.btnEdiItemTypes.Click += new System.EventHandler(this.btnEdiItemTypes_Click);
            // 
            // vehicleTypeIDComboBox
            // 
            this.vehicleTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "VehicleTypeID", true));
            this.vehicleTypeIDComboBox.DataSource = this.mVehicleTypeBindingSource;
            this.vehicleTypeIDComboBox.DisplayMember = "Description";
            this.vehicleTypeIDComboBox.FormattingEnabled = true;
            this.vehicleTypeIDComboBox.Location = new System.Drawing.Point(428, 59);
            this.vehicleTypeIDComboBox.Name = "vehicleTypeIDComboBox";
            this.vehicleTypeIDComboBox.Size = new System.Drawing.Size(216, 23);
            this.vehicleTypeIDComboBox.TabIndex = 9;
            this.vehicleTypeIDComboBox.ValueMember = "Vehicletype";
            // 
            // mVehicleTypeBindingSource
            // 
            this.mVehicleTypeBindingSource.DataMember = "m_VehicleType";
            this.mVehicleTypeBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // itemTypeIDComboBox
            // 
            this.itemTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itemsBindingSource, "ItemTypeID", true));
            this.itemTypeIDComboBox.DataSource = this.itemTypesBindingSource;
            this.itemTypeIDComboBox.DisplayMember = "ItemTypeDescreption";
            this.itemTypeIDComboBox.FormattingEnabled = true;
            this.itemTypeIDComboBox.Location = new System.Drawing.Point(428, 25);
            this.itemTypeIDComboBox.Name = "itemTypeIDComboBox";
            this.itemTypeIDComboBox.Size = new System.Drawing.Size(216, 23);
            this.itemTypeIDComboBox.TabIndex = 8;
            this.itemTypeIDComboBox.ValueMember = "ItemTypeID";
            // 
            // itemTypesBindingSource
            // 
            this.itemTypesBindingSource.DataMember = "ItemTypes";
            this.itemTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // btnEditCats
            // 
            this.btnEditCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCats.Location = new System.Drawing.Point(292, 26);
            this.btnEditCats.Name = "btnEditCats";
            this.btnEditCats.Size = new System.Drawing.Size(26, 23);
            this.btnEditCats.TabIndex = 7;
            this.btnEditCats.Tag = "Categoires";
            this.btnEditCats.Text = "...";
            this.btnEditCats.UseVisualStyleBackColor = true;
            this.btnEditCats.Click += new System.EventHandler(this.btnEditCats_Click);
            // 
            // categoryListTableAdapter
            // 
            this.categoryListTableAdapter.ClearBeforeFill = true;
            // 
            // locationViewTableAdapter
            // 
            this.locationViewTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdNew);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.cboReceivedNo);
            this.groupBox2.Controls.Add(this.txtUnitCost);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(373, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 72);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive Item";
            // 
            // cmdNew
            // 
            this.cmdNew.AutoSize = true;
            this.cmdNew.Location = new System.Drawing.Point(80, 48);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(38, 13);
            this.cmdNew.TabIndex = 23;
            this.cmdNew.TabStop = true;
            this.cmdNew.Text = "New...";
            this.cmdNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cmdNew_LinkClicked);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(390, 13);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(81, 27);
            this.btnReceive.TabIndex = 21;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // cboReceivedNo
            // 
            this.cboReceivedNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboReceivedNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboReceivedNo.DisplayMember = "Description";
            this.cboReceivedNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReceivedNo.FormattingEnabled = true;
            this.cboReceivedNo.Location = new System.Drawing.Point(83, 22);
            this.cboReceivedNo.Name = "cboReceivedNo";
            this.cboReceivedNo.Size = new System.Drawing.Size(135, 23);
            this.cboReceivedNo.TabIndex = 16;
            this.cboReceivedNo.ValueMember = "MeasurementId";
            this.cboReceivedNo.SelectedIndexChanged += new System.EventHandler(this.cboReceivedNo_SelectedIndexChanged);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(286, 46);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(136, 21);
            this.txtUnitCost.TabIndex = 20;
            this.txtUnitCost.TextChanged += new System.EventHandler(this.txtUnitCost_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(286, 19);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(75, 21);
            this.txtQty.TabIndex = 18;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.Color.Blue;
            this.lblDone.Location = new System.Drawing.Point(864, 456);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(28, 13);
            this.lblDone.TabIndex = 22;
            this.lblDone.Text = "       ";
            // 
            // openDlg
            // 
            this.openDlg.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSItemDetails,
            this.btnBrowseItems,
            this.toolStripSeparator3,
            this.btnAllItems});
            this.toolStrip1.Location = new System.Drawing.Point(0, 525);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1097, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSItemDetails
            // 
            this.btnSItemDetails.Checked = true;
            this.btnSItemDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnSItemDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSItemDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnSItemDetails.Image")));
            this.btnSItemDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSItemDetails.Name = "btnSItemDetails";
            this.btnSItemDetails.Size = new System.Drawing.Size(103, 22);
            this.btnSItemDetails.Text = "Item Transactions";
            this.btnSItemDetails.Click += new System.EventHandler(this.btnSItemDetails_Click);
            // 
            // btnBrowseItems
            // 
            this.btnBrowseItems.Checked = true;
            this.btnBrowseItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnBrowseItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBrowseItems.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseItems.Image")));
            this.btnBrowseItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBrowseItems.Name = "btnBrowseItems";
            this.btnBrowseItems.Size = new System.Drawing.Size(67, 22);
            this.btnBrowseItems.Text = "Categories";
            this.btnBrowseItems.Click += new System.EventHandler(this.btnBrowseItems_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAllItems
            // 
            this.btnAllItems.Checked = true;
            this.btnAllItems.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAllItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAllItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAllItems.Image")));
            this.btnAllItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(102, 22);
            this.btnAllItems.Text = "Advanced Search";
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
            // 
            // grdItemList
            // 
            this.grdItemList.AllowUserToAddRows = false;
            this.grdItemList.AllowUserToDeleteRows = false;
            this.grdItemList.AutoGenerateColumns = false;
            this.grdItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.partNumberDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.measurementIdDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.orderLevelDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.vatTaxedDataGridViewCheckBoxColumn});
            this.grdItemList.DataSource = this.itemsBindingSource;
            this.grdItemList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grdItemList.Location = new System.Drawing.Point(0, 27);
            this.grdItemList.Name = "grdItemList";
            this.grdItemList.ReadOnly = true;
            this.grdItemList.RowHeadersWidth = 10;
            this.grdItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItemList.Size = new System.Drawing.Size(351, 498);
            this.grdItemList.TabIndex = 22;
            this.grdItemList.SelectionChanged += new System.EventHandler(this.grdItemList_SelectionChanged);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // partNumberDataGridViewTextBoxColumn
            // 
            this.partNumberDataGridViewTextBoxColumn.DataPropertyName = "PartNumber";
            this.partNumberDataGridViewTextBoxColumn.HeaderText = "Part Number";
            this.partNumberDataGridViewTextBoxColumn.Name = "partNumberDataGridViewTextBoxColumn";
            this.partNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // measurementIdDataGridViewTextBoxColumn
            // 
            this.measurementIdDataGridViewTextBoxColumn.DataPropertyName = "MeasurementId";
            this.measurementIdDataGridViewTextBoxColumn.HeaderText = "MeasurementId";
            this.measurementIdDataGridViewTextBoxColumn.Name = "measurementIdDataGridViewTextBoxColumn";
            this.measurementIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.measurementIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderLevelDataGridViewTextBoxColumn
            // 
            this.orderLevelDataGridViewTextBoxColumn.DataPropertyName = "OrderLevel";
            this.orderLevelDataGridViewTextBoxColumn.HeaderText = "OrderLevel";
            this.orderLevelDataGridViewTextBoxColumn.Name = "orderLevelDataGridViewTextBoxColumn";
            this.orderLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderLevelDataGridViewTextBoxColumn.Visible = false;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.ReadOnly = true;
            this.pictureDataGridViewImageColumn.Visible = false;
            // 
            // vatTaxedDataGridViewCheckBoxColumn
            // 
            this.vatTaxedDataGridViewCheckBoxColumn.DataPropertyName = "VatTaxed";
            this.vatTaxedDataGridViewCheckBoxColumn.HeaderText = "VatTaxed";
            this.vatTaxedDataGridViewCheckBoxColumn.Name = "vatTaxedDataGridViewCheckBoxColumn";
            this.vatTaxedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.vatTaxedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "PartNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label6);
            this.groupBox3.Controls.Add(this.txtYearBegining);
            this.groupBox3.Controls.Add(this.lnkItemBalances);
            this.groupBox3.Controls.Add(this.lnkHistory);
            this.groupBox3.Controls.Add(this.lnkSetBeginning);
            this.groupBox3.Controls.Add(label5);
            this.groupBox3.Controls.Add(this.txtUnitPrice);
            this.groupBox3.Controls.Add(label4);
            this.groupBox3.Controls.Add(this.txtInStock);
            this.groupBox3.Location = new System.Drawing.Point(373, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(673, 80);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Latest Values";
            // 
            // txtYearBegining
            // 
            this.txtYearBegining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearBegining.Location = new System.Drawing.Point(88, 52);
            this.txtYearBegining.Name = "txtYearBegining";
            this.txtYearBegining.ReadOnly = true;
            this.txtYearBegining.Size = new System.Drawing.Size(111, 22);
            this.txtYearBegining.TabIndex = 30;
            this.txtYearBegining.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lnkItemBalances
            // 
            this.lnkItemBalances.AutoSize = true;
            this.lnkItemBalances.Location = new System.Drawing.Point(204, 20);
            this.lnkItemBalances.Name = "lnkItemBalances";
            this.lnkItemBalances.Size = new System.Drawing.Size(39, 13);
            this.lnkItemBalances.TabIndex = 28;
            this.lnkItemBalances.TabStop = true;
            this.lnkItemBalances.Text = "Details";
            this.lnkItemBalances.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkItemBalances_LinkClicked);
            // 
            // lnkHistory
            // 
            this.lnkHistory.AutoSize = true;
            this.lnkHistory.Location = new System.Drawing.Point(423, 38);
            this.lnkHistory.Name = "lnkHistory";
            this.lnkHistory.Size = new System.Drawing.Size(48, 13);
            this.lnkHistory.TabIndex = 27;
            this.lnkHistory.TabStop = true;
            this.lnkHistory.Text = "History...";
            this.lnkHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHistory_LinkClicked);
            // 
            // lnkSetBeginning
            // 
            this.lnkSetBeginning.AutoSize = true;
            this.lnkSetBeginning.Location = new System.Drawing.Point(204, 54);
            this.lnkSetBeginning.Name = "lnkSetBeginning";
            this.lnkSetBeginning.Size = new System.Drawing.Size(32, 13);
            this.lnkSetBeginning.TabIndex = 24;
            this.lnkSetBeginning.TabStop = true;
            this.lnkSetBeginning.Text = "Set...";
            this.lnkSetBeginning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetPrice_LinkClicked);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(361, 17);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(111, 21);
            this.txtUnitPrice.TabIndex = 26;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInStock
            // 
            this.txtInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInStock.Location = new System.Drawing.Point(88, 20);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.ReadOnly = true;
            this.txtInStock.Size = new System.Drawing.Size(111, 22);
            this.txtInStock.TabIndex = 26;
            this.txtInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemIDTextBox
            // 
            this.itemIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsBindingSource, "ItemID", true));
            this.itemIDTextBox.Location = new System.Drawing.Point(470, 49);
            this.itemIDTextBox.Name = "itemIDTextBox";
            this.itemIDTextBox.Size = new System.Drawing.Size(183, 20);
            this.itemIDTextBox.TabIndex = 24;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // m_VehicleTypeTableAdapter
            // 
            this.m_VehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // measurmentTypesTableAdapter
            // 
            this.measurmentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // itemPurchaseTypesTableAdapter
            // 
            this.itemPurchaseTypesTableAdapter.ClearBeforeFill = true;
            // 
            // frmItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 550);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.itemIDTextBox);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.grdItemList);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.bNavItems);
            this.Controls.Add(partNumberLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(measurementIdLabel);
            this.Controls.Add(this.measurementIdComboBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(orderLevelLabel);
            this.Controls.Add(this.orderLevelTextBox);
            this.Controls.Add(vatTaxedLabel);
            this.Controls.Add(this.vatTaxedCheckBox);
            this.Controls.Add(pictureLabel);
            this.KeyPreview = true;
            this.Name = "frmItemEdit";
            this.Text = "Item Editor";
            this.Activated += new System.EventHandler(this.frmItemEdit_Activated);
            this.Load += new System.EventHandler(this.frmItemEdit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmItemEdit_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavItems)).EndInit();
            this.bNavItems.ResumeLayout(false);
            this.bNavItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurmentUnitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPurchaseTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItemList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingNavigator bNavItems;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton itemsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox measurementIdComboBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox orderLevelTextBox;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.CheckBox vatTaxedCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private BelayAbSSDataSet belayAbSSDataSet;
        private System.Windows.Forms.BindingSource measurmentUnitsBindingSource;
        private System.Windows.Forms.BindingSource categoryListBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.CategoryListTableAdapter categoryListTableAdapter;
        private System.Windows.Forms.BindingSource locationViewBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.LocationViewTableAdapter locationViewTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboReceivedNo;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditImage;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteImage;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBrowseItems;
        private System.Windows.Forms.ToolStripButton btnAllItems;
        private System.Windows.Forms.ToolStripButton btnSItemDetails;
        private System.Windows.Forms.Button btnEditCats;
        private System.Windows.Forms.DataGridView grdItemList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.LinkLabel cmdNew;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.LinkLabel lnkSetBeginning;
        private System.Windows.Forms.LinkLabel lnkHistory;
        public System.Windows.Forms.ComboBox categoryIdComboBox;
        private System.Windows.Forms.TextBox itemIDTextBox;
        private System.Windows.Forms.ComboBox itemTypeIDComboBox;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn measurementIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vatTaxedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ComboBox vehicleTypeIDComboBox;
        private System.Windows.Forms.BindingSource mVehicleTypeBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter m_VehicleTypeTableAdapter;
        private System.Windows.Forms.Button btnEditVehiceTypes;
        private System.Windows.Forms.Button btnEdiItemTypes;
        private System.Windows.Forms.BindingSource measurmentTypesBindingSource;
        private BelayAbSSDataSetItemsCategoriesTableAdapters.MeasurmentTypesTableAdapter measurmentTypesTableAdapter;
        private System.Windows.Forms.LinkLabel lnkItemBalances;
        private System.Windows.Forms.ComboBox itemPurchaseTypeComboBox;
        private System.Windows.Forms.TextBox txtYearBegining;
        private System.Windows.Forms.BindingSource itemPurchaseTypesBindingSource;
        private BelayAbSSDataSetItemsCategoriesTableAdapters.ItemPurchaseTypesTableAdapter itemPurchaseTypesTableAdapter;
    }
}