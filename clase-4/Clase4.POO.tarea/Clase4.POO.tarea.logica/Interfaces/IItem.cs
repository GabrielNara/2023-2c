using Clase4.POO.tarea.Logica.ObjetosMagicos;

namespace Clase4.POO.tarea.Logica.Interfaces;

/// <summary>
/// Interfaz para objetos que pueden ser utilizados por un personaje
/// </summary>
public interface IItem
{
    public int Id { get; set; }
    string Nombre { get; }
    void Usar(Personaje personaje);

    public void Actualizar(ObjetoMagico nuevoObjeto);
 
}
