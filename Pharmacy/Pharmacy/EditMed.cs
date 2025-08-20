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
    public partial class EditMed : Form
    {
        public EditMed()
        {
            InitializeComponent();
        }
       // medicineCLASS m1 = new medicineCLASS();
        medicineCLASS m2 = new medicineCLASS();
        medicineCLASS m3 = new medicineCLASS();
        void DisplayRecords()
        {
            dgvMedicine.DataSource = m3.GetMedicineRecords();
            dgvMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMedicine.ReadOnly = true;
            dgvMedicine.Refresh();
        }
        void ClearForm()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineDosage.Clear();
            txtMedicinePrice.Clear();
            txtMedicineQuantity.Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicine.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvMedicine.SelectedRows[0];
                txtMedicineID.Text = dr.Cells[0].Value.ToString();
                txtMedicineName.Text = dr.Cells[1].Value.ToString();
                txtMedicineDosage.Text = dr.Cells[2].Value.ToString();
                txtMedicinePrice.Text = dr.Cells[3].Value.ToString();
                txtMedicineQuantity.Text = dr.Cells[4].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            if (!m2.FindMedicine(MedicineID))//to check the record to be updated exists
            {
                MessageBox.Show(" record not found!!");
                return;
            }

            if (m2.UpdateMedicineRecord(MedicineID, Name, Dosage, Price, Quantity))
            {
                DisplayRecords();
                MessageBox.Show("record updated successfully");
                ClearForm();
            }
            else
            {
                MessageBox.Show("error adding record!!!");
            }
        }

        private void EditMed_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
