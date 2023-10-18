using Clase6.EF.Data.EF;
using Clase6.EF.Logica;
using Clase6.EF.Test.Comun;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Clase6.EF.Test.Logica;

public class UbicacionServicioTest : TestBase
{
    public UbicacionServicioTest()
    {

    }

    
    [Fact]
    public void AgregarTest()
    {
        //Arrange
        Pw32cIslaTesoroContext context = ServiceProvider.GetService<Pw32cIslaTesoroContext>();
        IUbicacionServicio ubicacionServicio = new UbicacionServicio(context);

        var ubicacion = new Ubicacion()
        {
            Nombre = "Ituzaingo",
        };

        //Act
        ubicacionServicio.Agregar(ubicacion);

        //Assert
        var ubicacionEncontrada = context.Ubicacions.Find(ubicacion.Id);

        Assert.NotNull(ubicacionEncontrada);
        Assert.Equal(ubicacion.Nombre, ubicacionEncontrada.Nombre);
        Assert.Equal(1, context.Ubicacions.Count());
    } 

    [Fact]
    public void EliminarTest()
    {
        //Arrange
        Pw32cIslaTesoroContext context = ServiceProvider.GetService<Pw32cIslaTesoroContext>();
        IUbicacionServicio ubicacionServicio = new UbicacionServicio(context);

        var ubicacion = new Ubicacion()
        {
            Nombre = "Ituzaingo",
        };

        //Act
        ubicacionServicio.Agregar(ubicacion);

        //Assert
        ubicacionServicio.Eliminar(ubicacion.Id);

        Assert.Equal(context.Ubicacions.Count(),0);
    }

    /*
     [Fact]
    public void ModificacionTest()
    {

    } 
     */

    [Fact]
    public void ListadoTest()
    {
        //Arrange
        Pw32cIslaTesoroContext context = ServiceProvider.GetService<Pw32cIslaTesoroContext>();
        IUbicacionServicio ubicacionServicio = new UbicacionServicio(context);

        var ubicacion = new Ubicacion()
        {
            Nombre = "Ituzaingo",
        };

        var ubicacion1 = new Ubicacion()
        {
            Nombre = "Moron",
        };

        //Act
        ubicacionServicio.Agregar(ubicacion);
        ubicacionServicio.Agregar(ubicacion1);

        //Assert
        var ubicacionesEncontradas = context.Ubicacions.ToList<Ubicacion>;

        Assert.NotNull(ubicacionesEncontradas);
        Assert.Equal(2, context.Ubicacions.Count());
    }



}
