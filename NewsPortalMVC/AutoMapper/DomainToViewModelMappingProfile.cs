using AutoMapper;
using Domain.Entities;
using NewsPortalMVC.ViewModels;

namespace NewsPortalMVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<NoticiaViewModel, Noticia>();
        }
    }
}