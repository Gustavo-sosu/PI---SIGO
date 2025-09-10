using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIGO.Migrations
{
    /// <inheritdoc />
    public partial class Correcao_do_nome_da_tabela_cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientef_professor_id",
                table: "clientef");

            migrationBuilder.DropForeignKey(
                name: "FK_clientej_professor_id",
                table: "clientej");

            migrationBuilder.DropForeignKey(
                name: "FK_endereco_professor_clienteid",
                table: "endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_telefone_professor_clienteid",
                table: "telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_professor",
                table: "professor");

            migrationBuilder.RenameTable(
                name: "professor",
                newName: "cliente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientef_cliente_id",
                table: "clientef",
                column: "id",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clientej_cliente_id",
                table: "clientej",
                column: "id",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_cliente_clienteid",
                table: "endereco",
                column: "clienteid",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_telefone_cliente_clienteid",
                table: "telefone",
                column: "clienteid",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientef_cliente_id",
                table: "clientef");

            migrationBuilder.DropForeignKey(
                name: "FK_clientej_cliente_id",
                table: "clientej");

            migrationBuilder.DropForeignKey(
                name: "FK_endereco_cliente_clienteid",
                table: "endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_telefone_cliente_clienteid",
                table: "telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "professor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_professor",
                table: "professor",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_clientef_professor_id",
                table: "clientef",
                column: "id",
                principalTable: "professor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_clientej_professor_id",
                table: "clientej",
                column: "id",
                principalTable: "professor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_professor_clienteid",
                table: "endereco",
                column: "clienteid",
                principalTable: "professor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_telefone_professor_clienteid",
                table: "telefone",
                column: "clienteid",
                principalTable: "professor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
