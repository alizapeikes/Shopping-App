namespace SemesterProject
{
    partial class ViewPurchases
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PurchaseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.numeric_start = new System.Windows.Forms.NumericUpDown();
            this.numeric_end = new System.Windows.Forms.NumericUpDown();
            this.pnl_priceRange = new System.Windows.Forms.Panel();
            this.btn_refreshPrice = new System.Windows.Forms.Button();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.pnl_dates = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.lbl_pickDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).BeginInit();
            this.pnl_priceRange.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.pnl_dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PurchaseID,
            this.Item,
            this.UnitPrice,
            this.Quantity,
            this.Total,
            this.Date});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PurchaseID
            // 
            this.PurchaseID.Text = "Purchase ID";
            this.PurchaseID.Width = 85;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 85;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.Width = 85;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 85;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 85;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 85;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "All Purchases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Specific Dates";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Specific Price Range";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "View Purchases";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(26, 31);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(146, 20);
            this.lbl_question.TabIndex = 7;
            this.lbl_question.Text = "Please Pick Range:";
            // 
            // numeric_start
            // 
            this.numeric_start.Location = new System.Drawing.Point(208, 29);
            this.numeric_start.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_start.Name = "numeric_start";
            this.numeric_start.Size = new System.Drawing.Size(120, 26);
            this.numeric_start.TabIndex = 8;
            this.numeric_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeric_end
            // 
            this.numeric_end.Location = new System.Drawing.Point(360, 29);
            this.numeric_end.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_end.Name = "numeric_end";
            this.numeric_end.Size = new System.Drawing.Size(120, 26);
            this.numeric_end.TabIndex = 9;
            this.numeric_end.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnl_priceRange
            // 
            this.pnl_priceRange.Controls.Add(this.numeric_start);
            this.pnl_priceRange.Controls.Add(this.numeric_end);
            this.pnl_priceRange.Controls.Add(this.btn_refreshPrice);
            this.pnl_priceRange.Controls.Add(this.lbl_end);
            this.pnl_priceRange.Controls.Add(this.lbl_start);
            this.pnl_priceRange.Controls.Add(this.lbl_question);
            this.pnl_priceRange.Location = new System.Drawing.Point(89, 114);
            this.pnl_priceRange.Name = "pnl_priceRange";
            this.pnl_priceRange.Size = new System.Drawing.Size(604, 67);
            this.pnl_priceRange.TabIndex = 10;
            this.pnl_priceRange.Visible = false;
            // 
            // btn_refreshPrice
            // 
            this.btn_refreshPrice.Location = new System.Drawing.Point(502, 10);
            this.btn_refreshPrice.Name = "btn_refreshPrice";
            this.btn_refreshPrice.Size = new System.Drawing.Size(82, 53);
            this.btn_refreshPrice.TabIndex = 11;
            this.btn_refreshPrice.Text = "Refresh Data";
            this.btn_refreshPrice.UseVisualStyleBackColor = true;
            this.btn_refreshPrice.Click += new System.EventHandler(this.btn_refreshPrice_Click);
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(356, 10);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(38, 20);
            this.lbl_end.TabIndex = 1;
            this.lbl_end.Text = "End";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(204, 10);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(44, 20);
            this.lbl_start.TabIndex = 0;
            this.lbl_start.Text = "Start";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.button1);
            this.pnl_buttons.Controls.Add(this.button2);
            this.pnl_buttons.Controls.Add(this.button3);
            this.pnl_buttons.Location = new System.Drawing.Point(98, 44);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(584, 59);
            this.pnl_buttons.TabIndex = 11;
            // 
            // pnl_dates
            // 
            this.pnl_dates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dates.Controls.Add(this.label1);
            this.pnl_dates.Controls.Add(this.button4);
            this.pnl_dates.Controls.Add(this.calendar);
            this.pnl_dates.Controls.Add(this.lbl_pickDate);
            this.pnl_dates.Location = new System.Drawing.Point(77, 62);
            this.pnl_dates.Name = "pnl_dates";
            this.pnl_dates.Size = new System.Drawing.Size(640, 296);
            this.pnl_dates.TabIndex = 12;
            this.pnl_dates.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = " (Hold the shift key to pick a range)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 53);
            this.button4.TabIndex = 14;
            this.button4.Text = "Refresh Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(268, 18);
            this.calendar.MaxSelectionCount = 100;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 13;
            // 
            // lbl_pickDate
            // 
            this.lbl_pickDate.AutoSize = true;
            this.lbl_pickDate.Location = new System.Drawing.Point(38, 30);
            this.lbl_pickDate.Name = "lbl_pickDate";
            this.lbl_pickDate.Size = new System.Drawing.Size(198, 20);
            this.lbl_pickDate.TabIndex = 12;
            this.lbl_pickDate.Text = "Please Pick a Date Range:";
            // 
            // ViewPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.pnl_dates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pnl_priceRange);
            this.Controls.Add(this.pnl_buttons);
            this.Name = "ViewPurchases";
            this.Text = "ViewPurchases";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_end)).EndInit();
            this.pnl_priceRange.ResumeLayout(false);
            this.pnl_priceRange.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_dates.ResumeLayout(false);
            this.pnl_dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PurchaseID;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.NumericUpDown numeric_start;
        private System.Windows.Forms.NumericUpDown numeric_end;
        private System.Windows.Forms.Panel pnl_priceRange;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Button btn_refreshPrice;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel pnl_dates;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.Label lbl_pickDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}