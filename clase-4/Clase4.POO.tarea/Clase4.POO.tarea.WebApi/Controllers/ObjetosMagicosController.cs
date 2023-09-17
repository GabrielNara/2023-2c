
using Clase4.POO.tarea.Logica;
using Clase4.POO.tarea.Logica.ObjetosMagicos;
using Clase4.POO.tarea.Logica.Servicios;
using Clase4.POO.tarea.WebApi.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.tarea.WebApi.Controllers
{
  
    [ApiController]
    [Route("api/objetos")]
    public class ObjetosMagicosController : ControllerBase
    {

        IPersonajeService _personajeService;
        public ObjetosMagicosController(IPersonajeService personajeService)
        {
            _personajeService = personajeService;
        }

        // Propiedad estática para almacenar la información de los objetos Magicos 
        private static List<ObjetoMagico> objetos = new List<ObjetoMagico>
    {
        new PocionCuracion(1, "Gluglu", "sanar moretones"),
        new PocionCuracion (2, "Catapunchis","curar ceguera" ),
        new Veneno(3, "Glu", "hacer moretones"),
        new Veneno (4, "Cataplun","dejar ciego" )
    };

        // GET /api/objetos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(objetos);
        }


        [HttpPost("usarPocion")]
        public IActionResult UsarPocion([FromBody] PocionRequest request)
        {
            var personaje = _personajeService.ObtenerPorId(request.PersonajeId);
            var pocion = objetos.Find(a => a.Id == request.PocionId);

            if (personaje == null || pocion == null)
            {
                return NotFound("No se encontró el personaje o pocion.");
            }

            pocion.Usar(personaje);

            return Ok($"{personaje.Nombre} usa una pocion llamada {pocion.Nombre} y hace {pocion.Efecto} de efecto. El HP de {personaje.Nombre} es ahora {personaje.HP} y su experiencia es {personaje.XP} ");

        }


        // POST /api/objetos/usarVeneno 
        [HttpPost("usarVeneno")]
        public IActionResult UsarVeneno([FromBody] VenenoRequest request)
        {
            var atacante = _personajeService.ObtenerPorId(request.AtacanteId);
            var objetivo = _personajeService.ObtenerPorId(request.ObjetivoId);
            var veneno = objetos.Find(a => a.Id == request.VenonoId);

            if (atacante == null || objetivo == null || veneno == null)
            {
                return NotFound("No se encontró el personaje, objetivo o veneno.");
            }

            veneno.Usar(objetivo);

            return Ok($"{atacante.Nombre} ataca a {objetivo.Nombre} con {veneno.Nombre} y hace {veneno.Efecto} de efecto. El HP de {objetivo.Nombre} es ahora {objetivo.HP} y su experiencia es {objetivo.XP} ");

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ObjetoMagico nuevoObjetoMagico)
        {
            //Busca el objeto
            ObjetoMagico objetoExistente = objetos.FirstOrDefault(obj => obj.Id == id);
          
            if (objetoExistente == null)
            {
                return NotFound(); 
            }

            // Actualiza el objeto existente con los datos del nuevo objeto.
            objetoExistente.Actualizar(nuevoObjetoMagico);

            // Aquí puedes realizar otras operaciones necesarias, como guardar en una base de datos si es necesario.

            return Ok(objetoExistente); // Retorna el objeto mágico actualizado.
        }










    }
}
