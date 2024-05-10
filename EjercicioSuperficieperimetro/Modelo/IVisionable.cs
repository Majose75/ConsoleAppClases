using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public interface IVisionable
    {
        string DameCadena(IMedible elemento);  // void porque el metodo no devuelve nada
    }
}
