namespace HospitalManagement.View
{
    partial class TestResultsForm
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
            testResultsListView = new ListView();
            addButton = new Button();
            orderedTestsComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            testResultRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // testResultsListView
            // 
            testResultsListView.Location = new Point(79, 243);
            testResultsListView.Name = "testResultsListView";
            testResultsListView.Size = new Size(184, 112);
            testResultsListView.TabIndex = 14;
            testResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(132, 200);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 13;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            orderedTestsComboBox.FormattingEnabled = true;
            orderedTestsComboBox.Location = new Point(79, 52);
            orderedTestsComboBox.Name = "orderedTestsComboBox";
            orderedTestsComboBox.Size = new Size(184, 23);
            orderedTestsComboBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 31);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 11;
            label1.Text = "Choose Tests:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 15;
            label2.Text = "Result:";
            label2.Click += label2_Click;
            // 
            // testResultRichTextBox
            // 
            testResultRichTextBox.Location = new Point(79, 108);
            testResultRichTextBox.Name = "testResultRichTextBox";
            testResultRichTextBox.Size = new Size(184, 71);
            testResultRichTextBox.TabIndex = 16;
            testResultRichTextBox.Text = "";
            // 
            // TestResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 394);
            Controls.Add(testResultRichTextBox);
            Controls.Add(label2);
            Controls.Add(testResultsListView);
            Controls.Add(addButton);
            Controls.Add(orderedTestsComboBox);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TestResultsForm";
            Text = "Test Results";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView testResultsListView;
        private Button addButton;
        private ComboBox orderedTestsComboBox;
        private Label label1;
        private Label label2;
        private RichTextBox testResultRichTextBox;
    }
}