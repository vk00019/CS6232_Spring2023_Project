using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    public partial class PatientRegistration : Form
    {
        private List<string> gender;
        private ManagementController _controller;
        public PatientRegistration()
        {
            _controller = new ManagementController();
            gender = new List<string>();
            AddGender();
            InitializeComponent();
            genderComboBox.DataSource = gender;
            statesComboBox.DataSource = _controller.GetStates();
        }

        private void AddGender()
        {
            gender.Add("Male");
            gender.Add("Female");
            gender.Add("Not Specified");
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumberTextBox.MaxLength = 10;
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void registerPatientButton_Click(object sender, EventArgs e)
        {
            CheckAllFields();
            if (errorLabel.Visible == true)
            {
                errorLabel.Text = "*All fields are required*";
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                errorLabel.Visible = false;
                var personalDetials = new PersonalDetails
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    DateOfBirth = birthDayDateTimePicker.Value,
                    PhoneNumber = phoneNumberTextBox.Text,
                    Gender = genderComboBox.SelectedItem.ToString(),
                    Street = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = statesComboBox.SelectedItem.ToString(),
                    ZipCode = zipCodeTextBox.Text,
                    Country = countryTextBox.Text
                };
                _controller.RegisterPatient(personalDetials);

            }
        }

        private void CheckAllFields()
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(streetAddressTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(zipCodeTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(countryTextBox.Text))
            {
                errorLabel.Visible = true;
            }
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            zipCodeTextBox.MaxLength = 5;
        }

        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
