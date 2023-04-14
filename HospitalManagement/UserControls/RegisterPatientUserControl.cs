using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.UserControls
{
    /// <summary>
    /// This class is used for register patients interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class RegisterPatientUserControl : UserControl
    {
        private List<string> _gender;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterPatientUserControl"/> class.
        /// </summary>
        public RegisterPatientUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _gender = new List<string>();
        }

        private void RegisterPatientButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            CheckAllFields();
            if (errorLabel.Visible)
            {
                errorLabel.Text = "*All fields are required to register*";
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                errorLabel.Visible = false;
                var personalDetails = new PersonalDetails
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
                _controller.RegisterPatient(personalDetails);
                ClearAllFields();
                errorLabel.Text = "Patient Registered Successfully";
                errorLabel.ForeColor = Color.Green;
                errorLabel.Visible = true;
            }
        }

        private void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {
            _gender = new List<string>();
            AddGender();
            genderComboBox.DataSource = _gender.ToArray();
            statesComboBox.DataSource = _controller.GetStates();
            birthDayDateTimePicker.MaxDate = DateTime.Now;
            birthDayDateTimePicker.Value = DateTime.Now.Date;
        }

        private void AddGender()
        {
            _gender.Add("Male");
            _gender.Add("Female");
            _gender.Add("Not Specified");
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

        private void ClearAllFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            streetAddressTextBox.Clear();
            cityTextBox.Clear();
            zipCodeTextBox.Clear();
            countryTextBox.Clear();
            genderComboBox.SelectedIndex = 0;
            statesComboBox.SelectedIndex = 0;
            birthDayDateTimePicker.ResetText();
        }

        private void ZipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            zipCodeTextBox.MaxLength = 5;
            errorLabel.Visible = false;
        }

        private void ZipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneNumberTextBox.MaxLength = 10;
            errorLabel.Visible = false;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
