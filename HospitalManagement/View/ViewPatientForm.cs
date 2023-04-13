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
    public partial class ViewPatientForm : Form
    {
        private PersonalDetails _patient;
        private ManagementController _controller;
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
            appointmentsDataGridView.DataSource = _controller.GetPatientAppointments(_patient.PdID);
            appointmentsDataGridView.ClearSelection();
        }

        private void AppointmentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int appointmentId;
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                appointmentId = Int32.Parse(appointmentsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                visitDataGridView.DataSource = _controller.GetPatientVisits(appointmentId);
            }
        }
    }
}
