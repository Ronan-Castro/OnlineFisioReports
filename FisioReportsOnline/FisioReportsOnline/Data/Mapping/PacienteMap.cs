using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FisioReportsOnline.Models;
using FisioReportsOnline.Models.Fisioterapico;

namespace FisioReportsOnline.Data.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            //Tabela
            builder.ToTable("Paciente");

            //Chave Primária
            builder.HasKey(x => x.IdPaciente);

            //Propriedades
            builder.Property(x => x.IdPaciente)
                .ValueGeneratedOnAdd()
                .UseMySqlIdentityColumn();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)")
                .IsRequired(false);

            builder.Property(x => x.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("VARCHAR(11)")
                .IsRequired(false);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(80)")
                .IsRequired(false);

            builder.Property(x => x.Profissao)
                .HasColumnName("Profissao")
                .HasColumnType("VARCHAR(50)")
                .IsRequired(false);

            builder.Property(x => x.DataUltimaAvaliacao)
                .HasColumnName("DataUltimaAvaliacao")
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder.Property(x => x.DataUltimaAtividade)
                .HasColumnName("DataUltimaAtividade")
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder.Property(x => x.Sexo)
                .HasColumnName("Sexo")
                .HasColumnType("TINYINT")
                .IsRequired(false);

            //Relações de um para muitos
            builder
                .HasMany(p => p.Avaliacoes)
                .WithOne(a => a.Paciente)
                .HasForeignKey(a => a.IdPaciente);

            //Relações de um para um
            builder.HasOne(p => p.Endereco)
                .WithOne()
                .HasForeignKey<Endereco>(e => e.IdPaciente)
                .IsRequired();
        }

        //Usando ICollection para suportar lazy loading que o EF utiliza.
        public ICollection<Avaliacao> Avaliacoes { get; internal set; }
        public ICollection<Evolucao> Evolucoes { get; internal set; }
    }
}
