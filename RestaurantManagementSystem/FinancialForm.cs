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
    public partial class FinancialForm : Form
    {
        AdminForm adf;
        ManagerForm mrf;
        string p;

        SqlConnection con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");

        public FinancialForm()
        {
            InitializeComponent();
        }


        public FinancialForm(AdminForm adf, String post)
        {
            InitializeComponent();
            this.adf = adf;
            this.p = post;

        }

        public FinancialForm(ManagerForm mrf, String post)
        {
            InitializeComponent();
            this.mrf = mrf;
            this.p = post;

        }
        private void FinancialFrom_Load(object sender, EventArgs e)
        {
            labelTotalSalesPrice.Text = "";
            showAll();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (p.Equals("Admin"))
            {
                //AdminForm af = new AdminForm();
                this.Hide();
                adf.Show();

            }
            else if (p.Equals("Manager"))
            {

                this.Hide();
                mrf.Show();
            }
            else
            {
                
            }
        }

        void showAll()
        {
            string qu = "select * from FinancialList";
            SqlCommand scd = new SqlCommand(qu, con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = scd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewFinancial.DataSource = dt;



        }

        private void buttonTotalSalesPrice_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dataGridViewFinancial.Rows.Count.ToString());
            try
            {
                int sum = 0;
                for (int i = 0; i <= dataGridViewFinancial.Rows.Count - 2; i++)
                {
                    sum = sum + int.Parse(dataGridViewFinancial.Rows[i].Cells[2].Value.ToString());
                }
                labelTotalSalesPrice.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("enter");
            //String quy = "select * from FinancialList where Date between '"+ dateTimePickerFromDate.Value.ToString() + "' and '"+ dateTimePickerToDate.Value.ToString() + "' order by Date";


            // DateTime date1 = dateTimePickerFromDate.Value;
            //MessageBox.Show(date1);
            //DateTime date2 = dateTimePickerToDate.Value;

            //string qu = "SELECT * FROM FinancialList WHERE Date >='" + date1 + "' AND Date <= '" + date2 + "' ORDER BY Date DESC";
            // MessageBox.Show("enter");


            //string qu = "select * from FinancialList";
            //SqlCommand scd = new SqlCommand(qu, con);
            //DataTable dt = new DataTable();

            //con.Open();
            // SqlDataAdapter saf = new SqlDataAdapter("SELECT * FROM FinancialList WHERE Date >='" + date1 + "' AND Date <= '" + date2 + "' ORDER BY Date DESC", con);
            //String qu = "SELECT * FROM FinancialList WHERE Date >='" + date1 + "' AND Date <= '" + date2 + "' ORDER BY Date DESC";
            //SqlCommand scd = new SqlCommand(qu, con);
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter(qu,con);

            //DataTable dt = new DataTable();

            //con.Open();

            //SqlDataReader sdr = scd.ExecuteReader();
            // dt.Load(sdr);
            //con.Close();

            // dataGridViewFinancial.DataSource = dt;
            // SqlDataReader sdr = scd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();

            // dataGridViewFinancial.DataSource = dt;
            DateTime date1 = Convert.ToDateTime(dateTimePickerFromDate.Text);
            DateTime date2 = Convert.ToDateTime(dateTimePickerToDate.Text);
            con.Open();
            // SqlDataAdapter saf = new SqlDataAdapter("select * from FinancialList ", con);
            SqlDataAdapter saf = new SqlDataAdapter("SELECT * FROM FinancialList WHERE Date >='" + date1 + "' AND Date <= '" + date2 + "' ORDER BY Date DESC", con);
            DataTable sd = new DataTable();
            //sd.Load(saf);
            saf.Fill(sd);
            con.Close();
            dataGridViewFinancial.DataSource = sd;
            //MessageBox.Show("enter");
            //showAll();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dateTimePickerFromDate.Text = dateTimePickerToDate.Text = DateTime.Now.ToString();
            labelTotalSalesPrice.Text = "";
            showAll();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();
        }
    }
}
