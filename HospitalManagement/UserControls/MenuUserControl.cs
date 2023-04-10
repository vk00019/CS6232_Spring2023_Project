using HospitalManagement.View;

namespace HospitalManagement.UserControls
{
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExitMenuItem_Click(sender, e);
            using var loginForm = new LoginForm();
            loginForm.Show();

            loginForm.DialogResult = DialogResult.OK;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            using var mainDashboard = new MainDashboard();
            //this.Hide();
            mainDashboard.ShowDialog();

        }

        public void SetUsername(string username)
        {
            usernameLabel.Text = username.ToUpper();
        }

        private void RegisterPatientMenuItem_Click(object sender, EventArgs e)
        {
            using var registerPatient = new PatientRegistration();
           // this.Hide();
            registerPatient.ShowDialog();
        }
    }
}
