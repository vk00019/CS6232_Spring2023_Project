﻿namespace HospitalManagement.View
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
            this.label1 = new System.Windows.Forms.Label();
            this.allTestsComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.orderTestsListView = new System.Windows.Forms.ListView();
            this.reviewTestsButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Tests:";
            // 
            // allTestsComboBox
            // 
            this.allTestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allTestsComboBox.FormattingEnabled = true;
            this.allTestsComboBox.Location = new System.Drawing.Point(93, 53);
            this.allTestsComboBox.Name = "allTestsComboBox";
            this.allTestsComboBox.Size = new System.Drawing.Size(184, 23);
            this.allTestsComboBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(146, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // orderTestsListView
            // 
            this.orderTestsListView.Location = new System.Drawing.Point(93, 130);
            this.orderTestsListView.Name = "orderTestsListView";
            this.orderTestsListView.Size = new System.Drawing.Size(184, 97);
            this.orderTestsListView.TabIndex = 3;
            this.orderTestsListView.UseCompatibleStateImageBehavior = false;
            // 
            // reviewTestsButton
            // 
            this.reviewTestsButton.AutoSize = true;
            this.reviewTestsButton.Location = new System.Drawing.Point(50, 250);
            this.reviewTestsButton.Name = "reviewTestsButton";
            this.reviewTestsButton.Size = new System.Drawing.Size(82, 25);
            this.reviewTestsButton.TabIndex = 4;
            this.reviewTestsButton.Text = "Review Tests";
            this.reviewTestsButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(146, 250);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(239, 250);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 307);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.reviewTestsButton);
            this.Controls.Add(this.orderTestsListView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.allTestsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "OrderTestForm";
            this.Text = "Order Test";
            this.ResumeLayout(false);
            this.PerformLayout();

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