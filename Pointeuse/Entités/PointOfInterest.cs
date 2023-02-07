using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Pointeuse.Entités
{
    public class PointOfInterest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        //Attribut taille
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }

        [ForeignKey("VilleId")]
        public Ville? Ville { get; set; }

        public int VilleId { get; set; }


        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}
