namespace HospitalManagement.UserControls
{
    public partial class SearchPatientVisitByUserControl : UserControl
    {
        public SearchPatientVisitByUserControl()
        {
            InitializeComponent();
        }

        private void DobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = false;
            lastnameTextBox.Visible = false;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void DobLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = true;
            dobDateTimePicker.Visible = true;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = false;
            firstnametextBox.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void FnLnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dobLabel.Visible = false;
            dobDateTimePicker.Visible = false;
            lastnameLabel.Visible = true;
            lastnameTextBox.Visible = true;
            firstnameLabel.Visible = true;
            firstnametextBox.Visible = true;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
            errorLabel.Visible = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dobDateTimePicker.ResetText();
            firstnametextBox.Clear();
            lastnameTextBox.Clear();
            errorLabel.Visible = false;
            searchDataGridView.Visible = false;
            viewButton.Visible = false;
            editButton.Visible = false;
        }
    }
}
