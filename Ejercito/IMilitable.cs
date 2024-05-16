using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IMilitable
    {
        string Nombre { get; set; }
        double Movimiento { get; set; }
        double Blindaje { get; set; }
        double PotenciaFuego { get; set; }
        double Precio { get; set; }

        double CapacidadMilitar();
    }
}