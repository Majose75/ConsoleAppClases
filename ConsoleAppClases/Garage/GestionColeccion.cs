using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Clase que va gestionado la ccoleccion de elementos agregadps

namespace ConsoleAppClases.Garage
{
    public class GestionColeccion
    {
        private double total;
        private List<IAlquilable> alquileres = new ();  //Que se cree una coleccion de alquileres
        //creamos metodo para añadir
        void Add(IAlquilable elemento)
        {
            this.alquileres.Add(elemento);
            //this.DameTotal+=
        }

        ////Esto es una barbaridad  FOREACH solo en caso de secuencial la suma, para acumulados. ya que FOREACH utiliza un sólo núcleo.
        //double DameTotal()
        //{
        //    double total = 0;
        //    foreach (var item in alquileres)
        //    {
        //        total += item.DameCoste();
        //    }
        //    return total;
        //}
        double DameTotal()
        {
            Parallel.ForEach (alquileres, numero =>
            {
                total += numero.DameCoste();
            });
            return total;
        }

    }
}
