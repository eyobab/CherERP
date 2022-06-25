namespace Belayab
{
    partial class frmDataImport
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
            System.Windows.Forms.Label itemPriceIDLabel;
            this.txtSourcefile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnProcessImport = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBalances = new System.Windows.Forms.CheckBox();
            this.chkItems = new System.Windows.Forms.CheckBox();
            this.lblBalMessage = new System.Windows.Forms.Label();
            this.prgImport = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.tabType = new System.Windows.Forms.TabControl();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.tabPagePrice = new System.Windows.Forms.TabPage();
            this.itemPriceIDTextBox = new System.Windows.Forms.TextBox();
            itemPriceIDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.tabPagePrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSourcefile
            // 
            this.txtSourcefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourcefile.Location = new System.Drawing.Point(8, 94);
            this.txtSourcefile.Margin = new System.Windows.Forms.Padding(2);
            this.txtSourcefile.Name = "txtSourcefile";
            this.txtSourcefile.ReadOnly = true;
            this.txtSourcefile.Size = new System.Drawing.Size(355, 21);
            this.txtSourcefile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(364, 93);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ExcelSource";
            // 
            // btnProcessImport
            // 
            this.btnProcessImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessImport.Location = new System.Drawing.Point(8, 118);
            this.btnProcessImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessImport.Name = "btnProcessImport";
            this.btnProcessImport.Size = new System.Drawing.Size(86, 24);
            this.btnProcessImport.TabIndex = 4;
            this.btnProcessImport.Text = "Process";
            this.btnProcessImport.UseVisualStyleBackColor = true;
            this.btnProcessImport.Click += new System.EventHandler(this.btnProcessImport_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(15, 163);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "  ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(280, 180);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBalances);
            this.groupBox1.Controls.Add(this.chkItems);
            this.groupBox1.Location = new System.Drawing.Point(14, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Include";
            // 
            // chkBalances
            // 
            this.chkBalances.AutoSize = true;
            this.chkBalances.Location = new System.Drawing.Point(113, 17);
            this.chkBalances.Margin = new System.Windows.Forms.Padding(2);
            this.chkBalances.Name = "chkBalances";
            this.chkBalances.Size = new System.Drawing.Size(70, 17);
            this.chkBalances.TabIndex = 1;
            this.chkBalances.Text = "Balances";
            this.chkBalances.UseVisualStyleBackColor = true;
            // 
            // chkItems
            // 
            this.chkItems.AutoSize = true;
            this.chkItems.Location = new System.Drawing.Point(44, 17);
            this.chkItems.Margin = new System.Windows.Forms.Padding(2);
            this.chkItems.Name = "chkItems";
            this.chkItems.Size = new System.Drawing.Size(51, 17);
            this.chkItems.TabIndex = 0;
            this.chkItems.Text = "Items";
            this.chkItems.UseVisualStyleBackColor = true;
            // 
            // lblBalMessage
            // 
            this.lblBalMessage.AutoSize = true;
            this.lblBalMessage.Location = new System.Drawing.Point(24, 177);
            this.lblBalMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalMessage.Name = "lblBalMessage";
            this.lblBalMessage.Size = new System.Drawing.Size(13, 13);
            this.lblBalMessage.TabIndex = 8;
            this.lblBalMessage.Text = "  ";
            // 
            // prgImport
            // 
            this.prgImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prgImport.Location = new System.Drawing.Point(0, 194);
            this.prgImport.Margin = new System.Windows.Forms.Padding(2);
            this.prgImport.Maximum = 15000;
            this.prgImport.Name = "prgImport";
            this.prgImport.Size = new System.Drawing.Size(448, 19);
            this.prgImport.Step = 50;
            this.prgImport.TabIndex = 9;
            this.prgImport.UseWaitCursor = true;
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(105, 125);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 13);
            this.lblPercent.TabIndex = 10;
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.tabPageItems);
            this.tabType.Controls.Add(this.tabPagePrice);
            this.tabType.Location = new System.Drawing.Point(56, 5);
            this.tabType.Name = "tabType";
            this.tabType.SelectedIndex = 0;
            this.tabType.Size = new System.Drawing.Size(237, 84);
            this.tabType.TabIndex = 11;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.groupBox1);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(229, 58);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // tabPagePrice
            // 
            this.tabPagePrice.Controls.Add(itemPriceIDLabel);
            this.tabPagePrice.Controls.Add(this.itemPriceIDTextBox);
            this.tabPagePrice.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrice.Name = "tabPagePrice";
            this.tabPagePrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrice.Size = new System.Drawing.Size(229, 58);
            this.tabPagePrice.TabIndex = 1;
            this.tabPagePrice.Text = "Prices";
            this.tabPagePrice.UseVisualStyleBackColor = true;
            // 
            // itemPriceIDLabel
            // 
            itemPriceIDLabel.AutoSize = true;
            itemPriceIDLabel.Location = new System.Drawing.Point(4, 18);
            itemPriceIDLabel.Name = "itemPriceIDLabel";
            itemPriceIDLabel.Size = new System.Drawing.Size(71, 13);
            itemPriceIDLabel.TabIndex = 100;
            itemPriceIDLabel.Text = "Item Price ID:";
            // 
            // itemPriceIDTextBox
            // 
            this.itemPriceIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceIDTextBox.Location = new System.Drawing.Point(95, 15);
            this.itemPriceIDTextBox.Name = "itemPriceIDTextBox";
            this.itemPriceIDTextBox.ReadOnly = true;
            this.itemPriceIDTextBox.Size = new System.Drawing.Size(116, 22);
            this.itemPriceIDTextBox.TabIndex = 101;
            // 
            // frmDataImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 213);
            this.Controls.Add(this.tabType);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.prgImport);
            this.Controls.Add(this.lblBalMessage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnProcessImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSourcefile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmDataImport";
            this.Text = "Data Import Processor";
            this.Load += new System.EventHandler(this.frmDataImport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.tabPagePrice.ResumeLayout(false);
            this.tabPagePrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourcefile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnProcessImport;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBalances;
        private System.Windows.Forms.CheckBox chkItems;
        private System.Windows.Forms.Label lblBalMessage;
        private System.Windows.Forms.ProgressBar prgImport;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPagePrice;
        public System.Windows.Forms.TextBox itemPriceIDTextBox;
        public System.Windows.Forms.TabControl tabType;
    }
}