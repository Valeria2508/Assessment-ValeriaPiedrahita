using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_ValeriaPiedrahita.seeders
{
    public class PatientSeeder
    {
        public static void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    Id =1,
                    First_Name = "Carlos",
                    Last_Name = "Gomez",
                    Email = "carlos.gomez@example.com",
                    Password = "password123",   
                    DateOfBirth = new DateTime(1985, 5, 22),
                    IdentificationNumber = "AB1234567"},

                new Patient
                {
                    Id=2,
                     First_Name = "Ana",
                    Last_Name = "Martinez",
                    Email = "ana.martinez@example.com",
                    Password = "password456",
                    DateOfBirth = new DateTime(1990, 11, 13),
                    IdentificationNumber = "XY9876543"
                },
                new Patient
                {
                    Id=3,
                    First_Name = "Juan",
                    Last_Name = "Perez",
                    Email = "juan.perez@example.com",
                    Password = "password789",
                    DateOfBirth = new DateTime(1978, 8, 30),
                    IdentificationNumber = "KL1122334"
                }
            
            );
        }

    }
}