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
    public class DBConnection
    {
        private static SqlConnection cn;
        public static void connect()
        {
            string con_str = @"Data Source=DESKTOP-8BL3MIG;Initial Catalog=pharmacy;Integrated Security=True;TrustServerCertificate=True";
            cn = new SqlConnection(con_str);
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void disconnnect()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public static SqlConnection GetConnection()
        {
            return cn;
        }
    }
}
