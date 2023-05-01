using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;
using System;
using System.ComponentModel;
using System.Reflection;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for review tests interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReviewTests : Form
    {

        private int index;
        private int _visitId;
        private readonly ManagementController _controller;
        private BindingList<TestList> _finalTests;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewTests"/> class.
        /// </summary>
        public ReviewTests()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _finalTests = new BindingList<TestList>();
            RefreshList();
        }

        public void SetTests(BindingList<TestList> finalTests)
        {
            foreach (var currentTest in finalTests)
            {
                _finalTests.Add(currentTest);
            }
        }

        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private void RefreshList()
        {
            reviewTestsDataGridView.DataSource = null;
            reviewTestsDataGridView.DataSource = _finalTests;
            reviewTestsDataGridView.ClearSelection();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _finalTests.RemoveAt(index);
            deleteButton.Enabled = false;
            RefreshList();
            if (_finalTests.Count == 0)
            {
                orderTestsButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private void orderTestsButton_Click(object sender, EventArgs e)
        {
            foreach (var currentTest in _finalTests)
            {
                _controller.OrderTests(_visitId, currentTest.Id);
            }
            DialogResult = DialogResult.OK;
            this.Close();
            MessageBox.Show("Sucessfully ordered the tests");
        }

        private void ReviewTestsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (reviewTestsDataGridView.SelectedRows[0] != null || reviewTestsDataGridView.SelectedRows.Count <= 0)
                {
                    index = reviewTestsDataGridView.SelectedRows[0].Index;
                }
            }
        }
    }
}
