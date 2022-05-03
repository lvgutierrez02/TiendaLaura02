using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TiendaLaura.Business.Abstract;
using TiendaLaura.Business.DTOs;

namespace TiendaLaura.WEB.Controllers
{
    public class PrendasController : Controller
    {
        private readonly IPrendaBusiness _prendaBusiness;
        private readonly ITipoPrendaBusiness _tipoPrendaBusiness;
        private readonly IColorBusiness _colorBusiness;
        public PrendasController(IPrendaBusiness prendaBusiness, IColorBusiness colorBusiness, ITipoPrendaBusiness tipoPrendaBusiness)
        {
            _prendaBusiness = prendaBusiness;
            _colorBusiness = colorBusiness;
            _tipoPrendaBusiness = tipoPrendaBusiness;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.titulo = "Prendas";
            return View(await _prendaBusiness.GetPrendas());
        }


        [HttpGet]
        public async  Task<IActionResult> Crear() {
            
            ViewData["ListaColorPrendas"] = new SelectList(await _colorBusiness.GetColores(), "ColorId", "Color");
            ViewData["ListaTipoPrendas"] = new SelectList(await _tipoPrendaBusiness.GetTiposPrenda(), "TipoPrendaId", "TipoPrendaNombre");
            return View();
            
        }


        [HttpPost]
        public async Task<IActionResult> Crear(PrendaDto prendaDto) {

            if (ModelState.IsValid)
            {
                try
                {
                    _prendaBusiness.GuardarPrenda(prendaDto);
                    var guardarPrenda = await _prendaBusiness.GuardarCambios(); 
                    if (guardarPrenda )
                        return RedirectToAction("Index");
                    return View(prendaDto);
                       

                }
                catch (Exception)
                {

                    throw;
                }

            }
            ViewData["ListaColorPrendas"] = new SelectList(await _colorBusiness.GetColores(), "ColorId", "Color");
            return View(prendaDto);
        }
    }
}
