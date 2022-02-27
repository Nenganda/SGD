using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGD.Data.Model;

namespace SGD.Data.EntityConfig
{
    public class ApplicationProdutoMap : IEntityTypeConfiguration<Produto>
	{
		public void Configure(EntityTypeBuilder<Produto> modelBuilder)
		{
			//Informar a que o campo (Id) perteente a tabela AspNetUsers é a chave Primaria
			modelBuilder
				.HasKey(pr => pr.Id);

			//modelBuilder.HasOne(pr => pr.ProdutoCategorias) - Chave Estrangeira
			modelBuilder.HasOne(pr => pr.Categorias)
				.WithMany(pc => pc.Produtos)
				.HasForeignKey(pr => pr.CategoriaId);

			modelBuilder.HasOne(pr => pr.SubCategorias)
				.WithMany(psc => psc.Produtos)
				.HasForeignKey(pr => pr.SubCategoriaId)
				.OnDelete(DeleteBehavior.Restrict);

			//HasColumnType("varchar(250)") - Tipo e Tamanho de Caracter;  .IsRequired() - Campo Obrigatorio
			modelBuilder.Property(pr => pr.Titulo)
				.HasColumnType("varchar(250)")
				.IsRequired();

			modelBuilder.Property(pr => pr.Autor)
				.HasColumnType("varchar(250)")
				.IsRequired();

			modelBuilder.Property(pr => pr.Descricao)
				.HasColumnType("varchar(max)")
				.IsRequired();

			modelBuilder.Property(pr => pr.AnoPublicacao)
				.HasColumnType("int")
				.IsRequired();

			modelBuilder.Property(pr => pr.Editora)
				.HasColumnType("varchar(100)")
				.IsRequired();

			modelBuilder.Property(pr => pr.Edicao)
				.HasColumnType("varchar(50)")
				.IsRequired();

			modelBuilder.Property(pr => pr.AnoEdicao)
				.HasColumnType("int")
				.IsRequired();

			modelBuilder.Property(pr => pr.NumeroEdicao)
				.HasColumnType("int")
				.IsRequired();

			modelBuilder.Property(pr => pr.NumeroPagina)
				.HasColumnType("int")
				.IsRequired();

			modelBuilder.Property(pr => pr.Idioma)
				.HasColumnType("varchar(50)")
				.IsRequired();

			//modelBuilder.HasOne(pr => pr.ProdutoCategorias) - Chave Estrangeira
			modelBuilder.HasOne(pr => pr.Paises)
				.WithMany(pa => pa.Produtos)
				.HasForeignKey(pr => pr.PaisId);
		}
	}
}
