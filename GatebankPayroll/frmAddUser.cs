using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            toSaveUser(txtFullname.Text, txtLoginID.Text, txtLoginID.Text);
        }


        private void toSaveUser(string fullName, string logId, string password)
        {
            if(forBrowseUser.ForBrowseUserDAO.saveUser(fullName,logId,password) != 1)
            {
                MessageBox.Show("User Add Successful", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLoginID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmBrowseUser fbu = new frmBrowseUser();
            fbu.MdiParent = this.MdiParent;
            fbu.Show();
            Close();
        }
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
