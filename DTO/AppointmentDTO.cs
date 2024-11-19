using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.DTO
{
    public class AppointmentDTO
    {
        public required int Id { get; set; }
        public required int PatientId { get; set; }
        public required int DoctorId { get; set; }
        public required int MedicalHistorialId { get; set; }
        public required DateTime Date { get; set; } 
        public required string Reason { get; set; }
    }
}