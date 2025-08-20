using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }
        saleCLASS s1 = new saleCLASS();

        private void btnADD_Click(object sender, EventArgs e)
        {
            showTotal();
            if (txtSaleID.Text == "")
            {
                MessageBox.Show("SaleId can not be null");
            }
            if (txtSalePrescriptionID.Text == "")
            {
                MessageBox.Show("prescriptionId can not be null");
            }
            String prescriptionId, SaleId;
            prescriptionId = txtSalePrescriptionID.Text;
            SaleId = txtSaleID.Text;
            string MedicineID = txtmedId.Text;

            decimal totalAmount;
            int quantityAvailable = int.Parse(txtCurrentQty.Text);
            int quantitysold = int.Parse(txtQty.Text);
            int NewQuantity = quantityAvailable - quantitysold;
            totalAmount = decimal.Parse(txtSaleTotalAmount.Text);

            if (s1.AddSaleRecord(SaleId, prescriptionId, totalAmount))
            {
                MessageBox.Show("record entered");
            }
            else
            {
                MessageBox.Show("could not enter record");
            }
            if (updateMED(MedicineID, NewQuantity))
            {
                MessageBox.Show("Medicine Stock Updated");
            }
        }

        private void showTotal()
        {
            string prescriptionId = txtSalePrescriptionID.Text.Trim();
            int totalQuantity = 0; // Total quantity of medicines in the prescription
            decimal totalAmount = 0; // Total amount of the sale

            if (!string.IsNullOrEmpty(prescriptionId))
            {
                try
                {
                    // SQL query to retrieve prescription details and calculate total amount
                    string query = "SELECT M.MedicineID AS MedicineID, M.Quantity AS AvailableQuantity, CONVERT(DECIMAL(18, 2), M.Price) AS Price, CONVERT(INT, P.QuantityPrescribed) AS QuantityPrescribed " +
                                   "FROM Prescription P " +
                                   "INNER JOIN Medicine M ON P.MedicineID = M.MedicineID " +
                                   "WHERE P.PrescriptionID = @PrescriptionID";

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = DBConnection.GetConnection();
                    cmd.Parameters.AddWithValue("@PrescriptionID", prescriptionId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int availableQuantity = reader.GetInt32(reader.GetOrdinal("AvailableQuantity"));
                        int quantityPrescribed = reader.GetInt32(reader.GetOrdinal("QuantityPrescribed"));
                        string MedicineID = reader.GetString(reader.GetOrdinal("MedicineID"));

                        
                        if (quantityPrescribed <= availableQuantity)
                        {
                            totalQuantity += quantityPrescribed;
                            totalAmount += reader.GetDecimal(reader.GetOrdinal("Price")) * quantityPrescribed;
                        }
                        else
                        {
                            MessageBox.Show("Insufficient quantity available for sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            reader.Close();
                            return; 
                        }
                        txtSaleTotalAmount.Text = totalAmount.ToString();
                        txtQty.Text = quantityPrescribed.ToString();
                        txtCurrentQty.Text = availableQuantity.ToString();
                        txtmedId.Text = MedicineID;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a prescription ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private bool updateMED(string MedicineID, int NewQuantity)
        {
            string query = " UPDATE Medicine SET Quantity=@NewQuantity WHERE MedicineID=@MedicineID";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@MedicineID", MedicineID);
            cmd.Parameters.AddWithValue("@NewQuantity", NewQuantity);
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
        private void Sale_Load(object sender, EventArgs e)
        {

            DBConnection.connect();
           // DisplayRecords();
        }
    }
}
