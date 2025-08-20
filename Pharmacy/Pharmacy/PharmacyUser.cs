using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public class PharmacyUser
    {
        public bool findUser(string LoginId, string Password)
        {
            string query = "SELECT * FROM login WHERE LoginId=@LoginId AND  Password=@Password";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@LoginId", LoginId);
            cmd.Parameters.AddWithValue("@Password", Password);
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool found = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }
            }
            catch (SqlException ex)
            {
                found = false;
                MessageBox.Show(ex.Message);
            }
            return found;
        }
    }
}
