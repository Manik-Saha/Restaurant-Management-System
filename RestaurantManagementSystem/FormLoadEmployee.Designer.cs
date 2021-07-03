namespace RestaurantManagementSystem
{
    partial class FormLoadEmployee
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
            this.dgvUserInformation = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOINING_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARITAL_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BLOOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserInformation
            // 
            this.dgvUserInformation.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvUserInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.POST,
            this.EMAIL,
            this.PHONE,
            this.GENDER,
            this.DOB,
            this.JOINING_DATE,
            this.MARITAL_STATUS,
            this.BLOOD,
            this.SALARY,
            this.ADDRESS});
            this.dgvUserInformation.GridColor = System.Drawing.Color.Gray;
            this.dgvUserInformation.Location = new System.Drawing.Point(0, 53);
            this.dgvUserInformation.Name = "dgvUserInformation";
            this.dgvUserInformation.Size = new System.Drawing.Size(947, 398);
            this.dgvUserInformation.TabIndex = 0;
            this.dgvUserInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserInformation_CellContentClick);
            this.dgvUserInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserInformation_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "Name";
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            // 
            // POST
            // 
            this.POST.DataPropertyName = "Post";
            this.POST.HeaderText = "POST";
            this.POST.Name = "POST";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "Email";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "Phone";
            this.PHONE.HeaderText = "PHONE";
            this.PHONE.Name = "PHONE";
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "Gender";
            this.GENDER.HeaderText = "GENDER";
            this.GENDER.Name = "GENDER";
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            // 
            // JOINING_DATE
            // 
            this.JOINING_DATE.DataPropertyName = "JoiningDate";
            this.JOINING_DATE.HeaderText = "JOINING_DATE";
            this.JOINING_DATE.Name = "JOINING_DATE";
            // 
            // MARITAL_STATUS
            // 
            this.MARITAL_STATUS.DataPropertyName = "MaritalStatus";
            this.MARITAL_STATUS.HeaderText = "MARITAL_STATUS";
            this.MARITAL_STATUS.Name = "MARITAL_STATUS";
            // 
            // BLOOD
            // 
            this.BLOOD.DataPropertyName = "Blood";
            this.BLOOD.HeaderText = "BLOOD";
            this.BLOOD.Name = "BLOOD";
            // 
            // SALARY
            // 
            this.SALARY.DataPropertyName = "Salary";
            this.SALARY.HeaderText = "SALARY";
            this.SALARY.Name = "SALARY";
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "Address";
            this.ADDRESS.HeaderText = "ADDRESS";
            this.ADDRESS.Name = "ADDRESS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 53);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(640, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 34);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(833, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(103, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(7, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(235, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 35);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Green;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(121, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormLoadEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUserInformation);
            this.Name = "FormLoadEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoadEmployee";
            this.Load += new System.EventHandler(this.FormLoadEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInformation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn POST;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOINING_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARITAL_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BLOOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
    }
}