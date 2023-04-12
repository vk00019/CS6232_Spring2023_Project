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
            this.clearButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
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
            this.bookErrorlabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(495, 701);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 62);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // bookButton
            // 
            this.bookButton.AutoSize = true;
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookButton.Location = new System.Drawing.Point(168, 701);
            this.bookButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(150, 62);
            this.bookButton.TabIndex = 24;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(123, 570);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(158, 37);
            this.timeLabel.TabIndex = 23;
            this.timeLabel.Text = "Select Time:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(342, 567);
            this.timePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.timePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(320, 39);
            this.timePicker.TabIndex = 22;
            this.timePicker.Value = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(342, 493);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.datePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(320, 39);
            this.datePicker.TabIndex = 21;
            this.datePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(123, 493);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(156, 37);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "Select Date:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(342, 252);
            this.reasonTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(320, 192);
            this.reasonTextBox.TabIndex = 19;
            this.reasonTextBox.Text = "";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.Location = new System.Drawing.Point(123, 260);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(108, 37);
            this.reasonLabel.TabIndex = 18;
            this.reasonLabel.Text = "Reason:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(342, 164);
            this.doctorComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(320, 40);
            this.doctorComboBox.TabIndex = 17;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.Location = new System.Drawing.Point(123, 175);
            this.doctorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(104, 37);
            this.doctorLabel.TabIndex = 16;
            this.doctorLabel.Text = "Doctor:";
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(342, 90);
            this.patientTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(320, 39);
            this.patientTextBox.TabIndex = 15;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientLabel.Location = new System.Drawing.Point(123, 98);
            this.patientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(112, 37);
            this.patientLabel.TabIndex = 14;
            this.patientLabel.Text = "Patient: ";
            // 
            // bookErrorlabel
            // 
            this.bookErrorlabel.AutoSize = true;
            this.bookErrorlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.bookErrorlabel.Location = new System.Drawing.Point(238, 646);
            this.bookErrorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookErrorlabel.Name = "bookErrorlabel";
            this.bookErrorlabel.Size = new System.Drawing.Size(165, 32);
            this.bookErrorlabel.TabIndex = 27;
            this.bookErrorlabel.Text = "error message";
            this.bookErrorlabel.Visible = false;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(198, 26);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(374, 37);
            this.headerLabel.TabIndex = 47;
            this.headerLabel.Text = "Book an Appointment Form";
            // 
            // BookAppointmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.bookErrorlabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.bookButton);
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
            this.Name = "BookAppointmentUserControl";
            this.Size = new System.Drawing.Size(784, 816);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label bookErrorlabel;
        private Label headerLabel;
    }
}
