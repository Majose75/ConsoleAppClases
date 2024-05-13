using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Validador : IValidable
    {
        public bool isValid(IReproducible ElementoReproducible)
        {
            return ElementoReproducible.Duracion > 0;
        }
 
    }
}