using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Almoxarifados")]
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Descricao")]
        public string Description { get; set; }

        [Required]
        [Column("Codigo")]
        public int Code { get; set; }

        [Required]
        [Column("EstoqueDisponivel")]
        public bool AvailableStock { get; set; }

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; } = false;

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}