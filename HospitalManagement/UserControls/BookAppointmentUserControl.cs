using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.UserControls
{
    public partial class BookAppointmentUserControl : UserControl
    {
        private readonly ManagementController _controller;
        public BookAppointmentUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            var appointmentTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
               timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            errorLabel.Visible = false;
            var doctor = doctorComboBox.SelectedItem as Doctor;
            var id = doctor.doctorID;
            CheckAllFields();
            if (errorLabel.Visible)
            {
                errorLabel.Text = "*All fields are required to register*";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
            else if (!DoctorOpen(id))
            {
                errorLabel.Text = "Doctor is not available for the selected time";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                var appointment = new Appointment
                {
                    PatientId = Convert.ToInt32(patientTextBox.Text),
                    DoctorId = id,
                    Reason = reasonTextBox.Text,
                    ScheduledTime = appointmentTime
                };
                _controller.BookAppointment(appointment);
                ClearAllFields();
                errorLabel.Text = "Appointment booked Successfully";
                errorLabel.ForeColor = Color.Green;
                errorLabel.Visible = true;
            }

        }

        private bool DoctorOpen(int id)
        {
            var appointment = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            foreach (DateTime time in _controller.GetDoctorAppointmentTimes(id))
            {
                var diff = appointment.Subtract(time).TotalMinutes;
                if (diff > -15 && diff < 15)
                {
                    return false;
                }
            }
            return true;
        }

        private void CheckAllFields()
        {
            if (string.IsNullOrEmpty(patientTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(reasonTextBox.Text))
            {
                errorLabel.Visible = true;
            }
        }

        private void ClearAllFields()
        {
            patientTextBox.Clear();
            reasonTextBox.Clear();
            doctorComboBox.SelectedIndex = 0;
            datePicker.ResetText();
            timePicker.ResetText();
            errorLabel.Visible = false;
        }

        private void BookAppointmentUserControl_Load(object sender, EventArgs e)
        {
            doctorComboBox.DataSource = _controller.GetDoctors();
            doctorComboBox.ValueMember = "pdID";
            doctorComboBox.DisplayMember = "Name";
            datePicker.MinDate = DateTime.Now;
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void patientTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void reasonTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
