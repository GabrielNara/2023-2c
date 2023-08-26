using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Tarea;

public interface IInputLector
{
    string LeerEntrada();
    void Clear();
}

public class ConsolaInputLector : IInputLector
{
    public string LeerEntrada()
    {
        return Console.ReadLine();
    }
    public void Clear()
    {
        Console.Clear();
    }
}
