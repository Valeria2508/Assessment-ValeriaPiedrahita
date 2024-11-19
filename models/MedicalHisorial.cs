using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.models
{
    [Table("medical_hisotials")]
    public class MedicalHisorial
    {
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementable
        [Column("id")]
        public required int Id {get; set;}

        [Column("patient_id")]
        [Required]
        public required int PatientId {get; set;}

        [Column("created_date")]
        [Required]
        public required DateTime CreatedDate {get; set;}

        [Column("diagnoses")]
        [Required]
        public required string Diagnoses {get; set;}

        [Column("medications")]
        [Required]
        public required string Medications {get; set;}

        [Column("allergies")]
        [Required]
        public required string Allergies {get; set;}

        [Column("details")]
        [Required]
        public required string Details {get; set;}

        [ForeignKey("PatientId")]
        public Patient Patients {get; set;} //patient is foreign key
    }
}