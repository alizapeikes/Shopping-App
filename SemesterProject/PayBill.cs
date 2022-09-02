using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProject
{
    public partial class PayBill : Form
    {
        USER user;
        DataClasses1DataContext db;
        public PayBill(DataClasses1DataContext db, USER user)
        {
            InitializeComponent();
            this.user = user;
            this.db = db;
            lbl_availCredit.Text = user.AvailableCredit.ToString();
            lbl_CreditLimit.Text = user.CreditLimit.ToString();
            lbl_balance.Text = user.CurrentBalance.ToString();


        }

        private void btn_payBill_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txt_amount.Text);
            if(amount <= 0)
            {
                MessageBox.Show("Please enter an amount greater than 0","Error");
            }
            else
            {
                user.CurrentBalance -= amount;
                db.SubmitChanges();
                MessageBox.Show("$" + amount + " paid", "Status");
                lbl_availCredit.Text = user.AvailableCredit.ToString();
                lbl_CreditLimit.Text = user.CreditLimit.ToString();
                lbl_balance.Text = user.CurrentBalance.ToString();
            }


        }
    }
}
