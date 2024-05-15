using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IFabricaOrdenadoresVendibles
    {
        IVendible DameVendible(TipoOrdenador tipo, int valorPrecio = 0, int valorGarantia = 0);
    }  
}