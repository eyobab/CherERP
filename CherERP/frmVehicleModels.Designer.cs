namespace Belayab
{
    partial class frmVehicleModels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleModels));
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.mVehicleSizesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stosaFlatRates = new Belayab.StosaFlatRates();
            this.m_VehicleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.m_VehicleTypeTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter();
            this.m_VehicleSizesTableAdapter = new Belayab.StosaFlatRatesTableAdapters.m_VehicleSizesTableAdapter();
            this.m_VehicleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.vehicletypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleSize = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ramarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniToolStrip = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bNavVTypeAddnew = new System.Windows.Forms.BindingNavigator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleSizesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stosaFlatRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavVTypeAddnew)).BeginInit();
            this.bNavVTypeAddnew.SuspendLayout();
            this.SuspendLayout();
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mVehicleSizesBindingSource
            // 
            this.mVehicleSizesBindingSource.DataMember = "m_VehicleSizes";
            this.mVehicleSizesBindingSource.DataSource = this.stosaFlatRates;
            // 
            // stosaFlatRates
            // 
            this.stosaFlatRates.DataSetName = "StosaFlatRates";
            this.stosaFlatRates.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_VehicleTypeBindingSource1
            // 
            this.m_VehicleTypeBindingSource1.DataMember = "m_VehicleType";
            this.m_VehicleTypeBindingSource1.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // m_VehicleTypeTableAdapter
            // 
            this.m_VehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // m_VehicleSizesTableAdapter
            // 
            this.m_VehicleSizesTableAdapter.ClearBeforeFill = true;
            // 
            // m_VehicleTypeDataGridView
            // 
            this.m_VehicleTypeDataGridView.AllowUserToAddRows = false;
            this.m_VehicleTypeDataGridView.AllowUserToDeleteRows = false;
            this.m_VehicleTypeDataGridView.AutoGenerateColumns = false;
            this.m_VehicleTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicletypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.VehicleSize,
            this.ramarksDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn});
            this.m_VehicleTypeDataGridView.DataSource = this.m_VehicleTypeBindingSource1;
            this.m_VehicleTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_VehicleTypeDataGridView.Location = new System.Drawing.Point(0, 25);
            this.m_VehicleTypeDataGridView.Name = "m_VehicleTypeDataGridView";
            this.m_VehicleTypeDataGridView.Size = new System.Drawing.Size(714, 618);
            this.m_VehicleTypeDataGridView.TabIndex = 7;
            this.m_VehicleTypeDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.m_VehicleTypeDataGridView_EditingControlShowing);
            // 
            // vehicletypeDataGridViewTextBoxColumn
            // 
            this.vehicletypeDataGridViewTextBoxColumn.DataPropertyName = "Vehicletype";
            this.vehicletypeDataGridViewTextBoxColumn.HeaderText = "Vehicle Type";
            this.vehicletypeDataGridViewTextBoxColumn.Name = "vehicletypeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // VehicleSize
            // 
            this.VehicleSize.DataPropertyName = "VehicleSize";
            this.VehicleSize.DataSource = this.mVehicleSizesBindingSource;
            this.VehicleSize.DisplayMember = "VehicleSize";
            this.VehicleSize.DisplayStyleForCurrentCellOnly = true;
            this.VehicleSize.HeaderText = "Vehicle Size";
            this.VehicleSize.Name = "VehicleSize";
            this.VehicleSize.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VehicleSize.ValueMember = "VehicleSizeId";
            this.VehicleSize.Width = 160;
            // 
            // ramarksDataGridViewTextBoxColumn
            // 
            this.ramarksDataGridViewTextBoxColumn.DataPropertyName = "Ramarks";
            this.ramarksDataGridViewTextBoxColumn.HeaderText = "Ramarks";
            this.ramarksDataGridViewTextBoxColumn.Name = "ramarksDataGridViewTextBoxColumn";
            this.ramarksDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "Model Name";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AddNewItem = null;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.CountItem = null;
            this.miniToolStrip.DeleteItem = null;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.MoveFirstItem = null;
            this.miniToolStrip.MoveLastItem = null;
            this.miniToolStrip.MoveNextItem = null;
            this.miniToolStrip.MovePreviousItem = null;
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.PositionItem = null;
            this.miniToolStrip.Size = new System.Drawing.Size(440, 25);
            this.miniToolStrip.TabIndex = 8;
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.Checked = true;
            this.bindingNavigatorAddNewItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(74, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            this.bindingNavigatorAddNewItem1.Click += new System.EventHandler(this.bindingNavigatorAddNewItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Checked = true;
            this.toolStripButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Save Data";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "  ";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.Checked = true;
            this.bindingNavigatorDeleteItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            this.bindingNavigatorDeleteItem1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem1_Click);
            // 
            // bNavVTypeAddnew
            // 
            this.bNavVTypeAddnew.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bNavVTypeAddnew.BindingSource = this.m_VehicleTypeBindingSource1;
            this.bNavVTypeAddnew.CountItem = this.bindingNavigatorCountItem1;
            this.bNavVTypeAddnew.DeleteItem = null;
            this.bNavVTypeAddnew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem1});
            this.bNavVTypeAddnew.Location = new System.Drawing.Point(0, 0);
            this.bNavVTypeAddnew.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bNavVTypeAddnew.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bNavVTypeAddnew.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bNavVTypeAddnew.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bNavVTypeAddnew.Name = "bNavVTypeAddnew";
            this.bNavVTypeAddnew.PositionItem = this.bindingNavigatorPositionItem1;
            this.bNavVTypeAddnew.Size = new System.Drawing.Size(714, 25);
            this.bNavVTypeAddnew.TabIndex = 8;
            this.bNavVTypeAddnew.Text = "bindingNavigator1";
            // 
            // frmVehicleModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 643);
            this.Controls.Add(this.m_VehicleTypeDataGridView);
            this.Controls.Add(this.bNavVTypeAddnew);
            this.Name = "frmVehicleModels";
            this.Text = "Types and Categories";
            this.Activated += new System.EventHandler(this.frmVehicleModels_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVehicleModels_FormClosed);
            this.Load += new System.EventHandler(this.frmVehicleModels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mVehicleSizesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stosaFlatRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miniToolStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavVTypeAddnew)).EndInit();
            this.bNavVTypeAddnew.ResumeLayout(false);
            this.bNavVTypeAddnew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter m_VehicleTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private StosaFlatRates stosaFlatRates;
        private System.Windows.Forms.BindingSource mVehicleSizesBindingSource;
        private Belayab.StosaFlatRatesTableAdapters.m_VehicleSizesTableAdapter m_VehicleSizesTableAdapter;
        private System.Windows.Forms.BindingSource m_VehicleTypeBindingSource1;
        private System.Windows.Forms.DataGridView m_VehicleTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicletypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn VehicleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator miniToolStrip;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.BindingNavigator bNavVTypeAddnew;
    }
}