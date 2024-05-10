using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class Normal : IVendible
    {
        public int Garantia { get; set; } = 3;
        public int Precio { get; set; } = 300;

        public double TiempoMedio()
        {
            return Precio / Garantia;
        }

        public override string? ToString()
        {
            return $"Normal,{Precio},{Garantia},{TiempoMedio()}";
        }
    }
}