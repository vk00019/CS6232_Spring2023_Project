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

        private void TestResultsForm_Load(object sender, EventArgs e)
        {
            List<TestList> testLists = _controller.GetOrderedTests(_visitId);
            orderedTestsComboBox.DataSource = testLists;
            orderedTestsComboBox.DisplayMember = "Name";
            orderedTestsComboBox.ValueMember = "Id";
        }
    }
}
