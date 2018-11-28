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
    
    public partial class frmAddEmployee : Form
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
        ArrayList branchName;
        ArrayList position;
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            getBranch();
            getPosition();
            cbBranch.SelectedIndex = 0;
            cbPosition.SelectedIndex = 0;
            txtBasicSalary.Text = "0.00";
        }

        private void getBranch()
        {
            cbBranch.Items.Clear();
            branchName = Global.getBranch(1);
            for(int x = 0; x < branchName.Count; x++)
            {
                cbBranch.Items.Add(branchName[x]);
            }
        }
        private void getPosition()
        {
            cbPosition.Items.Clear();
            position = Global.getPosition(1);
            for(int x = 0; x < position.Count; x++)
            {
                cbPosition.Items.Add(position[x]);
            }
        }

        private void cbBranch_Leave(object sender, EventArgs e)
        {
            branchExisting();
        }
        private void cbPosition_Leave(object sender, EventArgs e)
        {
            positionExisting();
        }

        private void all_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtBasicSalary_Leave(object sender, EventArgs e)
        {
            if(txtBasicSalary.Text == "")
            {
                txtBasicSalary.Text = "0.00";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullname = txtFirstName.Text + " " + txtLastName.Text;
            if(forAddEmployee.forAddEmployeeDAO.insertEmployee(fullname, Convert.ToDouble(txtBasicSalary.Text), cbPosition.Text, Convert.ToDateTime(dtpDateHired.Text), cbBranch.Text,txtLoginID.Text))
            {
                MessageBox.Show("Password of employee for payroll account is same as their user login id", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Employee Already Exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// methods
        /// </summary>

        private bool branchExisting()
        {
            bool exist = false;
            if (cbBranch.Text == "")
            {
                MessageBox.Show("Please Select Branch", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbBranch.Focus();
            }
            for (int x = 0; x < branchName.Count; x++)
            {
                if (cbBranch.Text != branchName[x].ToString())
                {
                    exist = false;
                }
                else
                {
                    exist = true;
                    break;
                }
            }

            if (!exist)
            {
                cbBranch.SelectedIndex = 0;
            }
            return exist;
        }

        private bool positionExisting()
        {
            bool exist = false;
            if (cbPosition.Text == "")
            {
                MessageBox.Show("Please Select Position", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbBranch.Focus();
            }
            for (int x = 0; x < position.Count; x++)
            {
                if (cbPosition.Text != position[x].ToString())
                {
                    exist = false;
                }
                else
                {
                    exist = true;
                    break;
                }
            }

            if (!exist)
            {
                cbPosition.SelectedIndex = 0;
            }
            return exist;
        }
    }
}
