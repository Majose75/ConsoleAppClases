using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Fabrica01 : IFabricaReproducibles
    {
        public IValidable Validador {get;set;}


        public IReproducible DameReproducible(EnumTipoLista tipo, int duracion = 0)
        {
            IReproducible reproducible = null; //Le asignamos un valor al elemento
            switch (tipo)
            {
                case EnumTipoLista.Canciones: reproducible = new Canciones(); break;
                case EnumTipoLista.Podcast: reproducible = new Podcast(); break;
                case EnumTipoLista.Videos: reproducible = new Videos(); break;
                case EnumTipoLista.Anuncio: reproducible = new Anuncio(); break;
            }
            if (duracion != 0)
            {
                reproducible.Duracion = duracion;
            }
            if ((reproducible != null) && Validador.isValid(reproducible)){
                return reproducible;
            }
            else { return null; }
        }
    }
}