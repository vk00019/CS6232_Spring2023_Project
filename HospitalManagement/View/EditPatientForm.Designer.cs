﻿namespace HospitalManagement.View
{
    partial class EditPatientForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.zipErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.Location = new System.Drawing.Point(477, 1009);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 53);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(206, 9);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(402, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Edit Patient Information Form";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(350, 772);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(327, 39);
            this.countryTextBox.TabIndex = 9;
            this.countryTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(99, 778);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(104, 32);
            this.countryLabel.TabIndex = 68;
            this.countryLabel.Text = "Country:";
            // 
            // statesComboBox
            // 
            this.statesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(350, 689);
            this.statesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(327, 40);
            this.statesComboBox.TabIndex = 8;
            this.statesComboBox.SelectedIndexChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(350, 446);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(327, 40);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.SelectedIndexChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(99, 450);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(97, 32);
            this.genderLabel.TabIndex = 65;
            this.genderLabel.Text = "Gender:";
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(350, 248);
            this.birthDayDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.birthDayDateTimePicker.MaxDate = new System.DateTime(2023, 4, 12, 15, 52, 12, 0);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(327, 39);
            this.birthDayDateTimePicker.TabIndex = 3;
            this.birthDayDateTimePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.birthDayDateTimePicker.ValueChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(350, 167);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.lastNameTextBox.TabIndex = 2;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(350, 327);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(327, 39);
            this.phoneNumberTextBox.TabIndex = 4;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(350, 525);
            this.streetAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(327, 39);
            this.streetAddressTextBox.TabIndex = 6;
            this.streetAddressTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(350, 603);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(327, 39);
            this.cityTextBox.TabIndex = 7;
            this.cityTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(350, 849);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(327, 39);
            this.zipCodeTextBox.TabIndex = 10;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox_KeyPress);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(350, 88);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.firstNameTextBox.TabIndex = 1;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(212, 963);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(116, 32);
            this.errorLabel.TabIndex = 57;
            this.errorLabel.Text = "errorlabel";
            this.errorLabel.Visible = false;
            // 
            // editPatientButton
            // 
            this.editPatientButton.AutoSize = true;
            this.editPatientButton.Enabled = false;
            this.editPatientButton.Location = new System.Drawing.Point(143, 1009);
            this.editPatientButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(150, 53);
            this.editPatientButton.TabIndex = 11;
            this.editPatientButton.Text = "Edit";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.EditPatientButton_Click);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(99, 851);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(105, 32);
            this.zipCodeLabel.TabIndex = 55;
            this.zipCodeLabel.Text = "Zipcode:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(99, 529);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(81, 32);
            this.streetLabel.TabIndex = 54;
            this.streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(99, 606);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 32);
            this.cityLabel.TabIndex = 53;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(99, 689);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(72, 32);
            this.stateLabel.TabIndex = 52;
            this.stateLabel.Text = "State:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(99, 329);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(182, 32);
            this.phoneNumberLabel.TabIndex = 51;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(99, 248);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(155, 32);
            this.dobLabel.TabIndex = 50;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(99, 169);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(131, 32);
            this.lastnameLabel.TabIndex = 49;
            this.lastnameLabel.Text = "Last Name:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(99, 92);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(134, 32);
            this.firstnameLabel.TabIndex = 48;
            this.firstnameLabel.Text = "First Name:";
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Location = new System.Drawing.Point(165, 396);
            this.phoneErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(116, 32);
            this.phoneErrorLabel.TabIndex = 69;
            this.phoneErrorLabel.Text = "errorlabel";
            this.phoneErrorLabel.Visible = false;
            // 
            // zipErrorLabel
            // 
            this.zipErrorLabel.AutoSize = true;
            this.zipErrorLabel.Location = new System.Drawing.Point(177, 910);
            this.zipErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipErrorLabel.Name = "zipErrorLabel";
            this.zipErrorLabel.Size = new System.Drawing.Size(116, 32);
            this.zipErrorLabel.TabIndex = 70;
            this.zipErrorLabel.Text = "errorlabel";
            this.zipErrorLabel.Visible = false;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 1108);
            this.Controls.Add(this.zipErrorLabel);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthDayDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Patient Form";
            this.Load += new System.EventHandler(this.EditPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Label headerLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private ComboBox statesComboBox;
        private ComboBox genderComboBox;
        private Label genderLabel;
        private DateTimePicker birthDayDateTimePicker;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox streetAddressTextBox;
        private TextBox cityTextBox;
        private TextBox zipCodeTextBox;
        private TextBox firstNameTextBox;
        private Label errorLabel;
        private Button editPatientButton;
        private Label zipCodeLabel;
        private Label streetLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label phoneNumberLabel;
        private Label dobLabel;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private Label phoneErrorLabel;
        private Label zipErrorLabel;
    }
}