using HospitalManagement.UserControls;

namespace HospitalManagement.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            this.Close();
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

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}