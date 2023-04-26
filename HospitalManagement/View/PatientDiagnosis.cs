using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for patient diagnosis interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class PatientDiagnosis : Form
    {
        private bool _initial;
        private bool _final;
        private Visit _visit;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientDiagnosis"/> class.
        /// </summary>
        public PatientDiagnosis()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _final = false;
            _initial = false;
        }

        public void SetVisit(Visit visit)
        {
            _visit = visit;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var initial = initialDiagnosisRichTextBox.Text;
            var final = finalDiagnosisRichTextBox.Text;
            var visit = new Visit
            {
                VisitId = _visit.VisitId,
                InitialDiagnosis = initial,
                FinalDiagnosis = final
            };

            if (_final && _initial)
            {
                _controller.UpdateDiagnosis(visit);
            }
            else if (_initial)
            {
                _controller.UpdateInitialDiagnosis(visit);
            }
            else if (_final)
            {
                _controller.UpdateFinalDiagnosis(visit);
            }
        }

        public void SetTextBoxes(Visit visit)
        {
            initialDiagnosisRichTextBox.Text = visit.InitialDiagnosis;
            finalDiagnosisRichTextBox.Text = visit.FinalDiagnosis;
            if (_controller.IsFinalDiagnosisAvailable(visit.VisitId))
            {
                DisableAllFields();
            }
        }

        private void DisableAllFields()
        {
            initialDiagnosisRichTextBox.ReadOnly = true;
            finalDiagnosisRichTextBox.ReadOnly = true;
            addButton.Enabled = false;
        }

        private void initialDiagnosisRichTextBox_TextChanged(object sender, EventArgs e)
        {
            _initial = true;
            addButton.Enabled = true;
        }

        private void finalDiagnosisRichTextBox_TextChanged(object sender, EventArgs e)
        {
            _final = true;
            addButton.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}