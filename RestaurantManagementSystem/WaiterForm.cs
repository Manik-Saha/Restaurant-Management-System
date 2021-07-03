using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class WaiterForm : Form
    {
        WaiterForm wf;
        private string id;
        public WaiterForm()
        {
            InitializeComponent();
        }

        public WaiterForm(WaiterForm wf,string uname,string id)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + uname;
            this.wf = wf;
            this.id = id;
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Waiter";
            OrderForm of = new OrderForm(this, post);
            of.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin lg = new FormLogin();
            lg.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Waiter";
            MenuForm mf = new MenuForm(this, post);
            mf.Show();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm mpf = new MyProfileForm(this.id);
            mpf.Show();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Waiter";
            OrderForm of = new OrderForm(this, post);
            of.Show();
        }
    }
}
