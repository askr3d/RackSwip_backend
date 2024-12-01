using Microsoft.AspNetCore.Mvc;
using RackSwip.Interfaces;
using RackSwip.Models;
using RackSwip.ViewModels.Edificio;

namespace RackSwip.Controllers
{
    public class EdificioController : Controller
    {
        private readonly string carpetaImagenes = "edificios";
        private readonly IEdificioRepository _edificioRepository;
        private readonly IPhotoService _photoService;

        public EdificioController(
            IEdificioRepository edificioRepository,
            IPhotoService photoService
        )
        {
            _edificioRepository = edificioRepository;
            _photoService = photoService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Edificio> edificios = await _edificioRepository.GetAllEdificios();
            return View(edificios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEdificioViewModel edificioVM)
        {
            if (ModelState.IsValid)
            {
                if (edificioVM.FotoUrl == null)
                {
                    ModelState.AddModelError("FotoUrl", "Debe subir una imagen");
                }
                else
                {
                    var result = await _photoService.AddPhotoAsync(edificioVM.FotoUrl, carpetaImagenes);
                    var edificio = new Edificio
                    {
                        Nombre = edificioVM.Nombre,
                        Ubicacion = edificioVM.Ubicacion,
                        FotoUrl = result
                    };
                    _edificioRepository.Add(edificio);
                    return RedirectToAction("Index");
                }
            }

            return View(edificioVM);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Edificio edificio = await _edificioRepository.GetByIdAsync(id);
            EditEdificioViewModel model = new EditEdificioViewModel
            {
                Id = edificio.Id,
                Nombre = edificio.Nombre,
                Ubicacion = edificio.Ubicacion,
                FotoSrc = edificio.FotoUrl
            };

            return View(model);
        }
    }
}
