namespace HospitalManagement.UserControls
{
    partial class SearchPatientVisitByUserControl
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
            viewButton = new Button();
            searchDataGridView = new DataGridView();
            errorLabel = new Label();
            clearButton = new Button();
            searchButton = new Button();
            firstnameLabel = new Label();
            firstnametextBox = new TextBox();
            lastnameLabel = new Label();
            dobDateTimePicker = new DateTimePicker();
            lastnameTextBox = new TextBox();
            dobLabel = new Label();
            dobLnRadioButton = new RadioButton();
            fnLnRadioButton = new RadioButton();
            dobRadioButton = new RadioButton();
            nameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewButton
            // 
            viewButton.AutoSize = true;
            viewButton.Location = new Point(209, 428);
            viewButton.Margin = new Padding(2, 1, 2, 1);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(92, 25);
            viewButton.TabIndex = 72;
            viewButton.Text = "View/Edit Visit";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Visible = false;
            viewButton.Click += viewButton_Click;
            // 
            // searchDataGridView
            // 
            searchDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(41, 264);
            searchDataGridView.Margin = new Padding(2, 1, 2, 1);
            searchDataGridView.MultiSelect = false;
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 82;
            searchDataGridView.RowTemplate.Height = 41;
            searchDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchDataGridView.Size = new Size(451, 141);
            searchDataGridView.TabIndex = 71;
            searchDataGridView.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(171, 225);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(81, 15);
            errorLabel.TabIndex = 70;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(303, 191);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 22);
            clearButton.TabIndex = 69;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(144, 191);
            searchButton.Margin = new Padding(2, 1, 2, 1);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(81, 22);
            searchButton.TabIndex = 68;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(91, 147);
            firstnameLabel.Margin = new Padding(2, 0, 2, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(93, 15);
            firstnameLabel.TabIndex = 67;
            firstnameLabel.Text = "Enter first name:";
            firstnameLabel.Visible = false;
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(229, 146);
            firstnametextBox.Margin = new Padding(2, 1, 2, 1);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(178, 23);
            firstnametextBox.TabIndex = 66;
            firstnametextBox.Visible = false;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(91, 109);
            lastnameLabel.Margin = new Padding(2, 0, 2, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(94, 15);
            lastnameLabel.TabIndex = 65;
            lastnameLabel.Text = "Enter Last name:";
            lastnameLabel.Visible = false;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Format = DateTimePickerFormat.Short;
            dobDateTimePicker.Location = new Point(229, 76);
            dobDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dobDateTimePicker.MaxDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(122, 23);
            dobDateTimePicker.TabIndex = 64;
            dobDateTimePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(229, 108);
            lastnameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(178, 23);
            lastnameTextBox.TabIndex = 63;
            lastnameTextBox.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(91, 76);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(106, 15);
            dobLabel.TabIndex = 62;
            dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobLnRadioButton
            // 
            dobLnRadioButton.AutoSize = true;
            dobLnRadioButton.Location = new Point(165, 39);
            dobLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobLnRadioButton.Name = "dobLnRadioButton";
            dobLnRadioButton.Size = new Size(171, 19);
            dobLnRadioButton.TabIndex = 61;
            dobLnRadioButton.Text = "Date of Birth and Last name";
            dobLnRadioButton.UseVisualStyleBackColor = true;
            dobLnRadioButton.CheckedChanged += DobLnRadioButton_CheckedChanged;
            // 
            // fnLnRadioButton
            // 
            fnLnRadioButton.AutoSize = true;
            fnLnRadioButton.Location = new Point(363, 39);
            fnLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            fnLnRadioButton.Name = "fnLnRadioButton";
            fnLnRadioButton.Size = new Size(129, 19);
            fnLnRadioButton.TabIndex = 60;
            fnLnRadioButton.Text = "First and Last Name";
            fnLnRadioButton.UseVisualStyleBackColor = true;
            fnLnRadioButton.CheckedChanged += FnLnRadioButton_CheckedChanged;
            // 
            // dobRadioButton
            // 
            dobRadioButton.AutoSize = true;
            dobRadioButton.Checked = true;
            dobRadioButton.Location = new Point(41, 39);
            dobRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobRadioButton.Name = "dobRadioButton";
            dobRadioButton.Size = new Size(91, 19);
            dobRadioButton.TabIndex = 59;
            dobRadioButton.TabStop = true;
            dobRadioButton.Text = "Date of Birth";
            dobRadioButton.UseVisualStyleBackColor = true;
            dobRadioButton.CheckedChanged += DobRadioButton_CheckedChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(41, 14);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(184, 15);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "Search Patient's Visit Based On: ";
            // 
            // SearchPatientVisitByUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewButton);
            Controls.Add(searchDataGridView);
            Controls.Add(errorLabel);
            Controls.Add(clearButton);
            Controls.Add(searchButton);
            Controls.Add(firstnameLabel);
            Controls.Add(firstnametextBox);
            Controls.Add(lastnameLabel);
            Controls.Add(dobDateTimePicker);
            Controls.Add(lastnameTextBox);
            Controls.Add(dobLabel);
            Controls.Add(dobLnRadioButton);
            Controls.Add(fnLnRadioButton);
            Controls.Add(dobRadioButton);
            Controls.Add(nameLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "SearchPatientVisitByUserControl";
            Size = new Size(541, 471);
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button viewButton;
        private DataGridView searchDataGridView;
        private Label errorLabel;
        private Button clearButton;
        private Button searchButton;
        private Label firstnameLabel;
        private TextBox firstnametextBox;
        private Label lastnameLabel;
        private DateTimePicker dobDateTimePicker;
        private TextBox lastnameTextBox;
        private Label dobLabel;
        private RadioButton dobLnRadioButton;
        private RadioButton fnLnRadioButton;
        private RadioButton dobRadioButton;
        private Label nameLabel;
    }
}
