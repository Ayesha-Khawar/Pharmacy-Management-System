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
    public class customerCLASS
    {
        public bool AddCustomerfRecord(string CustomerID, string Name, string Address, string Phone)
        {
            string query = "Insert into Customer(CustomerID, Name, Address, Phone) values (@CustomerID, @Name, @Address, @Phone)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

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
        public bool UpdateCustomerRecord(string CustomerID, string Name, string Address, string Phone)
        {
            string query = "UPDATE Customer SET Name=@Name, Address=@Address, Phone=@Phone WHERE CustomerID= '" + CustomerID + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

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
        public bool DeleteCustomerRecord(string CustomerID)
        {

            string query = "DELETE FROM Customer WHERE CustomerID= @CustomerID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
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
        public bool FindCustomer(string CustomerID)
        {
            bool found = false;
            string query = "Select * from Customer where CustomerID = '" + CustomerID + "'"; //RoomNo = 'xyz'
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
        public DataTable GetCustomerRecords()
        {
            string query = "select * from Customer";
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
        public DataTable searchcustRecords(string Name)
        {
            string query = "SELECT p.PrescriptionID, p.QuantityPrescribed " +
                   "FROM Prescription p " +
                   "INNER JOIN Customer c ON c.CustomerID = p.CustomerID " +
                   "WHERE c.Name = @Name";

            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            da.SelectCommand.Parameters.AddWithValue("@Name", Name);

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
