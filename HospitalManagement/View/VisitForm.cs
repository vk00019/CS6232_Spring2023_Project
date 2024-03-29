﻿using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for visit form interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class VisitForm : Form
    {
        private Visit _visit;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="VisitForm"/> class.
        /// </summary>
        public VisitForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        public void SetVisit(Visit visit)
        {
            _visit = visit;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            var visit = _controller.GetVisitForEditOrView(_visit.VisitId);

            doctorTextBox.Text = visit.DoctorName;
            nurseTextBox.Text = visit.NurseName;
            patientTextBox.Text = visit.PatientName;
            patientDOBTextBox.Text = visit.PatientDOB.ToShortDateString();
            if (_controller.IsFinalDiagnosisAvailable(_visit.VisitId))
            {
                orderTestsButton.Enabled = false;
            }
            else
            {
                orderTestsButton.Enabled = true;
            }
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            using var routineCheckUp = new RoutineCheckup();
            routineCheckUp.SetVisitId(_visit.VisitId);
            routineCheckUp.SetFields(_visit);
            routineCheckUp.ShowDialog();
        }

        private void diagnosisButton_Click(object sender, EventArgs e)
        {
            using var diagnosis = new PatientDiagnosis();
            diagnosis.SetVisit(_visit);
            diagnosis.SetTextBoxes(_visit);
            var result = diagnosis.ShowDialog();
            if (result == DialogResult.Yes)
            {
                orderTestsButton.Enabled = false;
            }
        }

        private void testResultsButton_Click(object sender, EventArgs e)
        {
            using var testResults = new TestResultsForm();
            testResults.SetVisitId(_visit.VisitId);
            testResults.ShowDialog();
        }

        private void orderTestsButton_Click(object sender, EventArgs e)
        {
            using var orderTests = new OrderTestForm();
            orderTests.SetVisitId(_visit.VisitId);
            orderTests.ShowDialog();
        }
    }
}
