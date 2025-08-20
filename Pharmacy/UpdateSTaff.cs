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
    public partial class UpdateSTaff : Form
    {
        public UpdateSTaff()
        {
            InitializeComponent();
        }
        void ClearForm()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtStaffPhone.Clear();
        }
        //staffCLASS st1 = new staffCLASS();
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
        
        private void UpdateSTaff_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvStaff.SelectedRows[0];
                txtStaffID.Text = dr.Cells[0].Value.ToString();
                txtStaffName.Text = dr.Cells[1].Value.ToString();
                txtStaffPhone.Text = dr.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "")
            {
                MessageBox.Show("ID can not be null");
                return;
            }
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Name can not be null");
                return;
            }
            if (txtStaffPhone.Text == "")
            {
                MessageBox.Show("phone can not be null");
                return;
            }

            string StaffID, Name, Phone;
            StaffID = txtStaffID.Text;
            Name = txtStaffName.Text;
            Phone = txtStaffPhone.Text;

            if (!st2.FindStaff(StaffID))//to check the record to be updated exists
            {
                MessageBox.Show(" record not found!!");
                return;
            }

            if (st2.UpdateStaffRecord(StaffID, Name, Phone))
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
