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
    public partial class frmEditEmployee : Form
    {
        public frmEditEmployee()
        {
            InitializeComponent();
        }

        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            getPosition();
            getBranch();
            getEmployeeByID(forBrowseUser.ForBrowseUserVO.getID());
        }
        private void getPosition()
        {
            cbPosition.Items.Clear();
            ArrayList position = Global.getPosition(1);
            for (int x = 0; x < position.Count; x++)
            {
                cbPosition.Items.Add(position[x]);
            }
        }
        private void getBranch()
        {
            cbBranch.Items.Clear();
            ArrayList branchName = Global.getBranch(1);
            for (int x = 0; x < branchName.Count; x++)
            {
                cbBranch.Items.Add(branchName[x]);
            }
        }
        public void getEmployeeByID(string id)
        {
            string[,] data = forBrowseUser.ForBrowseUserDAO.getEmployeeDetailsById(id);
            txtFullName.Text = data[0, 0];
            txtBasicSalary.Text = data[0, 1];
            cbPosition.Text = data[0, 2];
            dtpDateHired.Text = data[0, 3];
            cbBranch.Text = data[0, 4];
            cbStatus.Text = data[0, 5];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(forBrowseUser.ForBrowseUserDAO.updateEmployeeDetails(txtFullName.Text, txtBasicSalary.Text, cbPosition.Text, dtpDateHired.Text, cbBranch.Text, cbStatus.Text,Convert.ToInt32(forBrowseUser.ForBrowseUserVO.getEmployeeID())))
            {
                MessageBox.Show("Update successful", "Update employee.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Employee details did not update.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
