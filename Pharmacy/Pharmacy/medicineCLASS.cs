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
    public class medicineCLASS
    {
        public bool AddMedicineRecord(string MedicineID, string Name, string Dosage, string Price, string Quantity)
        {
            string query = "Insert into Medicine(MedicineID, Name, Dosage, Price,Quantity ) values (@MedicineID, @Name, @Dosage, @Price,@Quantity)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
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
        public bool UpdateMedicineRecord(string MedicineID, string Name, string Dosage, string Price, string Quantity)
        {
            string query = "UPDATE Medicine SET Name=@Name, Dosage=@Dosage, Quantity=@Quantity WHERE MedicineID= '" + MedicineID + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Dosage", Dosage);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.Parameters.AddWithValue("@Quantity", Quantity);
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
        public bool DeleteMedicineRecord(string MedicineID)
        {

            string query = "DELETE FROM Medicine WHERE MedicineID= @MedicineID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
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
        public bool FindMedicine(string MedicineID)
        {
            bool found = false;
            string query = "Select * from Medicine where MedicineID = '" + MedicineID + "'"; //RoomNo = 'xyz'
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
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
        public DataTable GetMedicineRecords()
        {
            string query = "select * from Medicine";
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
    }
}
