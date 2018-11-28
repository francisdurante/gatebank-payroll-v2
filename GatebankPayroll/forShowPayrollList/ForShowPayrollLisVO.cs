using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatebankPayroll.forShowPayrollList
{
    class ForShowPayrollLisVO
    {

        private static string payrollDetailsID;

        public static string getPayrollDetailsID() { return payrollDetailsID; }
        public static void setPayrollDetailsID(string id) { payrollDetailsID = id; }
    }
}
