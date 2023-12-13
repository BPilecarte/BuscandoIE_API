using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BuscandoIE.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_IE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNPJ = table.Column<long>(type: "bigint", nullable: false),
                    NroIE = table.Column<int>(type: "int", nullable: false),
                    UF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SituacaoIE = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_IE", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_IE",
                columns: new[] { "Id", "CNPJ", "Nome", "NroIE", "SituacaoIE", "UF" },
                values: new object[,]
                {
                    { 1, 61550141000172L, "LIBERTY SEGUROS S.A", 123456, 1, "SP" },
                    { 2, 2233469000104L, "F1RST TECNOLOGIA E INOVACAO LTDA", 789456, 3, "SP" },
                    { 3, 29980158000157L, "HDI SEGUROS S.A", 159753, 4, "SP" },
                    { 4, 60872504000123L, "ITAU UNIBANCO HOLDING S.A", 951357, 3, "RJ" },
                    { 5, 90400888000142L, "BANCO SANTANDER (BRASIL) S.A", 654238, 1, "BA" },
                    { 6, 66970229000167L, "CLARO NXT TELECOMUNICACOES S.A", 786216, 4, "PA" },
                    { 7, 29309127000179L, "AMIL ASSISTENCIA MEDICA INTERNACIONAL S.A", 658920, 4, "GO" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_IE");
        }
    }
}
