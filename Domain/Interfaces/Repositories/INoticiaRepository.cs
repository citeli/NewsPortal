using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface INoticiaRepository : IRepositoryBase<Noticia>
    {
        IEnumerable<Noticia> BuscaPorPalavraChave(string palavraChave);
    }
}
