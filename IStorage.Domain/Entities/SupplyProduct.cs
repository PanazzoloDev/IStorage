using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("InsumosProdutos")]
    public class SupplyProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("InsumoId")]
        public long SupplyId { get; set; }

        [Required]
        [Column("ProdutoId")]
        public long ProductId { get; set; }
    }
}