using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Tarea;

interface IJuegoAdivinanza
{
    void Jugar(int numeroMaximo);

}


public class JuegoAdivinanza : IJuegoAdivinanza
{
    private int numeroIngresado;
    private readonly IInputLector inputLector;

    public JuegoAdivinanza(IInputLector inputLector)
    {
        this.inputLector = inputLector;
    }

    public void Jugar(int numeroMaximo)
    {

        Random random = new Random();
        int numeroAleatorio = random.Next(1, numeroMaximo  + 1); 
        int contador = 0;

        Console.WriteLine($"Ya elegí un número entre 1 y {numeroMaximo}, adivina:");

        do
        {
            this.numeroIngresado = Int32.Parse(inputLector.LeerEntrada());

            // int distancia = Math.Abs(numeroIngresado - numeroAleatorio);
            int distancia = numeroIngresado - numeroAleatorio;

            if(distancia == 0)
            {
                Console.WriteLine($" Lo lograste, El numero aleatorio era: {numeroAleatorio} y la cantidad de intentos fue {contador}");
            }
            else if (distancia > 40)
            {
                Console.WriteLine("Estás frío, vuelve a ingresar un numero.");
            }
            else if (distancia <= 40 &&  distancia >20)
            {
                Console.WriteLine("Estás tibio, vuelve a ingresar un numero.");
            }
            else if (distancia <=20 && distancia >=5)
            {
                Console.WriteLine("Estás caliente, vuelve a ingresar un numero.");
            }
            else
            {
                Console.WriteLine("Estás ardiendo, vuelve a ingresar un numero.");
            }

            contador++;



        } while (numeroIngresado != numeroAleatorio); 


    }





}
