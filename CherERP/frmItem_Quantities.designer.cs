namespace Belayab
{
    partial class frmItem_Quantities
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
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label qtyDateLabel;
            System.Windows.Forms.Label label2;
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.qtyDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.StoreComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemIdTextBox = new System.Windows.Forms.TextBox();
            this.StoreTextBox = new System.Windows.Forms.TextBox();
            quantityLabel = new System.Windows.Forms.Label();
            qtyDateLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(321, 61);
            quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 3;
            quantityLabel.Text = "Quantity:";
            // 
            // qtyDateLabel
            // 
            qtyDateLabel.AutoSize = true;
            qtyDateLabel.Location = new System.Drawing.Point(33, 106);
            qtyDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            qtyDateLabel.Name = "qtyDateLabel";
            qtyDateLabel.Size = new System.Drawing.Size(68, 17);
            qtyDateLabel.TabIndex = 5;
            qtyDateLabel.Text = "Qty Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 11);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 17);
            label2.TabIndex = 10;
            label2.Text = "Item ID:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(392, 57);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(151, 26);
            this.quantityTextBox.TabIndex = 3;
            // 
            // qtyDateDateTimePicker
            // 
            this.qtyDateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.qtyDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.qtyDateDateTimePicker.Location = new System.Drawing.Point(111, 101);
            this.qtyDateDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.qtyDateDateTimePicker.Name = "qtyDateDateTimePicker";
            this.qtyDateDateTimePicker.Size = new System.Drawing.Size(191, 22);
            this.qtyDateDateTimePicker.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(439, 137);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StoreComboBox
            // 
            this.StoreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreComboBox.FormattingEnabled = true;
            this.StoreComboBox.Location = new System.Drawing.Point(111, 57);
            this.StoreComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StoreComboBox.Name = "StoreComboBox";
            this.StoreComboBox.Size = new System.Drawing.Size(205, 26);
            this.StoreComboBox.TabIndex = 2;
            this.StoreComboBox.SelectedIndexChanged += new System.EventHandler(this.StoreComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Store:";
            // 
            // ItemIdTextBox
            // 
            this.ItemIdTextBox.Location = new System.Drawing.Point(113, 7);
            this.ItemIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemIdTextBox.Name = "ItemIdTextBox";
            this.ItemIdTextBox.ReadOnly = true;
            this.ItemIdTextBox.Size = new System.Drawing.Size(447, 22);
            this.ItemIdTextBox.TabIndex = 0;
            // 
            // StoreTextBox
            // 
            this.StoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreTextBox.Location = new System.Drawing.Point(112, 59);
            this.StoreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StoreTextBox.Name = "StoreTextBox";
            this.StoreTextBox.ReadOnly = true;
            this.StoreTextBox.Size = new System.Drawing.Size(188, 26);
            this.StoreTextBox.TabIndex = 11;
            this.StoreTextBox.Visible = false;
            // 
            // frmItem_Quantities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 224);
            this.Controls.Add(this.StoreTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.ItemIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreComboBox);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(qtyDateLabel);
            this.Controls.Add(this.qtyDateDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmItem_Quantities";
            this.Text = "Item_Quantities";
            this.Load += new System.EventHandler(this.Item_Quantities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker qtyDateDateTimePicker;
        public System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ItemIdTextBox;
        public System.Windows.Forms.ComboBox StoreComboBox;
        private System.Windows.Forms.TextBox StoreTextBox;
    }
}