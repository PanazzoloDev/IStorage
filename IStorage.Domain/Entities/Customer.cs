using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Clientes")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(150)]
        [Column("Identificacao")]
        public string Identification { get; set; }

        [StringLength(50)]
        [Column("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(11)]
        [Column("Celular")]
        public string Cellphone { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; } = false;
    }
}