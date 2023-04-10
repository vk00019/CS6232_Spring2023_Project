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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            addButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(107, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(239, 96);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
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
            // richTextBox2
            // 
            richTextBox2.Location = new Point(107, 209);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(239, 96);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
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
            addButton.Location = new Point(121, 328);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(253, 328);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // PatientDiagnosis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 374);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientDiagnosis";
            Text = "Patient Diagnosis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label2;
        private Button addButton;
        private Button cancelButton;
    }
}