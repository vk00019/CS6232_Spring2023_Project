namespace HospitalManagement.View
{
    partial class OrderTestForm
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
            label1 = new Label();
            allTestsComboBox = new ComboBox();
            addButton = new Button();
            reviewTestsButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            testsDataGridView = new DataGridView();
            label2 = new Label();
            errorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 43);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose Tests:";
            // 
            // allTestsComboBox
            // 
            allTestsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            allTestsComboBox.FormattingEnabled = true;
            allTestsComboBox.Location = new Point(106, 71);
            allTestsComboBox.Margin = new Padding(3, 4, 3, 4);
            allTestsComboBox.Name = "allTestsComboBox";
            allTestsComboBox.Size = new Size(210, 28);
            allTestsComboBox.TabIndex = 1;
            allTestsComboBox.SelectedIndexChanged += allTestsComboBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(167, 120);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // reviewTestsButton
            // 
            reviewTestsButton.AutoSize = true;
            reviewTestsButton.Location = new Point(63, 348);
            reviewTestsButton.Margin = new Padding(3, 4, 3, 4);
            reviewTestsButton.Name = "reviewTestsButton";
            reviewTestsButton.Size = new Size(102, 33);
            reviewTestsButton.TabIndex = 4;
            reviewTestsButton.Text = "Review Tests";
            reviewTestsButton.UseVisualStyleBackColor = true;
            reviewTestsButton.Click += reviewTestsButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(173, 348);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(279, 348);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(86, 31);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // testsDataGridView
            // 
            testsDataGridView.AllowUserToAddRows = false;
            testsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testsDataGridView.Location = new Point(67, 159);
            testsDataGridView.Margin = new Padding(3, 4, 3, 4);
            testsDataGridView.MultiSelect = false;
            testsDataGridView.Name = "testsDataGridView";
            testsDataGridView.ReadOnly = true;
            testsDataGridView.RowHeadersWidth = 51;
            testsDataGridView.RowTemplate.Height = 25;
            testsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            testsDataGridView.Size = new Size(297, 181);
            testsDataGridView.TabIndex = 7;
            testsDataGridView.CellMouseClick += testsDataGridView_CellMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 12);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 8;
            label2.Text = "Add tests to review";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(184, 395);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(77, 20);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "errorLabel";
            errorLabel.Visible = false;
            // 
            // OrderTestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 443);
            Controls.Add(errorLabel);
            Controls.Add(label2);
            Controls.Add(testsDataGridView);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(reviewTestsButton);
            Controls.Add(addButton);
            Controls.Add(allTestsComboBox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderTestForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Test";
            ((System.ComponentModel.ISupportInitialize)testsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox allTestsComboBox;
        private Button addButton;
        private Button reviewTestsButton;
        private Button deleteButton;
        private Button cancelButton;
        private DataGridView testsDataGridView;
        private Label label2;
        private Label errorLabel;
    }
}