using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forGeneratePayroll
{
    class forGeneratePayrollDAO
    {
        public static bool saveGeneratedpayroll(string sss, string pagibig,string philhealth,string tax,string sssloan, string pagibigloan, string proviloan, string absent, string late, string provifund, string smcard,string arcard, string other,
            string ot, string allowance, string incentives, string bonus, string other1, string other1v, string other2, string other2v, string other3,string other3v,string remarks,
            string employeename, string dateFrom, string dateTo,string totalAdd, string totalDeduc,string takeHomePay)
        {
            bool response = false;

            Connection cn = new Connection();
            try
            {
                SqlCommand toSavePayroll = new SqlCommand("dbo.spSaveGeneratedPayroll", cn.connect());
                toSavePayroll.CommandType = System.Data.CommandType.StoredProcedure;
                toSavePayroll.Parameters.AddWithValue("@sss", Convert.ToDouble(sss));
                toSavePayroll.Parameters.AddWithValue("@pagibig", Convert.ToDouble(pagibig));
                toSavePayroll.Parameters.AddWithValue("@philhealth", Convert.ToDouble(philhealth));
                toSavePayroll.Parameters.AddWithValue("@tax", Convert.ToDouble(tax));
                toSavePayroll.Parameters.AddWithValue("@sssloan", Convert.ToDouble(sssloan));
                toSavePayroll.Parameters.AddWithValue("@pagibigloan", Convert.ToDouble(pagibigloan));
                toSavePayroll.Parameters.AddWithValue("@proviloan", Convert.ToDouble(proviloan));
                toSavePayroll.Parameters.AddWithValue("@absent", Convert.ToDouble(absent));
                toSavePayroll.Parameters.AddWithValue("@lates", Convert.ToDouble(late));
                toSavePayroll.Parameters.AddWithValue("@provifund", Convert.ToDouble(provifund));
                toSavePayroll.Parameters.AddWithValue("@smcard", Convert.ToDouble(smcard));
                toSavePayroll.Parameters.AddWithValue("@arhealthcard", Convert.ToDouble(arcard));
                toSavePayroll.Parameters.AddWithValue("@others", Convert.ToDouble(other));
                toSavePayroll.Parameters.AddWithValue("@ot", Convert.ToDouble(ot));
                toSavePayroll.Parameters.AddWithValue("@allowance", Convert.ToDouble(allowance));
                toSavePayroll.Parameters.AddWithValue("@incentive", Convert.ToDouble(incentives));
                toSavePayroll.Parameters.AddWithValue("@bonus", Convert.ToDouble(bonus));
                toSavePayroll.Parameters.AddWithValue("@other1", other1);
                toSavePayroll.Parameters.AddWithValue("@other1v", Convert.ToDouble(other1v));
                toSavePayroll.Parameters.AddWithValue("@other2", other2);
                toSavePayroll.Parameters.AddWithValue("@other2v", Convert.ToDouble(other2v));
                toSavePayroll.Parameters.AddWithValue("@other3", other3);
                toSavePayroll.Parameters.AddWithValue("@other3v", Convert.ToDouble(other3v));
                toSavePayroll.Parameters.AddWithValue("@remarks", remarks);
                toSavePayroll.Parameters.AddWithValue("@employeeName", employeename);
                toSavePayroll.Parameters.AddWithValue("@dateFrom", Convert.ToDateTime(dateFrom));
                toSavePayroll.Parameters.AddWithValue("@dateTo", Convert.ToDateTime(dateTo));
                toSavePayroll.Parameters.AddWithValue("@totaladd", Convert.ToDouble(totalAdd));
                toSavePayroll.Parameters.AddWithValue("@totaldeduc", Convert.ToDouble(totalDeduc));
                toSavePayroll.Parameters.AddWithValue("@takehomepay", Convert.ToDouble(takeHomePay));

                int sqlReturn = toSavePayroll.ExecuteNonQuery();
                if (sqlReturn == -1)
                    response = true;
                else
                    response = false;
            }
            catch(Exception ex)
            {
                response = false;
                MessageBox.Show(ex.Message);
            }
            cn.connect().Close();
            return response;
        }

        public static bool payrollExstingByDate(string employeeName, string dateFrom, string dateTo)
        {
            bool response = false;
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckExstingPayroll = new SqlCommand("dbo.spCheckPayrollDate", cn.connect());
                toCheckExstingPayroll.CommandType = System.Data.CommandType.StoredProcedure;
                toCheckExstingPayroll.Parameters.AddWithValue("@employeeName", employeeName);
                toCheckExstingPayroll.Parameters.AddWithValue("@dateFrom", dateFrom);
                toCheckExstingPayroll.Parameters.AddWithValue("@dateTo", dateTo);
                SqlDataReader toCheckExstingPayrollReader = toCheckExstingPayroll.ExecuteReader();
                if (toCheckExstingPayrollReader.HasRows)
                {
                    while (toCheckExstingPayrollReader.Read())
                    {
                        if(toCheckExstingPayrollReader.GetInt32(0) == 0)
                        {
                            response = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                response = false;
                MessageBox.Show(ex.Message, "SQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cn.connect().Close();
            return response;
        }
    }
}
