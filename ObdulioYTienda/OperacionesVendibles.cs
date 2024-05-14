using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public class OperacionesVendibles : IColeccionVendibles
    {
        public List<IVendible> vendibles = new List<IVendible>();
        int numOrdenadores = 0;
        int numOrdenadoresMas125 = 0;
        int ordenadorMasBarato = Int32.MinValue;
        int ordenadorMasCaro= Int32.MaxValue;
        int totalPrecio= 0;
        
        public void Add(IVendible elemento)
        {
            vendibles.Add(elemento);
            numOrdenadores++;
            if(elemento.Precio > 125)
            {
                numOrdenadoresMas125++;
            }
            if(elemento.Precio > ordenadorMasCaro)
            {
                ordenadorMasCaro = elemento.Precio;
            }
            if(elemento.Precio < ordenadorMasBarato)
            {
                ordenadorMasBarato= elemento.Precio;
            }
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        public int NumordenadorsVendidos()
        {
            return numOrdenadores;
        }

        public int OrdenadoesDeMasde125()
        {
            return numOrdenadoresMas125; 
        }

        public int OrdenadorMasBarato()
        {
            return ordenadorMasBarato;
        }

        public int OrdenadorMasCaro()
        {
            return ordenadorMasCaro;
        }

        public double PrecioMedioOrdenador()
        {
            throw new NotImplementedException();
        }

        public double TotalImporteFacturado()
        {
            throw new NotImplementedException();
        }
    }
}