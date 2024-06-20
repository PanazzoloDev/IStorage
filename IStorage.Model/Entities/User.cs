using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Model.Entities
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Column(TypeName = "text")]
        public string Image { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool Deleted { get; set; } = false;

        [Required]
        public DateTime BirthDate { get; set; }
    }
}