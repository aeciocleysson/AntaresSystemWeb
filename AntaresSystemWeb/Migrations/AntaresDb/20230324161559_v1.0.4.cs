using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntaresSystemWeb.Migrations.AntaresDb
{
    public partial class v104 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Funcionario",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Matricula",
                table: "Funcionario",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)");
        }
    }
}
