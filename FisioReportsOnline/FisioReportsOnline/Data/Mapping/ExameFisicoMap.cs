using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;
using FisioReportsOnline.Models.Fisioterapico;

namespace FisioReportsOnline.Data.Mapping
{
    public class ExameFisicoMap : IEntityTypeConfiguration<ExameFisico>
    {
        public void Configure(EntityTypeBuilder<ExameFisico> builder)
        {
            //Tabela
            builder.ToTable("ExameFisico");

            //Chave Primária
            builder.HasKey(x => x.IdExameFisico);

            //Chave estrangeira
            builder.HasIndex(dc => dc.IdAvaliacao).IsUnique();

            //Propriedades
            builder.Property(x => x.IdExameFisico)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.Equilibrio)
               .HasColumnName("Equilibrio")
               .HasColumnType("TINYINT(1)")
               .IsRequired(false);

            builder.Property(x => x.FroxidaoLigamentar)
                .HasColumnName("FroxidaoLigamentar")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.EstabilidadeEscapular)
                .HasColumnName("EstabilidadeEscapular")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.MobilidadeColuna)
                .HasColumnName("MobilidadeColuna")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.PadraoMovimento)
            .HasColumnName("PadraoMovimento")
            .HasColumnType("TINYINT")
            .HasAnnotation("MySql:Comment", "0 - Maleável e 1 - Rígido")
            .IsRequired();

            builder.Property(x => x.Cabeca)
            .HasColumnName("Cabeca")
            .HasColumnType("TINYINT")
            .HasAnnotation("MySql:Comment", "0 - Normal, 1 - Inclinada Esquerda e 2 - Inclinada Direita")
            .IsRequired();

            builder.Property(x => x.Cervical)
            .HasColumnName("Cervical")
            .HasColumnType("TINYINT")
            .HasAnnotation("MySql:Comment", "0 - Normal, 1 - Anteriorizada e 2 - Retificada")
            .IsRequired();

            builder.Property(x => x.Joelhos)
            .HasColumnName("Joelhos")
            .HasColumnType("TINYINT")
            .HasAnnotation("MySql:Comment", "0 - Normal, 1 - Valgo e 2 - Varo")
            .IsRequired();

            builder.Property(x => x.Pes)
            .HasColumnName("Pes")
            .HasColumnType("TINYINT")
            .HasAnnotation("MySql:Comment", "0 - Normal, 1 - Valgo e 2 - Varo")
            .IsRequired();

            //Relações um para um
            builder.HasOne(ex => ex.Ombros)
                .WithOne()
                .HasForeignKey<Ombro>(o => o.IdExameFisico)
                .IsRequired();

            builder.HasOne(ex => ex.Coluna)
                .WithOne()
                .HasForeignKey<Coluna>(c => c.IdExameFisico)
                .IsRequired();

            builder.HasOne(ex => ex.Pelve)
                .WithOne()
                .HasForeignKey<Pelve>(p => p.IdExameFisico)
                .IsRequired();
        }
    }
}