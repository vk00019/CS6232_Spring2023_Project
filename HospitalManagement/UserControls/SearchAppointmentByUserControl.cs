using HospitalManagement.Controller;
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
        private Appointment _appointment;
        private ManagementController _controller;
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
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            viewEditButton.Visible = true;
            viewEditButton.Enabled = false;
            List<Appointment> appointments;
            if (dobRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value
                };
                appointments = _controller.GetAppointmentWithDob(patientsObject);
                searchDataGridView.DataSource = appointments;
                searchDataGridView.Visible = true;
                searchDataGridView.ClearSelection();
            }
            else if (dobLnRadioButton.Checked)
            {
                var patientsObject = new PersonalDetails
                {
                    DateOfBirth = dobDateTimePicker.Value,
                    LastName = lastnameTextBox.Text
                };
                appointments = _controller.GetAppointmentWithDobAndLastname(patientsObject);
                searchDataGridView.DataSource = appointments;
                searchDataGridView.Visible = true;
                searchDataGridView.ClearSelection();

            }
            else
            {
                var patientsObject = new PersonalDetails
                {
                    FirstName = firstnametextBox.Text,
                    LastName = lastnameTextBox.Text
                };
                appointments = _controller.GetAppointmentWithFirstNameAndLastName(patientsObject);
                searchDataGridView.DataSource = appointments;
                searchDataGridView.Visible = true;
                searchDataGridView.ClearSelection();
            }
        }

        private void searchDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                viewEditButton.Enabled = false;
            }
            else
            {
                viewEditButton.Visible = true;
                viewEditButton.Enabled = true;
                if (searchDataGridView.SelectedRows[0] != null)
                {
                    _appointment.AppointmentId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    _appointment.PatientId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    _appointment.DoctorId = Int32.Parse(searchDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                    _appointment.ScheduledTime = DateTime.Parse(searchDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    _appointment.Reason = searchDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }

        private void ViewEditButton_Click(object sender, EventArgs e)
        {
            using var viewform = new ViewAppointmentForm();
            viewform.SetAppointment(_appointment);
            viewform.ShowDialog();
            searchDataGridView.Visible = false;
        }
    }
}
