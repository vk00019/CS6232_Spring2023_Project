using HospitalManagement.DAL;
using HospitalManagement.model;
using HospitalManagement.Model;

namespace HospitalManagement.Controller
{
    public class ManagementController
    {
        private readonly ManagementDbDal _managementDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagementController"/> class.
        /// </summary>
        public ManagementController()
        {
            _managementDal = new ManagementDbDal();
        }

        /// <summary>
        /// Registers the patient.
        /// </summary>
        /// <param name="personalDetails">The personal details.</param>
        public void RegisterPatient(PersonalDetails personalDetails)
        {
            _managementDal.RegisterPatient(personalDetails);
        }

        /// <summary>
        /// Books the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void BookAppointment(Appointment appointment)
        {
            _managementDal.BookAppointment(appointment);
        }

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStates()
        {
            return _managementDal.GetStates();
        }

        /// <summary>
        /// Gets the doctor appointment times.
        /// </summary>
        /// <param name="id">The id of doctor.</param>
        /// <returns></returns>
        public List<DateTime> GetDoctorAppointmentTimes(int id)
        {
            return _managementDal.GetDoctorAppointmentTimes(id);
        }

        /// <summary>
        /// Updates the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void UpdateAppointment(Appointment appointment)
        {
            _managementDal.UpdateAppointment(appointment);
        }

        /// <summary>
        /// This method checks if there is a visit associated with an appointment
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if there is a visit</returns>
        public bool CheckVisit(int id)
        {
            return _managementDal.CheckVisit(id);
        }

        /// <summary>
        /// Checks the appointment.
        /// </summary>
        /// <param name="id">The id of appointment.</param>
        /// <returns></returns>
        public bool CheckAppointment(int id)
        {
            return _managementDal.CheckAppointment(id);
        }

        /// <summary>
        /// This method deletes the appointment with the given id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAppointment(int id)
        {
            _managementDal.DeleteAppointment(id);
        }

        /// <summary>
        /// Deletes the patient.
        /// </summary>
        /// <param name="id">The patient id to be deleted.</param>
        public void DeletePatient(int id)
        {
            _managementDal.DeletePatient(id);
        }

        /// <summary>
        /// Validates the patient.
        /// </summary>
        /// <param name="id">The patient id.</param>
        /// <returns></returns>
        public bool ValidatePatient(int id)
        {
            return _managementDal.ValidatePatient(id);
        }

        /// <summary>
        /// Gets the doctors.
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            return _managementDal.GetDoctors();
        }

        /// <summary>
        /// Checks the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool CheckUser(string username, string password)
        {
            return _managementDal.CheckUser(username, password);
        }

        /// <summary>
        /// Gets the patient with dob.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithDob(PersonalDetails patient)
        {
            return _managementDal.GetPatientWithDob(patient);
        }

        /// <summary>
        /// Gets the patient with dob and lastname.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithDobAndLastname(PersonalDetails patient)
        {
            return _managementDal.GetPatientWithDobAndLastname(patient);
        }

        /// <summary>
        /// Gets the patient with firstname and lastname.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithFirstnameAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetPatientWithFirstnameAndLastname(patientsObject);
        }

        /// <summary>
        /// Gets the patient appointments.
        /// </summary>
        /// <param name="patientId">The patient id.</param>
        /// <returns></returns>
        public List<Appointment> GetPatientAppointments(int patientId)
        {
            return _managementDal.GetPatientAppointments(patientId);
        }

        /// <summary>
        /// Gets the patient visits.
        /// </summary>
        /// <param name="appointmentId">The appointment id.</param>
        /// <returns></returns>
        public List<Visit> GetPatientVisits(int appointmentId)
        {
            return _managementDal.GetPatientVisits(appointmentId);
        }

        /// <summary>
        /// Updates the patient details.
        /// </summary>
        /// <param name="patientDetails">The patient details.</param>
        public void UpdatePatientDetails(PersonalDetails patientDetails)
        {
            _managementDal.UpdatePatientDetails(patientDetails);
        }

        /// <summary>
        /// Gets the appointment with dob.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentWithDob(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentsWithDOB(patientsObject);
        }

        /// <summary>
        /// Gets the appointment with dob and lastname.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentWithDobAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentsWithDOBAndLastname(patientsObject);
        }

        /// <summary>
        /// Gets the last name of the appointment with first name and.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentWithFirstNameAndLastName(PersonalDetails patientsObject)
        {
            return _managementDal.GetAppointmentWithFirstNameAndLastName(patientsObject);
        }

        /// <summary>
        /// Gets the nurse.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public Nurse GetNurse(string username)
        {
            return _managementDal.GetNurse(username);
        }

        /// <summary>
        /// Gets the patient id.
        /// </summary>
        /// <param name="pdId">The personal details id.</param>
        /// <returns></returns>
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
        {
            return _managementDal.GetTests();
        }

        /// <summary>
        /// Gets the today's appointments.
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetTodaysAppointments()
        {
            return _managementDal.GetTodaysAppointments();
        }

        /// <summary>
        /// Starts the visit.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void StartVisit(Visit visit)
        { 
            _managementDal.StartVisit(visit);
        }

        /// <summary>
        /// Gets the latest visit.
        /// </summary>
        /// <returns></returns>
        public Visit GetLatestVisit()
        {
            return _managementDal.GetLatestVisit();
        }

        /// <summary>
        /// Gets the visit with dob.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Visit> GetVisitWithDob(PersonalDetails patientsObject)
        {
            return _managementDal.GetVisitWithDOB(patientsObject);
        }

        /// <summary>
        /// Gets the visit with dob and lastname.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Visit> GetVisitWithDobAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetVisitWithDOBAndLastName(patientsObject);
        }

        /// <summary>
        /// Gets the visit with firstname and lastname.
        /// </summary>
        /// <param name="patientsObject">The patients object.</param>
        /// <returns></returns>
        public List<Visit> GetVisitWithFirstnameAndLastname(PersonalDetails patientsObject)
        {
            return _managementDal.GetVisitWithFirstAndLastName(patientsObject);
        }

        /// <summary>
        /// Orders the tests.
        /// </summary>
        /// <param name="visitId">The visit identifier.</param>
        /// <param name="testId">The test identifier.</param>
        public void OrderTests(int visitId, int testId)
        {
            _managementDal.OrderTests(visitId, testId);
        }

        /// <summary>
        /// Updates the initial diagnosis.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void UpdateInitialDiagnosis(Visit visit)
        {
            _managementDal.UpdateInitialDiagnosis(visit);
        }

        /// <summary>
        /// Updates the final diagnosis.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void UpdateFinalDiagnosis(Visit visit)
        {
            _managementDal.UpdateFinalDiagnosis(visit);
        }

        /// <summary>
        /// Updates the diagnosis.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void UpdateDiagnosis(Visit visit)
        {
            _managementDal.UpdateDiagnosis(visit);
        }

        /// <summary>
        /// Gets the visit for edit or view.
        /// </summary>
        /// <param name="visitID">The visit identifier.</param>
        /// <returns></returns>
        public Visit GetVisitForEditOrView(int visitID)
        {
            return _managementDal.GetVisitForEditOrView(visitID);
        }

        /// <summary>
        /// Gets the ordered tests.
        /// </summary>
        /// <param name="id">The visit id.</param>
        /// <returns></returns>
        public List<TestList> GetOrderedTests(int id)
        {
            return _managementDal.GetOrderedTests(id);
        }

        /// <summary>
        /// Determines whether [is final diagnosis available] [the specified identifier].
        /// </summary>
        /// <param name="id">The visit id.</param>
        /// <returns>
        ///   <c>true</c> if [is final diagnosis available] [the specified identifier]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFinalDiagnosisAvailable(int id)
        {
            return _managementDal.IsFinalDiagnosisAvailable(id);
        }

        /// <summary>
        /// Gets the everything.
        /// </summary>
        /// <param name="id">The visit id.</param>
        /// <returns></returns>
        public Visit GetEverything(int id)
        {
            return _managementDal.GetEverything(id);
        }

        /// <summary>
        /// Updates the patient tests.
        /// </summary>
        /// <param name="patientTest">The patient test.</param>
        public void UpdatePatientTests(PatientTest patientTest)
        {
            _managementDal.UpdatePatientTests(patientTest);
        }

        /// <summary>
        /// Ges the patient tests results.
        /// </summary>
        /// <param name="id">The visit id.</param>
        /// <returns></returns>
        public List<PatientTest> GePatientTestsResults(int id)
        {
            return _managementDal.GePatientTestsResults(id);
        }
    }
}
