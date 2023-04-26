namespace HospitalManagement.View
{
    partial class TodaysAppointments
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduledDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startVisitButton = new System.Windows.Forms.Button();
            this.msgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(39, 32);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(363, 37);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "List of Today\'s Appointments:";
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.AllowUserToAddRows = false;
            this.appointmentsDataGridView.AllowUserToDeleteRows = false;
            this.appointmentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.patientID,
            this.doctorID,
            this.doctorName,
            this.ScheduledDate,
            this.reason});
            this.appointmentsDataGridView.Location = new System.Drawing.Point(39, 85);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 41;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(917, 301);
            this.appointmentsDataGridView.TabIndex = 5;
            this.appointmentsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AppointmentsDataGridView_CellMouseClick);
            // 
            // appointmentID
            // 
            this.appointmentID.HeaderText = "Appointment ID";
            this.appointmentID.MinimumWidth = 10;
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.ReadOnly = true;
            this.appointmentID.Width = 200;
            // 
            // patientID
            // 
            this.patientID.HeaderText = "Patients ID";
            this.patientID.MinimumWidth = 10;
            this.patientID.Name = "patientID";
            this.patientID.ReadOnly = true;
            this.patientID.Width = 200;
            // 
            // doctorID
            // 
            this.doctorID.HeaderText = "Doctor ID";
            this.doctorID.MinimumWidth = 10;
            this.doctorID.Name = "doctorID";
            this.doctorID.ReadOnly = true;
            this.doctorID.Width = 200;
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "Doctor Name";
            this.doctorName.MinimumWidth = 10;
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            this.doctorName.Width = 200;
            // 
            // ScheduledDate
            // 
            this.ScheduledDate.HeaderText = "Scheduled Date";
            this.ScheduledDate.MinimumWidth = 10;
            this.ScheduledDate.Name = "ScheduledDate";
            this.ScheduledDate.ReadOnly = true;
            this.ScheduledDate.Width = 200;
            // 
            // reason
            // 
            this.reason.HeaderText = "Reason";
            this.reason.MinimumWidth = 10;
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Width = 200;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(605, 474);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 47);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // startVisitButton
            // 
            this.startVisitButton.AutoSize = true;
            this.startVisitButton.Enabled = false;
            this.startVisitButton.Location = new System.Drawing.Point(197, 474);
            this.startVisitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.startVisitButton.Name = "startVisitButton";
            this.startVisitButton.Size = new System.Drawing.Size(204, 53);
            this.startVisitButton.TabIndex = 9;
            this.startVisitButton.Text = "Start Patient Visit";
            this.startVisitButton.UseVisualStyleBackColor = true;
            this.startVisitButton.Click += new System.EventHandler(this.StartVisitButton_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msgLabel.Location = new System.Drawing.Point(65, 410);
            this.msgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(163, 32);
            this.msgLabel.TabIndex = 10;
            this.msgLabel.Text = "messageLabel";
            // 
            // TodaysAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 593);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.startVisitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TodaysAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todays Appointments";
            this.Load += new System.EventHandler(this.TodaysAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private DataGridView appointmentsDataGridView;
        private Button cancelButton;
        private Button startVisitButton;
        private Label msgLabel;
        private DataGridViewTextBoxColumn appointmentID;
        private DataGridViewTextBoxColumn patientID;
        private DataGridViewTextBoxColumn doctorID;
        private DataGridViewTextBoxColumn doctorName;
        private DataGridViewTextBoxColumn ScheduledDate;
        private DataGridViewTextBoxColumn reason;
    }
}