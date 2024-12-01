using RackSwip.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RackSwip.Models
{
    public class Rack
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Side")]
        public int SideId { get; set; }
        public Side Side { get; set; }
        public String Nombre { get; set; }
        public String FotoUrl { get; set; }
        public AccesibilidadCategory Accesibilidad { get; set; }
        public ICollection<Componente> Componentes { get; set; }
    }
}
