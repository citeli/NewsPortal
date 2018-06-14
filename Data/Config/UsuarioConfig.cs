using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Config
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(50);

            Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
