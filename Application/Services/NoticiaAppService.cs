using System.Collections.Generic;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class NoticiaAppService : AppServiceBase<Noticia>, INoticiaAppService
    {
        private readonly INoticiaService _noticiaService;

        public NoticiaAppService(INoticiaService noticiaService) : base(noticiaService)
        {
            _noticiaService = noticiaService;
        }

        public IEnumerable<Noticia> BuscarPorPalavraChave(string palavraChave)
        {
            return _noticiaService.BuscaPorPalavraChave(palavraChave);
        }
    }
}