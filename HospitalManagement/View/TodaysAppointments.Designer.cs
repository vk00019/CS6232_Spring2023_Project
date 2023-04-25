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
            nameLabel = new Label();
            appointmentsDataGridView = new DataGridView();
            cancelButton = new Button();
            startVisitButton = new Button();
            msgLabel = new Label();
            appointmentID = new DataGridViewTextBoxColumn();
            patientID = new DataGridViewTextBoxColumn();
            doctorID = new DataGridViewTextBoxColumn();
            doctorName = new DataGridViewTextBoxColumn();
            ScheduledDate = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(21, 15);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(189, 19);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "List of Today's Appointments:";
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AllowUserToAddRows = false;
            appointmentsDataGridView.AllowUserToDeleteRows = false;
            appointmentsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { appointmentID, patientID, doctorID, doctorName, ScheduledDate, reason });
            appointmentsDataGridView.Location = new Point(21, 40);
            appointmentsDataGridView.Margin = new Padding(2, 1, 2, 1);
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.RowHeadersWidth = 82;
            appointmentsDataGridView.RowTemplate.Height = 41;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(494, 141);
            appointmentsDataGridView.TabIndex = 5;
            appointmentsDataGridView.CellMouseClick += AppointmentsDataGridView_CellMouseClick;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(326, 222);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(81, 22);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // startVisitButton
            // 
            startVisitButton.AutoSize = true;
            startVisitButton.Enabled = false;
            startVisitButton.Location = new Point(106, 222);
            startVisitButton.Margin = new Padding(2, 1, 2, 1);
            startVisitButton.Name = "startVisitButton";
            startVisitButton.Size = new Size(110, 25);
            startVisitButton.TabIndex = 9;
            startVisitButton.Text = "Start Patient Visit";
            startVisitButton.UseVisualStyleBackColor = true;
            startVisitButton.Click += StartVisitButton_Click;
            // 
            // msgLabel
            // 
            msgLabel.AutoSize = true;
            msgLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            msgLabel.Location = new Point(35, 192);
            msgLabel.Margin = new Padding(2, 0, 2, 0);
            msgLabel.Name = "msgLabel";
            msgLabel.Size = new Size(81, 15);
            msgLabel.TabIndex = 10;
            msgLabel.Text = "messageLabel";
            // 
            // appointmentID
            // 
            appointmentID.HeaderText = "Appointment ID";
            appointmentID.Name = "appointmentID";
            appointmentID.ReadOnly = true;
            // 
            // patientID
            // 
            patientID.HeaderText = "Patients ID";
            patientID.Name = "patientID";
            patientID.ReadOnly = true;
            // 
            // doctorID
            // 
            doctorID.HeaderText = "Doctor ID";
            doctorID.Name = "doctorID";
            doctorID.ReadOnly = true;
            // 
            // doctorName
            // 
            doctorName.HeaderText = "Doctor Name";
            doctorName.Name = "doctorName";
            doctorName.ReadOnly = true;
            // 
            // ScheduledDate
            // 
            ScheduledDate.HeaderText = "Scheduled Date";
            ScheduledDate.Name = "ScheduledDate";
            ScheduledDate.ReadOnly = true;
            // 
            // reason
            // 
            reason.HeaderText = "Reason";
            reason.Name = "reason";
            reason.ReadOnly = true;
            // 
            // TodaysAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 278);
            Controls.Add(msgLabel);
            Controls.Add(startVisitButton);
            Controls.Add(cancelButton);
            Controls.Add(nameLabel);
            Controls.Add(appointmentsDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TodaysAppointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todays Appointments";
            Load += TodaysAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
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