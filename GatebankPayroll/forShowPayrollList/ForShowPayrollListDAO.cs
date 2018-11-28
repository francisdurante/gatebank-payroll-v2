using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forShowPayrollList
{
    class ForShowPayrollListDAO
    {

        public static string[,] getAllPayrollList(string id)
        {
            string[,] users = null;
            Connection cn = new Connection();
            try
            {
                SqlCommand toGetCount = new SqlCommand("SELECT COUNT(*) FROM PayrollDetails WHERE EmployeeID = @id", cn.connect());
                toGetCount.Parameters.AddWithValue("@id", id);
                int length = (int)toGetCount.ExecuteScalar();
                users = new string[length, 4];
                SqlCommand toGetPayrollDetails = new SqlCommand("dbo.spGetAPayrollDetailPerUser", cn.connect());
                toGetPayrollDetails.CommandType = System.Data.CommandType.StoredProcedure;
                toGetPayrollDetails.Parameters.AddWithValue("@employeeId", id);
                SqlDataReader toGetPayrollDetailsReader = toGetPayrollDetails.ExecuteReader();
                if (toGetPayrollDetailsReader.HasRows)
                {
                    int x = 0;
                    while (toGetPayrollDetailsReader.Read())
                    {
                        int i = 0;
                        users[x, i] = toGetPayrollDetailsReader.GetValue(0).ToString(); //ID
                        users[x, ++i] = Convert.ToDateTime(toGetPayrollDetailsReader.GetValue(4)).ToString("MMMM dd, yyyy"); //Date from
                        users[x, ++i] = Convert.ToDateTime(toGetPayrollDetailsReader.GetValue(5)).ToString("MMMM dd, yyyy"); //Date to
                        users[x, ++i] = toGetPayrollDetailsReader.GetValue(8).ToString();  //take home pay
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
