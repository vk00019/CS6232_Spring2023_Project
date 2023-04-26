using HospitalManagement.View;
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
            routine.SetVisitId(_visit.VisitId);
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
            diagnosis.SetVisitId(_visit.VisitId);
            diagnosis.ShowDialog();
        }
    }
}
