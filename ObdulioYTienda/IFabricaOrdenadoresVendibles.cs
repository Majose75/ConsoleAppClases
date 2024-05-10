using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IFabricaOrdenadoresVendibles
    {
        IVendible dameVendible(TipoOrdenador tipo, int valorPrecio=0, int valorGarantia = 0);
         
    }
}