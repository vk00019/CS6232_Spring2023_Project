using HospitalManagement.Controller;
using HospitalManagement.Model;
using HospitalManagement.View;

namespace HospitalManagement.UserControls
{
    /// <summary>
    /// This class is used for search patient interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchPatientByUserControl : UserControl
    {
        private readonly ManagementController _controller;
        private readonly PersonalDetails _patientDetails;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPatientByUserControl"/> class.
        /// </summary>
        public SearchPatientByUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _patientDetails = new PersonalDetails();
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
            deletePatientButton.Visible = false;
            bookAppointmentButton.Visible = false;
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
            deletePatientButton.Visible = false;
            bookAppointmentButton.Visible = false;
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
            deletePatientButton.Visible = false;
            bookAppointmentButton.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            viewButton.Visible = true;
            editButton.Visible = true;
            deletePatientButton.Visible = true;
            bookAppointmentButton.Visible = true;
            viewButton.Enabled = false;
            editButton.Enabled = false;
            deletePatientButton.Enabled = false;
            bookAppointmentButton.Enabled = false;
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
                    deletePatientButton.Visible = false;
                    bookAppointmentButton.Visible = false;
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
                    deletePatientButton.Visible = false;
                    bookAppointmentButton.Visible = false;
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
                deletePatientButton.Visible = false;
                bookAppointmentButton.Visible = false;
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
            deletePatientButton.Visible = false;
            bookAppointmentButton.Visible = false;
        }

        private void SearchDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                viewButton.Enabled = false;
                editButton.Enabled = false;
                bookAppointmentButton.Enabled = false;
                deletePatientButton.Enabled = false;
            }
            else
            {
                viewButton.Enabled = true;
                editButton.Enabled = true;
                bookAppointmentButton.Enabled = true;
                deletePatientButton.Enabled = true;
                if (searchDataGridView.SelectedRows[0] != null)
                {
                    int personalDetailsId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    _patientDetails.PdID = _controller.GetPatientId(personalDetailsId);
                    _patientDetails.FirstName = searchDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    _patientDetails.LastName = searchDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    _patientDetails.DateOfBirth = DateTime.Parse(searchDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    _patientDetails.PhoneNumber = searchDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    _patientDetails.Gender = searchDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    _patientDetails.Street = searchDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    _patientDetails.City = searchDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                    _patientDetails.State = searchDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    _patientDetails.Country = searchDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    _patientDetails.ZipCode = searchDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                }
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            using var viewForm = new ViewPatientForm();
            viewForm.SetPatientDetails(_patientDetails);
            viewForm.ShowDialog();
            if (viewForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using var editForm = new EditPatientForm();
            editForm.SetPatientDetails(_patientDetails);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            deletePatientButton.Visible = false;
            bookAppointmentButton.Visible = false;
        }

        private void SearchPatientByUserControl_Load(object sender, EventArgs e)
        {
            dobDateTimePicker.MaxDate = DateTime.Now;
            dobDateTimePicker.Value = DateTime.Now.Date;
        }

        private void DeletePatientButton_Click(object sender, EventArgs e)
        {
            int pdId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            if (!_controller.CheckAppointment(pdId))
            {
                string message =
                    "Are you sure to delete this patient?";
                string caption = "Delete Patient!!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    _controller.DeletePatient(pdId);
                    errorLabel.Text = "Patient is deleted";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                    SearchButton_Click(sender, e);
                }
                else
                {
                    errorLabel.Text = "Patient can not be deleted as the operation is not confirmed.";
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Visible = true;
                }
            }
            else
            {
                errorLabel.Text = "Patient can not be deleted as there is an Appointment associated with them.";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void BookAppointmentButton_Click(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)this.Parent.Parent;
            tabControl.SelectedTab = tabControl.TabPages["appointmentTab"];
            UserControl bookAppointmentUserControl = (UserControl)tabControl.TabPages["appointmentTab"].Controls["bookAppointmentUserControl"];
            tabControl.TabPages["appointmentTab"].Controls["searchAppointmentByUserControl"].Visible = false;
            bookAppointmentUserControl.Visible = true;
            bookAppointmentUserControl.Controls["patientTextBox"].Text = _patientDetails.PdID.ToString();
        }

    }
}
