using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorys.Migrations
{
    /// <inheritdoc />
    public partial class collections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Comanda_ComandaId",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoComanda_Comanda_ComandaId1",
                table: "ProdutoComanda");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Comanda_ComandaId",
                table: "Pagamento",
                column: "ComandaId",
                principalTable: "Comanda",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoComanda_Comanda_ComandaId1",
                table: "ProdutoComanda",
                column: "ComandaId1",
                principalTable: "Comanda",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagamento_Comanda_ComandaId",
                table: "Pagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoComanda_Comanda_ComandaId1",
                table: "ProdutoComanda");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagamento_Comanda_ComandaId",
                table: "Pagamento",
                column: "ComandaId",
                principalTable: "Comanda",
                principalColumn: "ComandaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoComanda_Comanda_ComandaId1",
                table: "ProdutoComanda",
                column: "ComandaId1",
                principalTable: "Comanda",
                principalColumn: "ComandaId");
        }
    }
}
