namespace HospitalManagement.View
{
    partial class PatientRegistration
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
            menuUserControl1 = new UserControls.MenuUserControl();
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            registerPatientButton = new Button();
            errorLabel = new Label();
            firstNameTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            cityTextBox = new TextBox();
            streetAddressTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            birthDayDateTimePicker = new DateTimePicker();
            label8 = new Label();
            genderComboBox = new ComboBox();
            statesComboBox = new ComboBox();
            label9 = new Label();
            countryTextBox = new TextBox();
            SuspendLayout();
            // 
            // menuUserControl1
            // 
            menuUserControl1.Dock = DockStyle.Top;
            menuUserControl1.Location = new Point(0, 0);
            menuUserControl1.Margin = new Padding(1, 0, 1, 0);
            menuUserControl1.Name = "menuUserControl1";
            menuUserControl1.Size = new Size(438, 55);
            menuUserControl1.TabIndex = 0;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(32, 47);
            label.Margin = new Padding(2, 0, 2, 0);
            label.Name = "label";
            label.Size = new Size(67, 15);
            label.TabIndex = 1;
            label.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 158);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 306);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 5;
            label4.Text = "State:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 267);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 6;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 231);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "Street:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 382);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 8;
            label7.Text = "Zipcode:";
            // 
            // registerPatientButton
            // 
            registerPatientButton.AutoSize = true;
            registerPatientButton.Location = new Point(175, 427);
            registerPatientButton.Margin = new Padding(2, 1, 2, 1);
            registerPatientButton.Name = "registerPatientButton";
            registerPatientButton.Size = new Size(81, 25);
            registerPatientButton.TabIndex = 9;
            registerPatientButton.Text = "Register";
            registerPatientButton.UseVisualStyleBackColor = true;
            registerPatientButton.Click += registerPatientButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(183, 459);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(57, 15);
            errorLabel.TabIndex = 10;
            errorLabel.Text = "errorlabel";
            errorLabel.Visible = false;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(167, 45);
            firstNameTextBox.Margin = new Padding(2, 1, 2, 1);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(178, 23);
            firstNameTextBox.TabIndex = 11;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(167, 381);
            zipCodeTextBox.Margin = new Padding(2, 1, 2, 1);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(178, 23);
            zipCodeTextBox.TabIndex = 12;
            zipCodeTextBox.TextChanged += zipCodeTextBox_TextChanged;
            zipCodeTextBox.KeyPress += zipCodeTextBox_KeyPress;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(167, 266);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(178, 23);
            cityTextBox.TabIndex = 14;
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(167, 229);
            streetAddressTextBox.Margin = new Padding(2, 1, 2, 1);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(178, 23);
            streetAddressTextBox.TabIndex = 15;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(167, 157);
            phoneNumberTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(178, 23);
            phoneNumberTextBox.TabIndex = 16;
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            phoneNumberTextBox.KeyPress += phoneNumberTextBox_KeyPress;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(167, 82);
            lastNameTextBox.Margin = new Padding(2, 1, 2, 1);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(178, 23);
            lastNameTextBox.TabIndex = 17;
            // 
            // birthDayDateTimePicker
            // 
            birthDayDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDayDateTimePicker.Location = new Point(167, 120);
            birthDayDateTimePicker.Margin = new Padding(2, 1, 2, 1);
            birthDayDateTimePicker.MaxDate = new DateTime(2023, 4, 8, 0, 0, 0, 0);
            birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            birthDayDateTimePicker.Size = new Size(178, 23);
            birthDayDateTimePicker.TabIndex = 18;
            birthDayDateTimePicker.Value = new DateTime(2023, 4, 8, 0, 0, 0, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 194);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 19;
            label8.Text = "Gender:";
            // 
            // genderComboBox
            // 
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(167, 192);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(178, 23);
            genderComboBox.TabIndex = 20;
            // 
            // statesComboBox
            // 
            statesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statesComboBox.FormattingEnabled = true;
            statesComboBox.Location = new Point(167, 306);
            statesComboBox.Name = "statesComboBox";
            statesComboBox.Size = new Size(178, 23);
            statesComboBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 348);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 22;
            label9.Text = "Country:";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(167, 345);
            countryTextBox.Margin = new Padding(2, 1, 2, 1);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(178, 23);
            countryTextBox.TabIndex = 23;
            // 
            // PatientRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 483);
            Controls.Add(countryTextBox);
            Controls.Add(label9);
            Controls.Add(statesComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(label8);
            Controls.Add(birthDayDateTimePicker);
            Controls.Add(lastNameTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(streetAddressTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(zipCodeTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(errorLabel);
            Controls.Add(registerPatientButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(menuUserControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "PatientRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.MenuUserControl menuUserControl1;
        private Label label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button registerPatientButton;
        private Label errorLabel;
        private TextBox firstNameTextBox;
        private TextBox zipCodeTextBox;
        private TextBox cityTextBox;
        private TextBox streetAddressTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox lastNameTextBox;
        private DateTimePicker birthDayDateTimePicker;
        private Label label8;
        private ComboBox genderComboBox;
        private ComboBox statesComboBox;
        private Label label9;
        private TextBox countryTextBox;
    }
}