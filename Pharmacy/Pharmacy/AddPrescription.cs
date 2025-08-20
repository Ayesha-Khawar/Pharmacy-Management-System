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
    public partial class AddPrescription : Form
    {
        public AddPrescription()
        {
            InitializeComponent();
        }
        prescriptionCLASS p1 = new prescriptionCLASS();
       // prescriptionCLASS p2 = new prescriptionCLASS();
        //prescriptionCLASS p3 = new prescriptionCLASS();
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtPrescriptionID.Text == "")
            {
                MessageBox.Show("Prescription ID can not be null");
                return;
            }
            if (txtPrescriptionCustID.Text == "")
            {
                MessageBox.Show("custID can not be null");
                return;
            }
            if (txtPrescriptionIssueDate.Text == "")
            {
                MessageBox.Show("Issue Date can not be null");
                return;
            }
            if (txtPrescriptionMedicineID.Text == "")
            {
                MessageBox.Show("Medicine ID can not be null");
                return;
            }
            if (txtPrescriptionMedQTY.Text == "")
            {
                MessageBox.Show("Medicine Quantity can not be null");
                return;
            }

            string PrescriptionID, CustomerID, IssueDate, MedicineID, QuantityPrescribed;
            PrescriptionID = txtPrescriptionID.Text;
            CustomerID = txtPrescriptionCustID.Text;
            IssueDate = txtPrescriptionIssueDate.Text;
            MedicineID = txtPrescriptionMedicineID.Text;
            QuantityPrescribed = txtPrescriptionMedQTY.Text;

            if (p1.FindPrescription(PrescriptionID))
            {
                MessageBox.Show(" record already exists!!");
                return;
            }

            if (p1.AddPrescriptionRecord(PrescriptionID, CustomerID, IssueDate, MedicineID, QuantityPrescribed))
            {
                MessageBox.Show("record added successfully");
                
            }
            else
            {
                MessageBox.Show("error adding record!!!");
            }
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            DBConnection.connect();

        }
    }
}
