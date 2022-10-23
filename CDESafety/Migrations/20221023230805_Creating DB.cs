using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CDESafety.Migrations
{
    public partial class CreatingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Aeronaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Prefixo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronaves", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ajudantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajudantes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Culturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Culturas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pilotos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CodigoAnac = table.Column<int>(type: "int", nullable: false),
                    Comissao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilotos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Indicativo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pistas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Propriedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propriedades", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RelatorioDeServicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    DataDeEmissao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PistaId = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EngAgronomo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroReceituario = table.Column<int>(type: "int", nullable: false),
                    ReceituarioEmissao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AeronaveId = table.Column<int>(type: "int", nullable: false),
                    AplicacaoMatutinoInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AplicacaoMatutinoFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AplicacaoVespertinoInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AplicacaoVespertinoFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HorimetroInicial = table.Column<float>(type: "float", nullable: false),
                    HorimetroFinal = table.Column<float>(type: "float", nullable: false),
                    Translado = table.Column<float>(type: "float", nullable: false),
                    PilotoId = table.Column<int>(type: "int", nullable: false),
                    AlturaVoo = table.Column<float>(type: "float", nullable: false),
                    Area = table.Column<float>(type: "float", nullable: false),
                    Talhao = table.Column<float>(type: "float", nullable: false),
                    Faixa = table.Column<float>(type: "float", nullable: false),
                    Carga = table.Column<float>(type: "float", nullable: false),
                    Vazao = table.Column<float>(type: "float", nullable: false),
                    UsoGPS = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TemperaturaMatutinoInicial = table.Column<int>(type: "int", nullable: false),
                    TemperaturaMatutinoFinal = table.Column<int>(type: "int", nullable: false),
                    UmidadeArMatutinoInicial = table.Column<int>(type: "int", nullable: false),
                    UmidadeArMatutinoFinal = table.Column<int>(type: "int", nullable: false),
                    VentoMatutinoInicial = table.Column<int>(type: "int", nullable: false),
                    VentoMatutinoFinal = table.Column<int>(type: "int", nullable: false),
                    TemperaturaVespertinoInicial = table.Column<int>(type: "int", nullable: false),
                    TemperaturaVespertinoFinal = table.Column<int>(type: "int", nullable: false),
                    UmidadeArVespertinoInicial = table.Column<int>(type: "int", nullable: false),
                    UmidadeArVespertinoFinal = table.Column<int>(type: "int", nullable: false),
                    VentoVespertinoInicial = table.Column<int>(type: "int", nullable: false),
                    VentoVespertinoFinal = table.Column<int>(type: "int", nullable: false),
                    Combustivel = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CombustivelQtd = table.Column<int>(type: "int", nullable: false),
                    CombustivelOrigem = table.Column<int>(type: "int", nullable: false),
                    PrecoHora = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatorioDeServicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatorioDeServicos_Aeronaves_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatorioDeServicos_Pilotos_PilotoId",
                        column: x => x.PilotoId,
                        principalTable: "Pilotos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelatorioDeServicos_Pistas_PistaId",
                        column: x => x.PistaId,
                        principalTable: "Pistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClientePropriedade",
                columns: table => new
                {
                    ClientesId = table.Column<int>(type: "int", nullable: false),
                    PropriedadesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientePropriedade", x => new { x.ClientesId, x.PropriedadesId });
                    table.ForeignKey(
                        name: "FK_ClientePropriedade_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientePropriedade_Propriedades_PropriedadesId",
                        column: x => x.PropriedadesId,
                        principalTable: "Propriedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AjudanteRelatorioDeServico",
                columns: table => new
                {
                    AjudantesId = table.Column<int>(type: "int", nullable: false),
                    RelatorioDeServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AjudanteRelatorioDeServico", x => new { x.AjudantesId, x.RelatorioDeServicosId });
                    table.ForeignKey(
                        name: "FK_AjudanteRelatorioDeServico_Ajudantes_AjudantesId",
                        column: x => x.AjudantesId,
                        principalTable: "Ajudantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AjudanteRelatorioDeServico_RelatorioDeServicos_RelatorioDeSe~",
                        column: x => x.RelatorioDeServicosId,
                        principalTable: "RelatorioDeServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ClienteRelatorioDeServico",
                columns: table => new
                {
                    ClientesId = table.Column<int>(type: "int", nullable: false),
                    RelatorioDeServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteRelatorioDeServico", x => new { x.ClientesId, x.RelatorioDeServicosId });
                    table.ForeignKey(
                        name: "FK_ClienteRelatorioDeServico_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteRelatorioDeServico_RelatorioDeServicos_RelatorioDeSer~",
                        column: x => x.RelatorioDeServicosId,
                        principalTable: "RelatorioDeServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CulturaRelatorioDeServico",
                columns: table => new
                {
                    CulturasId = table.Column<int>(type: "int", nullable: false),
                    RelatorioDeServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CulturaRelatorioDeServico", x => new { x.CulturasId, x.RelatorioDeServicosId });
                    table.ForeignKey(
                        name: "FK_CulturaRelatorioDeServico_Culturas_CulturasId",
                        column: x => x.CulturasId,
                        principalTable: "Culturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CulturaRelatorioDeServico_RelatorioDeServicos_RelatorioDeSer~",
                        column: x => x.RelatorioDeServicosId,
                        principalTable: "RelatorioDeServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EquipamentoRelatorioDeServico",
                columns: table => new
                {
                    EquipamentosId = table.Column<int>(type: "int", nullable: false),
                    RelatorioDeServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipamentoRelatorioDeServico", x => new { x.EquipamentosId, x.RelatorioDeServicosId });
                    table.ForeignKey(
                        name: "FK_EquipamentoRelatorioDeServico_Equipamentos_EquipamentosId",
                        column: x => x.EquipamentosId,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipamentoRelatorioDeServico_RelatorioDeServicos_RelatorioD~",
                        column: x => x.RelatorioDeServicosId,
                        principalTable: "RelatorioDeServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PropriedadeRelatorioDeServico",
                columns: table => new
                {
                    PropriedadesId = table.Column<int>(type: "int", nullable: false),
                    RelatorioDeServicosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropriedadeRelatorioDeServico", x => new { x.PropriedadesId, x.RelatorioDeServicosId });
                    table.ForeignKey(
                        name: "FK_PropriedadeRelatorioDeServico_Propriedades_PropriedadesId",
                        column: x => x.PropriedadesId,
                        principalTable: "Propriedades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropriedadeRelatorioDeServico_RelatorioDeServicos_RelatorioD~",
                        column: x => x.RelatorioDeServicosId,
                        principalTable: "RelatorioDeServicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AjudanteRelatorioDeServico_RelatorioDeServicosId",
                table: "AjudanteRelatorioDeServico",
                column: "RelatorioDeServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientePropriedade_PropriedadesId",
                table: "ClientePropriedade",
                column: "PropriedadesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteRelatorioDeServico_RelatorioDeServicosId",
                table: "ClienteRelatorioDeServico",
                column: "RelatorioDeServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_CulturaRelatorioDeServico_RelatorioDeServicosId",
                table: "CulturaRelatorioDeServico",
                column: "RelatorioDeServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipamentoRelatorioDeServico_RelatorioDeServicosId",
                table: "EquipamentoRelatorioDeServico",
                column: "RelatorioDeServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_PropriedadeRelatorioDeServico_RelatorioDeServicosId",
                table: "PropriedadeRelatorioDeServico",
                column: "RelatorioDeServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioDeServicos_AeronaveId",
                table: "RelatorioDeServicos",
                column: "AeronaveId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioDeServicos_PilotoId",
                table: "RelatorioDeServicos",
                column: "PilotoId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatorioDeServicos_PistaId",
                table: "RelatorioDeServicos",
                column: "PistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AjudanteRelatorioDeServico");

            migrationBuilder.DropTable(
                name: "ClientePropriedade");

            migrationBuilder.DropTable(
                name: "ClienteRelatorioDeServico");

            migrationBuilder.DropTable(
                name: "CulturaRelatorioDeServico");

            migrationBuilder.DropTable(
                name: "EquipamentoRelatorioDeServico");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "PropriedadeRelatorioDeServico");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Ajudantes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Culturas");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "Propriedades");

            migrationBuilder.DropTable(
                name: "RelatorioDeServicos");

            migrationBuilder.DropTable(
                name: "Aeronaves");

            migrationBuilder.DropTable(
                name: "Pilotos");

            migrationBuilder.DropTable(
                name: "Pistas");
        }
    }
}
