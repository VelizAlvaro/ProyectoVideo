using Helados.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Helados.Models
{
    public class Producto
    {
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public bool? Cantidad { get; set; }
        [Required]
        public bool? precio { get; set; }
      
        
    }
}
