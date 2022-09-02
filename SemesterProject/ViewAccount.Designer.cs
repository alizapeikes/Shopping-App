namespace SemesterProject
{
    partial class ViewAccount
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
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_creditLimit = new System.Windows.Forms.Label();
            this.lbl_currBalance = new System.Windows.Forms.Label();
            this.lbl_availCredit = new System.Windows.Forms.Label();
            this.lbl_accountInfo = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.Credit = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.availCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(426, 173);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(51, 20);
            this.lbl_user.TabIndex = 0;
            this.lbl_user.Text = "label1";
            // 
            // lbl_creditLimit
            // 
            this.lbl_creditLimit.AutoSize = true;
            this.lbl_creditLimit.Location = new System.Drawing.Point(426, 212);
            this.lbl_creditLimit.Name = "lbl_creditLimit";
            this.lbl_creditLimit.Size = new System.Drawing.Size(51, 20);
            this.lbl_creditLimit.TabIndex = 1;
            this.lbl_creditLimit.Text = "label2";
            // 
            // lbl_currBalance
            // 
            this.lbl_currBalance.AutoSize = true;
            this.lbl_currBalance.Location = new System.Drawing.Point(426, 251);
            this.lbl_currBalance.Name = "lbl_currBalance";
            this.lbl_currBalance.Size = new System.Drawing.Size(51, 20);
            this.lbl_currBalance.TabIndex = 2;
            this.lbl_currBalance.Text = "label3";
            // 
            // lbl_availCredit
            // 
            this.lbl_availCredit.AutoSize = true;
            this.lbl_availCredit.Location = new System.Drawing.Point(426, 291);
            this.lbl_availCredit.Name = "lbl_availCredit";
            this.lbl_availCredit.Size = new System.Drawing.Size(51, 20);
            this.lbl_availCredit.TabIndex = 3;
            this.lbl_availCredit.Text = "label3";
            // 
            // lbl_accountInfo
            // 
            this.lbl_accountInfo.AutoSize = true;
            this.lbl_accountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accountInfo.Location = new System.Drawing.Point(286, 115);
            this.lbl_accountInfo.MinimumSize = new System.Drawing.Size(2, 2);
            this.lbl_accountInfo.Name = "lbl_accountInfo";
            this.lbl_accountInfo.Size = new System.Drawing.Size(242, 29);
            this.lbl_accountInfo.TabIndex = 4;
            this.lbl_accountInfo.Text = "Account Information";
            this.lbl_accountInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(312, 173);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 20);
            this.username.TabIndex = 5;
            this.username.Text = "Username: ";
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Location = new System.Drawing.Point(311, 212);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(92, 20);
            this.Credit.TabIndex = 6;
            this.Credit.Text = "Credit Limit:";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(274, 251);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(128, 20);
            this.balance.TabIndex = 7;
            this.balance.Text = "Current Balance:";
            // 
            // availCredit
            // 
            this.availCredit.AutoSize = true;
            this.availCredit.Location = new System.Drawing.Point(277, 291);
            this.availCredit.Name = "availCredit";
            this.availCredit.Size = new System.Drawing.Size(126, 20);
            this.availCredit.TabIndex = 8;
            this.availCredit.Text = "Available Credit: ";
            // 
            // ViewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.availCredit);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lbl_accountInfo);
            this.Controls.Add(this.lbl_availCredit);
            this.Controls.Add(this.lbl_currBalance);
            this.Controls.Add(this.lbl_creditLimit);
            this.Controls.Add(this.lbl_user);
            this.Name = "ViewAccount";
            this.Text = "ViewAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_creditLimit;
        private System.Windows.Forms.Label lbl_currBalance;
        private System.Windows.Forms.Label lbl_availCredit;
        private System.Windows.Forms.Label lbl_accountInfo;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label availCredit;
    }
}