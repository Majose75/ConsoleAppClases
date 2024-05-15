using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Validador : IValidable
    {
        public bool isValid(IMilitable Elemento)
        {
            return (Elemento.Precio >= 0);
        }
    }
}