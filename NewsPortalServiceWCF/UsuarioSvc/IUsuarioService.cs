using System.Runtime.Serialization;
using System.ServiceModel;
using Domain.Entities;

namespace NewsPortalServiceWCF.UsuarioSvc
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IUsuarioService
    {

        [OperationContract]
        void GravarUsuario(Usuario usuario);

    }
}
