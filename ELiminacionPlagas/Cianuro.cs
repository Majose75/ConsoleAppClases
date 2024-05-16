using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELiminacionPlagas
{
    public class Cianuro : IVeneno
    {
        public string Tipo { get; set; }
        public int Coste { get; set; } = 2;
    }
}