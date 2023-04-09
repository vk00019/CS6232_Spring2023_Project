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
            this.bookAppointmentButton = new System.Windows.Forms.Button();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.startPatientVisitButton = new System.Windows.Forms.Button();
            this.searchPatientButton = new System.Windows.Forms.Button();
            this.menuUserControl = new HospitalManagement.UserControls.MenuUserControl();
            this.SuspendLayout();
            // 
            // bookAppointmentButton
            // 
            this.bookAppointmentButton.AutoSize = true;
            this.bookAppointmentButton.Location = new System.Drawing.Point(73, 184);
            this.bookAppointmentButton.Name = "bookAppointmentButton";
            this.bookAppointmentButton.Size = new System.Drawing.Size(226, 46);
            this.bookAppointmentButton.TabIndex = 3;
            this.bookAppointmentButton.Text = "Book Appointment";
            this.bookAppointmentButton.UseVisualStyleBackColor = true;
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Location = new System.Drawing.Point(474, 184);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(226, 46);
            this.registerPatientButton.TabIndex = 4;
            this.registerPatientButton.Text = "Register Patient";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            // 
            // startPatientVisitButton
            // 
            this.startPatientVisitButton.AutoSize = true;
            this.startPatientVisitButton.Location = new System.Drawing.Point(73, 327);
            this.startPatientVisitButton.Name = "startPatientVisitButton";
            this.startPatientVisitButton.Size = new System.Drawing.Size(226, 46);
            this.startPatientVisitButton.TabIndex = 5;
            this.startPatientVisitButton.Text = "Start Patient Visit";
            this.startPatientVisitButton.UseVisualStyleBackColor = true;
            // 
            // searchPatientButton
            // 
            this.searchPatientButton.AutoSize = true;
            this.searchPatientButton.Location = new System.Drawing.Point(474, 327);
            this.searchPatientButton.Name = "searchPatientButton";
            this.searchPatientButton.Size = new System.Drawing.Size(226, 46);
            this.searchPatientButton.TabIndex = 6;
            this.searchPatientButton.Text = "Search Patient";
            this.searchPatientButton.UseVisualStyleBackColor = true;
            // 
            // menuUserControl
            // 
            this.menuUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuUserControl.Location = new System.Drawing.Point(0, 0);
            this.menuUserControl.Name = "menuUserControl";
            this.menuUserControl.Size = new System.Drawing.Size(840, 108);
            this.menuUserControl.TabIndex = 7;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 545);
            this.Controls.Add(this.menuUserControl);
            this.Controls.Add(this.searchPatientButton);
            this.Controls.Add(this.startPatientVisitButton);
            this.Controls.Add(this.registerPatientButton);
            this.Controls.Add(this.bookAppointmentButton);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bookAppointmentButton;
        private Button registerPatientButton;
        private Button startPatientVisitButton;
        private Button searchPatientButton;
        private UserControls.MenuUserControl menuUserControl;
    }
}