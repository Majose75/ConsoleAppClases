using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ListasReproduccion : IListasReproduccion
    {
        public LinkedList<IReproducible> Reproducibles = new LinkedList<IReproducible>();
        int numeroCanciones = 0;
        int sumaDuracion = 0;
     

        public void Add(IReproducible elemento)
        {
            if (elemento != null)
            {
                Reproducibles.AddFirst(elemento);
                numeroCanciones++;
                sumaDuracion += elemento.Duracion;
            }
        }

        public int TotalCanciones()
        {
            return numeroCanciones;
        }

        public int TotalDuracionLista()
        {
            return sumaDuracion;
        }
    }
}