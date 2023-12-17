using Helados.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Helados.Models
{
    public class Usuario
    {
        [Key]
        public int Ci { get; set; }
        [Required]
        public string? Direcion { get; set; }
        [Required]
        public string? NombreCompleto { get; set; }
        [Required]
        public int? tel { get; set; }
        [Required]
        public string? Cuenta { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public RolEnum Rol { get; set; }


    }
}
