using System.ComponentModel.DataAnnotations;

namespace RackSwip.Models
{
    public class Edificio
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Ubicacion { get; set; }
        public String FotoUrl { get; set; }
        public ICollection<Side> Sides { get; set; }
    }
}
