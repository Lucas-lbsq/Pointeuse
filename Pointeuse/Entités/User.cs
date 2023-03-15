using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pointeuse.Entités
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nom { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Prenom { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Identifiant { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Password { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Service { get; set; } = string.Empty;
    } 
}
