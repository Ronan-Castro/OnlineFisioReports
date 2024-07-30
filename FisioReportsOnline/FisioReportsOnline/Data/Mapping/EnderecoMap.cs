using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models;

namespace FisioReportsOnline.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Tabela
            builder.ToTable("Endereco");

            //Chave Primária
            builder.HasKey(x => x.IdEndereco);

            //Propriedades
            builder.Property(x => x.IdEndereco)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();
        }
    }
}
