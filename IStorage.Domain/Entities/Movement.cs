using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Movimentos")]
    public class Movement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("InsumoId")]
        public long SupplyId { get; set; }

        [Required]
        [Column("Quantidade")]
        public double Quantity { get; set; }

        [Required]
        [StringLength(1)]
        [Column("Tipo")]
        public string Type { get; set; }

        [Column("AlmoxOrigemId")]
        public long? SourceWarehouseId { get; set; }

        [Column("AlmoxDestinoId")]
        public long? DestinationWarehouseId { get; set; }

        [Required]
        [Column("Observacoes", TypeName = "text")]
        public string Observations { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; }

        [Column("PedidoId")]
        public long? OrderId { get; set; }
    }
}