using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll
{
    public partial class frmLogin : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLoginID.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please Complete the Information", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (forLogin.LoginDAO.loggedin(txtLoginID.Text, txtPassword.Text))
                {
                    case 0:
                        MessageBox.Show("User not exist", "Log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        Form f = Application.OpenForms["frmMain"];
                        if(f == null)
                        {
                            this.Hide();
                            frmMain fm = new frmMain();
                            fm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Main Form is Already Opened", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 2 :
                        MessageBox.Show("Something went Wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 500:
                        MessageBox.Show("Error Occured In logging in", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                Form f = Application.OpenForms["frmConnectionStringSetting"];
                if (f == null)
                {
                    frmConnectionStringSetting cs = new frmConnectionStringSetting();
                    cs.Show();
                }
                else
                {
                    MessageBox.Show("Connection String Setting Form is Already Open", "Open Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtLoginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
