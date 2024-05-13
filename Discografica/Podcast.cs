using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Podcast : IReproducible
    {
        public int Duracion { get; set; } = 8;

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}