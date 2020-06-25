using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustagram2
{
    class Set_User
    {
        private static Set_User setuser = new Set_User();
        private string user_id;
        private Set_User(){}
        public static Set_User SetUser() { return setuser; }
        public string getUser_id()
        {
            return user_id;
        }
        public void setUser_id(string user_id)
        {
            this.user_id = user_id;
        }
    }
}
