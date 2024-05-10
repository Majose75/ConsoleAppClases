using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    public interface IVisionable
    {
        string DameCadena(IAlquilable elemento);  // void porque el metodo no devuelve nada
    }
}
