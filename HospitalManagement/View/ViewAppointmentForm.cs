using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for view appointment interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ViewAppointmentForm : Form
    {
        private readonly ManagementController _controller;
        private Appointment _apointment;
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewAppointmentForm"/> class.
        /// </summary>
        public ViewAppointmentForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void ViewAppointmentForm_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        /// <summary>
        /// Sets the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        public void SetAppointment(Appointment appointment)
        {
            this._apointment = appointment;
        }

        private void SetupForm()
        {
            doctorComboBox.DataSource = _controller.GetDoctors();
            doctorComboBox.ValueMember = "doctorID";
            doctorComboBox.DisplayMember = "Name";
            doctorComboBox.SelectedValue = _apointment.DoctorId;
            patientTextBox.Text = _apointment.PatientId.ToString();
            patientTextBox.ReadOnly = true;
            reasonTextBox.Text = _apointment.Reason;
            timePicker.Value = _apointment.ScheduledTime;
            datePicker.Value = _apointment.ScheduledTime;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
               timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
                errorLabel.Visible = false;
                var doctor = doctorComboBox.SelectedItem as Doctor;
                var id = doctor.doctorID;
                var patientId = _apointment.PatientId;
                CheckAllFields();
                if (!_controller.ValidatePatient(patientId))
                {
                    errorLabel.Text = "There is no patient with this ID";
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Visible = true;
                }
                else if (errorLabel.Visible)
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
                        AppointmentId = _apointment.AppointmentId,
                        PatientId = patientId,
                        DoctorId = id,
                        Reason = reasonTextBox.Text,
                        ScheduledTime = appointmentTime
                    };
                    _controller.UpdateAppointment(appointment);
                    errorLabel.Text = "Appointment updated Successfully";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                }
            }
            catch
            {
                errorLabel.Text = "Please enter only numbers for patient id";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private bool DateChanged()
        {
            if (_apointment.ScheduledTime.Year == datePicker.Value.Year &&
                _apointment.ScheduledTime.Month == datePicker.Value.Month &&
                _apointment.ScheduledTime.Day == datePicker.Value.Day &&
                _apointment.ScheduledTime.Hour == timePicker.Value.Hour &&
                _apointment.ScheduledTime.Minute == timePicker.Value.Minute)
            {
                return false;
            }
            return true;
        }

        private bool HoursCheck()
        {
            if (_apointment.ScheduledTime.Subtract(DateTime.Now).TotalHours <= 24)
            {
                return false;
            }
            return true;
        }

        private bool DoctorOpen(int id)
        {
            var appointment = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);

            if (!DateChanged())
            {
                return true;
            }
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

        private void patientTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void reasonTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
