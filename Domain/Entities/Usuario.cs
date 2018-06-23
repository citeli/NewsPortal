using System.Runtime.Serialization;

namespace Domain.Entities
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Senha { get; set; }
    }
}