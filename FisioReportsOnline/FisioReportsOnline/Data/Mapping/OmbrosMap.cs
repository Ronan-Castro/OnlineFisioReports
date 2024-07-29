using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ExameFisico;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class OmbrosMap : IEntityTypeConfiguration<Ombros>
    {
        public void Configure(EntityTypeBuilder<Ombros> builder)
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
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsAnteriorizada)
               .HasColumnName("Anteriorizada")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.LadoElevado)
               .HasColumnName("LadoElevado")
               .HasColumnType("TINYINT")
               .HasAnnotation("MySql:Comment", "0 - Elevado Direito e 1 - Elevado Esquerdo")
               .IsRequired(false);

            builder.Property(x => x.IsEscapulaAlada)
               .HasColumnName("EscapulaAlada")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);
        }
    }
}