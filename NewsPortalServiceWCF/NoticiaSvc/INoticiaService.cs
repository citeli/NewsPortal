using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Entities;
using System.ServiceModel;

namespace NewsPortalServiceWCF.NoticiaSvc
{
    [ServiceContract]
    public interface INoticiaService
    {
        [OperationContract]
        void GravarNoticia(Noticia noticia);
    }
}