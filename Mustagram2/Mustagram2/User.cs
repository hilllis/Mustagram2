using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mustagram2
{
    public class User
    {
        private static User _instance = null;
        string user_name;
        string user_id;
        string profile;
        
        
        private User()
        {
           
        }
        private static User instance
        {
            get
            {
                if (_instance == null) _instance = new User();
                return _instance;
            }
        }

    }
}
