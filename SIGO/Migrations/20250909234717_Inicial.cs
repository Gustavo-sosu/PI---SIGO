using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIGO.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "professor",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    senha = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    data = table.Column<DateOnly>(type: "date", nullable: false),
                    Situacao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clientef",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    cpf = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    datanasc = table.Column<DateOnly>(type: "date", nullable: false),
                    sexo = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false),
                    obs = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientef", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientef_professor_id",
                        column: x => x.id,
                        principalTable: "professor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientej",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    razao = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    cnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientej", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientej_professor_id",
                        column: x => x.id,
                        principalTable: "professor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero = table.Column<int>(type: "integer", nullable: false),
                    rua = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cidade = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cep = table.Column<int>(type: "integer", maxLength: 8, nullable: false),
                    bairro = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    clienteid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.id);
                    table.ForeignKey(
                        name: "FK_endereco_professor_clienteid",
                        column: x => x.clienteid,
                        principalTable: "professor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "telefone",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numero = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    clienteid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefone", x => x.id);
                    table.ForeignKey(
                        name: "FK_telefone_professor_clienteid",
                        column: x => x.clienteid,
                        principalTable: "professor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "professor",
                columns: new[] { "id", "data", "email", "nome", "senha", "Situacao" },
                values: new object[,]
                {
                    { 1, new DateOnly(2025, 6, 1), "joao@email.com", "João Pereira", "123456", 1 },
                    { 2, new DateOnly(2025, 6, 3), "contato@empresaabc.com", "Empresa ABC", "123456", 1 }
                });

            migrationBuilder.InsertData(
                table: "clientef",
                columns: new[] { "id", "cpf", "datanasc", "obs", "sexo" },
                values: new object[] { 1, "12345678901", new DateOnly(1990, 5, 12), "Cliente antigo", "M" });

            migrationBuilder.InsertData(
                table: "clientej",
                columns: new[] { "id", "cnpj", "razao" },
                values: new object[] { 2, "12345678000199", "Empresa ABC Ltda" });

            migrationBuilder.InsertData(
                table: "endereco",
                columns: new[] { "id", "bairro", "cep", "cidade", "clienteid", "estado", "numero", "rua" },
                values: new object[,]
                {
                    { 1, "Centro", 1001000, "São Paulo", 1, "SP", 123, "Rua das Flores" },
                    { 2, "Copacabana", 22041001, "Rio de Janeiro", 2, "RJ", 456, "Av. Brasil" }
                });

            migrationBuilder.InsertData(
                table: "telefone",
                columns: new[] { "id", "clienteid", "numero" },
                values: new object[,]
                {
                    { 1, 1, "11999999999" },
                    { 2, 2, "21988888888" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_endereco_clienteid",
                table: "endereco",
                column: "clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_telefone_clienteid",
                table: "telefone",
                column: "clienteid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientef");

            migrationBuilder.DropTable(
                name: "clientej");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "telefone");

            migrationBuilder.DropTable(
                name: "professor");
        }
    }
}
