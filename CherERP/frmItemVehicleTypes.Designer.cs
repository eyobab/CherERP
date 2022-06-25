namespace Belayab
{
    partial class frmItemVehicleTypes
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
            System.Windows.Forms.Label vehicletypeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label ramarksLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemVehicleTypes));
            this.belayAbSSDataSetItemsCategories = new Belayab.BelayAbSSDataSetItemsCategories();
            this.m_VehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_VehicleTypeTableAdapter = new Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter();
            this.m_VehicleTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.m_VehicleTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vehicletypeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ramarksTextBox = new System.Windows.Forms.TextBox();
            this.m_VehicleTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vehicletypeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ramarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingNavigator)).BeginInit();
            this.m_VehicleTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicletypeLabel
            // 
            vehicletypeLabel.AutoSize = true;
            vehicletypeLabel.Location = new System.Drawing.Point(93, 49);
            vehicletypeLabel.Name = "vehicletypeLabel";
            vehicletypeLabel.Size = new System.Drawing.Size(65, 13);
            vehicletypeLabel.TabIndex = 1;
            vehicletypeLabel.Text = "Vehicletype:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(93, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // ramarksLabel
            // 
            ramarksLabel.AutoSize = true;
            ramarksLabel.Location = new System.Drawing.Point(93, 101);
            ramarksLabel.Name = "ramarksLabel";
            ramarksLabel.Size = new System.Drawing.Size(52, 13);
            ramarksLabel.TabIndex = 5;
            ramarksLabel.Text = "Ramarks:";
            // 
            // belayAbSSDataSetItemsCategories
            // 
            this.belayAbSSDataSetItemsCategories.DataSetName = "BelayAbSSDataSetItemsCategories";
            this.belayAbSSDataSetItemsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_VehicleTypeBindingSource
            // 
            this.m_VehicleTypeBindingSource.DataMember = "m_VehicleType";
            this.m_VehicleTypeBindingSource.DataSource = this.belayAbSSDataSetItemsCategories;
            // 
            // m_VehicleTypeTableAdapter
            // 
            this.m_VehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // m_VehicleTypeBindingNavigator
            // 
            this.m_VehicleTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.m_VehicleTypeBindingNavigator.BindingSource = this.m_VehicleTypeBindingSource;
            this.m_VehicleTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.m_VehicleTypeBindingNavigator.DeleteItem = null;
            this.m_VehicleTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.m_VehicleTypeBindingNavigatorSaveItem});
            this.m_VehicleTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.m_VehicleTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.m_VehicleTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.m_VehicleTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.m_VehicleTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.m_VehicleTypeBindingNavigator.Name = "m_VehicleTypeBindingNavigator";
            this.m_VehicleTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.m_VehicleTypeBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.m_VehicleTypeBindingNavigator.TabIndex = 0;
            this.m_VehicleTypeBindingNavigator.Text = "bindingNavigator1";
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
            // m_VehicleTypeBindingNavigatorSaveItem
            // 
            this.m_VehicleTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.m_VehicleTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("m_VehicleTypeBindingNavigatorSaveItem.Image")));
            this.m_VehicleTypeBindingNavigatorSaveItem.Name = "m_VehicleTypeBindingNavigatorSaveItem";
            this.m_VehicleTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.m_VehicleTypeBindingNavigatorSaveItem.Text = "Save Data";
            this.m_VehicleTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.m_VehicleTypeBindingNavigatorSaveItem_Click);
            // 
            // vehicletypeTextBox
            // 
            this.vehicletypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_VehicleTypeBindingSource, "Vehicletype", true));
            this.vehicletypeTextBox.Location = new System.Drawing.Point(167, 46);
            this.vehicletypeTextBox.Name = "vehicletypeTextBox";
            this.vehicletypeTextBox.Size = new System.Drawing.Size(228, 20);
            this.vehicletypeTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_VehicleTypeBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(167, 72);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(268, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // ramarksTextBox
            // 
            this.ramarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.m_VehicleTypeBindingSource, "Ramarks", true));
            this.ramarksTextBox.Location = new System.Drawing.Point(167, 98);
            this.ramarksTextBox.Name = "ramarksTextBox";
            this.ramarksTextBox.Size = new System.Drawing.Size(334, 20);
            this.ramarksTextBox.TabIndex = 6;
            // 
            // m_VehicleTypeDataGridView
            // 
            this.m_VehicleTypeDataGridView.AutoGenerateColumns = false;
            this.m_VehicleTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_VehicleTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.m_VehicleTypeDataGridView.DataSource = this.m_VehicleTypeBindingSource;
            this.m_VehicleTypeDataGridView.Location = new System.Drawing.Point(12, 135);
            this.m_VehicleTypeDataGridView.Name = "m_VehicleTypeDataGridView";
            this.m_VehicleTypeDataGridView.Size = new System.Drawing.Size(549, 299);
            this.m_VehicleTypeDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vehicletype";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vehicletype";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ramarks";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ramarks";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // frmItemVehicleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 446);
            this.Controls.Add(this.m_VehicleTypeDataGridView);
            this.Controls.Add(vehicletypeLabel);
            this.Controls.Add(this.vehicletypeTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(ramarksLabel);
            this.Controls.Add(this.ramarksTextBox);
            this.Controls.Add(this.m_VehicleTypeBindingNavigator);
            this.Name = "frmItemVehicleTypes";
            this.Text = "Vehicle Types";
            this.Load += new System.EventHandler(this.frmItemVehicleTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSSDataSetItemsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeBindingNavigator)).EndInit();
            this.m_VehicleTypeBindingNavigator.ResumeLayout(false);
            this.m_VehicleTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_VehicleTypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbSSDataSetItemsCategories belayAbSSDataSetItemsCategories;
        private System.Windows.Forms.BindingSource m_VehicleTypeBindingSource;
        private Belayab.BelayAbSSDataSetItemsCategoriesTableAdapters.m_VehicleTypeTableAdapter m_VehicleTypeTableAdapter;
        private System.Windows.Forms.BindingNavigator m_VehicleTypeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton m_VehicleTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox vehicletypeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox ramarksTextBox;
        private System.Windows.Forms.DataGridView m_VehicleTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}