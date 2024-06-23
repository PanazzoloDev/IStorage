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
        [Column("InsumoId")]
        public long SupplyId { get; set; }

        [Required]
        [Column("Quantidade")]
        public double Quantity { get; set; }

        [Required]
        [Column("AlmoxId")]
        public long WarehouseId { get; set; }
    }
}