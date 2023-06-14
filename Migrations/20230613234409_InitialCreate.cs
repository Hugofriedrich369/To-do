using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_do.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Afazeres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Afazeres", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Afazeres",
                columns: new[] { "Id", "Data", "Desc", "Status", "Titulo" },
                values: new object[] { 1, new DateTime(2023, 6, 13, 20, 44, 9, 760, DateTimeKind.Local).AddTicks(3050), "Apenas um Teste", true, "Teste" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Afazeres");
        }
    }
}
