using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DeberPrograPao1.ViewModels
{
    public class PersonaViewModel
    {
        public int Id { get; internal set; }
        [Required]
        public string Nombre { get; set; }
        [Display(Name = "Fotografía")]
        public IFormFile Foto { get; set; }
    }
}
