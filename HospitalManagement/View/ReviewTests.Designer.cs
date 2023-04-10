namespace HospitalManagement.View
{
    partial class ReviewTests
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
            cancelButton = new Button();
            deleteButton = new Button();
            orderTestsButton = new Button();
            reviewTestsListView = new ListView();
            addButton = new Button();
            orderedTestsComboBox = new ComboBox();
            label1 = new Label();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(264, 274);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(171, 274);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            orderTestsButton.AutoSize = true;
            orderTestsButton.Location = new Point(75, 274);
            orderTestsButton.Name = "orderTestsButton";
            orderTestsButton.Size = new Size(82, 25);
            orderTestsButton.TabIndex = 11;
            orderTestsButton.Text = "Order Tests";
            orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // reviewTestsListView
            // 
            reviewTestsListView.Location = new Point(118, 138);
            reviewTestsListView.Name = "reviewTestsListView";
            reviewTestsListView.Size = new Size(184, 97);
            reviewTestsListView.TabIndex = 10;
            reviewTestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(171, 98);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            orderedTestsComboBox.FormattingEnabled = true;
            orderedTestsComboBox.Location = new Point(118, 61);
            orderedTestsComboBox.Name = "orderedTestsComboBox";
            orderedTestsComboBox.Size = new Size(184, 23);
            orderedTestsComboBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Choose Tests:";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(141, 249);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 14;
            errorLabel.Text = "label2";
            errorLabel.Visible = false;
            // 
            // ReviewTests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 322);
            Controls.Add(errorLabel);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(orderTestsButton);
            Controls.Add(reviewTestsListView);
            Controls.Add(addButton);
            Controls.Add(orderedTestsComboBox);
            Controls.Add(label1);
            Name = "ReviewTests";
            Text = "Review Tests";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button deleteButton;
        private Button orderTestsButton;
        private ListView reviewTestsListView;
        private Button addButton;
        private ComboBox orderedTestsComboBox;
        private Label label1;
        private Label errorLabel;
    }
}