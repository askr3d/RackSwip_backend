using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RackSwip.Models
{
    public class DireccionIP
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Componente")]
        public int ComponenteId { get; set; }
        public Componente Componente { get; set; }
        public String DNS { get; set; }
        public String Direccion { get; set; }
    }
}
