namespace Belayab
{
    partial class frmMaintainanceS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintainanceS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.s_MaintenanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.s_MaintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
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
            this.s_MaintenanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.s_MaintenanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_MaintenanceTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.s_MaintenanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceBindingNavigator)).BeginInit();
            this.s_MaintenanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // s_MaintenanceBindingNavigator
            // 
            this.s_MaintenanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.s_MaintenanceBindingNavigator.BindingSource = this.s_MaintenanceBindingSource;
            this.s_MaintenanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.s_MaintenanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.s_MaintenanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.s_MaintenanceBindingNavigatorSaveItem});
            this.s_MaintenanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.s_MaintenanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.s_MaintenanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.s_MaintenanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.s_MaintenanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.s_MaintenanceBindingNavigator.Name = "s_MaintenanceBindingNavigator";
            this.s_MaintenanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.s_MaintenanceBindingNavigator.Size = new System.Drawing.Size(426, 25);
            this.s_MaintenanceBindingNavigator.TabIndex = 0;
            this.s_MaintenanceBindingNavigator.Text = "bindingNavigator1";
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
            // s_MaintenanceBindingSource
            // 
            this.s_MaintenanceBindingSource.DataMember = "s_Maintenance";
            this.s_MaintenanceBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
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
            // s_MaintenanceBindingNavigatorSaveItem
            // 
            this.s_MaintenanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.s_MaintenanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("s_MaintenanceBindingNavigatorSaveItem.Image")));
            this.s_MaintenanceBindingNavigatorSaveItem.Name = "s_MaintenanceBindingNavigatorSaveItem";
            this.s_MaintenanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.s_MaintenanceBindingNavigatorSaveItem.Text = "Save Data";
            this.s_MaintenanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.s_MaintenanceBindingNavigatorSaveItem_Click);
            // 
            // s_MaintenanceDataGridView
            // 
            this.s_MaintenanceDataGridView.AutoGenerateColumns = false;
            this.s_MaintenanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.s_MaintenanceDataGridView.DataSource = this.s_MaintenanceBindingSource;
            this.s_MaintenanceDataGridView.Location = new System.Drawing.Point(12, 28);
            this.s_MaintenanceDataGridView.Name = "s_MaintenanceDataGridView";
            this.s_MaintenanceDataGridView.Size = new System.Drawing.Size(387, 231);
            this.s_MaintenanceDataGridView.TabIndex = 1;
            this.s_MaintenanceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.s_MaintenanceDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sMaitenanceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Service Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sMaintananceDescriptin";
            this.dataGridViewTextBoxColumn2.HeaderText = "Service Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 220;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // s_MaintenanceTableAdapter
            // 
            this.s_MaintenanceTableAdapter.ClearBeforeFill = true;
            // 
            // frmMaintainanceS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 271);
            this.Controls.Add(this.s_MaintenanceDataGridView);
            this.Controls.Add(this.s_MaintenanceBindingNavigator);
            this.Name = "frmMaintainanceS";
            this.Text = "Maintenance Services and Prices";
            this.Load += new System.EventHandler(this.frmMaintainanceS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceBindingNavigator)).EndInit();
            this.s_MaintenanceBindingNavigator.ResumeLayout(false);
            this.s_MaintenanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_MaintenanceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource s_MaintenanceBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.s_MaintenanceTableAdapter s_MaintenanceTableAdapter;
        private System.Windows.Forms.BindingNavigator s_MaintenanceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton s_MaintenanceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView s_MaintenanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}