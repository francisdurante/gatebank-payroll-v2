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
                MessageBox.Show("Generate Payroll is Already Opened", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
