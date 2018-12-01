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
    public partial class frmTimeSheet : Form
    {
        public frmTimeSheet()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            toSaveTimeSheet(getDataToSave());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTimeSheet_Load(object sender, EventArgs e)
        {
            getInitialData();
        }

        private void getInitialData()
        {
            lblTimeSheetDateFrom.Text = forGeneratePayroll.forGeneratePayrollVO.getDateFrom();
            lblTimeSheetDateTo.Text = forGeneratePayroll.forGeneratePayrollVO.getDateTo();
            lblEmployeeNameContent.Text = forGeneratePayroll.forGeneratePayrollVO.getEmployeeName();

            lblDay1.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).ToString("MMMM dd, ddd");
            lblDay2.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(1).ToString("MMMM dd, ddd");
            lblDay3.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(2).ToString("MMMM dd, ddd");
            lblDay4.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(3).ToString("MMMM dd, ddd");
            lblDay5.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(4).ToString("MMMM dd, ddd");
            lblDay6.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(5).ToString("MMMM dd, ddd");
            lblDay7.Text = Convert.ToDateTime(lblTimeSheetDateFrom.Text).AddDays(6).ToString("MMMM dd, ddd");
        }

        private void toSaveTimeSheet(Dictionary<string,string> data)
        {
            forGenerateTimeSheet.ForGenerateTimeSheetDAO.insertTimeSheet(data);
        }


        private Dictionary<string,string> getDataToSave()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["day0date"] = lblDay1.Text;
            data["day0timeIn"] = txtDay1TimeIn.Text;
            data["day0timeOut"] = txtDay1TimeOut.Text;
            data["day0remarks"] = cbRemarksDay1.Text;

            data["day1date"] = lblDay2.Text;
            data["day1timeIn"] = txtday2TimeIn.Text;
            data["day1timeOut"] = txtDay2TimeOut.Text;
            data["day1remarks"] = cbRemarksDay2.Text;

            data["day2date"] = lblDay3.Text;
            data["day2timeIn"] = txtDay3timeIn.Text;
            data["day2timeOut"] = txtDay3TimeOut.Text;
            data["day2remarks"] = cbRemarksDay3.Text;

            data["day3date"] = lblDay4.Text;
            data["day3timeIn"] = txtDay4TimeIn.Text;
            data["day3timeOut"] = txtDay4TimeOut.Text;
            data["day3remarks"] = cbRemarksDay4.Text;

            data["day4date"] = lblDay5.Text;
            data["day4timeIn"] = txtDay5TimeIn.Text;
            data["day4timeOut"] = txtDay5TimeOut.Text;
            data["day4remarks"] = cbRemarksDay5.Text;

            data["day5date"] = lblDay6.Text;
            data["day5timeIn"] = txtDay6TimeIn.Text;
            data["day5timeOut"] = txtDay6TimeOut.Text;
            data["day5remarks"] = cbRemarksDay6.Text;

            data["day6date"] = lblDay7.Text;
            data["day6timeIn"] = txtDay7TimeIn.Text;
            data["day6timeOut"] = txtDay7TimeOut.Text;
            data["day6remarks"] = cbRemarksDay7.Text;

            return data;
        }

        private void all_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf(':') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
