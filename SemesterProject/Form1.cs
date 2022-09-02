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
    public partial class MainMenu : Form
    {
        DataClasses1DataContext db;
        USER user;
        public MainMenu()
        {
            InitializeComponent();

            db = new DataClasses1DataContext();
        }


        private void login_click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;
            var success = db.USERs.Any(u => u.Username.Equals(username) && u.UserPassword.Equals(password));
            if (success)
            { 
                pnl_login.Visible = false;
                pnl_options.Visible = true;
                user = db.USERs.Where(u => u.Username.Equals(txt_username.Text) && u.UserPassword.Equals(password)).First();
            }
            else
            {
                lbl_errorMessage.Text = "Username or Password is inccorect \nPlease re-enter.";
            }
            

        }

        private void viewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAccount viewAccount = new ViewAccount(user);
            viewAccount.ShowDialog();
        }

        private void purchaseItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseItem purchaseItem = new PurchaseItem(db, user);
            purchaseItem.ShowDialog();
        }

        private void payBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayBill payBill = new PayBill(db,user);
            payBill.ShowDialog();
        }

        private void viewPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPurchases viewPurchases = new ViewPurchases(db,user);
            viewPurchases.ShowDialog();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }
    }
}
