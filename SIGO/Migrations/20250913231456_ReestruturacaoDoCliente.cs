using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIGO.Migrations
{
    /// <inheritdoc />
    public partial class ReestruturacaoDoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clientef");

            migrationBuilder.DropTable(
                name: "clientej");

            migrationBuilder.DeleteData(
                table: "endereco",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "endereco",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "telefone",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "telefone",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cliente",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.AddColumn<int>(
                name: "ddd",
                table: "telefone",
                type: "integer",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "complemento",
                table: "endereco",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pais",
                table: "endereco",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "cnpj_cpf",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "obs",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "razao",
                table: "cliente",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "sexo",
                table: "cliente",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tipocliente",
                table: "cliente",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ddd",
                table: "telefone");

            migrationBuilder.DropColumn(
                name: "complemento",
                table: "endereco");

            migrationBuilder.DropColumn(
                name: "pais",
                table: "endereco");

            migrationBuilder.DropColumn(
                name: "cnpj_cpf",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "obs",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "razao",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "sexo",
                table: "cliente");

            migrationBuilder.DropColumn(
                name: "tipocliente",
                table: "cliente");

            migrationBuilder.CreateTable(
                name: "clientef",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    cpf = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    datanasc = table.Column<DateOnly>(type: "date", nullable: false),
                    obs = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    sexo = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientef", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientef_cliente_id",
                        column: x => x.id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientej",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    cnpj = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    razao = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientej", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientej_cliente_id",
                        column: x => x.id,
                        principalTable: "cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "cliente",
                columns: new[] { "id", "data", "email", "nome", "senha", "situacao" },
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
        }
    }
}
