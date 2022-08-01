using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECOURSES.Migrations
{
    public partial class subbb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Subscribers",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subscribers",
                table: "Courses");
        }
    }
}
