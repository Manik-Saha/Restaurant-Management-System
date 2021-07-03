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
    public partial class PasswordChangeForm : Form
    {
        private string id,pass,sql;
        private SqlConnection con = null;

        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        public PasswordChangeForm(MyProfileForm mp,string id)
        {
            InitializeComponent();
            this.id = id;
            mp.Close();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text!="" && txtNewPassword.Text!=""&& txtOldPassword.Text != "")
            {
                string query = "select * from UserInformation where ID ='" + this.id + "'";
                DataTable dt = DataAccess.Data(query);
                this.pass = dt.Rows[0]["Password"].ToString();
                if (txtOldPassword.Text.Equals(this.pass))
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=WALTON_Prelude;Initial Catalog=RestaurantManagementSystemDatabase;Integrated Security=True");
                        con.Open();
                        sql = "update UserInformation set [Password]='" + txtNewPassword.Text + "' where id='" + this.id + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Password Changed");
                        this.Close();
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
                else
                {
                    MessageBox.Show("Your old password does not match.");
                }
            }
            else
            {
                MessageBox.Show("Please, Enter all the information.");
            }
        }
    }
}
