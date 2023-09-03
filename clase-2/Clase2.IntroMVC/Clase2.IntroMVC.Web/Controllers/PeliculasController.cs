using Clase2.IntroMvc.Logica;
using Clase2.IntroMVC.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace Clase2.IntroMVC.Web.Controllers
{
    public class PeliculasController : Controller
    {
        private IPeliculasRepositorio _peliculasRepositorio;
        public PeliculasController(IPeliculasRepositorio peliculasRepositorio)
        {
            _peliculasRepositorio = peliculasRepositorio;
        }
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Pelicula pelicula)
        {
           pelicula.EstaEnStarPlus = Request.Form["EstaEnStarPlus"] == "on";
            pelicula.EstaEnNetflix = Request.Form["EstaEnNetflix"] == "on";
            pelicula.EstaEnHBO = Request.Form["EstaEnHBO"] == "on";
            pelicula.EstaEnDisney = Request.Form["EstaEnDisney"] == "on";
            pelicula.EstaEnAmazon = Request.Form["EstaEnAmazon"] == "on"; 
            _peliculasRepositorio.Agregar(pelicula);
            return RedirectToAction("Listado");
        }

        public IActionResult Listado()
        {
            var peliculas = _peliculasRepositorio.ObtenerTodas();
            return View(peliculas);
        }

    }
}
