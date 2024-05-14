using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class Validador : IValidador
    {
        public bool isValid(IVendible ElementoTienda)
        {
            return (ElementoTienda.Precio > 0 && ElementoTienda.Garantia > 0);
        }
    }
}