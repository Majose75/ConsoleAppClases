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

        public IVendible DameVendible(TipoOrdenador tipo, int valorPrecio, int valorGarantia)
        {
            IVendible vendible = null;
            switch (tipo)
            {
                case TipoOrdenador.Normal:  vendible= new Normal();
                case TipoOrdenador.Gamer:  vendible= new Normal();
                case TipoOrdenador.Lentorro: vendible= new Normal();

            }
            if (vendible != null)
            {
                valorPrecio = vendible.Precio;
                valorGarantia= vendible.Garantia;

            }
            
        }
    }
    
    
}


