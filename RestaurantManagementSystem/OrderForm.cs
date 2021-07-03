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
    public partial class OrderForm : Form
    {
        int customerId;
        AdminForm adf;
        ManagerForm mrf;
        WaiterForm wf;

        String p;

        SqlConnection con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");

        public OrderForm()
        {
            InitializeComponent();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            showAll();
        }

        public OrderForm(AdminForm adf, String post)
        {
            InitializeComponent();
            this.adf = adf;
            this.p = post;

        }

        public OrderForm(ManagerForm mrf, String post)
        {
            InitializeComponent();
            this.mrf = mrf;
            this.p = post;

        }

        public OrderForm(WaiterForm wf, String post)
        {
            InitializeComponent();
            this.wf = wf;
            this.p = post;

        }

        void showAll()
        {
            string qu = "select * from MenuList";
            SqlCommand scd = new SqlCommand(qu, con);
            DataTable dt = new DataTable();

            string qur = "select * from OrderList";
            SqlCommand sd = new SqlCommand(qur, con);
            DataTable dat = new DataTable();

            con.Open();

            SqlDataReader sdr = scd.ExecuteReader();
            dt.Load(sdr);

            SqlDataReader sqr = sd.ExecuteReader();
            dat.Load(sqr);

            con.Close();

            dataGridViewMenu1.DataSource = dt;
            dataGridViewOrder.DataSource = dat;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string qu = "select * from MenuList where Name='" + textSearchBox.Text + "'";

            DataTable dt = DataAccess.Data(qu);
            dataGridViewMenu1.DataSource = dt;
            dataGridViewMenu1.Refresh();
        }

        private void dataGridViewMenu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textProductName.Text = dataGridViewMenu1.SelectedRows[0].Cells[1].Value.ToString();
            textPrice.Text = dataGridViewMenu1.SelectedRows[0].Cells[2].Value.ToString();
            textQuantity.Focus();
        }

        private void buttonTotalPrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (textQuantity.Text != "")
                {
                    int price = Int32.Parse(textPrice.Text);
                    int quantity = Int32.Parse(textQuantity.Text);

                    int totalPrice = price * quantity;

                    textTotalPrice.Text = totalPrice.ToString();


                }
                else
                {
                    MessageBox.Show("Please enter quantity");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        void clearAll()
        {

            dateTimePicker1.Text = DateTime.Now.ToString();
            textProductName.Text = "";
            textPrice.Text = "";
            textQuantity.Text = "";
            textTotalPrice.Text = "";
            textSearchBox.Text = "";

        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string proName = textProductName.Text.ToString();
                string proTotalPrice = textTotalPrice.Text.ToString();
                string date = dateTimePicker1.Text.ToString();

                string qry = "insert into OrderList values('" + proName + "','" + proTotalPrice + "','" + date + "')";
                SqlCommand sc = new SqlCommand(qry, con);

                sc.ExecuteNonQuery();


                MessageBox.Show("Insert successfully");

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

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId = Convert.ToInt32(dataGridViewOrder.SelectedRows[0].Cells[0].Value);
            textProName.Text = dataGridViewOrder.SelectedRows[0].Cells[1].Value.ToString();
            textBoxTotalAmount.Text = dataGridViewOrder.SelectedRows[0].Cells[2].Value.ToString();
        }

        void OrderClear()
        {
            this.customerId = 0;
            this.textProName.Text = "";
            this.textBoxTotalAmount.Text = "";

        }

        private void buttonOrderClear_Click(object sender, EventArgs e)
        {
            OrderClear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerId > 0)
                {


                    con.Open();

                    string proName = textProName.Text.ToString();
                    string totalAmount = textBoxTotalAmount.Text.ToString();

                    string qry = "delete from OrderList  where [Customer_Id]='" + customerId + "'"; ;
                    SqlCommand sc = new SqlCommand(qry, con);

                    sc.ExecuteNonQuery();


                    MessageBox.Show("Delete successfully");
                }
                else
                {
                    MessageBox.Show("Please select a item");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clearAll();
                OrderClear();
                showAll();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (p.Equals("Admin"))
            {
                //AdminForm af = new AdminForm();
                this.Hide();
                adf.Show();

            }
            else if (p.Equals("Waiter"))
            {

                this.Hide();
                wf.Show();
            }
            else
            {
                //ManagerForm mf = new ManagerForm();
                this.Hide();
                mrf.Show();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void textTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textQuantity.Text != "")
                {
                    int price = Int32.Parse(textPrice.Text);
                    int quantity = Int32.Parse(textQuantity.Text);

                    int totalPrice = price * quantity;

                    textTotalPrice.Text = totalPrice.ToString();


                }
                else
                {
                    MessageBox.Show("Please enter quantity");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
