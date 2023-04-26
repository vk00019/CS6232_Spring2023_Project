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
            this.errorLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.reviewTestsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reviewTestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(507, 401);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 49);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(334, 401);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 49);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // orderTestsButton
            // 
            this.orderTestsButton.AutoSize = true;
            this.orderTestsButton.Location = new System.Drawing.Point(156, 401);
            this.orderTestsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.orderTestsButton.Name = "orderTestsButton";
            this.orderTestsButton.Size = new System.Drawing.Size(152, 53);
            this.orderTestsButton.TabIndex = 11;
            this.orderTestsButton.Text = "Order Tests";
            this.orderTestsButton.UseVisualStyleBackColor = true;
            this.orderTestsButton.Click += new System.EventHandler(this.orderTestsButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(362, 469);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(121, 32);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.Visible = false;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(297, 19);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(227, 32);
            this.orderLabel.TabIndex = 16;
            this.orderLabel.Text = "Select tests to order";
            // 
            // reviewTestsDataGridView
            // 
            this.reviewTestsDataGridView.AllowUserToAddRows = false;
            this.reviewTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewTestsDataGridView.Location = new System.Drawing.Point(156, 68);
            this.reviewTestsDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reviewTestsDataGridView.MultiSelect = false;
            this.reviewTestsDataGridView.Name = "reviewTestsDataGridView";
            this.reviewTestsDataGridView.RowHeadersWidth = 82;
            this.reviewTestsDataGridView.RowTemplate.Height = 25;
            this.reviewTestsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reviewTestsDataGridView.Size = new System.Drawing.Size(490, 320);
            this.reviewTestsDataGridView.TabIndex = 17;
            this.reviewTestsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ReviewTestsDataGridView_CellMouseClick);
            // 
            // ReviewTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 525);
            this.Controls.Add(this.reviewTestsDataGridView);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.orderTestsButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Tests";
            ((System.ComponentModel.ISupportInitialize)(this.reviewTestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
        private Button deleteButton;
        private Button orderTestsButton;
        private Label errorLabel;
        private Label orderLabel;
        private DataGridView reviewTestsDataGridView;
    }
}