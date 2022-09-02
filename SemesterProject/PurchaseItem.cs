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
    public partial class PurchaseItem : Form
    {
        DataClasses1DataContext db;
        USER user;
        int itemIDChosen;
        public PurchaseItem(DataClasses1DataContext db, USER user)
        {
            InitializeComponent();
            this.user = user;
            this.db = db;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            var itemNames = db.ITEMs;
            String[] items = new String[3];
            ListViewItem listViewItem;
            foreach (var item in itemNames)
            {
                items[0] = item.ItemName;
                items[1] = item.Price.ToString();
                items[2] = item.ItemID.ToString();
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = null;
            decimal price;
            decimal quantity = numericUpDown.Value;
            if(listView1.SelectedItems.Count != 0)
            {
                productName = listView1.SelectedItems[0].SubItems[0].Text;
                price = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[1].Text);
                itemIDChosen = Convert.ToInt32(listView1.SelectedItems[0].SubItems[2].Text);

                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("Product Name: " + productName +
                    "\nPrice: " + price + "\nQuantity: " + quantity + "\n\nOrder Total:  $" + (price * quantity) + "\nConfirm Order?", "Purchase Details", buttons);
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {
                    if ((user.CurrentBalance + (price * quantity)) < user.AvailableCredit)
                    {
                        PURCHASE purchase = new PURCHASE();
                        purchase.Quantity = Convert.ToInt32(quantity);
                        purchase.USER = user;
                        purchase.ItemID = itemIDChosen;
                        purchase.Date = DateTime.Now.Date;
                        purchase.Total = quantity * price;

                        user.CurrentBalance = user.CurrentBalance + (price * quantity);

                        db.PURCHASEs.InsertOnSubmit(purchase);
                        db.SubmitChanges();
                        MessageBox.Show("Purchase Confirmed!\n$" + price * quantity + " charged to your account.");
                    }
                    else
                    {
                        MessageBox.Show("Insufficient Credit!");
                    }

                }
            }
            else
            {
                MessageBox.Show("Error! Please Choose an item!", "Error");
            }


        }


    }
}
