using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntaresSystemWeb.Migrations.AntaresDb
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ponto_LogPonto_LogPontoId",
                table: "Ponto");

            migrationBuilder.DropTable(
                name: "LogPonto");

            migrationBuilder.DropIndex(
                name: "IX_Ponto_LogPontoId",
                table: "Ponto");

            migrationBuilder.AlterColumn<string>(
                name: "Matricula",
                table: "Ponto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Ponto",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Ponto");

            migrationBuilder.AlterColumn<long>(
                name: "Matricula",
                table: "Ponto",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LogPonto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Inserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAtivo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserAlteration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserInserted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogPonto", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ponto_LogPontoId",
                table: "Ponto",
                column: "LogPontoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ponto_LogPonto_LogPontoId",
                table: "Ponto",
                column: "LogPontoId",
                principalTable: "LogPonto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
