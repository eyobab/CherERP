namespace Belayab
{
    partial class frmBranch_Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranch_Store));
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbBranchStore = new Belayab.BelayAbBranchStore();
            this.branchesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.BranchesTableAdapter();
            this.storesTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.StoresTableAdapter();
            this.shelfsTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.ShelfsTableAdapter();
            this.columnsTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.ColumnsTableAdapter();
            this.rowsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rowsTableAdapter = new Belayab.BelayAbBranchStoreTableAdapters.RowsTableAdapter();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.branchesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.branchesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingNavigator)).BeginInit();
            this.branchesBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // branchesDataGridView
            // 
            this.branchesDataGridView.AutoGenerateColumns = false;
            this.branchesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.branchesDataGridView.DataSource = this.branchesBindingSource;
            this.branchesDataGridView.Location = new System.Drawing.Point(6, 28);
            this.branchesDataGridView.Name = "branchesDataGridView";
            this.branchesDataGridView.Size = new System.Drawing.Size(450, 138);
            this.branchesDataGridView.TabIndex = 1;
            this.branchesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BranchId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Branch Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BranchName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Branch Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // storesBindingSource
            // 
            this.storesBindingSource.DataMember = "FK_Stores_Branches";
            this.storesBindingSource.DataSource = this.branchesBindingSource;
            // 
            // storesDataGridView
            // 
            this.storesDataGridView.AutoGenerateColumns = false;
            this.storesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.storesDataGridView.DataSource = this.storesBindingSource;
            this.storesDataGridView.Location = new System.Drawing.Point(4, 197);
            this.storesDataGridView.Name = "storesDataGridView";
            this.storesDataGridView.Size = new System.Drawing.Size(446, 131);
            this.storesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StoreId";
            this.dataGridViewTextBoxColumn5.HeaderText = "StoreId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StoreName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Store Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 250;
            // 
            // shelfsBindingSource
            // 
            this.shelfsBindingSource.DataMember = "Stores_Shelfs";
            this.shelfsBindingSource.DataSource = this.storesBindingSource;
            // 
            // columnsBindingSource
            // 
            this.columnsBindingSource.DataMember = "Shelfs_Columns";
            this.columnsBindingSource.DataSource = this.shelfsBindingSource;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // storesTableAdapter
            // 
            this.storesTableAdapter.ClearBeforeFill = true;
            // 
            // shelfsTableAdapter
            // 
            this.shelfsTableAdapter.ClearBeforeFill = true;
            // 
            // columnsTableAdapter
            // 
            this.columnsTableAdapter.ClearBeforeFill = true;
            // 
            // rowsBindingSource
            // 
            this.rowsBindingSource.DataMember = "Columns_Rows";
            this.rowsBindingSource.DataSource = this.columnsBindingSource;
            // 
            // rowsTableAdapter
            // 
            this.rowsTableAdapter.ClearBeforeFill = true;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // branchesBindingNavigatorSaveItem
            // 
            this.branchesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("branchesBindingNavigatorSaveItem.Image")));
            this.branchesBindingNavigatorSaveItem.Name = "branchesBindingNavigatorSaveItem";
            this.branchesBindingNavigatorSaveItem.Size = new System.Drawing.Size(130, 22);
            this.branchesBindingNavigatorSaveItem.Text = "Save changes";
            this.branchesBindingNavigatorSaveItem.Click += new System.EventHandler(this.branchesBindingNavigatorSaveItem_Click);
            // 
            // branchesBindingNavigator
            // 
            this.branchesBindingNavigator.AddNewItem = null;
            this.branchesBindingNavigator.BindingSource = this.branchesBindingSource;
            this.branchesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.branchesBindingNavigator.DeleteItem = null;
            this.branchesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.branchesBindingNavigator.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.branchesBindingNavigatorSaveItem});
            this.branchesBindingNavigator.Location = new System.Drawing.Point(17, 6);
            this.branchesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.branchesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.branchesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.branchesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.branchesBindingNavigator.Name = "branchesBindingNavigator";
            this.branchesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.branchesBindingNavigator.Size = new System.Drawing.Size(357, 25);
            this.branchesBindingNavigator.TabIndex = 0;
            this.branchesBindingNavigator.Text = "bindingNavigator1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StoreId";
            this.dataGridViewTextBoxColumn4.HeaderText = "StoreId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ShelfId";
            this.dataGridViewTextBoxColumn6.HeaderText = "Shelf Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 250;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ColumnId";
            this.dataGridViewTextBoxColumn8.HeaderText = "Column Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RowId";
            this.dataGridViewTextBoxColumn10.HeaderText = "Row Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnItems);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.storesDataGridView);
            this.groupBox1.Controls.Add(this.branchesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(17, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 344);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(456, 197);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(86, 23);
            this.btnItems.TabIndex = 5;
            this.btnItems.Text = "View Items";
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Branches";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stores in the selected branch";
            // 
            // frmBranch_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.branchesBindingNavigator);
            this.MaximizeBox = false;
            this.Name = "frmBranch_Store";
            this.Text = "Branches and Stores";
            this.Load += new System.EventHandler(this.frmBranch_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbBranchStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shelfsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingNavigator)).EndInit();
            this.branchesBindingNavigator.ResumeLayout(false);
            this.branchesBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbBranchStore belayAbBranchStore;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.DataGridView branchesDataGridView;
        private System.Windows.Forms.BindingSource storesBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.StoresTableAdapter storesTableAdapter;
        private System.Windows.Forms.DataGridView storesDataGridView;
        private System.Windows.Forms.BindingSource shelfsBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.ShelfsTableAdapter shelfsTableAdapter;
        private System.Windows.Forms.BindingSource columnsBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.ColumnsTableAdapter columnsTableAdapter;
        private System.Windows.Forms.BindingSource rowsBindingSource;
        private Belayab.BelayAbBranchStoreTableAdapters.RowsTableAdapter rowsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton branchesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator branchesBindingNavigator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnItems;

    }
}