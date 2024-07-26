using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FisioReportsOnline.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Configure a propriedade Ativo com valor padrão true
            builder.Property(e => e.Ativo)
                   .HasDefaultValue(true)
                   .IsRequired();
        }
    }
}
