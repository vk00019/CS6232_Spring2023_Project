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
            
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetUsername(string username)
        {
            usernameLabel.Text = username.ToUpper();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            //using MainDashboard dashboard = new MainDashboard();
            //dashboard.TopLevel = true;
            //dashboard.Show();
            
            Form openForm = Application.OpenForms["MainDashboard"];
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                using var open = new MainDashboard();
                open.Show();
            }
        }

        private void RegisterPatientMenuItem_Click(object sender, EventArgs e)
        {
            //using PatientRegistration register = new PatientRegistration();
            //register.TopLevel = false;
            //register.Show();

            Form openForm = Application.OpenForms["PatientRegistration"];
            if (openForm != null)
            {
                openForm.Focus();
            }
            else
            {
                using var register = new PatientRegistration();
                register.Show();
            }
            
        }
    }
}
