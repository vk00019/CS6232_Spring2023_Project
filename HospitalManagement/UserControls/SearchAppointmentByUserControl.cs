﻿using HospitalManagement.Controller;
using HospitalManagement.Model;
using HospitalManagement.View;

namespace HospitalManagement.UserControls
{
    /// <summary>
    /// This class is used for search appointment interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchAppointmentByUserControl : UserControl
    {
        private readonly Appointment _appointment;
        private readonly ManagementController _controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAppointmentByUserControl"/> class.
        /// </summary>
        public SearchAppointmentByUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _appointment = new Appointment();
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
            viewEditButton.Visible = false;
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
            viewEditButton.Visible = false;
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
            viewEditButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            viewEditButton.Enabled = false;
            deleteButton.Enabled = false;
            List<Appointment> appointments;
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                appointments = _controller.GetAppointmentWithDob(patientsObject);
                CheckForAppointments(appointments);
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
                    appointments = _controller.GetAppointmentWithDobAndLastname(patientsObject);
                    CheckForAppointments(appointments);
                }
                else
                {
                    errorLabel.Text = "Please fill the Lastname";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewEditButton.Visible = false;
                    deleteButton.Visible = false;
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
                    appointments = _controller.GetAppointmentWithFirstNameAndLastName(patientsObject);
                    CheckForAppointments(appointments);
                }
                else
                {
                    errorLabel.Text = "Please fill both Firstname and Lastname";
                    errorLabel.Visible = true;
                    errorLabel.ForeColor = Color.Red;
                    viewEditButton.Visible = false;
                    deleteButton.Visible = false;
                }
            }
        }

        private void CheckForAppointments(List<Appointment> appointments)
        {
            if (appointments.Count > 0)
            {
                searchDataGridView.Visible = true;
                RefreshDataGridView(appointments);
                searchDataGridView.ClearSelection();
                viewEditButton.Visible = true;
                deleteButton.Visible = true;
            }
            else
            {
                searchDataGridView.Visible = false;
                errorLabel.Text = "There are no appointments available with details provided." + Environment.NewLine +
                                  "Book an appointment or check the details given again.";
                errorLabel.Visible = true;
                errorLabel.ForeColor = Color.Red;
                viewEditButton.Visible = false;
                deleteButton.Visible = false;
            }
        }

        public void RefreshDataGridView(List<Appointment> appointments)
        {
            searchDataGridView.Rows.Clear();

            foreach (Appointment currentIncident in appointments)
            {
                if (currentIncident != null)
                {
                    DataGridViewRow currentRow = searchDataGridView.Rows[searchDataGridView.Rows.Add()];
                    currentRow.Cells[appointmentID.Index].Value = currentIncident.AppointmentId;
                    searchDataGridView.Columns["appointmentID"].Visible = false;
                    currentRow.Cells[patientID.Index].Value = currentIncident.PatientId;
                    currentRow.Cells[doctorID.Index].Value = currentIncident.DoctorId;
                    searchDataGridView.Columns["doctorID"].Visible = false;
                    currentRow.Cells[doctorName.Index].Value = currentIncident.Name;
                    currentRow.Cells[scheduledDate.Index].Value = currentIncident.ScheduledTime;
                    currentRow.Cells[reason.Index].Value = currentIncident.Reason;
                }
            }
        }

        private void SearchDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                viewEditButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else
            {
                viewEditButton.Visible = true;
                viewEditButton.Enabled = true;
                deleteButton.Enabled = true;
                if (searchDataGridView.SelectedRows[0] != null)
                {
                    _appointment.AppointmentId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    _appointment.PatientId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    _appointment.DoctorId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                    _appointment.Name = searchDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    _appointment.ScheduledTime = DateTime.Parse(searchDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                    _appointment.Reason = searchDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    errorLabel.Visible = false;
                }
            }
        }

        private void ViewEditButton_Click(object sender, EventArgs e)
        {
            using var viewForm = new ViewAppointmentForm();
            viewForm.SetAppointment(_appointment);
            viewForm.ShowDialog();
            SearchButton_Click(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.ResetText();
            firstnametextBox.Clear();
            lastnameTextBox.Clear();
            errorLabel.Visible = false;
            searchDataGridView.Visible = false;
            viewEditButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!_controller.CheckVisit(_appointment.AppointmentId))
            {
                string message = "Are you sure to delete this appointment?";
                string caption = "Delete Appointment!!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _controller.DeleteAppointment(_appointment.AppointmentId);
                    errorLabel.Text = "Appointment is deleted";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                    SearchButton_Click(sender, e);
                }
                else
                {
                    errorLabel.Text = "Appointment can not be deleted as the operation is cancelled or not confirmed";
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Visible = true;
                }
            }
            else
            {
                errorLabel.Text = "Appointment can not be deleted as there is a visit associated with it";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void lastnameTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void firstnametextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void SearchAppointmentByUserControl_Load(object sender, EventArgs e)
        {
            dobDateTimePicker.MaxDate = DateTime.Now;
            dobDateTimePicker.Value = DateTime.Now.Date;
        }
    }
}
