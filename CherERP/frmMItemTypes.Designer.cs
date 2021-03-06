namespace Belayab
{
    partial class frmMItemTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMItemTypes));
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.m_ItemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_ItemTypesTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_ItemTypesTableAdapter();
            this.m_ItemTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_ItemTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.m_ItemTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesBindingNavigator)).BeginInit();
            this.m_ItemTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_ItemTypesBindingSource
            // 
            this.m_ItemTypesBindingSource.DataMember = "m_ItemTypes";
            this.m_ItemTypesBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // m_ItemTypesTableAdapter
            // 
            this.m_ItemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // m_ItemTypesBindingNavigator
            // 
            this.m_ItemTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_ItemTypesBindingNavigator.BindingSource = this.m_ItemTypesBindingSource;
            this.m_ItemTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_ItemTypesBindingNavigator.DeleteItem = null;
            this.m_ItemTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_ItemTypesBindingNavigatorSaveItem});
            this.m_ItemTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_ItemTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_ItemTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_ItemTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_ItemTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_ItemTypesBindingNavigator.Name = "m_ItemTypesBindingNavigator";
            this.m_ItemTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_ItemTypesBindingNavigator.Size = new System.Drawing.Size(299, 25);
            this.m_ItemTypesBindingNavigator.TabIndex = 0;
            this.m_ItemTypesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // m_ItemTypesDataGridView
            // 
            this.m_ItemTypesDataGridView.AllowUserToAddRows = false;
            this.m_ItemTypesDataGridView.AllowUserToDeleteRows = false;
            this.m_ItemTypesDataGridView.AutoGenerateColumns = false;
            this.m_ItemTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_ItemTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.m_ItemTypesDataGridView.DataSource = this.m_ItemTypesBindingSource;
            this.m_ItemTypesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.m_ItemTypesDataGridView.Name = "m_ItemTypesDataGridView";
            this.m_ItemTypesDataGridView.Size = new System.Drawing.Size(255, 270);
            this.m_ItemTypesDataGridView.TabIndex = 1;
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // m_ItemTypesBindingNavigatorSaveItem
            // 
            this.m_ItemTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_ItemTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_ItemTypesBindingNavigatorSaveItem.Image")));
            this.m_ItemTypesBindingNavigatorSaveItem.Name = "m_ItemTypesBindingNavigatorSaveItem";
            this.m_ItemTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_ItemTypesBindingNavigatorSaveItem.Text = "Save Data";
            this.m_ItemTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_ItemTypesBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemTypeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemType";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // frmMItemTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 307);
            this.Controls.Add(this.m_ItemTypesDataGridView);
            this.Controls.Add(this.m_ItemTypesBindingNavigator);
            this.Name = "frmMItemTypes";
            this.Text = "Maintained Item Types";
            this.Load += new System.EventHandler(this.frmMItemTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesBindingNavigator)).EndInit();
            this.m_ItemTypesBindingNavigator.ResumeLayout(false);
            this.m_ItemTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ItemTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource m_ItemTypesBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_ItemTypesTableAdapter m_ItemTypesTableAdapter;
        private System.Windows.Forms.BindingNavigator m_ItemTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_ItemTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_ItemTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}