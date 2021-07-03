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
    public partial class PaymentForm : Form
    {
        AdminForm adf = null;
        ManagerForm mrf = null;

        DateTime date;
        string proName;
        String p = "";
        SqlConnection con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(AdminForm adf, String post)
        {
            InitializeComponent();
            this.adf = adf;
            this.p = post;

        }

        public PaymentForm(ManagerForm mrf, String post,int a)
        {
            InitializeComponent();
            this.mrf = mrf;
            this.p = post;
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            showAll();
            clearAll();

        }

        void showAll()
        {
            string qu = "select * from OrderList";
            SqlCommand scd = new SqlCommand(qu, con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = scd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewOrder1.DataSource = dt;

        }

        private void dataGridViewOrder1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //customerId = Convert.ToInt32(dataGridViewOrder1.SelectedRows[0].Cells[0].Value);
            proName = dataGridViewOrder1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxTotal.Text = dataGridViewOrder1.SelectedRows[0].Cells[2].Value.ToString();
            date = Convert.ToDateTime(dataGridViewOrder1.SelectedRows[0].Cells[3].Value);
            //DateTime date1 = Convert.ToDateTime(dateTimePickerFromDate.Text);
            double total = double.Parse(textBoxTotal.Text);

            double vat = total * 0.1;

            textBoxVat.Text = vat.ToString();

            //double withvat = ;
            textBoxTotalpayment.Text = (total + vat).ToString();




        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Payment ");
            try
            {
                //if (float.Parse(textBoxPaidAmount.Text) > float.Parse(textBoxReturnAmount.Text))
                if (textBoxPaidAmount.Text != null)
                {
                    float paidAmount = float.Parse(textBoxPaidAmount.Text);
                    float proTotalPayment = float.Parse(textBoxTotalpayment.Text);

                    textBoxReturnAmount.Text = (paidAmount - proTotalPayment).ToString();
                    string totalPayment = textBoxTotalpayment.Text.ToString();
                    //string totalPayment=
                    con.Open();

                    //float proTotalPayment = float.Parse(textBoxTotalpayment.Text);
                    //string proTotalPrice = textTotalPrice.Text.ToString();

                    string qry = "insert into FinancialList values('" + proName + "','" + totalPayment + "','" + date + "')";
                    SqlCommand sc = new SqlCommand(qry, con);

                    sc.ExecuteNonQuery();


                    MessageBox.Show("Payment successfully");
                }
                else
                {
                    MessageBox.Show("Payment not successfull");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                showAll();
                clearAll();
            }



        }

        void clearAll()
        {
            textBoxTotal.Text = "";
            textBoxVat.Text = "";
            textBoxTotalpayment.Text = "";
            textBoxPaidAmount.Text = "";
            textBoxReturnAmount.Text = "";
            textBoxSearchId.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (adf != null) 
            {
                AdminForm af = new AdminForm();
                this.Hide();
                af.Show();

            }
            else if (mrf != null) 
            {
                ManagerForm mf = new ManagerForm();
                this.Hide();
                mf.Show();
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSearchId_Click(object sender, EventArgs e)
        {
            string qu = "select * from OrderList where [Customer_Id]='" + textBoxSearchId.Text + "'";

            DataTable dt = DataAccess.Data(qu);
            dataGridViewOrder1.DataSource = dt;
            dataGridViewOrder1.Refresh();

        }
    }
}