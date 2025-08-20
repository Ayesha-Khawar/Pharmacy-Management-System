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
            if (txtSaleStaffId.Text == "")
            {
                MessageBox.Show("staffID can not be null");
            }
            String staffID, prescriptionId, SaleId;
            decimal totalAmount;
            staffID = txtSaleStaffId.Text;
            prescriptionId = txtSalePrescriptionID.Text;
            SaleId=txtSaleID.Text;
            totalAmount = decimal.Parse(txtSaleTotalAmount.Text);
            if (s1.AddSaleRecord(SaleId, prescriptionId, staffID, totalAmount))
            {
                MessageBox.Show("record entered");
            }
            else
            {
                MessageBox.Show("could not enter record");
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
                            string query = "SELECT M.MedicineID, M.Quantity AS AvailableQuantity, CONVERT(DECIMAL(18, 2), M.Price) AS Price, CONVERT(INT, P.QuantityPrescribed) AS QuantityPrescribed " +
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

                                // Check if available quantity is sufficient for sale
                                if (quantityPrescribed <= availableQuantity)
                                {
                                    totalQuantity += quantityPrescribed;
                                    totalAmount += reader.GetDecimal(reader.GetOrdinal("Price")) * quantityPrescribed;
                                    //UpdateMedicineQuantity(totalQuantity);
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity available for sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    reader.Close();
                                    return; // Exit the method
                                }
                                txtSaleTotalAmount.Text = totalAmount.ToString();
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       // DBConnection.disconnnect();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a prescription ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

               


        private void Sale_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
           // DisplayRecords();
        }
    }
}
