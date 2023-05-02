namespace HospitalManagement.UserControls
{
    partial class StartPatientVisitUserControl
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
            patientTextBox = new TextBox();
            nurseTextBox = new TextBox();
            doctorTextBox = new TextBox();
            testResultsButton = new Button();
            diagnosisButton = new Button();
            orderTestsButton = new Button();
            routineCheckupButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            headerLabel = new Label();
            patientDOBTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // patientTextBox
            // 
            patientTextBox.Location = new Point(135, 140);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.ReadOnly = true;
            patientTextBox.Size = new Size(162, 23);
            patientTextBox.TabIndex = 20;
            // 
            // nurseTextBox
            // 
            nurseTextBox.Location = new Point(135, 103);
            nurseTextBox.Margin = new Padding(2, 1, 2, 1);
            nurseTextBox.Name = "nurseTextBox";
            nurseTextBox.ReadOnly = true;
            nurseTextBox.Size = new Size(162, 23);
            nurseTextBox.TabIndex = 19;
            // 
            // doctorTextBox
            // 
            doctorTextBox.Location = new Point(135, 64);
            doctorTextBox.Margin = new Padding(2, 1, 2, 1);
            doctorTextBox.Name = "doctorTextBox";
            doctorTextBox.ReadOnly = true;
            doctorTextBox.Size = new Size(162, 23);
            doctorTextBox.TabIndex = 18;
            // 
            // testResultsButton
            // 
            testResultsButton.AutoSize = true;
            testResultsButton.Location = new Point(209, 270);
            testResultsButton.Margin = new Padding(2, 1, 2, 1);
            testResultsButton.Name = "testResultsButton";
            testResultsButton.Size = new Size(111, 25);
            testResultsButton.TabIndex = 17;
            testResultsButton.Text = "Test Results";
            testResultsButton.UseVisualStyleBackColor = true;
            testResultsButton.Click += testResultsButton_Click;
            // 
            // diagnosisButton
            // 
            diagnosisButton.AutoSize = true;
            diagnosisButton.Location = new Point(29, 270);
            diagnosisButton.Margin = new Padding(2, 1, 2, 1);
            diagnosisButton.Name = "diagnosisButton";
            diagnosisButton.Size = new Size(111, 25);
            diagnosisButton.TabIndex = 16;
            diagnosisButton.Text = "Diagnosis";
            diagnosisButton.UseVisualStyleBackColor = true;
            diagnosisButton.Click += diagnosisButton_Click;
            // 
            // orderTestsButton
            // 
            orderTestsButton.AutoSize = true;
            orderTestsButton.Location = new Point(209, 222);
            orderTestsButton.Margin = new Padding(2, 1, 2, 1);
            orderTestsButton.Name = "orderTestsButton";
            orderTestsButton.Size = new Size(111, 25);
            orderTestsButton.TabIndex = 15;
            orderTestsButton.Text = "Order Tests";
            orderTestsButton.UseVisualStyleBackColor = true;
            orderTestsButton.Click += orderTestsButton_Click;
            // 
            // routineCheckupButton
            // 
            routineCheckupButton.AutoSize = true;
            routineCheckupButton.Location = new Point(29, 222);
            routineCheckupButton.Margin = new Padding(2, 1, 2, 1);
            routineCheckupButton.Name = "routineCheckupButton";
            routineCheckupButton.Size = new Size(114, 25);
            routineCheckupButton.TabIndex = 14;
            routineCheckupButton.Text = "Routine Checkup";
            routineCheckupButton.UseVisualStyleBackColor = true;
            routineCheckupButton.Click += routineCheckupButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 142);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 13;
            label3.Text = "Patient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 12;
            label2.Text = "Nurse:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 11;
            label1.Text = "Doctor:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(75, 21);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(172, 19);
            headerLabel.TabIndex = 48;
            headerLabel.Text = "Start Patient's Visit Form";
            // 
            // patientDOBTextBox
            // 
            patientDOBTextBox.Location = new Point(135, 178);
            patientDOBTextBox.Margin = new Padding(2, 1, 2, 1);
            patientDOBTextBox.Name = "patientDOBTextBox";
            patientDOBTextBox.ReadOnly = true;
            patientDOBTextBox.Size = new Size(162, 23);
            patientDOBTextBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 49;
            label4.Text = "Patient DOB:";
            // 
            // StartPatientVisitUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(patientDOBTextBox);
            Controls.Add(label4);
            Controls.Add(headerLabel);
            Controls.Add(patientTextBox);
            Controls.Add(nurseTextBox);
            Controls.Add(doctorTextBox);
            Controls.Add(testResultsButton);
            Controls.Add(diagnosisButton);
            Controls.Add(orderTestsButton);
            Controls.Add(routineCheckupButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "StartPatientVisitUserControl";
            Size = new Size(378, 316);
            Load += StartPatientVisitUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox patientTextBox;
        private TextBox nurseTextBox;
        private TextBox doctorTextBox;
        private Button testResultsButton;
        private Button diagnosisButton;
        private Button orderTestsButton;
        private Button routineCheckupButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label headerLabel;
        private TextBox patientDOBTextBox;
        private Label label4;
    }
}
