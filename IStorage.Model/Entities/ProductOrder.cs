using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("ProdutosPedidos")]
    public class ProductOrder
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required]
        public long OrderId { get; set; }
    }
}