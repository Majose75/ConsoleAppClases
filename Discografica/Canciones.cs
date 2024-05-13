using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Canciones : IReproducible
    {
        public int Duracion { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}