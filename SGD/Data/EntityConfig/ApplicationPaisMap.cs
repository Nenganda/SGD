using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGD.Data.Model;

namespace SGD.Data.EntityConfig
{
    public class ApplicationPaisMap : IEntityTypeConfiguration<Pais>
	{
		public void Configure(EntityTypeBuilder<Pais> modelBuilder)
		{
			//Informar a que o campo (Id) perteente a tabela AspNetUsers é a chave Primaria
			modelBuilder
				.HasKey(pa => pa.Id);

			//HasColumnType("varchar(250)") - Tipo e Tamanho de Caracter;  .IsRequired() - Campo Obrigatorio
			modelBuilder.Property(pa => pa.Nome)
				.HasColumnType("varchar(250)")
				.IsRequired();
		}
	}
}
