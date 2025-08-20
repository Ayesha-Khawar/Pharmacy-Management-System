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
    public partial class addCust : Form
    {
        public addCust()
        {
            InitializeComponent();
        }
        customerCLASS c1 = new customerCLASS();
       // customerCLASS c2 = new customerCLASS();
        //customerCLASS c3 = new customerCLASS();

        private void btnADD_Click(object sender, EventArgs e)
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

            if (c1.FindCustomer(CustomerID))
            {
                MessageBox.Show(" record already exists!!");
                return;
            }

            if (c1.AddCustomerfRecord(CustomerID, Name, Address, Phone))
            {
                MessageBox.Show("record added successfully");
                //DisplayRecords();
                //ClearForm();
            }
            else
            {
                MessageBox.Show("error adding record!!!");
            }
        }

        private void addCust_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
        }
    }
}
