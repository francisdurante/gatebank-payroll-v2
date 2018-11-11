using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll
{
    public partial class frmConnectionStringSetting : Form
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
        public frmConnectionStringSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection("Data Source = " + txtServer.Text + "; Initial Catalog = " + txtDbName.Text + "; User ID = " + txtDbUsername.Text + "; Password = " + txtDbPassword.Text);
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connect Succeeded!");
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Connection Error!");
                    cnn.Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k + "Connection Error!");
                cnn.Close();
            }
            cnn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter text = new StreamWriter(Directory.GetCurrentDirectory() + "\\Resources\\Connection.txt");
                string cs = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDbName.Text + ";User ID=" + txtDbUsername.Text + ";Password=" + txtDbPassword.Text;
                string connectionString = Cryptography.Encrypt(cs);
                text.Write(connectionString);
                text.Close();
                Close();
            }
            catch
            {
                Close();
            }
        }
        private void RetrieveConnectionString()
        {
            string readText = Cryptography.Decrypt(File.ReadAllText(Directory.GetCurrentDirectory() + "\\Resources\\Connection.txt"));
            String[] cs = readText.Split(';');
            String[] ip = cs[0].Split('=');
            String[] database = cs[1].Split('=');
            String[] user = cs[2].Split('=');
            String[] password = cs[3].Split('=');
            txtServer.Text = ip[1];
            txtDbName.Text = database[1];
            txtDbUsername.Text = user[1];
            txtDbPassword.Text = password[1];
        }
        private void ConnectionString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConnectionStringSetting_Load(object sender, EventArgs e)
        {
            RetrieveConnectionString();
        }
    }
}
