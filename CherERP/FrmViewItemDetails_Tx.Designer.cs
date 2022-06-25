namespace Belayab
{
    partial class FrmViewItemDetails_Tx
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
            this.tabStoreBalances = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.storeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.store1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grdTransferIn = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdReceived = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grdIssued = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grdTransferOut = new System.Windows.Forms.DataGridView();
            this.belayAbSecurity1 = new Belayab.BelayAbSecurity();
            this.grdTranList = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.cboStoreList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnFilterTrans = new System.Windows.Forms.Button();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.tabStoreBalances.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransferIn)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceived)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIssued)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransferOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTranList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStoreBalances
            // 
            this.tabStoreBalances.ContextMenuStrip = this.contextMenuStrip1;
            this.tabStoreBalances.Controls.Add(this.tabPage3);
            this.tabStoreBalances.Controls.Add(this.tabPage2);
            this.tabStoreBalances.Controls.Add(this.tabPage1);
            this.tabStoreBalances.Controls.Add(this.tabPage4);
            this.tabStoreBalances.Location = new System.Drawing.Point(4, 393);
            this.tabStoreBalances.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabStoreBalances.Name = "tabStoreBalances";
            this.tabStoreBalances.SelectedIndex = 0;
            this.tabStoreBalances.Size = new System.Drawing.Size(1353, 389);
            this.tabStoreBalances.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPrintPreview,
            this.storeViewToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 52);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(163, 24);
            this.mnuPrintPreview.Text = "Print Preview";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // storeViewToolStripMenuItem
            // 
            this.storeViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.store1ToolStripMenuItem});
            this.storeViewToolStripMenuItem.Name = "storeViewToolStripMenuItem";
            this.storeViewToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.storeViewToolStripMenuItem.Text = "Store View";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // store1ToolStripMenuItem
            // 
            this.store1ToolStripMenuItem.Name = "store1ToolStripMenuItem";
            this.store1ToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.store1ToolStripMenuItem.Text = "Store1";
            this.store1ToolStripMenuItem.Click += new System.EventHandler(this.store1ToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grdTransferIn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1345, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transactions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grdTransferIn
            // 
            this.grdTransferIn.AllowUserToAddRows = false;
            this.grdTransferIn.AllowUserToDeleteRows = false;
            this.grdTransferIn.AllowUserToOrderColumns = true;
            this.grdTransferIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransferIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransferIn.Location = new System.Drawing.Point(0, 0);
            this.grdTransferIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTransferIn.Name = "grdTransferIn";
            this.grdTransferIn.Size = new System.Drawing.Size(1345, 360);
            this.grdTransferIn.TabIndex = 1;
            this.grdTransferIn.DoubleClick += new System.EventHandler(this.grdTransferIn_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdReceived);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1345, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Received";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdReceived
            // 
            this.grdReceived.AllowUserToAddRows = false;
            this.grdReceived.AllowUserToDeleteRows = false;
            this.grdReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReceived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReceived.Location = new System.Drawing.Point(4, 4);
            this.grdReceived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdReceived.Name = "grdReceived";
            this.grdReceived.Size = new System.Drawing.Size(1337, 352);
            this.grdReceived.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grdIssued);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1345, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Issued";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grdIssued
            // 
            this.grdIssued.AllowUserToAddRows = false;
            this.grdIssued.AllowUserToDeleteRows = false;
            this.grdIssued.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIssued.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIssued.Location = new System.Drawing.Point(4, 4);
            this.grdIssued.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdIssued.Name = "grdIssued";
            this.grdIssued.Size = new System.Drawing.Size(1337, 352);
            this.grdIssued.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grdTransferOut);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1345, 360);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Transfer Out";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grdTransferOut
            // 
            this.grdTransferOut.AllowUserToAddRows = false;
            this.grdTransferOut.AllowUserToDeleteRows = false;
            this.grdTransferOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransferOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransferOut.Location = new System.Drawing.Point(0, 0);
            this.grdTransferOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTransferOut.Name = "grdTransferOut";
            this.grdTransferOut.Size = new System.Drawing.Size(1345, 360);
            this.grdTransferOut.TabIndex = 1;
            // 
            // belayAbSecurity1
            // 
            this.belayAbSecurity1.DataSetName = "BelayAbSecurity";
            this.belayAbSecurity1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdTranList
            // 
            this.grdTranList.AllowUserToAddRows = false;
            this.grdTranList.AllowUserToDeleteRows = false;
            this.grdTranList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTranList.Location = new System.Drawing.Point(4, 57);
            this.grdTranList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdTranList.Name = "grdTranList";
            this.grdTranList.Size = new System.Drawing.Size(1353, 279);
            this.grdTranList.TabIndex = 1;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(147, 16);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(787, 22);
            this.txtFind.TabIndex = 2;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find>>";
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(941, 359);
            this.dateTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(167, 23);
            this.dateTo.TabIndex = 4;
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(683, 359);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(171, 23);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // cboStoreList
            // 
            this.cboStoreList.DisplayMember = "StoreName";
            this.cboStoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreList.FormattingEnabled = true;
            this.cboStoreList.Location = new System.Drawing.Point(439, 359);
            this.cboStoreList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStoreList.Name = "cboStoreList";
            this.cboStoreList.Size = new System.Drawing.Size(153, 25);
            this.cboStoreList.TabIndex = 5;
            this.cboStoreList.ValueMember = "StoreID";
            this.cboStoreList.Visible = false;
            this.cboStoreList.SelectedIndexChanged += new System.EventHandler(this.cboStoreList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Store:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(908, 363);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(1153, 12);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(149, 28);
            this.btnSummary.TabIndex = 8;
            this.btnSummary.Text = "Company Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Visible = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnFilterTrans
            // 
            this.btnFilterTrans.Location = new System.Drawing.Point(1117, 358);
            this.btnFilterTrans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFilterTrans.Name = "btnFilterTrans";
            this.btnFilterTrans.Size = new System.Drawing.Size(100, 28);
            this.btnFilterTrans.TabIndex = 9;
            this.btnFilterTrans.Text = "Filter";
            this.btnFilterTrans.UseVisualStyleBackColor = true;
            this.btnFilterTrans.Visible = false;
            this.btnFilterTrans.Click += new System.EventHandler(this.btnFilterTrans_Click);
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Location = new System.Drawing.Point(1225, 357);
            this.btnCancelFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(100, 28);
            this.btnCancelFilter.TabIndex = 9;
            this.btnCancelFilter.Text = "Cancel";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Visible = false;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // FrmViewItemDetails_Tx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1355, 734);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.btnFilterTrans);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboStoreList);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.grdTranList);
            this.Controls.Add(this.tabStoreBalances);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmViewItemDetails_Tx";
            this.Text = "Item Details and Transactions";
            this.Load += new System.EventHandler(this.FrmViewItemDetails_Load);
            this.Resize += new System.EventHandler(this.FrmViewItemDetails_Resize);
            this.tabStoreBalances.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransferIn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceived)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIssued)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransferOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belayAbSecurity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTranList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabStoreBalances;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private BelayAbSecurity belayAbSecurity1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem storeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem store1ToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdIssued;
        private System.Windows.Forms.DataGridView grdReceived;
        private System.Windows.Forms.DataGridView grdTranList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grdTransferIn;
        private System.Windows.Forms.DataGridView grdTransferOut;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox cboStoreList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnFilterTrans;
        private System.Windows.Forms.Button btnCancelFilter;
    }
}