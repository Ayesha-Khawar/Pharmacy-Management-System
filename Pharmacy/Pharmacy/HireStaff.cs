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
    public partial class HireStaff : Form
    {
        public HireStaff()
        {
            InitializeComponent();
        }
        staffCLASS st1 = new staffCLASS();
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
        void ClearForm()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            txtStaffPhone.Clear();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            if(txtStaffID.Text == "")
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

            if (st1.FindStaff(StaffID))
            {
                MessageBox.Show(" record already exists!!");
                return;
            }

            if (st1.AddStaffRecord(StaffID, Name, Phone))
            {

                MessageBox.Show("HIRED!!");
                DisplayRecords();
                ClearForm();
            }
            else
            {
                MessageBox.Show("error adding record!!!");
            }
        }

        private void HireStaff_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();   
        }
    }
}
