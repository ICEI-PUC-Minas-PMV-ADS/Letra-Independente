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
        [Required(ErrorMessage ="obrigatório informar a Título")]

        public string Titulo { get; set; }

        public DateTime Data { get; set; }


        [Required(ErrorMessage = "obrigatório informar a Estrutura")]

        public int Estrutura { get; set; }

        [Display(Name = "Tipo de texto")]
        [Required(ErrorMessage = "obrigatório informar a Tipo")]
        public ClassificacaoTexto Tipo { get; set; }

       
    }

    public enum ClassificacaoTexto

    {
        CiênciasExatasedaTerra,
        CiênciasHumanas,
        CiênciasSociais,
        Outros,
        somenteexatas   

           

    }


}
