using HospitalManagement.model;
using HospitalManagement.Model;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalManagement.DAL
{
    /// <summary>
    /// This class is used to interact with the Database
    /// </summary>
    public class ManagementDbDal
    {
        /// <summary>
        /// Registers the patient.
        /// </summary>
        /// <param name="personalDetails">The personal details.</param>
        public void RegisterPatient(PersonalDetails personalDetails)
        {
            var firstname = personalDetails.FirstName;
            var lastname = personalDetails.LastName;
            var dateOfBirth = personalDetails.DateOfBirth;
            var phoneNumber = personalDetails.PhoneNumber;
            var street = personalDetails.Street;
            var city = personalDetails.City;
            var country = personalDetails.Country;
            var zipCode = personalDetails.ZipCode;
            var state = personalDetails.State;
            var gender = personalDetails.Gender;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            //string query = "INSERT INTO PersonalDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) " +
            //    "VALUES(@firstname,@lastname,@dateOfBirth,@gender,@street,@city,@state,@zipCode,@country,@phoneNumber)";
            using var command = new SqlCommand("registerPatient", connection);
            command.CommandType = CommandType.StoredProcedure;

            //string query2 = "INSERT INTO Patient(pdID) "
            //    + "values((select pdID from PersonalDetails where firstName = @firstname and lastName = @lastname and dateOfBirth = @dateOfBirth))";

            //using var command2 = new SqlCommand(query2, connection);

            command.Parameters.Add("@Firstname", System.Data.SqlDbType.VarChar);
            command.Parameters["@Firstname"].Value = firstname;

            command.Parameters.Add("@Lastname", System.Data.SqlDbType.VarChar);
            command.Parameters["@Lastname"].Value = lastname;

            command.Parameters.Add("@PhoneNumber", System.Data.SqlDbType.VarChar);
            command.Parameters["@PhoneNumber"].Value = phoneNumber;

            command.Parameters.Add("@Street", System.Data.SqlDbType.VarChar);
            command.Parameters["@Street"].Value = street;

            command.Parameters.Add("@City", System.Data.SqlDbType.VarChar);
            command.Parameters["@City"].Value = city;

            command.Parameters.Add("@Country", System.Data.SqlDbType.VarChar);
            command.Parameters["@Country"].Value = country;

            command.Parameters.Add("@ZipCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@ZipCode"].Value = zipCode;

            command.Parameters.Add("@State", System.Data.SqlDbType.VarChar);
            command.Parameters["@State"].Value = state;

            command.Parameters.Add("@Gender", System.Data.SqlDbType.VarChar);
            command.Parameters["@Gender"].Value = gender;

            command.Parameters.Add("@DateOfBirth", System.Data.SqlDbType.Date);
            command.Parameters["@DateOfBirth"].Value = dateOfBirth;

            //command2.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar);
            //command2.Parameters["@firstname"].Value = firstname;

            //command2.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar);
            //command2.Parameters["@lastname"].Value = lastname;

            //command2.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.Date);
            //command2.Parameters["@dateOfBirth"].Value = dateOfBirth;

            command.ExecuteNonQuery();
            //command2.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the patient details.
        /// </summary>
        /// <param name="patientDetails">The patient details.</param>
        public void UpdatePatientDetails(PersonalDetails patientDetails)
        {
            var firstname = patientDetails.FirstName;
            var lastname = patientDetails.LastName;
            var dateOfBirth = patientDetails.DateOfBirth;
            var phoneNumber = patientDetails.PhoneNumber;
            var street = patientDetails.Street;
            var city = patientDetails.City;
            var country = patientDetails.Country;
            var zipCode = patientDetails.ZipCode;
            var state = patientDetails.State;
            var gender = patientDetails.Gender;

            using var connection = DBConnection.GetConnection();
            connection.Open();

            string query = "Update PersonalDetails set firstName = @firstname, lastName = @lastname, dateOfBirth = @dateOfBirth, " +
                           " gender = @gender, streetAddress = @street, state = @state, zipCode = @zipCode, city = @city, " +
                           " country = @country, phoneNumber = @phoneNumber where " +
                           "pdID = (select pdID from Patient where patientID = @patientId)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@patientId", SqlDbType.Int);
            command.Parameters["@patientId"].Value = patientDetails.PdID;

            command.Parameters.Add("@firstname", SqlDbType.VarChar);
            command.Parameters["@firstname"].Value = firstname;

            command.Parameters.Add("@lastname", SqlDbType.VarChar);
            command.Parameters["@lastname"].Value = lastname;

            command.Parameters.Add("@phoneNumber", SqlDbType.VarChar);
            command.Parameters["@phoneNumber"].Value = phoneNumber;

            command.Parameters.Add("@street", SqlDbType.VarChar);
            command.Parameters["@street"].Value = street;

            command.Parameters.Add("@city", SqlDbType.VarChar);
            command.Parameters["@city"].Value = city;

            command.Parameters.Add("@country", SqlDbType.VarChar);
            command.Parameters["@country"].Value = country;

            command.Parameters.Add("@zipCode", SqlDbType.VarChar);
            command.Parameters["@zipCode"].Value = zipCode;

            command.Parameters.Add("@state", SqlDbType.VarChar);
            command.Parameters["@state"].Value = state;

            command.Parameters.Add("@gender", SqlDbType.VarChar);
            command.Parameters["@gender"].Value = gender;

            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Books the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void BookAppointment(Appointment appointment)
        {
            var patientId = appointment.PatientId;
            var doctorId = appointment.DoctorId;
            var reason = appointment.Reason;
            var date = appointment.ScheduledTime;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO Appointment(patientID, doctorID, reason, scheduledDate) " +
                "VALUES(@patientId, @doctorId, @reason, @date)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@patientId", System.Data.SqlDbType.Int);
            command.Parameters["@patientId"].Value = patientId;

            command.Parameters.Add("@doctorId", System.Data.SqlDbType.Int);
            command.Parameters["@doctorId"].Value = doctorId;

            command.Parameters.Add("@reason", System.Data.SqlDbType.VarChar);
            command.Parameters["@reason"].Value = reason;

            command.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
            command.Parameters["@date"].Value = date;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void UpdateAppointment(Appointment appointment)
        {
            var appointmentId = appointment.AppointmentId;
            var patientId = appointment.PatientId;
            var doctorId = appointment.DoctorId;
            var reason = appointment.Reason;
            var date = appointment.ScheduledTime;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "UPDATE Appointment SET doctorID = @doctorId, " +
                "reason = @reason, scheduledDate = @date WHERE appointmentID = @appointmentId ";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", System.Data.SqlDbType.Int);
            command.Parameters["@appointmentId"].Value = appointmentId;

            command.Parameters.Add("@doctorId", System.Data.SqlDbType.Int);
            command.Parameters["@doctorId"].Value = doctorId;

            command.Parameters.Add("@reason", System.Data.SqlDbType.VarChar);
            command.Parameters["@reason"].Value = reason;

            command.Parameters.Add("@date", System.Data.SqlDbType.DateTime);
            command.Parameters["@date"].Value = date;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Adds the routine checkup.
        /// </summary>
        /// <param name="visit">The visit.</param>
        public void AddRoutineCheckup(Visit visit)
        {
            var height = visit.Height;
            var weight = visit.Weight;
            var systolicBP = visit.SystolicBp;
            var diastolicBP = visit.DiastolicBp;
            var bodyTemperature = visit.BodyTemperature;
            var pulse = visit.Pulse;
            var symptoms = visit.Symptoms;
            var visitId = visit.VisitId;

            using var connection = DBConnection.GetConnection();
            connection.Open();
            
            string query = "UPDATE Visit SET height = @height, weight = @weight, systolicBP = @systolicBP " +
                           "diastolicBP = @diastolicBP, bodyTemperature = @bodyTemperature, pulse = @pulse, symptoms = @symptoms " +
                           "WHERE visitID = @visitId ";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@height", System.Data.SqlDbType.Decimal);
            command.Parameters["@height"].Value = height;

            command.Parameters.Add("@weight", System.Data.SqlDbType.Decimal);
            command.Parameters["@weight"].Value = weight;

            command.Parameters.Add("@systolicBP", System.Data.SqlDbType.Int);
            command.Parameters["@systolicBP"].Value = systolicBP;   

            command.Parameters.Add("@diastolicBP", System.Data.SqlDbType.Int);
            command.Parameters["@diastolicBP"].Value = diastolicBP;

            command.Parameters.Add("@bodyTemperature", System.Data.SqlDbType.Decimal);
            command.Parameters["@bodyTemperature"].Value = bodyTemperature;

            command.Parameters.Add("@pulse", System.Data.SqlDbType.Int);
            command.Parameters["@pulse"].Value = pulse;

            command.Parameters.Add("@symptoms", System.Data.SqlDbType.VarChar);
            command.Parameters["@symptoms"].Value = symptoms;

            command.Parameters.Add("@visitId", System.Data.SqlDbType.Int);
            command.Parameters["@visitId"].Value = visitId;

            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <returns></returns>
        public List<string> GetStates()
        {
            var states = new List<string>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select stateName from states";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var stateNameOrdinal = reader.GetOrdinal("stateName");
            while (reader.Read())
            {
                var state = reader.GetString(stateNameOrdinal);
                states.Add(state);
            }
            return states;
        }

        /// <summary>
        /// Gets the doctor appointment times.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public List<DateTime> GetDoctorAppointmentTimes(int id)
        {
            var times = new List<DateTime>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select scheduledDate from Appointment where doctorID = @id";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters["@id"].Value = id;
            using var reader = command.ExecuteReader();
            var dateOrdinal = reader.GetOrdinal("scheduledDate");
            while (reader.Read())
            {
                var date = reader.GetDateTime(dateOrdinal);
                times.Add(date);
            }
            return times;
        }

        /// <summary>
        /// This method deletes the appointment with the given id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteAppointment(int id)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "delete from Appointment where appointmentId = @id";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters["@id"].Value = id;

            command.ExecuteScalar();
        }

        public void DeletePatient(int id)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            //string query = "delete from Patient where pdId = @id";
            using var command = new SqlCommand("deletePatient", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@PersonalDetailsID", System.Data.SqlDbType.Int);
            command.Parameters["@PersonalDetailsID"].Value = id;
            //command.ExecuteNonQuery();
            command.ExecuteScalar();
        }

        /// <summary>
        /// Validates the patient.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool ValidatePatient(int id)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();

            const string query = "SELECT count(*) FROM Patient " +
                                 "WHERE patientID = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = id;

            var count = Convert.ToInt32(command.ExecuteScalar());

            return count == 1;
        }

        /// <summary>
        /// Gets the doctors.
        /// </summary>
        /// <returns></returns>
        public List<Doctor> GetDoctors()
        {
            var doctors = new List<Doctor>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select doctorID, p.pdID, firstName, lastName from Doctor as d, PersonalDetails as p where d.pdID = p.pdID";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var didOrdinal = reader.GetOrdinal("doctorID");
            var pdidOrdinal = reader.GetOrdinal("pdID");
            var firstOrdinal = reader.GetOrdinal("firstName");
            var lastOrdinal = reader.GetOrdinal("lastName");

            while (reader.Read())
            {
                var doctorId = reader.GetInt32(didOrdinal);
                var firstName = reader.GetString(firstOrdinal);
                var lastName = reader.GetString(lastOrdinal);
                var pdID = reader.GetInt32(pdidOrdinal);
                doctors.Add(new Doctor
                {
                    doctorID = doctorId,
                    pdID = pdID,
                    Name = firstName + " " + lastName,
                });
            }
            return doctors;
        }

        /// <summary>
        /// This method returns list of tests from database
        /// </summary>
        /// <returns>List of tests</returns>
        public List<TestList> GetTests()
        {
            var tests = new List<TestList>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select testID, testName from Tests";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var idOrdinal = reader.GetOrdinal("testID");
            var nameOrdinal = reader.GetOrdinal("testName");

            while (reader.Read())
            {
                var id = reader.GetInt32(idOrdinal);
                var Name = reader.GetString(nameOrdinal);
                tests.Add(new TestList
                {
                    Id = id,
                    Name = Name
                });
            }
            return tests;
        }

        /// <summary>
        /// Checks the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool CheckUser(string username, string password)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Users where userName = @username and password = @password";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
            command.Parameters["@username"].Value = username;
            command.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            command.Parameters["@password"].Value = password;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }

        /// <summary>
        /// This method checks if there is a visit assosiated with an appointment
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if there is a visit</returns>
        public bool CheckVisit(int id)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Visit where appointmentID = @id";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar);
            command.Parameters["@id"].Value = id;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 1;
        }

        public bool CheckAppointment(int id)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Appointment, Patient where Patient.patientID = Appointment.patientID and Patient.pdID = @id";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters["@id"].Value = id;
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count >= 1;
        }

        /// <summary>
        /// Gets the patient with dob.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithDob(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var dateOfBirth = patient.DateOfBirth;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select personalDetails.pdID as pdId, firstName, lastName, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and dateOfBirth = @dateOfBirth";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("pdId");
            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var lastNameOrdinal = reader.GetOrdinal("lastName");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
            var genderOrdinal = reader.GetOrdinal("gender");
            var streetOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var pdId = reader.GetInt32(patientIdOrdinal);
                var firstName = reader.GetString(firstNameOrdinal);
                var lastName = reader.GetString(lastNameOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);
                var gender = reader.GetString(genderOrdinal);
                var street = reader.GetString(streetOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zip = reader.GetString(zipOrdinal);
                var country = reader.GetString(countryOrdinal);

                patients.Add(new PersonalDetails
                {
                    PdID = pdId,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    PhoneNumber = phoneNumber,
                    Gender = gender,
                    Street = street,
                    City = city,
                    State = state,
                    ZipCode = zip,
                    Country = country
                });
            }
            return patients;
        }

        /// <summary>
        /// Gets the patient with dob and lastname.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithDobAndLastname(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var dateOfBirth = patient.DateOfBirth;
            var lastNameFromPatient = patient.LastName;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select personalDetails.pdID as pdId, firstName, lastName, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and dateOfBirth = @dateOfBirth and lastName = @lastName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            command.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastNameFromPatient;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("pdId");
            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var lastNameOrdinal = reader.GetOrdinal("lastName");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
            var genderOrdinal = reader.GetOrdinal("gender");
            var streetOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var pdId = reader.GetInt32(patientIdOrdinal);
                var firstName = reader.GetString(firstNameOrdinal);
                var lastName = reader.GetString(lastNameOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);
                var gender = reader.GetString(genderOrdinal);
                var street = reader.GetString(streetOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zip = reader.GetString(zipOrdinal);
                var country = reader.GetString(countryOrdinal);

                patients.Add(new PersonalDetails
                {
                    PdID = pdId,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    PhoneNumber = phoneNumber,
                    Gender = gender,
                    Street = street,
                    City = city,
                    State = state,
                    ZipCode = zip,
                    Country = country
                });
            }
            return patients;
        }

        /// <summary>
        /// Gets the patient with firstname and lastname.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<PersonalDetails> GetPatientWithFirstnameAndLastname(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var firstNameFromPatient = patient.FirstName;
            var lastNameFromPatient = patient.LastName;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select personalDetails.pdID as pdId, firstName, lastName, dateOfBirth, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and firstName = @firstName and lastName = @lastName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            command.Parameters["@firstName"].Value = firstNameFromPatient;
            command.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastNameFromPatient;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("pdId");
            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var lastNameOrdinal = reader.GetOrdinal("lastName");
            var dateOfBirthOrdinal = reader.GetOrdinal("dateOfBirth");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
            var genderOrdinal = reader.GetOrdinal("gender");
            var streetOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var pdId = reader.GetInt32(patientIdOrdinal);
                var firstName = reader.GetString(firstNameOrdinal);
                var lastName = reader.GetString(lastNameOrdinal);
                var dateOfBirth = reader.GetDateTime(dateOfBirthOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);
                var gender = reader.GetString(genderOrdinal);
                var street = reader.GetString(streetOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zip = reader.GetString(zipOrdinal);
                var country = reader.GetString(countryOrdinal);

                patients.Add(new PersonalDetails
                {
                    PdID = pdId,
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    PhoneNumber = phoneNumber,
                    Gender = gender,
                    Street = street,
                    City = city,
                    State = state,
                    ZipCode = zip,
                    Country = country
                });
            }
            return patients;
        }

        /// <summary>
        /// Gets the patient appointments.
        /// </summary>
        /// <param name="patientId">The patient identifier.</param>
        /// <returns></returns>
        public List<Appointment> GetPatientAppointments(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using var connection = DBConnection.GetConnection();
            connection.Open();

            var query =
                "select appointmentID, patientID, Appointment.doctorID,PersonalDetails.firstName AS doctorFirstName, PersonalDetails.lastName AS doctorLastName, scheduledDate, reason from Appointment,PersonalDetails,Doctor where patientID = @patientId and Doctor.pdID = PersonalDetails.pdID and Doctor.doctorID = Appointment.doctorID";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@patientId", SqlDbType.Int);
            command.Parameters["@patientId"].Value = patientId;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("scheduledDate");
            var reasonOrdinal = reader.GetOrdinal("reason");
            var doctorFirstOrdinal = reader.GetOrdinal("doctorFirstName");
            var doctorLastOrdinal = reader.GetOrdinal("doctorLastName");

            while (reader.Read())
            {
                var patient = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);
                var doctorfirstName = reader.GetString(doctorFirstOrdinal);
                var doctorlastName = reader.GetString(doctorLastOrdinal);

                appointments.Add(new Appointment
                {
                    PatientId = patient,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason,
                    Name = doctorfirstName + " " + doctorlastName
                });
            }

            return appointments;
        }

        /// <summary>
        /// Gets the patient visits.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <returns></returns>
        public List<Visit> GetPatientVisits(int appointmentId)
        {
            List<Visit> appointmentVisits = new List<Visit>();

            using var connection = DBConnection.GetConnection();
            connection.Open();

            var query = "select visitID, nurseID, height, weight, systolicBP, diastolicBP, bodyTemperature, " +
                        "pulse, symptoms, initialDiagnosis, finalDiagnosis from Visit where appointmentID = @appointmentId;";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", SqlDbType.Int);
            command.Parameters["@appointmentId"].Value = appointmentId;
            using var reader = command.ExecuteReader();

            var visitIdOrdinal = reader.GetOrdinal("visitID");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");
            var heightOrdinal = reader.GetOrdinal("height");
            var weightOrdinal = reader.GetOrdinal("weight");
            var sysOrdinal = reader.GetOrdinal("systolicBP");
            var diaBpOrdinal = reader.GetOrdinal("diastolicBP");
            var tempOrdinal = reader.GetOrdinal("bodyTemperature");
            var pulseOrdinal = reader.GetOrdinal("pulse");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var iniOrdinal = reader.GetOrdinal("initialDiagnosis");
            var finalOrdinal = reader.GetOrdinal("finalDiagnosis");

            while (reader.Read())
            {
                var visitId = reader.GetInt32(visitIdOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                var height = reader.IsDBNull(heightOrdinal) ? -1 : reader.GetDecimal(heightOrdinal);
                var weight = reader.IsDBNull(weightOrdinal) ? -1 : reader.GetDecimal(weightOrdinal);
                var sysBp = reader.IsDBNull(sysOrdinal) ? -1 : reader.GetInt32(sysOrdinal);
                var diaBp = reader.IsDBNull(diaBpOrdinal) ? -1 : reader.GetInt32(diaBpOrdinal);
                var temp = reader.IsDBNull(tempOrdinal) ? -1 : reader.GetDecimal(tempOrdinal);
                var pulse = reader.IsDBNull(pulseOrdinal) ? -1 : reader.GetInt32(pulseOrdinal);
                var symptoms = reader.IsDBNull(symptomsOrdinal) ? "" : reader.GetString(symptomsOrdinal);
                var initial = reader.IsDBNull(iniOrdinal) ? "" : reader.GetString(iniOrdinal);
                var final = reader.IsDBNull(finalOrdinal)
                    ? "" : reader.GetString(finalOrdinal);

                appointmentVisits.Add(new Visit
                {
                    VisitId = visitId,
                    AppointmentId = appointmentId,
                    NurseId = nurseId,
                    Height = height,
                    Weight = weight,
                    SystolicBp = sysBp,
                    DiastolicBp = diaBp,
                    BodyTemperature = temp,
                    Pulse = pulse,
                    Symptoms = symptoms,
                    InitialDiagnosis = initial,
                    FinalDiagnosis = final
                });
            }

            return appointmentVisits;
        }

        /// <summary>
        /// Gets the appointments with dob.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsWithDOB(PersonalDetails patient)
        {
            var dateOfBirth = patient.DateOfBirth;
            List<Appointment> appointments = new List<Appointment>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "SELECT Appointment.appointmentID, Patient.patientID, Doctor.doctorID, " +
                "DoctorDetails.firstName AS doctorFirstName, DoctorDetails.lastName AS doctorLastName, " +
                        " Appointment.scheduledDate, Appointment.reason " +
                        " FROM Appointment " +
                        " JOIN Patient ON Appointment.patientID = Patient.patientID " +
                        " JOIN PersonalDetails AS PatientDetails ON Patient.pdID = PatientDetails.pdID " +
                        " JOIN Doctor ON Appointment.doctorID = Doctor.doctorID " +
                        " JOIN PersonalDetails AS DoctorDetails ON Doctor.pdID = DoctorDetails.pdID " +
                        " where PatientDetails.dateOfBirth = @dateOfBirth ";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("scheduledDate");
            var reasonOrdinal = reader.GetOrdinal("reason");
            var doctorFirstOrdinal = reader.GetOrdinal("doctorFirstName");
            var doctorLastOrdinal = reader.GetOrdinal("doctorLastName");

            while (reader.Read())
            {
                var patientID = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);
                var doctorfirstName = reader.GetString(doctorFirstOrdinal);
                var doctorlastName = reader.GetString(doctorLastOrdinal);

                appointments.Add(new Appointment
                {
                    PatientId = patientID,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason,
                    Name = doctorfirstName + " " + doctorlastName
                });
            }

            return appointments;


        }

        /// <summary>
        /// Gets the appointments with dob and lastname.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsWithDOBAndLastname(PersonalDetails patient)
        {
            var dateOfBirth = patient.DateOfBirth;
            var lastName = patient.LastName;
            List<Appointment> appointments = new List<Appointment>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "SELECT Appointment.appointmentID, Patient.patientID, Doctor.doctorID, " +
                "DoctorDetails.firstName AS doctorFirstName, DoctorDetails.lastName AS doctorLastName, " +
                        " Appointment.scheduledDate, Appointment.reason " +
                        " FROM Appointment " +
                        " JOIN Patient ON Appointment.patientID = Patient.patientID " +
                        " JOIN PersonalDetails AS PatientDetails ON Patient.pdID = PatientDetails.pdID " +
                        " JOIN Doctor ON Appointment.doctorID = Doctor.doctorID " +
                        " JOIN PersonalDetails AS DoctorDetails ON Doctor.pdID = DoctorDetails.pdID " +
                        " where PatientDetails.dateOfBirth = @dateOfBirth and PatientDetails.lastName = @lastName";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            command.Parameters.Add("@lastName", SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastName;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("scheduledDate");
            var reasonOrdinal = reader.GetOrdinal("reason");
            var doctorFirstOrdinal = reader.GetOrdinal("doctorFirstName");
            var doctorLastOrdinal = reader.GetOrdinal("doctorLastName");

            while (reader.Read())
            {
                var patientID = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);
                var doctorfirstName = reader.GetString(doctorFirstOrdinal);
                var doctorlastName = reader.GetString(doctorLastOrdinal);

                appointments.Add(new Appointment
                {
                    PatientId = patientID,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason,
                    Name = doctorfirstName + " " + doctorlastName
                });
            }
            return appointments;
        }

        /// <summary>
        /// Gets the last name of the appointment with first name and.
        /// </summary>
        /// <param name="patient">The patient.</param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentWithFirstNameAndLastName(PersonalDetails patient)
        {
            var firstName = patient.FirstName;
            var lastName = patient.LastName;
            List<Appointment> appointments = new List<Appointment>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "SELECT Appointment.appointmentID, Patient.patientID, Doctor.doctorID, " +
                "DoctorDetails.firstName AS doctorFirstName, DoctorDetails.lastName AS doctorLastName, " +
                        " Appointment.scheduledDate, Appointment.reason " + 
                        " FROM Appointment " + 
                        " JOIN Patient ON Appointment.patientID = Patient.patientID " + 
                        " JOIN PersonalDetails AS PatientDetails ON Patient.pdID = PatientDetails.pdID " + 
                        " JOIN Doctor ON Appointment.doctorID = Doctor.doctorID " + 
                        " JOIN PersonalDetails AS DoctorDetails ON Doctor.pdID = DoctorDetails.pdID " +
                        " WHERE PatientDetails.firstName = @firstName and PatientDetails.lastName = @lastName";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@firstName", SqlDbType.VarChar);
            command.Parameters["@firstName"].Value = firstName;
            command.Parameters.Add("@lastName", SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastName;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("scheduledDate");
            var reasonOrdinal = reader.GetOrdinal("reason");
            var doctorFirstOrdinal = reader.GetOrdinal("doctorFirstName");
            var doctorLastOrdinal = reader.GetOrdinal("doctorLastName");

            while (reader.Read())
            {
                var patientID = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);
                var doctorfirstName = reader.GetString(doctorFirstOrdinal);
                var doctorlastName = reader.GetString(doctorLastOrdinal);

                appointments.Add(new Appointment
                {
                    PatientId = patientID,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason,
                    Name = doctorfirstName + " " + doctorlastName
                });
            }
            return appointments;
        }

        /// <summary>
        /// Gets the nurse with the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public Nurse GetNurse(string username)
        {
            var nurse = new Nurse();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select PersonalDetails.firstName, PersonalDetails.lastName ,Nurse.nurseID from " +
                           "PersonalDetails, Nurse, Users where Users.pdID = nurse.pdID and " +
                           "PersonalDetails.pdID = Users.pdID and users.userName = @username";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@username", SqlDbType.VarChar);
            command.Parameters["@username"].Value = username;
            using var reader = command.ExecuteReader();

            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var lastNameOrdinal = reader.GetOrdinal("lastName");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");

            while (reader.Read())
            {
                var firstName = reader.GetString(firstNameOrdinal);
                var lastName = reader.GetString(lastNameOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                
                nurse.FirstName = firstName; 
                nurse.LastName = lastName;
                nurse.NurseId = nurseId;

            }
            return nurse;
        }

        public int GetPatientId(int pdId)
        {
            int patientId = 0;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select patientID from Patient, PersonalDetails where " +
                           "Patient.pdID = PersonalDetails.pdID and Patient.pdID = @pdId";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@pdId", SqlDbType.Int);
            command.Parameters["@pdId"].Value = pdId;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");

            while (reader.Read())
            {
                patientId = reader.GetInt32(patientIdOrdinal);
            }

            return patientId;
        }

        public int GetNurseId(string username)
        {
            int nurseId = 0;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select nurseID from Nurse, Users where Users.pdID = nurse.pdID and users.userName = @username";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@username", SqlDbType.VarChar);
            command.Parameters["@username"].Value = username;
            using var reader = command.ExecuteReader();

            var nurseIdOrdinal = reader.GetOrdinal("nurseID");

            while (reader.Read())
            {
                nurseId = reader.GetInt32(nurseIdOrdinal);
            }

            return nurseId;
        }

        public List<Appointment> GetTodaysAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select appointmentID, patientID, Appointment.doctorID,PersonalDetails.firstName AS doctorFirstName, PersonalDetails.lastName AS doctorLastName, scheduledDate, reason from Appointment,Doctor,PersonalDetails " +
                           "where convert(date, scheduledDate) = convert(date, GETDATE()) and Doctor.pdID = PersonalDetails.pdID and Doctor.doctorID = Appointment.doctorID";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("scheduledDate");
            var reasonOrdinal = reader.GetOrdinal("reason");
            var doctorFirstOrdinal = reader.GetOrdinal("doctorFirstName");
            var doctorLastOrdinal = reader.GetOrdinal("doctorLastName");

            while (reader.Read())
            {
                var patientId = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);
                var doctorfirstName = reader.GetString(doctorFirstOrdinal);
                var doctorlastName = reader.GetString(doctorLastOrdinal);


                appointments.Add(new Appointment
                {
                    PatientId = patientId,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason,
                    Name = doctorfirstName + " " + doctorlastName
                });
            }
            return appointments;
        }

        public List<Visit> GetVisitWithDOB(PersonalDetails patient)
        {
            var dateOfBirth = patient.DateOfBirth;
            
            List<Visit> appointments = new List<Visit>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "select Visit.appointmentID,Visit.nurseID,Visit.visitID,Visit.height,Visit.weight,Visit.systolicBP,Visit.diastolicBP,Visit.bodyTemperature, "  + 
                "Visit.pulse, Visit.symptoms, Visit.initialDiagnosis,Visit.finalDiagnosis from Visit,Appointment,PersonalDetails,Patient where PersonalDetails.dateOfBirth = @dateOfBirth and PersonalDetails.pdID = Patient.pdID and Patient.patientID = Appointment.patientID and Visit.appointmentID = Appointment.appointmentID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            
            using var reader = command.ExecuteReader();

            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var visitIdOrdinal = reader.GetOrdinal("visitID");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");
            var heightOrdinal = reader.GetOrdinal("height");
            var weightOrdinal = reader.GetOrdinal("weight");
            var sysOrdinal = reader.GetOrdinal("systolicBP");
            var diaBpOrdinal = reader.GetOrdinal("diastolicBP");
            var tempOrdinal = reader.GetOrdinal("bodyTemperature");
            var pulseOrdinal = reader.GetOrdinal("pulse");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var iniOrdinal = reader.GetOrdinal("initialDiagnosis");
            var finalOrdinal = reader.GetOrdinal("finalDiagnosis");

            while (reader.Read())
            {
                var visitId = reader.GetInt32(visitIdOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var height = reader.IsDBNull(heightOrdinal) ? -1 : reader.GetDecimal(heightOrdinal);
                var weight = reader.IsDBNull(weightOrdinal) ? -1 : reader.GetDecimal(weightOrdinal);
                var sysBp = reader.IsDBNull(sysOrdinal) ? -1 : reader.GetInt32(sysOrdinal);
                var diaBp = reader.IsDBNull(diaBpOrdinal) ? -1 : reader.GetInt32(diaBpOrdinal);
                var temp = reader.IsDBNull(tempOrdinal) ? -1 : reader.GetDecimal(tempOrdinal);
                var pulse = reader.IsDBNull(pulseOrdinal) ? -1 : reader.GetInt32(pulseOrdinal);
                var symptoms = reader.IsDBNull(symptomsOrdinal) ? "" : reader.GetString(symptomsOrdinal);
                var initial = reader.IsDBNull(iniOrdinal) ? "" : reader.GetString(iniOrdinal);
                var final = reader.IsDBNull(finalOrdinal)
                    ? "" : reader.GetString(finalOrdinal);

                appointments.Add(new Visit
                {
                    VisitId = visitId,
                    AppointmentId = appointmentId,
                    NurseId = nurseId,
                    Height = height,
                    Weight = weight,
                    SystolicBp = sysBp,
                    DiastolicBp = diaBp,
                    BodyTemperature = temp,
                    Pulse = pulse,
                    Symptoms = symptoms,
                    InitialDiagnosis = initial,
                    FinalDiagnosis = final
                });
            }

            return appointments;
        }

        public List<Visit> GetVisitWithDOBAndLastName(PersonalDetails patient)
        {
            var dateOfBirth = patient.DateOfBirth;
            var lastName = patient.LastName;
            List<Visit> appointments = new List<Visit>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "select Visit.appointmentID,Visit.nurseID,Visit.visitID,Visit.height,Visit.weight,Visit.systolicBP,Visit.diastolicBP,Visit.bodyTemperature, " +
                "Visit.pulse, Visit.symptoms, Visit.initialDiagnosis,Visit.finalDiagnosis from Visit,Appointment,PersonalDetails,Patient where PersonalDetails.dateOfBirth = @dateOfBirth and PersonalDetails.lastName = @lastName and PersonalDetails.pdID = Patient.pdID and Patient.patientID = Appointment.patientID and Visit.appointmentID = Appointment.appointmentID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@dateOfBirth", SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            command.Parameters.Add("lastName", SqlDbType.VarChar);
            command.Parameters["lastName"].Value = lastName;
            using var reader = command.ExecuteReader();

            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var visitIdOrdinal = reader.GetOrdinal("visitID");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");
            var heightOrdinal = reader.GetOrdinal("height");
            var weightOrdinal = reader.GetOrdinal("weight");
            var sysOrdinal = reader.GetOrdinal("systolicBP");
            var diaBpOrdinal = reader.GetOrdinal("diastolicBP");
            var tempOrdinal = reader.GetOrdinal("bodyTemperature");
            var pulseOrdinal = reader.GetOrdinal("pulse");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var iniOrdinal = reader.GetOrdinal("initialDiagnosis");
            var finalOrdinal = reader.GetOrdinal("finalDiagnosis");

            while (reader.Read())
            {
                var visitId = reader.GetInt32(visitIdOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var height = reader.IsDBNull(heightOrdinal) ? -1 : reader.GetDecimal(heightOrdinal);
                var weight = reader.IsDBNull(weightOrdinal) ? -1 : reader.GetDecimal(weightOrdinal);
                var sysBp = reader.IsDBNull(sysOrdinal) ? -1 : reader.GetInt32(sysOrdinal);
                var diaBp = reader.IsDBNull(diaBpOrdinal) ? -1 : reader.GetInt32(diaBpOrdinal);
                var temp = reader.IsDBNull(tempOrdinal) ? -1 : reader.GetDecimal(tempOrdinal);
                var pulse = reader.IsDBNull(pulseOrdinal) ? -1 : reader.GetInt32(pulseOrdinal);
                var symptoms = reader.IsDBNull(symptomsOrdinal) ? "" : reader.GetString(symptomsOrdinal);
                var initial = reader.IsDBNull(iniOrdinal) ? "" : reader.GetString(iniOrdinal);
                var final = reader.IsDBNull(finalOrdinal)
                    ? "" : reader.GetString(finalOrdinal);

                appointments.Add(new Visit
                {
                    VisitId = visitId,
                    AppointmentId = appointmentId,
                    NurseId = nurseId,
                    Height = height,
                    Weight = weight,
                    SystolicBp = sysBp,
                    DiastolicBp = diaBp,
                    BodyTemperature = temp,
                    Pulse = pulse,
                    Symptoms = symptoms,
                    InitialDiagnosis = initial,
                    FinalDiagnosis = final
                });
            }

            return appointments;
        }

        internal List<Visit> GetVisitWithFirstAndLastName(PersonalDetails patient)
        {

            var firstName = patient.FirstName;
            var lastName = patient.LastName;
            List<Visit> appointments = new List<Visit>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            var query = "select Visit.appointmentID,Visit.nurseID,Visit.visitID,Visit.height,Visit.weight,Visit.systolicBP,Visit.diastolicBP,Visit.bodyTemperature, " +
                "Visit.pulse, Visit.symptoms, Visit.initialDiagnosis,Visit.finalDiagnosis from Visit,Appointment,PersonalDetails,Patient where PersonalDetails.firstName = @firstName and PersonalDetails.lastName = @lastName and PersonalDetails.pdID = Patient.pdID and Patient.patientID = Appointment.patientID and Visit.appointmentID = Appointment.appointmentID";
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("lastName", SqlDbType.VarChar);
            command.Parameters["lastName"].Value = lastName;
            command.Parameters.Add("firstName", SqlDbType.VarChar);
            command.Parameters["firstName"].Value = firstName;
            using var reader = command.ExecuteReader();

            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var visitIdOrdinal = reader.GetOrdinal("visitID");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");
            var heightOrdinal = reader.GetOrdinal("height");
            var weightOrdinal = reader.GetOrdinal("weight");
            var sysOrdinal = reader.GetOrdinal("systolicBP");
            var diaBpOrdinal = reader.GetOrdinal("diastolicBP");
            var tempOrdinal = reader.GetOrdinal("bodyTemperature");
            var pulseOrdinal = reader.GetOrdinal("pulse");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var iniOrdinal = reader.GetOrdinal("initialDiagnosis");
            var finalOrdinal = reader.GetOrdinal("finalDiagnosis");

            while (reader.Read())
            {
                var visitId = reader.GetInt32(visitIdOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var height = reader.IsDBNull(heightOrdinal) ? -1 : reader.GetDecimal(heightOrdinal);
                var weight = reader.IsDBNull(weightOrdinal) ? -1 : reader.GetDecimal(weightOrdinal);
                var sysBp = reader.IsDBNull(sysOrdinal) ? -1 : reader.GetInt32(sysOrdinal);
                var diaBp = reader.IsDBNull(diaBpOrdinal) ? -1 : reader.GetInt32(diaBpOrdinal);
                var temp = reader.IsDBNull(tempOrdinal) ? -1 : reader.GetDecimal(tempOrdinal);
                var pulse = reader.IsDBNull(pulseOrdinal) ? -1 : reader.GetInt32(pulseOrdinal);
                var symptoms = reader.IsDBNull(symptomsOrdinal) ? "" : reader.GetString(symptomsOrdinal);
                var initial = reader.IsDBNull(iniOrdinal) ? "" : reader.GetString(iniOrdinal);
                var final = reader.IsDBNull(finalOrdinal)
                    ? "" : reader.GetString(finalOrdinal);

                appointments.Add(new Visit
                {
                    VisitId = visitId,
                    AppointmentId = appointmentId,
                    NurseId = nurseId,
                    Height = height,
                    Weight = weight,
                    SystolicBp = sysBp,
                    DiastolicBp = diaBp,
                    BodyTemperature = temp,
                    Pulse = pulse,
                    Symptoms = symptoms,
                    InitialDiagnosis = initial,
                    FinalDiagnosis = final
                });
            }

            return appointments;
        }
    }
}