using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatebankPayroll.forLogin
{
    class ForLoginVO
    {
        private static int userID;
        private static string userFullName;
        private static string accessLevel;
        private static string ID;

        public static int getUserID() { return userID; }
        public static void setUserID(int id) { userID = id; }
        public static string getUserFullName() { return userFullName; }
        public static void setFullName(string name) { userFullName = name; }
        public static string getAccessLevel() { return accessLevel; }
        public static void setAccessLevel(string access) { accessLevel = access; }
        public static string getID() { return ID; }
        public static void setID(string id) { ID = id; }

    }
}
