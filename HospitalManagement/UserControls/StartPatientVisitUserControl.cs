using HospitalManagement.View;
using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.UserControls
{
    public partial class StartPatientVisitUserControl : UserControl
    {
        private readonly ManagementController _controller;
        private Visit _visit;

        /// <summary>
        /// Initializes a new instance of the <see cref="StartPatientVisitUserControl"/> class.
        /// </summary>
        public StartPatientVisitUserControl()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            using var routine = new RoutineCheckup();
            routine.SetVisitId(_visit.VisitId);
            routine.SetFields(_visit);
            routine.ShowDialog();
        }

        private void StartPatientVisitUserControl_Load(object sender, EventArgs e)
        {
            _visit = _controller.GetLatestVisit();
            doctorTextBox.Text = _visit.DoctorName;
            patientTextBox.Text = _visit.PatientName;
        }

        private void orderTestsButton_Click(object sender, EventArgs e)
        {
            using var orderTests = new OrderTestForm();
            orderTests.SetVisitId(_visit.VisitId);
            orderTests.ShowDialog();
        }

        private void testResultsButton_Click(object sender, EventArgs e)
        {
            using var testResults = new TestResultsForm();
            testResults.SetVisitId(_visit.VisitId);
            testResults.ShowDialog();
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
    }
}
