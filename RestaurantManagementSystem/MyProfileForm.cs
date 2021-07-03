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
    public partial class MyProfileForm : Form
    {
        private string loadID;
        public MyProfileForm()
        {
            InitializeComponent();
        }

        public MyProfileForm(string id)
        {
            InitializeComponent();
            this.loadID = id;
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            this.assignValue(this.loadID);
        }

        public void assignValue(string id)
        {
            string query = "select * from UserInformation where ID ='" + id + "'";
            DataTable dt = DataAccess.Data(query);
            lblID.Text = dt.Rows[0]["ID"].ToString();
            lblName.Text = dt.Rows[0]["Name"].ToString();
            lblPost.Text = dt.Rows[0]["Post"].ToString();
            lblEmail.Text = dt.Rows[0]["Email"].ToString();
            lblPhone.Text = dt.Rows[0]["Phone"].ToString();
            lblGender.Text = dt.Rows[0]["Gender"].ToString();
            lblDOB.Text = dt.Rows[0]["DOB"].ToString();
            lblJoiningDate.Text = dt.Rows[0]["JoiningDate"].ToString();
            lblMaritalStatus.Text = dt.Rows[0]["Maritalstatus"].ToString();
            lblBlood.Text = dt.Rows[0]["Blood"].ToString();
            lblSalary.Text = dt.Rows[0]["Salary"].ToString();
            lblAddress.Text = dt.Rows[0]["Address"].ToString();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            PasswordChangeForm pc = new PasswordChangeForm(this,lblID.Text);
            pc.Show();
        }
    }
}
