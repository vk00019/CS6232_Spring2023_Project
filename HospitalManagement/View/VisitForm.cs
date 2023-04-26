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

        public void SetVisit(Visit visitID)
        {
            _visit = visitID;
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
    }
}
