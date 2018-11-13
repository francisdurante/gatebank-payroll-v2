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

        static double deduction = 0.00;
        public static double forEE(double basicSalary)
        {
            Connection cn = new Connection();

            SqlCommand SSSDeductions = new SqlCommand("SELECT * FROM SSSTable WHERE SSS_id = 1", cn.connect());
            SqlDataReader SSSDeductionsReader = SSSDeductions.ExecuteReader();
            if (SSSDeductionsReader.HasRows)
            {
                while (SSSDeductionsReader.Read())
                {
                    if (basicSalary >= 16000)
                    {
                        basicSalary = 16000.00;
                    }
                    if (basicSalary <= 1000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(1);
                    }
                    else if (basicSalary <= 1500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(2);
                    }
                    else if (basicSalary <= 2000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(3);
                    }
                    else if (basicSalary <= 2500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(4);
                    }
                    else if (basicSalary <= 3000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(5);
                    }
                    else if (basicSalary <= 3500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(6);
                    }
                    else if (basicSalary <= 4000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(7);
                    }
                    else if (basicSalary <= 4500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(8);
                    }
                    else if (basicSalary <= 5000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(9);
                    }
                    else if (basicSalary <= 5500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(10);
                    }
                    else if (basicSalary <= 6000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(11);
                    }
                    else if (basicSalary <= 6500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(12);
                    }
                    else if (basicSalary <= 7000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(13);
                    }
                    else if (basicSalary <= 7500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(14);
                    }
                    else if (basicSalary <= 8000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(15);
                    }
                    else if (basicSalary <= 8500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(16);
                    }
                    else if (basicSalary <= 9000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(17);
                    }
                    else if (basicSalary <= 9500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(18);
                    }
                    else if (basicSalary <= 10000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(19);
                    }
                    else if (basicSalary <= 10500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(20);
                    }
                    else if (basicSalary <= 11000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(21);
                    }
                    else if (basicSalary <= 11500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(22);
                    }
                    else if (basicSalary <= 12000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(23);
                    }
                    else if (basicSalary <= 12500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(24);
                    }
                    else if (basicSalary <= 13000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(25);
                    }
                    else if (basicSalary <= 13500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(26);
                    }
                    else if (basicSalary <= 14000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(27);
                    }
                    else if (basicSalary <= 14500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(28);
                    }
                    else if (basicSalary <= 15000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(28);
                    }
                    else if (basicSalary <= 15500)
                    {
                        deduction = SSSDeductionsReader.GetDouble(30);
                    }
                    else if (basicSalary <= 16000)
                    {
                        deduction = SSSDeductionsReader.GetDouble(31);
                    }
                    else
                    {
                        deduction = SSSDeductionsReader.GetDouble(31);
                    }
                }
                SSSDeductionsReader.Close();
                cn.connect().Close();
            }
            return deduction;
        }

        public static double forER(double basicSalary)
        {

            Connection cn = new Connection();

            SqlCommand SSSDeductions = new SqlCommand("SELECT * FROM SSSTable WHERE SSS_id = 1", cn.connect());
            SqlDataReader SSSDeductionsReader = SSSDeductions.ExecuteReader();
            while (SSSDeductionsReader.Read())
            {
                if (basicSalary >= 16000)
                {
                    basicSalary = 16000.00;
                }
                if (basicSalary <= 1000)
                {
                    deduction = SSSDeductionsReader.GetDouble(31);
                }
                else if (basicSalary <= 1500)
                {
                    deduction = SSSDeductionsReader.GetDouble(32);
                }
                else if (basicSalary <= 2000)
                {
                    deduction = SSSDeductionsReader.GetDouble(33);
                }
                else if (basicSalary <= 2500)
                {
                    deduction = SSSDeductionsReader.GetDouble(34);
                }
                else if (basicSalary <= 3000)
                {
                    deduction = SSSDeductionsReader.GetDouble(35);
                }
                else if (basicSalary <= 3500)
                {
                    deduction = SSSDeductionsReader.GetDouble(36);
                }
                else if (basicSalary <= 4000)
                {
                    deduction = SSSDeductionsReader.GetDouble(37);
                }
                else if (basicSalary <= 4500)
                {
                    deduction = SSSDeductionsReader.GetDouble(38);
                }
                else if (basicSalary <= 5000)
                {
                    deduction = SSSDeductionsReader.GetDouble(39);
                }
                else if (basicSalary <= 5500)
                {
                    deduction = SSSDeductionsReader.GetDouble(40);
                }
                else if (basicSalary <= 6000)
                {
                    deduction = SSSDeductionsReader.GetDouble(41);
                }
                else if (basicSalary <= 6500)
                {
                    deduction = SSSDeductionsReader.GetDouble(42);
                }
                else if (basicSalary <= 7000)
                {
                    deduction = SSSDeductionsReader.GetDouble(43);
                }
                else if (basicSalary <= 7500)
                {
                    deduction = SSSDeductionsReader.GetDouble(44);
                }
                else if (basicSalary <= 8000)
                {
                    deduction = SSSDeductionsReader.GetDouble(45);
                }
                else if (basicSalary <= 8500)
                {
                    deduction = SSSDeductionsReader.GetDouble(46);
                }
                else if (basicSalary <= 9000)
                {
                    deduction = SSSDeductionsReader.GetDouble(47);
                }
                else if (basicSalary <= 9500)
                {
                    deduction = SSSDeductionsReader.GetDouble(48);
                }
                else if (basicSalary <= 10000)
                {
                    deduction = SSSDeductionsReader.GetDouble(49);
                }
                else if (basicSalary <= 10500)
                {
                    deduction = SSSDeductionsReader.GetDouble(50);
                }
                else if (basicSalary <= 11000)
                {
                    deduction = SSSDeductionsReader.GetDouble(51);
                }
                else if (basicSalary <= 11500)
                {
                    deduction = SSSDeductionsReader.GetDouble(52);
                }
                else if (basicSalary <= 12000)
                {
                    deduction = SSSDeductionsReader.GetDouble(53);
                }
                else if (basicSalary <= 12500)
                {
                    deduction = SSSDeductionsReader.GetDouble(54);
                }
                else if (basicSalary <= 13000)
                {
                    deduction = SSSDeductionsReader.GetDouble(55);
                }
                else if (basicSalary <= 13500)
                {
                    deduction = SSSDeductionsReader.GetDouble(56);
                }
                else if (basicSalary <= 14000)
                {
                    deduction = SSSDeductionsReader.GetDouble(57);
                }
                else if (basicSalary <= 14500)
                {
                    deduction = SSSDeductionsReader.GetDouble(58);
                }
                else if (basicSalary <= 15000)
                {
                    deduction = SSSDeductionsReader.GetDouble(59);
                }
                else if (basicSalary <= 15500)
                {
                    deduction = SSSDeductionsReader.GetDouble(60);
                }
                else if (basicSalary <= 16000)
                {
                    deduction = SSSDeductionsReader.GetDouble(61);
                }
                else
                {
                    deduction = SSSDeductionsReader.GetDouble(61);
                }
            }
            SSSDeductionsReader.Close();
            cn.connect().Close();

            return deduction;
        }
        public double EREC(double basicSalary)
        {
            if (basicSalary >= 15000)
            {
                return 30.00;
            }
            else
            {
                return 10.00;
            }
        }
    }
}
