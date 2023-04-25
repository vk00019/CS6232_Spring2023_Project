using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for order tests interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class OrderTestForm : Form
    {
        private int _visitId;
        private int index;
        private List<TestList> _ordered;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTestForm"/> class.
        /// </summary>
        public OrderTestForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _ordered = new List<TestList>();
            allTestsComboBox.DataSource = _controller.GetTests();
            allTestsComboBox.DisplayMember = "Name";

        }

        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var testToAdd = allTestsComboBox.SelectedItem as TestList;
            _ordered.Add(new TestList
            {
                Id = testToAdd.Id,
                Name = testToAdd.Name,
            });
            RefreshList();
        }

        private void RefreshList()
        {
            testsDataGridView.DataSource = null;
            testsDataGridView.DataSource = _ordered;
        }

        private void testsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                deleteButton.Enabled = false;
            }
            else
            {
                deleteButton.Enabled = true;
                if (testsDataGridView.SelectedRows[0] != null)
                { 
                    index = testsDataGridView.SelectedRows[0].Index;
                   // MessageBox.Show(index + "");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _ordered.RemoveAt(index);
            RefreshList();
        }

        private void reviewTestsButton_Click(object sender, EventArgs e)
        {
            if (_ordered.Count > 0)
            {
                using var reviewForm = new ReviewTests();
                reviewForm.SetTests(_ordered);
                reviewForm.SetVisitId(_visitId);
                reviewForm.ShowDialog();
                this.Close();

            }
            else
            {
                errorLabel.Text = @"Please select at least one test";
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
            }
        }

        private void allTestsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
