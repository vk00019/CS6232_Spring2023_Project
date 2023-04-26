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
            this.chooseTestsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.testResultTextBox = new System.Windows.Forms.RichTextBox();
            this.normalComboBox = new System.Windows.Forms.ComboBox();
            this.normalLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testResultsListView
            // 
            this.testResultsListView.Location = new System.Drawing.Point(60, 708);
            this.testResultsListView.Margin = new System.Windows.Forms.Padding(6);
            this.testResultsListView.Name = "testResultsListView";
            this.testResultsListView.Size = new System.Drawing.Size(591, 234);
            this.testResultsListView.TabIndex = 14;
            this.testResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(267, 633);
            this.addButton.Margin = new System.Windows.Forms.Padding(6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 49);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            this.orderedTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderedTestsComboBox.FormattingEnabled = true;
            this.orderedTestsComboBox.Location = new System.Drawing.Point(301, 96);
            this.orderedTestsComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.orderedTestsComboBox.Name = "orderedTestsComboBox";
            this.orderedTestsComboBox.Size = new System.Drawing.Size(338, 40);
            this.orderedTestsComboBox.TabIndex = 12;
            // 
            // chooseTestsLabel
            // 
            this.chooseTestsLabel.AutoSize = true;
            this.chooseTestsLabel.Location = new System.Drawing.Point(111, 96);
            this.chooseTestsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.chooseTestsLabel.Name = "chooseTestsLabel";
            this.chooseTestsLabel.Size = new System.Drawing.Size(158, 32);
            this.chooseTestsLabel.TabIndex = 11;
            this.chooseTestsLabel.Text = "Choose Tests:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(137, 216);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(132, 32);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Test Result:";
            // 
            // testResultTextBox
            // 
            this.testResultTextBox.Location = new System.Drawing.Point(301, 178);
            this.testResultTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.testResultTextBox.Name = "testResultTextBox";
            this.testResultTextBox.Size = new System.Drawing.Size(338, 147);
            this.testResultTextBox.TabIndex = 16;
            this.testResultTextBox.Text = "";
            // 
            // normalComboBox
            // 
            this.normalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.normalComboBox.FormattingEnabled = true;
            this.normalComboBox.Location = new System.Drawing.Point(301, 372);
            this.normalComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.normalComboBox.Name = "normalComboBox";
            this.normalComboBox.Size = new System.Drawing.Size(338, 40);
            this.normalComboBox.TabIndex = 18;
            // 
            // normalLabel
            // 
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(60, 375);
            this.normalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(211, 32);
            this.normalLabel.TabIndex = 17;
            this.normalLabel.Text = "Choose Normality:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(31, 451);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(258, 32);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Select Performed Date:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(301, 529);
            this.timePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(338, 39);
            this.timePicker.TabIndex = 24;
            this.timePicker.Value = new System.DateTime(2023, 4, 8, 21, 1, 25, 0);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(301, 451);
            this.datePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(338, 39);
            this.datePicker.TabIndex = 23;
            this.datePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 529);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select Performed Time:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(183, 24);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(333, 37);
            this.headerLabel.TabIndex = 49;
            this.headerLabel.Text = "Add Patient\'s Test Result";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(93, 584);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(165, 32);
            this.errorLabel.TabIndex = 50;
            this.errorLabel.Text = "error message";
            this.errorLabel.Visible = false;
            // 
            // TestResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 969);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.normalComboBox);
            this.Controls.Add(this.normalLabel);
            this.Controls.Add(this.testResultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.testResultsListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderedTestsComboBox);
            this.Controls.Add(this.chooseTestsLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestResultsForm";
            this.Text = "Test Results";
            this.Load += new System.EventHandler(this.TestResultsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView testResultsListView;
        private Button addButton;
        private ComboBox orderedTestsComboBox;
        private Label chooseTestsLabel;
        private Label resultLabel;
        private RichTextBox testResultTextBox;
        private ComboBox normalComboBox;
        private Label normalLabel;
        private Label dateLabel;
        private DateTimePicker timePicker;
        private DateTimePicker datePicker;
        private Label label1;
        private Label headerLabel;
        private Label errorLabel;
    }
}