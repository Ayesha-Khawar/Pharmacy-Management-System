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
    public class presClass
    {
        public bool AddPresRecord(string PrescriptionID, string CustomerID, string MedicineID, int QuantityPrescribed)
        {
            string query = "Insert into Prescription(PrescriptionID, CustomerID, MedicineID, QuantityPrescribed) values (@PrescriptionID, @CustomerID, @MedicineID, @QuantityPrescribed)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
            cmd.Parameters.AddWithValue("@QuantityPrescribed", QuantityPrescribed);
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
        public DataTable GetPresRecords()
        {
            string query = "select * from Prescription";
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
        public bool DeletePresceription(string PrescriptionID)
        {

            string query = "DELETE FROM Prescription WHERE PrescriptionID= @PrescriptionID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
            bool success = false;
            //execute the query and return
            //number of records deleted innto n
            try
            {
                //execute the query and return

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
