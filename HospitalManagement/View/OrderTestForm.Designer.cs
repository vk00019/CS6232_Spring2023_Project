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
            orderTestsListView = new ListView();
            reviewTestsButton = new Button();
            deleteButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose Tests:";
            // 
            // allTestsComboBox
            // 
            allTestsComboBox.FormattingEnabled = true;
            allTestsComboBox.Location = new Point(93, 53);
            allTestsComboBox.Name = "allTestsComboBox";
            allTestsComboBox.Size = new Size(184, 23);
            allTestsComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(146, 90);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsListView
            // 
            orderTestsListView.Location = new Point(93, 130);
            orderTestsListView.Name = "orderTestsListView";
            orderTestsListView.Size = new Size(184, 97);
            orderTestsListView.TabIndex = 3;
            orderTestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // reviewTestsButton
            // 
            reviewTestsButton.AutoSize = true;
            reviewTestsButton.Location = new Point(50, 250);
            reviewTestsButton.Name = "reviewTestsButton";
            reviewTestsButton.Size = new Size(82, 25);
            reviewTestsButton.TabIndex = 4;
            reviewTestsButton.Text = "Review Tests";
            reviewTestsButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(146, 250);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(239, 250);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 307);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(reviewTestsButton);
            Controls.Add(orderTestsListView);
            Controls.Add(addButton);
            Controls.Add(allTestsComboBox);
            Controls.Add(label1);
            Name = "OrderTestForm";
            Text = "Order Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox allTestsComboBox;
        private Button addButton;
        private ListView orderTestsListView;
        private Button reviewTestsButton;
        private Button deleteButton;
        private Button cancelButton;
    }
}