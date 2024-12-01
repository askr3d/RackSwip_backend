using System.ComponentModel.DataAnnotations;

namespace RackSwip.ViewModels.Edificio
{
    public class EditEdificioViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del edificio es obligatorio")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "La ubicación del edificio es obligatorio")]
        public String Ubicacion { get; set; }
        public String FotoSrc { get; set; }
        public IFormFile FotoUrl { get; set; }
    }
}
