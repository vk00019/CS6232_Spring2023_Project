using HospitalManagement.Model;
using System.Data;
using System.Data.SqlClient;

namespace HospitalManagement.DAL
{
    public class ManagementDbDal
    {
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
            string query = "INSERT INTO PersonalDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) " +
                "VALUES(@firstname,@lastname,@dateOfBirth,@gender,@street,@city,@state,@zipCode,@country,@phoneNumber)";
            using var command = new SqlCommand(query, connection);

            string query2 = "INSERT INTO Patient(pdID) "
                + "values((select pdID from PersonalDetails where firstName = @firstname and lastName = @lastname and dateOfBirth = @dateOfBirth))";

            using var command2 = new SqlCommand(query2, connection);

            command.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar);
            command.Parameters["@firstname"].Value = firstname;

            command.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastname"].Value = lastname;

            command.Parameters.Add("@phoneNumber", System.Data.SqlDbType.VarChar);
            command.Parameters["@phoneNumber"].Value = phoneNumber;

            command.Parameters.Add("@street", System.Data.SqlDbType.VarChar);
            command.Parameters["@street"].Value = street;

            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar);
            command.Parameters["@city"].Value = city;

            command.Parameters.Add("@country", System.Data.SqlDbType.VarChar);
            command.Parameters["@country"].Value = country;

            command.Parameters.Add("@zipCode", System.Data.SqlDbType.VarChar);
            command.Parameters["@zipCode"].Value = zipCode;

            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar);
            command.Parameters["@state"].Value = state;

            command.Parameters.Add("@gender", System.Data.SqlDbType.VarChar);
            command.Parameters["@gender"].Value = gender;

            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;

            command2.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar);
            command2.Parameters["@firstname"].Value = firstname;

            command2.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar);
            command2.Parameters["@lastname"].Value = lastname;

            command2.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.Date);
            command2.Parameters["@dateOfBirth"].Value = dateOfBirth;

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }

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

        public List<DateTime> GetAppointmentTimes(int id)
        {
            var times = new List<string>();
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select stateName from states";
            using var command = new SqlCommand(query, connection);
            using var reader = command.ExecuteReader();
            var stateNameOrdinal = reader.GetOrdinal("stateName");
            while (reader.Read())
            {
                var state = reader.GetString(stateNameOrdinal);
                times.Add(state);
            }
            return times;
        }

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

        public List<PersonalDetails> GetPatientWithDob(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var dateOfBirth = patient.DateOfBirth;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select patientID, firstName, lastName, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and dateOfBirth = @dateOfBirth";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
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
                var patientId = reader.GetInt32(patientIdOrdinal);
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
                    PdID = patientId,
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

        public List<PersonalDetails> GetPatientWithDobAndLastname(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var dateOfBirth = patient.DateOfBirth;
            var lastNameFromPatient = patient.LastName;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select patientID, firstName, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and dateOfBirth = @dateOfBirth and lastName = @lastName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@dateOfBirth", System.Data.SqlDbType.DateTime);
            command.Parameters["@dateOfBirth"].Value = dateOfBirth;
            command.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastNameFromPatient;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var firstNameOrdinal = reader.GetOrdinal("firstName");
            var phoneNumberOrdinal = reader.GetOrdinal("phoneNumber");
            var genderOrdinal = reader.GetOrdinal("gender");
            var streetOrdinal = reader.GetOrdinal("streetAddress");
            var cityOrdinal = reader.GetOrdinal("city");
            var stateOrdinal = reader.GetOrdinal("state");
            var zipOrdinal = reader.GetOrdinal("zipCode");
            var countryOrdinal = reader.GetOrdinal("country");

            while (reader.Read())
            {
                var patientId = reader.GetInt32(patientIdOrdinal);
                var firstName = reader.GetString(firstNameOrdinal);
                var phoneNumber = reader.GetString(phoneNumberOrdinal);
                var gender = reader.GetString(genderOrdinal);
                var street = reader.GetString(streetOrdinal);
                var city = reader.GetString(cityOrdinal);
                var state = reader.GetString(stateOrdinal);
                var zip = reader.GetString(zipOrdinal);
                var country = reader.GetString(countryOrdinal);

                patients.Add(new PersonalDetails
                {
                    PdID = patientId,
                    FirstName = firstName,
                    LastName = lastNameFromPatient,
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

        public List<PersonalDetails> GetPatientWithFirstnameAndLastname(PersonalDetails patient)
        {
            var patients = new List<PersonalDetails>();
            var firstNameFromPatient = patient.FirstName;
            var lastNameFromPatient = patient.LastName;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select patientID, dateOfBirth, phoneNumber, gender, streetAddress, city, state, zipCode, country " +
                "from PersonalDetails, patient where personalDetails.pdID = patient.pdID and firstName = @firstName and lastName = @lastName";
            using var command = new SqlCommand(query, connection);
            command.Parameters.Add("@firstName", System.Data.SqlDbType.VarChar);
            command.Parameters["@firstName"].Value = firstNameFromPatient;
            command.Parameters.Add("@lastName", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastNameFromPatient;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
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
                var patientId = reader.GetInt32(patientIdOrdinal);
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
                    PdID = patientId,
                    FirstName = firstNameFromPatient,
                    LastName = lastNameFromPatient,
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

        public List<Appointment> GetPatientAppointments(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>();

            using var connection = DBConnection.GetConnection();
            connection.Open();

            var query =
                "select appointmentID, patientID, doctorID, schedulateDate, reason from Appointment where patientID = @patientId";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@patientId", SqlDbType.Int);
            command.Parameters["@patientId"].Value = patientId;
            using var reader = command.ExecuteReader();

            var patientIdOrdinal = reader.GetOrdinal("patientID");
            var appointmentIdOrdinal = reader.GetOrdinal("appointmentID");
            var doctorIdOrdinal = reader.GetOrdinal("doctorID");
            var scheduledDateOrdinal = reader.GetOrdinal("schedulateDate");
            var reasonOrdinal = reader.GetOrdinal("reason");

            while (reader.Read())
            {
                var patient = reader.GetInt32(patientIdOrdinal);
                var appointmentId = reader.GetInt32(appointmentIdOrdinal);
                var doctorId = reader.GetInt32(doctorIdOrdinal);
                var scheduledDate = reader.GetDateTime(scheduledDateOrdinal);
                var reason = reader.GetString(reasonOrdinal);

                appointments.Add(new Appointment
                {
                    PatientId = patient,
                    AppointmentId = appointmentId,
                    DoctorId = doctorId,
                    ScheduledTime = scheduledDate,
                    Reason = reason
                });
            }

            return appointments;
        }

        public List<Visit> GetPatientVisits(int appointmentId)
        {
            List<Visit> appointmentVisits = new List<Visit>();

            using var connection = DBConnection.GetConnection();
            connection.Open();

            var query = "select visitID, nurseID, height, weight, systolicBP, diastolic, bodyTemperature, " +
                        "pulse, symptoms, initialDiagnosis, finalDiagnosis from Visit where appointmentID = @appointmentId;";

            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@appointmentId", SqlDbType.Int);
            command.Parameters["@appointmentId"].Value = appointmentId;
            using var reader = command.ExecuteReader();

            var visitIdOrdinal = reader.GetOrdinal("visitID");
            var nurseIdOrdinal = reader.GetOrdinal("nurseID");
            var heightOrdinal = reader.GetOrdinal("height");
            var weightOrdinal = reader.GetOrdinal("weight");
            var sysOrdinal = reader.GetOrdinal("systolicBp");
            var diaBpOrdinal = reader.GetOrdinal("diastolic");
            var tempOrdinal = reader.GetOrdinal("bodyTemperature");
            var pulseOrdinal = reader.GetOrdinal("pulse");
            var symptomsOrdinal = reader.GetOrdinal("symptoms");
            var iniOrdinal = reader.GetOrdinal("initialDiagnosis");
            var finalOrdinal = reader.GetOrdinal("finalDiagnosis");

            while (reader.Read())
            {
                var visitId = reader.GetInt32(visitIdOrdinal);
                var nurseId = reader.GetInt32(nurseIdOrdinal);
                var height = reader.GetString(heightOrdinal);
                var weight = reader.GetString(weightOrdinal);
                var sysBp = reader.GetInt32(sysOrdinal);
                var diaBp = reader.GetInt32(diaBpOrdinal);
                var temp = reader.GetInt32(tempOrdinal);
                var pulse = reader.GetInt32(pulseOrdinal);
                var symptoms = reader.GetString(symptomsOrdinal);
                var initial = reader.GetString(iniOrdinal);
                var final = reader.GetString(finalOrdinal);

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

    }
}
