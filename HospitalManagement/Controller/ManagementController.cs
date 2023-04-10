using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Controller
{
    public class ManagementController
    {
        private string _username = "jane";
        private string _password = "test1234";

        public string Username()
        {
            return _username;
        }

        public string Password()
        {
            return _password;
        }
    }
}
