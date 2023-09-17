using Clase4.POO.tarea.Logica.Interfaces;

namespace Clase4.POO.tarea.Logica.ObjetosMagicos;

public class ObjetoMagico : IItem
{
    public int Id { get; set; }
    public string Nombre { get; }
    public string Efecto { get; }

    public ObjetoMagico(int id,string nombre, string efecto)
    {
        Id = id;
        Nombre = nombre;
        Efecto = efecto;
    }

    public void Usar(Personaje personaje)
    {
        Console.WriteLine($"{personaje.Nombre} usa {Nombre} y obtiene el efecto: {Efecto}");
    }
}