using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IStorage.Domain.Enums;

namespace IStorage.Domain.Entities
{
    [Table("Pedidos")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("Codigo")]
        public int Code { get; set; }

        [Required]
        [Column("ClienteId")]
        public long CustomerId { get; set; }

        [Column("Observacoes", TypeName = "text")]
        public string Observations { get; set; }

        [Required]
        [Column("ResponsavelId")]
        public long ResponsibleId { get; set; }

        [Required]
        [Column("Total")]
        public double Total { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; }

        [Column("Prazo")]
        public DateTime? Deadline { get; set; }

        [Required]
        [Column("Status")]
        public int Status { get; set; }
    }
}