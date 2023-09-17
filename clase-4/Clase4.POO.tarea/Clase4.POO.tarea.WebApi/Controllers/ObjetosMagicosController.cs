using Clase4.POO.tarea.Logica;
using Clase4.POO.tarea.Logica.ObjetosMagicos;
using Clase4.POO.tarea.Logica.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.tarea.WebApi.Controllers
{
    
    [ApiController]
    [Route("api/objetosMagicos")]
    public class ObjetosMagicosController : ControllerBase
    {
        IPersonajeService _personajeService;
        public ObjetosMagicosController(IPersonajeService personajeService)
        {
            _personajeService = personajeService;
        }

        // Propiedad estática para almacenar la información de los objetos magicos
        private static List<ObjetoMagico> objetosMagicos = new List<ObjetoMagico>
    {
        new PocionCuracion(1,"Pocion Curacion","curar"),
        new Veneno(2,"Veneno","dañar")

    };

        // GET /api/objetosMagicos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(objetosMagicos);
        }


    }
}
