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
        private int _visitId;
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

        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var initial = initialDiagnosisRichTextBox.Text;
            var final = finalDiagnosisRichTextBox.Text;
            var visit = new Visit
            {
                VisitId = _visitId,
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