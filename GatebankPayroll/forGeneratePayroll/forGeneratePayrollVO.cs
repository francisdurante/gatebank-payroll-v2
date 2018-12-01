using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatebankPayroll.forGeneratePayroll
{
    class forGeneratePayrollVO
    {
        private static string dateFrom;
        private static string dateTo;
        private static string employeeName;
        private static string employeeID;

        public static void setDateFrom(string value) { dateFrom = value; }
        public static string getDateFrom() { return dateFrom; }
        public static void setDateTo(string value) { dateTo = value; }
        public static string getDateTo() { return dateTo; }
        public static void setEmployeeName(string value) { employeeName = value; }
        public static string getEmployeeName() { return employeeName; }
        public static void setEmployeeID(string value) { employeeID = value; }
        public static string getEmployeeID() { return employeeID; }
    }
}
