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
    public partial class frmBrowseUser : Form
    {
        public frmBrowseUser()
        {
            InitializeComponent();
        }

        private void frmBrowseUser_Load(object sender, EventArgs e)
        {
           getUsers(txtSearch.Text);
        }

        private void getUsers(string name)
        {
            lvUserList.Items.Clear();
            string[,] data = forBrowseUser.ForBrowseUserDAO.getUsers(name);
            for (int x = 0; x < data.Length / 5; x++)
            {
                int i = 0;
                ListViewItem lv = new ListViewItem(data[x, i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i]);
                lv.SubItems.Add(data[x, ++i] == "1" ? "ACTIVE" : data[x, ++i] == "0" ?"INACTIVE" : "");
                lvUserList.Items.Add(lv);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvUserList_DoubleClick(object sender, EventArgs e)
        {
            if (lvUserList.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lvUserList.SelectedItems;
                forBrowseUser.ForBrowseUserVO.setID(items[0].SubItems[0].Text);
                forBrowseUser.ForBrowseUserVO.setloginId(items[0].SubItems[1].Text);
                forBrowseUser.ForBrowseUserVO.setfullName(items[0].SubItems[2].Text);
                forBrowseUser.ForBrowseUserVO.setAccessLevel(items[0].SubItems[3].Text);
                forBrowseUser.ForBrowseUserVO.setStatus(items[0].SubItems[4].Text);

                frmEditUser fbu = new frmEditUser();
                fbu.MdiParent = this.MdiParent;
                fbu.Show();
            }
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getUsers(txtSearch.Text);
        }
    }
}
