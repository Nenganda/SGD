using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGD.Data.Model;

namespace SGD.Data.EntityConfig
{
    public class ApplicationCategoriaMap : IEntityTypeConfiguration<Categoria>
	{
		public void Configure(EntityTypeBuilder<Categoria> modelBuilder)
		{
			//Informar a que o campo (Id) perteente a tabela AspNetUsers é a chave Primaria
			modelBuilder
				.HasKey(pc => pc.Id);

			//HasColumnType("varchar(250)") - Tipo e Tamanho de Caracter;  .IsRequired() - Campo Obrigatorio
			modelBuilder.Property(pc => pc.Nome)
				.HasColumnType("varchar(250)")
				.IsRequired();

			modelBuilder.Property(pc => pc.Descricao)
				.HasColumnType("varchar(1000)")
				.IsRequired();
		}
	}
}