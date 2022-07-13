using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_WebApi.Migrations
{
    public partial class Allcompletee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Basic_Pay = table.Column<int>(type: "int", nullable: false),
                    HRA = table.Column<int>(type: "int", nullable: false),
                    Conveyance_Allowences = table.Column<int>(type: "int", nullable: false),
                    Special_Allowences = table.Column<int>(type: "int", nullable: false),
                    PF = table.Column<int>(type: "int", nullable: false),
                    TDS = table.Column<int>(type: "int", nullable: false),
                    Gross_Salary = table.Column<int>(type: "int", nullable: false),
                    Net_Salary = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Salary", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Salary");
        }
    }
}
