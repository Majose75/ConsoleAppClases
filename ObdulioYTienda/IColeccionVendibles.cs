using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObdulioYTienda
{
    public interface IColeccionVendibles
    {
        void Add(IVendible elemento);
        int NumordenadorsVendidos();
        void Listar();
        int OrdenadoesDeMasde125();
        int OrdenadorMasBarato();
        int OrdenadorMasCaro();
        double PrecioMedioOrdenador();
        double TotalImporteFacturado();
    }
}