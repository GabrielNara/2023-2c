using Clase4.POO.tarea.Logica.Interfaces;

namespace Clase4.POO.tarea.Logica.ObjetosMagicos;

public class ObjetoMagico : IItem
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Efecto { get; set; }

    public ObjetoMagico(int id,string nombre, string efecto)
    {
        Id = id;
        Nombre = nombre;
        Efecto = efecto;
    }

    public void Usar(Personaje personaje)
    {
        Console.WriteLine($"{personaje.Nombre} usa {Nombre} y recupera 10 puntos de vida.");
    }

    // Dentro de la clase ObjetoMagico
    public void Actualizar(ObjetoMagico nuevoObjeto)
    {
        
        Id = nuevoObjeto.Id;
        Nombre = nuevoObjeto.Nombre;
        Efecto = nuevoObjeto.Efecto;
    }


}