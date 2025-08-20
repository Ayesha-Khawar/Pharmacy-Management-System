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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }
       // prescriptionCLASS p1 = new prescriptionCLASS();
        //prescriptionCLASS p2 = new prescriptionCLASS();
        prescriptionCLASS p3 = new prescriptionCLASS();
        void DisplayRecords()
        {
            dgvPrescription.DataSource = p3.GetPrescriptionRecords();
            dgvPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrescription.ReadOnly = true;
            dgvPrescription.Refresh();
        }
        void ClearForm()
        {
           
        }
        private void txtMedicineQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }

        private void dgvPrescription_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
