using HospitalManagement.View;
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

namespace HospitalManagement.UserControls
{
    public partial class StartPatientVisitUserControl : UserControl
    {
        private readonly ManagementController _controller;
        private Visit _visit;
        public StartPatientVisitUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            using var routine = new RoutineCheckup();
            routine.ShowDialog();
        }

        private void StartPatientVisitUserControl_Load(object sender, EventArgs e)
        {
            _visit = _controller.GetLatestVisit();
            doctorTextBox.Text = _visit.DoctorName;
            patientTextBox.Text = _visit.PatientName;
        }
    }
}
