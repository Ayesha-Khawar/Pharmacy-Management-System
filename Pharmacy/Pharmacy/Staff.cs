using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
       // staffCLASS st1 = new staffCLASS();
        //staffCLASS st2 = new staffCLASS();
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
        
        private void Staff_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }

        
    }
}
