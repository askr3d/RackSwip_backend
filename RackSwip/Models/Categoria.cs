using System.ComponentModel.DataAnnotations;

namespace RackSwip.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
    }
}
