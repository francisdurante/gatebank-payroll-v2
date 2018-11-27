using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatebankPayroll.forParameters
{
    class ForParametersDAO
    {
        public static ArrayList getAllParameters()
        {
            Connection cn = new Connection();
            ArrayList response = new ArrayList();
            try
            {
                SqlCommand toGetParameters = new SqlCommand("dbo.spGetParameters", cn.connect());
                toGetParameters.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader toGetParametersReader = toGetParameters.ExecuteReader();
                if (toGetParametersReader.HasRows)
                {
                    while (toGetParametersReader.Read())
                    {
                        response.Add(toGetParametersReader.GetValue(2).ToString());
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                response = null;
            }
            cn.connect().Close();
            return response;
        }

        public static void toSaveParameters(string pagbIbig, string philhealth, string provi)
        {
            Connection cn = new Connection();
            try
            {
                SqlCommand toSaveParameters = new SqlCommand("dbo.spSaveParameters", cn.connect());
                toSaveParameters.CommandType = System.Data.CommandType.StoredProcedure;
                toSaveParameters.Parameters.AddWithValue("@pagibig", Convert.ToDouble(pagbIbig));
                toSaveParameters.Parameters.AddWithValue("@philhealth", Convert.ToDouble(philhealth));
                toSaveParameters.Parameters.AddWithValue("@provi", Convert.ToDouble(provi));
                int response = toSaveParameters.ExecuteNonQuery();
                if (response == 0)
                {
                    MessageBox.Show("No record updated!", "Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record updated!", "Parameters", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.connect().Close();
        }
    }
}
