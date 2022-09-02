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
    public partial class ViewAccount : Form
    {
        USER user;
        public ViewAccount(USER user)
        {
            InitializeComponent();

            this.user = user;
            lbl_user.Text = user.Username;
            lbl_creditLimit.Text = user.CreditLimit.ToString();
            lbl_currBalance.Text = user.CurrentBalance.ToString();
            lbl_availCredit.Text = user.AvailableCredit.ToString();

            

        }
    }
}
