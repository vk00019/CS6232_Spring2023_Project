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

        public void BookAppointment(Appointment appointment)
        {
            _managementDal.BookAppointment(appointment);
        }

        public List<string> GetStates()
        {
            return _managementDal.GetStates();
        }

        public List<DateTime> GetDoctorAppointmentTimes(int id)
        {
            return _managementDal.GetDoctorAppointmentTimes(id);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _managementDal.UpdateAppointment(appointment);
        }

        public bool ValidatePatient(int id)
        {
            return _managementDal.ValidatePatient(id);
        }

        public List<Doctor> GetDoctors()
        {
            return _managementDal.GetDoctors();
        }

        public bool CheckUser(string username, string password)
        {
            return _managementDal.CheckUser(username,password);
        }

        public List<PersonalDetails> GetPatientWithDob(PersonalDetails patient)
        {
            return _managementDal.GetPatientWithDob(patient);
        }

        public List<PersonalDetails> GetPatientWithDobAndLastname(PersonalDetails patient)
        {
            return _managementDal.GetPatientWithDobAndLastname(patient);
        }

        public List<PersonalDetails> GetPatientWithFirstnameAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetPatientWithFirstnameAndLastname(patientsObject);
        }

        public List<Appointment> GetPatientAppointments(int patientId)
        {
            return _managementDal.GetPatientAppointments(patientId);
        }

        public List<Visit> GetPatientVisits(int appointmentId)
        {
            return _managementDal.GetPatientVisits(appointmentId);
        }

        public void UpdatePatientDetails(PersonalDetails patientDetails)
        { 
            _managementDal.UpdatePatientDetails(patientDetails);
        }

        internal List<Appointment> GetAppointmenttWithDob(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentsWithDOB(patientsObject);
        }
    }
}
