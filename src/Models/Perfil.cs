using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;


namespace src.Models
{
    [Table("Perfis")]
    public class Perfil
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string NomePerfil { get; set; }

        public string DescricaoPerfil { get; set; }

        public int IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

    }
}
