using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_WebApi.Migrations
{
    public partial class Allcompleteee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Skill_Name",
                table: "Employee_Skill",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Qualification_Name",
                table: "Employee_Qualification",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Skill_Name",
                table: "Employee_Skill");

            migrationBuilder.DropColumn(
                name: "Qualification_Name",
                table: "Employee_Qualification");
        }
    }
}
