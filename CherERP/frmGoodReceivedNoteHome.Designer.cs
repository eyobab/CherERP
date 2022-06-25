namespace Belayab
{
    partial class frmGoodReceivedNoteHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodReceivedNoteHome));
            this.itemsReceivedBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.itemsReceivedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.belayAbReceived = new Belayab.BelayAbReceived();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripAddNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
            this.itemsReceivedDataGridView = new System.Windows.Forms.DataGridView();
            this.ReceivedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsReceivedTableAdapter = new Belayab.BelayAbReceivedTableAdapters.ItemsReceivedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingNavigator)).BeginInit();
            this.itemsReceivedBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsReceivedBindingNavigator
            // 
            this.itemsReceivedBindingNavigator.AddNewItem = null;
            this.itemsReceivedBindingNavigator.BindingSource = this.itemsReceivedBindingSource;
            this.itemsReceivedBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsReceivedBindingNavigator.DeleteItem = null;
            this.itemsReceivedBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.itemsReceivedBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.txtFind,
            this.toolStripAddNew,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripRefresh});
            this.itemsReceivedBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsReceivedBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsReceivedBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsReceivedBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsReceivedBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsReceivedBindingNavigator.Name = "itemsReceivedBindingNavigator";
            this.itemsReceivedBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsReceivedBindingNavigator.Size = new System.Drawing.Size(1027, 27);
            this.itemsReceivedBindingNavigator.TabIndex = 0;
            this.itemsReceivedBindingNavigator.Text = "bindingNavigator1";
            // 
            // itemsReceivedBindingSource
            // 
            this.itemsReceivedBindingSource.DataMember = "ItemsReceived";
            this.itemsReceivedBindingSource.DataSource = this.belayAbReceived;
            // 
            // belayAbReceived
            // 
            this.belayAbReceived.DataSetName = "BelayAbReceived";
            this.belayAbReceived.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 24);
            this.toolStripLabel1.Text = "Find>>";
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(132, 27);
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // toolStripAddNew
            // 
            this.toolStripAddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripAddNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddNew.Image")));
            this.toolStripAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddNew.Name = "toolStripAddNew";
            this.toolStripAddNew.Size = new System.Drawing.Size(75, 24);
            this.toolStripAddNew.Text = "Add New";
            this.toolStripAddNew.Click += new System.EventHandler(this.toolStripAddNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(21, 24);
            this.toolStripLabel3.Text = "   ";
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefresh.Image")));
            this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(62, 24);
            this.toolStripRefresh.Text = "Refresh";
            this.toolStripRefresh.Click += new System.EventHandler(this.toolStripRefresh_Click);
            // 
            // itemsReceivedDataGridView
            // 
            this.itemsReceivedDataGridView.AllowUserToAddRows = false;
            this.itemsReceivedDataGridView.AllowUserToDeleteRows = false;
            this.itemsReceivedDataGridView.AutoGenerateColumns = false;
            this.itemsReceivedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsReceivedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceivedNumber,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.VoucherType,
            this.dataGridViewTextBoxColumn9});
            this.itemsReceivedDataGridView.DataSource = this.itemsReceivedBindingSource;
            this.itemsReceivedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsReceivedDataGridView.Location = new System.Drawing.Point(0, 27);
            this.itemsReceivedDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.itemsReceivedDataGridView.Name = "itemsReceivedDataGridView";
            this.itemsReceivedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsReceivedDataGridView.Size = new System.Drawing.Size(1027, 457);
            this.itemsReceivedDataGridView.TabIndex = 1;
            this.itemsReceivedDataGridView.DoubleClick += new System.EventHandler(this.itemsReceivedDataGridView_DoubleClick);
            // 
            // ReceivedNumber
            // 
            this.ReceivedNumber.DataPropertyName = "ReceivedNumber";
            this.ReceivedNumber.HeaderText = "Received Number";
            this.ReceivedNumber.Name = "ReceivedNumber";
            this.ReceivedNumber.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReceivedDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Received Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ReceivedBy";
            this.dataGridViewTextBoxColumn7.HeaderText = "Received By";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DeliveredBy";
            this.dataGridViewTextBoxColumn8.HeaderText = "Delivered By";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn14.HeaderText = "Status";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn15.HeaderText = "Store";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // VoucherType
            // 
            this.VoucherType.DataPropertyName = "VoucherType";
            this.VoucherType.HeaderText = "Voucher Type";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ReceivingRemark";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remark";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // itemsReceivedTableAdapter
            // 
            this.itemsReceivedTableAdapter.ClearBeforeFill = true;
            // 
            // frmGoodReceivedNoteHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 484);
            this.Controls.Add(this.itemsReceivedDataGridView);
            this.Controls.Add(this.itemsReceivedBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGoodReceivedNoteHome";
            this.Text = "Receiving Transaction List";
            this.Load += new System.EventHandler(this.frmGoodReceivedNoteHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingNavigator)).EndInit();
            this.itemsReceivedBindingNavigator.ResumeLayout(false);
            this.itemsReceivedBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbReceived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsReceivedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BelayAbReceived belayAbReceived;
        private System.Windows.Forms.BindingSource itemsReceivedBindingSource;
        private Belayab.BelayAbReceivedTableAdapters.ItemsReceivedTableAdapter itemsReceivedTableAdapter;
        private System.Windows.Forms.BindingNavigator itemsReceivedBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView itemsReceivedDataGridView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        public System.Windows.Forms.ToolStripButton toolStripAddNew;
    }
}