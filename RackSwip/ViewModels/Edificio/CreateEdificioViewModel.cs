using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RackSwip.ViewModels.Edificio
{
    public class CreateEdificioViewModel
    {
        [Required(ErrorMessage = "El nombre del edificio es obligatorio")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "La ubicación del edificio es obligatorio")]
        public String Ubicacion { get; set; }
        public IFormFile FotoUrl { get; set; }
    }
}
