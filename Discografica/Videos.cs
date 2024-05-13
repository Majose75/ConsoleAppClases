using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Videos : IReproducible
    {
        public int Duracion { get; set; } = 20;

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}