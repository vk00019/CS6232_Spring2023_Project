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
            this.label9 = new System.Windows.Forms.Label();
            this.statesComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.registerPatientButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
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
            this.countryTextBox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 746);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 32);
            this.label9.TabIndex = 44;
            this.label9.Text = "Country:";
            // 
            // statesComboBox
            // 
            this.statesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statesComboBox.FormattingEnabled = true;
            this.statesComboBox.Location = new System.Drawing.Point(345, 657);
            this.statesComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.statesComboBox.Name = "statesComboBox";
            this.statesComboBox.Size = new System.Drawing.Size(327, 40);
            this.statesComboBox.TabIndex = 43;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(345, 414);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(327, 40);
            this.genderComboBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 32);
            this.label8.TabIndex = 41;
            this.label8.Text = "Gender:";
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(345, 260);
            this.birthDayDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.birthDayDateTimePicker.MaxDate = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(327, 39);
            this.birthDayDateTimePicker.TabIndex = 40;
            this.birthDayDateTimePicker.Value = new System.DateTime(2023, 4, 12, 0, 0, 0, 0);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(345, 179);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.lastNameTextBox.TabIndex = 39;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(345, 339);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(327, 39);
            this.phoneNumberTextBox.TabIndex = 38;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            this.phoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(345, 493);
            this.streetAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(327, 39);
            this.streetAddressTextBox.TabIndex = 37;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(345, 571);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(327, 39);
            this.cityTextBox.TabIndex = 36;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(345, 817);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(327, 39);
            this.zipCodeTextBox.TabIndex = 35;
            this.zipCodeTextBox.TextChanged += new System.EventHandler(this.ZipCodeTextBox_TextChanged);
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox_KeyPress);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(345, 100);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(327, 39);
            this.firstNameTextBox.TabIndex = 34;
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
            this.registerPatientButton.TabIndex = 32;
            this.registerPatientButton.Text = "Register";
            this.registerPatientButton.UseVisualStyleBackColor = true;
            this.registerPatientButton.Click += new System.EventHandler(this.RegisterPatientButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 819);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Zipcode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 497);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "Street:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 574);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 657);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 341);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Last Name:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(94, 104);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(134, 32);
            this.label.TabIndex = 24;
            this.label.Text = "First Name:";
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
            this.clearButton.TabIndex = 47;
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
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statesComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.birthDayDateTimePicker);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.registerPatientButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Name = "RegisterPatientUserControl";
            this.Size = new System.Drawing.Size(802, 1042);
            this.Load += new System.EventHandler(this.RegisterPatientUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox countryTextBox;
        private Label label9;
        private ComboBox statesComboBox;
        private ComboBox genderComboBox;
        private Label label8;
        private DateTimePicker birthDayDateTimePicker;
        private TextBox lastNameTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox streetAddressTextBox;
        private TextBox cityTextBox;
        private TextBox zipCodeTextBox;
        private TextBox firstNameTextBox;
        private Label errorLabel;
        private Button registerPatientButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label;
        private Label headerLabel;
        private Button clearButton;
    }
}
