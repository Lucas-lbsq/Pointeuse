using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointeuse.Entités
{
    public class DetailUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDetailUser { get; set; }

        public int idUser { get; set; }

        [ForeignKey("idUser")]
        public User? user { get; set; }
        public string? Details { get; set; }
    }
}
