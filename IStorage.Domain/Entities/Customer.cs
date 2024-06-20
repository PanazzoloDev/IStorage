using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Clientes")]
    public class Customer
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Identification { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        public string CellPhone { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Deleted { get; set; } = false;
    }
}