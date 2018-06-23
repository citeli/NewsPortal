using System;
using System.Runtime.Serialization;

namespace Domain.Entities
{
    [DataContract]
    public class Noticia
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Conteudo { get; set; }
        [DataMember]
        public string Imagem { get; set; }
        [DataMember]
        public DateTime DataPublicacao { get; set; }
        [DataMember]
        public Usuario Usuario { get; set; }
        [DataMember]
        public string PalavraChave { get; set; }
    }
}
