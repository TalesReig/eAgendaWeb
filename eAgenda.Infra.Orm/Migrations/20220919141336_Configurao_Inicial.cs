using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace eAgenda.Infra.Orm.Migrations
{
    public partial class Configurao_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBCategoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBContato",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: true),
                    Empresa = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cargo = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBDespesa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormaPagamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBDespesa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBTarefa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(200)", nullable: false),
                    Prioridade = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataConclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PercentualConcluido = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBTarefa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBCompromisso",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Assunto = table.Column<string>(type: "varchar(300)", nullable: false),
                    Local = table.Column<string>(type: "varchar(300)", nullable: true),
                    TipoLocal = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraInicio = table.Column<long>(type: "bigint", nullable: false),
                    HoraTermino = table.Column<long>(type: "bigint", nullable: false),
                    ContatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCompromisso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCompromisso_TBContato_ContatoId",
                        column: x => x.ContatoId,
                        principalTable: "TBContato",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBDespesa_TBCategoria",
                columns: table => new
                {
                    CategoriasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DespesasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBDespesa_TBCategoria", x => new { x.CategoriasId, x.DespesasId });
                    table.ForeignKey(
                        name: "FK_TBDespesa_TBCategoria_TBCategoria_CategoriasId",
                        column: x => x.CategoriasId,
                        principalTable: "TBCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBDespesa_TBCategoria_TBDespesa_DespesasId",
                        column: x => x.DespesasId,
                        principalTable: "TBDespesa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBItemTarefa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(200)", nullable: false),
                    Concluido = table.Column<bool>(type: "bit", nullable: false),
                    TarefaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBItemTarefa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBItemTarefa_TBTarefa_TarefaId",
                        column: x => x.TarefaId,
                        principalTable: "TBTarefa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBCompromisso_ContatoId",
                table: "TBCompromisso",
                column: "ContatoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBDespesa_TBCategoria_DespesasId",
                table: "TBDespesa_TBCategoria",
                column: "DespesasId");

            migrationBuilder.CreateIndex(
                name: "IX_TBItemTarefa_TarefaId",
                table: "TBItemTarefa",
                column: "TarefaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBCompromisso");

            migrationBuilder.DropTable(
                name: "TBDespesa_TBCategoria");

            migrationBuilder.DropTable(
                name: "TBItemTarefa");

            migrationBuilder.DropTable(
                name: "TBContato");

            migrationBuilder.DropTable(
                name: "TBCategoria");

            migrationBuilder.DropTable(
                name: "TBDespesa");

            migrationBuilder.DropTable(
                name: "TBTarefa");
        }
    }
}
