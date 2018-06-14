using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Config
{
    public class NoticiaConfig : EntityTypeConfiguration<Noticia>
    {
        public NoticiaConfig()
        {
            HasKey(n => n.Id);

            Property(n => n.Titulo)
                .IsRequired()
                .HasMaxLength(30);

            Property(n => n.Conteudo)
                .IsRequired()
                .HasMaxLength(200);

            Property(n => n.DataPublicacao)
                .IsRequired();

            Property(n => n.Imagem)
                .IsOptional();
        }
    }
}
