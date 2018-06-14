using System.Collections.Generic;
using Application.Interface;using Domain.Entities;

namespace Application.Interfaces
{
    public interface INoticiaAppService : IAppServiceBase<Noticia>
    {
        IEnumerable<Noticia> BuscarPorPalavraChave(string palavraChave);
    }
}
