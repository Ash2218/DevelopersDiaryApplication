using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;



namespace DevelopersDiaryApplication
{
    public static class DBConnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DevelopersDiaryApplication"].ConnectionString;
    }
}
