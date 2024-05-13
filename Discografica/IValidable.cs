using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public interface IValidable
    {
        bool isValid(IReproducible ElementoReproducible);
    }
}