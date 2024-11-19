using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_ValeriaPiedrahita.Migrations
{
    /// <inheritdoc />
    public partial class createdseederappo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_doctors_doctor_id1",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_medical_hisotials_medical_historial_id1",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_patients_patient_id1",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_doctor_id1",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_medical_historial_id1",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_patient_id1",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "doctor_id1",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "medical_historial_id1",
                table: "appointment");

            migrationBuilder.DropColumn(
                name: "patient_id1",
                table: "appointment");

            migrationBuilder.InsertData(
                table: "appointment",
                columns: new[] { "id", "date", "doctor_id", "medical_historial_id", "patient_id", "reason" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, "Consulta de control" },
                    { 2, new DateTime(2024, 11, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 2, 2, 2, "Dolor de cabeza persistente" },
                    { 3, new DateTime(2024, 11, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, 3, "Chequeo preventivo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointment_doctor_id",
                table: "appointment",
                column: "doctor_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_medical_historial_id",
                table: "appointment",
                column: "medical_historial_id");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_patient_id",
                table: "appointment",
                column: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_doctors_doctor_id",
                table: "appointment",
                column: "doctor_id",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_medical_hisotials_medical_historial_id",
                table: "appointment",
                column: "medical_historial_id",
                principalTable: "medical_hisotials",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_patients_patient_id",
                table: "appointment",
                column: "patient_id",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointment_doctors_doctor_id",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_medical_hisotials_medical_historial_id",
                table: "appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_appointment_patients_patient_id",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_doctor_id",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_medical_historial_id",
                table: "appointment");

            migrationBuilder.DropIndex(
                name: "IX_appointment_patient_id",
                table: "appointment");

            migrationBuilder.DeleteData(
                table: "appointment",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appointment",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "appointment",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "doctor_id1",
                table: "appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "medical_historial_id1",
                table: "appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "patient_id1",
                table: "appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_appointment_doctor_id1",
                table: "appointment",
                column: "doctor_id1");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_medical_historial_id1",
                table: "appointment",
                column: "medical_historial_id1");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_patient_id1",
                table: "appointment",
                column: "patient_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_doctors_doctor_id1",
                table: "appointment",
                column: "doctor_id1",
                principalTable: "doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_medical_hisotials_medical_historial_id1",
                table: "appointment",
                column: "medical_historial_id1",
                principalTable: "medical_hisotials",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointment_patients_patient_id1",
                table: "appointment",
                column: "patient_id1",
                principalTable: "patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
