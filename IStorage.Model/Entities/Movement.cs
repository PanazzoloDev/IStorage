using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("Movimentos")]
    public class Movement
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long MaterialId { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Quantity { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        public long? OriginWarehouseId { get; set; }

        public long? DestinationWarehouseId { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Notes { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public long? OrderId { get; set; }
    }
}