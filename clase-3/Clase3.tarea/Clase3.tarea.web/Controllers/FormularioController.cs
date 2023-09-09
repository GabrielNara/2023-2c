using Clase3.tarea.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.tarea.web.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EnviarRespuesta()
        {
            return View(new FormularioViewModel());
        }

        [HttpPost]
        public IActionResult EnviarRespuesta(FormularioViewModel request)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(request);
        }




    }
}
