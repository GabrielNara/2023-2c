using Clase4.POO.tarea.Logica.ObjetosMagicos;
using Clase4.POO.tarea.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.tarea.Test
{
    public class VenenoTest
    {
        [Fact]
        public void Usar_Ok()
        {
            // Arrange
            var pocionCuracion = new PocionCuracion("Poción de curación", "Recupera 10 puntos de vida.");
            var personaje = new Personaje("Gandalf", 100, 100);
            var vidaEsperada = 110;
            var experienciaEsperada = 105;

            // Act
            pocionCuracion.Usar(personaje);

            // Assert
            Assert.Equal(vidaEsperada, personaje.HP);
            Assert.Equal(experienciaEsperada, personaje.XP);
        }
    }
}
