using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class NoticiaRepository : RepositoryBase<Noticia>, INoticiaRepository
    {
        public IEnumerable<Noticia> BuscaPorPalavraChave(string palavraChave)
        {
            return Db.Noticias.Where(n => n.PalavraChave == palavraChave);
        }
    }
}
