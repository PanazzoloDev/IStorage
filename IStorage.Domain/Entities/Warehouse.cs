using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Almoxarifados")]
    public class Warehouse
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public bool StockAvailable { get; set; } = false;

        [Required]
        public bool Deleted { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; }

    }
}