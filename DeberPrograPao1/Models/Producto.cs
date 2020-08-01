using System.ComponentModel.DataAnnotations;

namespace DeberPrograPao1.Models
{
    public abstract class Producto
    {
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
    }
}
