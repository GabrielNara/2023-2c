using Clase4.POO.tarea.Logica.Interfaces;

namespace Clase4.POO.tarea.Logica.ObjetosMagicos
{
    public class PocionCuracion : ObjetoMagico, IItem
    {
        //Aca hereda el constructor base
        public PocionCuracion(int id,string nombre, string efecto) : base(id,nombre, efecto)
        {
        }

        public void Usar(Personaje personaje)
        {
            Console.WriteLine($"{personaje.Nombre} usa {Nombre} y recupera 10 puntos de vida.");
            // Lógica para aplicar el efecto al personaje
            personaje.HP += 10;
            personaje.XP += 5;
        }
    }
}
