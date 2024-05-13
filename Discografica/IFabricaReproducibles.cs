using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public interface IFabricaReproducibles
    {
        IValidable Validador { get; set; }
        
        IReproducible DameReproducible(EnumTipoLista tipo, int duracion);
    }
}