namespace HospitalManagement.View
{
    partial class VisitForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            routineCheckupButton = new Button();
            orderTestsButton = new Button();
            diagnosisButton = new Button();
            testResultsButton = new Button();
            doctorTextBox = new TextBox();
            nurseTextBox = new TextBox();
            patientTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Doctor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Nurse:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "Patient:";
            // 
            // routineCheckupButton
            // 
            routineCheckupButton.AutoSize = true;
            routineCheckupButton.Location = new Point(68, 185);
            routineCheckupButton.Margin = new Padding(2, 1, 2, 1);
            routineCheckupButton.Name = "routineCheckupButton";
            routineCheckupButton.Size = new Size(111, 25);
            routineCheckupButton.TabIndex = 4;
            routineCheckupButton.Text = "Routine Checkup";
            routineCheckupButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            orderTestsButton.AutoSize = true;
            orderTestsButton.Location = new Point(248, 185);
            orderTestsButton.Margin = new Padding(2, 1, 2, 1);
            orderTestsButton.Name = "orderTestsButton";
            orderTestsButton.Size = new Size(111, 25);
            orderTestsButton.TabIndex = 5;
            orderTestsButton.Text = "Order Tests";
            orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            diagnosisButton.AutoSize = true;
            diagnosisButton.Location = new Point(68, 232);
            diagnosisButton.Margin = new Padding(2, 1, 2, 1);
            diagnosisButton.Name = "diagnosisButton";
            diagnosisButton.Size = new Size(111, 25);
            diagnosisButton.TabIndex = 6;
            diagnosisButton.Text = "Diagnosis";
            diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // testResultsButton
            // 
            testResultsButton.AutoSize = true;
            testResultsButton.Location = new Point(248, 232);
            testResultsButton.Margin = new Padding(2, 1, 2, 1);
            testResultsButton.Name = "testResultsButton";
            testResultsButton.Size = new Size(111, 25);
            testResultsButton.TabIndex = 7;
            testResultsButton.Text = "Test Results";
            testResultsButton.UseVisualStyleBackColor = true;
            // 
            // doctorTextBox
            // 
            doctorTextBox.Location = new Point(122, 54);
            doctorTextBox.Margin = new Padding(2, 1, 2, 1);
            doctorTextBox.Name = "doctorTextBox";
            doctorTextBox.Size = new Size(162, 23);
            doctorTextBox.TabIndex = 8;
            // 
            // nurseTextBox
            // 
            nurseTextBox.Location = new Point(122, 91);
            nurseTextBox.Margin = new Padding(2, 1, 2, 1);
            nurseTextBox.Name = "nurseTextBox";
            nurseTextBox.Size = new Size(162, 23);
            nurseTextBox.TabIndex = 9;
            // 
            // patientTextBox
            // 
            patientTextBox.Location = new Point(122, 129);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.Size = new Size(162, 23);
            patientTextBox.TabIndex = 10;
            // 
            // VisitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 285);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VisitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visit Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button routineCheckupButton;
        private Button orderTestsButton;
        private Button diagnosisButton;
        private Button testResultsButton;
        private TextBox doctorTextBox;
        private TextBox nurseTextBox;
        private TextBox patientTextBox;
    }
}