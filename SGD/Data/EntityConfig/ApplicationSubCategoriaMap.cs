using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGD.Data.Model;

namespace SGD.Data.EntityConfig
{
    public class ApplicationSubCategoriaMap : IEntityTypeConfiguration<SubCategoria>
	{
		public void Configure(EntityTypeBuilder<SubCategoria> modelBuilder)
		{
			//Informar a que o campo (Id) perteente a tabela AspNetUsers é a chave Primaria
			modelBuilder
				.HasKey(psc => psc.Id);

			//HasColumnType("varchar(250)") - Tipo e Tamanho de Caracter;  .IsRequired() - Campo Obrigatorio
			modelBuilder.Property(psc => psc.Nome)
				.HasColumnType("varchar(250)")
				.IsRequired();

			modelBuilder.Property(psc => psc.Descricao)
				.HasColumnType("varchar(1000)")
				.IsRequired();

			//modelBuilder.HasOne(pr => pr.ProdutoCategorias) - Chave Estrangeira
			modelBuilder.HasOne(psc => psc.Categorias)
				.WithMany(pc => pc.SubCategorias)
				.HasForeignKey(psc => psc.CategoriaId);
		}
	}
}
