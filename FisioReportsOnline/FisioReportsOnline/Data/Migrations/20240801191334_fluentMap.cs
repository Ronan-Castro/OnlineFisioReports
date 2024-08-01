using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FisioReportsOnline.Migrations
{
    /// <inheritdoc />
    public partial class fluentMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(80)", nullable: true),
                    Profissao = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    DataUltimaAvaliacao = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DataUltimaAtividade = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Sexo = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosticoClinico = table.Column<string>(type: "TEXT", nullable: true),
                    DiagnosticoFisioterapeutico = table.Column<string>(type: "TEXT", nullable: true),
                    QueixaPrincipal = table.Column<string>(type: "TEXT", nullable: true),
                    ObservacaoDoenca = table.Column<string>(type: "TEXT", nullable: true),
                    TratamentoAnterior = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetivoTerapeutico = table.Column<string>(type: "TEXT", nullable: true),
                    ObjetivoPessoal = table.Column<string>(type: "TEXT", nullable: true),
                    DataAtendimento = table.Column<string>(type: "TEXT", nullable: false),
                    IdPaciente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.IdAvaliacao);
                    table.ForeignKey(
                        name: "FK_Avaliacao_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Paciente_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evolucao",
                columns: table => new
                {
                    IdEvolucao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPaciente = table.Column<int>(type: "int", nullable: false),
                    PacienteIdPaciente = table.Column<int>(type: "int", nullable: false),
                    DataAtividade = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Aparelho = table.Column<string>(type: "TEXT", nullable: true),
                    Anotacoes = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteChegou = table.Column<string>(type: "TEXT", nullable: true),
                    ClienteSaiu = table.Column<string>(type: "TEXT", nullable: true),
                    Fisioterapeuta = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evolucao", x => x.IdEvolucao);
                    table.ForeignKey(
                        name: "FK_Evolucao_Paciente_PacienteIdPaciente",
                        column: x => x.PacienteIdPaciente,
                        principalTable: "Paciente",
                        principalColumn: "IdPaciente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoencasCondicoes",
                columns: table => new
                {
                    IdDoencasCondicoes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false),
                    Metabolica = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Cardiaca = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Respiratorias = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Vasculares = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Neurologicas = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Endocrina = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Dermatologica = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    GastroIntestinal = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Visual = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Covid = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Diabete = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Hipertensao = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Cardiopatia = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Neoplasias = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    DoencasHereditarias = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Gestacao = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Cirurgias = table.Column<byte>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoencasCondicoes", x => x.IdDoencasCondicoes);
                    table.ForeignKey(
                        name: "FK_DoencasCondicoes_Avaliacao_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacao",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExameFisico",
                columns: table => new
                {
                    IdExameFisico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false),
                    Equilibrio = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    FroxidaoLigamentar = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    EstabilidadeEscapular = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    MobilidadeColuna = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    PadraoMovimento = table.Column<byte>(type: "TINYINT", nullable: false),
                    Cabeca = table.Column<byte>(type: "TINYINT", nullable: false),
                    Cervical = table.Column<byte>(type: "TINYINT", nullable: false),
                    Joelhos = table.Column<byte>(type: "TINYINT", nullable: false),
                    Pes = table.Column<byte>(type: "TINYINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameFisico", x => x.IdExameFisico);
                    table.ForeignKey(
                        name: "FK_ExameFisico_Avaliacao_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacao",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HabitosVida",
                columns: table => new
                {
                    IdHabitosVida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false),
                    Tabagismo = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Etilismo = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    IngereAgua = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Medicacao = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Intestino = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    AtivFisica = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Pilates = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    ObsHabitos = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitosVida", x => x.IdHabitosVida);
                    table.ForeignKey(
                        name: "FK_HabitosVida_Avaliacao_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacao",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coluna",
                columns: table => new
                {
                    IdExameFisico = table.Column<int>(type: "int", nullable: false),
                    IdColuna = table.Column<int>(type: "int", nullable: false),
                    Normal = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Escoliose = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Hipercifose = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Hiperlordose = table.Column<byte>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coluna", x => x.IdExameFisico);
                    table.ForeignKey(
                        name: "FK_Coluna_ExameFisico_IdExameFisico",
                        column: x => x.IdExameFisico,
                        principalTable: "ExameFisico",
                        principalColumn: "IdExameFisico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ombros",
                columns: table => new
                {
                    IdOmbros = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdExameFisico = table.Column<int>(type: "int", nullable: false),
                    Normal = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Anteriorizada = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    LadoElevado = table.Column<byte>(type: "TINYINT", nullable: false),
                    EscapulaAlada = table.Column<byte>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ombros", x => x.IdOmbros);
                    table.ForeignKey(
                        name: "FK_Ombros_ExameFisico_IdExameFisico",
                        column: x => x.IdExameFisico,
                        principalTable: "ExameFisico",
                        principalColumn: "IdExameFisico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pelve",
                columns: table => new
                {
                    IdPelve = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdExameFisico = table.Column<int>(type: "int", nullable: false),
                    Normal = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Anteversao = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    Retroversao = table.Column<byte>(type: "TINYINT(1)", nullable: false),
                    LadoElevado = table.Column<byte>(type: "TINYINT", nullable: false),
                    Escoliose = table.Column<byte>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pelve", x => x.IdPelve);
                    table.ForeignKey(
                        name: "FK_Pelve_ExameFisico_IdExameFisico",
                        column: x => x.IdExameFisico,
                        principalTable: "ExameFisico",
                        principalColumn: "IdExameFisico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacao_IdPaciente",
                table: "Avaliacao",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_DoencasCondicoes_IdAvaliacao",
                table: "DoencasCondicoes",
                column: "IdAvaliacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_IdPaciente",
                table: "Endereco",
                column: "IdPaciente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evolucao_PacienteIdPaciente",
                table: "Evolucao",
                column: "PacienteIdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_ExameFisico_IdAvaliacao",
                table: "ExameFisico",
                column: "IdAvaliacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HabitosVida_IdAvaliacao",
                table: "HabitosVida",
                column: "IdAvaliacao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ombros_IdExameFisico",
                table: "Ombros",
                column: "IdExameFisico",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pelve_IdExameFisico",
                table: "Pelve",
                column: "IdExameFisico",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coluna");

            migrationBuilder.DropTable(
                name: "DoencasCondicoes");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Evolucao");

            migrationBuilder.DropTable(
                name: "HabitosVida");

            migrationBuilder.DropTable(
                name: "Ombros");

            migrationBuilder.DropTable(
                name: "Pelve");

            migrationBuilder.DropTable(
                name: "ExameFisico");

            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
