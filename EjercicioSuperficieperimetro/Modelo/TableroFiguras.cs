using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioSuperficieperimetro.Modelo
{
    public class TableroFiguras
    {
        double superficieTotal;
        double perimetroTotal;
        public List<IMedible> ListaFiguras = new();
        public void Add(IMedible elemento)
        {
            this.ListaFiguras.Add(elemento);
        }
        //Para saber el número Total de Figuras de la coleccion
        public int dameTotalFiguras()
        {
            return ListaFiguras.Count;
        }
        //Superficie total de todas ellas
        public double dameSuperficieTotal()
        {
            Parallel.ForEach(ListaFiguras, numero =>
            {
                superficieTotal += numero.dameSuperficie();
            });
            return superficieTotal;
        }
        public double damePerimetroTotal()
        {
            Parallel.ForEach(ListaFiguras, numero =>
            {
                perimetroTotal += numero.damePerimetro();
            });
            return perimetroTotal;
        }
        public IMedible dameFiguraMinima()  //Se coge la primera figura
        {
            IMedible FiguraMin = ListaFiguras[0];
            foreach (var figura in ListaFiguras)
            {
                if (figura.dameSuperficie() < FiguraMin.dameSuperficie())
                {
                    FiguraMin = figura;
                }
            }
            return FiguraMin;
        }
        public IMedible dameFiguraMaxima()  //Se coge la primera figura
        {
            IMedible FiguraMax = ListaFiguras[0];
            foreach (var figura in ListaFiguras)
            {
                if (figura.dameSuperficie() > FiguraMax.dameSuperficie())
                {
                    FiguraMax = figura;
                }
            }
            return FiguraMax;
        }

        public double mediaSuperficie()
        {
            return dameSuperficieTotal()/ListaFiguras.Count;
        }
        public double mediaPerimetro()
        {
            return damePerimetroTotal() / ListaFiguras.Count;
        }
    }


}


   





