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
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void DobLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void FnLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = false;
            dobDateTimePicker.Visible = false;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = true;
            firstnametextBox.Visible = true;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            viewButton.Visible = true;
            editButton.Visible = true;
            viewButton.Enabled = false;
            editButton.Enabled = false;
            List<PersonalDetails> patients;
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                patients = _controller.GetPatientWithDob(patientsObject);
                CheckForPatients(patients);
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
                    CheckForPatients(patients);
                }
                else
                {
                    errorLabel.Text = "Please fill Lastname field";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewButton.Visible = false;
                    editButton.Visible = false;
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
                    CheckForPatients(patients);
                }
                else
                {
                    errorLabel.Text = "Please fill both Firstname and Lastname";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewButton.Visible = false;
                    editButton.Visible = false;
                }
            }
        }

        private void CheckForPatients(List<PersonalDetails> patients)
        {
            if (patients.Count > 0)
            {
                searchDataGridView.Visible = true;
                searchDataGridView.DataSource = patients;
                searchDataGridView.ClearSelection();
            }
            else
            {
                searchDataGridView.Visible = false;
                errorLabel.Text = "There are no patients available with details provided." + Environment.NewLine +
                                  "Register them or check the details given again.";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
                viewButton.Visible = false;
                editButton.Visible = false;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.ResetText();
            firstnametextBox.Clear();
            lastnameTextBox.Clear();
            errorLabel.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
        }

        private void SearchDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewButton.Enabled = true;
            editButton.Enabled = true;
        }
    }
}
