namespace RestaurantManagementSystem
{
    partial class AdminForm
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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFinancials = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnManageWaiter = new System.Windows.Forms.Button();
            this.btnManageManager = new System.Windows.Forms.Button();
            this.btnManageAdmin = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.btnMyProfile);
            this.pnlLeft.Controls.Add(this.lblDashboard);
            this.pnlLeft.Location = new System.Drawing.Point(0, 1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(285, 476);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAdmin);
            this.panel1.Location = new System.Drawing.Point(38, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 235);
            this.panel1.TabIndex = 17;
            // 
            // pbAdmin
            // 
            this.pbAdmin.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.images__2_;
            this.pbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAdmin.Image = global::RestaurantManagementSystem.Properties.Resources.images__2_;
            this.pbAdmin.Location = new System.Drawing.Point(-5, 0);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(210, 235);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdmin.TabIndex = 6;
            this.pbAdmin.TabStop = false;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnMyProfile.Location = new System.Drawing.Point(52, 344);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(173, 61);
            this.btnMyProfile.TabIndex = 2;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(48, 31);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(177, 24);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Admin Dashboard";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.btnPayment);
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.btnLogOut);
            this.pnlRight.Controls.Add(this.btnFinancials);
            this.pnlRight.Controls.Add(this.btnMenu);
            this.pnlRight.Controls.Add(this.btnOrder);
            this.pnlRight.Controls.Add(this.btnTable);
            this.pnlRight.Controls.Add(this.btnManageWaiter);
            this.pnlRight.Controls.Add(this.btnManageManager);
            this.pnlRight.Controls.Add(this.btnManageAdmin);
            this.pnlRight.Controls.Add(this.btnAddEmployee);
            this.pnlRight.Location = new System.Drawing.Point(283, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(785, 476);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(96, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 23);
            this.lblWelcome.TabIndex = 16;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(686, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 44);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFinancials
            // 
            this.btnFinancials.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinancials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinancials.Location = new System.Drawing.Point(276, 302);
            this.btnFinancials.Name = "btnFinancials";
            this.btnFinancials.Size = new System.Drawing.Size(226, 116);
            this.btnFinancials.TabIndex = 13;
            this.btnFinancials.Text = "Finalcals";
            this.btnFinancials.UseVisualStyleBackColor = false;
            this.btnFinancials.Click += new System.EventHandler(this.btnFinancials_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Location = new System.Drawing.Point(34, 302);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(226, 116);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOrder.Location = new System.Drawing.Point(521, 180);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(226, 116);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTable.Location = new System.Drawing.Point(276, 180);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(226, 116);
            this.btnTable.TabIndex = 10;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnManageWaiter
            // 
            this.btnManageWaiter.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWaiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageWaiter.Location = new System.Drawing.Point(34, 180);
            this.btnManageWaiter.Name = "btnManageWaiter";
            this.btnManageWaiter.Size = new System.Drawing.Size(226, 116);
            this.btnManageWaiter.TabIndex = 9;
            this.btnManageWaiter.Text = "Manage  Waiter";
            this.btnManageWaiter.UseVisualStyleBackColor = false;
            this.btnManageWaiter.Click += new System.EventHandler(this.btnManageWaiter_Click);
            // 
            // btnManageManager
            // 
            this.btnManageManager.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageManager.Location = new System.Drawing.Point(521, 58);
            this.btnManageManager.Name = "btnManageManager";
            this.btnManageManager.Size = new System.Drawing.Size(226, 116);
            this.btnManageManager.TabIndex = 8;
            this.btnManageManager.Text = "Manage  Manager";
            this.btnManageManager.UseVisualStyleBackColor = false;
            this.btnManageManager.Click += new System.EventHandler(this.btnManageManager_Click);
            // 
            // btnManageAdmin
            // 
            this.btnManageAdmin.BackColor = System.Drawing.Color.ForestGreen;
            this.btnManageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAdmin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageAdmin.Location = new System.Drawing.Point(276, 58);
            this.btnManageAdmin.Name = "btnManageAdmin";
            this.btnManageAdmin.Size = new System.Drawing.Size(226, 116);
            this.btnManageAdmin.TabIndex = 3;
            this.btnManageAdmin.Text = "Manage  Admin";
            this.btnManageAdmin.UseVisualStyleBackColor = false;
            this.btnManageAdmin.Click += new System.EventHandler(this.btnManageAdmin_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee.Location = new System.Drawing.Point(34, 58);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(226, 116);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayment.Location = new System.Drawing.Point(521, 302);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(226, 116);
            this.btnPayment.TabIndex = 17;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 477);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnManageAdmin;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnFinancials;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnManageWaiter;
        private System.Windows.Forms.Button btnManageManager;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Button btnPayment;
    }
}