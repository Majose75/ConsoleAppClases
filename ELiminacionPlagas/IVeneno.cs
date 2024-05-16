using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELiminacionPlagas
{
    public interface IVeneno
    {
        string Tipo { get; set; }
        int Coste { get; set; } 
    }
}