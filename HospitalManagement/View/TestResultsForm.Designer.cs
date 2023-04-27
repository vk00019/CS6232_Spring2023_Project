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
            chooseTestsLabel = new Label();
            resultLabel = new Label();
            testResultTextBox = new RichTextBox();
            normalComboBox = new ComboBox();
            normalLabel = new Label();
            dateLabel = new Label();
            timePicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            label1 = new Label();
            headerLabel = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // testResultsListView
            // 
            testResultsListView.Location = new Point(32, 332);
            testResultsListView.Name = "testResultsListView";
            testResultsListView.Size = new Size(320, 112);
            testResultsListView.TabIndex = 14;
            testResultsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(144, 297);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 13;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            orderedTestsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            orderedTestsComboBox.FormattingEnabled = true;
            orderedTestsComboBox.Location = new Point(162, 45);
            orderedTestsComboBox.Name = "orderedTestsComboBox";
            orderedTestsComboBox.Size = new Size(184, 23);
            orderedTestsComboBox.TabIndex = 12;
            // 
            // chooseTestsLabel
            // 
            chooseTestsLabel.AutoSize = true;
            chooseTestsLabel.Location = new Point(60, 45);
            chooseTestsLabel.Name = "chooseTestsLabel";
            chooseTestsLabel.Size = new Size(78, 15);
            chooseTestsLabel.TabIndex = 11;
            chooseTestsLabel.Text = "Choose Tests:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(74, 101);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(65, 15);
            resultLabel.TabIndex = 15;
            resultLabel.Text = "Test Result:";
            // 
            // testResultTextBox
            // 
            testResultTextBox.Location = new Point(162, 83);
            testResultTextBox.Name = "testResultTextBox";
            testResultTextBox.Size = new Size(184, 71);
            testResultTextBox.TabIndex = 16;
            testResultTextBox.Text = "";
            // 
            // normalComboBox
            // 
            normalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            normalComboBox.FormattingEnabled = true;
            normalComboBox.Location = new Point(162, 174);
            normalComboBox.Name = "normalComboBox";
            normalComboBox.Size = new Size(184, 23);
            normalComboBox.TabIndex = 18;
            // 
            // normalLabel
            // 
            normalLabel.AutoSize = true;
            normalLabel.Location = new Point(32, 176);
            normalLabel.Name = "normalLabel";
            normalLabel.Size = new Size(106, 15);
            normalLabel.TabIndex = 17;
            normalLabel.Text = "Choose Normality:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(17, 211);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(127, 15);
            dateLabel.TabIndex = 19;
            dateLabel.Text = "Select Performed Date:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(162, 248);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            timePicker.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(184, 23);
            timePicker.TabIndex = 24;
            timePicker.Value = new DateTime(2023, 4, 8, 21, 1, 25, 0);
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(162, 211);
            datePicker.Margin = new Padding(2, 1, 2, 1);
            datePicker.MaxDate = new DateTime(2200, 12, 31, 0, 0, 0, 0);
            datePicker.MinDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(184, 23);
            datePicker.TabIndex = 23;
            datePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 25;
            label1.Text = "Select Performed Time:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(99, 11);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(171, 19);
            headerLabel.TabIndex = 49;
            headerLabel.Text = "Add Patient's Test Result";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(50, 274);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(81, 15);
            errorLabel.TabIndex = 50;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // TestResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 351);
            Controls.Add(errorLabel);
            Controls.Add(headerLabel);
            Controls.Add(label1);
            Controls.Add(timePicker);
            Controls.Add(datePicker);
            Controls.Add(dateLabel);
            Controls.Add(normalComboBox);
            Controls.Add(normalLabel);
            Controls.Add(testResultTextBox);
            Controls.Add(resultLabel);
            Controls.Add(testResultsListView);
            Controls.Add(addButton);
            Controls.Add(orderedTestsComboBox);
            Controls.Add(chooseTestsLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TestResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Test Results";
            Load += TestResultsForm_Load;
            ResumeLayout(false);
            PerformLayout();
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