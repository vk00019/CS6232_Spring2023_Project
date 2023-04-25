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
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    public partial class TodaysAppointments : Form
    {
        private readonly Appointment _appointment;
        private readonly ManagementController _controller;
        public TodaysAppointments()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _appointment = new Appointment();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void StartVisitButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
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
                    _appointment.ScheduledTime = DateTime.Parse(appointmentsDataGridView.SelectedRows[0].Cells[3].Value.ToString());
                    _appointment.Reason = appointmentsDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    msgLabel.Visible = false;
                }
            }
        }

        private void TodaysAppointments_Load(object sender, EventArgs e)
        {
            List<Appointment> appointments = _controller.GetTodaysAppointments();
            if (appointments.Count > 0)
            {
                appointmentsDataGridView.DataSource = appointments;
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
    }
}
