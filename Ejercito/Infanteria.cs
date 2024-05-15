using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercito
{
    public class Infanteria : IMilitable
    {
        public Infanteria(string nombre, double movimiento, double blindaje, double potencia, double precio)
        {
            Nombre = nombre;
            Movimiento = movimiento;
            PotenciaFuego = potencia;
            Blindaje = blindaje;
            Precio = precio;
        }

        public string Nombre { get; set; }
        public double Movimiento { get; set; }
        public double Blindaje { get; set; }
        public double PotenciaFuego { get; set; }
        public double Precio { get; set; }

        //public double CapacidadMilitar()
        //{
        //    return ((PotenciaFuego * Movimiento) / 2) / 100 - Blindaje;
        //}

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}