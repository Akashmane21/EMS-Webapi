using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_WebApi.Migrations
{
    public partial class Allcomplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qualification_id",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualification_id",
                table: "Employee");
        }
    }
}
