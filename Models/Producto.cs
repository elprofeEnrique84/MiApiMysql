using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIAPIMYSQL.Models
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nombre")]
        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [Column("precio", TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }
    }
}
