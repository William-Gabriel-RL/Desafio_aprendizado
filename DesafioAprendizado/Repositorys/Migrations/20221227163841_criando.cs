using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositorys.Migrations
{
    /// <inheritdoc />
    public partial class criando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNome = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CategoriaDeletado = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    FormaPagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormaPagamentoNome = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    FormaPagamentoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    FormaPagamentoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.FormaPagamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Mesa",
                columns: table => new
                {
                    MesaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesaOcupada = table.Column<bool>(type: "bit", nullable: false),
                    MesaDeletada = table.Column<bool>(type: "bit", nullable: false),
                    MesaDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesa", x => x.MesaId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoNome = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ProdutoDescricao = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ProdutoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProdutoFotoId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "StatusSituacao",
                columns: table => new
                {
                    StatusSituacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusSituacaoNome = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    StatusSituacaoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    StatusSituacaoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusSituacao", x => x.StatusSituacaoId);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTipo",
                columns: table => new
                {
                    UsuarioTipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioTipoNome = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UsuarioTipoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioTipoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTipo", x => x.UsuarioTipoId);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCategoria",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoCategoriaDeletado = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoCategoriaDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategoria", x => new { x.ProdutoId, x.CategoriaId });
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoCategoria_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioMatricula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioNome = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    UsuarioSenha = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UsuarioDeletado = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioTipoId = table.Column<int>(type: "int", nullable: true),
                    UsuarioDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioMatricula);
                    table.ForeignKey(
                        name: "FK_Usuario_UsuarioTipo_UsuarioTipoId",
                        column: x => x.UsuarioTipoId,
                        principalTable: "UsuarioTipo",
                        principalColumn: "UsuarioTipoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComandaHoraAbertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    ComandaTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ComandaFinalizada = table.Column<bool>(type: "bit", nullable: false),
                    ComandaDeletado = table.Column<bool>(type: "bit", nullable: false),
                    ComandaDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    AtendenteMatricula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.ComandaId);
                    table.ForeignKey(
                        name: "FK_Comanda_Mesa_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesa",
                        principalColumn: "MesaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comanda_Usuario_AtendenteMatricula",
                        column: x => x.AtendenteMatricula,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioMatricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagamentoDataHora = table.Column<DateTime>(type: "datetime", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    FormaPagamentoId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioMatricula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PagamentoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    PagamentoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.PagamentoId);
                    table.ForeignKey(
                        name: "FK_Pagamento_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagamento_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "FormaPagamentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pagamento_Usuario_UsuarioMatricula",
                        column: x => x.UsuarioMatricula,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioMatricula",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoComanda",
                columns: table => new
                {
                    ProdutoComandaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoComandaQuantidadeProdutos = table.Column<int>(type: "int", nullable: false),
                    ProdutoComandaPreco = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    ProdutoComandaObservacao = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    ComandaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutoComandaDeletado = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoComandaDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoComanda", x => x.ProdutoComandaId);
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "ComandaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoComandaSituacao",
                columns: table => new
                {
                    ProdutoComandaSituacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoComandaSituacaoDataHora = table.Column<DateTime>(type: "datetime", nullable: false),
                    ProdutoComandaSituacaoMotivo = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: true),
                    ProdutoComandaSituacaoDeletado = table.Column<bool>(type: "bit", nullable: false),
                    ProdutoComandaSituacaoDataUltimaAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    UsuarioMatricula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StatusSituacaoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoComandaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoComandaSituacao", x => x.ProdutoComandaSituacaoId);
                    table.ForeignKey(
                        name: "FK_ProdutoComandaSituacao_ProdutoComanda_ProdutoComandaId",
                        column: x => x.ProdutoComandaId,
                        principalTable: "ProdutoComanda",
                        principalColumn: "ProdutoComandaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoComandaSituacao_StatusSituacao_StatusSituacaoId",
                        column: x => x.StatusSituacaoId,
                        principalTable: "StatusSituacao",
                        principalColumn: "StatusSituacaoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoComandaSituacao_Usuario_UsuarioMatricula",
                        column: x => x.UsuarioMatricula,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioMatricula",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_AtendenteMatricula",
                table: "Comanda",
                column: "AtendenteMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_MesaId",
                table: "Comanda",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_ComandaId",
                table: "Pagamento",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_FormaPagamentoId",
                table: "Pagamento",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagamento_UsuarioMatricula",
                table: "Pagamento",
                column: "UsuarioMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCategoria_CategoriaId",
                table: "ProdutoCategoria",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_ComandaId",
                table: "ProdutoComanda",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_ProdutoId",
                table: "ProdutoComanda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComandaSituacao_ProdutoComandaId",
                table: "ProdutoComandaSituacao",
                column: "ProdutoComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComandaSituacao_StatusSituacaoId",
                table: "ProdutoComandaSituacao",
                column: "StatusSituacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComandaSituacao_UsuarioMatricula",
                table: "ProdutoComandaSituacao",
                column: "UsuarioMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UsuarioTipoId",
                table: "Usuario",
                column: "UsuarioTipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "ProdutoCategoria");

            migrationBuilder.DropTable(
                name: "ProdutoComandaSituacao");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "ProdutoComanda");

            migrationBuilder.DropTable(
                name: "StatusSituacao");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Mesa");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "UsuarioTipo");
        }
    }
}
