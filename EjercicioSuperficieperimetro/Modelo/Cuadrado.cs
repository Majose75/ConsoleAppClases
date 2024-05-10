using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    
    public class Cuadrado : IMedible
    
    {
        public IVisionable Visor { get; set; }
        public int lado { get; set; }
        public double dameSuperficie()
        {
            return lado * lado;
        }
        public double damePerimetro()
        {
            return lado * 4;
        }
        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }

    }
}

