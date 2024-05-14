using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ValidadorCorea : Validador,IValidable
    {
        public bool isValid(IReproducible ElementoReproducible)
        {
            return base.isValid(ElementoReproducible) && ElementoReproducible.Duracion >=7 && ElementoReproducible.Duracion <= 15;
        }
    }
}