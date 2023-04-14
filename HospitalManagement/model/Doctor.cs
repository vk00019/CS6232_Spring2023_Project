namespace HospitalManagement.Model
{
    /// <summary>
    /// This class is used for doctor object
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// Gets or sets the doctor identifier.
        /// </summary>
        /// <value>
        /// The doctor identifier.
        /// </value>
        public int doctorID { get; set; }

        /// <summary>
        /// Gets or sets the pd identifier.
        /// </summary>
        /// <value>
        /// The pd identifier.
        /// </value>
        public int pdID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

    }
}
