namespace HospitalManagement.View
{
    partial class SearchPatientBy
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
            this.menuUserControl = new HospitalManagement.UserControls.MenuUserControl();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.fnLnRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLnRadioButton = new System.Windows.Forms.RadioButton();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnametextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuUserControl
            // 
            this.menuUserControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuUserControl.Location = new System.Drawing.Point(0, 0);
            this.menuUserControl.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.menuUserControl.Name = "menuUserControl";
            this.menuUserControl.Size = new System.Drawing.Size(962, 98);
            this.menuUserControl.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(21, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(304, 32);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Search Patient Based On: ";
            // 
            // dobRadioButton
            // 
            this.dobRadioButton.AutoSize = true;
            this.dobRadioButton.Checked = true;
            this.dobRadioButton.Location = new System.Drawing.Point(31, 156);
            this.dobRadioButton.Name = "dobRadioButton";
            this.dobRadioButton.Size = new System.Drawing.Size(181, 36);
            this.dobRadioButton.TabIndex = 2;
            this.dobRadioButton.TabStop = true;
            this.dobRadioButton.Text = "Date of Birth";
            this.dobRadioButton.UseVisualStyleBackColor = true;
            this.dobRadioButton.CheckedChanged += new System.EventHandler(this.dobRadioButton_CheckedChanged);
            // 
            // fnLnRadioButton
            // 
            this.fnLnRadioButton.AutoSize = true;
            this.fnLnRadioButton.Location = new System.Drawing.Point(630, 156);
            this.fnLnRadioButton.Name = "fnLnRadioButton";
            this.fnLnRadioButton.Size = new System.Drawing.Size(255, 36);
            this.fnLnRadioButton.TabIndex = 3;
            this.fnLnRadioButton.Text = "First and Last Name";
            this.fnLnRadioButton.UseVisualStyleBackColor = true;
            this.fnLnRadioButton.CheckedChanged += new System.EventHandler(this.fnLnRadioButton_CheckedChanged);
            // 
            // dobLnRadioButton
            // 
            this.dobLnRadioButton.AutoSize = true;
            this.dobLnRadioButton.Location = new System.Drawing.Point(262, 156);
            this.dobLnRadioButton.Name = "dobLnRadioButton";
            this.dobLnRadioButton.Size = new System.Drawing.Size(343, 36);
            this.dobLnRadioButton.TabIndex = 4;
            this.dobLnRadioButton.Text = "Date of Birth and Last name";
            this.dobLnRadioButton.UseVisualStyleBackColor = true;
            this.dobLnRadioButton.CheckedChanged += new System.EventHandler(this.dobLnRadioButton_CheckedChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(381, 304);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(328, 39);
            this.lastnameTextBox.TabIndex = 31;
            this.lastnameTextBox.Visible = false;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(124, 236);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(217, 32);
            this.dobLabel.TabIndex = 30;
            this.dobLabel.Text = "Enter Date of Birth:";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDateTimePicker.Location = new System.Drawing.Point(381, 236);
            this.dobDateTimePicker.MaxDate = new System.DateTime(2023, 4, 10, 0, 0, 0, 0);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(224, 39);
            this.dobDateTimePicker.TabIndex = 32;
            this.dobDateTimePicker.Value = new System.DateTime(2023, 4, 10, 0, 0, 0, 0);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(124, 307);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(189, 32);
            this.lastnameLabel.TabIndex = 33;
            this.lastnameLabel.Text = "Enter Last name:";
            this.lastnameLabel.Visible = false;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(124, 388);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(188, 32);
            this.firstnameLabel.TabIndex = 35;
            this.firstnameLabel.Text = "Enter first name:";
            this.firstnameLabel.Visible = false;
            // 
            // firstnametextBox
            // 
            this.firstnametextBox.Location = new System.Drawing.Point(381, 385);
            this.firstnametextBox.Name = "firstnametextBox";
            this.firstnametextBox.Size = new System.Drawing.Size(328, 39);
            this.firstnametextBox.TabIndex = 34;
            this.firstnametextBox.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(223, 480);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 46);
            this.searchButton.TabIndex = 36;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(517, 480);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 46);
            this.clearButton.TabIndex = 37;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(272, 554);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(165, 32);
            this.errorLabel.TabIndex = 38;
            this.errorLabel.Text = "error message";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(101, 636);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.RowHeadersWidth = 82;
            this.searchDataGridView.RowTemplate.Height = 41;
            this.searchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchDataGridView.Size = new System.Drawing.Size(700, 300);
            this.searchDataGridView.TabIndex = 39;
            this.searchDataGridView.Visible = false;
            // 
            // viewButton
            // 
            this.viewButton.AutoSize = true;
            this.viewButton.Location = new System.Drawing.Point(223, 998);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(155, 46);
            this.viewButton.TabIndex = 40;
            this.viewButton.Text = "View Patient";
            this.viewButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(512, 998);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(155, 46);
            this.editButton.TabIndex = 41;
            this.editButton.Text = "Edit Patient";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // SearchPatientBy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 1094);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.viewButton);
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
            this.Controls.Add(this.menuUserControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchPatientBy";
            this.Text = "Search Patient";
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.MenuUserControl menuUserControl;
        private Label nameLabel;
        private RadioButton dobRadioButton;
        private RadioButton fnLnRadioButton;
        private RadioButton dobLnRadioButton;
        private TextBox lastnameTextBox;
        private Label dobLabel;
        private DateTimePicker dobDateTimePicker;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private TextBox firstnametextBox;
        private Button searchButton;
        private Button clearButton;
        private Label errorLabel;
        private DataGridView searchDataGridView;
        private Button viewButton;
        private Button editButton;
    }
}