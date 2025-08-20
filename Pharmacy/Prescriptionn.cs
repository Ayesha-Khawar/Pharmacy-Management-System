using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Prescriptionn : Form
    {
        public Prescriptionn()
        {
            InitializeComponent();
        }
        presClass p1 = new presClass();
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtPrescriptionID.Text == "")
            {
                MessageBox.Show("Prescription ID can not be null");
            }
            if (txtmedicineID.Text == "")
            {
                MessageBox.Show("MedicineID can not be null");
            }
            if (txtQtyPrescribed.Text == "")
            {
                MessageBox.Show("Quantity Prescribed can not be null");
            }
            String PrescriptionId, MedicineID, CustomerID;
            int quantityPrescribed;
            PrescriptionId = txtPrescriptionID.Text;
            MedicineID = txtmedicineID.Text;
            quantityPrescribed = int.Parse(txtQtyPrescribed.Text);
            CustomerID = txtCustomerID.Text;
            if (p1.AddPresRecord(PrescriptionId, CustomerID, MedicineID, quantityPrescribed))
            {
                MessageBox.Show("record entered");
            }
            else
            {
                MessageBox.Show("could not enter record");
            }
        }

        private void Prescriptionn_Load(object sender, EventArgs e)
        {
            DBConnection.GetConnection();
        }
    }
}
