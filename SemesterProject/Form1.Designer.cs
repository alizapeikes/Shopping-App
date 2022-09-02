namespace SemesterProject
{
    partial class MainMenu
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
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.lbl_errorMessage = new System.Windows.Forms.Label();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_login.SuspendLayout();
            this.pnl_options.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.lbl_errorMessage);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.txt_password);
            this.pnl_login.Controls.Add(this.txt_username);
            this.pnl_login.Controls.Add(this.lbl_password);
            this.pnl_login.Controls.Add(this.lbl_UserName);
            this.pnl_login.Controls.Add(this.LoginLabel);
            this.pnl_login.Location = new System.Drawing.Point(112, 80);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(527, 286);
            this.pnl_login.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(210, 193);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(102, 35);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.login_click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(277, 136);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 26);
            this.txt_password.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(277, 94);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 26);
            this.txt_username.TabIndex = 3;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(170, 142);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(78, 20);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(170, 100);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(83, 20);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "Username";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(190, 40);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(166, 29);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Please Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_errorMessage
            // 
            this.lbl_errorMessage.AutoSize = true;
            this.lbl_errorMessage.Location = new System.Drawing.Point(142, 245);
            this.lbl_errorMessage.Name = "lbl_errorMessage";
            this.lbl_errorMessage.Size = new System.Drawing.Size(0, 20);
            this.lbl_errorMessage.TabIndex = 6;
            this.lbl_errorMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_options
            // 
            this.pnl_options.Controls.Add(this.menuStrip1);
            this.pnl_options.Location = new System.Drawing.Point(12, 12);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(776, 422);
            this.pnl_options.TabIndex = 1;
            this.pnl_options.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsMenu
            // 
            this.optionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseItemToolStripMenuItem,
            this.viewPurchasesToolStripMenuItem,
            this.viewAccountToolStripMenuItem,
            this.payBillToolStripMenuItem});
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(92, 30);
            this.optionsMenu.Text = "Options";
            // 
            // purchaseItemToolStripMenuItem
            // 
            this.purchaseItemToolStripMenuItem.Name = "purchaseItemToolStripMenuItem";
            this.purchaseItemToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.purchaseItemToolStripMenuItem.Text = "Purchase Item";
            this.purchaseItemToolStripMenuItem.Click += new System.EventHandler(this.purchaseItemToolStripMenuItem_Click);
            // 
            // viewPurchasesToolStripMenuItem
            // 
            this.viewPurchasesToolStripMenuItem.Name = "viewPurchasesToolStripMenuItem";
            this.viewPurchasesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewPurchasesToolStripMenuItem.Text = "View Purchases";
            this.viewPurchasesToolStripMenuItem.Click += new System.EventHandler(this.viewPurchasesToolStripMenuItem_Click);
            // 
            // viewAccountToolStripMenuItem
            // 
            this.viewAccountToolStripMenuItem.Name = "viewAccountToolStripMenuItem";
            this.viewAccountToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewAccountToolStripMenuItem.Text = "View Account";
            this.viewAccountToolStripMenuItem.Click += new System.EventHandler(this.viewAccountToolStripMenuItem_Click);
            // 
            // payBillToolStripMenuItem
            // 
            this.payBillToolStripMenuItem.Name = "payBillToolStripMenuItem";
            this.payBillToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.payBillToolStripMenuItem.Text = "Pay Bill";
            this.payBillToolStripMenuItem.Click += new System.EventHandler(this.payBillToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_options);
            this.Controls.Add(this.pnl_login);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.pnl_options.ResumeLayout(false);
            this.pnl_options.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label lbl_errorMessage;
        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payBillToolStripMenuItem;
    }
}

