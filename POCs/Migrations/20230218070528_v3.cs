using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POCs.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Items_Courses_courseId",
                table: "Plan_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Items_Plans_planId",
                table: "Plan_Items");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Items_courseId",
                table: "Plan_Items");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Items_planId",
                table: "Plan_Items");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Plan_Items");

            migrationBuilder.DropColumn(
                name: "planId",
                table: "Plan_Items");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Items_Course_Id",
                table: "Plan_Items",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Items_Courses_Course_Id",
                table: "Plan_Items",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Items_Plans_Plan_Id",
                table: "Plan_Items",
                column: "Plan_Id",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Items_Courses_Course_Id",
                table: "Plan_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Plan_Items_Plans_Plan_Id",
                table: "Plan_Items");

            migrationBuilder.DropIndex(
                name: "IX_Plan_Items_Course_Id",
                table: "Plan_Items");

            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Plan_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "planId",
                table: "Plan_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Items_courseId",
                table: "Plan_Items",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_Items_planId",
                table: "Plan_Items",
                column: "planId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Items_Courses_courseId",
                table: "Plan_Items",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Plan_Items_Plans_planId",
                table: "Plan_Items",
                column: "planId",
                principalTable: "Plans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
