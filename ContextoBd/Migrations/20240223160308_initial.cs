using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContextoBd.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RespostaQuizzes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PerguntasDasAlternativas = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespostaQuizzes", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AlternativaQuiz",
                columns: table => new
                {
                    IDRespostasQuiz = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AlternativaQuiz = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RespostaQuizid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlternativaQuiz", x => x.IDRespostasQuiz);
                    table.ForeignKey(
                        name: "FK_AlternativaQuiz_RespostaQuizzes_RespostaQuizid",
                        column: x => x.RespostaQuizid,
                        principalTable: "RespostaQuizzes",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PerguntasDoQuiz",
                columns: table => new
                {
                    IDPerguntasQuiz = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Perguntas = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RespostaQuizid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerguntasDoQuiz", x => x.IDPerguntasQuiz);
                    table.ForeignKey(
                        name: "FK_PerguntasDoQuiz_RespostaQuizzes_RespostaQuizid",
                        column: x => x.RespostaQuizid,
                        principalTable: "RespostaQuizzes",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_AlternativaQuiz_RespostaQuizid",
                table: "AlternativaQuiz",
                column: "RespostaQuizid");

            migrationBuilder.CreateIndex(
                name: "IX_PerguntasDoQuiz_RespostaQuizid",
                table: "PerguntasDoQuiz",
                column: "RespostaQuizid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlternativaQuiz");

            migrationBuilder.DropTable(
                name: "PerguntasDoQuiz");

            migrationBuilder.DropTable(
                name: "RespostaQuizzes");
        }
    }
}
