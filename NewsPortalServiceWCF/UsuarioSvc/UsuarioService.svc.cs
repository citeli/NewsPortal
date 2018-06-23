using System;
using System.ServiceModel;
using Application.Services;
using Data.Repositories;
using Domain.Interfaces.Repositories;
using Domain.Entities;

namespace NewsPortalServiceWCF.UsuarioSvc
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class UsuarioService : IUsuarioService
    {
        public void GravarUsuario(Usuario usuario)
        {
            IUsuarioRepository usuarioRepository = new UsuarioRepository();

            Domain.Interfaces.Services.IUsuarioService usuarioService = new Domain.Services.UsuarioService(usuarioRepository);
            
            UsuarioAppService usuarioAppService = new UsuarioAppService(usuarioService);

            usuarioAppService.Add(usuario);
        }
    }
}
