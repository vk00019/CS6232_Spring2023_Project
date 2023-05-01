using HospitalManagement.Controller;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for routine checkup interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RoutineCheckup : Form
    {
        private int _visitId;
        private readonly ManagementController _controller;
        private bool _error;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutineCheckup"/> class.
        /// </summary>
        public RoutineCheckup()
        {
            InitializeComponent();
            _controller = new ManagementController();
            EnableAllfields();
            _error = false;
        }

        /// <summary>
        /// Sets the visit identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private void addDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                CheckAllFields();
                if (!errorLabel.Visible && !_error)
                {
                    var height = Convert.ToDecimal(heightTextBox.Text);
                    var weight = Convert.ToDecimal(weightTextBox.Text);
                    var sysBp = Convert.ToInt32(sysBPTextBox.Text);
                    var diaBp = Convert.ToInt32(diaBPTextBox.Text);
                    var temperature = Convert.ToDecimal(tempTextBox.Text);
                    var pulse = Convert.ToInt32(pulseTextBox.Text);
                    var symptoms = symptomsTextBox.Text;
                    var visit = new Visit
                    {
                        VisitId = _visitId,
                        Height = height,
                        Weight = weight,
                        SystolicBp = sysBp,
                        DiastolicBp = diaBp,
                        BodyTemperature = temperature,
                        Pulse = pulse,
                        Symptoms = symptoms
                    };
                    _controller.AddRoutineCheckup(visit);
                    errorLabel.Text = @"Checkup details updated successfully";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                }
            }
            catch (Exception)
            {
                errorLabel.Text = @"Please enter only digits greater than 0";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
            catch
            {
                errorLabel.Text = @"Please enter only numbers for all fields expect for symptoms";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        public void SetFields(Visit visit)
        {

            var newVisit = _controller.GetEverything(visit.VisitId);
            heightTextBox.Text = newVisit.Height.ToString();
            weightTextBox.Text = newVisit.Weight.ToString();
            sysBPTextBox.Text = newVisit.SystolicBp.ToString();
            diaBPTextBox.Text = newVisit.DiastolicBp.ToString();
            tempTextBox.Text = newVisit.BodyTemperature.ToString();
            pulseTextBox.Text = newVisit.Pulse.ToString();
            symptomsTextBox.Text = newVisit.Symptoms.ToString();
            if (_controller.IsFinalDiagnosisAvailable(visit.VisitId))
            {
                DisableAllFields();
            }

            if (heightTextBox.Text.Equals("-1") || weightTextBox.Text.Equals("-1") || sysBPTextBox.Text.Equals("-1") ||
            diaBPTextBox.Text.Equals("-1") || tempTextBox.Text.Equals("-1") || pulseTextBox.Text.Equals("-1"))
            {
                ClearAllFields();
            }

        }

        private void DisableAllFields()
        {
            heightTextBox.ReadOnly = true;
            weightTextBox.ReadOnly = true;
            sysBPTextBox.ReadOnly = true;
            diaBPTextBox.ReadOnly = true;
            tempTextBox.ReadOnly = true;
            pulseTextBox.ReadOnly = true;
            symptomsTextBox.ReadOnly = true;
            addDetailsButton.Enabled = false;
        }

        private void EnableAllfields()
        {
            heightTextBox.ReadOnly = false;
            weightTextBox.ReadOnly = false;
            sysBPTextBox.ReadOnly = false;
            diaBPTextBox.ReadOnly = false;
            tempTextBox.ReadOnly = false;
            pulseTextBox.ReadOnly = false;
            symptomsTextBox.ReadOnly = false;
            addDetailsButton.Enabled = true;
        }

        private void CheckAllFields()
        {
            errorLabel.Text = @"*All fields are required*";
            errorLabel.ForeColor = Color.Red;
            if (string.IsNullOrEmpty(heightTextBox.Text))
            {
                heightErrorLabel.Visible = true;
                heightErrorLabel.Text = "Please enter Height";
                heightErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(weightTextBox.Text))
            {
                weightErrorLabel.Visible = true;
                weightErrorLabel.Text = "Please enter Weight";
                weightErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(diaBPTextBox.Text))
            {
                diastolicErrorLabel.Visible = true;
                diastolicErrorLabel.Text = "Please enter Diastolic BP";
                diastolicErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(sysBPTextBox.Text))
            {
                systolicErrorLabel.Visible = true;
                systolicErrorLabel.Text = "Please enter Systolic BP";
                systolicErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(tempTextBox.Text))
            {
                temperatureErrorLabel.Visible = true;
                temperatureErrorLabel.Text = "Please enter Temperature";
                temperatureErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(pulseTextBox.Text))
            {
                pulseErrorLabel.Visible = true;
                pulseErrorLabel.Text = "Please enter Pulse";
                pulseErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
            if (string.IsNullOrEmpty(symptomsTextBox.Text))
            {
                symptomsErrorLabel.Visible = true;
                symptomsErrorLabel.Text = "Please enter Symptoms";
                symptomsErrorLabel.ForeColor = Color.Red;
                _error = true;
            }
        }

        private void ClearAllFields()
        {
            heightTextBox.Clear();
            weightTextBox.Clear();
            sysBPTextBox.Clear();
            diaBPTextBox.Clear();
            tempTextBox.Clear();
            pulseTextBox.Clear();
            symptomsTextBox.Clear();
            errorLabel.Visible = false;
            heightErrorLabel.Visible = false;
            weightErrorLabel.Visible = false;
            diastolicErrorLabel.Visible = false;
            systolicErrorLabel.Visible = false;
            temperatureErrorLabel.Visible = false;
            symptomsErrorLabel.Visible = false;
            pulseErrorLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
