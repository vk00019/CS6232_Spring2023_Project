using HospitalManagement.UserControls;

namespace HospitalManagement.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        public void SetUsernameLabel(string username)
        {
            usernameLabel.Text = username;
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
    }
}