using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("Textos")]
    public class Texto
    {

        [Key]
        public int Id { get; set; }    

        [Display(Name ="Título")]
        [Required(ErrorMessage ="Obrigatório informar o Título")]

        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        [Display(Name = "Tag")]
        [Required(ErrorMessage = "Obrigatório informar a tag")]
        public ClassificacaoTexto Tipo { get; set; }

        [Display(Name="Texto")]
        [Required(ErrorMessage = "Escreva aqui o seu texto")]
        public string Artigo { get; set; }

        public int IdPerfil { get; set; }
        [ForeignKey("IdPerfil")]
        public Perfil Perfil { get; set; }
    }

    public enum ClassificacaoTexto
    {
        [Display(Name = "Ciencias Exatas e da Terra")]
        CiênciasExatasEdaTerra,
        [Display(Name = "Ciencias Humanas")]
        CiênciasHumanas,
        [Display(Name = "Ciencias Sociais")]
        CiênciasSociais,
        [Display(Name = "Somente Exatas")]
        SomenteExatas,
        [Display(Name = "Outros")]
        Outros
    }


}
