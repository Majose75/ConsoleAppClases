using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public interface IFactoriaMedibles
    {
        IMedible dameFigura(EnumTipos tipo, int valor);
    }
}
