using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class AddEmployeeForm : Form
    {
        private SqlConnection con = null;
        private int salary, sal;
        private static int a = 10000, m = 1000, w = 100;
        private string id, gender, maritalStatus,blood, address, post;
        private AdminForm af = null;
        private FormLoadEmployee fle = null;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        public AddEmployeeForm(AdminForm af)
        {
            InitializeComponent();
            this.af = af;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //AdminForm ad = new AdminForm();
            if (af != null)
                af.Show();
            else if (fle != null)
                fle.Show();
        }

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            post = cmbPost.SelectedItem.ToString();

            if (post.Equals("Admin"))
            {
                id = "A-" + (a++);
            }
            else if (post.Equals("Manager"))
            {
                id = "M-" + (m++);
            }
            else if (post.Equals("Waiter"))
            {
                id = "W-" + (w++);
            }
            txtID.Text = id;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtPassword.Text = txtConfirmPassword.Text = txtEmail.Text = txtPhone.Text = txtSalary.Text = txtAddress.Text = "";
            dtpDOB.Text = dtpJoiningDate.Text = DateTime.Now.ToString();
            cmbBloodGroup.SelectedItem = null;
            rbMale.Checked = rbFemale.Checked = rbMarried.Checked = rbUnmarried.Checked = false;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Visible = true;
                return;
            }
            else
                lblError.Visible = false;

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPost_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblJoining_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddEmp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string uname = txtName.Text;

            string pass = txtPassword.Text;

            string mail = txtEmail.Text;

            string phn = txtPhone.Text;

            if (rbMale.Checked)
                gender = "male";
            else if (rbFemale.Checked)
                gender = "Female";

            DateTime dob = Convert.ToDateTime(dtpDOB.Text);

            DateTime joining = Convert.ToDateTime(dtpJoiningDate.Text);

            if (rbMarried.Checked)
                maritalStatus = "Married";
            else if (rbUnmarried.Checked)
                maritalStatus = "Unmarried";

            blood = cmbBloodGroup.SelectedItem.ToString();

            if (Int32.TryParse(txtSalary.Text, out sal))
                this.salary = sal;
            else
                MessageBox.Show("Enter a valid salary");

            address = txtAddress.Text;

            try
            {
                con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");
                con.Open();
                string query = "insert into UserInformation values('"+txtID.Text+"','"+uname+"','"+pass+"','"+post+"','"+mail+"','"+phn+"','"+gender+"', '"+dob+"', '"+joining+"','"+maritalStatus+"','"+blood+"',"+salary+",'"+address+"')";
                SqlCommand cmd = new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
