using FisioReportsOnline.Data.Mapping;
using FisioReportsOnline.Models;
using FisioReportsOnline.Models.Fisioterapico;
using FisioReportsOnline.Models.Fisioterapico.ComposicaoExameFisico;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FisioReportsOnline.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<DoencaCondicao> DoencasCondicoes { get; set; }
        public DbSet<HabitoVida> HabitosVida { get; set; }
        public DbSet<ExameFisico> ExamesFisicos { get; set; }
        public DbSet<Ombro> Ombros { get; set; }
        public DbSet<Coluna> Colunas { get; set; }
        public DbSet<Pelve> Pelves { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Endereco> Enderecos{ get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Aplicar a configura��o da entidade ApplicationUser
            builder.ApplyConfiguration(new UsuarioMap());
        }

    }
}
