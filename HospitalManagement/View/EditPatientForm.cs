using HospitalManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Controller;

namespace HospitalManagement.View
{
    public partial class EditPatientForm : Form
    {
        private PersonalDetails _patient;
        private List<string> _gender;
        private readonly ManagementController _controller;
        public EditPatientForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _gender = new List<string>();
        }

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
            editPatientButton.Enabled = true;
        }
    }
}
