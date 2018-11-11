using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forAddEmployee
{
    class forAddEmployeeDAO
    {
        public static bool insertEmployee(string fullName, double basicSalary, string position, DateTime dateHired, string branch)
        {
            bool value = false;
            Connection cn = new Connection();
            try
            {
                SqlCommand insertEmployee = new SqlCommand("dbo.spInsertEmployee", cn.connect());
                insertEmployee.CommandType = CommandType.StoredProcedure;
                insertEmployee.Parameters.AddWithValue("@fullName", fullName);
                insertEmployee.Parameters.AddWithValue("@basicSalary", basicSalary);
                insertEmployee.Parameters.AddWithValue("@position", position);
                insertEmployee.Parameters.AddWithValue("@dateHire", dateHired);
                insertEmployee.Parameters.AddWithValue("@branch", branch);

                SqlDataReader insertEmployeeReader = insertEmployee.ExecuteReader();
                while (insertEmployeeReader.Read())
                {
                    if (Convert.ToInt32(insertEmployeeReader.GetInt32(0)) != 1)
                    {
                        value = false;
                    }
                    else
                    {
                        value = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.connect().Close();
            }
            cn.connect().Close();
            return value;
        }
    }
}
