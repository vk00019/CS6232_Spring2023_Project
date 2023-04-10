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
            this.testResultsListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.orderedTestsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // testResultsListView
            // 
            this.testResultsListView.Location = new System.Drawing.Point(79, 243);
            this.testResultsListView.Name = "testResultsListView";
            this.testResultsListView.Size = new System.Drawing.Size(184, 112);
            this.testResultsListView.TabIndex = 14;
            this.testResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(132, 200);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            this.orderedTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderedTestsComboBox.FormattingEnabled = true;
            this.orderedTestsComboBox.Location = new System.Drawing.Point(79, 52);
            this.orderedTestsComboBox.Name = "orderedTestsComboBox";
            this.orderedTestsComboBox.Size = new System.Drawing.Size(184, 23);
            this.orderedTestsComboBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Choose Tests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Result:";
            // 
            // testResultRichTextBox
            // 
            this.testResultRichTextBox.Location = new System.Drawing.Point(79, 108);
            this.testResultRichTextBox.Name = "testResultRichTextBox";
            this.testResultRichTextBox.Size = new System.Drawing.Size(184, 71);
            this.testResultRichTextBox.TabIndex = 16;
            this.testResultRichTextBox.Text = "";
            // 
            // TestResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 394);
            this.Controls.Add(this.testResultRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testResultsListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderedTestsComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestResultsForm";
            this.Text = "Test Results";
            this.ResumeLayout(false);
            this.PerformLayout();

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