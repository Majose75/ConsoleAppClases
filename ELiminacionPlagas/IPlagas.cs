using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELiminacionPlagas
{
    public interface IPlagas
    {
        string TipoPlaga { get; set; }
        double CantidadVeneno { get; set; }
        string TipoVeneno { get; set; }
    }
}