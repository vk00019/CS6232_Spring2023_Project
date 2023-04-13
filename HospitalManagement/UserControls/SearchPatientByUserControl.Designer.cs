namespace HospitalManagement.UserControls
{
    partial class SearchPatientByUserControl
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
            editButton = new Button();
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
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.Location = new Point(279, 430);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(83, 25);
            editButton.TabIndex = 57;
            editButton.Text = "Edit Patient";
            editButton.UseVisualStyleBackColor = true;
            editButton.Visible = false;
            // 
            // viewButton
            // 
            viewButton.AutoSize = true;
            viewButton.Location = new Point(123, 430);
            viewButton.Margin = new Padding(2, 1, 2, 1);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(83, 25);
            viewButton.TabIndex = 56;
            viewButton.Text = "View Patient";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(20, 261);
            searchDataGridView.Margin = new Padding(2, 1, 2, 1);
            searchDataGridView.MultiSelect = false;
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 82;
            searchDataGridView.RowTemplate.Height = 41;
            searchDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchDataGridView.Size = new Size(451, 141);
            searchDataGridView.TabIndex = 55;
            searchDataGridView.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(150, 222);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(81, 15);
            errorLabel.TabIndex = 54;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(282, 188);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 22);
            clearButton.TabIndex = 53;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(123, 188);
            searchButton.Margin = new Padding(2, 1, 2, 1);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(81, 22);
            searchButton.TabIndex = 52;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(70, 144);
            firstnameLabel.Margin = new Padding(2, 0, 2, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(93, 15);
            firstnameLabel.TabIndex = 51;
            firstnameLabel.Text = "Enter first name:";
            firstnameLabel.Visible = false;
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(208, 143);
            firstnametextBox.Margin = new Padding(2, 1, 2, 1);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(178, 23);
            firstnametextBox.TabIndex = 50;
            firstnametextBox.Visible = false;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(70, 106);
            lastnameLabel.Margin = new Padding(2, 0, 2, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(94, 15);
            lastnameLabel.TabIndex = 49;
            lastnameLabel.Text = "Enter Last name:";
            lastnameLabel.Visible = false;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Format = DateTimePickerFormat.Short;
            dobDateTimePicker.Location = new Point(208, 73);
            dobDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dobDateTimePicker.MaxDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(122, 23);
            dobDateTimePicker.TabIndex = 48;
            dobDateTimePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(208, 105);
            lastnameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(178, 23);
            lastnameTextBox.TabIndex = 47;
            lastnameTextBox.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(70, 73);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(106, 15);
            dobLabel.TabIndex = 46;
            dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobLnRadioButton
            // 
            dobLnRadioButton.AutoSize = true;
            dobLnRadioButton.Location = new Point(144, 36);
            dobLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobLnRadioButton.Name = "dobLnRadioButton";
            dobLnRadioButton.Size = new Size(171, 19);
            dobLnRadioButton.TabIndex = 45;
            dobLnRadioButton.Text = "Date of Birth and Last name";
            dobLnRadioButton.UseVisualStyleBackColor = true;
            dobLnRadioButton.CheckedChanged += DobLnRadioButton_CheckedChanged;
            // 
            // fnLnRadioButton
            // 
            fnLnRadioButton.AutoSize = true;
            fnLnRadioButton.Location = new Point(342, 36);
            fnLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            fnLnRadioButton.Name = "fnLnRadioButton";
            fnLnRadioButton.Size = new Size(129, 19);
            fnLnRadioButton.TabIndex = 44;
            fnLnRadioButton.Text = "First and Last Name";
            fnLnRadioButton.UseVisualStyleBackColor = true;
            fnLnRadioButton.CheckedChanged += FnLnRadioButton_CheckedChanged;
            // 
            // dobRadioButton
            // 
            dobRadioButton.AutoSize = true;
            dobRadioButton.Checked = true;
            dobRadioButton.Location = new Point(20, 36);
            dobRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobRadioButton.Name = "dobRadioButton";
            dobRadioButton.Size = new Size(91, 19);
            dobRadioButton.TabIndex = 43;
            dobRadioButton.TabStop = true;
            dobRadioButton.Text = "Date of Birth";
            dobRadioButton.UseVisualStyleBackColor = true;
            dobRadioButton.CheckedChanged += DobRadioButton_CheckedChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(20, 11);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(149, 15);
            nameLabel.TabIndex = 42;
            nameLabel.Text = "Search Patient Based On: ";
            // 
            // SearchPatientByUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(editButton);
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
            Name = "SearchPatientByUserControl";
            Size = new Size(491, 475);
            Load += SearchPatientByUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button editButton;
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
