using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GatebankPayroll
{
    public partial class SSSTable : Form
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
        public SSSTable()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void SSSTable_Load(object sender, EventArgs e)
        {
            toRetrieveSSSTable();
        }

        private void txtSSS13_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSSS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSSS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
        private void btnButton_Click(object sender, EventArgs e)
        {
            toSaveOrUpdate();
        }

        private void toSaveOrUpdate()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckIfHave = new SqlCommand("SELECT * FROM SSSTable WHERE SSS_id = 1", cn.connect());
                SqlDataReader toCheckIfHaveReader = toCheckIfHave.ExecuteReader();
                if(!toCheckIfHaveReader.HasRows)
                {
                    SqlCommand toInsertInSSSTable = new SqlCommand("INSERT INTO tbl_sss_table("
                        + "SSS_range1,"
                        + "SSS_range2,"
                        + "SSS_range3,"
                        + "SSS_range4,"
                        + "SSS_range5,"
                        + "SSS_range6,"
                        + "SSS_range7,"
                        + "SSS_range8,"
                        + "SSS_range9,"
                        + "SSS_range10,"
                        + "SSS_range11,"
                        + "SSS_range12,"
                        + "SSS_range13,"
                        + "SSS_range14,"
                        + "SSS_range15,"
                        + "SSS_range16,"
                        + "SSS_range17,"
                        + "SSS_range18,"
                        + "SSS_range19,"
                        + "SSS_range20,"
                        + "SSS_range21,"
                        + "SSS_range22,"
                        + "SSS_range23,"
                        + "SSS_range24,"
                        + "SSS_range25,"
                        + "SSS_range26,"
                        + "SSS_range27,"
                        + "SSS_range28,"
                        + "SSS_range29,"
                        + "SSS_range30,"
                        + "SSS_range31,"
                        + "SSS_ER_range1,"
                        + "SSS_ER_range2,"
                        + "SSS_ER_range3,"
                        + "SSS_ER_range4,"
                        + "SSS_ER_range5,"
                        + "SSS_ER_range6,"
                        + "SSS_ER_range7,"
                        + "SSS_ER_range8,"
                        + "SSS_ER_range9,"
                        + "SSS_ER_range10,"
                        + "SSS_ER_range11,"
                        + "SSS_ER_range12,"
                        + "SSS_ER_range13,"
                        + "SSS_ER_range14,"
                        + "SSS_ER_range15,"
                        + "SSS_ER_range16,"
                        + "SSS_ER_range17,"
                        + "SSS_ER_range18,"
                        + "SSS_ER_range19,"
                        + "SSS_ER_range20,"
                        + "SSS_ER_range21,"
                        + "SSS_ER_range22,"
                        + "SSS_ER_range23,"
                        + "SSS_ER_range24,"
                        + "SSS_ER_range25,"
                        + "SSS_ER_range26,"
                        + "SSS_ER_range27,"
                        + "SSS_ER_range28,"
                        + "SSS_ER_range29,"
                        + "SSS_ER_range30,"
                        + "SSS_ER_range31)"
                        + " VALUES(@sss1,"
                        + "@sss2,"
                        + "@sss3,"
                        + "@sss4,"
                        + "@sss5,"
                        + "@sss6,"
                        + "@sss7,"
                        + "@sss8,"
                        + "@sss9,"
                        + "@sss10,"
                        + "@sss11,"
                        + "@sss12,"
                        + "@sss13,"
                        + "@sss14,"
                        + "@sss15,"
                        + "@sss16,"
                        + "@sss17,"
                        + "@sss18,"
                        + "@sss19,"
                        + "@sss20,"
                        + "@sss21,"
                        + "@sss22,"
                        + "@sss23,"
                        + "@sss24,"
                        + "@sss25,"
                        + "@sss26,"
                        + "@sss27,"
                        + "@sss28,"
                        + "@sss29,"
                        + "@sss30,"
                        + "@sss31,"
                        + "@sssER1,"
                        + "@sssER2,"
                        + "@sssER3,"
                        + "@sssER4,"
                        + "@sssER5,"
                        + "@sssER6,"
                        + "@sssER7,"
                        + "@sssER8,"
                        + "@sssER9,"
                        + "@sssER10,"
                        + "@sssER11,"
                        + "@sssER12,"
                        + "@sssER13,"
                        + "@sssER14,"
                        + "@sssER15,"
                        + "@sssER16,"
                        + "@sssER17,"
                        + "@sssER18,"
                        + "@sssER19,"
                        + "@sssER20,"
                        + "@sssER21,"
                        + "@sssER22,"
                        + "@sssER23,"
                        + "@sssER24,"
                        + "@sssER25,"
                        + "@sssER26,"
                        + "@sssER27,"
                        + "@sssER28,"
                        + "@sssER29,"
                        + "@sssER30,"
                        + "@sssER31)", cn.connect());
                    toInsertInSSSTable.Parameters.AddWithValue("@sss1", txtSSS1.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss2", txtSSS2.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss3", txtSSS3.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss4", txtSSS4.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss5", txtSSS5.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss6", txtSSS6.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss7", txtSSS7.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss8", txtSSS8.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss9", txtSSS9.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss10", txtSSS10.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss11", txtSSS11.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss12", txtSSS12.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss13", txtSSS13.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss14", txtSSS14.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss15", txtSSS15.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss16", txtSSS16.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss17", txtSSS17.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss18", txtSSS18.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss19", txtSSS19.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss20", txtSSS20.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss21", txtSSS21.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss22", txtSSS22.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss23", txtSSS23.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss24", txtSSS24.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss25", txtSSS25.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss26", txtSSS26.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss27", txtSSS27.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss28", txtSSS28.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss29", txtSSS29.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss30", txtSSS30.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sss31", txtSSS31.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER1", txtERSSS1.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER2", txtERSSS2.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER3", txtERSSS3.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER4", txtERSSS4.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER5", txtERSSS5.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER6", txtERSSS6.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER7", txtERSSS7.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER8", txtERSSS8.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER9", txtERSSS9.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER10", txtERSSS10.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER11", txtERSSS11.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER12", txtERSSS12.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER13", txtERSSS13.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER14", txtERSSS14.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER15", txtERSSS15.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER16", txtERSSS16.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER17", txtERSSS17.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER18", txtERSSS18.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER19", txtERSSS19.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER20", txtERSSS20.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER21", txtERSSS21.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER22", txtERSSS22.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER23", txtERSSS23.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER24", txtERSSS24.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER25", txtERSSS25.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER26", txtERSSS26.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER27", txtERSSS27.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER28", txtERSSS28.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER29", txtERSSS29.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER30", txtERSSS30.Text);
                    toInsertInSSSTable.Parameters.AddWithValue("@sssER31", txtERSSS31.Text);
                    toInsertInSSSTable.ExecuteNonQuery();
                    MessageBox.Show("SSS Table Inserted!");
                    cn.connect().Close();
                }
                else
                {
                    SqlCommand toUpdateSSSTable = new SqlCommand("UPDATE SSSTable SET "
                        + "SSS_range1 = @sss1,"
                        + "SSS_range2 = @sss2,"
                        + "SSS_range3 = @sss3,"
                        + "SSS_range4 = @sss4,"
                        + "SSS_range5 = @sss5,"
                        + "SSS_range6 = @sss6,"
                        + "SSS_range7 = @sss7,"
                        + "SSS_range8 = @sss8,"
                        + "SSS_range9 = @sss9,"
                        + "SSS_range10 = @sss10,"
                        + "SSS_range11 = @sss11,"
                        + "SSS_range12 = @sss12,"
                        + "SSS_range13 = @sss13,"
                        + "SSS_range14 = @sss14,"
                        + "SSS_range15 = @sss15,"
                        + "SSS_range16 = @sss16,"
                        + "SSS_range17 = @sss17,"
                        + "SSS_range18 = @sss18,"
                        + "SSS_range19 = @sss19,"
                        + "SSS_range20 = @sss20,"
                        + "SSS_range21 = @sss21,"
                        + "SSS_range22 = @sss22,"
                        + "SSS_range23 = @sss23,"
                        + "SSS_range24 = @sss24,"
                        + "SSS_range25 = @sss25,"
                        + "SSS_range26 = @sss26,"
                        + "SSS_range27 = @sss27,"
                        + "SSS_range28 = @sss28,"
                        + "SSS_range29 = @sss29,"
                        + "SSS_range30 = @sss30,"
                        + "SSS_range31 = @sss31,"
                        + "SSS_ER_range1 = @sssEE1,"
                        + "SSS_ER_range2 = @sssEE2,"
                        + "SSS_ER_range3 = @sssEE3,"
                        + "SSS_ER_range4 = @sssEE4,"
                        + "SSS_ER_range5 = @sssEE5,"
                        + "SSS_ER_range6 = @sssEE6,"
                        + "SSS_ER_range7 = @sssEE7,"
                        + "SSS_ER_range8 = @sssEE8,"
                        + "SSS_ER_range9 = @sssEE9,"
                        + "SSS_ER_range10 = @sssEE10,"
                        + "SSS_ER_range11 = @sssEE11,"
                        + "SSS_ER_range12 = @sssEE12,"
                        + "SSS_ER_range13 = @sssEE13,"
                        + "SSS_ER_range14 = @sssEE14,"
                        + "SSS_ER_range15 = @sssEE15,"
                        + "SSS_ER_range16 = @sssEE16,"
                        + "SSS_ER_range17 = @sssEE17,"
                        + "SSS_ER_range18 = @sssEE18,"
                        + "SSS_ER_range19 = @sssEE19,"
                        + "SSS_ER_range20 = @sssEE20,"
                        + "SSS_ER_range21 = @sssEE21,"
                        + "SSS_ER_range22 = @sssEE22,"
                        + "SSS_ER_range23 = @sssEE23,"
                        + "SSS_ER_range24 = @sssEE24,"
                        + "SSS_ER_range25 = @sssEE25,"
                        + "SSS_ER_range26 = @sssEE26,"
                        + "SSS_ER_range27 = @sssEE27,"
                        + "SSS_ER_range28 = @sssEE28,"
                        + "SSS_ER_range29 = @sssEE29,"
                        + "SSS_ER_range30 = @sssEE30,"
                        + "SSS_ER_range31 = @sssEE31 WHERE SSS_id = 1", cn.connect());

                    toUpdateSSSTable.Parameters.AddWithValue("@sss1", txtSSS1.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss2", txtSSS2.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss3", txtSSS3.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss4", txtSSS4.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss5", txtSSS5.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss6", txtSSS6.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss7", txtSSS7.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss8", txtSSS8.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss9", txtSSS9.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss10", txtSSS10.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss11", txtSSS11.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss12", txtSSS12.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss13", txtSSS13.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss14", txtSSS14.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss15", txtSSS15.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss16", txtSSS16.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss17", txtSSS17.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss18", txtSSS18.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss19", txtSSS19.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss20", txtSSS20.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss21", txtSSS21.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss22", txtSSS22.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss23", txtSSS23.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss24", txtSSS24.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss25", txtSSS25.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss26", txtSSS26.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss27", txtSSS27.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss28", txtSSS28.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss29", txtSSS29.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss30", txtSSS30.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sss31", txtSSS31.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE1", txtERSSS1.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE2", txtERSSS2.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE3", txtERSSS3.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE4", txtERSSS4.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE5", txtERSSS5.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE6", txtERSSS6.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE7", txtERSSS7.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE8", txtERSSS8.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE9", txtERSSS9.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE10", txtERSSS10.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE11", txtERSSS11.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE12", txtERSSS12.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE13", txtERSSS13.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE14", txtERSSS14.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE15", txtERSSS15.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE16", txtERSSS16.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE17", txtERSSS17.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE18", txtERSSS18.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE19", txtERSSS19.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE20", txtERSSS20.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE21", txtERSSS21.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE22", txtERSSS22.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE23", txtERSSS23.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE24", txtERSSS24.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE25", txtERSSS25.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE26", txtERSSS26.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE27", txtERSSS27.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE28", txtERSSS28.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE29", txtERSSS29.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE30", txtERSSS30.Text);
                    toUpdateSSSTable.Parameters.AddWithValue("@sssEE31", txtERSSS31.Text);
                    toUpdateSSSTable.ExecuteNonQuery();
                    MessageBox.Show("SSS table Updated!");
                    cn.connect().Close();
                }
            }catch(Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
            }
        }

        private void toRetrieveSSSTable()
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toRetrieveData = new SqlCommand("SELECT * FROM SSSTable WHERE SSS_id = 1", cn.connect());
                SqlDataReader toRetrieveDataReader = toRetrieveData.ExecuteReader();
                if (toRetrieveDataReader.HasRows)
                {
                    while (toRetrieveDataReader.Read())
                    {
                        txtSSS1.Text = toRetrieveDataReader.GetDouble(1).ToString();
                        txtSSS2.Text = toRetrieveDataReader.GetDouble(2).ToString();
                        txtSSS3.Text = toRetrieveDataReader.GetDouble(3).ToString();
                        txtSSS4.Text = toRetrieveDataReader.GetDouble(4).ToString();
                        txtSSS5.Text = toRetrieveDataReader.GetDouble(5).ToString();
                        txtSSS6.Text = toRetrieveDataReader.GetDouble(6).ToString();
                        txtSSS7.Text = toRetrieveDataReader.GetDouble(7).ToString();
                        txtSSS8.Text = toRetrieveDataReader.GetDouble(8).ToString();
                        txtSSS9.Text = toRetrieveDataReader.GetDouble(9).ToString();
                        txtSSS10.Text = toRetrieveDataReader.GetDouble(10).ToString();
                        txtSSS11.Text = toRetrieveDataReader.GetDouble(11).ToString();
                        txtSSS12.Text = toRetrieveDataReader.GetDouble(12).ToString();
                        txtSSS13.Text = toRetrieveDataReader.GetDouble(13).ToString();
                        txtSSS14.Text = toRetrieveDataReader.GetDouble(14).ToString();
                        txtSSS15.Text = toRetrieveDataReader.GetDouble(15).ToString();
                        txtSSS16.Text = toRetrieveDataReader.GetDouble(16).ToString();
                        txtSSS17.Text = toRetrieveDataReader.GetDouble(17).ToString();
                        txtSSS18.Text = toRetrieveDataReader.GetDouble(18).ToString();
                        txtSSS19.Text = toRetrieveDataReader.GetDouble(19).ToString();
                        txtSSS20.Text = toRetrieveDataReader.GetDouble(20).ToString();
                        txtSSS21.Text = toRetrieveDataReader.GetDouble(21).ToString();
                        txtSSS22.Text = toRetrieveDataReader.GetDouble(22).ToString();
                        txtSSS23.Text = toRetrieveDataReader.GetDouble(23).ToString();
                        txtSSS24.Text = toRetrieveDataReader.GetDouble(24).ToString();
                        txtSSS25.Text = toRetrieveDataReader.GetDouble(25).ToString();
                        txtSSS26.Text = toRetrieveDataReader.GetDouble(26).ToString();
                        txtSSS27.Text = toRetrieveDataReader.GetDouble(27).ToString();
                        txtSSS28.Text = toRetrieveDataReader.GetDouble(28).ToString();
                        txtSSS29.Text = toRetrieveDataReader.GetDouble(29).ToString();
                        txtSSS30.Text = toRetrieveDataReader.GetDouble(30).ToString();
                        txtSSS31.Text = toRetrieveDataReader.GetDouble(31).ToString();

                        txtERSSS1.Text = toRetrieveDataReader.GetDouble(32).ToString();
                        txtERSSS2.Text = toRetrieveDataReader.GetDouble(33).ToString();
                        txtERSSS3.Text = toRetrieveDataReader.GetDouble(34).ToString();
                        txtERSSS4.Text = toRetrieveDataReader.GetDouble(35).ToString();
                        txtERSSS5.Text = toRetrieveDataReader.GetDouble(36).ToString();
                        txtERSSS6.Text = toRetrieveDataReader.GetDouble(37).ToString();
                        txtERSSS7.Text = toRetrieveDataReader.GetDouble(38).ToString();
                        txtERSSS8.Text = toRetrieveDataReader.GetDouble(39).ToString();
                        txtERSSS9.Text = toRetrieveDataReader.GetDouble(40).ToString();
                        txtERSSS10.Text = toRetrieveDataReader.GetDouble(41).ToString();
                        txtERSSS11.Text = toRetrieveDataReader.GetDouble(42).ToString();
                        txtERSSS12.Text = toRetrieveDataReader.GetDouble(43).ToString();
                        txtERSSS13.Text = toRetrieveDataReader.GetDouble(44).ToString();
                        txtERSSS14.Text = toRetrieveDataReader.GetDouble(45).ToString();
                        txtERSSS15.Text = toRetrieveDataReader.GetDouble(46).ToString();
                        txtERSSS16.Text = toRetrieveDataReader.GetDouble(47).ToString();
                        txtERSSS17.Text = toRetrieveDataReader.GetDouble(48).ToString();
                        txtERSSS18.Text = toRetrieveDataReader.GetDouble(49).ToString();
                        txtERSSS19.Text = toRetrieveDataReader.GetDouble(50).ToString();
                        txtERSSS20.Text = toRetrieveDataReader.GetDouble(51).ToString();
                        txtERSSS21.Text = toRetrieveDataReader.GetDouble(52).ToString();
                        txtERSSS22.Text = toRetrieveDataReader.GetDouble(53).ToString();
                        txtERSSS23.Text = toRetrieveDataReader.GetDouble(54).ToString();
                        txtERSSS24.Text = toRetrieveDataReader.GetDouble(55).ToString();
                        txtERSSS25.Text = toRetrieveDataReader.GetDouble(56).ToString();
                        txtERSSS26.Text = toRetrieveDataReader.GetDouble(57).ToString();
                        txtERSSS27.Text = toRetrieveDataReader.GetDouble(58).ToString();
                        txtERSSS28.Text = toRetrieveDataReader.GetDouble(59).ToString();
                        txtERSSS29.Text = toRetrieveDataReader.GetDouble(60).ToString();
                        txtERSSS30.Text = toRetrieveDataReader.GetDouble(61).ToString();
                        txtERSSS31.Text = toRetrieveDataReader.GetDouble(62).ToString();
                    }
                    toRetrieveDataReader.Close();
                    cn.connect().Close();
                }
                else
                {
                    MessageBox.Show("Please Insert New SSS Table!");
                    cn.connect().Close();
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
                cn.connect().Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
