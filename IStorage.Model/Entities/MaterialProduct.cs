using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("InsumosProdutos")]
    public class MaterialProduct
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long MaterialId { get; set; }

        [Required]
        public long ProductId { get; set; }
    }
}