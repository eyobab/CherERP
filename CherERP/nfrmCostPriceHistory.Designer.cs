namespace Belayab
{
    partial class nfrmCostPriceHistory
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
            System.Windows.Forms.Label partNumberLabel1;
            this.partNumberComboBox = new System.Windows.Forms.ComboBox();
            this.grdCost = new System.Windows.Forms.DataGridView();
            this.grdPrice = new System.Windows.Forms.DataGridView();
            this.lnkSetPrice = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            partNumberLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // partNumberLabel1
            // 
            partNumberLabel1.AutoSize = true;
            partNumberLabel1.Location = new System.Drawing.Point(3, 35);
            partNumberLabel1.Name = "partNumberLabel1";
            partNumberLabel1.Size = new System.Drawing.Size(27, 13);
            partNumberLabel1.TabIndex = 3;
            partNumberLabel1.Text = "Item";
            // 
            // partNumberComboBox
            // 
            this.partNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.partNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partNumberComboBox.DisplayMember = "Description";
            this.partNumberComboBox.FormattingEnabled = true;
            this.partNumberComboBox.Location = new System.Drawing.Point(36, 32);
            this.partNumberComboBox.Name = "partNumberComboBox";
            this.partNumberComboBox.Size = new System.Drawing.Size(524, 21);
            this.partNumberComboBox.TabIndex = 4;
            this.partNumberComboBox.ValueMember = "ItemID";
            this.partNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.partNumberComboBox_SelectedIndexChanged);
            // 
            // grdCost
            // 
            this.grdCost.AllowUserToAddRows = false;
            this.grdCost.AllowUserToDeleteRows = false;
            this.grdCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCost.Location = new System.Drawing.Point(28, 89);
            this.grdCost.Name = "grdCost";
            this.grdCost.ReadOnly = true;
            this.grdCost.Size = new System.Drawing.Size(279, 173);
            this.grdCost.TabIndex = 5;
            // 
            // grdPrice
            // 
            this.grdPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrice.Location = new System.Drawing.Point(330, 89);
            this.grdPrice.Name = "grdPrice";
            this.grdPrice.ReadOnly = true;
            this.grdPrice.Size = new System.Drawing.Size(268, 173);
            this.grdPrice.TabIndex = 5;
            // 
            // lnkSetPrice
            // 
            this.lnkSetPrice.AutoSize = true;
            this.lnkSetPrice.Location = new System.Drawing.Point(336, 265);
            this.lnkSetPrice.Name = "lnkSetPrice";
            this.lnkSetPrice.Size = new System.Drawing.Size(81, 13);
            this.lnkSetPrice.TabIndex = 25;
            this.lnkSetPrice.TabStop = true;
            this.lnkSetPrice.Text = "Set new price...";
            this.lnkSetPrice.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetPrice_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cost History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Price History";
            // 
            // nfrmCostPriceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkSetPrice);
            this.Controls.Add(this.grdPrice);
            this.Controls.Add(this.grdCost);
            this.Controls.Add(partNumberLabel1);
            this.Controls.Add(this.partNumberComboBox);
            this.Name = "nfrmCostPriceHistory";
            this.Text = "Item Cost and Price History";
            this.Load += new System.EventHandler(this.nfrmCostPriceHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCost;
        private System.Windows.Forms.DataGridView grdPrice;
        public System.Windows.Forms.ComboBox partNumberComboBox;
        private System.Windows.Forms.LinkLabel lnkSetPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}