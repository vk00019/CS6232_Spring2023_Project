using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for review tests interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReviewTests : Form
    {

        private TestList _testList;
        private int _visitId;
        private readonly ManagementController _controller;
        private List<TestList> _finalTests;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewTests"/> class.
        /// </summary>
        public ReviewTests()
        {
            InitializeComponent();
            _controller = new ManagementController();
            RefreshList();
        }

        public void SetTests(List<TestList> finalTests)
        {
            _finalTests = finalTests;
        }

        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private void RefreshList()
        {
            testsDataGridView.DataSource = null;
            testsDataGridView.DataSource = _finalTests;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void orderTestsButton_Click(object sender, EventArgs e)
        {
            foreach (var currentTest in _finalTests)
            {
                _controller.OrderTests(_visitId, currentTest.Id);
            }
            errorLabel.Text = @"Successfully added tests";
            errorLabel.ForeColor = Color.Green;
            errorLabel.Visible = true;
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
                    _testList.Id = Int32.Parse(testsDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    _testList.Name = testsDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                }
            }
        }
    }
}
