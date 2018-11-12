﻿using System;
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
    public partial class frmGeneratePayroll : Form
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
        Dictionary<string,string> employeeNames;
        public frmGeneratePayroll()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            all_onLeave();
            if(forGeneratePayroll.forGeneratePayrollDAO.saveGeneratedpayroll(txtSSSD.Text, txtPagIbigD.Text, txtPHD.Text, txtWTaxD.Text, txtSSSLoanD.Text, txtPagIbigLoan.Text,
                txtProviLoan.Text, txtAbsent.Text, txtLate.Text, txtProviFund.Text, txtSMCard.Text, txtArHCard.Text, txtOther.Text,
                txtOT.Text, txtAllowance.Text, txtIncentives.Text, txtBonus.Text, txtOther1Txt.Text, txtOther1.Text, txtOther2Txt.Text, txtOther2.Text, txtOther3Txt.Text, txtOther3.Text,
                txtRemarks.Text, cnEmployeeName.Text, dtpFrom.Text, dtpTo.Text))
            {
                MessageBox.Show("Payroll Saved", "Gearate Payroll", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Payroll Error to Saved", "Gearate Payroll", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmGeneratePayroll_Load(object sender, EventArgs e)
        {
            cnEmployeeName.Text = "---Select Employee---";
            textBoxOnloadValue();
            getEmployeeName();
        }

        public void textBoxOnloadValue()
        {
            txtPagIbigD.Text = "0.00";
            txtPHD.Text = "0.00";
            txtSSSD.Text = "0.00";
            txtWTaxD.Text = "0.00";
            txtSSSLoanD.Text = "0.00";
            txtProviLoan.Text = "0.00";
            txtPagIbigLoan.Text = "0.00";

            txtAbsent.Text = "0.00";
            txtLate.Text = "0.00";
            txtProviFund.Text = "0.00";
            txtSMCard.Text = "0.00";
            txtArHCard.Text = "0.00";
            txtOther.Text = "0.00";

            txtOT.Text = "0.00";
            txtIncentives.Text = "0.00";
            txtBonus.Text = "0.00";
            txtAllowance.Text = "0.00";
            txtOther1.Text = "0.00";
            txtOther2.Text = "0.00";
            txtOther3.Text = "0.00";
        }
        public void getEmployeeName()
        {
            cnEmployeeName.Items.Clear();
            cnEmployeeName.Items.Add("---Select Employee---");
            employeeNames = Global.getEmployeeName(1);
            for(int x = 0; x < employeeNames.Count; x++)
            {
                cnEmployeeName.Items.Add(employeeNames["name"+x]);
            }
        }

        private void gbEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void cnEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cnEmployeeName.SelectedIndex != 0)
            {
                for (int x = 0; x < employeeNames.Count; x++)
                {
                    lblBasicSalaryContent.Text = employeeNames[cnEmployeeName.Text + "salary"];
                    lblPositionContent.Text = employeeNames[cnEmployeeName.Text + "position"];
                    lblBranchContent.Text = employeeNames[cnEmployeeName.Text + "branch"];
                }
            }
        }
        private bool employeeExisting()
        {
            bool exist = false;
            if (cnEmployeeName.Text == "")
            {
                MessageBox.Show("Please Select Branch", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cnEmployeeName.Focus();
            }
            for (int x = 0; x < employeeNames.Count; x++)
            {
                if (cnEmployeeName.Text != employeeNames["name"+x])
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
                cnEmployeeName.Text = "---Select Employee---";
            }
            return exist;
        }

        private void cnEmployeeName_Leave(object sender, EventArgs e)
        {
            employeeExisting();
        }
        private void all_onEnter(object sender, EventArgs e)
        {

        }
        private void all_onLeave()
        {
            var gd = this.gbGDeduction.Controls.OfType<TextBox>().ToArray();
            foreach (TextBox  t in gd)
            {
                if(t.Text == "")
                {
                    t.Text = "0.00";
                }
            }

            var ld = this.gbLoanDeductions.Controls.OfType<TextBox>().ToArray();
            foreach (TextBox t in ld)
            {
                if (t.Text == "")
                {
                    t.Text = "0.00";
                }
            }

            var cd = this.gbComanyDeduction.Controls.OfType<TextBox>().ToArray();
            foreach (TextBox t in cd)
            {
                if (t.Text == "")
                {
                    t.Text = "0.00";
                }
            }

            var add = this.gbAdditional.Controls.OfType<TextBox>().ToArray();
            foreach (TextBox t in add)
            {
                if (t.Text == "")
                {
                    t.Text = "0.00";
                }
            }
            if (txtOther1.Text == "") { txtOther1.Text = "0.00"; }
            if (txtOther2.Text == "") { txtOther2.Text = "0.00"; }
            if (txtOther3.Text == "") { txtOther3.Text = "0.00"; }
        }
    }
}
