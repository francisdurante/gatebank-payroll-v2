using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forLogin
{
    class LoginDAO
    {
        public static int loggedin(string userLogId, string password)
        {
            int response = 0;
            Connection cn = new Connection();
            try
            {
                SqlCommand spLogin = new SqlCommand("dbo.spUserLoggedIn", cn.connect());
                spLogin.CommandType = CommandType.StoredProcedure;
                spLogin.Parameters.AddWithValue("@username", userLogId);
                spLogin.Parameters.AddWithValue("@password", Cryptography.Encrypt(password));
                SqlDataReader spLoginReader = spLogin.ExecuteReader();
                while (spLoginReader.Read())
                {
                    try
                    {
                        if(Convert.ToInt32(spLoginReader.GetOrdinal("Response")) != 1)
                        {
                            response = Convert.ToInt32(spLoginReader.GetOrdinal("Response"));
                        }
                    }
                    catch
                    {
                        response = 1;
                        ForLoginVO.setUserID(Convert.ToInt32(spLoginReader["ID"]));
                        ForLoginVO.setFullName(spLoginReader["full_name"].ToString());
                        ForLoginVO.setAccessLevel(spLoginReader["name"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                response = 500;
                cn.connect().Close();
            }
            cn.connect().Close();
            return response;
        }
    }
}
