using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_ValeriaPiedrahita.models
{
    [Table("patients")] //table name
    public class Patient
    {
        [Key] //primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id autoincrementable
        [Column("id")]
        public required int Id {get; set;}

        [Column("first_name")]
        [Required]
        public required string First_Name {get; set;}

        [Column("last_name")]
        [Required]
        public required string Last_Name {get; set;}

        [Column("email")]
        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public required string Email {get; set;}

        [Column("password")]
        [Required]
        [MaxLength(15)]
        public required string Password {get; set;}

        [Column("date_of_birth")]
        [Required]
        public required DateTime DateOfBirth {get; set;}

        [Column("Identification_number")]
        [Required]
        [MaxLength(30)]
        public required string IdentificationNumber {get; set;}

    }
}