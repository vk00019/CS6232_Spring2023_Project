using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Model
{
    public class Visit
    {
        public int VisitId { get; set; }
        public int AppointmentId { get; set; }
        public int NurseId { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int SystolicBp { get; set; }
        public int DiastolicBp { get; set; }
        public decimal BodyTemperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }
        public string InitialDiagnosis { get; set; }
        public string FinalDiagnosis { get; set; }
    }
}
