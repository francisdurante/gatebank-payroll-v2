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
    public partial class frmPayrollDetailsReport : Form
    {
        public frmPayrollDetailsReport()
        {
            InitializeComponent();
        }

        private void frmPayrollDetailsReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPayrollDetails.spReportGeneratedPayrollPerUser' table. You can move, or remove it, as needed.
            this.spReportGeneratedPayrollPerUserTableAdapter.Fill(this.dataSetPayrollDetails.spReportGeneratedPayrollPerUser,Convert.ToInt32(forShowPayrollList.ForShowPayrollLisVO.getPayrollDetailsID()));
            this.reportViewer1.RefreshReport();
        }
    }
}
