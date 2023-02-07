using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pointeuse.Entités
{
    public class Ville
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
        [MaxLength(200)]

        public ICollection<PointOfInterest> PointsOfInsterest { get; set; }
                = new List<PointOfInterest>();
        
        //rendre une donnée obligatoire
        public Ville(string name)
        {
            Name = name;
        }
    }
}
