using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy
{
    public class saleCLASS
    {
        public DataTable GetSaleRecords()
        {
            string query = "select * from Sale";
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        
        public bool AddSaleRecord(string SaleID, string PrescriptionID, decimal TotalAmount)
        {
            string query = "INSERT INTO Sale (SaleID, PrescriptionID, TotalAmount) " +
                           "VALUES (@SaleID, @PrescriptionID, @TotalAmount)";

            SqlCommand cmd = new SqlCommand(query, DBConnection.GetConnection());
            cmd.Parameters.AddWithValue("@SaleID", SaleID);
            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            //cmd.Parameters.AddWithValue("@StaffID", StaffID);
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        

    }
}
