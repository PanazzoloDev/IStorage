using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("ProdutosPedidos")]
    public class ProductOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [Column("ProdutoId")]
        public long ProductId { get; set; }

        [Required]
        [Column("PedidoId")]
        public long OrderId { get; set; }
    }

}