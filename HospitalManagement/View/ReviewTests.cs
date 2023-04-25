using HospitalManagement.model;

namespace HospitalManagement.View
{
    /// <summary>
    /// This class is used for review tests interface
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ReviewTests : Form
    {

        private List<TestList> _finalTests;
        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewTests"/> class.
        /// </summary>
        public ReviewTests()
        {
            InitializeComponent();
        }

        public void SetTests(List<TestList> finalTests)
        {
            _finalTests = finalTests;
        }
    }
}
