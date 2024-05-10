using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    internal class Furgoneta: IAlquilable
    {
        public string Identificador { get; set; }
        public double PrecioHora { get; set; } = 8;
        public double Tiempo { get; set; }

        public double DameCoste()
        {
            return PrecioHora * Tiempo;
        }

        public override string? ToString()
        {
            return $"Hola soy una Furgoneta con precioHora: {this.PrecioHora} y un coste de: {DameCoste()}";

        }

    }
}
