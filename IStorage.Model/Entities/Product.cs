using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("Produtos")]
    public class Product
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
        public int Code { get; set; }
    }
}