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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.patientTab = new System.Windows.Forms.TabPage();
            this.searchPatientByUserControl = new HospitalManagement.UserControls.SearchPatientByUserControl();
            this.registerPatientUserControl = new HospitalManagement.UserControls.RegisterPatientUserControl();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.appointmentTab = new System.Windows.Forms.TabPage();
            this.searchAppointmentByUserControl = new HospitalManagement.UserControls.SearchAppointmentByUserControl();
            this.bookAppointmentUserControl = new HospitalManagement.UserControls.BookAppointmentUserControl();
            this.searchAppointmentButton = new System.Windows.Forms.Button();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.visitTab = new System.Windows.Forms.TabPage();
            this.searchVisitButton = new System.Windows.Forms.Button();
            this.startPatientVisitButton = new System.Windows.Forms.Button();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.patientTab.SuspendLayout();
            this.appointmentTab.SuspendLayout();
            this.visitTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.patientTab);
            this.tabControl.Controls.Add(this.appointmentTab);
            this.tabControl.Controls.Add(this.visitTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 89);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1274, 1370);
            this.tabControl.TabIndex = 0;
            // 
            // patientTab
            // 
            this.patientTab.Controls.Add(this.searchPatientByUserControl);
            this.patientTab.Controls.Add(this.registerPatientUserControl);
            this.patientTab.Controls.Add(this.searchPatientButton);
            this.patientTab.Controls.Add(this.registerPatientButton);
            this.patientTab.Location = new System.Drawing.Point(8, 46);
            this.patientTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.patientTab.Size = new System.Drawing.Size(1258, 1316);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Patient";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // searchPatientByUserControl
            // 
            this.searchPatientByUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchPatientByUserControl.Location = new System.Drawing.Point(77, 125);
            this.searchPatientByUserControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchPatientByUserControl.Name = "searchPatientByUserControl";
            this.searchPatientByUserControl.Size = new System.Drawing.Size(1026, 1089);
            this.searchPatientByUserControl.TabIndex = 3;
            this.searchPatientByUserControl.Visible = false;
            // 
            // registerPatientUserControl
            // 
            this.registerPatientUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerPatientUserControl.Location = new System.Drawing.Point(103, 143);
            this.registerPatientUserControl.Name = "registerPatientUserControl";
            this.registerPatientUserControl.Size = new System.Drawing.Size(1014, 1091);
            this.registerPatientUserControl.TabIndex = 2;
            this.registerPatientUserControl.Visible = false;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Location = new System.Drawing.Point(650, 38);
            this.searchPatientButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(284, 67);
            this.searchPatientButton.TabIndex = 1;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Location = new System.Drawing.Point(268, 38);
            this.registerPatientButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(307, 67);
            this.registerPatientButton.TabIndex = 0;
            this.registerPatientButton.Text = "Register Patient";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // appointmentTab
            // 
            this.appointmentTab.Controls.Add(this.searchAppointmentByUserControl);
            this.appointmentTab.Controls.Add(this.bookAppointmentUserControl);
            this.appointmentTab.Controls.Add(this.searchAppointmentButton);
            this.appointmentTab.Controls.Add(this.bookAppointmentButton);
            this.appointmentTab.Location = new System.Drawing.Point(8, 46);
            this.appointmentTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.appointmentTab.Size = new System.Drawing.Size(1258, 1262);
            this.appointmentTab.TabIndex = 1;
            this.appointmentTab.Text = "Appointment";
            this.appointmentTab.UseVisualStyleBackColor = true;
            // 
            // searchAppointmentByUserControl
            // 
            this.searchAppointmentByUserControl.Location = new System.Drawing.Point(113, 137);
            this.searchAppointmentByUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchAppointmentByUserControl.Name = "searchAppointmentByUserControl";
            this.searchAppointmentByUserControl.Size = new System.Drawing.Size(1028, 1082);
            this.searchAppointmentByUserControl.TabIndex = 5;
            this.searchAppointmentByUserControl.Visible = false;
            // 
            // bookAppointmentUserControl
            // 
            this.bookAppointmentUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookAppointmentUserControl.Location = new System.Drawing.Point(205, 137);
            this.bookAppointmentUserControl.Name = "bookAppointmentUserControl";
            this.bookAppointmentUserControl.Size = new System.Drawing.Size(846, 1008);
            this.bookAppointmentUserControl.TabIndex = 4;
            this.bookAppointmentUserControl.Visible = false;
            // 
            // searchAppointmentButton
            // 
            this.searchAppointmentButton.AutoSize = true;
            this.searchAppointmentButton.Location = new System.Drawing.Point(634, 43);
            this.searchAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchAppointmentButton.Name = "searchAppointmentButton";
            this.searchAppointmentButton.Size = new System.Drawing.Size(355, 67);
            this.searchAppointmentButton.TabIndex = 3;
            this.searchAppointmentButton.Text = "Search Appointment";
            this.searchAppointmentButton.UseVisualStyleBackColor = true;
            this.searchAppointmentButton.Click += new System.EventHandler(this.SearchAppointmentButton_Click);
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.AutoSize = true;
            this.bookAppointmentButton.Location = new System.Drawing.Point(219, 43);
            this.bookAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(335, 67);
            this.bookAppointmentButton.TabIndex = 2;
            this.bookAppointmentButton.Text = "Book an Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            this.bookAppointmentButton.Click += new System.EventHandler(this.BookAppointmentButton_Click);
            // 
            // visitTab
            // 
            this.visitTab.Controls.Add(this.searchVisitButton);
            this.visitTab.Controls.Add(this.startPatientVisitButton);
            this.visitTab.Location = new System.Drawing.Point(8, 46);
            this.visitTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.visitTab.Name = "visitTab";
            this.visitTab.Size = new System.Drawing.Size(1258, 1262);
            this.visitTab.TabIndex = 2;
            this.visitTab.Text = "Visit";
            this.visitTab.UseVisualStyleBackColor = true;
            // 
            // searchVisitButton
            // 
            this.searchVisitButton.AutoSize = true;
            this.searchVisitButton.Location = new System.Drawing.Point(650, 43);
            this.searchVisitButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchVisitButton.Name = "searchVisitButton";
            this.searchVisitButton.Size = new System.Drawing.Size(329, 67);
            this.searchVisitButton.TabIndex = 3;
            this.searchVisitButton.Text = "Search Patient Visit";
            this.searchVisitButton.UseVisualStyleBackColor = true;
            // 
            // startPatientVisitButton
            // 
            this.startPatientVisitButton.AutoSize = true;
            this.startPatientVisitButton.Location = new System.Drawing.Point(244, 43);
            this.startPatientVisitButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.startPatientVisitButton.Name = "startPatientVisitButton";
            this.startPatientVisitButton.Size = new System.Drawing.Size(314, 67);
            this.startPatientVisitButton.TabIndex = 2;
            this.startPatientVisitButton.Text = "Start Patient Visit";
            this.startPatientVisitButton.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(1060, 15);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(89, 32);
            this.logoutLinkLabel.TabIndex = 11;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(461, 10);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(142, 37);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "username";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1274, 1459);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management Dashboard";
            this.tabControl.ResumeLayout(false);
            this.patientTab.ResumeLayout(false);
            this.patientTab.PerformLayout();
            this.appointmentTab.ResumeLayout(false);
            this.appointmentTab.PerformLayout();
            this.visitTab.ResumeLayout(false);
            this.visitTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}