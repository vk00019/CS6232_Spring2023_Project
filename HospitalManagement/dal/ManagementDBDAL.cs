using HospitalManagement.Model;
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
            var street =  personalDetails.Street;
            var city = personalDetails.City;
            var country = personalDetails.Country;
            var zipCode = personalDetails.ZipCode;
            var state = personalDetails.State;
            var gender = personalDetails.Gender;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO PersonalDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) " +
                "VALUES(@firstname,@lastname,@dateOfBirth,@gender,@street,@city,@state,@zipCode,@country,@phoneNumber)";
            using var command = new SqlCommand(query,connection);

            string query2 = "INSERT INTO Patient(pdID) "
                + "values((select pdID from PersonalDetails where firstName = @firstname and lastName = @lastname and dateOfBirth = @dateOfBirth))";

            using var command2 = new SqlCommand(query2, connection);

            command.Parameters.Add("@firstname",System.Data.SqlDbType.VarChar);
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
            using var command = new SqlCommand(query,connection);
            using var reader = command.ExecuteReader();
            var stateNameOrdinal = reader.GetOrdinal("stateName");
            while (reader.Read())
            {
                var state = reader.GetString(stateNameOrdinal);
                states.Add(state);
            }
            return states;
        }

        public bool CheckUser(string username, string password)
        {
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "select count(*) from Users where userName = @username and password = @password";
            using var command = new SqlCommand(query,connection);
            command.Parameters.Add("@username",System.Data.SqlDbType.VarChar);
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

            var patientIDOrdinal = reader.GetOrdinal("patientID");
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
                var patientID = reader.GetInt32(patientIDOrdinal);
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
                    PdID = patientID,
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
            command.Parameters.Add("@lastName",System.Data.SqlDbType.VarChar);
            command.Parameters["@lastName"].Value = lastNameFromPatient;
            using var reader = command.ExecuteReader();

            var patientIDOrdinal = reader.GetOrdinal("patientID");
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
                var patientID = reader.GetInt32(patientIDOrdinal);
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
                    PdID = patientID,
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

            var patientIDOrdinal = reader.GetOrdinal("patientID");
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
                var patientID = reader.GetInt32(patientIDOrdinal);
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
                    PdID = patientID,
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
    }
}
