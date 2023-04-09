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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientVisitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.startPatientVisitButton = new System.Windows.Forms.Button();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenu,
            this.appointmentMenuItem,
            this.patientMenuItem,
            this.closeMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeMenu
            // 
            this.homeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(99, 38);
            this.homeMenu.Text = "Home";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(206, 44);
            this.openMenuItem.Text = "Open";
            // 
            // appointmentMenuItem
            // 
            this.appointmentMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAppointmentMenuItem,
            this.searchAppointmentMenuItem});
            this.appointmentMenuItem.Name = "appointmentMenuItem";
            this.appointmentMenuItem.Size = new System.Drawing.Size(175, 38);
            this.appointmentMenuItem.Text = "Appointment";
            // 
            // bookAppointmentMenuItem
            // 
            this.bookAppointmentMenuItem.Name = "bookAppointmentMenuItem";
            this.bookAppointmentMenuItem.Size = new System.Drawing.Size(366, 44);
            this.bookAppointmentMenuItem.Text = "Book Appointment";
            // 
            // searchAppointmentMenuItem
            // 
            this.searchAppointmentMenuItem.Name = "searchAppointmentMenuItem";
            this.searchAppointmentMenuItem.Size = new System.Drawing.Size(366, 44);
            this.searchAppointmentMenuItem.Text = "Search Appointment";
            // 
            // patientMenuItem
            // 
            this.patientMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientMenuItem,
            this.searchPatientMenuItem,
            this.searchPatientVisitMenuItem});
            this.patientMenuItem.Name = "patientMenuItem";
            this.patientMenuItem.Size = new System.Drawing.Size(107, 38);
            this.patientMenuItem.Text = "Patient";
            // 
            // registerPatientMenuItem
            // 
            this.registerPatientMenuItem.Name = "registerPatientMenuItem";
            this.registerPatientMenuItem.Size = new System.Drawing.Size(359, 44);
            this.registerPatientMenuItem.Text = "Register Patient";
            // 
            // searchPatientMenuItem
            // 
            this.searchPatientMenuItem.Name = "searchPatientMenuItem";
            this.searchPatientMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchPatientMenuItem.Text = "Search Patient";
            // 
            // searchPatientVisitMenuItem
            // 
            this.searchPatientVisitMenuItem.Name = "searchPatientVisitMenuItem";
            this.searchPatientVisitMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchPatientVisitMenuItem.Text = "Search Patient Visit";
            // 
            // closeMenu
            // 
            this.closeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(92, 38);
            this.closeMenu.Text = "Close";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitMenuItem.Text = "Exit";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(791, 58);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(119, 32);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "username";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(925, 58);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(89, 32);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.AutoSize = true;
            this.bookAppointmentButton.Location = new System.Drawing.Point(169, 226);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(226, 46);
            this.bookAppointmentButton.TabIndex = 3;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Location = new System.Drawing.Point(570, 226);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(226, 46);
            this.registerPatientButton.TabIndex = 4;
            this.registerPatientButton.Text = "Register Patient";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            // 
            // startPatientVisitButton
            // 
            this.startPatientVisitButton.AutoSize = true;
            this.startPatientVisitButton.Location = new System.Drawing.Point(169, 369);
            this.startPatientVisitButton.Name = "startPatientVisitButton";
            this.startPatientVisitButton.Size = new System.Drawing.Size(226, 46);
            this.startPatientVisitButton.TabIndex = 5;
            this.startPatientVisitButton.Text = "Start Patient Visit";
            this.startPatientVisitButton.UseVisualStyleBackColor = true;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Location = new System.Drawing.Point(570, 369);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(226, 46);
            this.searchPatientButton.TabIndex = 6;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 597);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.startPatientVisitButton);
            this.Controls.Add(this.registerPatientButton);
            this.Controls.Add(this.bookAppointmentButton);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeMenu;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem appointmentMenuItem;
        private ToolStripMenuItem bookAppointmentMenuItem;
        private ToolStripMenuItem searchAppointmentMenuItem;
        private ToolStripMenuItem patientMenuItem;
        private ToolStripMenuItem registerPatientMenuItem;
        private ToolStripMenuItem searchPatientMenuItem;
        private ToolStripMenuItem searchPatientVisitMenuItem;
        private ToolStripMenuItem closeMenu;
        private ToolStripMenuItem exitMenuItem;
        private Label usernameLabel;
        private LinkLabel logoutLinkLabel;
        private Button bookAppointmentButton;
        private Button registerPatientButton;
        private Button startPatientVisitButton;
        private Button searchPatientButton;
    }
}