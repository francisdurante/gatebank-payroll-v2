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
    public partial class frmParameters : Form
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

        ArrayList initialData;

        public frmParameters()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmParameters_Load(object sender, EventArgs e)
        {
            getInitialData();
        }

        public void getInitialData()
        {
            initialData = new ArrayList();
            initialData = forParameters.ForParametersDAO.getAllParameters();
            txtPagIbig.Text = initialData[0].ToString();
            txtPhilHealth.Text = initialData[1].ToString();
            txtProviFund.Text = initialData[2].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            forParameters.ForParametersDAO.toSaveParameters(txtPagIbig.Text, txtPhilHealth.Text, txtProviFund.Text);
        }
    }
}
