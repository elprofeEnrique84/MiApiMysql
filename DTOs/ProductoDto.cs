using System.ComponentModel.DataAnnotations;

namespace MIAPIMYSQL.DTOs
{
    // DTO para crear o actualizar un producto (sin Id)
    public class ProductoDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        public decimal Precio { get; set; }
    }
}
