using System;
using Application.Services;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace NewsPortalServiceWCF.NoticiaSvc
{
    public class NoticiaService : INoticiaService
    {
        public void GravarNoticia(Noticia noticia)
        {
            INoticiaRepository noticiaRepository = new NoticiaRepository();

            Domain.Interfaces.Services.INoticiaService noticiaService = new Domain.Services.NoticiaService(noticiaRepository);

            NoticiaAppService noticiaAppService = new NoticiaAppService(noticiaService);

            noticiaAppService.Add(noticia);
        }
    }
}
