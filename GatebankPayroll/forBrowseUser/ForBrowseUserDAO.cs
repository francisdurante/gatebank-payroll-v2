using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forBrowseUser
{
    class ForBrowseUserDAO
    {
        public static string[,] getUsers(string name)
        {
            string[,] users = null;
            Connection cn = new Connection();
            try
            {
                SqlCommand toGetCount = new SqlCommand("SELECT COUNT(*) FROM Users", cn.connect());
                int length = (int)toGetCount.ExecuteScalar();
                users = new string[length, 5];
                SqlCommand toGetUserData = new SqlCommand("dbo.spGetUsers", cn.connect());
                toGetUserData.CommandType = System.Data.CommandType.StoredProcedure;
                toGetUserData.Parameters.AddWithValue("@user_full_name", "%" + name + "%");
                SqlDataReader toGetUserDataReader = toGetUserData.ExecuteReader();
                if (toGetUserDataReader.HasRows)
                {
                    int x = 0;
                    while (toGetUserDataReader.Read())
                    {
                        int i = 0;
                        users[x, i] = toGetUserDataReader.GetValue(0).ToString(); //ID
                        users[x, ++i] = toGetUserDataReader.GetValue(1).ToString(); //LOGIN ID
                        users[x, ++i] = toGetUserDataReader.GetValue(4).ToString(); //fullname
                        users[x, ++i] = toGetUserDataReader.GetValue(7).ToString();  //AccessLevel
                        users[x, ++i] = toGetUserDataReader.GetValue(5).ToString(); // status
                        x++;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                users = null;
            }
            cn.connect().Close();

            return users;
        }

        public static bool updateUsers(string fullName, string accessLevel, int status, int id)
        {
            bool responseBool = false;
            Connection cn = new Connection();
            try
            {
                SqlCommand toUpdateUser = new SqlCommand("dbo.spUpdateUsers", cn.connect());
                toUpdateUser.CommandType = System.Data.CommandType.StoredProcedure;
                toUpdateUser.Parameters.AddWithValue("@fullName", fullName);
                toUpdateUser.Parameters.AddWithValue("@AccessLevel", accessLevel);
                toUpdateUser.Parameters.AddWithValue("@status", status);
                toUpdateUser.Parameters.AddWithValue("@ID", id);
                int response = toUpdateUser.ExecuteNonQuery();
                if(response < 0)
                {
                    MessageBox.Show("User updated!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmBrowseUser fbu = new frmBrowseUser();
                    responseBool = true;
                }
                else
                {
                    MessageBox.Show("User not updated!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    responseBool =  false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                responseBool = false;
            }
            cn.connect().Close();
            return responseBool;
        }
    }
}
