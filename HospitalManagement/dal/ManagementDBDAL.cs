using HospitalManagement.Model;
using System.Data.SqlClient;
using TechSupport.DAL;

namespace HospitalManagement.DAL
{
    public class ManagementDBDAL
    {
        public void RegisterPatient(PersonalDetails personalDetials)
        {
            var firstname = personalDetials.FirstName;
            var lastname = personalDetials.LastName;
            var dateOfBirth = personalDetials.DateOfBirth;
            var phonenumber = personalDetials.PhoneNumber;
            var street =  personalDetials.Street;
            var city = personalDetials.City;
            var country = personalDetials.Country;
            var zipCode = personalDetials.ZipCode;
            var state = personalDetials.State;
            var gender = personalDetials.Gender;
            using var connection = DBConnection.GetConnection();
            connection.Open();
            string query = "INSERT INTO PersonalDetails(firstName,lastName,dateOfBirth,gender,streetAddress,city,state,zipCode,country,phoneNumber) " +
                "VALUES(@firstname,@lastname,@dateOfBirth,@gender,@street,@city,@state,@zipCode,@country,@phonenumber)";
            using var command = new SqlCommand(query,connection);

            string query2 = "INSERT INTO Patient(pdID) "
                + "values((select pdID from PersonalDetails where firstName = @firstname and lastName = @lastname and dateOfBirth = @dateOfBirth))";

            using var command2 = new SqlCommand(query2, connection);

            command.Parameters.Add("@firstname",System.Data.SqlDbType.VarChar);
            command.Parameters["@firstname"].Value = firstname;

            command.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar);
            command.Parameters["@lastname"].Value = lastname;

            command.Parameters.Add("@phonenumber", System.Data.SqlDbType.VarChar);
            command.Parameters["@phonenumber"].Value = phonenumber;

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
    }
}
