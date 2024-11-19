﻿// <auto-generated />
using System;
using Assessment_ValeriaPiedrahita.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment_ValeriaPiedrahita.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241115171202_createdtables")]
    partial class createdtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int")
                        .HasColumnName("doctor_id");

                    b.Property<int>("MedicalHistorialId")
                        .HasColumnType("int")
                        .HasColumnName("medical_historial_id");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("reason");

                    b.Property<int>("doctor_id")
                        .HasColumnType("int");

                    b.Property<int>("medical_historial_id")
                        .HasColumnType("int");

                    b.Property<int>("patient_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("doctor_id");

                    b.HasIndex("medical_historial_id");

                    b.HasIndex("patient_id");

                    b.ToTable("appointment", t =>
                        {
                            t.Property("doctor_id")
                                .HasColumnName("doctor_id1");

                            t.Property("medical_historial_id")
                                .HasColumnName("medical_historial_id1");

                            t.Property("patient_id")
                                .HasColumnName("patient_id1");
                        });
                });

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("end_time");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Identification_number");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("password");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("specialization");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time(6)")
                        .HasColumnName("start_time");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "carlos.gomez@example.com",
                            EndTime = new TimeOnly(16, 0, 0),
                            First_Name = "Carlos",
                            IdentificationNumber = "D1234567",
                            Last_Name = "Gomez",
                            Password = "password123",
                            Specialization = "Cardiologist",
                            StartTime = new TimeOnly(8, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Email = "ana.martinez@example.com",
                            EndTime = new TimeOnly(17, 0, 0),
                            First_Name = "Ana",
                            IdentificationNumber = "D2345678",
                            Last_Name = "Martinez",
                            Password = "password456",
                            Specialization = "Neurologist",
                            StartTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Email = "juan.perez@example.com",
                            EndTime = new TimeOnly(15, 30, 0),
                            First_Name = "Juan",
                            IdentificationNumber = "D3456789",
                            Last_Name = "Perez",
                            Password = "password789",
                            Specialization = "General Surgeon",
                            StartTime = new TimeOnly(7, 30, 0)
                        });
                });

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.MedicalHisorial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Allergies")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("allergies");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_date");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("details");

                    b.Property<string>("Diagnoses")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("diagnoses");

                    b.Property<string>("Medications")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("medications");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasColumnName("patient_id");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("medical_hisotials");
                });

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Identification_number");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.Appointment", b =>
                {
                    b.HasOne("Assessment_ValeriaPiedrahita.models.Doctor", "Doctors")
                        .WithMany()
                        .HasForeignKey("doctor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assessment_ValeriaPiedrahita.models.MedicalHisorial", "MedicalHistorials")
                        .WithMany()
                        .HasForeignKey("medical_historial_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assessment_ValeriaPiedrahita.models.Patient", "Patients")
                        .WithMany()
                        .HasForeignKey("patient_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctors");

                    b.Navigation("MedicalHistorials");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Assessment_ValeriaPiedrahita.models.MedicalHisorial", b =>
                {
                    b.HasOne("Assessment_ValeriaPiedrahita.models.Patient", "Patients")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
