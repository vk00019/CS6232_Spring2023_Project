using HospitalManagement.Controller;
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
        private ManagementController _controller;
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
        }

        private void routineCheckupButton_Click(object sender, EventArgs e)
        {
            using var routineCheckUp = new RoutineCheckup();
            routineCheckUp.SetFields(_visit);
            routineCheckUp.ShowDialog();
        }

        private void diagnosisButton_Click(object sender, EventArgs e)
        {
            using var diagnosis = new PatientDiagnosis();
            diagnosis.SetVisit(_visit);
            diagnosis.SetTextBoxes(_visit);
            diagnosis.ShowDialog();
        }
    }
}
