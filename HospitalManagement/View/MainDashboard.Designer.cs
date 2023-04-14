namespace HospitalManagement.View
{
    partial class MainDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            patientTab = new TabPage();
            searchPatientByUserControl = new UserControls.SearchPatientByUserControl();
            registerPatientUserControl = new UserControls.RegisterPatientUserControl();
            searchPatientButton = new Button();
            registerPatientButton = new Button();
            appointmentTab = new TabPage();
            searchAppointmentByUserControl = new UserControls.SearchAppointmentByUserControl();
            bookAppointmentUserControl = new UserControls.BookAppointmentUserControl();
            searchAppointmentButton = new Button();
            bookAppointmentButton = new Button();
            visitTab = new TabPage();
            searchVisitButton = new Button();
            startPatientVisitButton = new Button();
            logoutLinkLabel = new LinkLabel();
            usernameLabel = new Label();
            tabControl.SuspendLayout();
            patientTab.SuspendLayout();
            appointmentTab.SuspendLayout();
            visitTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(patientTab);
            tabControl.Controls.Add(appointmentTab);
            tabControl.Controls.Add(visitTab);
            tabControl.Dock = DockStyle.Bottom;
            tabControl.Location = new Point(0, 29);
            tabControl.Margin = new Padding(2, 3, 2, 3);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(683, 781);
            tabControl.TabIndex = 0;
            // 
            // patientTab
            // 
            patientTab.Controls.Add(searchPatientByUserControl);
            patientTab.Controls.Add(registerPatientUserControl);
            patientTab.Controls.Add(searchPatientButton);
            patientTab.Controls.Add(registerPatientButton);
            patientTab.Location = new Point(4, 29);
            patientTab.Margin = new Padding(2, 3, 2, 3);
            patientTab.Name = "patientTab";
            patientTab.Padding = new Padding(2, 3, 2, 3);
            patientTab.Size = new Size(675, 748);
            patientTab.TabIndex = 0;
            patientTab.Text = "Patient";
            patientTab.UseVisualStyleBackColor = true;
            // 
            // searchPatientByUserControl
            // 
            searchPatientByUserControl.AutoSize = true;
            searchPatientByUserControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            searchPatientByUserControl.BackColor = SystemColors.ControlLightLight;
            searchPatientByUserControl.Location = new Point(71, 69);
            searchPatientByUserControl.Margin = new Padding(2, 1, 2, 1);
            searchPatientByUserControl.Name = "searchPatientByUserControl";
            searchPatientByUserControl.Size = new Size(553, 281);
            searchPatientByUserControl.TabIndex = 3;
            searchPatientByUserControl.Visible = false;
            // 
            // registerPatientUserControl
            // 
            registerPatientUserControl.AutoSize = true;
            registerPatientUserControl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerPatientUserControl.BackColor = SystemColors.ControlLightLight;
            registerPatientUserControl.Location = new Point(131, 83);
            registerPatientUserControl.Margin = new Padding(1);
            registerPatientUserControl.Name = "registerPatientUserControl";
            registerPatientUserControl.Size = new Size(419, 612);
            registerPatientUserControl.TabIndex = 2;
            registerPatientUserControl.Visible = false;
            // 
            // searchPatientButton
            // 
            searchPatientButton.AutoSize = true;
            searchPatientButton.Location = new Point(362, 24);
            searchPatientButton.Margin = new Padding(2, 3, 2, 3);
            searchPatientButton.Name = "searchPatientButton";
            searchPatientButton.Size = new Size(128, 40);
            searchPatientButton.TabIndex = 1;
            searchPatientButton.Text = "Search Patient";
            searchPatientButton.UseVisualStyleBackColor = true;
            searchPatientButton.Click += SearchPatientButton_Click;
            // 
            // registerPatientButton
            // 
            registerPatientButton.AutoSize = true;
            registerPatientButton.Location = new Point(165, 24);
            registerPatientButton.Margin = new Padding(2, 3, 2, 3);
            registerPatientButton.Name = "registerPatientButton";
            registerPatientButton.Size = new Size(139, 40);
            registerPatientButton.TabIndex = 0;
            registerPatientButton.Text = "Register Patient";
            registerPatientButton.UseVisualStyleBackColor = true;
            registerPatientButton.Click += RegisterPatientButton_Click;
            // 
            // appointmentTab
            // 
            appointmentTab.Controls.Add(searchAppointmentByUserControl);
            appointmentTab.Controls.Add(bookAppointmentUserControl);
            appointmentTab.Controls.Add(searchAppointmentButton);
            appointmentTab.Controls.Add(bookAppointmentButton);
            appointmentTab.Location = new Point(4, 29);
            appointmentTab.Margin = new Padding(2, 3, 2, 3);
            appointmentTab.Name = "appointmentTab";
            appointmentTab.Padding = new Padding(2, 3, 2, 3);
            appointmentTab.Size = new Size(675, 748);
            appointmentTab.TabIndex = 1;
            appointmentTab.Text = "Appointment";
            appointmentTab.UseVisualStyleBackColor = true;
            // 
            // searchAppointmentByUserControl
            // 
            searchAppointmentByUserControl.Location = new Point(49, 72);
            searchAppointmentByUserControl.Margin = new Padding(1);
            searchAppointmentByUserControl.Name = "searchAppointmentByUserControl";
            searchAppointmentByUserControl.Size = new Size(576, 745);
            searchAppointmentByUserControl.TabIndex = 5;
            searchAppointmentByUserControl.Visible = false;
            // 
            // bookAppointmentUserControl
            // 
            bookAppointmentUserControl.BackColor = SystemColors.ControlLightLight;
            bookAppointmentUserControl.Location = new Point(82, 99);
            bookAppointmentUserControl.Margin = new Padding(1);
            bookAppointmentUserControl.Name = "bookAppointmentUserControl";
            bookAppointmentUserControl.Size = new Size(497, 524);
            bookAppointmentUserControl.TabIndex = 4;
            bookAppointmentUserControl.Visible = false;
            // 
            // searchAppointmentButton
            // 
            searchAppointmentButton.AutoSize = true;
            searchAppointmentButton.Location = new Point(351, 27);
            searchAppointmentButton.Margin = new Padding(2, 3, 2, 3);
            searchAppointmentButton.Name = "searchAppointmentButton";
            searchAppointmentButton.Size = new Size(177, 40);
            searchAppointmentButton.TabIndex = 3;
            searchAppointmentButton.Text = "Search Appointment";
            searchAppointmentButton.UseVisualStyleBackColor = true;
            searchAppointmentButton.Click += SearchAppointmentButton_Click;
            // 
            // bookAppointmentButton
            // 
            bookAppointmentButton.AutoSize = true;
            bookAppointmentButton.Location = new Point(135, 27);
            bookAppointmentButton.Margin = new Padding(2, 3, 2, 3);
            bookAppointmentButton.Name = "bookAppointmentButton";
            bookAppointmentButton.Size = new Size(189, 40);
            bookAppointmentButton.TabIndex = 2;
            bookAppointmentButton.Text = "Book an Appointment";
            bookAppointmentButton.UseVisualStyleBackColor = true;
            bookAppointmentButton.Click += BookAppointmentButton_Click;
            // 
            // visitTab
            // 
            visitTab.Controls.Add(searchVisitButton);
            visitTab.Controls.Add(startPatientVisitButton);
            visitTab.Location = new Point(4, 29);
            visitTab.Margin = new Padding(2, 3, 2, 3);
            visitTab.Name = "visitTab";
            visitTab.Size = new Size(675, 748);
            visitTab.TabIndex = 2;
            visitTab.Text = "Visit";
            visitTab.UseVisualStyleBackColor = true;
            // 
            // searchVisitButton
            // 
            searchVisitButton.AutoSize = true;
            searchVisitButton.Location = new Point(347, 27);
            searchVisitButton.Margin = new Padding(2, 3, 2, 3);
            searchVisitButton.Name = "searchVisitButton";
            searchVisitButton.Size = new Size(165, 40);
            searchVisitButton.TabIndex = 3;
            searchVisitButton.Text = "Search Patient Visit";
            searchVisitButton.UseVisualStyleBackColor = true;
            // 
            // startPatientVisitButton
            // 
            startPatientVisitButton.AutoSize = true;
            startPatientVisitButton.Location = new Point(150, 27);
            startPatientVisitButton.Margin = new Padding(2, 3, 2, 3);
            startPatientVisitButton.Name = "startPatientVisitButton";
            startPatientVisitButton.Size = new Size(150, 40);
            startPatientVisitButton.TabIndex = 2;
            startPatientVisitButton.Text = "Start Patient Visit";
            startPatientVisitButton.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Location = new Point(560, 9);
            logoutLinkLabel.Margin = new Padding(2, 0, 2, 0);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(56, 20);
            logoutLinkLabel.TabIndex = 11;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "Logout";
            logoutLinkLabel.LinkClicked += LogoutLinkLabel_LinkClicked;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.Location = new Point(434, 5);
            usernameLabel.Margin = new Padding(2, 0, 2, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(87, 23);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "username";
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(683, 810);
            Controls.Add(logoutLinkLabel);
            Controls.Add(tabControl);
            Controls.Add(usernameLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management Dashboard";
            tabControl.ResumeLayout(false);
            patientTab.ResumeLayout(false);
            patientTab.PerformLayout();
            appointmentTab.ResumeLayout(false);
            appointmentTab.PerformLayout();
            visitTab.ResumeLayout(false);
            visitTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tabControl;
        private TabPage patientTab;
        private TabPage appointmentTab;
        private TabPage visitTab;
        private Button searchPatientButton;
        private Button registerPatientButton;
        private Button searchAppointmentButton;
        private Button bookAppointmentButton;
        private Button searchVisitButton;
        private Button startPatientVisitButton;
        private LinkLabel logoutLinkLabel;
        private Label usernameLabel;
        private UserControls.SearchPatientByUserControl searchPatientByUserControl;
        private UserControls.RegisterPatientUserControl registerPatientUserControl;
        private UserControls.BookAppointmentUserControl bookAppointmentUserControl;
        private UserControls.SearchAppointmentByUserControl searchAppointmentByUserControl;
    }
}