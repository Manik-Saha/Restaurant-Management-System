namespace RestaurantManagementSystem
{
    partial class PaymentForm
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.textBoxReturnAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.labelReturnAmount = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelTotalpayment = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonSearchId = new System.Windows.Forms.Button();
            this.textBoxSearchId = new System.Windows.Forms.TextBox();
            this.dataGridViewOrder1 = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotalpayment = new System.Windows.Forms.TextBox();
            this.labelVat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(265, 547);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(64, 21);
            this.buttonClear.TabIndex = 41;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(148, 547);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(111, 21);
            this.buttonPayment.TabIndex = 40;
            this.buttonPayment.Text = "Payment";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // textBoxReturnAmount
            // 
            this.textBoxReturnAmount.Location = new System.Drawing.Point(280, 470);
            this.textBoxReturnAmount.Name = "textBoxReturnAmount";
            this.textBoxReturnAmount.Size = new System.Drawing.Size(85, 20);
            this.textBoxReturnAmount.TabIndex = 39;
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(280, 436);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(85, 20);
            this.textBoxPaidAmount.TabIndex = 38;
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(280, 366);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(85, 20);
            this.textBoxVat.TabIndex = 35;
            // 
            // labelReturnAmount
            // 
            this.labelReturnAmount.AutoSize = true;
            this.labelReturnAmount.Location = new System.Drawing.Point(118, 474);
            this.labelReturnAmount.Name = "labelReturnAmount";
            this.labelReturnAmount.Size = new System.Drawing.Size(78, 13);
            this.labelReturnAmount.TabIndex = 33;
            this.labelReturnAmount.Text = "Return Amount";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Location = new System.Drawing.Point(118, 438);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(67, 13);
            this.labelPaidAmount.TabIndex = 32;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // labelTotalpayment
            // 
            this.labelTotalpayment.AutoSize = true;
            this.labelTotalpayment.Location = new System.Drawing.Point(118, 402);
            this.labelTotalpayment.Name = "labelTotalpayment";
            this.labelTotalpayment.Size = new System.Drawing.Size(74, 13);
            this.labelTotalpayment.TabIndex = 31;
            this.labelTotalpayment.Text = "Total payment";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(118, 335);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 28;
            this.labelTotal.Text = "Total";
            // 
            // buttonSearchId
            // 
            this.buttonSearchId.Location = new System.Drawing.Point(412, 11);
            this.buttonSearchId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearchId.Name = "buttonSearchId";
            this.buttonSearchId.Size = new System.Drawing.Size(56, 19);
            this.buttonSearchId.TabIndex = 42;
            this.buttonSearchId.Text = "Search";
            this.buttonSearchId.UseVisualStyleBackColor = true;
            this.buttonSearchId.Click += new System.EventHandler(this.buttonSearchId_Click);
            // 
            // textBoxSearchId
            // 
            this.textBoxSearchId.Location = new System.Drawing.Point(9, 11);
            this.textBoxSearchId.Name = "textBoxSearchId";
            this.textBoxSearchId.Size = new System.Drawing.Size(387, 20);
            this.textBoxSearchId.TabIndex = 43;
            // 
            // dataGridViewOrder1
            // 
            this.dataGridViewOrder1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder1.Location = new System.Drawing.Point(9, 42);
            this.dataGridViewOrder1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewOrder1.Name = "dataGridViewOrder1";
            this.dataGridViewOrder1.RowHeadersWidth = 51;
            this.dataGridViewOrder1.RowTemplate.Height = 24;
            this.dataGridViewOrder1.Size = new System.Drawing.Size(515, 258);
            this.dataGridViewOrder1.TabIndex = 44;
            this.dataGridViewOrder1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder1_CellClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(334, 547);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(64, 21);
            this.buttonBack.TabIndex = 45;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(280, 335);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(85, 20);
            this.textBoxTotal.TabIndex = 46;
            // 
            // textBoxTotalpayment
            // 
            this.textBoxTotalpayment.Location = new System.Drawing.Point(280, 400);
            this.textBoxTotalpayment.Name = "textBoxTotalpayment";
            this.textBoxTotalpayment.Size = new System.Drawing.Size(85, 20);
            this.textBoxTotalpayment.TabIndex = 47;
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(118, 370);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(46, 13);
            this.labelVat.TabIndex = 29;
            this.labelVat.Text = "Vat 10%";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(535, 581);
            this.Controls.Add(this.textBoxTotalpayment);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewOrder1);
            this.Controls.Add(this.textBoxSearchId);
            this.Controls.Add(this.buttonSearchId);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textBoxReturnAmount);
            this.Controls.Add(this.textBoxPaidAmount);
            this.Controls.Add(this.textBoxVat);
            this.Controls.Add(this.labelReturnAmount);
            this.Controls.Add(this.labelPaidAmount);
            this.Controls.Add(this.labelTotalpayment);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelTotal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textBoxReturnAmount;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label labelReturnAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelTotalpayment;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonSearchId;
        private System.Windows.Forms.TextBox textBoxSearchId;
        private System.Windows.Forms.DataGridView dataGridViewOrder1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxTotalpayment;
        private System.Windows.Forms.Label labelVat;
    }
}