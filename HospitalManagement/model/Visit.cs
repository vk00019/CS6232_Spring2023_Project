namespace HospitalManagement.Model
{
    /// <summary>
    /// This class is used for visit object
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// Gets or sets the visit identifier.
        /// </summary>
        /// <value>
        /// The visit identifier.
        /// </value>
        public int VisitId { get; set; }
        /// <summary>
        /// Gets or sets the appointment identifier.
        /// </summary>
        /// <value>
        /// The appointment identifier.
        /// </value>
        public int AppointmentId { get; set; }
        /// <summary>
        /// Gets or sets the nurse identifier.
        /// </summary>
        /// <value>
        /// The nurse identifier.
        /// </value>
        public int NurseId { get; set; }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public decimal Height { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public decimal Weight { get; set; }
        /// <summary>
        /// Gets or sets the systolic bp.
        /// </summary>
        /// <value>
        /// The systolic bp.
        /// </value>
        public int SystolicBp { get; set; }
        /// <summary>
        /// Gets or sets the diastolic bp.
        /// </summary>
        /// <value>
        /// The diastolic bp.
        /// </value>
        public int DiastolicBp { get; set; }
        /// <summary>
        /// Gets or sets the body temperature.
        /// </summary>
        /// <value>
        /// The body temperature.
        /// </value>
        public decimal BodyTemperature { get; set; }
        /// <summary>
        /// Gets or sets the pulse.
        /// </summary>
        /// <value>
        /// The pulse.
        /// </value>
        public int Pulse { get; set; }
        /// <summary>
        /// Gets or sets the symptoms.
        /// </summary>
        /// <value>
        /// The symptoms.
        /// </value>
        public string Symptoms { get; set; }
        /// <summary>
        /// Gets or sets the initial diagnosis.
        /// </summary>
        /// <value>
        /// The initial diagnosis.
        /// </value>
        public string InitialDiagnosis { get; set; }
        /// <summary>
        /// Gets or sets the final diagnosis.
        /// </summary>
        /// <value>
        /// The final diagnosis.
        /// </value>
        public string FinalDiagnosis { get; set; }

        /// <summary>
        /// Gets or sets the name of the doctor.
        /// </summary>
        /// <value>
        /// The name of the doctor.
        /// </value>
        public string DoctorName { get; set; }

        /// <summary>
        /// Gets or sets the name of the patient.
        /// </summary>
        /// <value>
        /// The name of the patient.
        /// </value>
        public string PatientName { get; set; }
    }
}
