namespace HospitalManagement.UserControls
{
    partial class BookAppointmentUserControl
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
            clearButton = new Button();
            bookButton = new Button();
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
            errorLabel = new Label();
            headerLabel = new Label();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(305, 438);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(92, 39);
            clearButton.TabIndex = 25;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // bookButton
            // 
            bookButton.AutoSize = true;
            bookButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bookButton.Location = new Point(103, 438);
            bookButton.Margin = new Padding(2, 1, 2, 1);
            bookButton.Name = "bookButton";
            bookButton.Size = new Size(92, 39);
            bookButton.TabIndex = 24;
            bookButton.Text = "Book";
            bookButton.UseVisualStyleBackColor = true;
            bookButton.Click += bookButton_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(76, 356);
            timeLabel.Margin = new Padding(2, 0, 2, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(101, 23);
            timeLabel.TabIndex = 23;
            timeLabel.Text = "Select Time:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(210, 354);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            timePicker.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(198, 27);
            timePicker.TabIndex = 22;
            timePicker.Value = new DateTime(2023, 4, 8, 21, 1, 25, 0);
            timePicker.ValueChanged += timePicker_ValueChanged;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(210, 308);
            datePicker.Margin = new Padding(2, 1, 2, 1);
            datePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            datePicker.MinDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(198, 27);
            datePicker.TabIndex = 21;
            datePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(76, 308);
            dateLabel.Margin = new Padding(2, 0, 2, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(100, 23);
            dateLabel.TabIndex = 20;
            dateLabel.Text = "Select Date:";
            // 
            // reasonTextBox
            // 
            reasonTextBox.Location = new Point(210, 158);
            reasonTextBox.Margin = new Padding(2, 1, 2, 1);
            reasonTextBox.Name = "reasonTextBox";
            reasonTextBox.Size = new Size(198, 122);
            reasonTextBox.TabIndex = 19;
            reasonTextBox.Text = "";
            reasonTextBox.TextChanged += reasonTextBox_TextChanged;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reasonLabel.Location = new Point(76, 162);
            reasonLabel.Margin = new Padding(2, 0, 2, 0);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new Size(69, 23);
            reasonLabel.TabIndex = 18;
            reasonLabel.Text = "Reason:";
            // 
            // doctorComboBox
            // 
            doctorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(210, 102);
            doctorComboBox.Margin = new Padding(2, 1, 2, 1);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(198, 28);
            doctorComboBox.TabIndex = 17;
            doctorComboBox.SelectedIndexChanged += doctorComboBox_SelectedIndexChanged;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            doctorLabel.Location = new Point(76, 109);
            doctorLabel.Margin = new Padding(2, 0, 2, 0);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(66, 23);
            doctorLabel.TabIndex = 16;
            doctorLabel.Text = "Doctor:";
            // 
            // patientTextBox
            // 
            patientTextBox.Location = new Point(210, 56);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.Size = new Size(198, 27);
            patientTextBox.TabIndex = 15;
            patientTextBox.TextChanged += patientTextBox_TextChanged;
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patientLabel.Location = new Point(76, 61);
            patientLabel.Margin = new Padding(2, 0, 2, 0);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new Size(94, 23);
            patientLabel.TabIndex = 14;
            patientLabel.Text = "Patient ID: ";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(146, 404);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(103, 20);
            errorLabel.TabIndex = 27;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(122, 16);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(235, 23);
            headerLabel.TabIndex = 47;
            headerLabel.Text = "Book an Appointment Form";
            // 
            // BookAppointmentUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(headerLabel);
            Controls.Add(errorLabel);
            Controls.Add(clearButton);
            Controls.Add(bookButton);
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
            Name = "BookAppointmentUserControl";
            Size = new Size(482, 510);
            Load += BookAppointmentUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearButton;
        private Button bookButton;
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
        private Label errorLabel;
        private Label headerLabel;
    }
}
