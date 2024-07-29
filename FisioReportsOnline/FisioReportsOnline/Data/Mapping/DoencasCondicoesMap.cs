using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisioReportsOnline.Models.Fisioterapico
{
    public class DoencasCondicoesMap : IEntityTypeConfiguration<DoencasCondicoes>
    {
        public void Configure(EntityTypeBuilder<DoencasCondicoes> builder)
        {
            //Tabela
            builder.ToTable("DoencasCondicoes");

            //Chave Primária
            builder.HasKey(x => x.IdDoencasCondicoes);

            //Propriedades
            builder.Property(x => x.IdDoencasCondicoes)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.Metabolica)
            .HasColumnName("Metabolica")
            .HasColumnType("TINYINT(1)")
            .IsRequired(false);

            builder.Property(x => x.Cardiaca)
                .HasColumnName("Cardiaca")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Respiratorias)
                .HasColumnName("Respiratorias")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Vasculares)
                .HasColumnName("Vasculares")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Neurologicas)
                .HasColumnName("Neurologicas")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Endocrina)
                .HasColumnName("Endocrina")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Dermatologica)
                .HasColumnName("Dermatologica")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.GastroIntestinal)
                .HasColumnName("GastroIntestinal")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Visual)
                .HasColumnName("Visual")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Covid)
                .HasColumnName("Covid")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Diabete)
                .HasColumnName("Diabete")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Hipertensao)
                .HasColumnName("Hipertensao")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Cardiopatia)
                .HasColumnName("Cardiopatia")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Neoplasias)
                .HasColumnName("Neoplasias")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.DoencasHereditarias)
                .HasColumnName("DoencasHereditarias")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Gestacao)
                .HasColumnName("Gestacao")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);

            builder.Property(x => x.Cirurgias)
                .HasColumnName("Cirurgias")
                .HasColumnType("TINYINT(1)")
                .IsRequired(false);
        }
    }
}
