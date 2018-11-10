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
    public partial class frmGeneratePayroll : Form
    {
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
            textBoxOnloadValue();
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
    }
}
