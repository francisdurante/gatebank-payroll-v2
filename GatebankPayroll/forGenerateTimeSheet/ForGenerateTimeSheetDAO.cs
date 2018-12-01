using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forGenerateTimeSheet
{
    class ForGenerateTimeSheetDAO
    {
        public static void insertTimeSheet(Dictionary<string, string> data)
        {
            Connection cn = new Connection();
            try
            {
                for(int x = 0; x < data.Count / 4; x++)
                {
                    SqlCommand insertTimeSheet = new SqlCommand("dbo.spInsertTimeSheet", cn.connect());
                    insertTimeSheet.CommandType = System.Data.CommandType.StoredProcedure;
                    insertTimeSheet.Parameters.AddWithValue("@employeeID", Convert.ToInt32(forGeneratePayroll.forGeneratePayrollVO.getEmployeeID()));
                    insertTimeSheet.Parameters.AddWithValue("@date", Convert.ToDateTime(data["day" + x + "date"]));
                    insertTimeSheet.Parameters.AddWithValue("@timeIn", data["day" + x + "timeIn"]);
                    insertTimeSheet.Parameters.AddWithValue("@timeOut", data["day" + x + "timeOut"]);
                    insertTimeSheet.Parameters.AddWithValue("@remarks", data["day" + x + "remarks"]);
                    insertTimeSheet.ExecuteNonQuery();
                }
                MessageBox.Show("Time Sheet Saved", "Time sheet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.connect().Close();
        }

        public static string[,] getEmployeeTimeSheet(int id, string date,string forLoad)
        {
            string[,] users = null;
            Connection cn = new Connection();
            try
            {
                SqlCommand toGetCount = new SqlCommand("SELECT COUNT(*) FROM TimeSheet WHERE EmployeeID LIKE @employeeID", cn.connect());
                toGetCount.Parameters.AddWithValue("@employeeID", id);
                int length = (int)toGetCount.ExecuteScalar();
                users = new string[length, 5];
                SqlCommand toGetTimeSheetData = new SqlCommand("dbo.spGetEmployeetimeSheet", cn.connect());
                toGetTimeSheetData.CommandType = System.Data.CommandType.StoredProcedure;
                toGetTimeSheetData.Parameters.AddWithValue("@employeeID", id);
                if (forLoad == "search")
                {
                    toGetTimeSheetData.Parameters.AddWithValue("@date", "%" + Convert.ToDateTime(date).ToString("yyyy-MM-dd") + "%");
                }
                else
                {
                    toGetTimeSheetData.Parameters.AddWithValue("@date", "%" + date + "%");
                }

                SqlDataReader toGetTimeSheetDataReader = toGetTimeSheetData.ExecuteReader();
                if (toGetTimeSheetDataReader.HasRows)
                {
                    int x = 0;
                    while (toGetTimeSheetDataReader.Read())
                    {
                        int i = 0;
                        users[x, i] = toGetTimeSheetDataReader.GetValue(0).ToString(); //ID
                        users[x, ++i] = Convert.ToDateTime(toGetTimeSheetDataReader.GetValue(2)).ToString("MMMM dd, ddd"); //Time sheet day
                        users[x, ++i] = toGetTimeSheetDataReader.GetValue(3).ToString() == "" ? "N/A" : toGetTimeSheetDataReader.GetValue(3).ToString(); //time in
                        users[x, ++i] = toGetTimeSheetDataReader.GetValue(4).ToString() == "" ? "N/A" : toGetTimeSheetDataReader.GetValue(4).ToString();  //time out
                        users[x, ++i] = toGetTimeSheetDataReader.GetValue(5).ToString(); // remarks
                        x++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                users = null;
            }
            cn.connect().Close();

            return users;
        }
    }
}
