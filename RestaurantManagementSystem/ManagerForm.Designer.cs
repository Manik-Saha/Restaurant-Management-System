namespace RestaurantManagementSystem
{
    partial class ManagerForm
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
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFinancials = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnManageWaiter = new System.Windows.Forms.Button();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
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
            this.pnlLeft.Size = new System.Drawing.Size(285, 463);
            this.pnlLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbManager);
            this.panel1.Location = new System.Drawing.Point(47, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 235);
            this.panel1.TabIndex = 18;
            // 
            // pbManager
            // 
            this.pbManager.BackgroundImage = global::RestaurantManagementSystem.Properties.Resources.images__3_;
            this.pbManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbManager.Image = global::RestaurantManagementSystem.Properties.Resources.images__3_;
            this.pbManager.Location = new System.Drawing.Point(-5, 0);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(210, 235);
            this.pbManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManager.TabIndex = 6;
            this.pbManager.TabStop = false;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnMyProfile.Location = new System.Drawing.Point(52, 358);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(173, 61);
            this.btnMyProfile.TabIndex = 3;
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
            this.lblDashboard.Size = new System.Drawing.Size(199, 24);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Manager Dashboard";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.lblWelcome);
            this.pnlRight.Controls.Add(this.btnLogOut);
            this.pnlRight.Controls.Add(this.btnFinancials);
            this.pnlRight.Controls.Add(this.btnMenu);
            this.pnlRight.Controls.Add(this.btnViewOrder);
            this.pnlRight.Controls.Add(this.btnTable);
            this.pnlRight.Controls.Add(this.btnManageWaiter);
            this.pnlRight.Controls.Add(this.btnGenerateBill);
            this.pnlRight.Location = new System.Drawing.Point(283, 1);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(785, 463);
            this.pnlRight.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(113, 38);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 23);
            this.lblWelcome.TabIndex = 17;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gold;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(653, 30);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(84, 44);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFinancials
            // 
            this.btnFinancials.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinancials.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinancials.Location = new System.Drawing.Point(276, 237);
            this.btnFinancials.Name = "btnFinancials";
            this.btnFinancials.Size = new System.Drawing.Size(226, 116);
            this.btnFinancials.TabIndex = 13;
            this.btnFinancials.Text = "Finalcals";
            this.btnFinancials.UseVisualStyleBackColor = false;
            this.btnFinancials.Click += new System.EventHandler(this.btnFinancials_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Location = new System.Drawing.Point(34, 237);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(226, 116);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewOrder.Location = new System.Drawing.Point(521, 103);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(226, 116);
            this.btnViewOrder.TabIndex = 11;
            this.btnViewOrder.Text = "Order";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTable.Location = new System.Drawing.Point(276, 103);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(226, 116);
            this.btnTable.TabIndex = 10;
            this.btnTable.Text = "Table";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnManageWaiter
            // 
            this.btnManageWaiter.BackColor = System.Drawing.Color.SeaGreen;
            this.btnManageWaiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWaiter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManageWaiter.Location = new System.Drawing.Point(34, 103);
            this.btnManageWaiter.Name = "btnManageWaiter";
            this.btnManageWaiter.Size = new System.Drawing.Size(226, 116);
            this.btnManageWaiter.TabIndex = 9;
            this.btnManageWaiter.Text = "Manage  Waiter";
            this.btnManageWaiter.UseVisualStyleBackColor = false;
            this.btnManageWaiter.Click += new System.EventHandler(this.btnManageWaiter_Click);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateBill.Location = new System.Drawing.Point(521, 237);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(226, 116);
            this.btnGenerateBill.TabIndex = 8;
            this.btnGenerateBill.Text = "Bill Generate";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 462);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnFinancials;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnManageWaiter;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbManager;
    }
}