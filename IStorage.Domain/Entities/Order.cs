using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IStorage.Domain.Enums;

namespace IStorage.Domain.Entities
{
    [Table("Pedidos")]
    public class Order
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public long CustomerId { get; set; }

        [Column(TypeName = "text")]
        public string Notes { get; set; }

        [Required]
        public long ResponsibleId { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Total { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Deleted { get; set; } = false;

        public DateTime? Deadline { get; set; }

        [Required]
        public OrderStatusEnum Status { get; set; }
    }
}