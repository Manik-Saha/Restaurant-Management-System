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
    public partial class MenuForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");
        public int proId;


        AdminForm afm=null;
        ManagerForm mfm=null;
        WaiterForm wf=null;

        string p, po;
        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(AdminForm afm, string post)
        {
            InitializeComponent();
            this.p = post;
            this.afm = afm;
        }

        public MenuForm(ManagerForm mfm, string post)
        {
            InitializeComponent();
            this.p = post;
            this.mfm = mfm;

        }

        public MenuForm(WaiterForm wf, String post)
        {
            InitializeComponent();
            this.wf = wf;
            this.p = post;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            show();
            show1();
        }

        private void proId_Click(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (p.Equals("Admin"))
            {
                //AdminForm af = new AdminForm();
                this.Hide();
                afm.Show();

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
                mfm.Show();
            }

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string proName = textProName.Text.ToString();
                string price = textPrice.Text.ToString();

                string qry = "insert into MenuList values('" + proName + "','" + price + "')";
                //proId++;
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
                show();
                show1();
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (proId > 0)
                {
                    //string query = "update UserInformation set [Name]='" + uname + "',Email='" + mail + "',Phone='" + phn + "',Gender='" + gender + "',DOB='" + dob + "',JoiningDate='" + joining + "',MaritalStatus='" + maritalStatus + "',Blood='" + blood + "',Salary=" + salary + ",[Address]='" + address + "' where ID='" + txtID.Text + "'";

                    con.Open();

                    string proName = textProName.Text.ToString();
                    string price = textPrice.Text.ToString();

                    string qry = "update MenuList set [Name] ='" + proName + "',[price]='" + price + "' where [ProductId]='" + proId + "'"; ;
                    SqlCommand sc = new SqlCommand(qry, con);

                    sc.ExecuteNonQuery();


                    MessageBox.Show("Update successfully");
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
                show();
                show1();
            }
        }

        private void show()
        {
            this.proId = 0;
            this.textProName.Text = "";
            this.textPrice.Text = "";
            this.textSearchMenu.Text = "";
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proId = Convert.ToInt32(dataGridViewMenu.SelectedRows[0].Cells[0].Value);
            textProName.Text = dataGridViewMenu.SelectedRows[0].Cells[1].Value.ToString();
            textPrice.Text = dataGridViewMenu.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (proId > 0)
                {


                    con.Open();

                    string proName = textProName.Text.ToString();
                    string price = textPrice.Text.ToString();

                    string qry = "delete from MenuList  where [ProductId]='" + proId + "'"; ;
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
                show();
                show1();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            show();
            show1();
        }

        private void textSearchMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            string qu = "select * from MenuList where Name='" + textSearchMenu.Text + "'";

            DataTable dt = DataAccess.Data(qu);
            dataGridViewMenu.DataSource = dt;
            dataGridViewMenu.Refresh();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        void show1()
        {
            string qu = "select * from MenuList";
            SqlCommand scd = new SqlCommand(qu, con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = scd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewMenu.DataSource = dt;



        }
    }
}
