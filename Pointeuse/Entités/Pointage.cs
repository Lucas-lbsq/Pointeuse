using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic.ApplicationServices;

namespace Pointeuse.Entités
{
    public class Pointage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public virtual User user { get; set; } = new User();

        [MaxLength(50)]
        public string Heure_Matin { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Heure_Midi { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Heure_ApresMidi { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Heure_Soir { get; set; } = string.Empty;

    }
}
