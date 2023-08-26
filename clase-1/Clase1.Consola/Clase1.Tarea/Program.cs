using Microsoft.Extensions.DependencyInjection;

namespace Clase1.Tarea;

class Program
{
    static void Main(string[] args)
    {
     
           var serviceProvider = new ServiceCollection()
                  .AddTransient<IInputLector, ConsolaInputLector>()
                  .AddScoped<IJuegoAdivinanza, JuegoAdivinanza>()
                  .BuildServiceProvider();

           var juego = serviceProvider.GetService<IJuegoAdivinanza>();

           Console.WriteLine("Ingresa el número máximo:");
           int numeroMaximo = Int32.Parse(Console.ReadLine());

           juego.Jugar(numeroMaximo); 


    


    }
}



