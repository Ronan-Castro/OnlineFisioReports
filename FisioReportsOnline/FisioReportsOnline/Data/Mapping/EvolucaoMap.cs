using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FisioReportsOnline.Models.Fisioterapico;

namespace FisioReportsOnline.Data.Mapping
{
    public class EvolucaoMap : IEntityTypeConfiguration<Evolucao>
    {
        public void Configure(EntityTypeBuilder<Evolucao> builder)
        {
            //Tabela
            builder.ToTable("Evolucao");

            //Chave Primária
            builder.HasKey(x => x.IdEvolucao);

            //Propriedades
            builder.Property(x => x.IdEvolucao)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.DataAtividade)
                .HasColumnName("DataAtividade")
                .HasColumnType("DATETIME");

            builder.Property(x => x.Aparelho)
                .HasColumnName("Aparelho")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.Anotacoes)
                .HasColumnName("Anotacoes")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.ClienteChegou)
                .HasColumnName("ClienteChegou")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.ClienteSaiu)
                .HasColumnName("ClienteSaiu")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.Fisioterapeuta)
                .HasColumnName("Fisioterapeuta")
                .HasColumnType("VARCHAR(100)")
                .IsRequired(false);

        }
    }
}
