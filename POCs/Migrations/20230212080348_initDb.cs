using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POCs.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "course_Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_Sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "course_days",
                columns: table => new
                {
                    day = table.Column<int>(type: "int", nullable: false),
                    Section_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_days", x => new { x.Section_Id, x.day });
                    table.ForeignKey(
                        name: "FK_course_days_course_Sections_Section_Id",
                        column: x => x.Section_Id,
                        principalTable: "course_Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "course_days");

            migrationBuilder.DropTable(
                name: "course_Sections");
        }
    }
}
