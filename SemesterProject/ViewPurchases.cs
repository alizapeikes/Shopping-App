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
    public partial class ViewPurchases : Form
    {
        DataClasses1DataContext db;
        USER user;
        public ViewPurchases(DataClasses1DataContext db, USER user)
        {
            InitializeComponent();
            this.user = user;
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;

            IEnumerable<PURCHASE> purchases = db.PURCHASEs.Where(p => p.UserID == user.UserID);
            showPurchases(purchases);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pnl_buttons.Visible = false;
            pnl_priceRange.Visible = true;
        }

        public void showPurchases(IEnumerable<PURCHASE> purchases)
        {
            String[] purchaseOrder = new String[6];
            ListViewItem listViewItem;
            foreach (var purchase in purchases)
            {
                purchaseOrder[0] = purchase.PurchaseID.ToString();
                purchaseOrder[1] = db.ITEMs.Where(i => i.ItemID == purchase.ItemID).Select(i => i.ItemName).Single();
                decimal price = db.ITEMs.Where(i => i.ItemID == purchase.ItemID).Select(i => i.Price).Single();
                purchaseOrder[2] = "$" + price.ToString();
                purchaseOrder[3] = purchase.Quantity.ToString();
                purchaseOrder[4] = "$" + purchase.Total;
                purchaseOrder[5] = purchase.Date.ToShortDateString();
                listViewItem = new ListViewItem(purchaseOrder);
                listView1.Items.Add(listViewItem);
            }
        }

        private void btn_refreshPrice_Click(object sender, EventArgs e)
        {
            pnl_buttons.Visible = true;
            pnl_priceRange.Visible = false;
            listView1.View = View.Details;
            listView1.GridLines = true;
            pnl_priceRange.Visible = false;

            decimal start = numeric_start.Value;
            decimal end = numeric_end.Value;
            IEnumerable<PURCHASE> purchases = db.PURCHASEs.Where(p => p.Total >= start && p.Total <= end && p.UserID == user.UserID);
            showPurchases(purchases);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pnl_buttons.Visible=false;
            pnl_dates.Visible = true;
            calendar.SelectionStart = new DateTime(2000, 1, 1);
            calendar.MaxDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pnl_buttons.Visible = true;
            pnl_dates.Visible = false;
            DateTime start = calendar.SelectionStart;
            DateTime end = calendar.SelectionEnd;
            IEnumerable<PURCHASE> purchase = db.PURCHASEs.Where(p => p.UserID == user.UserID && p.Date >= start && p.Date <= end);
            showPurchases(purchase);
        }
    }
}
