using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Estoque")]
    public class Inventory
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long MaterialId { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Quantity { get; set; }

        [Required]
        public long WarehouseId { get; set; }
    }
}