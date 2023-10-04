using clase5.logica;
using Microsoft.AspNetCore.Mvc;

namespace clase5.mvc.Controllers
{
    public class PrincipalController : Controller
    {

        private readonly IRectanguloService _rectanguloService;

        public PrincipalController(IRectanguloService rectanguloService)
        {
            _rectanguloService = rectanguloService;
        }


        public IActionResult Bienvenido()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CalcularAreaRectangulo()
        {
            return View(new Rectangulo());
        }

        [HttpPost]
        public IActionResult CalcularAreaRectangulo(Rectangulo request)
        {
           if(ModelState.IsValid)
            {
                _rectanguloService.Agregar(request);
                TempData["UltimoRectanguloAgregado"] = request.Id;
                return RedirectToAction("Resultados");
            }
           return View(request);
        }


        [HttpGet]
        public IActionResult Resultados()
        {
            return View(_rectanguloService.Listar());
        }






    }
}
