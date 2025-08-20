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
    public partial class deleteCust : Form
    {
        public deleteCust()
        {
            InitializeComponent();
        }
        customerCLASS c1 = new customerCLASS();
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0) //if row is selected
            {
                DataGridViewRow dr = dgvCustomer.SelectedRows[0];
                string CustomerID = dr.Cells[0].Value.ToString();
                DialogResult dia_res = MessageBox.Show("do you want to delete record?", "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dia_res == DialogResult.Yes)
                {
                    if (c2.DeleteCustomerRecord(CustomerID))//if record is deleted 
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

        private void deleteCust_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }
    }
}
