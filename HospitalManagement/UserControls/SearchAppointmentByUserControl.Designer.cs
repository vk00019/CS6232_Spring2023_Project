namespace HospitalManagement.UserControls
{
    partial class SearchAppointmentByUserControl
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
            viewEditButton = new Button();
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
            // viewEditButton
            // 
            viewEditButton.AutoSize = true;
            viewEditButton.Location = new Point(270, 426);
            viewEditButton.Margin = new Padding(2, 1, 2, 1);
            viewEditButton.Name = "viewEditButton";
            viewEditButton.Size = new Size(146, 25);
            viewEditButton.TabIndex = 72;
            viewEditButton.Text = "View/Edit Appointment";
            viewEditButton.UseVisualStyleBackColor = true;
            viewEditButton.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(46, 256);
            searchDataGridView.Margin = new Padding(2, 1, 2, 1);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 82;
            searchDataGridView.RowTemplate.Height = 41;
            searchDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchDataGridView.Size = new Size(377, 141);
            searchDataGridView.TabIndex = 71;
            searchDataGridView.Visible = false;
            searchDataGridView.CellMouseClick += searchDataGridView_CellMouseClick;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(138, 218);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(81, 15);
            errorLabel.TabIndex = 70;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(270, 183);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 22);
            clearButton.TabIndex = 69;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(112, 183);
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
            firstnameLabel.Location = new Point(59, 140);
            firstnameLabel.Margin = new Padding(2, 0, 2, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(95, 15);
            firstnameLabel.TabIndex = 67;
            firstnameLabel.Text = "Enter First name:";
            firstnameLabel.Visible = false;
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(197, 139);
            firstnametextBox.Margin = new Padding(2, 1, 2, 1);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(178, 23);
            firstnametextBox.TabIndex = 66;
            firstnametextBox.Visible = false;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(59, 102);
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
            dobDateTimePicker.Location = new Point(197, 69);
            dobDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dobDateTimePicker.MaxDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(122, 23);
            dobDateTimePicker.TabIndex = 64;
            dobDateTimePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(197, 101);
            lastnameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(178, 23);
            lastnameTextBox.TabIndex = 63;
            lastnameTextBox.Visible = false;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(59, 69);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(106, 15);
            dobLabel.TabIndex = 62;
            dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobLnRadioButton
            // 
            dobLnRadioButton.AutoSize = true;
            dobLnRadioButton.Location = new Point(133, 31);
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
            fnLnRadioButton.Location = new Point(331, 31);
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
            dobRadioButton.Location = new Point(9, 31);
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
            nameLabel.Location = new Point(9, 7);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(183, 15);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "Search Appointment Based On: ";
            // 
            // SearchAppointmentByUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewEditButton);
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
            Name = "SearchAppointmentByUserControl";
            Size = new Size(485, 472);
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button viewEditButton;
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
