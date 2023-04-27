namespace HospitalManagement.Model
{
    /// <summary>
    /// This class is used for visit object
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Visit"/> class.
        /// </summary>
        public Visit()
        {
            InitialDiagnosis = "";
            FinalDiagnosis = "";
            Symptoms = "";
        }

        /// <summary>
        /// Gets or sets the visit identifier.
        /// </summary>
        /// <value>
        /// The visit identifier.
        /// </value>
        public int VisitId { get; set; }
        public DateTime AppointmentDate { get; set; }
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
        private decimal _height;
        public decimal Height
        {
            get => _height;

            set
            {
                if(value == -1)
                {
                    _height = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _height = value;
            }
        }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        private decimal _weight;
        public decimal Weight
        {
            get => _weight;

            set
            {
                if (value == -1)
                {
                    _weight = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _weight = value;
            }
        }
        /// <summary>
        /// Gets or sets the systolic bp.
        /// </summary>
        /// <value>
        /// The systolic bp.
        /// </value>
        private decimal _systolicBp;
        public decimal SystolicBp
        {
            get => _systolicBp;

            set
            {
                if (value == -1)
                {
                    _systolicBp = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _systolicBp = value;
            }
        }
        /// <summary>
        /// Gets or sets the diastolic bp.
        /// </summary>
        /// <value>
        /// The diastolic bp.
        /// </value>
        private decimal _diastolicBp;
        public decimal DiastolicBp
        {
            get => _diastolicBp;

            set
            {
                if (value == -1)
                {
                    _diastolicBp = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _diastolicBp = value;
            }
        }
        /// <summary>
        /// Gets or sets the body temperature.
        /// </summary>
        /// <value>
        /// The body temperature.
        /// </value>
        private decimal _bodyTempterature;
        public decimal BodyTemperature
        {
            get => _bodyTempterature;

            set
            {
                if (value == -1)
                {
                    _bodyTempterature = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _bodyTempterature = value;
            }
        }
        /// <summary>
        /// Gets or sets the pulse.
        /// </summary>
        /// <value>
        /// The pulse.
        /// </value>
        private decimal _pulse;
        public decimal Pulse
        {
            get => _pulse;

            set
            {
                if (value == -1)
                {
                    _pulse = 0;
                }
                else if (value < 0)
                {
                    throw new Exception("");
                }
                _pulse = value;
            }
        }
        /// <summary>
        /// Gets or sets the symptoms.
        /// </summary>
        /// <value>
        /// The symptoms.
        /// </value>
        public string Symptoms
        {
            get; set;
        }
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

        public string NurseName { get; set; }
        
    }
}
