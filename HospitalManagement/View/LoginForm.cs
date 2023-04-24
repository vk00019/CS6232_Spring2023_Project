using HospitalManagement.Controller;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for login form interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            errorLabel.Visible = false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            if (_controller.CheckUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                using var mainForm = new MainDashboard();
                var name = "Name: " + _controller.GetFirstAndLastName(usernameTextBox.Text) +
                           " Username: " + usernameTextBox.Text;
                mainForm.SetUsernameLabel(name);
                this.Hide();
                var value = mainForm.ShowDialog();

                if (value != DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }

                usernameTextBox.Clear();
                passwordTextBox.Clear();

            }
            else
            {
                usernameTextBox.Clear();
                passwordTextBox.Clear();
                errorLabel.Text = "Invalid Username or Password";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
