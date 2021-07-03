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
    public partial class FormLoadEmployee : Form
    {
        string id = null,po;
        private AdminForm af = null;
        private ManagerForm mf = null;

        public FormLoadEmployee()
        {
            InitializeComponent();
        }

        public FormLoadEmployee(AdminForm af,string post)
        {
            InitializeComponent();
            this.po = post;
            this.af = af;
        }

        public FormLoadEmployee(ManagerForm mf, string post,int b)
        {
            InitializeComponent();
            this.po = post;
            this.mf = mf;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageEmployeeForm em = new ManageEmployeeForm(this,id);
            em.Show();
        }

        private void dgvUserInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvUserInformation.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            //MessageBox.Show(id);
        }

        private void FormLoadEmployee_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        public void Initialize()
        {
            this.LoadUserInformation();
        }

        public void LoadUserInformation()
        {
            string query = "select ID,[Name],Post,Email,Phone,Gender,DOB,JoiningDate,MaritalStatus,Blood,Salary,[Address] from UserInformation where Post='"+po+"'";
            DataTable dt = DataAccess.Data(query);
            //dgvUserInformation.AutoGenerateColumns = false;
            dgvUserInformation.DataSource = dt;
            dgvUserInformation.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (af != null)
                af.Show();
            else if (mf != null)
                mf.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                this.Initialize();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchInformation();
        }

        private void SearchInformation()
        {
            try
            {
                string query = "select ID,[Name],Post,Email,Phone,Gender,DOB,JoiningDate,MaritalStatus,Blood,Salary,[Address] from UserInformation where ID ='"+txtSearch.Text+"'";
                DataTable dt = DataAccess.Data(query);
                //dgvUserInformation.AutoGenerateColumns = false;
                dgvUserInformation.DataSource = dt;
                dgvUserInformation.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //id = dgvUserInformation.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            if (id != "")
            {
                string query = "delete from UserInformation where ID='"+id+"'";
                DataAccess.Execute(query);
                this.Initialize();
            }
            else
            {
                MessageBox.Show("Please,select a row first.");
            }
        }
    }
}
