using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IVendible
    {
        int Garantia { get; set; }
        int Precio { get; set; }
        double TiempoMedio();
  
    }
}