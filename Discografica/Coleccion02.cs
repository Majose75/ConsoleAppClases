using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Coleccion02 : ListasReproduccion
    {
        public double TotalDineroListaDistribucion()
        {
            var sumaDinero = 0;
            foreach (var item in base.Reproducibles) 
            {
                if (item is ICanon)
                {
                    sumaDinero += (item as ICanon).Coste;
                }
            }
            
            return sumaDinero;
        }
    }
}