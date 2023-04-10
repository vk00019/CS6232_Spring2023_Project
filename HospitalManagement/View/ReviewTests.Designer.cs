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
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.orderTestsButton = new System.Windows.Forms.Button();
            this.reviewTestsListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.orderedTestsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(264, 274);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(171, 274);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(75, 274);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(82, 25);
            this.orderTestsButton.TabIndex = 11;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            // 
            // reviewTestsListView
            // 
            this.reviewTestsListView.Location = new System.Drawing.Point(118, 138);
            this.reviewTestsListView.Name = "reviewTestsListView";
            this.reviewTestsListView.Size = new System.Drawing.Size(184, 97);
            this.reviewTestsListView.TabIndex = 10;
            this.reviewTestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(171, 98);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // orderedTestsComboBox
            // 
            this.orderedTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderedTestsComboBox.FormattingEnabled = true;
            this.orderedTestsComboBox.Location = new System.Drawing.Point(118, 61);
            this.orderedTestsComboBox.Name = "orderedTestsComboBox";
            this.orderedTestsComboBox.Size = new System.Drawing.Size(184, 23);
            this.orderedTestsComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Tests:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(141, 249);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(38, 15);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "label2";
            this.errorLabel.Visible = false;
            // 
            // ReviewTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 322);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.orderTestsButton);
            this.Controls.Add(this.reviewTestsListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderedTestsComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewTests";
            this.Text = "Review Tests";
            this.ResumeLayout(false);
            this.PerformLayout();

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