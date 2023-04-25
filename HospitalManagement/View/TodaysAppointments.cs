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
        private readonly ManagementController _controller;
        public TodaysAppointments()
        {
            InitializeComponent();
            _controller = new ManagementController();
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
            }
        }

        private void TodaysAppointments_Load(object sender, EventArgs e)
        {
            List<Appointment> appointments = _controller.GetTodaysAppointments();
            appointmentsDataGridView.DataSource = appointments;
            appointmentsDataGridView.ClearSelection();
            msgLabel.Text = "Please select an appointment to start the visit for patient";
            msgLabel.Visible = true;
        }
    }
}
