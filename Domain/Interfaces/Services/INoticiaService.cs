using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Services
{
    public interface INoticiaService : IServiceBase<Noticia>
    {
        IEnumerable<Noticia> BuscaPorPalavraChave(string palavraChave);
    }
}
