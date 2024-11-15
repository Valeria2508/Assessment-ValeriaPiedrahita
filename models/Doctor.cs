using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.models
{
    [Table("doctors")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementable
        [Column("id")]
        public required int Id {get; set;}

        [Column("first_name")]
        [Required]
        public required string First_Name {get; set;}

        [Column("last_name")]
        [Required]
        public required string Last_Name {get; set;}

        [Column("specialization")]
        [Required]
        public required string Specialization {get; set;}

        [Column("start_time ")]
        [Required]
        public required TimeOnly StartTime {get; set;}

        [Column("end_time")]
        [Required]
        public required TimeOnly EndTime {get; set;}

        [Column("aviable")]
        [Required]
        public required bool Available {get; set;}

        [Column("email")]
        [Required]
        [MaxLength(50)]
        public required string Email {get; set;}

        [Column("password")]
        [Required]
        [MaxLength(15)]
        public required string Password {get; set;}

        [Column("Identification_number")]
        [Required]
        [MaxLength(30)]
        public required string IdentificationNumber {get; set;}

    }
}