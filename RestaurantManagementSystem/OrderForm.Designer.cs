namespace RestaurantManagementSystem
{
    partial class OrderForm
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
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.labelProName = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.textProName = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOrderClear = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(667, 64);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(86, 15);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Product Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(667, 137);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(667, 215);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(51, 15);
            this.labelQuantity.TabIndex = 3;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(667, 303);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // textSearchBox
            // 
            this.textSearchBox.Location = new System.Drawing.Point(13, 56);
            this.textSearchBox.Margin = new System.Windows.Forms.Padding(4);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(506, 21);
            this.textSearchBox.TabIndex = 5;
            this.textSearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewMenu1
            // 
            this.dataGridViewMenu1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu1.Location = new System.Drawing.Point(13, 115);
            this.dataGridViewMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMenu1.Name = "dataGridViewMenu1";
            this.dataGridViewMenu1.RowHeadersWidth = 51;
            this.dataGridViewMenu1.RowTemplate.Height = 24;
            this.dataGridViewMenu1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu1.Size = new System.Drawing.Size(629, 293);
            this.dataGridViewMenu1.TabIndex = 6;
            this.dataGridViewMenu1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu1_CellClick);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(13, 478);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(629, 272);
            this.dataGridViewOrder.TabIndex = 7;
            this.dataGridViewOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellClick);
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(829, 64);
            this.textProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(184, 21);
            this.textProductName.TabIndex = 8;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(829, 137);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(184, 21);
            this.textPrice.TabIndex = 9;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(829, 215);
            this.textQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(184, 21);
            this.textQuantity.TabIndex = 10;
            this.textQuantity.TextChanged += new System.EventHandler(this.textQuantity_TextChanged);
            // 
            // textTotalPrice
            // 
            this.textTotalPrice.Location = new System.Drawing.Point(829, 303);
            this.textTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textTotalPrice.Name = "textTotalPrice";
            this.textTotalPrice.Size = new System.Drawing.Size(184, 21);
            this.textTotalPrice.TabIndex = 11;
            this.textTotalPrice.TextChanged += new System.EventHandler(this.textTotalPrice_TextChanged);
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalPrice.Location = new System.Drawing.Point(665, 380);
            this.buttonTotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(163, 26);
            this.buttonTotalPrice.TabIndex = 12;
            this.buttonTotalPrice.Text = "Total Price";
            this.buttonTotalPrice.UseVisualStyleBackColor = true;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToOrder.Location = new System.Drawing.Point(840, 380);
            this.buttonAddToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(163, 26);
            this.buttonAddToOrder.TabIndex = 13;
            this.buttonAddToOrder.Text = "Add To Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.buttonAddToOrder_Click);
            // 
            // labelProName
            // 
            this.labelProName.AutoSize = true;
            this.labelProName.Location = new System.Drawing.Point(667, 500);
            this.labelProName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProName.Name = "labelProName";
            this.labelProName.Size = new System.Drawing.Size(86, 15);
            this.labelProName.TabIndex = 14;
            this.labelProName.Text = "Product Name";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(667, 600);
            this.labelTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(79, 15);
            this.labelTotalAmount.TabIndex = 15;
            this.labelTotalAmount.Text = "Total Amount";
            this.labelTotalAmount.Click += new System.EventHandler(this.labelTotalAmount_Click);
            // 
            // textProName
            // 
            this.textProName.Location = new System.Drawing.Point(881, 500);
            this.textProName.Margin = new System.Windows.Forms.Padding(4);
            this.textProName.Name = "textProName";
            this.textProName.Size = new System.Drawing.Size(194, 21);
            this.textProName.TabIndex = 20;
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(881, 597);
            this.textBoxTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.Size = new System.Drawing.Size(194, 21);
            this.textBoxTotalAmount.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(762, 693);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(85, 26);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(544, 54);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 28);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1019, 380);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 26);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOrderClear
            // 
            this.buttonOrderClear.Location = new System.Drawing.Point(871, 693);
            this.buttonOrderClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderClear.Name = "buttonOrderClear";
            this.buttonOrderClear.Size = new System.Drawing.Size(85, 26);
            this.buttonOrderClear.TabIndex = 30;
            this.buttonOrderClear.Text = "Clear";
            this.buttonOrderClear.UseVisualStyleBackColor = true;
            this.buttonOrderClear.Click += new System.EventHandler(this.buttonOrderClear_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(990, 693);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(85, 26);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1051, 10);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(85, 26);
            this.buttonLogout.TabIndex = 32;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(730, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 21);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(667, 18);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 15);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "Date";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 749);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOrderClear);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.textProName);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.labelProName);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.buttonTotalPrice);
            this.Controls.Add(this.textTotalPrice);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewMenu1);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelProductName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.DataGridView dataGridViewMenu1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textTotalPrice;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Label labelProName;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.TextBox textProName;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOrderClear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDate;
    }
}