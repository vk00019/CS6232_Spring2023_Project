using HospitalManagement.DAL;
using HospitalManagement.model;
using HospitalManagement.Model;

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

        /// <summary>
        /// This method checks if there is a visit assosiated with an appointment
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if there is a visit</returns>
        public bool CheckVisit(int id)
        {
            return (_managementDal.CheckVisit(id));
        }

        public bool CheckAppointment(int id)
        {
            return (_managementDal.CheckAppointment(id));
        }

        /// <summary>
        /// This method deletes the appointment with the given id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAppointment(int id)
        {
            _managementDal.DeleteAppointment(id);
        }

        public void DeletePatient(int id)
        {
            _managementDal.DeletePatient(id);
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
            return _managementDal.CheckUser(username, password);
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

        public List<Appointment> GetAppointmentWithDob(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentsWithDOB(patientsObject);
        }

        public List<Appointment> GetAppointmentWithDobAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentsWithDOBAndLastname(patientsObject);
        }

        public List<Appointment> GetAppointmentWithFirstNameAndLastName(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentWithFirstNameAndLastName(patientsObject);
        }

        public Nurse GetNurse(string username)
        {
            return _managementDal.GetNurse(username);
        }

        public int GetPatientId(int pdId)
        {
            return _managementDal.GetPatientId(pdId);
        }

        /// <summary>
        /// Adds the routine checkup.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void AddRoutineCheckup(Visit visit)
        {
            _managementDal.AddRoutineCheckup(visit);
        }

        /// <summary>
        /// This method returns list of tests from database
        /// </summary>
        /// <returns>List of tests</returns>
        public List<TestList> GetTests()
        public int GetNurseId(string username)
        {
            return _managementDal.GetNurseId(username);
        }

        public List<Appointment> GetTodaysAppointments()
        {
            return _managementDal.GetTests();
        }
    }
}
