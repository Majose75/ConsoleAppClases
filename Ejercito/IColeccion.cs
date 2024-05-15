using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public interface IColeccion
    {
        bool Add(IMilitable elemento);
        int DameElementos();
        double DamePotenciaTotal();
        double DameBlindajeTotal();
        double DameMovimientoTotal();
        double TotalGastado();
        double CapacidadMilitar();
    }

   
}