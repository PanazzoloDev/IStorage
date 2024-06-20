using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("Insumos")]
    public class Material
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Deleted { get; set; } = false;

        [Required]
        [StringLength(2)]
        public string UnitOfMeasure { get; set; }

        [Column(TypeName = "float")]
        public double? SafetyStock { get; set; }

        [Column(TypeName = "float")]
        public double? MinimumBatch { get; set; }
    }
}