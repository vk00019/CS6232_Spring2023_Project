namespace HospitalManagement.View
{
    partial class ViewPatientForm
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
            headerLabel = new Label();
            patientNameLabel = new Label();
            dobLabel = new Label();
            appointmentsDataGridView = new DataGridView();
            nameLabel = new Label();
            visitsLabel = new Label();
            visitDataGridView = new DataGridView();
            cancelButton = new Button();
            patientIdLabel = new Label();
            appointmentID = new DataGridViewTextBoxColumn();
            patientID = new DataGridViewTextBoxColumn();
            doctorID = new DataGridViewTextBoxColumn();
            doctorName = new DataGridViewTextBoxColumn();
            scheduledDate = new DataGridViewTextBoxColumn();
            reason = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)visitDataGridView).BeginInit();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(179, 14);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(139, 19);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Patient Information";
            // 
            // patientNameLabel
            // 
            patientNameLabel.AutoSize = true;
            patientNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patientNameLabel.Location = new Point(162, 45);
            patientNameLabel.Margin = new Padding(2, 0, 2, 0);
            patientNameLabel.Name = "patientNameLabel";
            patientNameLabel.Size = new Size(92, 19);
            patientNameLabel.TabIndex = 1;
            patientNameLabel.Text = "Patient Name";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dobLabel.Location = new Point(431, 45);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(82, 19);
            dobLabel.TabIndex = 2;
            dobLabel.Text = "Patient Dob";
            // 
            // appointmentsDataGridView
            // 
            appointmentsDataGridView.AllowUserToAddRows = false;
            appointmentsDataGridView.AllowUserToDeleteRows = false;
            appointmentsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            appointmentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDataGridView.Columns.AddRange(new DataGridViewColumn[] { appointmentID, patientID, doctorID, doctorName, scheduledDate, reason });
            appointmentsDataGridView.Location = new Point(26, 107);
            appointmentsDataGridView.Margin = new Padding(2, 1, 2, 1);
            appointmentsDataGridView.MultiSelect = false;
            appointmentsDataGridView.Name = "appointmentsDataGridView";
            appointmentsDataGridView.ReadOnly = true;
            appointmentsDataGridView.RowHeadersWidth = 82;
            appointmentsDataGridView.RowTemplate.Height = 41;
            appointmentsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDataGridView.Size = new Size(494, 141);
            appointmentsDataGridView.TabIndex = 3;
            appointmentsDataGridView.CellMouseClick += AppointmentsDataGridView_CellMouseClick;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(26, 82);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(140, 19);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "List of Appointments:";
            // 
            // visitsLabel
            // 
            visitsLabel.AutoSize = true;
            visitsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            visitsLabel.Location = new Point(26, 262);
            visitsLabel.Margin = new Padding(2, 0, 2, 0);
            visitsLabel.Name = "visitsLabel";
            visitsLabel.Size = new Size(294, 19);
            visitsLabel.TabIndex = 6;
            visitsLabel.Text = "Select an Appointment to view the visit details:";
            // 
            // visitDataGridView
            // 
            visitDataGridView.AllowUserToAddRows = false;
            visitDataGridView.AllowUserToDeleteRows = false;
            visitDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            visitDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            visitDataGridView.Location = new Point(26, 286);
            visitDataGridView.Margin = new Padding(2, 1, 2, 1);
            visitDataGridView.Name = "visitDataGridView";
            visitDataGridView.ReadOnly = true;
            visitDataGridView.RowHeadersWidth = 82;
            visitDataGridView.RowTemplate.Height = 41;
            visitDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            visitDataGridView.Size = new Size(494, 141);
            visitDataGridView.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(387, 458);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(81, 22);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patientIdLabel.Location = new Point(26, 45);
            patientIdLabel.Margin = new Padding(2, 0, 2, 0);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(70, 19);
            patientIdLabel.TabIndex = 8;
            patientIdLabel.Text = "Patient ID";
            // 
            // appointmentID
            // 
            appointmentID.HeaderText = "Appointment ID";
            appointmentID.Name = "appointmentID";
            appointmentID.ReadOnly = true;
            // 
            // patientID
            // 
            patientID.HeaderText = "Patient ID";
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
            // scheduledDate
            // 
            scheduledDate.HeaderText = "Scheduled Date";
            scheduledDate.Name = "scheduledDate";
            scheduledDate.ReadOnly = true;
            // 
            // reason
            // 
            reason.HeaderText = "Reason";
            reason.Name = "reason";
            reason.ReadOnly = true;
            // 
            // ViewPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 351);
            Controls.Add(patientIdLabel);
            Controls.Add(cancelButton);
            Controls.Add(visitsLabel);
            Controls.Add(visitDataGridView);
            Controls.Add(nameLabel);
            Controls.Add(appointmentsDataGridView);
            Controls.Add(dobLabel);
            Controls.Add(patientNameLabel);
            Controls.Add(headerLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewPatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Patient Information";
            Load += ViewPatientForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)visitDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label patientNameLabel;
        private Label dobLabel;
        private DataGridView appointmentsDataGridView;
        private Label nameLabel;
        private Label visitsLabel;
        private DataGridView visitDataGridView;
        private Button cancelButton;
        private Label patientIdLabel;
        private DataGridViewTextBoxColumn appointmentID;
        private DataGridViewTextBoxColumn patientID;
        private DataGridViewTextBoxColumn doctorID;
        private DataGridViewTextBoxColumn doctorName;
        private DataGridViewTextBoxColumn scheduledDate;
        private DataGridViewTextBoxColumn reason;
    }
}