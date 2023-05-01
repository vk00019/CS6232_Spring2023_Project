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
            this.headerLabel = new System.Windows.Forms.Label();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduledDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLabel = new System.Windows.Forms.Label();
            this.visitsLabel = new System.Windows.Forms.Label();
            this.visitDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.patientIdLabel = new System.Windows.Forms.Label();
            this.visitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysBp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diBp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pulse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(332, 30);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(271, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Patient Information";
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientNameLabel.Location = new System.Drawing.Point(301, 96);
            this.patientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(177, 37);
            this.patientNameLabel.TabIndex = 1;
            this.patientNameLabel.Text = "Patient Name";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dobLabel.Location = new System.Drawing.Point(800, 96);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(157, 37);
            this.dobLabel.TabIndex = 2;
            this.dobLabel.Text = "Patient Dob";
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
            this.scheduledDate,
            this.reason});
            this.appointmentsDataGridView.Location = new System.Drawing.Point(48, 228);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.appointmentsDataGridView.MultiSelect = false;
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.ReadOnly = true;
            this.appointmentsDataGridView.RowHeadersWidth = 82;
            this.appointmentsDataGridView.RowTemplate.Height = 41;
            this.appointmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(917, 301);
            this.appointmentsDataGridView.TabIndex = 3;
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
            this.patientID.HeaderText = "Patient ID";
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
            // scheduledDate
            // 
            this.scheduledDate.HeaderText = "Scheduled Date";
            this.scheduledDate.MinimumWidth = 10;
            this.scheduledDate.Name = "scheduledDate";
            this.scheduledDate.ReadOnly = true;
            this.scheduledDate.Width = 200;
            // 
            // reason
            // 
            this.reason.HeaderText = "Reason";
            this.reason.MinimumWidth = 10;
            this.reason.Name = "reason";
            this.reason.ReadOnly = true;
            this.reason.Width = 200;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(48, 175);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(269, 37);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "List of Appointments:";
            // 
            // visitsLabel
            // 
            this.visitsLabel.AutoSize = true;
            this.visitsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visitsLabel.Location = new System.Drawing.Point(48, 559);
            this.visitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visitsLabel.Name = "visitsLabel";
            this.visitsLabel.Size = new System.Drawing.Size(570, 37);
            this.visitsLabel.TabIndex = 6;
            this.visitsLabel.Text = "Select an Appointment to view the visit details:";
            // 
            // visitDataGridView
            // 
            this.visitDataGridView.AllowUserToAddRows = false;
            this.visitDataGridView.AllowUserToDeleteRows = false;
            this.visitDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitId,
            this.height,
            this.weight,
            this.sysBp,
            this.diBp,
            this.bodyTemp,
            this.pulse,
            this.symptoms,
            this.initialDiagnosis,
            this.finalDiagnosis});
            this.visitDataGridView.Location = new System.Drawing.Point(48, 610);
            this.visitDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.visitDataGridView.Name = "visitDataGridView";
            this.visitDataGridView.ReadOnly = true;
            this.visitDataGridView.RowHeadersWidth = 82;
            this.visitDataGridView.RowTemplate.Height = 41;
            this.visitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitDataGridView.Size = new System.Drawing.Size(917, 301);
            this.visitDataGridView.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(719, 977);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 47);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // patientIdLabel
            // 
            this.patientIdLabel.AutoSize = true;
            this.patientIdLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientIdLabel.Location = new System.Drawing.Point(48, 96);
            this.patientIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientIdLabel.Name = "patientIdLabel";
            this.patientIdLabel.Size = new System.Drawing.Size(132, 37);
            this.patientIdLabel.TabIndex = 8;
            this.patientIdLabel.Text = "Patient ID";
            // 
            // visitId
            // 
            this.visitId.HeaderText = "Visit Id";
            this.visitId.MinimumWidth = 10;
            this.visitId.Name = "visitId";
            this.visitId.ReadOnly = true;
            this.visitId.Width = 200;
            // 
            // height
            // 
            this.height.HeaderText = "Height";
            this.height.MinimumWidth = 10;
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Width = 200;
            // 
            // weight
            // 
            this.weight.HeaderText = "Weight";
            this.weight.MinimumWidth = 10;
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 200;
            // 
            // sysBp
            // 
            this.sysBp.HeaderText = "Systolic BP";
            this.sysBp.MinimumWidth = 10;
            this.sysBp.Name = "sysBp";
            this.sysBp.ReadOnly = true;
            this.sysBp.Width = 200;
            // 
            // diBp
            // 
            this.diBp.HeaderText = "Diastolic BP";
            this.diBp.MinimumWidth = 10;
            this.diBp.Name = "diBp";
            this.diBp.ReadOnly = true;
            this.diBp.Width = 200;
            // 
            // bodyTemp
            // 
            this.bodyTemp.HeaderText = "Body Temperature";
            this.bodyTemp.MinimumWidth = 10;
            this.bodyTemp.Name = "bodyTemp";
            this.bodyTemp.ReadOnly = true;
            this.bodyTemp.Width = 200;
            // 
            // pulse
            // 
            this.pulse.HeaderText = "Pulse";
            this.pulse.MinimumWidth = 10;
            this.pulse.Name = "pulse";
            this.pulse.ReadOnly = true;
            this.pulse.Width = 200;
            // 
            // symptoms
            // 
            this.symptoms.HeaderText = "Symptoms";
            this.symptoms.MinimumWidth = 10;
            this.symptoms.Name = "symptoms";
            this.symptoms.ReadOnly = true;
            this.symptoms.Width = 200;
            // 
            // initialDiagnosis
            // 
            this.initialDiagnosis.HeaderText = "Initial Diagnosis";
            this.initialDiagnosis.MinimumWidth = 10;
            this.initialDiagnosis.Name = "initialDiagnosis";
            this.initialDiagnosis.ReadOnly = true;
            this.initialDiagnosis.Width = 200;
            // 
            // finalDiagnosis
            // 
            this.finalDiagnosis.HeaderText = "Final Diagnosis";
            this.finalDiagnosis.MinimumWidth = 10;
            this.finalDiagnosis.Name = "finalDiagnosis";
            this.finalDiagnosis.ReadOnly = true;
            this.finalDiagnosis.Width = 200;
            // 
            // ViewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 1061);
            this.Controls.Add(this.patientIdLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.visitsLabel);
            this.Controls.Add(this.visitDataGridView);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patient Information";
            this.Load += new System.EventHandler(this.ViewPatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn visitId;
        private DataGridViewTextBoxColumn height;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn sysBp;
        private DataGridViewTextBoxColumn diBp;
        private DataGridViewTextBoxColumn bodyTemp;
        private DataGridViewTextBoxColumn pulse;
        private DataGridViewTextBoxColumn symptoms;
        private DataGridViewTextBoxColumn initialDiagnosis;
        private DataGridViewTextBoxColumn finalDiagnosis;
    }
}