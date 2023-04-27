namespace HospitalManagement.model
{
    /// <summary>
    /// Keeps track of test result ordered for patient
    /// </summary>
    public class PatientTest
    {
        /// <summary>
        /// Gets or sets the visit identifier.
        /// </summary>
        /// <value>
        /// The visit identifier.
        /// </value>
        public int VisitId { get; set; }

        /// <summary>
        /// Gets or sets the test identifier.
        /// </summary>
        /// <value>
        /// The test identifier.
        /// </value>
        public int TestId { get; set; }

        /// <summary>
        /// Gets or sets the name of the test.
        /// </summary>
        /// <value>
        /// The name of the test.
        /// </value>
        public string TestName { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets the performed date.
        /// </summary>
        /// <value>
        /// The performed date.
        /// </value>
        public DateTime PerformedDate { get; set; }

        /// <summary>
        /// Gets or sets the normality.
        /// </summary>
        /// <value>
        /// The normality.
        /// </value>
        public string Normality {get; set; }
    }
}
