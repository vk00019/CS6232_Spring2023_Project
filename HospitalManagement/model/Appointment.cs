namespace HospitalManagement.Model
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime ScheduledTime { get; set; }
        public string Reason { get; set; }
    }
}
