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
            this.patientTextBox.Location = new System.Drawing.Point(251, 299);
            this.patientTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.patientTextBox.Name = "patientTextBox";
            this.patientTextBox.Size = new System.Drawing.Size(297, 39);
            this.patientTextBox.TabIndex = 20;
            patientTextBox.Location = new Point(135, 140);
            patientTextBox.Margin = new Padding(2, 1, 2, 1);
            patientTextBox.Name = "patientTextBox";
            patientTextBox.ReadOnly = true;
            patientTextBox.Size = new Size(162, 23);
            patientTextBox.TabIndex = 20;
            // 
            // nurseTextBox
            // 
            this.nurseTextBox.Location = new System.Drawing.Point(251, 220);
            this.nurseTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nurseTextBox.Name = "nurseTextBox";
            this.nurseTextBox.Size = new System.Drawing.Size(297, 39);
            this.nurseTextBox.TabIndex = 19;
            nurseTextBox.Location = new Point(135, 103);
            nurseTextBox.Margin = new Padding(2, 1, 2, 1);
            nurseTextBox.Name = "nurseTextBox";
            nurseTextBox.ReadOnly = true;
            nurseTextBox.Size = new Size(162, 23);
            nurseTextBox.TabIndex = 19;
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Location = new System.Drawing.Point(251, 139);
            this.doctorTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(297, 39);
            this.doctorTextBox.TabIndex = 18;
            doctorTextBox.Location = new Point(135, 65);
            doctorTextBox.Margin = new Padding(2, 1, 2, 1);
            doctorTextBox.Name = "doctorTextBox";
            doctorTextBox.ReadOnly = true;
            doctorTextBox.Size = new Size(162, 23);
            doctorTextBox.TabIndex = 18;
            // 
            // testResultsButton
            // 
            this.testResultsButton.AutoSize = true;
            this.testResultsButton.Location = new System.Drawing.Point(388, 510);
            this.testResultsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.testResultsButton.Name = "testResultsButton";
            this.testResultsButton.Size = new System.Drawing.Size(206, 53);
            this.testResultsButton.TabIndex = 17;
            this.testResultsButton.Text = "Test Results";
            this.testResultsButton.UseVisualStyleBackColor = true;
            this.testResultsButton.Click += new System.EventHandler(this.testResultsButton_Click);
            testResultsButton.AutoSize = true;
            testResultsButton.Location = new Point(209, 239);
            testResultsButton.Margin = new Padding(2, 1, 2, 1);
            testResultsButton.Name = "testResultsButton";
            testResultsButton.Size = new Size(111, 25);
            testResultsButton.TabIndex = 17;
            testResultsButton.Text = "Test Results";
            testResultsButton.UseVisualStyleBackColor = true;
            // 
            // diagnosisButton
            // 
            this.diagnosisButton.AutoSize = true;
            this.diagnosisButton.Location = new System.Drawing.Point(54, 510);
            this.diagnosisButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.diagnosisButton.Name = "diagnosisButton";
            this.diagnosisButton.Size = new System.Drawing.Size(206, 53);
            this.diagnosisButton.TabIndex = 16;
            this.diagnosisButton.Text = "Diagnosis";
            this.diagnosisButton.UseVisualStyleBackColor = true;
            diagnosisButton.AutoSize = true;
            diagnosisButton.Location = new Point(29, 239);
            diagnosisButton.Margin = new Padding(2, 1, 2, 1);
            diagnosisButton.Name = "diagnosisButton";
            diagnosisButton.Size = new Size(111, 25);
            diagnosisButton.TabIndex = 16;
            diagnosisButton.Text = "Diagnosis";
            diagnosisButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(388, 407);
            this.orderTestsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(206, 53);
            this.orderTestsButton.TabIndex = 15;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            this.orderTestsButton.Click += new System.EventHandler(this.orderTestsButton_Click);
            orderTestsButton.AutoSize = true;
            orderTestsButton.Location = new Point(209, 191);
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
            this.routineCheckupButton.AutoSize = true;
            this.routineCheckupButton.Location = new System.Drawing.Point(54, 407);
            this.routineCheckupButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.routineCheckupButton.Name = "routineCheckupButton";
            this.routineCheckupButton.Size = new System.Drawing.Size(206, 53);
            this.routineCheckupButton.TabIndex = 14;
            this.routineCheckupButton.Text = "Routine Checkup";
            this.routineCheckupButton.UseVisualStyleBackColor = true;
            this.routineCheckupButton.Click += new System.EventHandler(this.routineCheckupButton_Click);
            routineCheckupButton.AutoSize = true;
            routineCheckupButton.Location = new Point(29, 191);
            routineCheckupButton.Margin = new Padding(2, 1, 2, 1);
            routineCheckupButton.Name = "routineCheckupButton";
            routineCheckupButton.Size = new Size(111, 25);
            routineCheckupButton.TabIndex = 14;
            routineCheckupButton.Text = "Routine Checkup";
            routineCheckupButton.UseVisualStyleBackColor = true;
            routineCheckupButton.Click += routineCheckupButton_Click;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Patient:";
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nurse:";
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doctor:";
            label1.AutoSize = true;
            label1.Location = new Point(41, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 11;
            label1.Text = "Doctor:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(139, 45);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(336, 37);
            this.headerLabel.TabIndex = 48;
            this.headerLabel.Text = "Start Patient\'s Visit Form";
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(75, 21);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(172, 19);
            headerLabel.TabIndex = 48;
            headerLabel.Text = "Start Patient's Visit Form";
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "StartPatientVisitUserControl";
            this.Size = new System.Drawing.Size(700, 631);
            this.Load += new System.EventHandler(this.StartPatientVisitUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Size = new Size(377, 296);
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
