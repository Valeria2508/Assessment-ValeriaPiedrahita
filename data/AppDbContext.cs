using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.models;
using Microsoft.EntityFrameworkCore;
using Assessment_ValeriaPiedrahita.seeders;

namespace Assessment_ValeriaPiedrahita.data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalHisorial> MedicalHistorials { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){ //manda a la db los seeders
            
            base.OnModelCreating(modelBuilder);
            PatientSeeder.Seed(modelBuilder);
            DoctorSeeder.Seed(modelBuilder);
            MedicalHistorialSeeder.Seed(modelBuilder);
            AppointmentSeeder.Seed(modelBuilder);
        }
 
    }
}