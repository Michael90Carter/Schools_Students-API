using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inco_webAPI.V2.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "312 Bukerere Sonde, BF 923", "UGANDA", "St Charles Lwanga Secondary School" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "583 Nakawa, MD 21207", "UGANDA", "St Michael Secondary School" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "Class", "Name", "Position", "SchoolId", "Subject" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "Senior Two", "Mathew Amone", "Assistant HOD ICT", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "ICT" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "Senior one", "Sam Okori", "HOD English", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "English" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "Senior Five", "Anold Emaru Raiden", "Head Teacher", new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Mathematics" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
