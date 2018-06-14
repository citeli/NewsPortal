using AutoMapper;
using Domain.Entities;
using NewsPortalMVC.ViewModels;

namespace NewsPortalMVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Noticia, NoticiaViewModel>();
        }
    }
}