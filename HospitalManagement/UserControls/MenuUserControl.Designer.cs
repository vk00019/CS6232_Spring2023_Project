namespace HospitalManagement.UserControls
{
    partial class MenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientVisitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(674, 49);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(89, 32);
            this.logoutLinkLabel.TabIndex = 9;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(502, 49);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(142, 37);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "username";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(184, 44);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(92, 38);
            this.closeMenu.Text = "Close";
            // 
            // searchPatientVisitMenuItem
            // 
            this.searchPatientVisitMenuItem.Name = "searchPatientVisitMenuItem";
            this.searchPatientVisitMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchPatientVisitMenuItem.Text = "Search Patient Visit";
            // 
            // searchPatientMenuItem
            // 
            this.searchPatientMenuItem.Name = "searchPatientMenuItem";
            this.searchPatientMenuItem.Size = new System.Drawing.Size(359, 44);
            this.searchPatientMenuItem.Text = "Search Patient";
            // 
            // registerPatientMenuItem
            // 
            this.registerPatientMenuItem.Name = "registerPatientMenuItem";
            this.registerPatientMenuItem.Size = new System.Drawing.Size(359, 44);
            this.registerPatientMenuItem.Text = "Register Patient";
            this.registerPatientMenuItem.Click += new System.EventHandler(this.RegisterPatientMenuItem_Click);
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
            // searchAppointmentMenuItem
            // 
            this.searchAppointmentMenuItem.Name = "searchAppointmentMenuItem";
            this.searchAppointmentMenuItem.Size = new System.Drawing.Size(366, 44);
            this.searchAppointmentMenuItem.Text = "Search Appointment";
            // 
            // bookAppointmentMenuItem
            // 
            this.bookAppointmentMenuItem.Name = "bookAppointmentMenuItem";
            this.bookAppointmentMenuItem.Size = new System.Drawing.Size(366, 44);
            this.bookAppointmentMenuItem.Text = "Book Appointment";
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
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(206, 44);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // homeMenu
            // 
            this.homeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem});
            this.homeMenu.Name = "homeMenu";
            this.homeMenu.Size = new System.Drawing.Size(99, 38);
            this.homeMenu.Text = "Home";
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 42);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(784, 154);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel logoutLinkLabel;
        private Label usernameLabel;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem closeMenu;
        private ToolStripMenuItem searchPatientVisitMenuItem;
        private ToolStripMenuItem searchPatientMenuItem;
        private ToolStripMenuItem registerPatientMenuItem;
        private ToolStripMenuItem patientMenuItem;
        private ToolStripMenuItem searchAppointmentMenuItem;
        private ToolStripMenuItem bookAppointmentMenuItem;
        private ToolStripMenuItem appointmentMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem homeMenu;
        private MenuStrip menuStrip1;
    }
}
