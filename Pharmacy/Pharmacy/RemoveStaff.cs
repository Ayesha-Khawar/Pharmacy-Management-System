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
    public partial class RemoveStaff : Form
    {
        public RemoveStaff()
        {
            InitializeComponent();
        }
        staffCLASS st1 = new staffCLASS();
        staffCLASS st2 = new staffCLASS();
        staffCLASS st3 = new staffCLASS();
        void DisplayRecords()
        {
            dgvStaff.DataSource = st3.GetStaffRecords();
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStaff.ReadOnly = true;
            dgvStaff.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvStaff.SelectedRows[0];
            string StaffID = dr.Cells[0].Value.ToString();
            DialogResult dia_res = MessageBox.Show("do you want to delete record?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dia_res == DialogResult.Yes)
            {
                if (st2.DeleteStaffRecord(StaffID))//if record is deleted 
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

        private void RemoveStaff_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }
    }
}