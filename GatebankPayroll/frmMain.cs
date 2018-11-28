using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.Azure;
                }
            }
            if(forLogin.ForLoginVO.getAccessLevel() == "Payroll Admin")
            {
                payrollMS.Visible = true;
                payrollMaintenanceMS.Visible = true;
                showPayrollMS.Visible = false;
            }
            else
            {
                payrollMS.Visible = false;
                payrollMaintenanceMS.Visible = false;
                showPayrollMS.Visible = true;
            }
            ssUserID.Text = "Logged User ID : " + forLogin.ForLoginVO.getUserID();
            ssFullname.Text = "Name : " + forLogin.ForLoginVO.getUserFullName();
            ssAccessLevel.Text = "Access Level : " + forLogin.ForLoginVO.getAccessLevel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ssDateTime.Text = "Date Time : " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit Program?", "Main Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = (dialog == DialogResult.No);
            }
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit Program?", "Main Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void generatePayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmGeneratePayroll"];
            if(f == null)
            {
                frmGeneratePayroll fgp = new frmGeneratePayroll();
                fgp.MdiParent = this;
                fgp.Show();
            }
            else
            {
                MessageBox.Show("Generate Payroll is Already Opened", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmAddEmployee"];
            if (f == null)
            {
                frmAddEmployee fgp = new frmAddEmployee();
                fgp.MdiParent = this;
                fgp.Show();
            }
            else
            {
                MessageBox.Show("Add Employee is Already Opened", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmParameters"];
            if (f == null)
            {
                frmParameters fgp = new frmParameters();
                fgp.MdiParent = this;
                fgp.Show();
            }
            else
            {
                MessageBox.Show("Parameter Form is Already Opened", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void browseParollUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmBrowseUser"];
            if (f == null)
            {
                frmBrowseUser fgp = new frmBrowseUser();
                fgp.MdiParent = this;
                fgp.Show();
            }
            else
            {
                MessageBox.Show("Browse User Form is Already Opened", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPayrollMS_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["frmShowPayrollList"];
            if (f == null)
            {
                frmShowPayrollList fgp = new frmShowPayrollList();
                fgp.MdiParent = this;
                fgp.Show();
            }
            else
            {
                MessageBox.Show("Payroll List Form is Already Opened", "Main Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
