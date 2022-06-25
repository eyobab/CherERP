namespace Belayab
{
    partial class frmCustomerAdress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerAdress));
            this.customerAddressBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customerAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbVMaintain = new Belayab.BelayAbVMaintain();
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
            this.customerAddressBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerAddressDataGridView = new System.Windows.Forms.DataGridView();
            this.customerAddressTableAdapter = new Belayab.BelayAbVMaintainTableAdapters.CustomerAddressTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingNavigator)).BeginInit();
            this.customerAddressBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerAddressBindingNavigator
            // 
            this.customerAddressBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerAddressBindingNavigator.BindingSource = this.customerAddressBindingSource;
            this.customerAddressBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerAddressBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerAddressBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerAddressBindingNavigatorSaveItem});
            this.customerAddressBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerAddressBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerAddressBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerAddressBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerAddressBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerAddressBindingNavigator.Name = "customerAddressBindingNavigator";
            this.customerAddressBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerAddressBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.customerAddressBindingNavigator.TabIndex = 0;
            this.customerAddressBindingNavigator.Text = "bindingNavigator1";
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
            // customerAddressBindingSource
            // 
            this.customerAddressBindingSource.DataMember = "CustomerAddress";
            this.customerAddressBindingSource.DataSource = this.belayAbVMaintain;
            // 
            // belayAbVMaintain
            // 
            this.belayAbVMaintain.DataSetName = "BelayAbVMaintain";
            this.belayAbVMaintain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // customerAddressBindingNavigatorSaveItem
            // 
            this.customerAddressBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerAddressBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerAddressBindingNavigatorSaveItem.Image")));
            this.customerAddressBindingNavigatorSaveItem.Name = "customerAddressBindingNavigatorSaveItem";
            this.customerAddressBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerAddressBindingNavigatorSaveItem.Text = "Save Data";
            this.customerAddressBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerAddressBindingNavigatorSaveItem_Click);
            // 
            // customerAddressDataGridView
            // 
            this.customerAddressDataGridView.AllowUserToAddRows = false;
            this.customerAddressDataGridView.AllowUserToDeleteRows = false;
            this.customerAddressDataGridView.AutoGenerateColumns = false;
            this.customerAddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerAddressDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.CustomerId});
            this.customerAddressDataGridView.DataSource = this.customerAddressBindingSource;
            this.customerAddressDataGridView.Location = new System.Drawing.Point(7, 32);
            this.customerAddressDataGridView.Name = "customerAddressDataGridView";
            this.customerAddressDataGridView.Size = new System.Drawing.Size(367, 203);
            this.customerAddressDataGridView.TabIndex = 1;
            this.customerAddressDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.customerAddressDataGridView_RowsAdded);
            // 
            // customerAddressTableAdapter
            // 
            this.customerAddressTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AdressType";
            this.dataGridViewTextBoxColumn2.HeaderText = "Adress Type";
            this.dataGridViewTextBoxColumn2.Items.AddRange(new object[] {
            "Work Phone",
            "Contact Phone",
            "Business Phone",
            "Fax Number",
            "Mobile Phone",
            "Email",
            "Website"});
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AdressValue";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adress Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // frmCustomerAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 245);
            this.Controls.Add(this.customerAddressDataGridView);
            this.Controls.Add(this.customerAddressBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerAdress";
            this.Text = "Cusstomer Addresses";
            this.Load += new System.EventHandler(this.frmCustomerAdress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingNavigator)).EndInit();
            this.customerAddressBindingNavigator.ResumeLayout(false);
            this.customerAddressBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbVMaintain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerAddressDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbVMaintain belayAbVMaintain;
        private System.Windows.Forms.BindingSource customerAddressBindingSource;
        private Belayab.BelayAbVMaintainTableAdapters.CustomerAddressTableAdapter customerAddressTableAdapter;
        private System.Windows.Forms.BindingNavigator customerAddressBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerAddressBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView customerAddressDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
    }
}