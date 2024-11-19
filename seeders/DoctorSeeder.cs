using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_ValeriaPiedrahita.seeders
{
    public class DoctorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Doctor>().HasData(
                 new Doctor
                {
                    Id = 1,
                    First_Name = "Carlos",
                    Last_Name = "Gomez",
                    Specialization = "Cardiologist",
                    StartTime = new TimeOnly(8, 0),   
                    EndTime = new TimeOnly(16, 0),    
                    Email = "carlos.gomez@example.com",
                    Password = "password123",
                    IdentificationNumber = "D1234567"
                },
                new Doctor
                {
                    Id = 2,
                    First_Name = "Ana",
                    Last_Name = "Martinez",
                    Specialization = "Neurologist",
                    StartTime = new TimeOnly(9, 0),   
                    EndTime = new TimeOnly(17, 0),   
                    Email = "ana.martinez@example.com",
                    Password = "password456",
                    IdentificationNumber = "D2345678"
                },
                new Doctor
                {
                    Id = 3,
                    First_Name = "Juan",
                    Last_Name = "Perez",
                    Specialization = "General Surgeon",
                    StartTime = new TimeOnly(7, 30),  
                    EndTime = new TimeOnly(15, 30),   
                    Email = "juan.perez@example.com",
                    Password = "password789",
                    IdentificationNumber = "D3456789"
                }
            );
        }
    }
}