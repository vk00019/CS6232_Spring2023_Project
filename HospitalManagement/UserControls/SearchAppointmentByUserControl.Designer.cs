﻿namespace HospitalManagement.UserControls
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
            this.viewEditButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.errorLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnametextBox = new System.Windows.Forms.TextBox();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobLnRadioButton = new System.Windows.Forms.RadioButton();
            this.fnLnRadioButton = new System.Windows.Forms.RadioButton();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewEditButton
            // 
            this.viewEditButton.AutoSize = true;
            this.viewEditButton.Location = new System.Drawing.Point(502, 909);
            this.viewEditButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewEditButton.Name = "viewEditButton";
            this.viewEditButton.Size = new System.Drawing.Size(284, 53);
            this.viewEditButton.TabIndex = 72;
            this.viewEditButton.Text = "View/Edit Appointment";
            this.viewEditButton.UseVisualStyleBackColor = true;
            this.viewEditButton.Visible = false;
            this.viewEditButton.Click += new System.EventHandler(this.ViewEditButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(86, 546);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowHeadersWidth = 82;
            this.searchDataGridView.RowTemplate.Height = 41;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(700, 301);
            this.searchDataGridView.TabIndex = 71;
            this.searchDataGridView.Visible = false;
            this.searchDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchDataGridView_CellMouseClick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(257, 466);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(165, 32);
            this.errorLabel.TabIndex = 70;
            this.errorLabel.Text = "error message";
            this.errorLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(502, 390);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(151, 46);
            this.clearButton.TabIndex = 69;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(208, 390);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 46);
            this.searchButton.TabIndex = 68;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(109, 299);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(192, 32);
            this.firstnameLabel.TabIndex = 67;
            this.firstnameLabel.Text = "Enter First name:";
            this.firstnameLabel.Visible = false;
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
            this.firstnametextBox.Location = new System.Drawing.Point(366, 296);
            this.firstnametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstnametextBox.Name = "firstnametextBox";
            this.firstnametextBox.Size = new System.Drawing.Size(327, 39);
            this.firstnametextBox.TabIndex = 66;
            this.firstnametextBox.Visible = false;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(109, 218);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(189, 32);
            this.lastnameLabel.TabIndex = 65;
            this.lastnameLabel.Text = "Enter Last name:";
            this.lastnameLabel.Visible = false;
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
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(366, 147);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(223, 39);
            this.dobDateTimePicker.TabIndex = 64;
            this.dobDateTimePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
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
            this.lastnameTextBox.Location = new System.Drawing.Point(366, 216);
            this.lastnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(327, 39);
            this.lastnameTextBox.TabIndex = 63;
            this.lastnameTextBox.Visible = false;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(109, 147);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(217, 32);
            this.dobLabel.TabIndex = 62;
            this.dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobLnRadioButton
            // 
            this.dobLnRadioButton.AutoSize = true;
            this.dobLnRadioButton.Location = new System.Drawing.Point(247, 66);
            this.dobLnRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobLnRadioButton.Name = "dobLnRadioButton";
            this.dobLnRadioButton.Size = new System.Drawing.Size(343, 36);
            this.dobLnRadioButton.TabIndex = 61;
            this.dobLnRadioButton.Text = "Date of Birth and Last name";
            this.dobLnRadioButton.UseVisualStyleBackColor = true;
            this.dobLnRadioButton.CheckedChanged += new System.EventHandler(this.DobLnRadioButton_CheckedChanged);
            // 
            // fnLnRadioButton
            // 
            this.fnLnRadioButton.AutoSize = true;
            this.fnLnRadioButton.Location = new System.Drawing.Point(614, 66);
            this.fnLnRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fnLnRadioButton.Name = "fnLnRadioButton";
            this.fnLnRadioButton.Size = new System.Drawing.Size(255, 36);
            this.fnLnRadioButton.TabIndex = 60;
            this.fnLnRadioButton.Text = "First and Last Name";
            this.fnLnRadioButton.UseVisualStyleBackColor = true;
            this.fnLnRadioButton.CheckedChanged += new System.EventHandler(this.FnLnRadioButton_CheckedChanged);
            // 
            // dobRadioButton
            // 
            this.dobRadioButton.AutoSize = true;
            this.dobRadioButton.Checked = true;
            this.dobRadioButton.Location = new System.Drawing.Point(16, 66);
            this.dobRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobRadioButton.Name = "dobRadioButton";
            this.dobRadioButton.Size = new System.Drawing.Size(181, 36);
            this.dobRadioButton.TabIndex = 59;
            this.dobRadioButton.TabStop = true;
            this.dobRadioButton.Text = "Date of Birth";
            this.dobRadioButton.UseVisualStyleBackColor = true;
            this.dobRadioButton.CheckedChanged += new System.EventHandler(this.DobRadioButton_CheckedChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(16, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(376, 32);
            this.nameLabel.TabIndex = 58;
            this.nameLabel.Text = "Search Appointment Based On: ";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewEditButton);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.firstnametextBox);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.dobLnRadioButton);
            this.Controls.Add(this.fnLnRadioButton);
            this.Controls.Add(this.dobRadioButton);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchAppointmentByUserControl";
            this.Size = new System.Drawing.Size(900, 1006);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
