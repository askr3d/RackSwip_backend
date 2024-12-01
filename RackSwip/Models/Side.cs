using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RackSwip.Models
{
    public class Side
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Edificio")]
        public int EdificioId { get; set; }
        public Edificio Edificio { get; set; }
        public String Nombre { get; set; }
        public String FotoUrl { get; set; }
        public ICollection<Rack> Racks { get; set; }
    }
}
