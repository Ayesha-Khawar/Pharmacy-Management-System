using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class searchCustomer : Form
    {
        customerCLASS cc = new customerCLASS();
        public searchCustomer()
        {
            InitializeComponent();
        }

        private void searchCustomer_Load(object sender, EventArgs e)
        {
            DBConnection.GetConnection();
        }

        private void btnfindCust_Click(object sender, EventArgs e)
        {
            DisplayRecords();
        }
        void DisplayRecords()
        {
            string Name;
            Name = txtCustomerID.Text;
            
            dgvSearchCustomer.DataSource = cc.searchcustRecords(Name);
            dgvSearchCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSearchCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearchCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSearchCustomer.ReadOnly = true;
            dgvSearchCustomer.Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
