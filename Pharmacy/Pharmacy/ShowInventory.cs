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

namespace Pharmacy
{
    public partial class ShowInventory : Form
    {
        public ShowInventory()
        {
            InitializeComponent();
        }

        private void ShowInventory_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
        }
        private void DisplayInventory(string MedicineID)
        {
            string query = "SELECT Name, Quantity, Price FROM Medicine WHERE MedicineID = @MedicineID";
            //using (SqlConnection connection = DBConnection.connect()) ;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader.GetString(0);
                txtQuantity.Text = reader.GetInt32(1).ToString();
                txtPrice.Text = reader.GetDecimal(2).ToString();
            }
             reader.Close();
        }


        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("ID can not be null");
            }
            string ID;
            ID=txtID.Text;
            DisplayInventory(ID);
            DBConnection.disconnnect();
        }
    }
}
