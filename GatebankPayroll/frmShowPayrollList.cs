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
    public partial class frmShowPayrollList : Form
    {
        public frmShowPayrollList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getAllPayrollList(string id)
        {
            lvPayrollList.Items.Clear();
            string[,] datas = forShowPayrollList.ForShowPayrollListDAO.getAllPayrollList(id);
            for (int x = 0; x < datas.Length / 4; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(datas[x, i]);
                lv.SubItems.Add(datas[x, ++i]);
                lv.SubItems.Add(datas[x, ++i]);
                lv.SubItems.Add(datas[x, ++i]);
                lvPayrollList.Items.Add(lv);
            }
        }

        private void frmShowPayrollList_Load(object sender, EventArgs e)
        {
            getAllPayrollList(forLogin.ForLoginVO.getID().ToString());
        }

        private void lvPayrollList_DoubleClick(object sender, EventArgs e)
        {
            showReport();
        }

        private void btnGenratePayroll_Click(object sender, EventArgs e)
        {
            showReport();
        }

        private void showReport()
        {
            if (lvPayrollList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvPayrollList.SelectedItems;
                forShowPayrollList.ForShowPayrollLisVO.setPayrollDetailsID(items[0].SubItems[0].Text);

                frmPayrollDetailsReport fbu = new frmPayrollDetailsReport();
                fbu.MdiParent = this.MdiParent;
                fbu.Show();
            }
        }
    }
}
