namespace Belayab
{
    partial class frmWOrkshopItemsNonIssued
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWOrkshopItemsNonIssued));
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.rpt_WorkOrderItems_Non_IssuedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grdNonIssuedWOItemsList = new System.Windows.Forms.DataGridView();
            this.WorkOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rpt_WorkOrderItems_Non_IssuedTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.rpt_WorkOrderItems_Non_IssuedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_WorkOrderItems_Non_IssuedBindingNavigator)).BeginInit();
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_WorkOrderItems_Non_IssuedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNonIssuedWOItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // rpt_WorkOrderItems_Non_IssuedBindingNavigator
            // 
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.AddNewItem = null;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.BindingSource = this.rpt_WorkOrderItems_Non_IssuedBindingSource;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.DeleteItem = null;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.Name = "rpt_WorkOrderItems_Non_IssuedBindingNavigator";
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.Size = new System.Drawing.Size(839, 25);
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.TabIndex = 1;
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.Text = "bindingNavigator1";
            // 
            // rpt_WorkOrderItems_Non_IssuedBindingSource
            // 
            this.rpt_WorkOrderItems_Non_IssuedBindingSource.DataMember = "rpt_WorkOrderItems_Non_Issued";
            this.rpt_WorkOrderItems_Non_IssuedBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // grdNonIssuedWOItemsList
            // 
            this.grdNonIssuedWOItemsList.AllowUserToAddRows = false;
            this.grdNonIssuedWOItemsList.AllowUserToDeleteRows = false;
            this.grdNonIssuedWOItemsList.AllowUserToOrderColumns = true;
            this.grdNonIssuedWOItemsList.AutoGenerateColumns = false;
            this.grdNonIssuedWOItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNonIssuedWOItemsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkOrderNumber,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn11});
            this.grdNonIssuedWOItemsList.DataSource = this.rpt_WorkOrderItems_Non_IssuedBindingSource;
            this.grdNonIssuedWOItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNonIssuedWOItemsList.Location = new System.Drawing.Point(0, 25);
            this.grdNonIssuedWOItemsList.Name = "grdNonIssuedWOItemsList";
            this.grdNonIssuedWOItemsList.Size = new System.Drawing.Size(839, 458);
            this.grdNonIssuedWOItemsList.TabIndex = 2;
            this.grdNonIssuedWOItemsList.DoubleClick += new System.EventHandler(this.rpt_WorkOrderItems_Non_IssuedDataGridView_DoubleClick);
            // 
            // WorkOrderNumber
            // 
            this.WorkOrderNumber.DataPropertyName = "W_O_Number";
            this.WorkOrderNumber.HeaderText = "W_O_Number";
            this.WorkOrderNumber.Name = "WorkOrderNumber";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Date In";
            this.dataGridViewTextBoxColumn10.HeaderText = "Date In";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SIV No";
            this.dataGridViewTextBoxColumn6.HeaderText = "SIV No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PlateNumber";
            this.dataGridViewTextBoxColumn7.HeaderText = "PlateNumber";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn8.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Date Out";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date Out";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "isOut";
            this.dataGridViewCheckBoxColumn1.HeaderText = "isOut";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn11.HeaderText = "StoreID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // rpt_WorkOrderItems_Non_IssuedTableAdapter
            // 
            this.rpt_WorkOrderItems_Non_IssuedTableAdapter.ClearBeforeFill = true;
            // 
            // frmWOrkshopItemsNonIssued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 483);
            this.Controls.Add(this.grdNonIssuedWOItemsList);
            this.Controls.Add(this.rpt_WorkOrderItems_Non_IssuedBindingNavigator);
            this.Name = "frmWOrkshopItemsNonIssued";
            this.Text = "Work Order items with No Issue Record";
            this.Load += new System.EventHandler(this.frmWOrkshopItemsNonIssued_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rpt_WorkOrderItems_Non_IssuedBindingNavigator)).EndInit();
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.ResumeLayout(false);
            this.rpt_WorkOrderItems_Non_IssuedBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpt_WorkOrderItems_Non_IssuedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdNonIssuedWOItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource rpt_WorkOrderItems_Non_IssuedBindingSource;
        private BelayAbSSDataSetItemsCategoriesTableAdapters.rpt_WorkOrderItems_Non_IssuedTableAdapter rpt_WorkOrderItems_Non_IssuedTableAdapter;
        private System.Windows.Forms.BindingNavigator rpt_WorkOrderItems_Non_IssuedBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView grdNonIssuedWOItemsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}