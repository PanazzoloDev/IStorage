using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Insumos")]
    public class Supply
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Descricao")]
        public string Description { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; } = false;

        [Required]
        [StringLength(2)]
        [Column("UnidadeMedida")]
        public string UnitMeasure { get; set; }

        [Column("EstoqueSeg")]
        public double? SecurityInventory { get; set; }

        [Column("LoteMinimo")]
        public double? MinimumLot { get; set; }
    }
}