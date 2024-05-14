using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Anuncio : IReproducible, ICanon
    {
        public int Duracion { get; set; } /*= 5;*/
        public int Coste { get; set; } = 32;

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}