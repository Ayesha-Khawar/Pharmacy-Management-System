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
    public partial class ViewPrescription : Form
    {
        public ViewPrescription()
        {
            InitializeComponent();
        }
        presClass p1 = new presClass();
        // saleCLASS s3 = new saleCLASS();
        //saleCLASS s2 = new saleCLASS();
        void DisplayRecords()
        {
            dgvPrescription.DataSource =p1.GetPresRecords();
            dgvPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescription.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrescription.ReadOnly = true;
            dgvPrescription.Refresh();
        }
        private void ViewPrescription_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
            DisplayRecords();
        }

    }
}
