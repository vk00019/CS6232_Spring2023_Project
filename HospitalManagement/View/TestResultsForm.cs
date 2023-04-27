using HospitalManagement.Controller;
using HospitalManagement.model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for test results interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TestResultsForm : Form
    {
        private readonly ManagementController _controller;
        private int _visitId;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestResultsForm"/> class.
        /// </summary>
        public TestResultsForm()
        {
            InitializeComponent();
            _controller = new ManagementController();
        }

        /// <summary>
        /// Sets the visit identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SetVisitId(int id)
        {
            _visitId = id;
        }

        private List<string> GetNormalityList()
        {
            List<string> list = new List<string>
            {
                "Normal",
                "Abnormal"
            };
            return list;
        }

        private void TestResultsForm_Load(object sender, EventArgs e)
        {
            SetOrderTests();
            normalComboBox.DataSource = GetNormalityList();

            datePicker.MaxDate = DateTime.Now;
            datePicker.Value = DateTime.Today;
            timePicker.Value = DateTime.Now;
            RefreshDataGridView();
        }

        private void SetOrderTests()
        {
            List<TestList> testLists = _controller.GetOrderedTests(_visitId);
            orderedTestsComboBox.DataSource = testLists;
            orderedTestsComboBox.DisplayMember = "Name";
            orderedTestsComboBox.ValueMember = "Id";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            CheckAllFields();
            if (errorLabel.Visible)
            {
                errorLabel.Text = "Please fill all the fields above";
                errorLabel.ForeColor = Color.Red;
            }
            else
            {
                var performedDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                    timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
                var selectedTest = orderedTestsComboBox.SelectedItem as TestList;
                string testResult = testResultTextBox.Text;
                string normality = normalComboBox.SelectedItem.ToString();

                var patientTest = new PatientTest
                {
                    VisitId = _visitId,
                    TestId = selectedTest.Id,
                    TestName = selectedTest.Name,
                    PerformedDate = performedDateTime,
                    Result = testResult,
                    Normality = normality
                };
                _controller.UpdatePatientTests(patientTest);
                errorLabel.Visible = true;
                errorLabel.Text = "Test result added successfully";
                errorLabel.ForeColor = Color.Green;
                SetOrderTests();
                RefreshDataGridView();
            }
        }

        /// <summary>
        /// Refreshes the data in the list view.
        /// </summary>
        public void RefreshDataGridView()
        {
            testsResultsDataGridView.Rows.Clear();
            List<PatientTest> testsList = _controller.GePatientTestsResults(_visitId);
            if (testsList.Count > 0)
            {
                testsResultsDataGridView.Visible = true;
                foreach (PatientTest currentTest in testsList)
                {
                    DataGridViewRow currentRow = testsResultsDataGridView.Rows[testsResultsDataGridView.Rows.Add()];
                    currentRow.Cells[testNameDgv.Index].Value = currentTest.TestName;
                    currentRow.Cells[testResultDgv.Index].Value = currentTest.Result;
                    currentRow.Cells[performedAtDgv.Index].Value = currentTest.PerformedDate;
                    currentRow.Cells[normalityDgv.Index].Value = currentTest.Normality;
                }
            }
            else
            {
                testsResultsDataGridView.Visible = false;
                errorLabel.Visible = true;
                errorLabel.Text = "There are no tests results available for this patient yet";
                errorLabel.ForeColor = Color.Black;
            }
        }

        private void CheckAllFields()
        {
            if (string.IsNullOrEmpty(testResultTextBox.Text))
            {
                errorLabel.Visible = true;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
