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
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            SuspendLayout();
            // 
            // viewEditButton
            // 
            viewEditButton.AutoSize = true;
            viewEditButton.Location = new Point(309, 568);
            viewEditButton.Margin = new Padding(2, 1, 2, 1);
            viewEditButton.Name = "viewEditButton";
            viewEditButton.Size = new Size(175, 33);
            viewEditButton.TabIndex = 72;
            viewEditButton.Text = "View/Edit Appointment";
            viewEditButton.UseVisualStyleBackColor = true;
            viewEditButton.Visible = false;
            viewEditButton.Click += ViewEditButton_Click;
            // 
            // searchDataGridView
            // 
            searchDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(53, 341);
            searchDataGridView.Margin = new Padding(2, 1, 2, 1);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.RowHeadersWidth = 82;
            searchDataGridView.RowTemplate.Height = 41;
            searchDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            searchDataGridView.Size = new Size(431, 188);
            searchDataGridView.TabIndex = 71;
            searchDataGridView.Visible = false;
            searchDataGridView.CellMouseClick += searchDataGridView_CellMouseClick;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(158, 291);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(103, 20);
            errorLabel.TabIndex = 70;
            errorLabel.Text = "error message";
            errorLabel.Visible = false;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(309, 244);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(93, 29);
            clearButton.TabIndex = 69;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(128, 244);
            searchButton.Margin = new Padding(2, 1, 2, 1);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(93, 29);
            searchButton.TabIndex = 68;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(67, 187);
            firstnameLabel.Margin = new Padding(2, 0, 2, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(118, 20);
            firstnameLabel.TabIndex = 67;
            firstnameLabel.Text = "Enter First name:";
            firstnameLabel.Visible = false;
            // 
            // firstnametextBox
            // 
            firstnametextBox.Location = new Point(225, 185);
            firstnametextBox.Margin = new Padding(2, 1, 2, 1);
            firstnametextBox.Name = "firstnametextBox";
            firstnametextBox.Size = new Size(203, 27);
            firstnametextBox.TabIndex = 66;
            firstnametextBox.Visible = false;
            firstnametextBox.TextChanged += firstnametextBox_TextChanged;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(67, 136);
            lastnameLabel.Margin = new Padding(2, 0, 2, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(117, 20);
            lastnameLabel.TabIndex = 65;
            lastnameLabel.Text = "Enter Last name:";
            lastnameLabel.Visible = false;
            // 
            // dobDateTimePicker
            // 
            dobDateTimePicker.Format = DateTimePickerFormat.Short;
            dobDateTimePicker.Location = new Point(225, 92);
            dobDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            dobDateTimePicker.MaxDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dobDateTimePicker.Name = "dobDateTimePicker";
            dobDateTimePicker.Size = new Size(139, 27);
            dobDateTimePicker.TabIndex = 64;
            dobDateTimePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            dobDateTimePicker.ValueChanged += dobDateTimePicker_ValueChanged;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(225, 135);
            lastnameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(203, 27);
            lastnameTextBox.TabIndex = 63;
            lastnameTextBox.Visible = false;
            lastnameTextBox.TextChanged += lastnameTextBox_TextChanged;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(67, 92);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(135, 20);
            dobLabel.TabIndex = 62;
            dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobLnRadioButton
            // 
            dobLnRadioButton.AutoSize = true;
            dobLnRadioButton.Location = new Point(152, 41);
            dobLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobLnRadioButton.Name = "dobLnRadioButton";
            dobLnRadioButton.Size = new Size(215, 24);
            dobLnRadioButton.TabIndex = 61;
            dobLnRadioButton.Text = "Date of Birth and Last name";
            dobLnRadioButton.UseVisualStyleBackColor = true;
            dobLnRadioButton.CheckedChanged += DobLnRadioButton_CheckedChanged;
            // 
            // fnLnRadioButton
            // 
            fnLnRadioButton.AutoSize = true;
            fnLnRadioButton.Location = new Point(378, 41);
            fnLnRadioButton.Margin = new Padding(2, 1, 2, 1);
            fnLnRadioButton.Name = "fnLnRadioButton";
            fnLnRadioButton.Size = new Size(160, 24);
            fnLnRadioButton.TabIndex = 60;
            fnLnRadioButton.Text = "First and Last Name";
            fnLnRadioButton.UseVisualStyleBackColor = true;
            fnLnRadioButton.CheckedChanged += FnLnRadioButton_CheckedChanged;
            // 
            // dobRadioButton
            // 
            dobRadioButton.AutoSize = true;
            dobRadioButton.Checked = true;
            dobRadioButton.Location = new Point(10, 41);
            dobRadioButton.Margin = new Padding(2, 1, 2, 1);
            dobRadioButton.Name = "dobRadioButton";
            dobRadioButton.Size = new Size(115, 24);
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
            nameLabel.Location = new Point(10, 9);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(231, 20);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "Search Appointment Based On: ";
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(53, 568);
            deleteButton.Margin = new Padding(2, 1, 2, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(175, 33);
            deleteButton.TabIndex = 73;
            deleteButton.Text = "Delete Appointment";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // SearchAppointmentByUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteButton);
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
            Size = new Size(554, 629);
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
        private Button deleteButton;
    }
}
