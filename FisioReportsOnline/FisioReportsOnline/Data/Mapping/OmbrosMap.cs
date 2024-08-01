using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;

namespace FisioReportsOnline.Data.Mapping
{
    public class OmbrosMap : IEntityTypeConfiguration<Ombro>
    {
        public void Configure(EntityTypeBuilder<Ombro> builder)
        {
            //Tabela
            builder.ToTable("Ombros");

            //Chave Primária
            builder.HasKey(x => x.IdOmbros);

            //Propriedades
            builder.Property(x => x.IdOmbros)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.IsNormal)
               .HasColumnName("Normal")
               .HasColumnType("TINYINT(1)");

            builder.Property(x => x.IsAnteriorizada)
               .HasColumnName("Anteriorizada")
               .HasColumnType("TINYINT(1)");

            builder.Property(x => x.LadoElevado)
               .HasColumnName("LadoElevado")
               .HasColumnType("TINYINT")
               .HasAnnotation("MySql:Comment", "0 - Elevado Direito e 1 - Elevado Esquerdo");

            builder.Property(x => x.IsEscapulaAlada)
               .HasColumnName("EscapulaAlada")
               .HasColumnType("TINYINT(1)");
        }
    }
}