using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class BookingTable : Form
    {
        private AdminForm af = null;
        private ManagerForm mf = null;
        private SqlConnection con = null;
        private int id = 0, guestNo;
        private string name,email,contact,request,tableType;
        private DateTime arrival;

        public BookingTable()
        {
            InitializeComponent();
        }

        public BookingTable(AdminForm af)
        {
            InitializeComponent();
            this.af = af;
            this.LoadBookingInformation();
        }

        public BookingTable(ManagerForm mf,string a)
        {
            InitializeComponent();
            this.mf = mf;
            this.LoadBookingInformation();
        }

        public void LoadBookingInformation()
        {
            string query = "select * from BookingTable";
            DataTable dt = DataAccess.Data(query);
            dgvBookingInfo.DataSource = dt;
            dgvBookingInfo.Refresh();
        }

        private void insertbttn_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            email = txtEmail.Text;
            contact = txtContact.Text;
            request = txtSpecialRequest.Text;
            arrival = Convert.ToDateTime(dtpArrival.Text);
            tableType = cmbTableType.SelectedItem.ToString();
            guestNo = Convert.ToInt32(cmbNoOfGuest.SelectedItem);

            try
            {
                con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");
                con.Open();
                string query = "insert into BookingTable values('" + name + "','" + contact + "','" + email + "','" + tableType + "'," + guestNo + ",'" + arrival + "','" + request + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Booked");
                this.LoadBookingInformation();
                this.clearAll();
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

        private void clearAll()
        {
            txtContact.Text = txtEmail.Text = txtName.Text = txtSpecialRequest.Text = "";
            dtpArrival.Text = DateTime.Now.ToString();
            cmbNoOfGuest.SelectedItem = cmbTableType.SelectedItem = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                this.LoadBookingInformation();
            }
            else
            {
                this.SearchInformation();
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
                string query = "select * from BookingTable where [Name] = '" + txtSearch.Text + "'";
                DataTable dt = DataAccess.Data(query);
                dgvBookingInfo.DataSource = dt;
                dgvBookingInfo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            //this.assignValue(id);
            name = txtName.Text;
            email = txtEmail.Text;
            contact = txtContact.Text;
            request = txtSpecialRequest.Text;
            arrival = Convert.ToDateTime(dtpArrival.Text);
            tableType = cmbTableType.SelectedItem.ToString();
            guestNo = Convert.ToInt32(cmbNoOfGuest.SelectedItem);
            try
            {
                con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");
                con.Open();
                string query = "update BookingTable set [Name]='" + name + "',Email='" + email + "',Contact='" + contact + "',type='" + tableType + "',NoOfGuest='" + guestNo + "',Date='" + arrival + "',Request='" + request + "' where bookingID='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
                this.clearAll();
                this.LoadBookingInformation();
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

        private void assignValue()
        {
            //int idd = id;
            string query = "select * from BookingTable where bookingID=" + id + "";
            DataTable dt = DataAccess.Data(query);
            txtContact.Text = dt.Rows[0]["Contact"].ToString();
            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtSpecialRequest.Text = dt.Rows[0]["Request"].ToString();
            cmbTableType.SelectedItem = dt.Rows[0]["type"].ToString();
            cmbNoOfGuest.SelectedItem = Convert.ToString(dt.Rows[0]["NoOfGuest"]);
            dtpArrival.Text = dt.Rows[0]["Date"].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*DialogResult exit;
            exit = MessageBox.Show("Are You Sure Want to Exit?", "Resturant Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }*/
            this.Hide();
            if (this.af != null)
            {
                this.af.Show();
            }
            else if (this.mf != null)
            {
                this.mf.Show();
            }
        }

        private void deletebttn_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                string query = "delete from BookingTable where bookingID=" + id + "";
                DataAccess.Execute(query);
                this.LoadBookingInformation();
            }
            else
            {
                MessageBox.Show("Please,select a row first.");
            }
        }

        private void dgvBookingInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvBookingInfo.Rows[e.RowIndex].Cells["bookingID"].Value);
            this.assignValue();
        }
    }
}
