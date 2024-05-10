using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Modelo
{
    public class Vehiculo
    {
        public Vehiculo(double Potencia, int numRuedas, double Velocidad)
        {
            Potencia = potencia;
            numRuedas = numruedas;
            Velocidad = velocidad;
        }

        public Vehiculo(string? damePotencia, string? dameRuedas, string? dameVelocidad)
        {
        }

        public double potencia { get; set; }
        public int numruedas { get; set; }
        public double velocidad { get; set; }
         public double velocidadMedia()
        {
                return (potencia * velocidad) / numruedas;
        }
        public override string? ToString()
        {
            return $"El coche tiene una Potencia de: {this.potencia} y velocidad Media de: {velocidadMedia()}";
        }  

    }

  
}

// escribir todos los datos y clacular velocidad media potencia=velocidad/numruedas


