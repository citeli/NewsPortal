using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class NoticiaService : ServiceBase<Noticia>, INoticiaService
    {
        private readonly INoticiaRepository _noticiaRepository;

        public NoticiaService(INoticiaRepository noticiaRepository) : base(noticiaRepository)
        {
            _noticiaRepository = noticiaRepository;
        }

        public IEnumerable<Noticia> BuscaPorPalavraChave(string palavraChave)
        {
            return _noticiaRepository.BuscaPorPalavraChave(palavraChave);
        }
    }
}
