using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.UserControls
{
    public partial class SearchPatientByUserControl : UserControl
    {
        private readonly ManagementController _controller;
        public SearchPatientByUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void DobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = false;
            lastnameTextBox.Visible = false;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
        }

        private void DobLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
        }

        private void FnLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = false;
            dobDateTimePicker.Visible = false;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = true;
            firstnametextBox.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            List<PersonalDetails> patients = new List<PersonalDetails>();
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                patients = _controller.GetPatientWithDob(patientsObject);
                searchDataGridView.Visible = true;
                searchDataGridView.DataSource = patients;
                searchDataGridView.ClearSelection();
            }
            else if (dobLnRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(lastnameTextBox.Text))
                {
                    var patientsObject = new PersonalDetails
                    {
                        DateOfBirth = dobDateTimePicker.Value,
                        LastName = lastnameTextBox.Text
                    };
                    patients = _controller.GetPatientWithDobAndLastname(patientsObject);
                    searchDataGridView.Visible = true;
                    searchDataGridView.DataSource = patients;
                    searchDataGridView.ClearSelection();
                }
                else
                {
                    errorLabel.Text = "Please fill Lastname field";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                }

            }
            else
            {
                if (!(string.IsNullOrEmpty(firstnametextBox.Text) || string.IsNullOrEmpty(lastnameTextBox.Text)))
                {
                    var patientsObject = new PersonalDetails
                    {
                        FirstName = firstnametextBox.Text,
                        LastName = lastnameTextBox.Text
                    };
                    patients = _controller.GetPatientWithFirstnameAndLastname(patientsObject);
                    searchDataGridView.Visible = true;
                    searchDataGridView.DataSource = patients;
                    searchDataGridView.ClearSelection();
                }
                else
                {
                    errorLabel.Text = "Please fill both Firstname and Lastname";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                }

            }
        }

        private void SearchPatientByUserControl_Load(object sender, EventArgs e)
        {
            searchDataGridView.ClearSelection();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.ResetText();
            firstnametextBox.Clear();
            lastnameTextBox.Clear();
            errorLabel.Visible = false;
        }
    }
}
