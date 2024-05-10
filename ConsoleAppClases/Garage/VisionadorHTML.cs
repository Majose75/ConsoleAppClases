using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    public class VisionadorHTML : IVisionable
    {
        public string DameCadena(IAlquilable elemento)
        {
            //Console.WriteLine($"Hola, soy un {elemento.GetType()} y tengo un ide de: {elemento.Identificador}");
            return "<b>Hola, soy un </b>" + 
                elemento.GetType() + " y tengo un id de: " + elemento.Identificador +
                " mi precio hora es: " + elemento.PrecioHora + ", he estado: " + 
                elemento.Tiempo + " y he generado " + elemento.DameCoste();
        }
    }
}
