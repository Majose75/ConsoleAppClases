using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ListasReproduccion : IListasReproduccion
    {
        List<IReproducible> Reproducibles = new List<IReproducible>();
        int numeroCanciones = 0;
        int sumaDuracion = 0;
     

        public void Add(IReproducible elemento)
        {
            if (elemento != null)
            {
                Reproducibles.Add(elemento);
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