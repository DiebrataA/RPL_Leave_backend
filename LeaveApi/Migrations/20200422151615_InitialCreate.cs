using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    employee_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    job_title = table.Column<string>(type: "nvarchar(25)", nullable: true),
                    leave_remaining = table.Column<int>(nullable: false),
                    password = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.employee_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
