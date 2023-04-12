namespace HospitalManagement.UserControls
{
    partial class RegisterPatientUserControl
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
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(345, 740);
            this.countryTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(327, 39);
            this.countryTextBox.TabIndex = 8;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(94, 746);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(104, 32);
            this.countryLabel.TabIndex = 44;
            this.countryLabel.Text = "Country:";
            // 
            // statesComboBox
            // 
            this.statesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(345, 657);
            this.statesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(327, 40);
            this.statesComboBox.TabIndex = 7;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(345, 414);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(327, 40);
            this.genderComboBox.TabIndex = 4;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(94, 418);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(97, 32);
            this.genderLabel.TabIndex = 41;
            this.genderLabel.Text = "Gender:";
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(345, 260);
            this.birthDayDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.birthDayDateTimePicker.MaxDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(327, 39);
            this.birthDayDateTimePicker.TabIndex = 2;
            this.birthDayDateTimePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(345, 179);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(345, 339);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(327, 39);
            this.phoneNumberTextBox.TabIndex = 3;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(345, 493);
            this.streetAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(327, 39);
            this.streetAddressTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(345, 571);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(327, 39);
            this.cityTextBox.TabIndex = 6;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(345, 817);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(327, 39);
            this.zipCodeTextBox.TabIndex = 9;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.ZipCodeTextBox_TextChanged);
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox_KeyPress);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(345, 100);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(213, 879);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(116, 32);
            this.errorLabel.TabIndex = 33;
            this.errorLabel.Text = "errorlabel";
            this.errorLabel.Visible = false;
            // 
            // registerPatientButton
            // 
            this.registerPatientButton.AutoSize = true;
            this.registerPatientButton.Location = new System.Drawing.Point(144, 925);
            this.registerPatientButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.registerPatientButton.Name = "registerPatientButton";
            this.registerPatientButton.Size = new System.Drawing.Size(150, 53);
            this.registerPatientButton.TabIndex = 10;
            this.registerPatientButton.Text = "Register";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(94, 819);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(105, 32);
            this.zipCodeLabel.TabIndex = 31;
            this.zipCodeLabel.Text = "Zipcode:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(94, 497);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(81, 32);
            this.streetLabel.TabIndex = 30;
            this.streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(94, 574);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 32);
            this.cityLabel.TabIndex = 29;
            this.cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(94, 657);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(72, 32);
            this.stateLabel.TabIndex = 28;
            this.stateLabel.Text = "State:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(94, 341);
            this.phoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(182, 32);
            this.phoneNumberLabel.TabIndex = 27;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(94, 260);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(155, 32);
            this.dobLabel.TabIndex = 26;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(94, 181);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(131, 32);
            this.lastnameLabel.TabIndex = 25;
            this.lastnameLabel.Text = "Last Name:";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(94, 104);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(134, 32);
            this.firstnameLabel.TabIndex = 24;
            this.firstnameLabel.Text = "First Name:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.Location = new System.Drawing.Point(201, 21);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(348, 37);
            this.headerLabel.TabIndex = 46;
            this.headerLabel.Text = "Patient Registration Form";
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(478, 925);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 53);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RegisterPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.clearButton);
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
            this.Controls.Add(this.registerPatientButton);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Name = "RegisterPatientUserControl";
            this.Size = new System.Drawing.Size(802, 1042);
            this.Load += new System.EventHandler(this.RegisterPatientUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Button registerPatientButton;
        private Label zipCodeLabel;
        private Label streetLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label phoneNumberLabel;
        private Label dobLabel;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private Label headerLabel;
        private Button clearButton;
    }
}
