using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatebankPayroll.forBrowseUser
{
    class ForBrowseUserVO
    {
        private static string Id;
        private static string loginId;
        private static string fullName;
        private static string accessLevel;
        private static string status;

        public static void setID(string id) { Id = id; }
        public static string getID() { return Id; }
        public static void setloginId(string value) {loginId = value; }
        public static string getLoginId() { return loginId; }
        public static void setfullName(string value) { fullName = value; }
        public static string getFullname() { return fullName; }
        public static void setAccessLevel(string value) { accessLevel = value; }
        public static string getAccessLevel() { return accessLevel; }
        public static void setStatus(string value) { status = value; }
        public static string getStatus() { return status; }
    }
}
