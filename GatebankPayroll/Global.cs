using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GatebankPayroll
{
    class Global
    {
        public static ArrayList getBranch(int status)
        {
            int rownCount = 0;
            ArrayList response = new ArrayList();
            Connection cn = new Connection();
            try
            {
                SqlCommand getBranch = new SqlCommand("dbo.spGetBranch",cn.connect());
                getBranch.CommandType = CommandType.StoredProcedure;
                getBranch.Parameters.AddWithValue("@status", status);

                SqlDataReader getBranchReader = getBranch.ExecuteReader();
                if (getBranchReader.HasRows)
                {
                    while (getBranchReader.Read())
                    {
                        response.Add(getBranchReader.GetValue(1).ToString());
                    }
                }
                else
                {
                    response.Add("");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                response.Add("");
                cn.connect().Close();
            }
            cn.connect().Close();
            return response;
        }

        public static ArrayList getPosition(int status)
        {
            int rownCount = 0;
            ArrayList response = new ArrayList();
            Connection cn = new Connection();
            try
            {
                SqlCommand getPosition = new SqlCommand("dbo.spGetPosition", cn.connect());
                getPosition.CommandType = CommandType.StoredProcedure;
                getPosition.Parameters.AddWithValue("@status", status);

                SqlDataReader getPositionReader = getPosition.ExecuteReader();
                if (getPositionReader.HasRows)
                {
                    while (getPositionReader.Read())
                    {
                        response.Add(getPositionReader.GetValue(1).ToString());
                    }
                }
                else
                {
                    response.Add("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                response.Add("");
                cn.connect().Close();
            }
            cn.connect().Close();
            return response;
        }

        public static Dictionary<string,string> getEmployeeName(int status)
        {
            int rownCount = 0;
            Dictionary<string,string> response = new Dictionary<string,string>();
            Connection cn = new Connection();
            try
            {
                SqlCommand getEmployee = new SqlCommand("dbo.spGetEmployeeName", cn.connect());
                getEmployee.CommandType = CommandType.StoredProcedure;
                getEmployee.Parameters.AddWithValue("@status", status);

                SqlDataReader getEmployeeReader = getEmployee.ExecuteReader();
                if (getEmployeeReader.HasRows)
                {
                    int x = 0;
                    while (getEmployeeReader.Read())
                    {
                        response.Add("name" + x,getEmployeeReader.GetValue(1).ToString());
                        response.Add(getEmployeeReader.GetValue(1).ToString()+"salary", getEmployeeReader.GetValue(4).ToString());
                        response.Add(getEmployeeReader.GetValue(1).ToString()+"position", getEmployeeReader.GetValue(8).ToString());
                        response.Add(getEmployeeReader.GetValue(1).ToString()+"branch", getEmployeeReader.GetValue(11).ToString());
                        x++;
                    }
                }
                else
                {
                    response.Add("","");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                response.Add("","");
                cn.connect().Close();
            }
            cn.connect().Close();
            return response;
        }
    }
}
