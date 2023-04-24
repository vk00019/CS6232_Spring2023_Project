namespace HospitalManagement.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new MaskedTextBox();
            errorLabel = new Label();
            loginButton = new Button();
            clearButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(55, 62);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(99, 23);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username: ";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(198, 62);
            usernameTextBox.Margin = new Padding(2, 1, 2, 1);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(224, 27);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += TextBox_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(55, 127);
            passwordLabel.Margin = new Padding(2, 0, 2, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(90, 23);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(198, 127);
            passwordTextBox.Margin = new Padding(2, 1, 2, 1);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(224, 27);
            passwordTextBox.TabIndex = 4;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += TextBox_TextChanged;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(114, 174);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(103, 20);
            errorLabel.TabIndex = 5;
            errorLabel.Text = "Error Message";
            errorLabel.Visible = false;
            // 
            // loginButton
            // 
            loginButton.AutoSize = true;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(116, 227);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(92, 39);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(265, 227);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(92, 39);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 309);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(errorLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private TextBox usernameTextBox;
        private Label passwordLabel;
        private MaskedTextBox passwordTextBox;
        private Label errorLabel;
        private Button loginButton;
        private Button clearButton;
    }
}