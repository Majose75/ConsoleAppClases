using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IFabrica
    {
        IValidable Validador { get; set; }

        IMilitable dameInstancia(EnumDivisiones divisiones, string nombre,double movimiento,double blindaje,double potencia,double precio);
    }
}