﻿using Clase4.POO.tarea.Logica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.tarea.Logica.ObjetosMagicos
{
    public class Veneno : ObjetoMagico, IItem
    {
        public Veneno(int id,string nombre, string efecto) : base(id,nombre, efecto)
        {
        }
        public override void Usar(Personaje personaje)
        {
            Console.WriteLine($"{personaje.Nombre} usa {Nombre} y envenena, quita 10 puntos de vida.");
            // Lógica para aplicar el efecto al personaje
            personaje.HP -= 10;
            personaje.XP -= 5;
        }


        public void UsarVeneno(Personaje personaje)
        {
         
            // Lógica para aplicar el efecto al personaje
            personaje.HP -= 10;
            personaje.XP -= 5;
        }

    }
}
