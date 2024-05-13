using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public interface IListasReproduccion
    {
        int TotalCanciones();
        int TotalDuracionLista();
        public void Add(IReproducible elemento);



    }
}