using ObdulioYTienda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class FabricaOrdenadores : IFabricaOrdenadoresVendibles
    {
        public IValidador Validador {get; set;}

        public IVendible dameVendible(TipoOrdenador tipo, int valorPrecio, int valorGarantia)
        {
            switch (tipo)
            {
                case TipoOrdenador.Normal:  return new Normal() { Precio= valorPrecio, Garantia=valorGarantia};
                case TipoOrdenador.Gamer:  return new Normal() { Precio = valorPrecio, Garantia = valorGarantia };
                case TipoOrdenador.Lentorro: return new Normal() { Precio = valorPrecio, Garantia = valorGarantia };

            }
            
        }
    }
    
    
}


