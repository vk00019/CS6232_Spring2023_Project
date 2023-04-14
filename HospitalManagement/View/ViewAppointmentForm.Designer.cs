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
            headerLabel = new Label();
            errorLabel = new Label();
            cancelButton = new Button();
            editButton = new Button();
            timeLabel = new Label();
            timePicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            dateLabel = new Label();
            reasonTextBox = new RichTextBox();
            reasonLabel = new Label();
            doctorComboBox = new ComboBox();
            doctorLabel = new Label();
            patientTextBox = new TextBox();
            patientLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(113, 19);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(226, 23);
            headerLabel.TabIndex = 61;
            headerLabel.Text = "View/Edit an Appointment";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(137, 406);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(103, 20);
            errorLabel.TabIndex = 60;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location = new Point(295, 441);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(92, 39);
            cancelButton.TabIndex = 59;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            editButton.Location = new Point(94, 441);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(92, 39);
            editButton.TabIndex = 58;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(66, 359);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(101, 23);
            timeLabel.TabIndex = 57;
            timeLabel.Text = "Select Time:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(201, 357);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            timePicker.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(198, 27);
            timePicker.TabIndex = 56;
            timePicker.Value = new DateTime(2023, 4, 8, 21, 1, 25, 0);
            timePicker.ValueChanged += timePicker_ValueChanged;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(201, 311);
            datePicker.Margin = new Padding(2, 1, 2, 1);
            datePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            datePicker.MinDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(198, 27);
            datePicker.TabIndex = 55;
            datePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(66, 311);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(100, 23);
            dateLabel.TabIndex = 54;
            dateLabel.Text = "Select Date:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Location = new Point(201, 160);
            reasonTextBox.Margin = new Padding(2, 1, 2, 1);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(198, 122);
            reasonTextBox.TabIndex = 53;
            reasonTextBox.Text = "";
            reasonTextBox.TextChanged += reasonTextBox_TextChanged;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(66, 165);
            reasonLabel.Margin = new Padding(2, 0, 2, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(69, 23);
            reasonLabel.TabIndex = 52;
            reasonLabel.Text = "Reason:";
            // 
            // doctorComboBox
            // 
            doctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(201, 105);
            doctorComboBox.Margin = new Padding(2, 1, 2, 1);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(198, 28);
            doctorComboBox.TabIndex = 51;
            doctorComboBox.SelectedIndexChanged += doctorComboBox_SelectedIndexChanged;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            doctorLabel.Location = new Point(66, 112);
            doctorLabel.Margin = new Padding(2, 0, 2, 0);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(66, 23);
            doctorLabel.TabIndex = 50;
            doctorLabel.Text = "Doctor:";
            // 
            // patientTextBox
            // 
            patientTextBox.Location = new Point(201, 59);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.Size = new Size(198, 27);
            patientTextBox.TabIndex = 49;
            patientTextBox.TextChanged += patientTextBox_TextChanged;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patientLabel.Location = new Point(66, 64);
            patientLabel.Margin = new Padding(2, 0, 2, 0);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(72, 23);
            patientLabel.TabIndex = 48;
            patientLabel.Text = "Patient: ";
            // 
            // ViewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 519);
            Controls.Add(headerLabel);
            Controls.Add(errorLabel);
            Controls.Add(cancelButton);
            Controls.Add(editButton);
            Controls.Add(timeLabel);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(dateLabel);
            Controls.Add(reasonTextBox);
            Controls.Add(reasonLabel);
            Controls.Add(doctorComboBox);
            Controls.Add(doctorLabel);
            Controls.Add(patientTextBox);
            Controls.Add(patientLabel);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Appointment";
            Load += ViewAppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
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