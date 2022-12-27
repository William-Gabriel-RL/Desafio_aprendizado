using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositorys.Context
{
    public class DesafioAprendizadoContext : DbContext
    {
        public DesafioAprendizadoContext()
        {
        }

        public DesafioAprendizadoContext(DbContextOptions<DesafioAprendizadoContext> options) : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioTipo> UsuarioTipos { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<ProdutoCategoria> ProdutosCategorias {get; set;}
        public virtual DbSet<ProdutoComanda> ProdutosComandas {get; set;}
        public virtual DbSet<ProdutoComandaSituacao> ProdutosComandasSituacoes { get; set; }
        public virtual DbSet<StatusSituacao> StatusSituacao { get; set; }
        public virtual DbSet<Comanda> Comandas { get; set; }
        public virtual DbSet<Pagamento> Pagamentos { get; set; }
        public virtual DbSet<FormaPagamento> FormasPagamento { get; set; }
        public virtual DbSet<Mesa> Mesas { get; set; }


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseSqlServer("Data Source=MAGNATI-10865-F;" +
                "Initial Catalog=DesafioAprendizado;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity => 
            {
                entity.ToTable("Usuario");
                entity.HasKey(e => e.UsuarioMatricula);
                entity.Property(e => e.UsuarioNome).HasMaxLength(60).IsUnicode(false).IsRequired();
                entity.Property(e => e.UsuarioSenha).HasMaxLength(255).IsUnicode(false).IsRequired();
                entity.Property(e => e.UsuarioDeletado).HasColumnType("bit");
                entity.Property(e => e.UsuarioDataUltimaAtualizacao).HasColumnType("datetime");
                entity.HasOne(e => e.Tipo).WithMany().HasForeignKey(e => e.UsuarioTipoId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<UsuarioTipo>(entity => 
            {
                entity.ToTable("UsuarioTipo");
                entity.HasKey(e => e.UsuarioTipoId);
                entity.Property(e => e.UsuarioTipoNome).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.UsuarioTipoDataUltimaAtualizacao).HasColumnType("datetime");
                entity.Property(e => e.UsuarioTipoDeletado).HasColumnType("bit");
            });

            modelBuilder.Entity<Produto>(entity =>
            {
                entity.ToTable("Produto");
                entity.HasKey(e => e.ProdutoId);
                entity.Property(e => e.ProdutoNome).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.ProdutoDescricao).HasMaxLength(120).IsUnicode(false).IsRequired();
                entity.Property(e => e.Preco).HasColumnType("decimal(8,2)").IsRequired();
                entity.Property(e => e.ProdutoDeletado).HasColumnType("bit");
                entity.Property(e => e.ProdutoDataUltimaAtualizacao).HasColumnType("datetime");
                entity.Property(e => e.ProdutoFotoId).HasMaxLength(50).IsUnicode(false);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("Categoria");
                entity.HasKey(e => e.CategoriaId);
                entity.Property(e => e.CategoriaNome).HasMaxLength(20).IsUnicode(false).IsRequired();
                entity.Property(e => e.CategoriaDeletado).HasColumnType("bit");
                entity.Property(e => e.CategoriaDataUltimaAtualizacao).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdutoCategoria>(entity =>
            {
                entity.ToTable("ProdutoCategoria");
                entity.HasKey(e => new { e.ProdutoId, e.CategoriaId });
            });

            modelBuilder.Entity<ProdutoComanda>(entity => 
            {
                entity.ToTable("ProdutoComanda");
                entity.HasKey(e => e.ProdutoComandaId);
                entity.Property(e => e.ProdutoComandaQuantidadeProdutos).HasColumnType("int").IsRequired();
                entity.Property(e => e.ProdutoComandaPreco).HasColumnType("decimal(8,2)").IsRequired();
                entity.Property(e => e.ProdutoComandaObservacao).HasMaxLength(120).IsUnicode(false).IsRequired();
                entity.HasOne(e => e.Produto).WithMany().HasForeignKey(e => e.ProdutoId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Comanda).WithMany().HasForeignKey(e => e.ComandaId).OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(e => e.Situacoes).WithOne().HasForeignKey(e => e.ProdutoComandaId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ProdutoComandaSituacao>(entity => 
            {
                entity.ToTable("ProdutoComandaSituacao");
                entity.HasKey(e => e.ProdutoComandaSituacaoId);
                entity.Property(e => e.ProdutoComandaSituacaoDataHora).HasColumnType("datetime");
                entity.Property(e => e.ProdutoComandaSituacaoMotivo).HasMaxLength(120).IsUnicode(false);
                entity.Property(e => e.ProdutoComandaSituacaoDeletado).HasColumnType("bit");
                entity.Property(e => e.ProdutoComandaSituacaoDataUltimaAtualizacao).HasColumnType("datetime");
                entity.HasOne(e => e.Usuario).WithMany().HasForeignKey(e => e.UsuarioMatricula).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.StatusSituacao).WithMany().HasForeignKey(e => e.StatusSituacaoId).OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.ProdutoComanda).WithMany().HasForeignKey(e => e.ProdutoComandaId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<StatusSituacao>(entity =>
            {
                entity.ToTable("StatusSituacao");
                entity.HasKey(e => e.StatusSituacaoId);
                entity.Property(e => e.StatusSituacaoNome).HasMaxLength(30).IsUnicode(false).IsRequired();
                entity.Property(e => e.StatusSituacaoDeletado).HasColumnType("bit");
                entity.Property(e => e.StatusSituacaoDataUltimaAtualizacao).HasColumnType("datetime");
            });

            modelBuilder.Entity<Comanda>(entity => 
            {
                entity.ToTable("Comanda");
                entity.HasKey(e => e.ComandaId);
                entity.Property(e => e.ComandaHoraAbertura).HasColumnType("datetime");
                entity.Property(e => e.ComandaTotal).HasColumnType("decimal(8,2)").IsRequired();
                entity.Property(e => e.ComandaFinalizada).HasColumnType("bit");
                entity.Property(e => e.ComandaDeletado).HasColumnType("bit");
                entity.Property(e => e.ComandaDataUltimaAtualizacao).HasColumnType("datetime");
                entity.HasOne(e => e.Atendente).WithMany().HasForeignKey(e => e.AtendenteMatricula).OnDelete(DeleteBehavior.Restrict).IsRequired();
                entity.HasOne(e => e.Mesa).WithMany().HasForeignKey(e => e.MesaId).OnDelete(DeleteBehavior.Restrict).IsRequired();
                entity.HasMany(e => e.ProdutosComanda).WithOne().HasPrincipalKey(e => e.ComandaId).OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(e => e.Pagamento).WithOne().HasPrincipalKey(e => e.ComandaId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Pagamento>(entity => 
            {
                entity.ToTable("Pagamento");
                entity.HasKey(e => e.PagamentoId);
                entity.Property(e => e.PagamentoDataHora).HasColumnType("datetime");
                entity.Property(e => e.Valor).HasColumnType("decimal(8, 2)").IsRequired();
                entity.HasOne(e => e.FormaPagamento).WithMany().HasForeignKey(e => e.FormaPagamentoId).IsRequired();
                entity.HasOne(e => e.Comanda).WithMany().HasForeignKey(e => e.ComandaId).IsRequired();
                entity.HasOne(e => e.Usuario).WithMany().HasForeignKey(e => e.UsuarioMatricula).IsRequired();
            });

            modelBuilder.Entity<FormaPagamento>(entity => 
            {
                entity.ToTable("FormaPagamento");
                entity.HasKey(e => e.FormaPagamentoId);
                entity.Property(e => e.FormaPagamentoNome).HasMaxLength(30).IsUnicode(false).IsRequired();
                entity.Property(e => e.FormaPagamentoDeletado).HasColumnType("bit");
                entity.Property(e => e.FormaPagamentoDataUltimaAtualizacao).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mesa>(entity =>
            {
                entity.ToTable("Mesa");
                entity.HasKey(e => e.MesaId);
                entity.Property(e => e.MesaOcupada).HasColumnType("bit");
                entity.Property(e => e.MesaDeletada).HasColumnType("bit");
                entity.Property(e => e.MesaDataUltimaAtualizacao).HasColumnType("datetime");
            });
        }
    }
}
