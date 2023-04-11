using HospitalManagement.DAL;
using HospitalManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Controller
{
    public class ManagementController
    {
        private ManagementDBDAL _managementDAL;

        public ManagementController()
        {
            _managementDAL = new ManagementDBDAL();
        }

        public void RegisterPatient(PersonalDetails personalDetials)
        {
            _managementDAL.RegisterPatient(personalDetials);
        }

        public List<string> GetStates()
        {
            return _managementDAL.GetStates();
        }

        public bool CheckUser(string username, string password)
        {
            return _managementDAL.CheckUser(username,password);
        }
    }
}
