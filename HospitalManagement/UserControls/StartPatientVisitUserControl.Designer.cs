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
            this.patientTextBox = new System.Windows.Forms.TextBox();
            this.nurseTextBox = new System.Windows.Forms.TextBox();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.testResultsButton = new System.Windows.Forms.Button();
            this.diagnosisButton = new System.Windows.Forms.Button();
            this.orderTestsButton = new System.Windows.Forms.Button();
            this.routineCheckupButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(135, 140);
            this.patientTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(162, 23);
            this.patientTextBox.TabIndex = 20;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Location = new System.Drawing.Point(135, 103);
            this.nurseTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(162, 23);
            this.nurseTextBox.TabIndex = 19;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(135, 65);
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(162, 23);
            this.doctorTextBox.TabIndex = 18;
            // 
            // testResultsButton
            // 
            this.testResultsButton.AutoSize = true;
            this.testResultsButton.Location = new System.Drawing.Point(209, 239);
            this.testResultsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(111, 25);
            this.testResultsButton.TabIndex = 17;
            this.testResultsButton.Text = "Test Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.AutoSize = true;
            this.diagnosisButton.Location = new System.Drawing.Point(29, 239);
            this.diagnosisButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(111, 25);
            this.diagnosisButton.TabIndex = 16;
            this.diagnosisButton.Text = "Diagnosis";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(209, 191);
            this.orderTestsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(111, 25);
            this.orderTestsButton.TabIndex = 15;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // routineCheckupButton
            // 
            this.routineCheckupButton.AutoSize = true;
            this.routineCheckupButton.Location = new System.Drawing.Point(29, 191);
            this.routineCheckupButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.routineCheckupButton.Name = "routineCheckupButton";
            this.routineCheckupButton.Size = new System.Drawing.Size(111, 25);
            this.routineCheckupButton.TabIndex = 14;
            this.routineCheckupButton.Text = "Routine Checkup";
            this.routineCheckupButton.UseVisualStyleBackColor = true;
            this.routineCheckupButton.Click += new System.EventHandler(this.routineCheckupButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Patient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nurse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doctor:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(75, 21);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(172, 19);
            this.headerLabel.TabIndex = 48;
            this.headerLabel.Text = "Start Patient\'s Visit Form";
            // 
            // StartPatientVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "StartPatientVisitUserControl";
            this.Size = new System.Drawing.Size(377, 296);
            this.ResumeLayout(false);
            this.PerformLayout();

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
