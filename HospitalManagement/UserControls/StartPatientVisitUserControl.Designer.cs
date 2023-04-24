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
            this.patientTextBox.Location = new System.Drawing.Point(250, 299);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(297, 39);
            this.patientTextBox.TabIndex = 20;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Location = new System.Drawing.Point(250, 219);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(297, 39);
            this.nurseTextBox.TabIndex = 19;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(250, 139);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(297, 39);
            this.doctorTextBox.TabIndex = 18;
            // 
            // testResultsButton
            // 
            this.testResultsButton.AutoSize = true;
            this.testResultsButton.Location = new System.Drawing.Point(388, 509);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(206, 54);
            this.testResultsButton.TabIndex = 17;
            this.testResultsButton.Text = "Test Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.AutoSize = true;
            this.diagnosisButton.Location = new System.Drawing.Point(54, 509);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(206, 54);
            this.diagnosisButton.TabIndex = 16;
            this.diagnosisButton.Text = "Diagnosis";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(388, 408);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(206, 54);
            this.orderTestsButton.TabIndex = 15;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // routineCheckupButton
            // 
            this.routineCheckupButton.AutoSize = true;
            this.routineCheckupButton.Location = new System.Drawing.Point(54, 408);
            this.routineCheckupButton.Name = "routineCheckupButton";
            this.routineCheckupButton.Size = new System.Drawing.Size(206, 54);
            this.routineCheckupButton.TabIndex = 14;
            this.routineCheckupButton.Text = "Routine Checkup";
            this.routineCheckupButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Patient:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nurse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doctor:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(140, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(336, 37);
            this.headerLabel.TabIndex = 48;
            this.headerLabel.Text = "Start Patient\'s Visit Form";
            // 
            // StartPatientVisitUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
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
            this.Name = "StartPatientVisitUserControl";
            this.Size = new System.Drawing.Size(700, 632);
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
