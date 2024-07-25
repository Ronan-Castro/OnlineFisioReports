using FisioReportsOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FisioReportsOnline.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<DoencasCondicoes> DoencasCondicoes { get; set; }
        public DbSet<HabitosVida> HabitosVida { get; set; }
        public DbSet<ExameFisico> ExameFisico { get; set; }
        public DbSet<PadraoMovimento> PadraoMovimento { get; set; }
        public DbSet<Cabeca> Cabeca { get; set; }
        public DbSet<Cervical> Cervical { get; set; }
        public DbSet<Ombros> Ombros { get; set; }
        public DbSet<Coluna> Coluna { get; set; }
        public DbSet<Pelve> Pelve { get; set; }
        public DbSet<Joelhos> Joelhos { get; set; }
        public DbSet<Pes> Pes { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        }
    }
