using RackSwip.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RackSwip.Models
{
    public class Componente
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Rack")]
        public int RackId { get; set; }
        public Rack Rack { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public String Nombre { get; set; }
        public String FotoUrl { get; set; }
        public String NumeroSerie { get; set; }
        public EstadoComponente Estado { get; set; }
    }
}
