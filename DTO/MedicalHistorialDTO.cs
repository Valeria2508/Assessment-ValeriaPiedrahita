using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.DTO
{
    public class MedicalHistorialDTO
    {
        public required int Id {get; set; }
        public required int PatientId {get; set;}
        public required DateTime CreatedDate {get; set;}
        public required string Diagnoses {get; set;}
        public required string Medications {get; set;}
        public required string Allergies {get; set;}
        public required string Details {get; set;}
    }
}