using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_ValeriaPiedrahita.seeders
{
    public class AppointmentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id=1,
                    PatientId = 1,  // Asegúrate de que este Id exista en la tabla 'patients'
                    DoctorId = 1,   // Asegúrate de que este Id exista en la tabla 'doctors'
                    MedicalHistorialId = 1,  // Asegúrate de que este Id exista en la tabla 'medical_historials'
                    Date = new DateTime(2024, 11, 18, 10, 0, 0),  // Fecha de la cita: 18 de noviembre de 2024 a las 10:00 AM
                    Reason = "Consulta de control"
                },
                new Appointment
                {
                    Id=2,
                    PatientId = 2,
                    DoctorId = 2,
                    MedicalHistorialId = 2,
                    Date = new DateTime(2024, 11, 19, 14, 30, 0),  // Fecha de la cita: 19 de noviembre de 2024 a las 14:30
                    Reason = "Dolor de cabeza persistente"
                },
                new Appointment
                {
                    Id=3,
                    PatientId = 3,
                    DoctorId = 3,
                    MedicalHistorialId = 3,
                    Date = new DateTime(2024, 11, 20, 9, 0, 0),
                    Reason = "Chequeo preventivo"
                }
            );
        }
    }
}