using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;

namespace FisioReportsOnline.Models.Fisioterapico.ExameFisico
{
    public class ColunaMap : IEntityTypeConfiguration<Coluna>
    {
        public void Configure(EntityTypeBuilder<Coluna> builder)
        {
            //Tabela
            builder.ToTable("Coluna");

            //Chave Primária
            builder.HasKey(x => x.IdExameFisico);

            //Propriedades
            builder.Property(x => x.IdExameFisico)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.IsNormal)
               .HasColumnName("Normal")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsEscoliose)
               .HasColumnName("Escoliose")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsHipercifose)
               .HasColumnName("Hipercifose")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.IsHiperlordose)
               .HasColumnName("Hiperlordose")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);
        }
    }
}