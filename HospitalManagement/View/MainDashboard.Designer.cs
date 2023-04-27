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
            searchPatientVisitByUserControl = new UserControls.SearchPatientVisitByUserControl();
            startPatientVisitUserControl = new UserControls.StartPatientVisitUserControl();
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
            tabControl.Size = new Size(740, 856);
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
            patientTab.Size = new Size(732, 823);
            patientTab.TabIndex = 0;
            patientTab.Text = "Patient";
            patientTab.UseVisualStyleBackColor = true;
            // 
            // searchPatientByUserControl
            // 
            searchPatientByUserControl.BackColor = SystemColors.ControlLightLight;
            searchPatientByUserControl.Location = new Point(47, 78);
            searchPatientByUserControl.Margin = new Padding(2, 1, 2, 1);
            searchPatientByUserControl.Name = "searchPatientByUserControl";
            searchPatientByUserControl.Size = new Size(631, 681);
            searchPatientByUserControl.TabIndex = 3;
            searchPatientByUserControl.Visible = false;
            // 
            // registerPatientUserControl
            // 
            registerPatientUserControl.BackColor = SystemColors.ControlLightLight;
            registerPatientUserControl.Location = new Point(63, 89);
            registerPatientUserControl.Margin = new Padding(1);
            registerPatientUserControl.Name = "registerPatientUserControl";
            registerPatientUserControl.Size = new Size(624, 682);
            registerPatientUserControl.TabIndex = 2;
            registerPatientUserControl.Visible = false;
            // 
            // searchPatientButton
            // 
            searchPatientButton.AutoSize = true;
            searchPatientButton.Location = new Point(400, 24);
            searchPatientButton.Margin = new Padding(2, 3, 2, 3);
            searchPatientButton.Name = "searchPatientButton";
            searchPatientButton.Size = new Size(175, 42);
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
            registerPatientButton.Size = new Size(189, 42);
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
            appointmentTab.Size = new Size(782, 823);
            appointmentTab.TabIndex = 1;
            appointmentTab.Text = "Appointment";
            appointmentTab.UseVisualStyleBackColor = true;
            // 
            // searchAppointmentByUserControl
            // 
            searchAppointmentByUserControl.Location = new Point(70, 86);
            searchAppointmentByUserControl.Margin = new Padding(2, 1, 2, 1);
            searchAppointmentByUserControl.Name = "searchAppointmentByUserControl";
            searchAppointmentByUserControl.Size = new Size(633, 676);
            searchAppointmentByUserControl.TabIndex = 5;
            searchAppointmentByUserControl.Visible = false;
            // 
            // bookAppointmentUserControl
            // 
            bookAppointmentUserControl.BackColor = SystemColors.ControlLightLight;
            bookAppointmentUserControl.Location = new Point(126, 86);
            bookAppointmentUserControl.Margin = new Padding(1);
            bookAppointmentUserControl.Name = "bookAppointmentUserControl";
            bookAppointmentUserControl.Size = new Size(521, 630);
            bookAppointmentUserControl.TabIndex = 4;
            bookAppointmentUserControl.Visible = false;
            // 
            // searchAppointmentButton
            // 
            searchAppointmentButton.AutoSize = true;
            searchAppointmentButton.Location = new Point(390, 27);
            searchAppointmentButton.Margin = new Padding(2, 3, 2, 3);
            searchAppointmentButton.Name = "searchAppointmentButton";
            searchAppointmentButton.Size = new Size(218, 42);
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
            bookAppointmentButton.Size = new Size(206, 42);
            bookAppointmentButton.TabIndex = 2;
            bookAppointmentButton.Text = "Book an Appointment";
            bookAppointmentButton.UseVisualStyleBackColor = true;
            bookAppointmentButton.Click += BookAppointmentButton_Click;
            // 
            // visitTab
            // 
            visitTab.Controls.Add(searchPatientVisitByUserControl);
            visitTab.Controls.Add(startPatientVisitUserControl);
            visitTab.Controls.Add(searchVisitButton);
            visitTab.Controls.Add(startPatientVisitButton);
            visitTab.Location = new Point(4, 29);
            visitTab.Margin = new Padding(2, 3, 2, 3);
            visitTab.Name = "visitTab";
            visitTab.Size = new Size(782, 823);
            visitTab.TabIndex = 2;
            visitTab.Text = "Visit";
            visitTab.UseVisualStyleBackColor = true;
            // 
            // searchPatientVisitByUserControl
            // 
            searchPatientVisitByUserControl.Location = new Point(31, 91);
            searchPatientVisitByUserControl.Margin = new Padding(1);
            searchPatientVisitByUserControl.Name = "searchPatientVisitByUserControl";
            searchPatientVisitByUserControl.Size = new Size(705, 704);
            searchPatientVisitByUserControl.TabIndex = 5;
            searchPatientVisitByUserControl.Visible = false;
            // 
            // startPatientVisitUserControl
            // 
            startPatientVisitUserControl.Location = new Point(150, 123);
            startPatientVisitUserControl.Margin = new Padding(1);
            startPatientVisitUserControl.Name = "startPatientVisitUserControl";
            startPatientVisitUserControl.Size = new Size(460, 429);
            startPatientVisitUserControl.TabIndex = 4;
            startPatientVisitUserControl.Visible = false;
            // 
            // searchVisitButton
            // 
            searchVisitButton.AutoSize = true;
            searchVisitButton.Location = new Point(400, 27);
            searchVisitButton.Margin = new Padding(2, 3, 2, 3);
            searchVisitButton.Name = "searchVisitButton";
            searchVisitButton.Size = new Size(202, 42);
            searchVisitButton.TabIndex = 3;
            searchVisitButton.Text = "Search Patient Visit";
            searchVisitButton.UseVisualStyleBackColor = true;
            searchVisitButton.Click += SearchVisitButton_Click;
            // 
            // startPatientVisitButton
            // 
            startPatientVisitButton.AutoSize = true;
            startPatientVisitButton.Location = new Point(150, 27);
            startPatientVisitButton.Margin = new Padding(2, 3, 2, 3);
            startPatientVisitButton.Name = "startPatientVisitButton";
            startPatientVisitButton.Size = new Size(193, 42);
            startPatientVisitButton.TabIndex = 2;
            startPatientVisitButton.Text = "Start Patient Visit";
            startPatientVisitButton.UseVisualStyleBackColor = true;
            startPatientVisitButton.Click += StartPatientVisitButton_Click;
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Location = new Point(652, 9);
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
            usernameLabel.Location = new Point(284, 6);
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
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(761, 857);
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
        private UserControls.RegisterPatientUserControl registerPatientUserControl;
        private UserControls.BookAppointmentUserControl bookAppointmentUserControl;
        private UserControls.SearchAppointmentByUserControl searchAppointmentByUserControl;
        private UserControls.SearchPatientByUserControl searchPatientByUserControl;
        private UserControls.StartPatientVisitUserControl startPatientVisitUserControl;
        private UserControls.SearchPatientVisitByUserControl searchPatientVisitByUserControl;
    }
}