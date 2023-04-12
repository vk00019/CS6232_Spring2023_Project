using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.Controller;
using HospitalManagement.UserControls;

namespace HospitalManagement.View
{
    public partial class LoginForm : Form
    {
        private ManagementController _controller;
        public LoginForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            errorLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            if (_controller.CheckUser(usernameTextBox.Text,passwordTextBox.Text))
            {
                using var mainForm = new MainDashboard();
                this.Hide();
                var value = mainForm.ShowDialog();
                //if (value != DialogResult.OK)
                //{
                //    this.Close();
                //}
                //else
                //{
                //    this.Show();
                //}

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
    }
}
