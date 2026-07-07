using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopersDiaryApplication
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static string UserEmail { get; set; }

        // Optional: quick check if someone is actually logged in
        public static bool IsLoggedIn => UserID != 0;

        // Call this on logout to clear the session
        public static void Clear()
        {
            UserID = 0;
            UserName = null;
            UserEmail = null;
        }

    }
}
