using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2026_peminjaman_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialPeminjamanLengkap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Keperluan",
                table: "Peminjaman",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Keperluan",
                table: "Peminjaman");
        }
    }
}
