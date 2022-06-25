namespace Belayab
{
    partial class FrmItemTypes
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
            System.Windows.Forms.Label itemTypeIDLabel;
            System.Windows.Forms.Label itemTypeDescreptionLabel;
            System.Windows.Forms.Label remarksLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemTypes));
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.itemTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypesTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemTypesTableAdapter();
            this.itemTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.itemTypeDescreptionTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            this.itemTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.itemTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            itemTypeIDLabel = new System.Windows.Forms.Label();
            itemTypeDescreptionLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingNavigator)).BeginInit();
            this.itemTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTypesBindingSource
            // 
            this.itemTypesBindingSource.DataMember = "ItemTypes";
            this.itemTypesBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // itemTypesTableAdapter
            // 
            this.itemTypesTableAdapter.ClearBeforeFill = true;
            // 
            // itemTypesBindingNavigator
            // 
            this.itemTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemTypesBindingNavigator.BindingSource = this.itemTypesBindingSource;
            this.itemTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemTypesBindingNavigator.DeleteItem = null;
            this.itemTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.itemTypesBindingNavigatorSaveItem});
            this.itemTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemTypesBindingNavigator.Name = "itemTypesBindingNavigator";
            this.itemTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemTypesBindingNavigator.Size = new System.Drawing.Size(603, 25);
            this.itemTypesBindingNavigator.TabIndex = 0;
            this.itemTypesBindingNavigator.Text = "bindingNavigator1";
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
            // itemTypeIDLabel
            // 
            itemTypeIDLabel.AutoSize = true;
            itemTypeIDLabel.Location = new System.Drawing.Point(65, 43);
            itemTypeIDLabel.Name = "itemTypeIDLabel";
            itemTypeIDLabel.Size = new System.Drawing.Size(71, 13);
            itemTypeIDLabel.TabIndex = 1;
            itemTypeIDLabel.Text = "Item Type ID:";
            // 
            // itemTypeIDTextBox
            // 
            this.itemTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemTypesBindingSource, "ItemTypeID", true));
            this.itemTypeIDTextBox.Location = new System.Drawing.Point(188, 40);
            this.itemTypeIDTextBox.Name = "itemTypeIDTextBox";
            this.itemTypeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTypeIDTextBox.TabIndex = 2;
            // 
            // itemTypeDescreptionLabel
            // 
            itemTypeDescreptionLabel.AutoSize = true;
            itemTypeDescreptionLabel.Location = new System.Drawing.Point(65, 69);
            itemTypeDescreptionLabel.Name = "itemTypeDescreptionLabel";
            itemTypeDescreptionLabel.Size = new System.Drawing.Size(117, 13);
            itemTypeDescreptionLabel.TabIndex = 3;
            itemTypeDescreptionLabel.Text = "Item Type Descreption:";
            // 
            // itemTypeDescreptionTextBox
            // 
            this.itemTypeDescreptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemTypesBindingSource, "ItemTypeDescreption", true));
            this.itemTypeDescreptionTextBox.Location = new System.Drawing.Point(188, 66);
            this.itemTypeDescreptionTextBox.Name = "itemTypeDescreptionTextBox";
            this.itemTypeDescreptionTextBox.Size = new System.Drawing.Size(193, 20);
            this.itemTypeDescreptionTextBox.TabIndex = 4;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(65, 95);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(52, 13);
            remarksLabel.TabIndex = 5;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemTypesBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(188, 92);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(193, 20);
            this.remarksTextBox.TabIndex = 6;
            // 
            // itemTypesDataGridView
            // 
            this.itemTypesDataGridView.AutoGenerateColumns = false;
            this.itemTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.itemTypesDataGridView.DataSource = this.itemTypesBindingSource;
            this.itemTypesDataGridView.Location = new System.Drawing.Point(24, 145);
            this.itemTypesDataGridView.Name = "itemTypesDataGridView";
            this.itemTypesDataGridView.Size = new System.Drawing.Size(567, 236);
            this.itemTypesDataGridView.TabIndex = 7;
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
            // itemTypesBindingNavigatorSaveItem
            // 
            this.itemTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemTypesBindingNavigatorSaveItem.Image")));
            this.itemTypesBindingNavigatorSaveItem.Name = "itemTypesBindingNavigatorSaveItem";
            this.itemTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.itemTypesBindingNavigatorSaveItem.Text = "Save Data";
            this.itemTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemTypesBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Type ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemTypeDescreption";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Type Descreption";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn3.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // FrmItemTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 393);
            this.Controls.Add(this.itemTypesDataGridView);
            this.Controls.Add(itemTypeIDLabel);
            this.Controls.Add(this.itemTypeIDTextBox);
            this.Controls.Add(itemTypeDescreptionLabel);
            this.Controls.Add(this.itemTypeDescreptionTextBox);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(this.itemTypesBindingNavigator);
            this.Name = "FrmItemTypes";
            this.Text = "Item Types";
            this.Load += new System.EventHandler(this.FrmItemTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesBindingNavigator)).EndInit();
            this.itemTypesBindingNavigator.ResumeLayout(false);
            this.itemTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource itemTypesBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.ItemTypesTableAdapter itemTypesTableAdapter;
        private System.Windows.Forms.BindingNavigator itemTypesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton itemTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox itemTypeIDTextBox;
        private System.Windows.Forms.TextBox itemTypeDescreptionTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
        private System.Windows.Forms.DataGridView itemTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}