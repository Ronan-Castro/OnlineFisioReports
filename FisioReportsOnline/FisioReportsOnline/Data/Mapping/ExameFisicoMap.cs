using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class ExameFisicoMap : IEntityTypeConfiguration<ExameFisico>
    {
        public void Configure(EntityTypeBuilder<ExameFisico> builder)
        {  
            //Tabela
            builder.ToTable("ExameFisico");

            //Chave Primária
            builder.HasKey(x => x.IdExameFisico);

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
                .WithOne(o => o.ExameFisico)
                .HasForeignKey<Ombros>(o => o.IdExameFisico)
                .IsRequired();

            builder.HasOne(ex => ex.Coluna)
                .WithOne(c => c.ExameFisico)
                .HasForeignKey<Coluna>(c => c.IdExameFisico)
                .IsRequired();

            builder.HasOne(ex => ex.Pelve)
                .WithOne(p => p.ExameFisico)
                .HasForeignKey<Pelve>(p => p.IdExameFisico)
                .IsRequired();
        }
    }
}