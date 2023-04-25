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
        private TestList _testList;
        private List<TestList> ordered;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTestForm"/> class.
        /// </summary>
        public OrderTestForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
            allTestsComboBox.DataSource = _controller.GetTests();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var testToAdd = allTestsComboBox.SelectedItem as TestList;
            ordered.Add(new TestList
            {
                Id = testToAdd.Id,
                Name = testToAdd.Name,
            });
            RefreshList();
        }

        private void RefreshList()
        {
            testsDataGridView.DataSource = null;
            testsDataGridView.DataSource = ordered;
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
