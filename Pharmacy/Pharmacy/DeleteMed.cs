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
    public partial class DeleteMed : Form
    {
        public DeleteMed()
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicine.SelectedRows.Count > 0) //if row is selected
            {
                DataGridViewRow dr = dgvMedicine.SelectedRows[0];
                string MedicineID = dr.Cells[0].Value.ToString();
                DialogResult dia_res = MessageBox.Show("do you want to delete record?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dia_res == DialogResult.Yes)
                {
                    if (m2.DeleteMedicineRecord(MedicineID))//if record is deleted 
                    {
                        MessageBox.Show("record deleted successfully");
                        DisplayRecords();
                    }
                    else
                    {
                        MessageBox.Show("error deleting record!!");
                    }
                }
            }
        }

        private void DeleteMed_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }
    }
}
