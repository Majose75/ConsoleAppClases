using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public class VisionadorConsola : IVisionable
    {
        public string DameCadena(IMedible elemento)
        {
             return "Hola, soy un " + 
                elemento.GetType().Name + " y tengo una superficie de: " + elemento.dameSuperficie() +
                " y un Perimetro de: " + elemento.damePerimetro();
        }
    }
}
