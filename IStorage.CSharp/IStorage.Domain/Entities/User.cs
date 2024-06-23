using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IStorage.Domain.Entities
{
    [Table("Usuarios")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Nome")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Login")]
        public string Login { get; set; }

        [Required]
        [StringLength(20)]
        [Column("Senha")]
        public string Password { get; set; }

        [Column("Imagem", TypeName = "text")]
        public string Image { get; set; }

        [Required]
        [Column("Codigo")]
        public int Code { get; set; }

        [Required]
        [Column("CriadoEm")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Required]
        [Column("Excluido")]
        public bool Deleted { get; set; } = false;

        [Required]
        [Column("Nascimento")]
        public DateTime Birthdate { get; set; }
    }
}