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
    public partial class ManageEmployeeForm : Form
    {
        private SqlConnection con = null;
        private int salary, sal;
        private static int a = 10000, m = 1000, w = 100;
        private string id, gender, maritalStatus, blood, address, post, updateID;
        private AdminForm af = null;
        private FormLoadEmployee fle = null;

        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        public ManageEmployeeForm(FormLoadEmployee fle, string idd)
        {
            InitializeComponent();
            this.assignValue(idd);
            this.fle = fle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            fle.Show();
            fle.Initialize();
        }

        private void cmbPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*post = cmbPost.SelectedItem.ToString();

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
            txtID.Text = id;*/
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

        public void assignValue(string idd)
        {
            this.updateID = idd;
            string query = "select * from UserInformation where ID ='" + this.updateID + "'";
            DataTable dt = DataAccess.Data(query);
            txtID.Text = dt.Rows[0]["ID"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
            txtConfirmPassword.Text = dt.Rows[0]["Password"].ToString();
            cmbPost.SelectedItem = dt.Rows[0]["Post"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtPhone.Text = dt.Rows[0]["Phone"].ToString();
            gender = dt.Rows[0]["Gender"].ToString();

            if (gender.Equals("male"))
                rbMale.Checked = true;
            else if(gender.Equals("Female"))
                rbFemale.Checked = true;

            dtpDOB.Text = dt.Rows[0]["DOB"].ToString();
            dtpJoiningDate.Text = dt.Rows[0]["JoiningDate"].ToString();
            maritalStatus = dt.Rows[0]["Maritalstatus"].ToString();

            if (maritalStatus.Equals("Married"))
                rbMarried.Checked = true;
            else if (maritalStatus.Equals("Unmarried"))
                rbUnmarried.Checked = true;

            cmbBloodGroup.SelectedItem = dt.Rows[0]["Blood"].ToString();
            txtSalary.Text = dt.Rows[0]["Salary"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
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
                string query = "update UserInformation set [Name]='"+uname+"',Email='"+mail+"',Phone='"+phn+"',Gender='"+gender+"',DOB='"+dob+"',JoiningDate='"+joining+"',MaritalStatus='"+maritalStatus+"',Blood='"+blood+"',Salary="+salary+",[Address]='"+address+"' where ID='"+txtID.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
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
