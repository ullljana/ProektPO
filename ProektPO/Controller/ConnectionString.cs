using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ProektPO.Controller
{
    class ConnectionString
    {
        public static string ConnStr
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ProektPO.Properties.Settings.ProektITConnectionString"].ConnectionString;
            }
        }
    }
}
