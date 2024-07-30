using FisioReportsOnline.Models.Fisioterapico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FisioReportsOnline.Data.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            //Tabela
            builder.ToTable("Avaliacao");

            //Chave Primária
            builder.HasKey(x => x.IdAvaliacao);

            //Propriedades
            builder.Property(x => x.IdAvaliacao)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.DiagClinico)
                .HasColumnName("DiagnosticoClinico")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.DiagFisioterapeutico)
                .HasColumnName("DiagnosticoFisioterapeutico")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.QueixaPrincipal)
                .HasColumnName("QueixaPrincipal")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.ObservacaoDoenca)
                .HasColumnName("ObservacaoDoenca")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.TratamentoAnterior)
                .HasColumnName("TratamentoAnterior")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.ObjetivoTerapeutico)
                .HasColumnName("ObjetivoTerapeutico")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.ObjetivoPessoal)
                .HasColumnName("ObjetivoPessoal")
                .HasColumnType("TEXT")
                .IsRequired(false);

            builder.Property(x => x.DataAtendimento)
                .HasColumnName("DataAtendimento")
                .HasColumnType("TEXT")
                .IsRequired(false);

            //Índices

            //Relações de um para um
            builder.HasOne(a => a.DoencasCondicoes)
                .WithOne()
                .HasForeignKey<DoencaCondicao>(dc => dc.IdAvaliacao)
                .IsRequired();

            builder.HasOne(x => x.ExameFisico)
                .WithOne()
                .HasForeignKey<ExameFisico>(ef => ef.IdAvaliacao)
                .IsRequired();

            builder.HasOne(x => x.HabitosVida)
                .WithOne()
                .HasForeignKey<HabitoVida>(hv => hv.IdAvaliacao)
                .IsRequired();
        }
    }

}
