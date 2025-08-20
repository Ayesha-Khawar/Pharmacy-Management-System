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
    public partial class Delete_Prescription : Form
    {
        public Delete_Prescription()
        {
            InitializeComponent();
        }
       // prescriptionCLASS p1 = new prescriptionCLASS();
        prescriptionCLASS p2 = new prescriptionCLASS();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPrescription.SelectedRows.Count > 0) //if row is selected
            {
                DataGridViewRow dr = dgvPrescription.SelectedRows[0];
                string PrescriptionID = dr.Cells[0].Value.ToString();
                DialogResult dia_res = MessageBox.Show("do you want to delete record?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dia_res == DialogResult.Yes)
                {
                    if (p2.DeletePrescriptionRecord(PrescriptionID))//if record is deleted 
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

        private void Delete_Prescription_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }
    }
}
