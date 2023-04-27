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
            SuspendLayout();
            // 
            // patientTextBox
            // 
            patientTextBox.Location = new Point(154, 187);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.ReadOnly = true;
            patientTextBox.Size = new Size(185, 27);
            patientTextBox.TabIndex = 20;
            // 
            // nurseTextBox
            // 
            nurseTextBox.Location = new Point(154, 137);
            nurseTextBox.Margin = new Padding(2, 1, 2, 1);
            nurseTextBox.Name = "nurseTextBox";
            nurseTextBox.ReadOnly = true;
            nurseTextBox.Size = new Size(185, 27);
            nurseTextBox.TabIndex = 19;
            // 
            // doctorTextBox
            // 
            doctorTextBox.Location = new Point(154, 85);
            doctorTextBox.Margin = new Padding(2, 1, 2, 1);
            doctorTextBox.Name = "doctorTextBox";
            doctorTextBox.ReadOnly = true;
            doctorTextBox.Size = new Size(185, 27);
            doctorTextBox.TabIndex = 18;
            // 
            // testResultsButton
            // 
            testResultsButton.AutoSize = true;
            testResultsButton.Location = new Point(239, 319);
            testResultsButton.Margin = new Padding(2, 1, 2, 1);
            testResultsButton.Name = "testResultsButton";
            testResultsButton.Size = new Size(127, 33);
            testResultsButton.TabIndex = 17;
            testResultsButton.Text = "Test Results";
            testResultsButton.UseVisualStyleBackColor = true;
            testResultsButton.Click += testResultsButton_Click;
            // 
            // diagnosisButton
            // 
            diagnosisButton.AutoSize = true;
            diagnosisButton.Location = new Point(33, 319);
            diagnosisButton.Margin = new Padding(2, 1, 2, 1);
            diagnosisButton.Name = "diagnosisButton";
            diagnosisButton.Size = new Size(127, 33);
            diagnosisButton.TabIndex = 16;
            diagnosisButton.Text = "Diagnosis";
            diagnosisButton.UseVisualStyleBackColor = true;
            diagnosisButton.Click += diagnosisButton_Click;
            // 
            // orderTestsButton
            // 
            orderTestsButton.AutoSize = true;
            orderTestsButton.Location = new Point(239, 255);
            orderTestsButton.Margin = new Padding(2, 1, 2, 1);
            orderTestsButton.Name = "orderTestsButton";
            orderTestsButton.Size = new Size(127, 33);
            orderTestsButton.TabIndex = 15;
            orderTestsButton.Text = "Order Tests";
            orderTestsButton.UseVisualStyleBackColor = true;
            orderTestsButton.Click += orderTestsButton_Click;
            // 
            // routineCheckupButton
            // 
            routineCheckupButton.AutoSize = true;
            routineCheckupButton.Location = new Point(33, 255);
            routineCheckupButton.Margin = new Padding(2, 1, 2, 1);
            routineCheckupButton.Name = "routineCheckupButton";
            routineCheckupButton.Size = new Size(130, 33);
            routineCheckupButton.TabIndex = 14;
            routineCheckupButton.Text = "Routine Checkup";
            routineCheckupButton.UseVisualStyleBackColor = true;
            routineCheckupButton.Click += routineCheckupButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 189);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 13;
            label3.Text = "Patient:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "Nurse:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 11;
            label1.Text = "Doctor:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(86, 28);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(210, 23);
            headerLabel.TabIndex = 48;
            headerLabel.Text = "Start Patient's Visit Form";
            // 
            // StartPatientVisitUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(432, 422);
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
    }
}
