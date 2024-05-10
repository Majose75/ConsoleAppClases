using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public class Circulo : IMedible
    {
        public IVisionable Visor { get; set; }
        public int radio { get; set; }
        public double dameSuperficie()
            {
            return Math.PI * (radio * radio);            }
        public double damePerimetro()
            {
                return 2*(Math.PI) * radio;
        }
        public override string? ToString()
        {
            return Visor.DameCadena(this);
        }
    }
}
