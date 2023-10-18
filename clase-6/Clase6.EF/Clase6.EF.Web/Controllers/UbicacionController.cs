using Clase6.EF.Data.EF;
using Clase6.EF.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase6.EF.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UbicacionController : Controller
{

    private IUbicacionServicio _ubicacionServicio;

    public UbicacionController(IUbicacionServicio ubicacionServicio)
    {
        this._ubicacionServicio = ubicacionServicio;
    }


    [HttpGet]
    public List<Ubicacion> Get()
    {
        return _ubicacionServicio.ObtenerTodos();
    }

    [HttpGet("{id}")]
    public Ubicacion Get(int id)
    {
        return _ubicacionServicio.ObtenerPorId(id);
    }

    [HttpPost]
    public void Post([FromBody] Ubicacion ubicacion)
    {
        _ubicacionServicio.Agregar(ubicacion);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Ubicacion ubicacion)
    {
        ubicacion.Id = id;
        _ubicacionServicio.Actualizar(ubicacion);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _ubicacionServicio.Eliminar(id);
    }
}
