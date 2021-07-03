using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RestaurantManagementSystem
{
    public static class DataAccess
    {
        public static DataTable Data(string qu)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-DK7TKAJO\SQLEXPRESS;Initial Catalog=RestaurentManagementSystemStudio;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(qu,con);
            DataSet ds = new DataSet();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);
            return ds.Tables[0];
        }

        public static void Execute(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-DK7TKAJO\SQLEXPRESS;Initial Catalog=RestaurentManagementSystemStudio;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
