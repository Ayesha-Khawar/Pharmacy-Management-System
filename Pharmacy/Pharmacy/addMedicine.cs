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
    public partial class addMedicine : Form
    {
        public addMedicine()
        {
            InitializeComponent();
        }
        medicineCLASS m1 = new medicineCLASS();

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (txtMedicineID.Text == "")
            {
                MessageBox.Show("ID can not be null");
                return;
            }
            if (txtMedicineName.Text == "")
            {
                MessageBox.Show("Name can not be null");
                return;
            }
            if (txtMedicineDosage.Text == "")
            {
                MessageBox.Show("dosage can not be null");
                return;
            }
            if (txtMedicinePrice.Text == "")
            {
                MessageBox.Show("price can not be null");
                return;
            }
            if (txtMedicineQuantity.Text == "")
            {
                MessageBox.Show("Quantity can not be null");
                return;
            }

            string MedicineID, Name, Dosage, Price, Quantity;
            MedicineID = txtMedicineID.Text;
            Name = txtMedicineName.Text;
            Dosage = txtMedicineDosage.Text;
            Price = txtMedicinePrice.Text;
            Quantity = txtMedicineQuantity.Text;

            if (m1.FindMedicine(MedicineID))
            {
                MessageBox.Show("Medicine record already exists!!");
                return;
            }

            if (m1.AddMedicineRecord(MedicineID, Name, Dosage, Price, Quantity))
            {

                MessageBox.Show("record added successfully");
                //DisplayRecords();
                //ClearForm();
            }
            else
            {
                MessageBox.Show("error adding record!!!");
            }
        }

        private void addMedicine_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
