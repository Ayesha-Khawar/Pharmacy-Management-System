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
    public partial class showsales : Form
    {
        public showsales()
        {
            InitializeComponent();
        }
        saleCLASS s1 = new saleCLASS();
        // saleCLASS s3 = new saleCLASS();
        //saleCLASS s2 = new saleCLASS();
        void DisplayRecords()
        {
            dgvSale.DataSource = s1.GetSaleRecords();
            dgvSale.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSale.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSale.ReadOnly = true;
            dgvSale.Refresh();
        }
        private void showsales_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();

        }
    }
}
