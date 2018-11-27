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
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            setInitialData();
        }

        private void setInitialData()
        {
            ArrayList accessLevel = Global.getAllAccessLevel();
            cbAccessLevel.Items.Clear();
            for (int x = 0; x < accessLevel.Count; x++)
            {
                cbAccessLevel.Items.Add(accessLevel[x]);
            }
            txtFullname.Text = forBrowseUser.ForBrowseUserVO.getFullname();
            txtLoginID.Text = forBrowseUser.ForBrowseUserVO.getLoginId();
            cbAccessLevel.Text = forBrowseUser.ForBrowseUserVO.getAccessLevel();
            cbStatus.Text = forBrowseUser.ForBrowseUserVO.getStatus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmBrowseUser fbu = new frmBrowseUser();
            fbu.MdiParent = MdiParent;
            fbu.Show();
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(forBrowseUser.ForBrowseUserDAO.updateUsers(txtFullname.Text, cbAccessLevel.Text, cbStatus.Text == "ACTIVE" ? 1 : 0, Convert.ToInt32(forBrowseUser.ForBrowseUserVO.getID())))
            {
                frmBrowseUser fbu = new frmBrowseUser();
                fbu.MdiParent = MdiParent;
                fbu.Show();
                Close();
            }
        }
    }
}
