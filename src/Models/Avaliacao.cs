using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("Avaliacoes")]
    public class Avaliacao
    {
       [Key]
       public int Id { get; set; }

        [Display(Name = "Comentário")]
        public string Comentario { get; set; }
        [Display(Name = "Entendimento")]
        [Required(ErrorMessage = "Adicione o seu nível de entendimento com relação ao texto")]
        public Entendimento Entendimento { get; set; }
        public int IdTexto { get; set; }
        [ForeignKey("IdTexto")]
        public Texto Texto { get; set; }
    }
}

public enum Entendimento
{
     Entendi,
     EntendiParcialmente,
     NaoEntendi,
}
