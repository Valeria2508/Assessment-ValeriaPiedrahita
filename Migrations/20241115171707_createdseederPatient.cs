using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assessment_ValeriaPiedrahita.Migrations
{
    /// <inheritdoc />
    public partial class createdseederPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "id", "date_of_birth", "email", "first_name", "Identification_number", "last_name", "password" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "carlos.gomez@example.com", "Carlos", "AB1234567", "Gomez", "password123" },
                    { 2, new DateTime(1990, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana.martinez@example.com", "Ana", "XY9876543", "Martinez", "password456" },
                    { 3, new DateTime(1978, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "juan.perez@example.com", "Juan", "KL1122334", "Perez", "password789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "patients",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
