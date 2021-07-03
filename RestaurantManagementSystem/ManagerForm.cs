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
    public partial class ManagerForm : Form
    {
        ManagerForm mf;
        private string id,a;
        int ab = 0;
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(ManagerForm mf,string uname,string id)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + uname;
            this.mf = mf;
            this.id = id;
        }

        private void btnManageWaiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Waiter";
            int a = 0; ;
            FormLoadEmployee le = new FormLoadEmployee(this,post,a);
            le.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            String post = "Manager";
            MenuForm mf = new MenuForm(this, post);
            mf.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin lg = new FormLogin();
            lg.Show();
            this.Hide();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm mpf = new MyProfileForm(this.id);
            mpf.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingTable bt = new BookingTable(this,a);
            bt.Show();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            String post = "Manager";
            OrderForm of = new OrderForm(this, post);
            of.Show();
        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Manager";
            FinancialForm pf = new FinancialForm(this, post);
            pf.Show();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            PaymentForm pf = new PaymentForm(this, post,ab);
            pf.Show();
        }
    }
}
