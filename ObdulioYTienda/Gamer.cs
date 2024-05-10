using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class Gamer : IVendible
    {
        public int Garantia { get; set; } = 4;
        public int Precio { get; set; } = 1000;

        public double TiempoMedio()
        {
            return Precio / Garantia;
        }

        public override string? ToString()
        {
            return $"Gamer,{Precio},{Garantia},{TiempoMedio()}";
        }
    }
}