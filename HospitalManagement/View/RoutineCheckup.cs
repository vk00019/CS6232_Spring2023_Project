using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for routine checkup interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RoutineCheckup : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutineCheckup"/> class.
        /// </summary>
        public RoutineCheckup()
        {
            InitializeComponent();
        }

        private void addDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                errorLabel.Visible = false;
                CheckAllFields();
                if (!errorLabel.Visible)
                {
                    var height = Convert.ToDecimal(heightTextBox.Text);
                    var weight = Convert.ToDecimal(weightTextBox.Text);
                    var sysBp = Convert.ToInt32(sysBPTextBox.Text);
                    var diaBp = Convert.ToInt32(diaBPTextBox.Text);
                    var temperature = Convert.ToInt32(tempTextBox.Text);
                    var pulse = Convert.ToInt32(pulseTextBox.Text);
                    var symptoms = symptomsTextBox.Text;
                    var visit = new Visit
                    {
                        Height = height,
                        Weight = weight,
                        SystolicBp = sysBp,
                        DiastolicBp = diaBp,
                        BodyTemperature = temperature,
                        Pulse = pulse,
                        Symptoms = symptoms
                    };
                    ClearAllFields();
                    errorLabel.Text = @"Checkup details updated successfully";
                    errorLabel.ForeColor = Color.Green;
                    errorLabel.Visible = true;
                }
            }
            catch
            {
                errorLabel.Text = @"Please enter only numbers for all fields expect for symptoms";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void CheckAllFields()
        {
            errorLabel.Text = @"*All fields are required*";
            errorLabel.ForeColor = Color.Red;
            if (string.IsNullOrEmpty(heightTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(weightTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(diaBPTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(sysBPTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(tempTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(pulseTextBox.Text))
            {
                errorLabel.Visible = true;
            }
            if (string.IsNullOrEmpty(symptomsTextBox.Text))
            {
                errorLabel.Visible = true;
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
        }
    }
}
