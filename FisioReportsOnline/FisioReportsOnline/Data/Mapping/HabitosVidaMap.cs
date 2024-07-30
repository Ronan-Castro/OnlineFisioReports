using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FisioReportsOnline.Models.Fisioterapico;

namespace FisioReportsOnline.Data.Mapping
{
    public class HabitosVidaMap : IEntityTypeConfiguration<HabitoVida>
    {
        public void Configure(EntityTypeBuilder<HabitoVida> builder)
        {
            //Tabela
            builder.ToTable("HabitosVida");

            //Chave Primária
            builder.HasKey(x => x.IdHabitosVida);

            //Chave estrangeira
            builder.HasIndex(dc => dc.IdAvaliacao).IsUnique();

            //Propriedades
            builder.Property(x => x.IdHabitosVida)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.Tabagismo)
                .HasColumnName("Tabagismo")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Etilismo)
                .HasColumnName("Etilismo")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.IngereAgua)
                .HasColumnName("IngereAgua")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Medicacao)
                .HasColumnName("Medicacao")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Intestino)
                .HasColumnName("Intestino")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.AtivFisica)
                .HasColumnName("AtivFisica")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Pilates)
                .HasColumnName("Pilates")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.ObsHabitos)
                .HasColumnName("ObsHabitos")
                .HasColumnType("TEXT")
                .IsRequired(false);
        }
    }
}