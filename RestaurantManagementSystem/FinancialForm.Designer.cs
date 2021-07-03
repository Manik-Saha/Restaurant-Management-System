namespace RestaurantManagementSystem
{
    partial class FinancialForm
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
            this.buttonTotalSalesPrice = new System.Windows.Forms.Button();
            this.dataGridViewFinancial = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTotalSalesPrice = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancial)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTotalSalesPrice
            // 
            this.buttonTotalSalesPrice.BackColor = System.Drawing.Color.Honeydew;
            this.buttonTotalSalesPrice.Location = new System.Drawing.Point(361, 346);
            this.buttonTotalSalesPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTotalSalesPrice.Name = "buttonTotalSalesPrice";
            this.buttonTotalSalesPrice.Size = new System.Drawing.Size(139, 26);
            this.buttonTotalSalesPrice.TabIndex = 0;
            this.buttonTotalSalesPrice.Text = "Total Sales Price";
            this.buttonTotalSalesPrice.UseVisualStyleBackColor = false;
            this.buttonTotalSalesPrice.Click += new System.EventHandler(this.buttonTotalSalesPrice_Click);
            // 
            // dataGridViewFinancial
            // 
            this.dataGridViewFinancial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFinancial.Location = new System.Drawing.Point(248, 63);
            this.dataGridViewFinancial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFinancial.Name = "dataGridViewFinancial";
            this.dataGridViewFinancial.RowHeadersWidth = 51;
            this.dataGridViewFinancial.RowTemplate.Height = 24;
            this.dataGridViewFinancial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFinancial.Size = new System.Drawing.Size(514, 258);
            this.dataGridViewFinancial.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(700, 413);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(62, 32);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTotalSalesPrice
            // 
            this.labelTotalSalesPrice.AutoSize = true;
            this.labelTotalSalesPrice.BackColor = System.Drawing.Color.White;
            this.labelTotalSalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalSalesPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotalSalesPrice.Location = new System.Drawing.Point(561, 346);
            this.labelTotalSalesPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalSalesPrice.Name = "labelTotalSalesPrice";
            this.labelTotalSalesPrice.Size = new System.Drawing.Size(60, 24);
            this.labelTotalSalesPrice.TabIndex = 4;
            this.labelTotalSalesPrice.Text = "label1";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(59, 292);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 29);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(674, 10);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(88, 32);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "Logout";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(24, 97);
            this.dateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerFromDate.TabIndex = 7;
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(24, 208);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(191, 20);
            this.dateTimePickerToDate.TabIndex = 8;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromDate.Location = new System.Drawing.Point(24, 50);
            this.labelFromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(83, 17);
            this.labelFromDate.TabIndex = 9;
            this.labelFromDate.Text = "From Date";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToDate.Location = new System.Drawing.Point(24, 158);
            this.labelToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(66, 17);
            this.labelToDate.TabIndex = 10;
            this.labelToDate.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(611, 413);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(62, 32);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FinancialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(778, 471);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelToDate);
            this.Controls.Add(this.labelFromDate);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTotalSalesPrice);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewFinancial);
            this.Controls.Add(this.buttonTotalSalesPrice);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FinancialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinancialFrom";
            this.Load += new System.EventHandler(this.FinancialFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFinancial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTotalSalesPrice;
        private System.Windows.Forms.DataGridView dataGridViewFinancial;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTotalSalesPrice;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
    }
}