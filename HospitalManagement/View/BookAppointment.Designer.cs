namespace HospitalManagement.View
{
    partial class BookAppointment
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
            this.menuUserControl = new HospitalManagement.UserControls.MenuUserControl();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.reasonTextBox = new System.Windows.Forms.RichTextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.bookButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.bookErrorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuUserControl
            // 
            this.menuUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuUserControl.Location = new System.Drawing.Point(0, 0);
            this.menuUserControl.Name = "menuUserControl";
            this.menuUserControl.Size = new System.Drawing.Size(868, 114);
            this.menuUserControl.TabIndex = 0;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patientLabel.Location = new System.Drawing.Point(113, 131);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(112, 37);
            this.patientLabel.TabIndex = 1;
            this.patientLabel.Text = "Patient: ";
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(333, 122);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(320, 39);
            this.patientTextBox.TabIndex = 2;
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doctorLabel.Location = new System.Drawing.Point(113, 206);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(104, 37);
            this.doctorLabel.TabIndex = 3;
            this.doctorLabel.Text = "Doctor:";
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(333, 197);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(320, 40);
            this.doctorComboBox.TabIndex = 4;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reasonLabel.Location = new System.Drawing.Point(113, 293);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(108, 37);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(333, 284);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(320, 192);
            this.reasonTextBox.TabIndex = 6;
            this.reasonTextBox.Text = "";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(113, 525);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(156, 37);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Select Date:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(333, 525);
            this.datePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(320, 39);
            this.datePicker.TabIndex = 8;
            this.datePicker.Value = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(333, 600);
            this.timePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(320, 39);
            this.timePicker.TabIndex = 9;
            this.timePicker.Value = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(113, 602);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(158, 37);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "Select Time:";
            // 
            // bookButton
            // 
            this.bookButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookButton.Location = new System.Drawing.Point(157, 686);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(150, 46);
            this.bookButton.TabIndex = 11;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(485, 686);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 46);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // bookErrorlabel
            // 
            this.bookErrorlabel.AutoSize = true;
            this.bookErrorlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.bookErrorlabel.Location = new System.Drawing.Point(201, 751);
            this.bookErrorlabel.Name = "bookErrorlabel";
            this.bookErrorlabel.Size = new System.Drawing.Size(165, 32);
            this.bookErrorlabel.TabIndex = 13;
            this.bookErrorlabel.Text = "error message";
            this.bookErrorlabel.Visible = false;
            // 
            // BookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 816);
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
            this.Controls.Add(this.menuUserControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book an Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.MenuUserControl menuUserControl;
        private Label patientLabel;
        private TextBox patientTextBox;
        private Label doctorLabel;
        private ComboBox doctorComboBox;
        private Label reasonLabel;
        private RichTextBox reasonTextBox;
        private Label dateLabel;
        private DateTimePicker datePicker;
        private DateTimePicker timePicker;
        private Label timeLabel;
        private Button bookButton;
        private Button clearButton;
        private Label bookErrorlabel;
    }
}