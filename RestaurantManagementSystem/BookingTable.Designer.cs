namespace RestaurantManagementSystem
{
    partial class BookingTable
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
            this.deletebttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTableType = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.txtSpecialRequest = new System.Windows.Forms.RichTextBox();
            this.cmbNoOfGuest = new System.Windows.Forms.ComboBox();
            this.cmbTableType = new System.Windows.Forms.ComboBox();
            this.updatebttn = new System.Windows.Forms.Button();
            this.insertbttn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvBookingInfo = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.bookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_CONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMER_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER_Of_GUEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPECIAL_REQUEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebttn
            // 
            this.deletebttn.BackColor = System.Drawing.Color.DarkRed;
            this.deletebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebttn.ForeColor = System.Drawing.Color.White;
            this.deletebttn.Location = new System.Drawing.Point(872, 20);
            this.deletebttn.Name = "deletebttn";
            this.deletebttn.Size = new System.Drawing.Size(78, 31);
            this.deletebttn.TabIndex = 0;
            this.deletebttn.Text = "Delete";
            this.deletebttn.UseVisualStyleBackColor = false;
            this.deletebttn.Click += new System.EventHandler(this.deletebttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Your Table";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(314, 19);
            this.txtName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(28, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelTableType
            // 
            this.labelTableType.AutoSize = true;
            this.labelTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableType.Location = new System.Drawing.Point(28, 138);
            this.labelTableType.Name = "labelTableType";
            this.labelTableType.Size = new System.Drawing.Size(86, 20);
            this.labelTableType.TabIndex = 4;
            this.labelTableType.Text = "Table Type";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(28, 75);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(53, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "No. of guests";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Arrival Date & Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contact  No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Special Request";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(223, 326);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(314, 19);
            this.txtContact.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(223, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 19);
            this.txtEmail.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpArrival);
            this.panel1.Controls.Add(this.txtSpecialRequest);
            this.panel1.Controls.Add(this.cmbNoOfGuest);
            this.panel1.Controls.Add(this.cmbTableType);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.labelTableType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Location = new System.Drawing.Point(26, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 504);
            this.panel1.TabIndex = 15;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Location = new System.Drawing.Point(233, 262);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(304, 19);
            this.dtpArrival.TabIndex = 18;
            // 
            // txtSpecialRequest
            // 
            this.txtSpecialRequest.Location = new System.Drawing.Point(223, 377);
            this.txtSpecialRequest.Name = "txtSpecialRequest";
            this.txtSpecialRequest.Size = new System.Drawing.Size(314, 96);
            this.txtSpecialRequest.TabIndex = 17;
            this.txtSpecialRequest.Text = "";
            // 
            // cmbNoOfGuest
            // 
            this.cmbNoOfGuest.FormattingEnabled = true;
            this.cmbNoOfGuest.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbNoOfGuest.Location = new System.Drawing.Point(223, 202);
            this.cmbNoOfGuest.Name = "cmbNoOfGuest";
            this.cmbNoOfGuest.Size = new System.Drawing.Size(314, 21);
            this.cmbNoOfGuest.TabIndex = 16;
            // 
            // cmbTableType
            // 
            this.cmbTableType.FormattingEnabled = true;
            this.cmbTableType.Items.AddRange(new object[] {
            "For Single",
            "For 2 & More",
            "For 5 Member",
            "For 6 Member or More"});
            this.cmbTableType.Location = new System.Drawing.Point(223, 139);
            this.cmbTableType.Name = "cmbTableType";
            this.cmbTableType.Size = new System.Drawing.Size(314, 21);
            this.cmbTableType.TabIndex = 15;
            // 
            // updatebttn
            // 
            this.updatebttn.BackColor = System.Drawing.Color.White;
            this.updatebttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebttn.Location = new System.Drawing.Point(787, 20);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(79, 31);
            this.updatebttn.TabIndex = 16;
            this.updatebttn.Text = "Update";
            this.updatebttn.UseVisualStyleBackColor = false;
            this.updatebttn.Click += new System.EventHandler(this.updatebttn_Click);
            // 
            // insertbttn
            // 
            this.insertbttn.BackColor = System.Drawing.Color.Green;
            this.insertbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertbttn.ForeColor = System.Drawing.Color.White;
            this.insertbttn.Location = new System.Drawing.Point(654, 20);
            this.insertbttn.Name = "insertbttn";
            this.insertbttn.Size = new System.Drawing.Size(127, 31);
            this.insertbttn.TabIndex = 17;
            this.insertbttn.Text = "Confirm Booking";
            this.insertbttn.UseVisualStyleBackColor = false;
            this.insertbttn.Click += new System.EventHandler(this.insertbttn_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(956, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 31);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvBookingInfo
            // 
            this.dgvBookingInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookingInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingID,
            this.CUSTOMER_NAME,
            this.CUSTOMER_CONTACT,
            this.CUSTOMER_EMAIL,
            this.TYPE,
            this.NUMBER_Of_GUEST,
            this.DATE,
            this.SPECIAL_REQUEST});
            this.dgvBookingInfo.Location = new System.Drawing.Point(660, 71);
            this.dgvBookingInfo.Name = "dgvBookingInfo";
            this.dgvBookingInfo.Size = new System.Drawing.Size(391, 504);
            this.dgvBookingInfo.TabIndex = 19;
            this.dgvBookingInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingInfo_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(562, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(346, 20);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(210, 31);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.White;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(274, 595);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(188, 41);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // bookingID
            // 
            this.bookingID.DataPropertyName = "bookingID";
            this.bookingID.HeaderText = "BOOKING ID";
            this.bookingID.Name = "bookingID";
            // 
            // CUSTOMER_NAME
            // 
            this.CUSTOMER_NAME.DataPropertyName = "Name";
            this.CUSTOMER_NAME.HeaderText = "CUSTOMER_NAME";
            this.CUSTOMER_NAME.Name = "CUSTOMER_NAME";
            // 
            // CUSTOMER_CONTACT
            // 
            this.CUSTOMER_CONTACT.DataPropertyName = "Contact";
            this.CUSTOMER_CONTACT.HeaderText = "CUSTOMER_CONTACT";
            this.CUSTOMER_CONTACT.Name = "CUSTOMER_CONTACT";
            // 
            // CUSTOMER_EMAIL
            // 
            this.CUSTOMER_EMAIL.DataPropertyName = "Email";
            this.CUSTOMER_EMAIL.HeaderText = "CUSTOMER_EMAIL";
            this.CUSTOMER_EMAIL.Name = "CUSTOMER_EMAIL";
            // 
            // TYPE
            // 
            this.TYPE.DataPropertyName = "type";
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.Name = "TYPE";
            // 
            // NUMBER_Of_GUEST
            // 
            this.NUMBER_Of_GUEST.DataPropertyName = "NoOfGuest";
            this.NUMBER_Of_GUEST.HeaderText = "NUMBER_Of_GUEST";
            this.NUMBER_Of_GUEST.Name = "NUMBER_Of_GUEST";
            // 
            // DATE
            // 
            this.DATE.DataPropertyName = "Date";
            this.DATE.HeaderText = "DATE";
            this.DATE.Name = "DATE";
            // 
            // SPECIAL_REQUEST
            // 
            this.SPECIAL_REQUEST.DataPropertyName = "Request";
            this.SPECIAL_REQUEST.HeaderText = "SPECIAL_REQUEST";
            this.SPECIAL_REQUEST.Name = "SPECIAL_REQUEST";
            // 
            // BookingTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1099, 659);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBookingInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.insertbttn);
            this.Controls.Add(this.updatebttn);
            this.Controls.Add(this.deletebttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "BookingTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingTable";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTableType;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.Button insertbttn;
        private System.Windows.Forms.ComboBox cmbTableType;
        private System.Windows.Forms.ComboBox cmbNoOfGuest;
        private System.Windows.Forms.RichTextBox txtSpecialRequest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.DataGridView dgvBookingInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_CONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER_Of_GUEST;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPECIAL_REQUEST;
    }
}