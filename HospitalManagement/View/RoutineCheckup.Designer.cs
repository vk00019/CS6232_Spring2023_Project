namespace HospitalManagement.View
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
            SuspendLayout();
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(203, 109);
            weightTextBox.Margin = new Padding(2, 1, 2, 1);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(203, 27);
            weightTextBox.TabIndex = 2;
            // 
            // diaBPTextBox
            // 
            diaBPTextBox.Location = new Point(203, 211);
            diaBPTextBox.Margin = new Padding(2, 1, 2, 1);
            diaBPTextBox.Name = "diaBPTextBox";
            diaBPTextBox.Size = new Size(203, 27);
            diaBPTextBox.TabIndex = 4;
            // 
            // tempTextBox
            // 
            tempTextBox.Location = new Point(203, 259);
            tempTextBox.Margin = new Padding(2, 1, 2, 1);
            tempTextBox.Name = "tempTextBox";
            tempTextBox.Size = new Size(203, 27);
            tempTextBox.TabIndex = 5;
            // 
            // pulseTextBox
            // 
            pulseTextBox.Location = new Point(203, 308);
            pulseTextBox.Margin = new Padding(2, 1, 2, 1);
            pulseTextBox.Name = "pulseTextBox";
            pulseTextBox.Size = new Size(203, 27);
            pulseTextBox.TabIndex = 6;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(203, 61);
            heightTextBox.Margin = new Padding(2, 1, 2, 1);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(203, 27);
            heightTextBox.TabIndex = 1;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(83, 465);
            errorLabel.Margin = new Padding(2, 0, 2, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(74, 20);
            errorLabel.TabIndex = 28;
            errorLabel.Text = "errorlabel";
            errorLabel.Visible = false;
            // 
            // addDetailsButton
            // 
            addDetailsButton.Location = new Point(77, 504);
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
            tempLabel.Location = new Point(48, 260);
            tempLabel.Margin = new Padding(2, 0, 2, 0);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new Size(96, 20);
            tempLabel.TabIndex = 25;
            tempLabel.Text = "Temperature:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new Point(48, 309);
            pulseLabel.Margin = new Padding(2, 0, 2, 0);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new Size(46, 20);
            pulseLabel.TabIndex = 24;
            pulseLabel.Text = "Pulse:";
            // 
            // symptomslabel
            // 
            symptomslabel.AutoSize = true;
            symptomslabel.Location = new Point(48, 361);
            symptomslabel.Margin = new Padding(2, 0, 2, 0);
            symptomslabel.Name = "symptomslabel";
            symptomslabel.Size = new Size(82, 20);
            symptomslabel.TabIndex = 23;
            symptomslabel.Text = "Symptoms:";
            // 
            // diaBPLabel
            // 
            diaBPLabel.AutoSize = true;
            diaBPLabel.Location = new Point(48, 212);
            diaBPLabel.Margin = new Padding(2, 0, 2, 0);
            diaBPLabel.Name = "diaBPLabel";
            diaBPLabel.Size = new Size(91, 20);
            diaBPLabel.TabIndex = 22;
            diaBPLabel.Text = "Diastolic BP:";
            // 
            // sysBpLabel
            // 
            sysBpLabel.AutoSize = true;
            sysBpLabel.Location = new Point(48, 161);
            sysBpLabel.Margin = new Padding(2, 0, 2, 0);
            sysBpLabel.Name = "sysBpLabel";
            sysBpLabel.Size = new Size(54, 20);
            sysBpLabel.TabIndex = 21;
            sysBpLabel.Text = "Sys BP:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(48, 112);
            weightLabel.Margin = new Padding(2, 0, 2, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(59, 20);
            weightLabel.TabIndex = 20;
            weightLabel.Text = "Weight:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(48, 64);
            heightLabel.Margin = new Padding(2, 0, 2, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(57, 20);
            heightLabel.TabIndex = 19;
            heightLabel.Text = "Height:";
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
            sysBPTextBox.Location = new Point(203, 160);
            sysBPTextBox.Margin = new Padding(2, 1, 2, 1);
            sysBPTextBox.Name = "sysBPTextBox";
            sysBPTextBox.Size = new Size(203, 27);
            sysBPTextBox.TabIndex = 3;
            // 
            // symptomsTextBox
            // 
            symptomsTextBox.Location = new Point(203, 352);
            symptomsTextBox.Margin = new Padding(2, 1, 2, 1);
            symptomsTextBox.Name = "symptomsTextBox";
            symptomsTextBox.Size = new Size(203, 97);
            symptomsTextBox.TabIndex = 7;
            symptomsTextBox.Text = "";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(266, 504);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(93, 29);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // RoutineCheckup
            // 
            AcceptButton = addDetailsButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(463, 545);
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
    }
}