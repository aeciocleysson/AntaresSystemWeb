using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AntaresSystemWeb.Migrations.AntaresDb
{
    public partial class v103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogPonto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAtivo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInserted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAlteration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogPonto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ponto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    Matricula = table.Column<long>(type: "bigint", nullable: false),
                    Entrada = table.Column<TimeSpan>(type: "time", nullable: false),
                    SaidaIntervalo = table.Column<TimeSpan>(type: "time", nullable: false),
                    RetornoIntervalo = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalIntervalo = table.Column<TimeSpan>(type: "time", nullable: false),
                    Saida = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalTrabalhado = table.Column<TimeSpan>(type: "time", nullable: false),
                    Minutos = table.Column<double>(type: "float", nullable: false),
                    LogPontoId = table.Column<int>(type: "int", nullable: false),
                    Inserted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAtivo = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserInserted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAlteration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ponto_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ponto_LogPonto_LogPontoId",
                        column: x => x.LogPontoId,
                        principalTable: "LogPonto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ponto_FuncionarioId",
                table: "Ponto",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponto_LogPontoId",
                table: "Ponto",
                column: "LogPontoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ponto");

            migrationBuilder.DropTable(
                name: "LogPonto");
        }
    }
}
