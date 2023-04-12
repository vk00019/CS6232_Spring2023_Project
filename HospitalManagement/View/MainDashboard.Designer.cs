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
            this.tabControl.Location = new System.Drawing.Point(0, 47);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1188, 1229);
            this.tabControl.TabIndex = 0;
            // 
            // patientTab
            // 
            this.patientTab.Controls.Add(this.searchPatientByUserControl);
            this.patientTab.Controls.Add(this.registerPatientUserControl);
            this.patientTab.Controls.Add(this.searchPatientButton);
            this.patientTab.Controls.Add(this.registerPatientButton);
            this.patientTab.Location = new System.Drawing.Point(8, 46);
            this.patientTab.Name = "patientTab";
            this.patientTab.Padding = new System.Windows.Forms.Padding(3);
            this.patientTab.Size = new System.Drawing.Size(1172, 1175);
            this.patientTab.TabIndex = 0;
            this.patientTab.Text = "Patient";
            this.patientTab.UseVisualStyleBackColor = true;
            // 
            // searchPatientByUserControl
            // 
            this.searchPatientByUserControl.AutoSize = true;
            this.searchPatientByUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchPatientByUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchPatientByUserControl.Location = new System.Drawing.Point(115, 110);
            this.searchPatientByUserControl.Name = "searchPatientByUserControl";
            this.searchPatientByUserControl.Size = new System.Drawing.Size(894, 449);
            this.searchPatientByUserControl.TabIndex = 3;
            this.searchPatientByUserControl.Visible = false;
            // 
            // registerPatientUserControl
            // 
            this.registerPatientUserControl.AutoSize = true;
            this.registerPatientUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerPatientUserControl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerPatientUserControl.Location = new System.Drawing.Point(213, 133);
            this.registerPatientUserControl.Name = "registerPatientUserControl";
            this.registerPatientUserControl.Size = new System.Drawing.Size(678, 980);
            this.registerPatientUserControl.TabIndex = 2;
            this.registerPatientUserControl.Visible = false;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Location = new System.Drawing.Point(588, 38);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(189, 46);
            this.searchPatientButton.TabIndex = 1;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            this.searchPatientButton.Click += new System.EventHandler(this.SearchPatientButton_Click);
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Location = new System.Drawing.Point(267, 38);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(189, 46);
            this.registerPatientButton.TabIndex = 0;
            this.registerPatientButton.Text = "Register Patient";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // appointmentTab
            // 
            this.appointmentTab.Controls.Add(this.searchAppointmentButton);
            this.appointmentTab.Controls.Add(this.bookAppointmentButton);
            this.appointmentTab.Location = new System.Drawing.Point(8, 46);
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.appointmentTab.Size = new System.Drawing.Size(1172, 1175);
            this.appointmentTab.TabIndex = 1;
            this.appointmentTab.Text = "Appointment";
            this.appointmentTab.UseVisualStyleBackColor = true;
            // 
            // searchAppointmentButton
            // 
            this.searchAppointmentButton.AutoSize = true;
            this.searchAppointmentButton.Location = new System.Drawing.Point(570, 41);
            this.searchAppointmentButton.Name = "searchAppointmentButton";
            this.searchAppointmentButton.Size = new System.Drawing.Size(243, 46);
            this.searchAppointmentButton.TabIndex = 3;
            this.searchAppointmentButton.Text = "Search Appointment";
            this.searchAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.AutoSize = true;
            this.bookAppointmentButton.Location = new System.Drawing.Point(219, 41);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(259, 46);
            this.bookAppointmentButton.TabIndex = 2;
            this.bookAppointmentButton.Text = "Book an Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // visitTab
            // 
            this.visitTab.Controls.Add(this.searchVisitButton);
            this.visitTab.Controls.Add(this.startPatientVisitButton);
            this.visitTab.Location = new System.Drawing.Point(8, 46);
            this.visitTab.Name = "visitTab";
            this.visitTab.Size = new System.Drawing.Size(1172, 1175);
            this.visitTab.TabIndex = 2;
            this.visitTab.Text = "Visit";
            this.visitTab.UseVisualStyleBackColor = true;
            // 
            // searchVisitButton
            // 
            this.searchVisitButton.AutoSize = true;
            this.searchVisitButton.Location = new System.Drawing.Point(564, 41);
            this.searchVisitButton.Name = "searchVisitButton";
            this.searchVisitButton.Size = new System.Drawing.Size(227, 46);
            this.searchVisitButton.TabIndex = 3;
            this.searchVisitButton.Text = "Search Patient Visit";
            this.searchVisitButton.UseVisualStyleBackColor = true;
            // 
            // startPatientVisitButton
            // 
            this.startPatientVisitButton.AutoSize = true;
            this.startPatientVisitButton.Location = new System.Drawing.Point(243, 41);
            this.startPatientVisitButton.Name = "startPatientVisitButton";
            this.startPatientVisitButton.Size = new System.Drawing.Size(204, 46);
            this.startPatientVisitButton.TabIndex = 2;
            this.startPatientVisitButton.Text = "Start Patient Visit";
            this.startPatientVisitButton.UseVisualStyleBackColor = true;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(910, 15);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(89, 32);
            this.logoutLinkLabel.TabIndex = 11;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLinkLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(706, 9);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ClientSize = new System.Drawing.Size(1222, 953);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.usernameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
        private UserControls.SearchPatientByUserControl searchPatientByUserControl;
        private UserControls.RegisterPatientUserControl registerPatientUserControl;
    }
}