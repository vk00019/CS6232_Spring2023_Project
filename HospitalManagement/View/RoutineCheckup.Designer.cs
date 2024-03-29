﻿namespace HospitalManagement.View
{
    partial class RoutineCheckup
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
            weightTextBox = new TextBox();
            diaBPTextBox = new TextBox();
            tempTextBox = new TextBox();
            pulseTextBox = new TextBox();
            heightTextBox = new TextBox();
            errorLabel = new Label();
            addDetailsButton = new Button();
            tempLabel = new Label();
            pulseLabel = new Label();
            symptomslabel = new Label();
            diaBPLabel = new Label();
            sysBpLabel = new Label();
            weightLabel = new Label();
            heightLabel = new Label();
            headerLabel = new Label();
            sysBPTextBox = new TextBox();
            symptomsTextBox = new RichTextBox();
            cancelButton = new Button();
            symptomsErrorLabel = new Label();
            pulseErrorLabel = new Label();
            temperatureErrorLabel = new Label();
            diastolicErrorLabel = new Label();
            systolicErrorLabel = new Label();
            weightErrorLabel = new Label();
            heightErrorLabel = new Label();
            SuspendLayout();
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(203, 125);
            weightTextBox.Margin = new Padding(2, 1, 2, 1);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(203, 27);
            weightTextBox.TabIndex = 2;
            weightTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // diaBPTextBox
            // 
            diaBPTextBox.Location = new Point(203, 264);
            diaBPTextBox.Margin = new Padding(2, 1, 2, 1);
            diaBPTextBox.Name = "diaBPTextBox";
            diaBPTextBox.Size = new Size(203, 27);
            diaBPTextBox.TabIndex = 4;
            diaBPTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // tempTextBox
            // 
            tempTextBox.Location = new Point(203, 332);
            tempTextBox.Margin = new Padding(2, 1, 2, 1);
            tempTextBox.Name = "tempTextBox";
            tempTextBox.Size = new Size(203, 27);
            tempTextBox.TabIndex = 5;
            tempTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // pulseTextBox
            // 
            pulseTextBox.Location = new Point(203, 397);
            pulseTextBox.Margin = new Padding(2, 1, 2, 1);
            pulseTextBox.Name = "pulseTextBox";
            pulseTextBox.Size = new Size(203, 27);
            pulseTextBox.TabIndex = 6;
            pulseTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(203, 61);
            heightTextBox.Margin = new Padding(2, 1, 2, 1);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(203, 27);
            heightTextBox.TabIndex = 1;
            heightTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(83, 568);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(74, 20);
            errorLabel.TabIndex = 28;
            errorLabel.Text = "errorlabel";
            errorLabel.Visible = false;
            // 
            // addDetailsButton
            // 
            addDetailsButton.Location = new Point(77, 607);
            addDetailsButton.Margin = new Padding(2, 1, 2, 1);
            addDetailsButton.Name = "addDetailsButton";
            addDetailsButton.Size = new Size(93, 29);
            addDetailsButton.TabIndex = 8;
            addDetailsButton.Text = "Add";
            addDetailsButton.UseVisualStyleBackColor = true;
            addDetailsButton.Click += addDetailsButton_Click;
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Location = new Point(13, 336);
            tempLabel.Margin = new Padding(2, 0, 2, 0);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(198, 20);
            tempLabel.TabIndex = 25;
            tempLabel.Text = "Temperature (in Fahrenheit) :";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new Point(48, 399);
            pulseLabel.Margin = new Padding(2, 0, 2, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(46, 20);
            pulseLabel.TabIndex = 24;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomslabel
            // 
            symptomslabel.AutoSize = true;
            symptomslabel.Location = new Point(48, 467);
            symptomslabel.Margin = new Padding(2, 0, 2, 0);
            symptomslabel.Name = "symptomslabel";
            symptomslabel.Size = new Size(82, 20);
            symptomslabel.TabIndex = 23;
            symptomslabel.Text = "Symptoms:";
            // 
            // diaBPLabel
            // 
            diaBPLabel.AutoSize = true;
            diaBPLabel.Location = new Point(48, 265);
            diaBPLabel.Margin = new Padding(2, 0, 2, 0);
            diaBPLabel.Name = "diaBPLabel";
            diaBPLabel.Size = new Size(91, 20);
            diaBPLabel.TabIndex = 22;
            diaBPLabel.Text = "Diastolic BP:";
            // 
            // sysBpLabel
            // 
            sysBpLabel.AutoSize = true;
            sysBpLabel.Location = new Point(48, 199);
            sysBpLabel.Margin = new Padding(2, 0, 2, 0);
            sysBpLabel.Name = "sysBpLabel";
            sysBpLabel.Size = new Size(54, 20);
            sysBpLabel.TabIndex = 21;
            sysBpLabel.Text = "Sys BP:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(48, 128);
            weightLabel.Margin = new Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(142, 20);
            weightLabel.TabIndex = 20;
            weightLabel.Text = "Weight (in pounds) :";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(48, 64);
            heightLabel.Margin = new Padding(2, 0, 2, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(132, 20);
            heightLabel.TabIndex = 19;
            heightLabel.Text = "Height (in Inches) :";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(129, 15);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(177, 23);
            headerLabel.TabIndex = 37;
            headerLabel.Text = "Enter Routine details";
            // 
            // sysBPTextBox
            // 
            sysBPTextBox.Location = new Point(203, 197);
            sysBPTextBox.Margin = new Padding(2, 1, 2, 1);
            sysBPTextBox.Name = "sysBPTextBox";
            sysBPTextBox.Size = new Size(203, 27);
            sysBPTextBox.TabIndex = 3;
            sysBPTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.Location = new Point(203, 457);
            symptomsTextBox.Margin = new Padding(2, 1, 2, 1);
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(203, 97);
            symptomsTextBox.TabIndex = 7;
            symptomsTextBox.Text = "";
            symptomsTextBox.GotFocus += heightTextBox_GotFocus;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(266, 607);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(93, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // symptomsErrorLabel
            // 
            symptomsErrorLabel.AutoSize = true;
            symptomsErrorLabel.ForeColor = Color.Red;
            symptomsErrorLabel.Location = new Point(214, 568);
            symptomsErrorLabel.Margin = new Padding(2, 0, 2, 0);
            symptomsErrorLabel.Name = "symptomsErrorLabel";
            symptomsErrorLabel.Size = new Size(74, 20);
            symptomsErrorLabel.TabIndex = 38;
            symptomsErrorLabel.Text = "errorlabel";
            symptomsErrorLabel.Visible = false;
            // 
            // pulseErrorLabel
            // 
            pulseErrorLabel.AutoSize = true;
            pulseErrorLabel.ForeColor = Color.Red;
            pulseErrorLabel.Location = new Point(214, 429);
            pulseErrorLabel.Margin = new Padding(2, 0, 2, 0);
            pulseErrorLabel.Name = "pulseErrorLabel";
            pulseErrorLabel.Size = new Size(74, 20);
            pulseErrorLabel.TabIndex = 39;
            pulseErrorLabel.Text = "errorlabel";
            pulseErrorLabel.Visible = false;
            // 
            // temperatureErrorLabel
            // 
            temperatureErrorLabel.AutoSize = true;
            temperatureErrorLabel.ForeColor = Color.Red;
            temperatureErrorLabel.Location = new Point(214, 364);
            temperatureErrorLabel.Margin = new Padding(2, 0, 2, 0);
            temperatureErrorLabel.Name = "temperatureErrorLabel";
            temperatureErrorLabel.Size = new Size(74, 20);
            temperatureErrorLabel.TabIndex = 40;
            temperatureErrorLabel.Text = "errorlabel";
            temperatureErrorLabel.Visible = false;
            // 
            // diastolicErrorLabel
            // 
            diastolicErrorLabel.AutoSize = true;
            diastolicErrorLabel.ForeColor = Color.Red;
            diastolicErrorLabel.Location = new Point(214, 296);
            diastolicErrorLabel.Margin = new Padding(2, 0, 2, 0);
            diastolicErrorLabel.Name = "diastolicErrorLabel";
            diastolicErrorLabel.Size = new Size(74, 20);
            diastolicErrorLabel.TabIndex = 41;
            diastolicErrorLabel.Text = "errorlabel";
            diastolicErrorLabel.Visible = false;
            // 
            // systolicErrorLabel
            // 
            systolicErrorLabel.AutoSize = true;
            systolicErrorLabel.ForeColor = Color.Red;
            systolicErrorLabel.Location = new Point(214, 229);
            systolicErrorLabel.Margin = new Padding(2, 0, 2, 0);
            systolicErrorLabel.Name = "systolicErrorLabel";
            systolicErrorLabel.Size = new Size(74, 20);
            systolicErrorLabel.TabIndex = 42;
            systolicErrorLabel.Text = "errorlabel";
            systolicErrorLabel.Visible = false;
            // 
            // weightErrorLabel
            // 
            weightErrorLabel.AutoSize = true;
            weightErrorLabel.ForeColor = Color.Red;
            weightErrorLabel.Location = new Point(214, 157);
            weightErrorLabel.Margin = new Padding(2, 0, 2, 0);
            weightErrorLabel.Name = "weightErrorLabel";
            weightErrorLabel.Size = new Size(74, 20);
            weightErrorLabel.TabIndex = 43;
            weightErrorLabel.Text = "errorlabel";
            weightErrorLabel.Visible = false;
            // 
            // heightErrorLabel
            // 
            heightErrorLabel.AutoSize = true;
            heightErrorLabel.ForeColor = Color.Red;
            heightErrorLabel.Location = new Point(214, 93);
            heightErrorLabel.Margin = new Padding(2, 0, 2, 0);
            heightErrorLabel.Name = "heightErrorLabel";
            heightErrorLabel.Size = new Size(74, 20);
            heightErrorLabel.TabIndex = 44;
            heightErrorLabel.Text = "errorlabel";
            heightErrorLabel.Visible = false;
            // 
            // RoutineCheckup
            // 
            AcceptButton = addDetailsButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(463, 651);
            Controls.Add(heightErrorLabel);
            Controls.Add(weightErrorLabel);
            Controls.Add(systolicErrorLabel);
            Controls.Add(diastolicErrorLabel);
            Controls.Add(temperatureErrorLabel);
            Controls.Add(pulseErrorLabel);
            Controls.Add(symptomsErrorLabel);
            Controls.Add(cancelButton);
            Controls.Add(symptomsTextBox);
            Controls.Add(sysBPTextBox);
            Controls.Add(headerLabel);
            Controls.Add(weightTextBox);
            Controls.Add(diaBPTextBox);
            Controls.Add(tempTextBox);
            Controls.Add(pulseTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(errorLabel);
            Controls.Add(addDetailsButton);
            Controls.Add(tempLabel);
            Controls.Add(pulseLabel);
            Controls.Add(symptomslabel);
            Controls.Add(diaBPLabel);
            Controls.Add(sysBpLabel);
            Controls.Add(weightLabel);
            Controls.Add(heightLabel);
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RoutineCheckup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Routine Checkup Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox weightTextBox;
        private TextBox diaBPTextBox;
        private TextBox tempTextBox;
        private TextBox pulseTextBox;
        private TextBox heightTextBox;
        private Label errorLabel;
        private Button addDetailsButton;
        private Label tempLabel;
        private Label pulseLabel;
        private Label symptomslabel;
        private Label diaBPLabel;
        private Label sysBpLabel;
        private Label weightLabel;
        private Label heightLabel;
        private Label headerLabel;
        private TextBox sysBPTextBox;
        private RichTextBox symptomsTextBox;
        private Button cancelButton;
        private Label symptomsErrorLabel;
        private Label pulseErrorLabel;
        private Label temperatureErrorLabel;
        private Label diastolicErrorLabel;
        private Label systolicErrorLabel;
        private Label weightErrorLabel;
        private Label heightErrorLabel;
    }
}