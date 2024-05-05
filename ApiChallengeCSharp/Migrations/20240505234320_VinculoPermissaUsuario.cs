using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiChallengeCSharp.Migrations
{
    /// <inheritdoc />
    public partial class VinculoPermissaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Permissaos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissaos_UsuarioId",
                table: "Permissaos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissaos_Usuarios_UsuarioId",
                table: "Permissaos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissaos_Usuarios_UsuarioId",
                table: "Permissaos");

            migrationBuilder.DropIndex(
                name: "IX_Permissaos_UsuarioId",
                table: "Permissaos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Permissaos");
        }
    }
}
