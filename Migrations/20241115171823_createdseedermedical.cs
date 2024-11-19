using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_ValeriaPiedrahita.Migrations
{
    /// <inheritdoc />
    public partial class createdseedermedical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "medical_hisotials",
                columns: new[] { "id", "allergies", "created_date", "details", "diagnoses", "medications", "patient_id" },
                values: new object[,]
                {
                    { 1, "Ninguna", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consulta de control anual.", "Hipertensión", "Atenolol", 1 },
                    { 2, "Alergia al polen", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Control y seguimiento de niveles de glucosa.", "Diabetes Tipo 2", "Metformina", 2 },
                    { 3, "Alergia a los mariscos", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Receta para inhalador y seguimiento.", "Asma", "Salbutamol", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "medical_hisotials",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "medical_hisotials",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "medical_hisotials",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
