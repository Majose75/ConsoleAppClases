using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ELiminacionPlagas
{
    public interface IEmpleables
    {
        string Cargo { get; set; }
        double IngresoServicio();
    }
}