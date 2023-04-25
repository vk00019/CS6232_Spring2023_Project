using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    public partial class TodaysAppointments : Form
    {
        private Nurse _nurse;
        private readonly Appointment _appointment;
        private readonly ManagementController _controller;
        public TodaysAppointments()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _appointment = new Appointment();
        }

        public void SetNurse(Nurse nurse)
        {
            _nurse = nurse;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void StartVisitButton_Click(object sender, EventArgs e)
        {
            if (_controller.CheckVisit(_appointment.AppointmentId))
            {
                msgLabel.Text = "Visit has already been started for this patient's appointment." + Environment.NewLine +
                                "Please search for visit to edit the details.";
                msgLabel.Visible = true;
            }
            else
            {
                var visit = new Visit
                {
                    AppointmentId = _appointment.AppointmentId,
                    NurseId = _nurse.NurseId
                };
                _controller.StartVisit(visit);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AppointmentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                startVisitButton.Enabled = false;
                msgLabel.Text = "Please select an appointment to start the visit";
                msgLabel.Visible = true;
            }
            else
            {
                msgLabel.Visible = false;
                startVisitButton.Enabled = true;
                if (appointmentsDataGridView.SelectedRows[0] != null)
                {
                    _appointment.AppointmentId = Int32.Parse(appointmentsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    _appointment.PatientId = Int32.Parse(appointmentsDataGridView.SelectedRows[0].Cells[1].Value.ToString());
                    _appointment.DoctorId = Int32.Parse(appointmentsDataGridView.SelectedRows[0].Cells[2].Value.ToString());
                    _appointment.Name = appointmentsDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    _appointment.ScheduledTime = DateTime.Parse(appointmentsDataGridView.SelectedRows[0].Cells[4].Value.ToString());
                    _appointment.Reason = appointmentsDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    msgLabel.Visible = false;
                }
            }
        }

        private void TodaysAppointments_Load(object sender, EventArgs e)
        {
            List<Appointment> appointments = _controller.GetTodaysAppointments();
            if (appointments.Count > 0)
            {
                RefreshDataGridView(appointments);
                appointmentsDataGridView.ClearSelection();
                msgLabel.Text = "Please select an appointment to start the visit for patient";
                msgLabel.Visible = true;
            }
            else
            {
                appointmentsDataGridView.Visible = false;
                msgLabel.Text = "It seems there are no appointments available today with any patients.";
                msgLabel.Visible = true;
            }

        }

        public void RefreshDataGridView(List<Appointment> appointments)
        {
            appointmentsDataGridView.Rows.Clear();

            foreach (Appointment currentIncident in appointments)
            {
                DataGridViewRow currentRow = appointmentsDataGridView.Rows[appointmentsDataGridView.Rows.Add()];
                currentRow.Cells[appointmentID.Index].Value = currentIncident.AppointmentId;
                appointmentsDataGridView.Columns["appointmentID"].Visible = false;
                currentRow.Cells[patientID.Index].Value = currentIncident.PatientId;
                currentRow.Cells[doctorID.Index].Value = currentIncident.DoctorId;
                appointmentsDataGridView.Columns["doctorID"].Visible = false;
                currentRow.Cells[doctorName.Index].Value = currentIncident.Name;
                currentRow.Cells[ScheduledDate.Index].Value = currentIncident.ScheduledTime;
                currentRow.Cells[reason.Index].Value = currentIncident.Reason;
            }
            appointmentsDataGridView.ClearSelection();
        }
    }
}
