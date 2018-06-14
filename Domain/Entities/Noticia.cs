using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Imagem { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Usuario Usuario { get; set; }
        public string PalavraChave { get; set; }

        public Noticia()
        {
            DataPublicacao = DateTime.Now;
        }
    }
}
