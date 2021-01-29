using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    // Classe base para product
    // Obs: Talvez seja necessário fazer Map futuramente com uma classe view
    [Table("Product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage ="Este campo é obrigatório"), MaxLength(100,ErrorMessage ="Nome excede 100 caracteres")]
        public string name { get; set; }
        [MaxLength(250, ErrorMessage = "Descrição excede 250 caracteres")]
        public string description { get; set; }

        [MaxLength(13, ErrorMessage = "Código de barras em formato inválido")]
        public string bar_code { get; set; }
        
        public decimal value { get; set; }
        public bool active { get; set; }
    }
}
