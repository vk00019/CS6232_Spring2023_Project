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
            countryTextBox = new TextBox();
            countryLabel = new Label();
            statesComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            genderLabel = new Label();
            birthDayDateTimePicker = new DateTimePicker();
            lastNameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            streetAddressTextBox = new TextBox();
            cityTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            errorLabel = new Label();
            registerPatientButton = new Button();
            zipCodeLabel = new Label();
            streetLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            phoneNumberLabel = new Label();
            dobLabel = new Label();
            lastnameLabel = new Label();
            firstnameLabel = new Label();
            headerLabel = new Label();
            clearButton = new Button();
            phoneNumberErrorLabel = new Label();
            zipCodeErrorLabel = new Label();
            SuspendLayout();
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(186, 359);
            countryTextBox.Margin = new Padding(2, 1, 2, 1);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(178, 23);
            countryTextBox.TabIndex = 8;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(51, 362);
            countryLabel.Margin = new Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(53, 15);
            countryLabel.TabIndex = 44;
            countryLabel.Text = "Country:";
            // 
            // statesComboBox
            // 
            statesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statesComboBox.FormattingEnabled = true;
            statesComboBox.Location = new Point(186, 320);
            statesComboBox.Name = "statesComboBox";
            statesComboBox.Size = new Size(178, 23);
            statesComboBox.TabIndex = 7;
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(186, 204);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(178, 23);
            genderComboBox.TabIndex = 4;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(51, 207);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(48, 15);
            genderLabel.TabIndex = 41;
            genderLabel.Text = "Gender:";
            // 
            // birthDayDateTimePicker
            // 
            birthDayDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDayDateTimePicker.Location = new Point(186, 122);
            birthDayDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            birthDayDateTimePicker.MaxDate = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            birthDayDateTimePicker.Size = new Size(178, 23);
            birthDayDateTimePicker.TabIndex = 2;
            birthDayDateTimePicker.Value = new DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(186, 84);
            lastNameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(178, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(186, 159);
            phoneNumberTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(178, 23);
            phoneNumberTextBox.TabIndex = 3;
            phoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            phoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(186, 243);
            streetAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(178, 23);
            streetAddressTextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(186, 280);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(178, 23);
            cityTextBox.TabIndex = 6;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(186, 395);
            zipCodeTextBox.Margin = new Padding(2, 1, 2, 1);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(178, 23);
            zipCodeTextBox.TabIndex = 9;
            zipCodeTextBox.TextChanged += ZipCodeTextBox_TextChanged;
            zipCodeTextBox.KeyPress += ZipCodeTextBox_KeyPress;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(186, 47);
            firstNameTextBox.Margin = new Padding(2, 1, 2, 1);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(178, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(126, 454);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(57, 15);
            errorLabel.TabIndex = 33;
            errorLabel.Text = "errorlabel";
            errorLabel.Visible = false;
            // 
            // registerPatientButton
            // 
            registerPatientButton.AutoSize = true;
            registerPatientButton.Location = new Point(83, 476);
            registerPatientButton.Margin = new Padding(2, 1, 2, 1);
            registerPatientButton.Name = "registerPatientButton";
            registerPatientButton.Size = new Size(81, 25);
            registerPatientButton.TabIndex = 10;
            registerPatientButton.Text = "Register";
            registerPatientButton.UseVisualStyleBackColor = true;
            registerPatientButton.Click += RegisterPatientButton_Click;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(51, 396);
            zipCodeLabel.Margin = new Padding(2, 0, 2, 0);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(53, 15);
            zipCodeLabel.TabIndex = 31;
            zipCodeLabel.Text = "Zipcode:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(51, 245);
            streetLabel.Margin = new Padding(2, 0, 2, 0);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(40, 15);
            streetLabel.TabIndex = 30;
            streetLabel.Text = "Street:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(51, 281);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 29;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(51, 320);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(36, 15);
            stateLabel.TabIndex = 28;
            stateLabel.Text = "State:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(51, 162);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 27;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(51, 128);
            dobLabel.Margin = new Padding(2, 0, 2, 0);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(76, 15);
            dobLabel.TabIndex = 26;
            dobLabel.Text = "Date of Birth:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(51, 87);
            lastnameLabel.Margin = new Padding(2, 0, 2, 0);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(66, 15);
            lastnameLabel.TabIndex = 25;
            lastnameLabel.Text = "Last Name:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new Point(51, 50);
            firstnameLabel.Margin = new Padding(2, 0, 2, 0);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new Size(67, 15);
            firstnameLabel.TabIndex = 24;
            firstnameLabel.Text = "First Name:";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(108, 10);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(180, 19);
            headerLabel.TabIndex = 46;
            headerLabel.Text = "Patient Registration Form";
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new Point(262, 476);
            clearButton.Margin = new Padding(2, 1, 2, 1);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(81, 25);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // phoneNumberErrorLabel
            // 
            phoneNumberErrorLabel.AutoSize = true;
            phoneNumberErrorLabel.Location = new Point(186, 186);
            phoneNumberErrorLabel.Name = "phoneNumberErrorLabel";
            phoneNumberErrorLabel.Size = new Size(38, 15);
            phoneNumberErrorLabel.TabIndex = 47;
            phoneNumberErrorLabel.Text = "label1";
            phoneNumberErrorLabel.Visible = false;
            // 
            // zipCodeErrorLabel
            // 
            zipCodeErrorLabel.AutoSize = true;
            zipCodeErrorLabel.Location = new Point(186, 428);
            zipCodeErrorLabel.Name = "zipCodeErrorLabel";
            zipCodeErrorLabel.Size = new Size(38, 15);
            zipCodeErrorLabel.TabIndex = 48;
            zipCodeErrorLabel.Text = "label1";
            zipCodeErrorLabel.Visible = false;
            // 
            // RegisterPatientUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(zipCodeErrorLabel);
            Controls.Add(phoneNumberErrorLabel);
            Controls.Add(clearButton);
            Controls.Add(headerLabel);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(statesComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(genderLabel);
            Controls.Add(birthDayDateTimePicker);
            Controls.Add(lastNameTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(streetAddressTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(zipCodeTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(errorLabel);
            Controls.Add(registerPatientButton);
            Controls.Add(zipCodeLabel);
            Controls.Add(streetLabel);
            Controls.Add(cityLabel);
            Controls.Add(stateLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(dobLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(firstnameLabel);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RegisterPatientUserControl";
            Size = new Size(432, 540);
            Load += RegisterPatientUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label phoneNumberErrorLabel;
        private Label zipCodeErrorLabel;
    }
}
