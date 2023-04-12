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
        private readonly ManagementDbDal _managementDal;

        public ManagementController()
        {
            _managementDal = new ManagementDbDal();
        }

        public void RegisterPatient(PersonalDetails personalDetails)
        {
            _managementDal.RegisterPatient(personalDetails);
        }

        public List<string> GetStates()
        {
            return _managementDal.GetStates();
        }

        public bool CheckUser(string username, string password)
        {
            return _managementDal.CheckUser(username,password);
        }

        public List<string> GetPatientWithDob(DateTime dt)
        {
            return _managementDal.GetPatientWithDob(dt);
        }
    }
}
