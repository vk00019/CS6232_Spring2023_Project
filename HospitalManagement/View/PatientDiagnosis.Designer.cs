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
            this.initialDiagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finalDiagnosisRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // initialDiagnosisRichTextBox
            // 
            this.initialDiagnosisRichTextBox.Location = new System.Drawing.Point(107, 65);
            this.initialDiagnosisRichTextBox.Name = "initialDiagnosisRichTextBox";
            this.initialDiagnosisRichTextBox.Size = new System.Drawing.Size(239, 96);
            this.initialDiagnosisRichTextBox.TabIndex = 0;
            this.initialDiagnosisRichTextBox.Text = "";
            this.initialDiagnosisRichTextBox.TextChanged += new System.EventHandler(this.initialDiagnosisRichTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Diagnosis:";
            // 
            // finalDiagnosisRichTextBox
            // 
            this.finalDiagnosisRichTextBox.Location = new System.Drawing.Point(107, 209);
            this.finalDiagnosisRichTextBox.Name = "finalDiagnosisRichTextBox";
            this.finalDiagnosisRichTextBox.Size = new System.Drawing.Size(239, 96);
            this.finalDiagnosisRichTextBox.TabIndex = 2;
            this.finalDiagnosisRichTextBox.Text = "";
            this.finalDiagnosisRichTextBox.TextChanged += new System.EventHandler(this.finalDiagnosisRichTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Final Diagnosis:";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(121, 341);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(253, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(156, 316);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(60, 15);
            this.errorLabel.TabIndex = 6;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.Visible = false;
            // 
            // PatientDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 385);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalDiagnosisRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialDiagnosisRichTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Diagnosis";
            this.ResumeLayout(false);
            this.PerformLayout();

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