namespace HospitalManagement.View
{
    partial class Visit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.routineCheckupButton = new System.Windows.Forms.Button();
            this.orderTestsButton = new System.Windows.Forms.Button();
            this.diagnosisButton = new System.Windows.Forms.Button();
            this.testResultsButton = new System.Windows.Forms.Button();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.nurseTextBox = new System.Windows.Forms.TextBox();
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nurse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient:";
            // 
            // routineCheckupButton
            // 
            this.routineCheckupButton.AutoSize = true;
            this.routineCheckupButton.Location = new System.Drawing.Point(127, 394);
            this.routineCheckupButton.Name = "routineCheckupButton";
            this.routineCheckupButton.Size = new System.Drawing.Size(206, 54);
            this.routineCheckupButton.TabIndex = 4;
            this.routineCheckupButton.Text = "Routine Checkup";
            this.routineCheckupButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(461, 394);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(206, 54);
            this.orderTestsButton.TabIndex = 5;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.AutoSize = true;
            this.diagnosisButton.Location = new System.Drawing.Point(127, 495);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(206, 54);
            this.diagnosisButton.TabIndex = 6;
            this.diagnosisButton.Text = "Diagnosis";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // testResultsButton
            // 
            this.testResultsButton.AutoSize = true;
            this.testResultsButton.Location = new System.Drawing.Point(461, 495);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(206, 54);
            this.testResultsButton.TabIndex = 7;
            this.testResultsButton.Text = "Test Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(227, 115);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(297, 39);
            this.doctorTextBox.TabIndex = 8;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Location = new System.Drawing.Point(227, 195);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(297, 39);
            this.nurseTextBox.TabIndex = 9;
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(227, 275);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(297, 39);
            this.patientTextBox.TabIndex = 10;
            // 
            // Visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.patientTextBox);
            this.Controls.Add(this.nurseTextBox);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.testResultsButton);
            this.Controls.Add(this.diagnosisButton);
            this.Controls.Add(this.orderTestsButton);
            this.Controls.Add(this.routineCheckupButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Visit";
            this.Text = "Visit Information";
            this.ResumeLayout(false);
            this.PerformLayout();

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