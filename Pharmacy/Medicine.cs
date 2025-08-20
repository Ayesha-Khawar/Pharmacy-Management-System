using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Pharmacy
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        medicineCLASS m1 = new medicineCLASS();
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
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            DBConnection.connect();

            DisplayRecords();
        }
    }
}
