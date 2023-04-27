using HospitalManagement.Model;
using HospitalManagement.Controller;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for edit patient interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditPatientForm : Form
    {
        private PersonalDetails _patient;
        private List<string> _gender;
        private readonly ManagementController _controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPatientForm"/> class.
        /// </summary>
        public EditPatientForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _gender = new List<string>();
        }
        /// <summary>
        /// Sets the patient details.
        /// </summary>
        /// <param name="patientDetails">The patient details.</param>
        public void SetPatientDetails(PersonalDetails patientDetails)
        {
            _patient = patientDetails;
        }

        private void AddGender()
        {
            _gender.Add("Male");
            _gender.Add("Female");
            _gender.Add("Not Specified");
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            birthDayDateTimePicker.MaxDate = DateTime.Now;
            _gender = new List<string>();
            AddGender();
            genderComboBox.DataSource = _gender.ToArray();
            statesComboBox.DataSource = _controller.GetStates();

            firstNameTextBox.Text = _patient.FirstName;
            lastNameTextBox.Text = _patient.LastName;
            birthDayDateTimePicker.Value = _patient.DateOfBirth;
            phoneNumberTextBox.Text = _patient.PhoneNumber;
            genderComboBox.SelectedItem = _patient.Gender;
            streetAddressTextBox.Text = _patient.Street;
            cityTextBox.Text = _patient.City;
            statesComboBox.SelectedItem = _patient.State;
            countryTextBox.Text = _patient.Country;
            zipCodeTextBox.Text = _patient.ZipCode;

            errorLabel.Visible = false;
            editPatientButton.Enabled = false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            zipCodeTextBox.MaxLength = 5;
            phoneNumberTextBox.MaxLength = 10;
            editPatientButton.Enabled = true;
        }

        private void EditPatientButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            CheckAllFields();
            if (errorLabel.Visible)
            {
                errorLabel.Text = "*All fields are required to edit the details*";
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                errorLabel.Visible = false;
                var personalDetails = new PersonalDetails
                {
                    PdID = _patient.PdID,
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
                _controller.UpdatePatientDetails(personalDetails);
                errorLabel.Text = "Patient Updated Successfully";
                errorLabel.ForeColor = Color.Green;
                errorLabel.Visible = true;
                editPatientButton.Enabled = false;
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
            if (zipCodeTextBox.Text.Length != 5)
            {
                errorLabel.Visible = true;
            }
            if (phoneNumberTextBox.Text.Length != 10)
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(countryTextBox.Text))
            {
                errorLabel.Visible = true;
            }
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ZipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
