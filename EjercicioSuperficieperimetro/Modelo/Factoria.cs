using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public class Factoria : IFactoriaMedibles
    {
        public IMedible dameFigura(EnumTipos tipo, int valor)
        {
            switch (tipo)
            {
                case EnumTipos.Cuadrado: return new Cuadrado() { lado=valor, Visor = new VisionadorConsola() };
                case EnumTipos.Circulo: return new Circulo() { radio=valor, Visor=new VisionadorConsola() }; 
                default: return null;
            }
        }
    }
}
