﻿using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    public partial class ViewPatientForm : Form
    {
        private PersonalDetails _patient;
        private readonly ManagementController _controller;
        public ViewPatientForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        public void SetPatientDetails(PersonalDetails patientDetails)
        {
            _patient = patientDetails;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ViewPatientForm_Load(object sender, EventArgs e)
        {
            patientNameLabel.Text = "Patient's Name: " + _patient.FirstName + " " + _patient.LastName;
            patientIdLabel.Text = "Id: " + _patient.PdID;
            dobLabel.Text = "Dob: " + _patient.DateOfBirth.ToShortDateString();
            List<Appointment> patientAppointments = _controller.GetPatientAppointments(_patient.PdID);
            if (patientAppointments.Count > 0)
            {
                appointmentsDataGridView.DataSource = patientAppointments;
                appointmentsDataGridView.ClearSelection();
            }
            else
            {
                nameLabel.Text += Environment.NewLine + "This patient doesnot have any appointments or visits." +
                                  Environment.NewLine + " Start an appointment by going to Appointments tab.";
                nameLabel.ForeColor = Color.Red;
                appointmentsDataGridView.Visible = false;
                visitDataGridView.Visible = false;
                visitsLabel.Visible = false;
            }

        }

        private void AppointmentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Visit> patientVisits = new List<Visit>();
            int appointmentId;
            if (e.RowIndex != -1)
            {
                appointmentId = Int32.Parse(appointmentsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                patientVisits = _controller.GetPatientVisits(appointmentId);
                if (patientVisits.Count > 0)
                {
                    visitDataGridView.DataSource = patientVisits;
                    visitDataGridView.ClearSelection();
                }
                else
                {
                    visitsLabel.Text += Environment.NewLine + "There are no visits available for this appointment." +
                                        Environment.NewLine + "Start a visit for this by going to the visit tab";
                    visitDataGridView.Visible = false;
                    visitsLabel.ForeColor = Color.Red;
                }
            }
            else
            {
                return;
            }
        }
    }
}
