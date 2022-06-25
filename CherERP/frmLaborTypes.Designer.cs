namespace Belayab
{
    partial class frmLaborTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaborTypes));
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
            this.m_LaborCostTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_LaborCostTypeTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.m_LaborCostTypeTableAdapter();
            this.m_LaborCostTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.m_LaborCostTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.m_LaborCostTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeBindingNavigator)).BeginInit();
            this.m_LaborCostTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_LaborCostTypeBindingSource
            // 
            this.m_LaborCostTypeBindingSource.DataMember = "m_LaborCostType";
            this.m_LaborCostTypeBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // m_LaborCostTypeTableAdapter
            // 
            this.m_LaborCostTypeTableAdapter.ClearBeforeFill = true;
            // 
            // m_LaborCostTypeBindingNavigator
            // 
            this.m_LaborCostTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_LaborCostTypeBindingNavigator.BindingSource = this.m_LaborCostTypeBindingSource;
            this.m_LaborCostTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_LaborCostTypeBindingNavigator.DeleteItem = null;
            this.m_LaborCostTypeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.m_LaborCostTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_LaborCostTypeBindingNavigatorSaveItem});
            this.m_LaborCostTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_LaborCostTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_LaborCostTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_LaborCostTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_LaborCostTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_LaborCostTypeBindingNavigator.Name = "m_LaborCostTypeBindingNavigator";
            this.m_LaborCostTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_LaborCostTypeBindingNavigator.Size = new System.Drawing.Size(424, 27);
            this.m_LaborCostTypeBindingNavigator.TabIndex = 0;
            this.m_LaborCostTypeBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // m_LaborCostTypeBindingNavigatorSaveItem
            // 
            this.m_LaborCostTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_LaborCostTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_LaborCostTypeBindingNavigatorSaveItem.Image")));
            this.m_LaborCostTypeBindingNavigatorSaveItem.Name = "m_LaborCostTypeBindingNavigatorSaveItem";
            this.m_LaborCostTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.m_LaborCostTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.m_LaborCostTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_LaborCostTypeBindingNavigatorSaveItem_Click);
            // 
            // m_LaborCostTypeDataGridView
            // 
            this.m_LaborCostTypeDataGridView.AllowUserToAddRows = false;
            this.m_LaborCostTypeDataGridView.AllowUserToDeleteRows = false;
            this.m_LaborCostTypeDataGridView.AutoGenerateColumns = false;
            this.m_LaborCostTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_LaborCostTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.m_LaborCostTypeDataGridView.DataSource = this.m_LaborCostTypeBindingSource;
            this.m_LaborCostTypeDataGridView.Location = new System.Drawing.Point(30, 30);
            this.m_LaborCostTypeDataGridView.Name = "m_LaborCostTypeDataGridView";
            this.m_LaborCostTypeDataGridView.RowTemplate.Height = 24;
            this.m_LaborCostTypeDataGridView.Size = new System.Drawing.Size(350, 529);
            this.m_LaborCostTypeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "lCostType";
            this.dataGridViewTextBoxColumn1.HeaderText = "Labor Cost Type";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // frmLaborTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 583);
            this.Controls.Add(this.m_LaborCostTypeDataGridView);
            this.Controls.Add(this.m_LaborCostTypeBindingNavigator);
            this.Name = "frmLaborTypes";
            this.Text = "Labor Cost Types";
            this.Load += new System.EventHandler(this.frmLaborTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeBindingNavigator)).EndInit();
            this.m_LaborCostTypeBindingNavigator.ResumeLayout(false);
            this.m_LaborCostTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_LaborCostTypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource m_LaborCostTypeBindingSource;
        private BelayAbVMaintainTableAdapters.m_LaborCostTypeTableAdapter m_LaborCostTypeTableAdapter;
        private System.Windows.Forms.BindingNavigator m_LaborCostTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_LaborCostTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView m_LaborCostTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}