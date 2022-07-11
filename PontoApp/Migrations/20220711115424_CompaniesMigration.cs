using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PontoApp.Migrations
{
    public partial class CompaniesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numFuncionarios",
                table: "Company");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numFuncionarios",
                table: "Company",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
