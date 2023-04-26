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
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nurse:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient:";
            // 
            // routineCheckupButton
            // 
            this.routineCheckupButton.AutoSize = true;
            this.routineCheckupButton.Location = new System.Drawing.Point(52, 379);
            this.routineCheckupButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.routineCheckupButton.Name = "routineCheckupButton";
            this.routineCheckupButton.Size = new System.Drawing.Size(206, 53);
            this.routineCheckupButton.TabIndex = 4;
            this.routineCheckupButton.Text = "Routine Checkup";
            this.routineCheckupButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(357, 379);
            this.orderTestsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(206, 53);
            this.orderTestsButton.TabIndex = 5;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.AutoSize = true;
            this.diagnosisButton.Location = new System.Drawing.Point(52, 479);
            this.diagnosisButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(206, 53);
            this.diagnosisButton.TabIndex = 6;
            this.diagnosisButton.Text = "Diagnosis";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // testResultsButton
            // 
            this.testResultsButton.AutoSize = true;
            this.testResultsButton.Location = new System.Drawing.Point(357, 479);
            this.testResultsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(206, 53);
            this.testResultsButton.TabIndex = 7;
            this.testResultsButton.Text = "Test Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(227, 115);
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(297, 39);
            this.doctorTextBox.TabIndex = 8;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Location = new System.Drawing.Point(227, 194);
            this.nurseTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(297, 39);
            this.nurseTextBox.TabIndex = 9;
            // 
            // patientTextBox
            // 
            this.patientTextBox.Location = new System.Drawing.Point(227, 275);
            this.patientTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(297, 39);
            this.patientTextBox.TabIndex = 10;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(215, 564);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 53);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 662);
            this.Controls.Add(this.cancelButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button cancelButton;
    }
}