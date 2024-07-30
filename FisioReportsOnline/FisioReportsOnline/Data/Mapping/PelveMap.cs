using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;

namespace FisioReportsOnline.Data.Mapping
{
    public class PelveMap : IEntityTypeConfiguration<Pelve>
    {
        public void Configure(EntityTypeBuilder<Pelve> builder)
        {
            //Tabela
            builder.ToTable("Pelve");

            //Chave Primária
            builder.HasKey(x => x.IdPelve);

            //Propriedades
            builder.Property(x => x.IdPelve)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.IsNormal)
               .HasColumnName("Normal")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsAnteversao)
               .HasColumnName("Anteversao")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.LadoElevado)
               .HasColumnName("LadoElevado")
               .HasColumnType("TINYINT")
               .HasAnnotation("MySql:Comment", "0 - Elevado Direito e 1 - Elevado Esquerdo")
               .IsRequired(false);

            builder.Property(x => x.IsRetroversao)
               .HasColumnName("Retroversao")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsEscoliose)
               .HasColumnName("Escoliose")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);
        }
    }
}