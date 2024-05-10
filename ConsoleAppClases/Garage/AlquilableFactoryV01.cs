using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClases.Garage
{
    internal class AlquilableFactoryV01: IFactoryAlquilable
    {
        public IAlquilable dameElemento(EnumTipos tipo, string id, double Tiempo)
        {
            switch (tipo) 
            { 
               case EnumTipos.Coche: return new Coche() { Identificador=id, PrecioHora=4,Tiempo=Tiempo};
               case EnumTipos.Furgoneta: return new Furgoneta() { Identificador = id, PrecioHora = 5, Tiempo = Tiempo };
                default: return null;
            }
        }
    }
}
