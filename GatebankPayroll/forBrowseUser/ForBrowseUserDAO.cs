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
                        users[x, ++i] = toGetUserDataReader.GetValue(8).ToString();  //AccessLevel
                        users[x, ++i] = toGetUserDataReader.GetValue(5).ToString(); // status
                        x++;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                responseBool = false;
            }
            cn.connect().Close();
            return responseBool;
        }

        public static int saveUser(string fullName, string logId, string password)
        {
            int response = 0;
            Connection cn = new Connection();
            try
            {
                SqlCommand toCheckUser = new SqlCommand("dbo.spCheckIfExistingUser", cn.connect());
                toCheckUser.CommandType = System.Data.CommandType.StoredProcedure;
                toCheckUser.Parameters.AddWithValue("@userLogID", logId);
                SqlDataReader toCheckUserReader = toCheckUser.ExecuteReader();

                if(toCheckUserReader.HasRows)
                {
                    MessageBox.Show("Log ID Already Exist", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand toSaveUser = new SqlCommand("dbo.spSaveUser", cn.connect());
                    toSaveUser.CommandType = System.Data.CommandType.StoredProcedure;
                    toSaveUser.Parameters.AddWithValue("@fullName", fullName);
                    toSaveUser.Parameters.AddWithValue("@userLogId",logId);
                    toSaveUser.Parameters.AddWithValue("@password", Cryptography.Encrypt(logId));

                    response = (int)toSaveUser.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return response;
        }
    }
}
