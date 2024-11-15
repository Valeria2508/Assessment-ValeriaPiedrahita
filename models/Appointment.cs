using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.models
{
    [Table("appointment")]
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementable
        [Column("id")]
        public required int Id {get; set;}

        [Column("patient_id")]
        [Required]
        public required int PatientId {get; set;}

        [Column("doctor_id")]
        [Required]
        public required int DoctorId {get; set;}

        [Column("medical_historial_id")]
        [Required]
        public required int MedicalHistorialId {get; set;}

        [Column("date")]
        [Required]
        public required DateTime Date {get; set;}

        [Column("reason")]
        [Required]
        [MaxLength(255)]
        public required string Reason {get; set;}

        [ForeignKey("patient_id")]
        public virtual Patient Patients { get; set; }

        [ForeignKey("doctor_id")]
        public virtual Doctor Doctors { get; set; }

        [ForeignKey("medical_historial_id")]
        public virtual MedicalHisorial MedicalHistorials { get; set; }

    }
}