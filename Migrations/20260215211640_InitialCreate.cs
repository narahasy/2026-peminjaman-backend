using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2026_Peminjaman_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "CreatedDate", "Email", "Name", "Phone", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 2, 16, 4, 16, 40, 490, DateTimeKind.Local).AddTicks(446), "admin@mail.com", "Admin", null, "active" },
                    { 2, null, new DateTime(2026, 2, 16, 4, 16, 40, 490, DateTimeKind.Local).AddTicks(461), "budiraharjo@mail.com", "Budi Raharjo", null, "active" },
                    { 3, null, new DateTime(2026, 2, 16, 4, 16, 40, 490, DateTimeKind.Local).AddTicks(462), "sitiaminah@mail.com", "Siti Aminah", null, "inactive" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
