using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IValidable
    {
        bool isValid(IMilitable Elemento);
    }
}