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
    public partial class AdminForm : Form
    {
        AdminForm am;
        string uname,id;
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(AdminForm am,string uname,string id)
        {
            InitializeComponent();
            this.am = am;
            lblWelcome.Text = "Welcome, " + uname;
            this.uname = uname;
            this.id = id;
        }

        private void pnlRight_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //am.Hide();
            AddEmployeeForm em = new AddEmployeeForm(this);
            em.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin lg = new FormLogin();
            lg.Show();
        }

        private void btnManageAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            FormLoadEmployee le = new FormLoadEmployee(this,post);
            le.Show();
        }

        private void btnManageManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Manager";
            FormLoadEmployee le = new FormLoadEmployee(this,post);
            le.Show();
        }

        private void btnManageWaiter_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Waiter";
            FormLoadEmployee le = new FormLoadEmployee(this,post);
            le.Show();
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            MenuForm mf = new MenuForm(this, post);
            mf.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingTable bt = new BookingTable(this);
            bt.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            OrderForm of = new OrderForm(this, post);
            of.Show();
        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            FinancialForm pf = new FinancialForm(this, post);
            pf.Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            string post = "Admin";
            PaymentForm pf = new PaymentForm(this, post);
            pf.Show();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            MyProfileForm mpf = new MyProfileForm(this.id);
            mpf.Show();
        }
    }
}
