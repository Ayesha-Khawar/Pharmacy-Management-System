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
    public partial class MainMenu : Form
    {
        // Field to keep track of the currently open child form
        private Form currentChildForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        // Method to open a new child form and close the previous one
        private void OpenChildForm(Form childForm)
        {
            // Close the current child form if it exists
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Set the new form as the current child form and display it
            currentChildForm = childForm;
            currentChildForm.MdiParent = this;
            currentChildForm.Show();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Medicine());
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void precriptionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewPrescription());
        }

        private void staffDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Staff());
        }

        private void salesDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new showsales());
        }

        private void hireStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HireStaff());
        }

        private void removeStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RemoveStaff());
        }

        private void updateStaffInfotmationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateSTaff());
        }

        private void showInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowInventory());
        }

        private void editMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditMed());
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new addMedicine());
        }

        private void deleteMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteMed());
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new addCust());
        }

        private void editCustomerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditCust());
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new deleteCust());
        }

        private void makeSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sale());
        }

        private void addPrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Prescriptionn());
        }

        private void deletePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Delete_Prescription());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deletePrescriptionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new DeletePrescription());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLOGIN frmLOGIN = new frmLOGIN();
            frmLOGIN.Show();
            this.Close();
        }

        private void aAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new addCust());
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditCust());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new deleteCust());
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new searchCustomer());
        }

        private void searchCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new searchCustomer());
        }
    }
}
