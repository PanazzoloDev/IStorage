using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Produtos")]
    public class Product
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
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; }

        [Required]
        [Column("Codigo")]
        public int Code { get; set; }
    }
}