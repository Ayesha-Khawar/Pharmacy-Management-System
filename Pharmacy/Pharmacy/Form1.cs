using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class frmLOGIN : Form
    {
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void frmLOGIN_Load(object sender, EventArgs e)
        {
            DBConnection.connect();
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            if(txtLoginId.Text == "")
            {
                MessageBox.Show("Login ID can not be null");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can not be null");
                return;
            }
            string LoginId = txtLoginId.Text;
            string Password = txtPassword.Text;
            PharmacyUser user = new PharmacyUser();
            if (user.findUser(LoginId, Password))
            {
                MainMenu frm = new MainMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("could not log in");
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
