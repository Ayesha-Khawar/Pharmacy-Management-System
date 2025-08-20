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
    public partial class EditCust : Form
    {
        public EditCust()
        {
            InitializeComponent();
        }
     //   customerCLASS c1 = new customerCLASS();
        customerCLASS c2 = new customerCLASS();
        customerCLASS c3 = new customerCLASS();
        void DisplayRecords()
        {
            dgvCustomer.DataSource = c3.GetCustomerRecords();
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomer.ReadOnly = true;
            dgvCustomer.Refresh();
        }
        void ClearForm()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtCustomerAddress.Clear();
            txtCustomerPhone.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvCustomer.SelectedRows[0];
                txtCustomerID.Text = dr.Cells[0].Value.ToString();
                txtCustomerName.Text = dr.Cells[1].Value.ToString();
                txtCustomerAddress.Text = dr.Cells[2].Value.ToString();
                txtCustomerPhone.Text = dr.Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("ID can not be null");
                return;
            }
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Name can not be null");
                return;
            }
            if (txtCustomerAddress.Text == "")
            {
                MessageBox.Show("address can not be null");
                return;
            }
            if (txtCustomerPhone.Text == "")
            {
                MessageBox.Show("phone can not be null");
                return;
            }

            string CustomerID, Name, Address, Phone;
            CustomerID = txtCustomerID.Text;
            Name = txtCustomerName.Text;
            Address = txtCustomerAddress.Text;
            Phone = txtCustomerPhone.Text;

            if (!c2.FindCustomer(CustomerID))//to check the record to be updated exists
            {
                MessageBox.Show(" record not found!!");
                return;
            }

            if (c2.UpdateCustomerRecord(CustomerID, Name, Address, Phone))
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

        private void EditCust_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }
    }
}
