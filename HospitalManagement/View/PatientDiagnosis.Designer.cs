namespace HospitalManagement.View
{
    partial class PatientDiagnosis
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
            initialDiagnosisRichTextBox = new RichTextBox();
            label1 = new Label();
            finalDiagnosisRichTextBox = new RichTextBox();
            label2 = new Label();
            addButton = new Button();
            cancelButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // initialDiagnosisRichTextBox
            // 
            initialDiagnosisRichTextBox.Location = new Point(107, 65);
            initialDiagnosisRichTextBox.Name = "initialDiagnosisRichTextBox";
            initialDiagnosisRichTextBox.Size = new Size(239, 96);
            initialDiagnosisRichTextBox.TabIndex = 0;
            initialDiagnosisRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Initial Diagnosis:";
            // 
            // finalDiagnosisRichTextBox
            // 
            finalDiagnosisRichTextBox.Location = new Point(107, 209);
            finalDiagnosisRichTextBox.Name = "finalDiagnosisRichTextBox";
            finalDiagnosisRichTextBox.Size = new Size(239, 96);
            finalDiagnosisRichTextBox.TabIndex = 2;
            finalDiagnosisRichTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 184);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Final Diagnosis:";
            // 
            // addButton
            // 
            addButton.Location = new Point(121, 341);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(253, 341);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(156, 316);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 6;
            errorLabel.Text = "label3";
            errorLabel.Visible = false;
            // 
            // PatientDiagnosis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 385);
            Controls.Add(errorLabel);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(finalDiagnosisRichTextBox);
            Controls.Add(label1);
            Controls.Add(initialDiagnosisRichTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientDiagnosis";
            Text = "Patient Diagnosis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox initialDiagnosisRichTextBox;
        private Label label1;
        private RichTextBox finalDiagnosisRichTextBox;
        private Label label2;
        private Button addButton;
        private Button cancelButton;
        private Label errorLabel;
    }
}