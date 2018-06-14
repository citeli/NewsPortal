using System;
using System.ComponentModel.DataAnnotations;

namespace NewsPortalMVC.ViewModels
{
    public class NoticiaViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo titulo")]
        [MaxLength(30, ErrorMessage = "Máximo 30 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o campo conteudo")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Conteudo { get; set; }
        public string Imagem { get; set; }

        [DataType(DataType.Currency)]
        public DateTime DataPublicacao { get; set; }
        public UsuarioViewModel Usuario { get; set; }
        public string PalavraChave { get; set; }

        public NoticiaViewModel()
        {
            DataPublicacao = DateTime.Now;
        }
    }
}