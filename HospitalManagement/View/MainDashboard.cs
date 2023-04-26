using HospitalManagement.model;
using HospitalManagement.UserControls;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for main dashboard interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        private Nurse _nurse;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            _nurse = new Nurse();
        }

        /// <summary>
        /// Sets the username label.
        /// </summary>
        /// <param name="username">The username.</param>
        public void SetUsernameLabel(string username)
        {
            usernameLabel.Text = username;
        }

        public void SetNurse(Nurse nurse)
        {
            _nurse = nurse;
        }

        private void RegisterPatientButton_Click(object sender, EventArgs e)
        {
            registerPatientUserControl.Visible = true;
            searchPatientByUserControl.Visible = false;
        }

        private void SearchPatientButton_Click(object sender, EventArgs e)
        {
            registerPatientUserControl.Visible = false;
            searchPatientByUserControl.Visible = true;
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BookAppointmentButton_Click(object sender, EventArgs e)
        {
            bookAppointmentUserControl.Visible = true;
            searchAppointmentByUserControl.Visible = false;
        }

        private void SearchAppointmentButton_Click(object sender, EventArgs e)
        {
            bookAppointmentUserControl.Visible = false;
            searchAppointmentByUserControl.Visible = true;
        }

        private void StartPatientVisitButton_Click(object sender, EventArgs e)
        {
            var startForm = new TodaysAppointments();
            startForm.SetNurse(_nurse);
            startForm.ShowDialog();
            if (startForm.DialogResult == DialogResult.OK)
            {
                searchPatientVisitByUserControl.Visible = false;
                startPatientVisitUserControl.Visible = true;
                startPatientVisitUserControl.Controls["nurseTextBox"].Text = _nurse.FirstName + " " + _nurse.LastName;
            }
            else
            {
                startPatientVisitUserControl.Visible = false;
                searchPatientVisitByUserControl.Visible = false;
            }
        }

        private void SearchVisitButton_Click(object sender, EventArgs e)
        {
            startPatientVisitUserControl.Visible = false;
            searchPatientVisitByUserControl.Visible = true;
        }
    }
}