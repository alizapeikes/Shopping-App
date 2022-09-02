namespace SemesterProject
{
    partial class PayBill
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
            this.lbl_enterAmount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.lbl_CreditLimit = new System.Windows.Forms.Label();
            this.lbl_availCredit = new System.Windows.Forms.Label();
            this.btn_payBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_enterAmount
            // 
            this.lbl_enterAmount.AutoSize = true;
            this.lbl_enterAmount.Location = new System.Drawing.Point(228, 274);
            this.lbl_enterAmount.Name = "lbl_enterAmount";
            this.lbl_enterAmount.Size = new System.Drawing.Size(335, 20);
            this.lbl_enterAmount.TabIndex = 0;
            this.lbl_enterAmount.Text = "Please enter the amount you would like to pay:";
            // 
            // txt_amount
            // 
            this.txt_amount.AcceptsReturn = true;
            this.txt_amount.Location = new System.Drawing.Point(292, 318);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(216, 26);
            this.txt_amount.TabIndex = 1;
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Location = new System.Drawing.Point(405, 185);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(0, 20);
            this.lbl_balance.TabIndex = 2;
            // 
            // lbl_CreditLimit
            // 
            this.lbl_CreditLimit.AutoSize = true;
            this.lbl_CreditLimit.Location = new System.Drawing.Point(405, 90);
            this.lbl_CreditLimit.Name = "lbl_CreditLimit";
            this.lbl_CreditLimit.Size = new System.Drawing.Size(0, 20);
            this.lbl_CreditLimit.TabIndex = 3;
            // 
            // lbl_availCredit
            // 
            this.lbl_availCredit.AutoSize = true;
            this.lbl_availCredit.Location = new System.Drawing.Point(405, 139);
            this.lbl_availCredit.Name = "lbl_availCredit";
            this.lbl_availCredit.Size = new System.Drawing.Size(0, 20);
            this.lbl_availCredit.TabIndex = 4;
            // 
            // btn_payBill
            // 
            this.btn_payBill.Location = new System.Drawing.Point(351, 355);
            this.btn_payBill.Name = "btn_payBill";
            this.btn_payBill.Size = new System.Drawing.Size(103, 34);
            this.btn_payBill.TabIndex = 5;
            this.btn_payBill.Text = "Pay Bill";
            this.btn_payBill.UseVisualStyleBackColor = true;
            this.btn_payBill.Click += new System.EventHandler(this.btn_payBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Credit Limit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Available Credit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Balance:";
            // 
            // PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_payBill);
            this.Controls.Add(this.lbl_availCredit);
            this.Controls.Add(this.lbl_CreditLimit);
            this.Controls.Add(this.lbl_balance);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.lbl_enterAmount);
            this.Name = "PayBill";
            this.Text = "PayBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_enterAmount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_CreditLimit;
        private System.Windows.Forms.Label lbl_availCredit;
        private System.Windows.Forms.Button btn_payBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}