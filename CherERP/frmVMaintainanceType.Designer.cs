namespace Belayab
{
    partial class frmVMaintainanceType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVMaintainanceType));
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.m_MaintenanceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_MaintenanceTypeTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_MaintenanceTypeTableAdapter();
            this.m_MaintenanceTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.m_MaintenanceTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_MaintenanceTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeBindingNavigator)).BeginInit();
            this.m_MaintenanceTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_MaintenanceTypeBindingSource
            // 
            this.m_MaintenanceTypeBindingSource.DataMember = "m_MaintenanceType";
            this.m_MaintenanceTypeBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // m_MaintenanceTypeTableAdapter
            // 
            this.m_MaintenanceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // m_MaintenanceTypeBindingNavigator
            // 
            this.m_MaintenanceTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_MaintenanceTypeBindingNavigator.BindingSource = this.m_MaintenanceTypeBindingSource;
            this.m_MaintenanceTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_MaintenanceTypeBindingNavigator.DeleteItem = null;
            this.m_MaintenanceTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_MaintenanceTypeBindingNavigatorSaveItem});
            this.m_MaintenanceTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_MaintenanceTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_MaintenanceTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_MaintenanceTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_MaintenanceTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_MaintenanceTypeBindingNavigator.Name = "m_MaintenanceTypeBindingNavigator";
            this.m_MaintenanceTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_MaintenanceTypeBindingNavigator.Size = new System.Drawing.Size(458, 25);
            this.m_MaintenanceTypeBindingNavigator.TabIndex = 0;
            this.m_MaintenanceTypeBindingNavigator.Text = "bindingNavigator1";
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
            // m_MaintenanceTypeBindingNavigatorSaveItem
            // 
            this.m_MaintenanceTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_MaintenanceTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_MaintenanceTypeBindingNavigatorSaveItem.Image")));
            this.m_MaintenanceTypeBindingNavigatorSaveItem.Name = "m_MaintenanceTypeBindingNavigatorSaveItem";
            this.m_MaintenanceTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_MaintenanceTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.m_MaintenanceTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_MaintenanceTypeBindingNavigatorSaveItem_Click);
            // 
            // m_MaintenanceTypeDataGridView
            // 
            this.m_MaintenanceTypeDataGridView.AutoGenerateColumns = false;
            this.m_MaintenanceTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_MaintenanceTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_MaintenanceTypeDataGridView.DataSource = this.m_MaintenanceTypeBindingSource;
            this.m_MaintenanceTypeDataGridView.Location = new System.Drawing.Point(23, 37);
            this.m_MaintenanceTypeDataGridView.Name = "m_MaintenanceTypeDataGridView";
            this.m_MaintenanceTypeDataGridView.Size = new System.Drawing.Size(423, 338);
            this.m_MaintenanceTypeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "m_TypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "m_TypeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "m_TypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Maintenance Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "m_TypeDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "m_TypeDescription";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // frmVMaintainanceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 396);
            this.Controls.Add(this.m_MaintenanceTypeDataGridView);
            this.Controls.Add(this.m_MaintenanceTypeBindingNavigator);
            this.Name = "frmVMaintainanceType";
            this.Text = "Maintenance Types";
            this.Load += new System.EventHandler(this.frmVMaintainanceType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeBindingNavigator)).EndInit();
            this.m_MaintenanceTypeBindingNavigator.ResumeLayout(false);
            this.m_MaintenanceTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_MaintenanceTypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource m_MaintenanceTypeBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.m_MaintenanceTypeTableAdapter m_MaintenanceTypeTableAdapter;
        private System.Windows.Forms.BindingNavigator m_MaintenanceTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_MaintenanceTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_MaintenanceTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}