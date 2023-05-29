using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome")]

        public string Nome { get; set; }  
       
        public string Email { get; set; }
        public string DescricaoPerfil { get; set; }
        public IFormFile Foto { get; set; }

    }
}
