using System;
using System.Windows.Forms;

namespace GatebankPayroll
{
    public partial class frmEmployeeTimeSheet : Form
    {
        public frmEmployeeTimeSheet()
        {
            InitializeComponent();
        }

        private void frmEmployeeTimeSheet_Load(object sender, EventArgs e)
        {
            getTimeSheetData(Convert.ToInt32(forLogin.ForLoginVO.getID()),"","");
        }

        private void getTimeSheetData(int id, string date, string forLoad)
        {
            lvTimeSheet.Items.Clear();
            string[,] data = forGenerateTimeSheet.ForGenerateTimeSheetDAO.getEmployeeTimeSheet(id, date, forLoad);
            for (int x = 0; x < data.Length / 5; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(data[x, i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lvTimeSheet.Items.Add(lv);
            }
        }

        private void brtSearch_Click(object sender, EventArgs e)
        {
            getTimeSheetData(Convert.ToInt32(forLogin.ForLoginVO.getID()), dtpDateSearch.Text,"search");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getTimeSheetData(Convert.ToInt32(forLogin.ForLoginVO.getID()), "","");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
