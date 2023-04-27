using HospitalManagement.Controller;
using HospitalManagement.model;
using HospitalManagement.Model;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

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
        private BindingList<TestList> _ordered;
        private BindingList<TestList> _list;
        private readonly ManagementController _controller;
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderTestForm"/> class.
        /// </summary>
        public OrderTestForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
            _ordered = new BindingList<TestList>();
            _list = new BindingList<TestList>();

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
            _ordered.Add(testToAdd);
            _list.Remove(testToAdd);
            RefreshList();
        }

        private void RefreshList()
        {
            testsDataGridView.DataSource = null;
            testsDataGridView.DataSource = _ordered;
            allTestsComboBox.DataSource = _list;
            allTestsComboBox.DisplayMember = "Name";
        }

        private void testsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                deleteButton.Enabled = true;
                if (testsDataGridView.SelectedRows[0] != null || testsDataGridView.SelectedRows.Count <= 0)
                {
                    index = testsDataGridView.SelectedRows[0].Index;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            _list.Add(_ordered[index]);
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

        private void UpdateTestList()
        {
            foreach (var test in _controller.GetTests())
            {
                bool adder = false;
                foreach (var ordered in _controller.GetOrderedTests(_visitId))
                {
                    if (test.Name.Equals(ordered.Name))
                    {
                        adder = false;
                        break;
                    }
                    else
                    {
                        adder = true;
                    }
                }
                if (adder)
                {
                    _list.Add(test);
                }
            }

            //foreach (var ordered in _controller.GetOrderedTests(_visitId))
            //{
            //    _list.Remove(ordered);
            //}

            //for (int i = 0; i < _controller.GetOrderedTests(_visitId).Count; i++)
            //{
            //    var ordered = _controller.GetOrderedTests(_visitId)[i];
            //    foreach (var current in _list)
            //    {
            //        if (!current.Name.Equals(ordered.Name))
            //        {
            //            _list.Remove(current);
            //        }
            //    }
            //}

            //var list = _controller.GetTests().Except(_controller.GetOrderedTests(_visitId));

            //foreach (var test in list)
            //{
            //    _list.Add(test);
            //}
        }

        private void OrderTestForm_Load(object sender, EventArgs e)
        {
            UpdateTestList();
            RefreshList();
        }
    }
}
