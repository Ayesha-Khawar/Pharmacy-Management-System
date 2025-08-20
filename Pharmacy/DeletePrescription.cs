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
    public partial class DeletePrescription : Form
    {
        public DeletePrescription()
        {
            InitializeComponent();
        }
        presClass p1 = new presClass();
        presClass p2 = new presClass();
        // saleCLASS s3 = new saleCLASS();
        //saleCLASS s2 = new saleCLASS();
        void DisplayRecords()
        {
            dgvPrescription.DataSource = p1.GetPresRecords();
            dgvPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrescription.ReadOnly = true;
            dgvPrescription.Refresh();
        }
        private void DeletePrescription_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
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
                    if (p2.DeletePresceription(PrescriptionID))//if record is deleted 
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
    }
}
