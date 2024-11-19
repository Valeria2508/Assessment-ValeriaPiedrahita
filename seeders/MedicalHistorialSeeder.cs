using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_ValeriaPiedrahita.seeders
{
    public class MedicalHistorialSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<MedicalHisorial>().HasData(
                new MedicalHisorial
                {
                    Id=1,
                    PatientId = 1,  // Asegúrate de que este Id exista en la tabla 'patients'
                    CreatedDate = new DateTime(2024, 1, 10),
                    Diagnoses = "Hipertensión",
                    Medications = "Atenolol",
                    Allergies = "Ninguna",
                    Details = "Consulta de control anual."
                },
                new MedicalHisorial
                {
                    Id=2,
                    PatientId = 2,
                    CreatedDate = new DateTime(2024, 2, 14),
                    Diagnoses = "Diabetes Tipo 2",
                    Medications = "Metformina",
                    Allergies = "Alergia al polen",
                    Details = "Control y seguimiento de niveles de glucosa."
                },
                new MedicalHisorial
                {
                    Id=3,
                    PatientId = 3,
                    CreatedDate = new DateTime(2024, 3, 20),
                    Diagnoses = "Asma",
                    Medications = "Salbutamol",
                    Allergies = "Alergia a los mariscos",
                    Details = "Receta para inhalador y seguimiento."
                }
            );
        }
    }
}