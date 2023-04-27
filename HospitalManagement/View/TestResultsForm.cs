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
            List<TestList> testLists = _controller.GetOrderedTests(_visitId);
            orderedTestsComboBox.DataSource = testLists;
            orderedTestsComboBox.DisplayMember = "Name";
            orderedTestsComboBox.ValueMember = "Id";

            normalComboBox.DataSource = GetNormalityList();
            datePicker.MaxDate = DateTime.Today;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var performedDateTime = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day,
                timePicker.Value.Hour, timePicker.Value.Minute, timePicker.Value.Second);
            var selectedTest = orderedTestsComboBox.SelectedItem as TestList;
            string testResult = testResultTextBox.Text;
            string normality = normalComboBox.SelectedText;

            var patientTest = new PatientTest
            {
                VisitId = _visitId,
                TestId = selectedTest.Id,
                TestName = selectedTest.Name,
                PerformedDate = performedDateTime,
                Result = testResult,
                Normality = normality
            };

        }
    }
}
