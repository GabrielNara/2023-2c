using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase5.logica;

public interface IRectanguloService
{
    List<Rectangulo> Listar();

    void Agregar(Rectangulo rectangulo);
}

public class RectanguloService : IRectanguloService
{

    private static List<Rectangulo> _rectangulos { get; set; } = new();

    public void Agregar(Rectangulo rectangulo)
    {
        rectangulo.Id = (_rectangulos.Max(r => r?.Id) ?? 0) + 1;
        _rectangulos.Add(rectangulo);
    }

    public List<Rectangulo> Listar()
    {
        return _rectangulos;
    }
}
