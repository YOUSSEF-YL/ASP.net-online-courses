using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECOURSES.Migrations
{
    public partial class addIsSubde : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubde",
                table: "Ratings",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubde",
                table: "Ratings");
        }
    }
}
