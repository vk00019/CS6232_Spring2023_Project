namespace HospitalManagement.View
{
    partial class ViewAppointmentForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.RichTextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(184, 30);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(359, 37);
            this.headerLabel.TabIndex = 61;
            this.headerLabel.Text = "View/Edit an Appointment";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(223, 650);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(165, 32);
            this.errorLabel.TabIndex = 60;
            this.errorLabel.Text = "error message";
            this.errorLabel.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(479, 706);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 62);
            this.cancelButton.TabIndex = 59;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(153, 706);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(150, 62);
            this.editButton.TabIndex = 58;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(107, 574);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(158, 37);
            this.timeLabel.TabIndex = 57;
            this.timeLabel.Text = "Select Time:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(327, 571);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(319, 39);
            this.timePicker.TabIndex = 56;
            this.timePicker.Value = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            this.timePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(327, 498);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(319, 39);
            this.datePicker.TabIndex = 55;
            this.datePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(107, 498);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(156, 37);
            this.dateLabel.TabIndex = 54;
            this.dateLabel.Text = "Select Date:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(327, 256);
            this.reasonTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(319, 193);
            this.reasonTextBox.TabIndex = 53;
            this.reasonTextBox.Text = "";
            this.reasonTextBox.TextChanged += new System.EventHandler(this.ReasonTextBox_TextChanged);
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.Location = new System.Drawing.Point(107, 264);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(108, 37);
            this.reasonLabel.TabIndex = 52;
            this.reasonLabel.Text = "Reason:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(327, 168);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(319, 40);
            this.doctorComboBox.TabIndex = 51;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.DoctorComboBox_SelectedIndexChanged);
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.Location = new System.Drawing.Point(107, 179);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(104, 37);
            this.doctorLabel.TabIndex = 50;
            this.doctorLabel.Text = "Doctor:";
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(327, 94);
            this.patientTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(319, 39);
            this.patientTextBox.TabIndex = 49;
            this.patientTextBox.TextChanged += new System.EventHandler(this.PatientTextBox_TextChanged);
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientLabel.Location = new System.Drawing.Point(107, 102);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(112, 37);
            this.patientLabel.TabIndex = 48;
            this.patientLabel.Text = "Patient: ";
            // 
            // ViewAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 830);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(this.doctorLabel);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(this.patientLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Appointment";
            this.Load += new System.EventHandler(this.ViewAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label errorLabel;
        private Button cancelButton;
        private Button editButton;
        private Label timeLabel;
        private DateTimePicker timePicker;
        private DateTimePicker datePicker;
        private Label dateLabel;
        private RichTextBox reasonTextBox;
        private Label reasonLabel;
        private ComboBox doctorComboBox;
        private Label doctorLabel;
        private TextBox patientTextBox;
        private Label patientLabel;
    }
}